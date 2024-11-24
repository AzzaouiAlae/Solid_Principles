namespace _04_Logging_Service_SRP
{
    public class LoggingService
    {
        public enum enLoggingType { ToFile, ToEventLog, ToDatabase }
        public void Log(string message, enLoggingType enLoggingType)
        {
            switch (enLoggingType)
            {
                case enLoggingType.ToFile:
                    FileLoggingService.LogToFile(message);
                    break;
                case enLoggingType.ToEventLog:
                    EventLoggingService.LogToEventLog(message);
                    break;
                case enLoggingType.ToDatabase:
                    DatabaseLoggingService.LogToDatabase(message);
                    break;
            }
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
