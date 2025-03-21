using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ArmstrongNumberChecker
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.Write("Enter a number: ");
            string input = Console.ReadLine();
            bool isInt = int.TryParse(input, out int result);
            while (!isInt)
            {
                Console.WriteLine("Enter a valid number: ");
                input = Console.ReadLine();
                isInt = int.TryParse(input, out result);
            }
            int length = input.Length;
            int number = int.Parse(input);
            int sum = 0;
            for (int i = 0; i < length; i++)
            {
                sum += (int)Math.Pow(int.Parse(input[i].ToString()), length);
            }
            if (sum == number)
            {
                Console.WriteLine($"{number} is an Armstrong number.");
            }
            else
            {
                Console.WriteLine($"{number} is not an Armstrong number, because sum of the powers of it's digits is {sum}");
            }
        }
    }
}
