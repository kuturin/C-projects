using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.Remoting.Services;
using System.Text;
using System.Threading.Tasks;

namespace FactorialOfNumber
{
    class Program
    {
        static int factorial(int n)
        {
            if (n == 1) return 1;
            n = n * (n - 1);
            return n;

            
            
        }
        static void Main(string[] args)
        {
            Console.Write("Enter the number bigger than 0: ");
            string input = Console.ReadLine();
            
            bool isInt = int.TryParse(input, out int n);
            while (!isInt || n <= 0)
            {
                Console.WriteLine("Enter valid number");
                input = Console.ReadLine();
                isInt = int.TryParse(input, out n);
            }
            int number = int.Parse(input);


            int fac = factorial(number);
            Console.WriteLine($"Factorial of {number} is: {fac}");


        }
    }
}
