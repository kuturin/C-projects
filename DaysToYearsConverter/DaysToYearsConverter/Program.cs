using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DaysToYearsConverter
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
            int ndays, years, week, days, daysInWeek = 7;
            Console.WriteLine("Enter the number of days");
            ndays = isNumber(Console.ReadLine());
            if (ndays < 0)
            {
                ndays *= -1;
            }
            years = ndays / 365;
            week = (ndays % 365)/daysInWeek;
            days = (ndays % 365) % daysInWeek;
            Console.WriteLine($"{ndays} days is approximately {years} years, {week} weeks, and {days} days.");

        }
    }
}
