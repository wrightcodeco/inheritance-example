using System.Text.Json;

namespace TestApplication.Services.Webhooks.ProductOnSale
{
    public class ProductOnSaleWebhookHandler : IProductOnSaleWebhookHandler
    {
        public string Process(string webhookBody)
        {
            var productOnSaleEvent = JsonSerializer.Deserialize<ProductOnSaleEvent>(webhookBody);

            return $"The {productOnSaleEvent.ProductName} is on sale for {productOnSaleEvent.SalePercentage:P}. Sales ends {productOnSaleEvent.SaleEndDate}.";
        }
    }
}