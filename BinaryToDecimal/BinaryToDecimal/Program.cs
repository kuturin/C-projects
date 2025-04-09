using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BinaryToDecimal
{
    class Program
    {
        static bool isBinary(string input)
        {
            foreach (char c in input)
            {
                if (c != '0' && c != '1')
                {
                    return false;
                }
            }
            return true;
        }
        static void Main(string[] args)
        {
            int num, binaryVal, decimalVal = 0, baseVal = 1, rem;
            Console.Write("Enter a Binary Number(1s and 0s) : ");
            string input = Console.ReadLine();
            while (!int.TryParse(input, out num) || !isBinary(input))
            {
                Console.Write("Invalid input. Please enter a valid binary number: ");
                input = Console.ReadLine();
            }
            binaryVal = num;
            while (num > 0)
            {
                rem = num % 10;
                decimalVal = decimalVal + rem * baseVal;
                num = num / 10;
                baseVal = baseVal * 2;
            }
            
            Console.Write("The Binary Number is : " + binaryVal);
            Console.Write("\nIts Decimal Equivalent is : " + decimalVal); 

        }
    }
}
