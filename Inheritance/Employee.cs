using System;

namespace Inheritance
{
    public class Employee
    {
        public int Id { get; set; }
        public string FullName { get; set; }
        public string Mobile { get; set; }
        public string Email { get; set; }

        public virtual void AddEmployee()
        {
            Console.Write("Enter Id => ");
            Id = Convert.ToInt32(Console.ReadLine());

            Console.Write("Enter FullName => ");
            FullName = Console.ReadLine();

            Console.Write("Enter Mobile => ");
            Mobile = Console.ReadLine();

            Console.Write("Enter Email => ");
            Email = Console.ReadLine();
        }

        public virtual void Print()
        {
            Console.WriteLine("Id = " + Id);
            Console.WriteLine("FullNAme = " + FullName);
            System.Console.WriteLine("Mobile = " + Mobile);
            System.Console.WriteLine("Email = " + Email);
        }
    }

    class FullTimeEmployee : Employee
    {
        public decimal Salary { get; set; }
        public string Benefits { get; set; }

        public void AddFullTimeEmployee()
        {
            base.AddEmployee();
            Console.Write("Enter Salary => ");
            Salary = Convert.ToDecimal(Console.ReadLine());
            Console.Write("Enter Benefits => ");
            Benefits = Console.ReadLine();
        }

        public void PrintFullTimeEmployee()
        {
            base.Print();
            Console.WriteLine("Salary = " + Salary);
            Console.WriteLine("Benefits = " + Benefits);
        }
    }

    class PartTimeEmployee : Employee
    {
        public decimal HourlySalary { get; set; }
        public string Employer { get; set; }

        public void AddPartTimeEmployee()
        {
            AddEmployee();
            Console.Write("Enter HourlySalary => ");
            HourlySalary = Convert.ToDecimal(Console.ReadLine());
            Console.Write("Enter Employer => ");
            Employer = Console.ReadLine();
        }

        public void PrintPartTimeEmployee()
        {
            base.Print();
            Console.WriteLine("HourlySalary = " + HourlySalary);
            Console.WriteLine("Employer = " + Employer);
        }
    }

    // method override

    class OverrideEmployee : Employee
    {
        public bool OverTime { get; set; }
        public int MaxHour { get; set; }
        public override void AddEmployee()
        {
            base.AddEmployee();
            Console.Write("Enter OverTime true or false => ");
            OverTime = Convert.ToBoolean(Console.ReadLine());
            Console.Write("Enter MaxHour => ");
            MaxHour = Convert.ToInt32(Console.ReadLine());
        }

        public override void Print()
        {
            base.Print();
            Console.WriteLine("OverTime = " + OverTime);
            Console.WriteLine("MaxHour = " + MaxHour);
        }
    }
}
