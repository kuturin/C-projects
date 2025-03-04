using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AllMultiplesOf17
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.Write("Enter a number: ");
            int number = int.Parse(Console.ReadLine()), a, i;
            for (i = 1; i <= number; i++)
            {
                a = i % 17;
                if (a == 0) 
                {
                    Console.WriteLine(i);
                }
            }
            Console.Read();
        }
    }
}
