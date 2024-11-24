namespace _04_Payment_Service_OCP
{
    public class PaymentService
    {
        IPaymentService _paymentService;
        public PaymentService(IPaymentService paymentService)
        {
            _paymentService = paymentService;
        }
        public void Pay(decimal amount)
        {
            _paymentService.Pay(amount);
        }
    }
    internal class Program
    {
        static void Main(string[] args)
        {
            PaymentService PayService = new(new BankTransferPaymentService());
            PayService.Pay(100);

            PayService = new(new BitcoinPaymentService());
            PayService.Pay(100);

            PayService = new(new CreditcardPaymentService());
            PayService.Pay(100);

            PayService = new(new PayPalPaymentService());
            PayService.Pay(100);
        }
    }
}
