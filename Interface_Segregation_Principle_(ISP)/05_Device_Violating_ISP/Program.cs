namespace _05_Device_Violating_ISP
{
    public interface IDevice
    {
        void MakeCall();
        void TakePhoto();
        void SendEmail();
        void UseGPS();
        
    }
    public class SnartPhone : IDevice 
    {
        public void MakeCall()
        {

        }

        public void SendEmail()
        {
            throw new NotImplementedException();
        }

        public void TakePhoto()
        {
            throw new NotImplementedException();
        }

        public void UseGPS()
        {
            throw new NotImplementedException();
        }
    }

    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Hello, World!");
        }
    }
}
