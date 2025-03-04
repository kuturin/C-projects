using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Odd_or_even
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int number;
            Console.WriteLine("Enter a number: ");
            number = int.Parse(Console.ReadLine());
            if (number % 2 == 0)
            {
                Console.WriteLine("The number is even");
                Console.Read();
            }
            else
            {
                Console.WriteLine("The number is odd");
                Console.Read();
            }
        }
    }
}
