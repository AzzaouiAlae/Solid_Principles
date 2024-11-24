using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _04_Logging_Service_SRP
{
    public class DatabaseLoggingService
    {
        public static void LogToDatabase(string message)
        {
            Console.WriteLine($"Logging to Database: {message}");
        }
    }
}
