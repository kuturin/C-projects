using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PerfectNumber
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.Write("Enter a positive number: ");
            string input = Console.ReadLine();
            bool isInt = int.TryParse(input, out int number);
            while (!isInt || number < 1)
            {
                Console.Write("Invalid input. Please enter a positive integer: ");
                input = Console.ReadLine();
                isInt = int.TryParse(input, out number);
            }
            int num = int.Parse(input);
            int sum = 0;
            for (int i = 1; i < num; i++)
            {
                if ((num % i) == 0)
                {
                    sum += i;
                }
            }
            if (sum == num)
            {
                Console.WriteLine($"{num} is a perfect number.");
            }
            else
            {
                Console.WriteLine($"{num} is not a perfect number. Because sum of its proper division is {sum}");
            }
        }
    }
}
