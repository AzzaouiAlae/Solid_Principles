using _02_Notification_Service_OCP;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _02_Notification_Service
{
    internal class TikTokService : INotification
    {
        public void Send(string to, string message)
        {
            Console.WriteLine($"Sending TikTok message to {to}: {message}");
        }
    }
}
