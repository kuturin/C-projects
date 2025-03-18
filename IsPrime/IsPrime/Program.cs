using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.InteropServices.WindowsRuntime;
using System.Text;
using System.Threading.Tasks;

namespace IsPrime
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.Write("Enter a last number: ");
            string input = Console.ReadLine();
            bool isNumber = int.TryParse(input, out int value);
            while (!isNumber)
            {
                Console.WriteLine("Write valid number");
                input = Console.ReadLine();
                isNumber = int.TryParse(input, out value);
            }
            int range = int.Parse(input);
            bool isPrime = true;
            Console.WriteLine($"Prime numbers from 0 to {range} are: ");
            for (int i = 2; i <= range; i++)
            {
                for (int j = 2; j <= range; j++)
                {
                    if (i != j && (i % j == 0))
                    {
                        isPrime = false;
                        break;
                    }
                }
                if (isPrime) 
                {
                    Console.WriteLine(i);
                }
                isPrime = true;
            }



        }
    }
}
