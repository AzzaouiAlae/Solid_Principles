namespace _05_Device_Violating_ISP
{
    public interface IDevice
    {
        void MakeCall();
        void TakePhoto();
        void SendEmail();
        void UseGPS();
    }
    public class SmartPhone : IDevice 
    {
        public void MakeCall()
        {
            Console.WriteLine("Making a call...");
        }

        public void SendEmail()
        {
            Console.WriteLine("Sending Email...");
        }

        public void TakePhoto()
        {
            Console.WriteLine("Taking a Photo...");
        }

        public void UseGPS()
        {
            Console.WriteLine("GPS...");
        }
    }
    public class Computer : IDevice
    {
        public void MakeCall()
        {
            throw new NotImplementedException();
        }

        public void SendEmail()
        {
            Console.WriteLine("Sending Email...");
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
            IDevice device= new SmartPhone();
            device.MakeCall();
            device.SendEmail();
            device.TakePhoto();
            device.UseGPS();

            IDevice device1 = new Computer();
            device1.MakeCall();
            device1.TakePhoto();
            device1.SendEmail();
            device1.UseGPS();
        }
    }
}
