namespace _03_Payment_Violating_ISP
{
    public interface IPayment
    {
        void PayWithCreaitCard();
        void PayWithPayPal();
        void PayWithBitcoin();
    }
    public class CreaditCartPayment : IPayment
    {
        public void PayWithBitcoin()
        {
            throw new NotImplementedException();
        }

        public void PayWithCreaitCard()
        {
            Console.WriteLine("Payment with creadit card...\n");
        }

        public void PayWithPayPal()
        {
            throw new NotImplementedException();
        }
    }
    public class PayPalPayment : IPayment
    {
        public void PayWithBitcoin()
        {
            throw new NotImplementedException();
        }

        public void PayWithCreaitCard()
        {
            throw new NotImplementedException();
        }

        public void PayWithPayPal()
        {
            Console.WriteLine("Payment with PayPal...\n");
        }
    }
    public class BitconPayment : IPayment
    {
        public void PayWithBitcoin()
        {
            Console.WriteLine("Payment with Bitcoin...\n");
        }

        public void PayWithCreaitCard()
        {
            throw new NotImplementedException();
        }

        public void PayWithPayPal()
        {
            throw new NotImplementedException();
        }
    }
    internal class Program
    {
        static void Main(string[] args)
        {
            BitconPayment payment = new BitconPayment();
            payment.PayWithBitcoin();
            //payment.PayWithCreaitCard();
            //payment.PayWithPayPal();

            CreaditCartPayment creaditCartPayment = new CreaditCartPayment();
            //creaditCartPayment.PayWithBitcoin();
            //creaditCartPayment.PayWithPayPal();
            creaditCartPayment.PayWithCreaitCard();

            PayPalPayment payPalPayment = new PayPalPayment();
            //payPalPayment.PayWithBitcoin();
            //payPalPayment.PayWithCreaitCard();
            payPalPayment.PayWithPayPal();
        }
    }
}
