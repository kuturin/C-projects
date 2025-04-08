using System;
using System.Collections.Generic;
using System.Globalization;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DayLigthSavingInformation
{
    class Program
    {

        static void Main(string[] args)
        {
            TimeZone z = TimeZone.CurrentTimeZone;
            DaylightTime t = z.GetDaylightChanges(DateTime.Now.Year);
            Console.WriteLine($"Start time: {t.Start}");
            Console.WriteLine($"Start time: {t.Delta}");
            Console.WriteLine($"Start time: {t.End}");
        }
    }
}
