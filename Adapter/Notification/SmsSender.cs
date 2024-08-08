namespace Adapter.Notification
{
    public class SmsSender : ISmsSender
    {
        public void SendSMS(string phoneNumber, string message)
        {
            Console.WriteLine($"Enviando SMS a {phoneNumber} con mensaje '{message}'");
        }
    }
}
