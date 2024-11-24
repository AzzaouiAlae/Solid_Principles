using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _02_Notification_Service_OCP
{
    public class WhatsappService: INotification
    {
        public void Send(string to, string message)
        {
            Console.WriteLine($"Sending Whatsapp to {to}: {message}");
        }
    }
}
