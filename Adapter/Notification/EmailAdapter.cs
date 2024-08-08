namespace Adapter.Notification
{
    public class EmailAdapter : INotificationService
    {
        private readonly IEmailSender _emailSender;

        public EmailAdapter(IEmailSender emailSender)  => _emailSender = emailSender;

        public void SendNotification(string message) => _emailSender.SendEmail("mailito@mail.com", "MAILITO", message);
    }
}
