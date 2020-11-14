using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Primitives;
using System.Linq;
using TestApplication.Services.Webhooks;

namespace TestApplication.Controllers
{
    [Route("[controller]")]
    [ApiController]
    public class WebhookController : ControllerBase
    {
        private readonly IWebhookHandlerFactory _webhookHandlerFactory;

        public WebhookController(IWebhookHandlerFactory webhookHandlerFactory)
        {
            _webhookHandlerFactory = webhookHandlerFactory;
        }

        [HttpPost]
        public IActionResult ReceiveWebhook([FromBody] string dataToProcess)
        {
            if (Request.Headers.TryGetValue("EVENT_TYPE", out StringValues eventHeader) == false)
            {
                return BadRequest("EVENT_TYPE header is required.");
            }

            var eventHeaderValue = eventHeader.Where(s => string.IsNullOrWhiteSpace(s) == false)
                                              .FirstOrDefault();

            if (string.IsNullOrWhiteSpace(eventHeaderValue) == false)
            {
                return BadRequest("EVENT_TYPE header is required.");
            }

            var webhookHandler = _webhookHandlerFactory.Create(eventHeaderValue);

            var response = webhookHandler.Process(dataToProcess);

            return Ok(response);
        }
    }
}
