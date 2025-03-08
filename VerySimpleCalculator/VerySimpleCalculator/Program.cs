using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace VerySimpleCalculator
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.Write("Enter the first number: ");
            double num1 = Convert.ToDouble(Console.ReadLine());
            Console.Write("Enter the second number: ");
            double num2 = Convert.ToDouble(Console.ReadLine());
            Console.Write("Enter the operator (+, -, *, /): ");
            string op = Console.ReadLine();
            if (op == "+")
            {
                Console.WriteLine("The result is: " + (num1 + num2));
            }
            else if (op == "-")
            {
                Console.WriteLine("The result is: " + (num1 - num2));
            }
            else if (op == "*")
            {
                Console.WriteLine("The result is: " + (num1 * num2));
            }
            else if (op == "/")
            {
                if (num2 == 0)
                {
                    Console.WriteLine("Cannot divide by zero");
                    return;
                }
                Console.WriteLine("The result is: " + (num1 / num2));
            }
            else
            {
                Console.WriteLine("Invalid operator");
            }
        }
    }
}
