using System;

namespace Interface
{
    public class ArithematicOperation : IArithematicOperation
    {
        public void Addition(int a, int b)
        {
            System.Console.WriteLine("Addition = " + (a+b));
        }

        public int Multiply(int a, int b)
        {
            return a * b;
        }
        
        public double Subraction(double a, double b)
        {
            return a - b;
        }

        public double Division(double a, double b)
        {
            return a / b;
        }
    }
}