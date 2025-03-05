using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ReverseNumberIsPalindrom
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.Write("Enter a number: ");
            string stringNumber = Console.ReadLine();
            int pos = 0;
            string reversedStringNumber = "";
            

            for (int i = stringNumber.Length - 1; i >= 0; i--)
            {
                reversedStringNumber += stringNumber[i];
            }
            int reversedNumber = int.Parse(reversedStringNumber);
            int number = int.Parse(stringNumber);
            Console.WriteLine("The reversed " + number + " is: " + reversedNumber);
            if (reversedNumber == number)
            {
                Console.WriteLine("The number is a palindrom");
            }
            else
            {
                Console.WriteLine("The number isn't a palindrom");
            }
        }
    }
}
