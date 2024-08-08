namespace Adapter.Notification
{
    public interface ISmsSender
    {
        void SendSMS(string phoneNumber, string message);
    }
}
