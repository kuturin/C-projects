using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GetUniversalTime
{
    class Program
    {
        static void Main(string[] args)
        {
            TimeZone zone = TimeZone.CurrentTimeZone;
            DateTime univ = zone.ToUniversalTime(DateTime.Now);
            Console.WriteLine($"Universal Time is {univ}");
        }
    }
}
