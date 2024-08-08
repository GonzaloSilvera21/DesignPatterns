namespace Adapter.Notification
{
    public class SmsAdapter : INotificationService
    {
        private readonly ISmsSender _smsSender;

        public SmsAdapter(ISmsSender smsSender) => _smsSender = smsSender;

        public void SendNotification(string message) => _smsSender.SendSMS("123456789", message);
    }
}
