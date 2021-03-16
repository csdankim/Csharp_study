using System;

namespace Abstract
{
    public class Menu
    {
        public int Print()
        {
            //Console.WriteLine("Press 1 for customer");
            //Console.WriteLine("Press 2 for Visitor");
            string[] names = Enum.GetNames(typeof(CustomerOption));
            int[] values = (int[]) Enum.GetValues(typeof(CustomerOption));
            int length = names.Length;

            for (int i = 0; i < length; i++)
            {
                System.Console.WriteLine("Press " + values[i] + " for " + names[i]);
            }

            Console.Write("Enter your choice => ");
            int choice = Convert.ToInt32(Console.ReadLine());
            
            return choice;
        }
    }
}
