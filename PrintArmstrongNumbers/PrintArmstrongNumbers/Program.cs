using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ArmstrongNumberChecker
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.Write("Enter a number: ");
            string input = Console.ReadLine();
            bool isInt = int.TryParse(input, out int result);
            while (!isInt)
            {
                Console.WriteLine("Enter a valid number: ");
                input = Console.ReadLine();
                isInt = int.TryParse(input, out result);
            }
            int range = int.Parse(input);
            for (int i = 0; i <= range; i++)
            {
                string numString = i.ToString();
                int numLength = numString.Length;
                int armstrongNum = 0;
                for (int j = 0; j < numLength; j++)
                {
                    armstrongNum += (int)Math.Pow(int.Parse(numString[j].ToString()), numLength);
                }
                if (armstrongNum == i)
                {
                    Console.WriteLine(i);
                }
                

            }
        }
    }
}