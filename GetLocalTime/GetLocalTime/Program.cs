using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GetLocalTime
{
    class Program
    {
        static void Main(string[] args)
        {
            TimeZone zone = TimeZone.CurrentTimeZone;
            DateTime local = zone.ToLocalTime(DateTime.Now);
            Console.WriteLine("Local time: {0}", local);
        }
    }
}
