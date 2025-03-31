using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ReverseNumber
{
    class Program
    {
        static double input(string input)
        {
            double number;
            string inputString = input;
            
            while (!double.TryParse(inputString, out number))
            {
                Console.WriteLine("Invalid input. Please enter a number.");
                inputString = Console.ReadLine();
            }
            number = double.Parse(inputString);
            return number;

        }
        static void Main(string[] args)
        {
            Console.Write("Enter a number to reverse: ");
            double number = input(Console.ReadLine());
            string numberString = number.ToString();
            int length = numberString.Length;
            if (length == 1)
            {
                Console.WriteLine("The reverse of the number is: " + numberString);
            }
            else
            {
                char[] numberArray = numberString.ToCharArray();
                if (numberArray[0] == '-')
                {
                    Console.Write("-");
                    Array.Reverse(numberArray, 1, length - 1);
                }
                else
                {
                    Array.Reverse(numberArray);
                }
                
                string reversedNumber = new string(numberArray);
                Console.WriteLine("The reverse of the number is: " + reversedNumber);
            }

        }
    }
}
