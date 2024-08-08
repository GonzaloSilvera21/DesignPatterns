namespace Adapter.Notification
{
    public class EmailSender : IEmailSender
    {
        public void SendEmail(string recipient, string subject, string body)
        {
            Console.WriteLine($"Enviado correo a {recipient} con asunto '{subject}' y cuerpo '{body}'");
        }
    }
}
