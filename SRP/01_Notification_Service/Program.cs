namespace _01_Notification_Service
{
    public class NotificqtionService
    {
        public enum enNotificationType { Email, SMS, Fax}
        public void SendNotification(string to, string message, enNotificationType notificationType)
        {
            if(notificationType == enNotificationType.Email)         
                SendEmail(to, message);            
            else if(notificationType == enNotificationType.SMS)
               SendSMS(to, message);
            else if(notificationType==enNotificationType.Fax)
                SendFax(to, message);
        }
        void SendEmail(string to, string message)
        {
            Console.WriteLine($"Sending email: {message} to: {to}");
        }
        void SendSMS(string to, string message)
        {
            Console.WriteLine($"Sending SMS: {message} to: {to}");
        }
        void SendFax(string to, string message)
        {
            Console.WriteLine($"Sending fax: {message} to: {to}");
        }
    }

    public class Program
    {
        static void Main(string[] args)
        {
            NotificqtionService service = new NotificqtionService();
            service.SendNotification("alae", "Hello", NotificqtionService.enNotificationType.Email);
            service.SendNotification("alae", "Hello", NotificqtionService.enNotificationType.SMS);
            service.SendNotification("alae", "Hello", NotificqtionService.enNotificationType.Fax);
        }
    }
}
