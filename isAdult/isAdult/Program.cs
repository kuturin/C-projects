using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace isAdult
{
    class Program
    {
        static void Main(string[] args)
        {
            string input;
            string legalInput;
            Console.Write("Enter your age:");
            input = Console.ReadLine();
            while (!int.TryParse(input, out int inputAge) || (int.Parse(input)) < 0 || (int.Parse(input)) > 150)
            {
                Console.WriteLine("Please enter a valid number.");
                input = Console.ReadLine();
            }
            int age = int.Parse(input);
            Console.Write("Enter legal age in your country:");
            legalInput = Console.ReadLine();
            while (!int.TryParse(legalInput, out int inputLegalAge) || (int.Parse(legalInput)) < 12  || (int.Parse(legalInput)) > 25)
            {
                Console.WriteLine("Please enter a valid number.");
                legalInput = Console.ReadLine();
            }
            int legalAge = int.Parse(legalInput);
            if (age >= legalAge)
            {
                Console.WriteLine("You are an adult.");
            }
            else
            {
                Console.WriteLine("You are not an adult.");
            }
        }
    }
}
