using System;

namespace Abstract
{
    /* 
    abstract method is declared inside the abstract class
    abstract method does not have definition, but it is overriden into the derived class
    abstract method is by default virtual method

    abstract class can have both abstract and non abstract methods
    abstract class cannot be instantiated
    abstract class must be inherited and its abstract methods must be implemented by the derived class
    only one abstract class can be inherited at a time by the drived class
    abstract class can have constructor, variables etc.
    */

    abstract class BaseCustomer
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public string EmailId { get; set; }
        public string Mobile { get; set; }

        public abstract void LogInfo();

        public void Welcome()
        {
            System.Console.WriteLine("Welcome to Electronoic store");
        } 
    }

    class Customer : BaseCustomer
    {
        public decimal BillAmount { get; set; }
        public decimal Discount { get; set; }

        public override void LogInfo()
        {
            Console.Write("Enter Id => ");
            Id = Convert.ToInt32(Console.ReadLine());

            Console.Write("Enter Name => ");
            Name = Console.ReadLine();

            Console.Write("Enter Email Id => ");
            EmailId = Console.ReadLine();

            Console.Write("Enter Mobile => ");
            Mobile = Console.ReadLine();

            Console.Write("Enter Bill Amount => ");
            BillAmount = Convert.ToDecimal(Console.ReadLine());

            Console.Write("Enter Discount => ");
            Discount = Convert.ToDecimal(Console.ReadLine());
        }
    }

    class Visitor : BaseCustomer
    {
        public string Reason { get; set; }
        public override void LogInfo()
        {
            Console.Write("Enter Id => ");
            Id = Convert.ToInt32(Console.ReadLine());

            Console.Write("Enter Name => ");
            Name = Console.ReadLine();

            Console.Write("Enter Email Id => ");
            EmailId = Console.ReadLine();

            Console.Write("Enter Mobile => ");
            Mobile = Console.ReadLine();

            Console.Write("Reason => ");
            Reason = Console.ReadLine();
        }
    }
}
