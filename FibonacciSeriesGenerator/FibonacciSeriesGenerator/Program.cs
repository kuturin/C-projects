using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FibonacciSeriesGenerator
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.Write("Enter length:");
            decimal i, a= 0, b= 1, length = int.Parse(Console.ReadLine());
            


            for (i = 0; i <= length; i++)
            {
                if (i > 0)
                {
                    Console.WriteLine(b);
                    b = a + b;
                    a = b - a;
                }
                else { Console.WriteLine( 0); }
                
               




            }
        }
    }
}
