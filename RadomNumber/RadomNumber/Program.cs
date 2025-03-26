using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RadomNumber
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.Write("Enter the max range of random number: ");
            string input = Console.ReadLine();
            while (!int.TryParse(input, out int n))
            {
                Console.Write("Invalid input. Please enter a valid number: ");
                input = Console.ReadLine();
            }
            int number = int.Parse(input);
            Random random = new Random();
            Console.WriteLine(random.Next(1, number));
        }
    }
}
