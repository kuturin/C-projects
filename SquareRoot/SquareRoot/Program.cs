using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SquareRoot
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.Write("Enter a number: ");
            string input = Console.ReadLine();
            while (!double.TryParse(input, out double number))
            {
                Console.Write("Invalid input. Please enter a number: ");
                input = Console.ReadLine();
            }
            double num = double.Parse(input);
            double result = Math.Sqrt(num);
            Console.WriteLine($"The square root of {num} is {result}");
        }
    }
}
