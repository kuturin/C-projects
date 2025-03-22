using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SumOfNNumbers
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.Write("Enter a number: ");
            string input = Console.ReadLine();
            bool isNumber = int.TryParse(input, out int number);
            while (!isNumber)
            {
                Console.WriteLine("Invalid input. Please enter a number");
                input = Console.ReadLine();
                isNumber = int.TryParse(input, out number);
            }
            int n = int.Parse(input);
            int sum = 0;
            for (int i = 0; i <= n; i++)
            {
                sum += i;
            }
            Console.WriteLine($"The sum of numbers from 0 to {n} is {sum}");
        }
    }
}
