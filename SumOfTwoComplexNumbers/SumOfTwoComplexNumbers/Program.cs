using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks; 
struct Complex
{
    public double real; public double imaginary;
    public Complex(double real, double imaginary)
    {
        this.real = real;
        this.imaginary = imaginary;
    }
    public static Complex operator +(Complex c1, Complex c2)
    {
        return new Complex(c1.real + c2.real, c1.imaginary + c2.imaginary);
    }
    public override string ToString()
    {
        return (String.Format("{0} + {1}i", real, imaginary));
    }
}

namespace SumOfTwoComplexNumbers
{
    class Program
    {
        static void Main(string[] args)
        {
            double num1;
            double img1;
            Console.WriteLine("Enter a complex number");
            Console.Write("Enter the real part: ");
            string inputN1 = Console.ReadLine();
            Console.Write("Enter the imaginary part: ");
            string inputI1 = Console.ReadLine();
            if (inputI1== "i" || inputI1 == "I")
            {
                inputI1 = "1";
            }
            if else (inputI1 == "-i" || inputI1 == "-I")
            {
                inputI1 = "-1";
            }

            while (!double.TryParse(inputN1, out num1) || !double.TryParse(inputI1, out img1))
        {
            Console.WriteLine("Invalid input. Please enter a valid number.");
            Console.Write("Enter the real part: ");
            inputN1 = Console.ReadLine();
            Console.Write("Enter the imaginary part: ");
            inputI1 = Console.ReadLine();
            if (inputI1 == "i" || inputI1 == "I")
            {
                inputI1 = "1";
            }
            if (inputI1 == "-i" || inputI1 == "-I")
            {
                    inputI1 = "-1";
                }
            }
            num1 = Convert.ToDouble(inputN1);
            img1 = Convert.ToDouble(inputI1);



            double num2;
            double img2;
            Console.WriteLine("Enter another complex number");
            Console.Write("Enter the real part: ");
            string inputN2 = Console.ReadLine();
            Console.Write("Enter the imaginary part: ");
            string inputI2 = Console.ReadLine();
            if (inputI2 == "i" || inputI2 == "I")
            {
                inputI2 = "1";
            }
            if (inputI2 == "-i" || inputI2 == "-I")
            {
                inputI2 = "-1";
            }

            while (!double.TryParse(inputN2, out num2) || !double.TryParse(inputI2, out img2))
            {
                Console.WriteLine("Invalid input. Please enter a valid number.");
                Console.Write("Enter the real part: ");
                inputN1 = Console.ReadLine();
                Console.Write("Enter the imaginary part: ");
                inputI2 = Console.ReadLine();
                if (inputI2 == "i" || inputI2 == "I")
                {
                    inputI2 = "1";
                }
                if (inputI2 == "-i" || inputI2 == "-I")
                {
                    inputI2 = "-1";
                }
            }
            num2 = Convert.ToDouble(inputN2);
            img2 = Convert.ToDouble(inputI2);

            Complex c1 = new Complex(num1, img1);
            Complex c2 = new Complex(num2, img2);
            Complex c3 = c1 + c2;
            Console.WriteLine("Sum of two complex numbers is: " + c3);
        }
    }
}
