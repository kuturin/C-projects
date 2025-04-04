using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DateInVariousFormats
{
    class Program
    {
        static int isNumber(string str)
        {
            string input = str;
            while (!int.TryParse(input, out int result))
            {
                Console.WriteLine("Enter a valid number");
                input = Console.ReadLine();
            }
            return int.Parse(input);

        }
        static void Main(string[] args)
        {
            int day;
            int month;
            int year;
            Console.WriteLine("Enter a date");
            Console.Write("Day: ");
            day = isNumber(Console.ReadLine());
            while (day > 31)
            {
                Console.WriteLine("Enter number lesser than 31");
                day = isNumber(Console.ReadLine());
            }
            Console.Write("Month: ");
            month = isNumber(Console.ReadLine());
            while(month > 12)
            {
                Console.WriteLine("Enter number lesser than 12");
                month = isNumber(Console.ReadLine());
            }
            Console.Write("Year: ");
            year = isNumber(Console.ReadLine());
            DateTime date = new DateTime(year, month, day);
            Console.WriteLine("Some Date Formats : ");
            Console.WriteLine($"Date and time {date}");
            Console.WriteLine(date.ToString("yyyy-MM-dd"));
            Console.WriteLine(date.ToString("dd-MMM-yy"));
            Console.WriteLine(date.ToString("M/d/yyyy"));
            Console.WriteLine(date.ToString("M/d/yy"));
            Console.WriteLine(date.ToString("MM/dd/yyyy"));
            Console.WriteLine(date.ToString("MM/dd/yy"));
            Console.WriteLine(date.ToString("yy/MM/dd"));

        }
    }
}
