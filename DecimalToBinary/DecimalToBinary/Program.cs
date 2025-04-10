using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DecimalToBinary
{
    class Program
    {
        static int isDecimal(string str)
        {
            while (!int.TryParse(str, out int n))
            {
                Console.WriteLine("Please enter a valid decimal number:");
                str = Console.ReadLine();
            }
            int num = int.Parse(str);
            if (num < 0)
            {
                num *= -1;
            }
            return int.Parse(str);
        }
        static int toBinary(int num)
        {
            int binary = 0;
            int i = 1;
            while (num > 0)
            {
                binary += (num % 2) * i;
                num /= 2;
                i *= 10;
            }
            return binary;
        }
        static void Main(string[] args)
        {
            Console.WriteLine("Enter a decimal number: ");
            int num = isDecimal(Console.ReadLine());
            int binary = toBinary(num);
            Console.WriteLine($"The binary representation of {num} is: {binary}");


        }
    }
}
