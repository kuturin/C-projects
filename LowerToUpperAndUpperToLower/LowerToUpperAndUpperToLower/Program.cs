using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LowerToUpperAndUpperToLower
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.Write("Enter a string: ");
            string str = Console.ReadLine();
            while (str.Length == 0)
            {
                Console.Write("Please enter a valid string");
                str = Console.ReadLine();
            }
            int chosen;
            Console.WriteLine("For Lower to Upper write 1, For Upper to Lower write 2, For doing nothing write 3 ");
            chosen = Convert.ToInt32(Console.ReadLine());
            while (chosen != 1 && chosen != 2 && chosen != 3)
            {
                Console.WriteLine("Please enter a valid number");
                chosen = Convert.ToInt32(Console.ReadLine());
            }
            for (int i = 0; i < str.Length; i++)
            {
                if (chosen == 1)
                
                {
                    Console.Write(char.ToUpper(str[i]));
                }
                else if (chosen == 2)
                {
                    Console.Write(char.ToLower(str[i]));
                }
                else if (chosen == 3)
                {
                    Console.Write(str[i]);
                }
                else
                {
                    Console.WriteLine("Invalid input");
                }
            }
        }
    }
}
