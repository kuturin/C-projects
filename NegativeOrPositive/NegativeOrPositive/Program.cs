using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace NegativeOrPositive
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int number;

            Console.Write("Enter number: ");
            number = Convert.ToInt32(Console.ReadLine());
            if (number > 0) 
            {
                Console.WriteLine("Your number is positive");
            }
            else if (number < 0)
            {
                Console.WriteLine("Your number is negative");
            }
            else
            {
                Console.WriteLine("Your  number is zero");
            }
            Console.ReadLine();
            //
        }
    }
}
