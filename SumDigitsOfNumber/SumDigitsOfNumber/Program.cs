﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SumDigitsOfNumber
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.Write("Enter a number: ");
            int number = int.Parse(Console.ReadLine());
            int sum = 0;
            string numberString = number.ToString();
            for (int i = 0; i < numberString.Length; i++)
            {
                sum += int.Parse(numberString[i].ToString());
            }
            Console.WriteLine("The sum of the digits of the " + number + " is " + sum);
        }
    }
}
