using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SumOfToBinaryNumbers
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.Write("Enter your first number: ");
            int firstNumber = int.Parse(Console.ReadLine());

            Console.Write("Enter your second number: ");
            int secondNumber = int.Parse(Console.ReadLine());

            string firstBinaryString = Convert.ToString(firstNumber, 2);
            Console.WriteLine("First number in binary is: " + firstBinaryString);
            string secondBinaryString = Convert.ToString(secondNumber, 2);
            Console.WriteLine("Second number in binary is: " + secondBinaryString);

            int firstBinary = Convert.ToInt32(firstBinaryString, 2);
            int secondBinary = Convert.ToInt32(secondBinaryString, 2);
            string sum = Convert.ToString(firstBinary + secondBinary, 2);
            Console.WriteLine("Sum of two numbers in binary is: " + sum);
        }
    }
}
