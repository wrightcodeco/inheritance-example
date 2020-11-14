using System.Text.Json;

namespace TestApplication.Services.Webhooks.ShippingUpdate
{
    public class ShippingUpdateWebhookHandler : IShippingUpdateWebhookHandler
    {
        public string Process(string webhookBody)
        {
            var shippingUpdateEvent = JsonSerializer.Deserialize<ShippingUpdateEvent>(webhookBody);

            return $"Your shipment for order {shippingUpdateEvent.OrderNumber} has a new update: {shippingUpdateEvent.Message}";
        }
    }
}