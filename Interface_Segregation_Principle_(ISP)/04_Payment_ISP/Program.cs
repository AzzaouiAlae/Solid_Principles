namespace _04_Payment_ISP
{
    public interface ICreaitCardPayment
    {
        void PayWithCreaitCard();
    }
    public interface IPayPalPayment
    {
        void PayWithPayPal();
    }
    public interface IBitcoinPayment
    {
        void PayWithBitcoin();
    }
    public class CreaditCartPayment : ICreaitCardPayment
    {
        public void PayWithCreaitCard()
        {
            Console.WriteLine("Payment with creadit card...\n");
        }
    }
    public class PayPalPayment : IPayPalPayment
    {
        public void PayWithPayPal()
        {
            Console.WriteLine("Payment with PayPal...\n");
        }
    }
    public class BitconPayment : IBitcoinPayment
    {
        public void PayWithBitcoin()
        {
            Console.WriteLine("Payment with Bitcoin...\n");
        }
    }
    public class AllPayment : ICreaitCardPayment, IPayPalPayment, IBitcoinPayment
    {
        public void PayWithBitcoin()
        {
            Console.WriteLine("Payment with Bitcoin...\n");
        }

        public void PayWithCreaitCard()
        {
            Console.WriteLine("Payment with creadit card...\n");
        }

        public void PayWithPayPal()
        {
            Console.WriteLine("Payment with PayPal...\n");
        }
    }

    internal class Program
    {
        static void Main(string[] args)
        {
            BitconPayment payment = new BitconPayment();
            payment.PayWithBitcoin();

            CreaditCartPayment creaditCartPayment = new CreaditCartPayment();
            creaditCartPayment.PayWithCreaitCard();

            PayPalPayment payPalPayment = new PayPalPayment();
            payPalPayment.PayWithPayPal();

            AllPayment allPayment = new AllPayment();
            allPayment.PayWithBitcoin();
            allPayment.PayWithPayPal();
            allPayment.PayWithCreaitCard();
        }
    }
}
