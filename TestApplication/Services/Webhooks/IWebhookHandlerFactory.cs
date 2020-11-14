namespace TestApplication.Services.Webhooks
{
    public interface IWebhookHandlerFactory
    {
        IWebhookHandler Create(string type);
    }
}