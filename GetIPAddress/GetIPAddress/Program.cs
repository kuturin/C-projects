using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Text;
using System.Threading.Tasks;

namespace GetIPAddress
{
    internal class Program
    {
        static void Main(string[] args)
        {
            string strHostName = string.Empty;
            strHostName = Dns.GetHostName();
            Console.WriteLine("Local machine's host name: " + strHostName);
            IPHostEntry ipEntry = Dns.GetHostEntry(strHostName);
            IPAddress[] addr = ipEntry.AddressList;
            for (int i = 0; i < addr.Length; i++)
            {
                Console.WriteLine("IP Address " + (i + 1) + ": " + addr[i].ToString());
            }
        }
    }
}
