namespace _01_Bird_Violating_LSP
{
    public class Bird
    {
        public virtual void Eat()
        {
            Console.WriteLine("Eating...");
        }
        public virtual void Fly()
        {
            Console.WriteLine("Flying...");
        }
    }
    public class Eagle: Bird
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
        public override void Fly()
        {
            throw new NotSupportedException();
        }
    }
    internal class Program
    {
        static void Main(string[] args)
        {
            Bird eagle = new Eagle();
            eagle.Eat();
            eagle.Fly();

            Bird ostrich = new Ostrich();        
            ostrich.Eat();
            //ostrich.Fly();
        }
    }
}
