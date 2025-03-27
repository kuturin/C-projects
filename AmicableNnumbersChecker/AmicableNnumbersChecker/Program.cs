using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AmicableNnumbersChecker
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Enter a pair of natural numbers:");
            Console.Write("First smaller number: ");
            string input1 = Console.ReadLine();
            int numer1;
            while (!int.TryParse(input1, out numer1) || numer1 < 1)
            {
                Console.WriteLine("Invalid input. Please enter a positive integer.");
                input1 = Console.ReadLine();
            }
            Console.Write("Second larger number: ");
            string input2 = Console.ReadLine();
            while (!int.TryParse(input2, out int numer2) || numer2 < 1 || numer2 <= numer1)
            {
                Console.WriteLine("Invalid input. Please enter a positive integer larger than the first number.");
                input2 = Console.ReadLine();
            }
            int num1 = int.Parse(input1);
            int num2 = int.Parse(input2);
            int sum1 = 0;
            int sum2 = 0;
            for (int i = 1; i < num1; i++)
            {
                if (num1 % i == 0)
                {
                    sum1 += i;
                }
            }
            for (int i = 1; i < num2; i++)
            {
                if (num2 % i == 0)
                {
                    sum2 += i;
                }
            }
            if (sum1 == num2 && sum2 == num1)
            {
                Console.WriteLine($"{num1} and {num2} are amicable numbers.");
            }
            else
            {
                Console.WriteLine($"{num1} and {num2} are not amicable numbers.");
            }
        }
    }
}
