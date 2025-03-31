using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.Remoting.Services;
using System.Text;
using System.Threading.Tasks;

namespace fractionalPowers
{
    class Program
    {
        static double input(string input)
        {
            double number;
            string inputString = input;
            while (!double.TryParse(inputString, out number))
            {
                Console.WriteLine("Invalid input. Please enter a number.");
                inputString = Console.ReadLine();
            }
            number = double.Parse(inputString);
            return number;

        }
        static void Main(string[] args)
        {
            Console.Write("Enter a base: ");
            double baseNumber = input(Console.ReadLine());
            Console.Write("Enter a exponent numerator: ");
            double numerator = input(Console.ReadLine());
            Console.Write("Enter a exponent denominator: ");
            double denominator = input(Console.ReadLine());
            while (denominator == 0)
            {
                Console.WriteLine("Invalid input. Please enter a non-zero number.");
                denominator = input(Console.ReadLine());
            }
            double exponent = numerator / denominator;
            double result = Math.Pow(baseNumber, exponent);
            Console.WriteLine("The result is: " + result);

        }
    }
}
