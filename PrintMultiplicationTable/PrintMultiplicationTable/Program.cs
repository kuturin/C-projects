using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PrintMultiplicationTable
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.Write("Enter the number to print multiplication table: ");
            int number = Convert.ToInt32(Console.ReadLine());
            while (number <= 0)
            {
                Console.WriteLine("Please enter a number bigger than 0'");
                number = Convert.ToInt32(Console.ReadLine());

            }
            Console.WriteLine("Multiplication table of {0} is as follows: ", number);
            for (int i = 1; i <= number; i++)
            {
                Console.WriteLine("\n");
                for (int j = 0; j <= number; j++)
                {
                    Console.Write("{0,6}", i * j);
                }
                
            }
        }
    }
}
