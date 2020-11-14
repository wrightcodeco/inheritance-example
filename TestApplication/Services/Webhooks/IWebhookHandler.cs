namespace TestApplication.Services.Webhooks
{
    public interface IWebhookHandler
    {
        string Process(string webhookBody);
    }
}