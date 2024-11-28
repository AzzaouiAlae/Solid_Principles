namespace _01_print_violiting_IPS
{
    public interface IPrinter
    {
        void Print(string content);
        void Scan();
        void Fax();            
    }
    public class BasicPrinter : IPrinter
    {
        public void Print(string content)
        {
            Console.WriteLine(content);
        }
        public void Scan()
        {
            throw new NotSupportedException();
        }
        public void Fax()
        {
            throw new NotSupportedException();
        }
    }
    internal class Program
    {
        static void Main(string[] args)
        {
            IPrinter printer = new BasicPrinter();
            printer.Print("Hello");
            //printer.Fax();
            //printer.Scan();
        }
    }
}
