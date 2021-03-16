using System;

namespace Interface
{
    /*
    interface provides the contract which must be implemented by the drived class
    by default, all the methods inside an interface are public and abstract
    interface support multiple inheritance
    interface cannot have any constructor
    interface cannot be instantiated
    interface cannot have variables
    */

    public interface IArithematicOperation
    {
        void Addition(int a, int b);
        int Multiply(int a, int b);
        double Subraction(double a, double b);
        double Division(double a, double b);
    }
}
