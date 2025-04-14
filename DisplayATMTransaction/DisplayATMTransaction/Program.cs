using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DisplayATMTransaction
{
    internal class Program
    {
        static int isInt(string str)
        {
            int num;
            while (!int.TryParse(str, out num))
            {
                Console.WriteLine("Invalid input. Please enter a valid number.");
                str = Console.ReadLine();
            }
            return num;
        }
        static void Main(string[] args)
        {
            int amount = 1000, deposit, withdraw;
            int choice, pin = 0, x = 0;
            Console.Write("Enter your PIN number: ");
            pin = isInt(Console.ReadLine());
            while (true)
            {
                Console.WriteLine("********Welcome to ATM Service**************\n");
                Console.WriteLine("1. Check Balance\n");
                Console.WriteLine("2. Withdraw Cash\n");
                Console.WriteLine("3. Deposit Cash\n");
                Console.WriteLine("4. Quit\n");
                Console.WriteLine("*********************************************\n\n");
                Console.WriteLine("Enter your choice: ");
                choice = isInt(Console.ReadLine());
                switch (choice)
                {
                    case 1:
                        Console.WriteLine("\n YOUR BALANCE IN Rs : {0} ", amount);
                        break;
                    case 2:
                        Console.WriteLine("\n ENTER THE AMOUNT TO WITHDRAW: ");
                        withdraw = int.Parse(Console.ReadLine());
                        if (withdraw % 100 != 0)
                        {
                            Console.WriteLine("\n PLEASE ENTER THE AMOUNT IN MULTIPLES OF 100");
                        }
                        else if (withdraw > (amount - 500))
                        {
                            Console.WriteLine("\n INSUFFICENT BALANCE");
                        }
                        else
                        {
                            amount = amount - withdraw;
                            Console.WriteLine("\n\n PLEASE COLLECT CASH");
                            Console.WriteLine("\n YOUR CURRENT BALANCE IS {0}", amount);
                        }
                        break;
                    case 3:
                        Console.WriteLine("\n ENTER THE AMOUNT TO DEPOSIT");
                        deposit = int.Parse(Console.ReadLine());
                        amount = amount + deposit;
                        Console.WriteLine("YOUR BALANCE IS {0}", amount);
                        break;
                    case 4:
                        Console.WriteLine("\n THANK U USING ATM");
                        break;
                }
            }
            


        }
    }
}
