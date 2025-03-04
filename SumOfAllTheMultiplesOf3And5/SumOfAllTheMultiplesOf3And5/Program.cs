using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SumOfAllTheMultiplesOf3And5
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.Write("Enter the number to find the sum of all the multiples of 3 and 5 in the number: ");
            int a, b, i, sum = 0, sumNumber = int.Parse(Console.ReadLine());
            
            for (i = 1; i<= sumNumber; i++) 
            {
                a = i % 3;
                b = i % 5;
                if (a == 0 || b == 0)
                {
                    sum = sum + i;
                }

            }
            Console.WriteLine("The sum of all the multiples of 3 and 5 in " + sumNumber + " is: " + sum);
        }
    }
}
