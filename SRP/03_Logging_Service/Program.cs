namespace _03_Logging_Service
{
    public class LoggingService
    {
        public enum enLoggingType { ToFile, ToEventLog, ToDatabase }
        public void Log(string message, enLoggingType enLoggingType)
        {
            switch (enLoggingType)
            {
                case enLoggingType.ToFile:
                    LogToFile(message);
                    break;
                case enLoggingType.ToEventLog:
                    LogToEventLog(message);
                    break;
                case enLoggingType.ToDatabase:
                    LogToDatabase(message);
                    break;
            }
        }
        void LogToFile(string message)
        {
            Console.WriteLine($"Logging to file: {message}");
        }
        void LogToEventLog(string message) 
        {
            Console.WriteLine($"Logging to event log: {message}");
        }
        void LogToDatabase(string message)
        {
            Console.WriteLine($"Logging to Database: {message}");
        }
    }

    internal class Program
    {
        static void Main(string[] args)
        {
            LoggingService log = new LoggingService();
            log.Log("logging service is working", LoggingService.enLoggingType.ToFile);
            log.Log("logging service is working", LoggingService.enLoggingType.ToEventLog);
            log.Log("logging service is working", LoggingService.enLoggingType.ToDatabase);
        }
    }
}
