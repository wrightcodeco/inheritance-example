using System.Text.Json;

namespace TestApplication.Services.Webhooks.ProductInStock
{
    public class ProductInStockWebhookHandler : IProductInStockWebhookHandler
    {
        public string Process(string webhookBody)
        {
            var productInStockEvent = JsonSerializer.Deserialize<ProductInStockEvent>(webhookBody);

            return $"{productInStockEvent.ProductName} is now back in stock. Get yours now.";
        }
    }
}