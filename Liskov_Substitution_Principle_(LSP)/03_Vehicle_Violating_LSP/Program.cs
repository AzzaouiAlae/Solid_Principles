namespace _03_Vehicle_Violating_LSP
{
    public class Vehicle
    {
        public virtual void StartEngine()
        {
            Console.WriteLine("Starting engine...");
        }
        public virtual void Drive()
        {
            Console.WriteLine("Driving...");
        }

    }
    public class Car : Vehicle
    {
        public override void StartEngine()
        {
            Console.WriteLine("Car starting engine...");
        }
        public override void Drive()
        {
            Console.WriteLine("car driving...");
        }
    }
    public class Bicycle : Vehicle
    {
        public override void StartEngine()
        {
            throw new NotSupportedException();
        }
        public override void Drive()
        {
            Console.WriteLine("Bike riding");
        }
    }
    internal class Program
    {
        static void Main(string[] args)
        {
            Vehicle car = new Car();
            car.StartEngine();
            car.Drive();

            Vehicle bicycle = new Bicycle();
            //bicycle.StartEngine();
            bicycle.Drive();
        }
    }
}
