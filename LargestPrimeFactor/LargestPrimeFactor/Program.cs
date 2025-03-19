using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LargestPrimeFactor
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.Write("Enter a Number larger than 0: ");
            string input = Console.ReadLine();
            bool isNumber = long.TryParse(input, out long number);
            while (!isNumber || (long.Parse(input) <= 0))
            {
                Console.Write("Invalid input. Please enter a number: ");
                input = Console.ReadLine();
                isNumber = long.TryParse(input, out number);
            }
            long num = long.Parse(input);
            int k = 0;
            for (int i = 1; i <= num; i++)
            {
                if (num % i ==0)
                {
                    k++;
                }
            }
            if (k == 2)
            {
                Console.WriteLine($"Entered Number is Prime Number and the Largest Factor is {num}");
            }
            else
            {
                Console.WriteLine("Not a Prime Number");
            }
        }
    }
}
