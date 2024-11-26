namespace _02_Bird_LSP
{
    public class Bird
    {
        public virtual void Eat()
        {
            Console.WriteLine("Eating...");
        }
        
    }
    public class FlyingBird : Bird
    {
        public virtual void Fly()
        {
            Console.WriteLine("Flying...");
        }
    }
    public class Eagle : FlyingBird
    {
        public override void Eat()
        {
            Console.WriteLine("Eagle Eating...");
        }
        public override void Fly()
        {
            Console.WriteLine("Eagle flying");
        }
    }
    public class Ostrich : Bird
    {
        public override void Eat()
        {
            Console.WriteLine("Ostrich Eating...");
        }
    }
    internal class Program
    {
        static void Main(string[] args)
        {
            FlyingBird eagle = new Eagle();
            eagle.Eat();
            eagle.Fly();

            Bird ostrich = new Ostrich();
            ostrich.Eat();
        }
    }
}
