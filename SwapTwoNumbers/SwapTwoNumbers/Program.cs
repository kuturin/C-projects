using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SwapTwoNumbers
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int number1, number2, temp;
            Console.Write("Enter the first number: ");
            number1 = Convert.ToInt32(Console.ReadLine());
            Console.Write("Enter the second number: ");
            number2 = Convert.ToInt32(Console.ReadLine());

            if (number1 == number2)
            {
                Console.WriteLine("Both numbers are equal.");
                return;
            }
            Console.WriteLine("Before swapping: ");
            Console.WriteLine($"First number: {number1}");
            Console.WriteLine($"Second number: {number2}");
            Console.WriteLine();
            temp = number1;
            number1 = number2;
            number2 = temp;
            Console.WriteLine("After swapping: ");
            Console.WriteLine($"First number: {number1}");
            Console.WriteLine($"Second number: {number2}");
            //
        }
    }
}
