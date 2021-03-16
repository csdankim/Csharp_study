using System;

namespace Generic
{
    class Program
    {
        static void Main(string[] args)
        {
            // EqualityChecker<int> equalityChecker = new EqualityChecker<int>();
            // System.Console.WriteLine(equalityChecker.CheckEquality(100, 100));

            ManageEmployee manageEmployee = new ManageEmployee();
            manageEmployee.AddEmployee();
            manageEmployee.Print();
            // manageEmployee.Remove("Dan");
            // System.Console.WriteLine("------------------------");
            // manageEmployee.Print();

            System.Console.WriteLine("------------------------");

            Student st = new Student();
            st.AddStudent();
            st.Print();
            st.Remove("Dan");
            System.Console.WriteLine("-------------------------");
            st.Print();
        }
    }
}
