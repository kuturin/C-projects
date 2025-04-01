using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RandomRegisterNumber
{
    class Program
    {
        static int isNumeric(string inputString)
        {
            string input = inputString;
            while (!int.TryParse(input, out int result))
            {
                Console.WriteLine("Please enter a valid number");
                input = Console.ReadLine();
            }
            return int.Parse(input);
        }
        static void Main(string[] args)
        {
            Console.Write("Enter how many Register Numbers to generate: ");
            int n = isNumeric(Console.ReadLine());
            Console.Write("Enter the starting Register Number: ");
            int start = isNumeric(Console.ReadLine());
            Random random = new Random();
            HashSet<int> uniqueNumbers = new HashSet<int>();

            while (uniqueNumbers.Count < n)
            {
                int newNumber = start + random.Next(0, n);
                uniqueNumbers.Add(newNumber);
            }

            foreach (int number in uniqueNumbers)
            {
                Console.WriteLine(number);
            }
        }
    }
}
