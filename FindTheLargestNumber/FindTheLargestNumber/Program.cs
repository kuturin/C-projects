using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FindTheLargestNumber
{
    internal class Program
    {
        public static int Question(string question)
        {
            Console.Write($"Enter a {question} number: ");
            return Convert.ToInt32(Console.ReadLine());
        }

        static void Main(string[] args)
        {
            int a, b;
            a = Question("first");
            b = Question("second");

            if (a > b)
            {
                Console.WriteLine($"{a} is the largest number.");
            }
            else if (a < b)
            {
                Console.WriteLine($"{b} is the largest number.");
            }
            else
            {
                Console.WriteLine("Both numbers are equal.");
            }


            Console.ReadLine();//

        }
            
        
    }
}
