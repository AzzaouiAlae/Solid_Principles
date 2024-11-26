namespace _04_Vehicle_LSP
{
    public class Vehicle
    {    
        public virtual void Drive()
        {
            Console.WriteLine("Driving...");
        }
    }
    public class MotorVehicle: Vehicle
    {
        public virtual void StartEngine()
        {
            Console.WriteLine("Starting engine...");
        }
    }
    public class Car : MotorVehicle
    {
        public override void StartEngine()
        {
            Console.WriteLine("Car starting engine...");
        }
        public override void Drive()
        {
            Console.WriteLine("driving a car...");
        }
    }
    public class Bicycle : Vehicle
    {
        public override void Drive()
        {
            Console.WriteLine("riding a Bike");
        }
    }
    internal class Program
    {
        static void Main(string[] args)
        {
            MotorVehicle car = new Car();
            car.StartEngine();
            car.Drive();

            Vehicle bicycle = new Bicycle();          
            bicycle.Drive();
        }
    }
}
