using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace IsDivisibleBy2
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.Write("Enter a number: ");
            int number = int.Parse(Console.ReadLine());
            if ( number % 2 == 0)
            {
                Console.WriteLine(number + " is divisible by 2");
            }
            else
            {
                Console.WriteLine(number + " isn't divisible by 2");
            }
        }
    }
}
