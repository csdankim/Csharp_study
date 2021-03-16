using System;

namespace Interface
{
    class Program
    {
        static void Main(string[] args)
        {
            IArithematicOperation arithematicOperation = new ArithematicOperation();
            arithematicOperation.Addition(10, 20);
            int multiply = arithematicOperation.Multiply(23, 18);
            System.Console.WriteLine("Multiplication = " + multiply);
            double subtract = arithematicOperation.Subraction(0, 30);
            System.Console.WriteLine("Subtraction = " + subtract);
            double division = arithematicOperation.Division(0, 30);
            System.Console.WriteLine("Division = " + division);
        }
    }
}
