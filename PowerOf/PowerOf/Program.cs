using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PowerOf
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
            Console.Write("Enter a number: ");
            double number = input(Console.ReadLine());
            Console.Write("Enter the power: ");
            double power = input(Console.ReadLine());
            double result = Math.Pow(number, power);
            Console.WriteLine($"{number} raised to the power of {power} is {result}");



        }
    }
}
