using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ExponentsCalculator
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.Write("Enter the base number: ");
            double baseNumber = double.Parse(Console.ReadLine());
            Console.Write("Enter the first exponent: ");
            double fisrtExponent = double.Parse(Console.ReadLine());
            Console.Write("Enter the second exponent: ");
            double secondExponent = double.Parse(Console.ReadLine());

            double mul = fisrtExponent + secondExponent;

            double result = Math.Pow(baseNumber, mul);

            Console.WriteLine("The result of " + baseNumber + " raised to the power of " + fisrtExponent + " and " + secondExponent + " is: " + baseNumber + " raised to the power of " + mul + " which is: " + result);
        }
    }
}
