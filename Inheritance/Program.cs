using System;

namespace Inheritance
{
    class Program
    {
        static void Main(string[] args)
        {
            FullTimeEmployee fte = new FullTimeEmployee();
            fte.AddFullTimeEmployee();
            fte.PrintFullTimeEmployee();

            Console.WriteLine("-----------------------------");

            PartTimeEmployee pte = new PartTimeEmployee();
            pte.AddPartTimeEmployee();
            pte.PrintPartTimeEmployee();

            Console.WriteLine("-----------------------------");

            Employee emp = new OverrideEmployee();
            emp.AddEmployee();
            emp.Print();
        }
    }
}
