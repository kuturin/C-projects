using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DecimalToHexadecimal
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
        static int toHexa(int num)
        {
            int hexa = 0;
            int i = 1;
            while (num != 0)
            {
                int rem = num % 16;
                hexa += rem * i;
                num /= 16;
                i *= 10;
            }

            return hexa;
        }
        static void Main(string[] args)
        {
            Console.WriteLine("Enter a decimal number: ");
            int num = isDecimal(Console.ReadLine());
            int hexa = toHexa(num);
            Console.WriteLine($"The hexadecimal representation of {num} is: {hexa}");


        }
    }
}
