using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BoxingOperations
{
    class sample
    {
        int x = 10;
        object obj;
        void boxmethod()
        {
            sample s = new sample();
            bool b;
            object ob = "CSHARP";
            b = s.obj is int;
            Console.WriteLine(b);
            s.obj = x;
            b = s.obj is int;
            Console.WriteLine("{0},{1},{2}", s.obj,s.x,b);
            s.x = (int)s.obj;
            s.x = 20;
            b = s.obj is int;
            Console.WriteLine("{0},{1},{2}", s.obj, s.x, b);
            s.obj = "CSHARP";
            b = s.obj is int;
            Console.WriteLine("{0},{1},{2}", s.obj, s.x, b);
            Console.ReadLine();
        }
        static void Main(string[] args)
        {
            sample s = new sample();
            s.boxmethod();
        }
    }
}
