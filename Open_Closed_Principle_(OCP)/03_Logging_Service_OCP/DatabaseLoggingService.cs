﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _03_Logging_Service_OCP
{
    public class DatabaseLoggingService: ILogging
    {
        public void Log(string message)
        {
            Console.WriteLine($"Logging to Database: {message}");
        }
    }
}
