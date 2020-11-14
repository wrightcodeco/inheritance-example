using System;
using TestApplication.Services.Webhooks.ProductInStock;
using TestApplication.Services.Webhooks.ProductOnSale;
using TestApplication.Services.Webhooks.ShippingUpdate;

namespace TestApplication.Services.Webhooks
{
    public class WebhookHandlerFactory : IWebhookHandlerFactory
    {
        private readonly IProductInStockWebhookHandler _productInStockWebhookHandler;
        private readonly IProductOnSaleWebhookHandler _productOnSaleWebhookHandler;
        private readonly IShippingUpdateWebhookHandler _shippingUpdateWebhookHandler;

        public IWebhookHandler Create(string type)
        {
            type = (type ?? string.Empty).ToUpper();

            switch (type)
            {
                case "PRODUCT_IN_STOCK":
                    return _productInStockWebhookHandler;
                case "PRODUCT_ON_SALE":
                    return _productOnSaleWebhookHandler;
                case "SHIPPING_UPDATE":
                    return _shippingUpdateWebhookHandler;
                default:
                    throw new NotImplementedException($"No handler defined for webhook type: {type}.");
            }
        }
    }
}