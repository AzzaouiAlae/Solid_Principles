namespace Interface_Inherit_Other_Interfaces
{
    public interface ICall
    {
        void MakeCall();
    }
    public interface IPhoto
    {
        void TakePhoto();
    }
    public  interface IEmail
    {
        void SendEmail();
    }
    public interface IGPS
    {
        void UseGPS();
    }
    public interface ISmartPhone: ICall, IPhoto, IEmail, IGPS
    {

    }
    public class SmartPhone : ISmartPhone
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
    public class Computer : IEmail
    {
        public void SendEmail()
        {
            Console.WriteLine("Sending Email...");
        }
    }
    public class Camera : IPhoto
    {
        public void TakePhoto()
        {
            Console.WriteLine("Taking a Photo...");
        }
    }
    public class AdvenceCamera : IPhoto, IEmail
    {
        public void SendEmail()
        {
            Console.WriteLine("Sending Email...");
        }

        public void TakePhoto()
        {
            Console.WriteLine("Taking a Photo...");
        }
    }
    internal class Program 
    {
        static void Main(string[] args)
        {
            Console.WriteLine("SmartPhone");
            SmartPhone device= new SmartPhone();
            device.MakeCall();
            device.SendEmail();
            device.TakePhoto();
            device.UseGPS();

            Console.WriteLine("\nComputer");
            Computer device1 = new Computer();
            device1.SendEmail();

            Console.WriteLine("\nCamera");
            Camera dev2 = new Camera();
            dev2.TakePhoto();

            Console.WriteLine("\nAdvenceCamera");
            AdvenceCamera dev3 = new();
            dev3.TakePhoto();
            dev3.SendEmail();
        }
    }
}
