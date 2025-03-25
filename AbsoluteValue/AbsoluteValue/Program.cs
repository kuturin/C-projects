using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AbsoluteValue
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.Write("Enter a number: ");
            string input = Console.ReadLine();
            while (!int.TryParse(input, out int value))
            {
                Console.WriteLine("Invalid input. Please enter a number: ");
                input = Console.ReadLine();
            }
            int number = Convert.ToInt32(input);
            int absoluteValue = Math.Abs(number);
            Console.WriteLine($"The absolute value of {number} is {absoluteValue}");
        }
    }
}
