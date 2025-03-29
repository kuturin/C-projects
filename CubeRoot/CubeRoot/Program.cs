using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CubeRoot
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.Write("Enter a number to find the cube root of: ");
            double num = Convert.ToDouble(Console.ReadLine());
            double cubeRoot = Math.Pow(num, 1.0 / 3.0);
            Console.WriteLine("The cube root of " + num + " is " + cubeRoot);
        }
    }
}
