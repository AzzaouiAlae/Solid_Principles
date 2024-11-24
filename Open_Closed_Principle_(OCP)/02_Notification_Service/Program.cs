
using _02_Notification_Service;

namespace _02_Notification_Service_OCP
{
    public class NotificationService
    {
        INotification _notification;
        public NotificationService(INotification notification)
        {
            _notification = notification;
        }
        public void Send(string to, string message)
        {
            _notification.Send(to, message);
        }
    }
    internal class Program
    {
        static void Main(string[] args)
        {
            NotificationService Service = new(new EmailService());
            Service.Send("alae", "Hello\n");

            Service = new(new FaxService());
            Service.Send("alae", "Hello\n");

            Service = new(new SMSService());
            Service.Send("alae", "Hello\n");

            Service = new(new TelegramService());
            Service.Send("alae", "Hello\n");

            Service = new(new SnappChatService());
            Service.Send("alae", "Hello\n");

            Service = new(new TikTokService());
            Service.Send("alae", "Hello\n");
        }
    }
}
