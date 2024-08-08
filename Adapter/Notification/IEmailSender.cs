namespace Adapter.Notification
{
    public interface IEmailSender
    {
        void SendEmail(string recipient, string subject, string body);
    }
}
