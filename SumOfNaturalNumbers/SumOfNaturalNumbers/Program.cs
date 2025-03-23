using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SumOfNaturalNumbers
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.Write("Enter how much natural numbers to sum?");
            string input = Console.ReadLine();
            bool isNumber = int.TryParse(input, out int number);
            while (!isNumber)
            {
                Console.WriteLine("Please enter a valid number");
                input = Console.ReadLine();
                isNumber = int.TryParse(input, out number);
            }
            int n = int.Parse(input);
            int sum = 0;
            for (int i = 1; i <= n; i++)
            {
                sum += i;
            }
            Console.WriteLine($"Sum of first {n} natural numbers is {sum}");
        }
    }
}
