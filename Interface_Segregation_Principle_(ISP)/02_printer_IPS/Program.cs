namespace _02_printer_IPS
{
    public interface IPrint
    {
        void Print(string content);
    }
    public interface IScan
    {
        void Scan();
    }
    public interface IFax
    {
        void Fax();
    }
    public interface ICopy
    {
        void Copy();
    }
    public class BasicPrinter : IPrint
    {
        public void Print(string content)
        {
            Console.WriteLine(content);
        }
    }
    public class AdvancePrinter : IPrint, IScan, IFax, ICopy
    {
        public void Copy()
        {
            Console.WriteLine("Copying...");
        }

        public void Fax()
        {
            Console.WriteLine("Send Fax");
        }

        public void Print(string content)
        {
            Console.WriteLine(content);
        }

        public void Scan()
        {
            Console.WriteLine("Scaning");
        }
    }
    internal class Program
    {
        static void Main(string[] args)
        {
            BasicPrinter printer = new BasicPrinter();
            printer.Print("Hello");

            AdvancePrinter advancePrinter = new AdvancePrinter();
            advancePrinter.Print("welcome");
            advancePrinter.Fax();
            advancePrinter.Scan();
            advancePrinter.Copy();
        }
    }
}
