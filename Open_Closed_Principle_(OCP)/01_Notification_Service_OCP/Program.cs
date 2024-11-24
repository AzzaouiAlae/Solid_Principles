
namespace _02_Notification_Service_OCP
{
    public class NotificationService
    {
        public enum enNotificationType { Email, SMS, Fax, Telegram, Whatsapp }
        public void SendNotification(string to, string message, enNotificationType notificationType)
        {
            if (notificationType == enNotificationType.Email)
            {
                EmailService.SendEmail(to, message);
            }
            if (notificationType == enNotificationType.SMS)
            {
                SMSService.SendSMS(to, message);
            }
            if (notificationType == enNotificationType.Fax)
            {
                FaxService.SendFax(to, message);
            }
            if(notificationType == enNotificationType.Telegram)
            {
                TelegramService.SendTelegram(to, message);
            }
            if(notificationType == enNotificationType.Whatsapp)
            {
                WhatsappService.SendWhatsapp(to, message);
            }
        }
    }
    internal class Program
    {
        static void Main(string[] args)
        {
            NotificationService service = new NotificationService();
            service.SendNotification("alae", "Hello", NotificationService.enNotificationType.Email);
            service.SendNotification("alae", "Hello", NotificationService.enNotificationType.SMS);
            service.SendNotification("alae", "Hello", NotificationService.enNotificationType.Fax);
            service.SendNotification("alae", "Hello", NotificationService.enNotificationType.Telegram);
            service.SendNotification("alae", "Hello", NotificationService.enNotificationType.Whatsapp);
        }
    }
}
