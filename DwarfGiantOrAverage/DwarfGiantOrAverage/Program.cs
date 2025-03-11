using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DwarfGiantOrAverage
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.Write("Write your height in cm: ");
            string input = Console.ReadLine();
            while (input == "")
            {
                Console.Write("Height can't be empty. Write your height in cm: ");
                input = Console.ReadLine();
            }
            bool isNumeric = int.TryParse(input, out int result);
            while (!isNumeric)
            {
                Console.Write("Height must be a number. Write your height in cm: ");
                input = Console.ReadLine();
                isNumeric = int.TryParse(input, out result);
            }
            int height = int.Parse(input);
            while (height <= 0)
            {
                Console.Write("Height can't be 0 or less. Write your height in cm: ");
                height = int.Parse(Console.ReadLine());
            }
            if (height < 140)
            {
                Console.WriteLine("You are a dwarf.");
            }
            else if (height > 200)
            {
                Console.WriteLine("You are a giant.");
            }
            else if (height >= 140 && height <= 200)
            {
                Console.WriteLine("You are average.");
            }
            else
            {
                Console.WriteLine("Invalid input.");
            }
        }
    }
}
