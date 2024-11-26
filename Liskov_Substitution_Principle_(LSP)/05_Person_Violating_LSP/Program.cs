namespace _05_Person_Violating_LSP
{
    public class Person
    {
        public virtual void PaySalary()
        {
            Console.WriteLine("Paying salary to a person...");
        }
        public virtual void SendEmail()
        {
            Console.WriteLine("Sending email to a Person...");
        }
    }
    public class Employee : Person
    {
        public override void PaySalary()
        {
            Console.WriteLine("Paying salary to an employee...");
        }
        public override void SendEmail()
        {
            Console.WriteLine("Sending email to an employee...");
        }
    }
    public class  Manager : Employee
    {
        public override void PaySalary()
        {
            Console.WriteLine("Paying salary to a Manager...");
        }
        public override void SendEmail()
        {
            Console.WriteLine("Sending email to a Manager...");
        }
    }
    public class Student : Person
    {
        public override void PaySalary()
        {
            throw new NotSupportedException();
        }
        public override void SendEmail()
        {
            Console.WriteLine("Sending email to a student...");
        }
    }
    internal class Program
    {
        static void Main(string[] args)
        {
            Person person = new Person();
            person.SendEmail();
            person.PaySalary();

            Employee employee = new Employee();
            employee.PaySalary();
            employee.SendEmail();

            Manager manager = new Manager();
            manager.PaySalary();
            manager.SendEmail();

            Student student = new Student();
            student.SendEmail();
            //student.PaySalary();
        }
    }
}
