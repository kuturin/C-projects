using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FactorsOfGivenNumber
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.Write("Enter a number: ");
            string input = Console.ReadLine();
            while (!int.TryParse(input, out int number))
            {
                Console.Write("Enter a valid number: ");
                input = Console.ReadLine();
            }
            int num = int.Parse(input);
            Console.WriteLine("Factors of " + num + " are:");
            for (int i = 1; i <= num; i++)
            {
                if (num % i == 0)
                {
                    Console.Write(i + ", ");
                }
            }
        }
    }
}
