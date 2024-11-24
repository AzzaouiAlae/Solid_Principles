using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _04_Logging_Service_SRP
{
    public class FileLoggingService
    {
        public static void LogToFile(string message)
        {
            Console.WriteLine($"Logging to file: {message}");
        }
    }
}
