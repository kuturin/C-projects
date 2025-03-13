using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MaxRange
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("1. Int");
            Console.WriteLine("2. Double");
            Console.WriteLine("3. Float");
            Console.WriteLine("4. Decimal");
            Console.Write("Chose your datatype by writing number of datatype:");

            string choice = Console.ReadLine();
            bool isInt = int.TryParse(choice, out int result);
            while (!isInt || result < 1 || result > 4)
            {
                Console.WriteLine("Invalid input. Please try again.");
                choice = Console.ReadLine();
                isInt = int.TryParse(choice, out result);
            }
            int dataType = int.Parse(choice);
            if (dataType == 1)
            {
                Console.WriteLine($"The maximum value of int is {int.MaxValue}");
                Console.WriteLine("The maximum value writen in exponent form of int is {0:E}", int.MaxValue);
            }
            else if (dataType == 2)
            {
                Console.WriteLine($"The  value of double is {double.MaxValue}");
                Console.WriteLine("The  value writen in exponent form of int is {0:E}", double.MaxValue);
            }
            else if (dataType == 3)
            {
                Console.WriteLine($"The  value of float is {float.MaxValue}");
                Console.WriteLine("The  value writen in exponent form of int is {0:E}", float.MaxValue);
            }
            else if (dataType == 4)
            {
                Console.WriteLine($"The  value of decimal is {decimal.MaxValue}");
                Console.WriteLine("The  value writen in exponent form of int is {0:E}", decimal.MaxValue);



            }
        }
    }
}
