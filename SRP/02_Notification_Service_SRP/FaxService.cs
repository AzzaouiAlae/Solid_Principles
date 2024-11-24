using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _02_Notification_Service_SRP
{
    public class FaxService
    {
        public static void SendFax(string to, string message)
        {
            Console.WriteLine($"Sending Fax to {to}: {message}");
        }
    }
}
