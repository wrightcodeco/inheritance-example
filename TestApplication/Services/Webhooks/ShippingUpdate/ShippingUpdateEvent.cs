namespace TestApplication.Services.Webhooks.ShippingUpdate
{
    public class ShippingUpdateEvent
    {
        public string Message { get; set; }

        public string OrderNumber { get; set; }
    }
}