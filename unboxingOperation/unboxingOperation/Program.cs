using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace unboxingOperation
{
    class sample
    {
        int data;
        void insert(object x)
        {
            data = (int)x * 5;
        }
        object delete()
        {
            data = 0;
            return (object)data;
        }
        static void Main(string[] args)
        {
            sample s = new sample();
            s.insert(10);
            Console.WriteLine("Data: {0}", s.data);
            Console.WriteLine("Data: {0}", s.delete());
            Console.ReadLine();
        }
    }
}
