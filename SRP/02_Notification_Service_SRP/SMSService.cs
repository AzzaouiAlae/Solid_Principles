using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _02_Notification_Service_SRP
{
    public class SMSService
    {
        public static void SendSMS(string to, string message)
        {
            Console.WriteLine($"Sending SMS to {to}: {message}");
        }
    }
}
