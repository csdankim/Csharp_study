using System;

namespace Abstract
{
    class Program
    {
        static void Main(string[] args)
        {
            // BaseCustomer baseCustomer = new BaseCustomer(); // abstract class cannot be instantiated
            /* BaseCustomer customer = new Customer();
            customer.LogInfo();

            BaseCustomer visitor = new Visitor();
            visitor.LogInfo(); */

            Menu m = new Menu();
            int choice = m.Print();

            /* switch (choice)
            {
                case 1:
                    BaseCustomer customer = new Customer();
                    customer.LogInfo();
                    break;
                case 2:
                    BaseCustomer visitor = new Visitor();
                    visitor.LogInfo();
                    break;
                default:
                    System.Console.WriteLine("Invalid Option");
                    break;
            } */  // -> goes to Customer Factory

            CustomerFactory customerFactory = new CustomerFactory();
            BaseCustomer baseCustomer = customerFactory.GetObject(choice);
            baseCustomer.LogInfo();
        }
    }
}
