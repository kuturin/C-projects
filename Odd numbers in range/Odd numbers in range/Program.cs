using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Odd_numbers_in_range
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.Write("Enter the first number of the range: ");
            int rangeStart = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine();
            Console.Write("Enter the last number of the range: ");
            int rangeEnd = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine($"In the range from {rangeStart} to {rangeEnd}, odd numbers are: ");
            for (int i = rangeStart; i <= rangeEnd; i++)
            {
                
                if (i % 2 != 0)
                {
                    Console.WriteLine(i);
                }
            }
        }
    }
}
