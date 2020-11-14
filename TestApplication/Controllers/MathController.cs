using Microsoft.AspNetCore.Mvc;
using System.Web;
using TestApplication.Services.Math;

namespace TestApplication.Controllers
{
    [Route("[controller]")]
    [ApiController]
    public class MathController : ControllerBase
    {
        private readonly IGeometryService _geometryService;

        public MathController(IGeometryService geometryServiceq)
        {
            _geometryService = geometryServiceq;
        }

        [HttpGet]
        public IActionResult Pythagorean([FromQuery] string a, [FromQuery] string b)
        {
            if (string.IsNullOrWhiteSpace(a))
            {
                return BadRequest("a is required.");
            }

            if (string.IsNullOrWhiteSpace(b))
            {
                return BadRequest("b is required.");
            }

            if (double.TryParse(HttpUtility.UrlDecode(a), out double aDouble) == false)
            {
                return BadRequest("a must be a valid double.");
            }

            if (double.TryParse(HttpUtility.UrlDecode(b), out double bDouble) == false)
            {
                return BadRequest("b must be a valid double.");
            }

            return Ok(_geometryService.Hypotense(aDouble, bDouble));
        }
    }
}
