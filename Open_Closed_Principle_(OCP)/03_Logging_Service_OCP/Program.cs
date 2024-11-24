namespace _03_Logging_Service_OCP
{
    public class LoggingService
    {
        ILogging _logging;
        public LoggingService(ILogging logging)
        { 
            _logging = logging; 
        }
        public void Log(string message)
        {
            _logging.Log(message);
        }
    }
    internal class Program
    {
        static void Main(string[] args)
        {
            LoggingService log = new (new DatabaseLoggingService());
            log.Log("Logging service is working\n");

            log = new(new EventLoggingService());
            log.Log("Logging service is working\n");

            log = new(new FileLoggingService());
            log.Log("Logging service is working\n");
        }
    }
}
