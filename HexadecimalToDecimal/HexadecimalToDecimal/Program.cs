using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HexadecimalToDecimal
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.Write("Enter hexadecimal number: ");
            string input = Console.ReadLine();
            int num = int.Parse(input, System.Globalization.NumberStyles.HexNumber);
            Console.WriteLine($"Decimal equivalent: {num}");
        }
    }
}
