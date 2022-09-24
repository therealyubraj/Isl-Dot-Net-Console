using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp.Calculator
{
    public class Calculator
    {
        public void PrintMainMenu()
        {
            Console.WriteLine("What would you like to do?: ");
            Console.WriteLine("1: Add");
            Console.WriteLine("2: Subtract");
            Console.WriteLine("3: Multiply");
            Console.WriteLine("4: Divide");
            Console.WriteLine("5: Concat");

            int operation = int.Parse(Console.ReadLine());


            if (operation < 5)
            {
                Console.WriteLine("Enter the first number:");
                int num1 = int.Parse(Console.ReadLine());

                Console.WriteLine("Enter the second number:");
                int num2 = int.Parse(Console.ReadLine());
                switch (operation)
                {
                    case 1:
                        Console.WriteLine($"The sum is: {Add(num1, num2)}");
                        break;
                    case 2:
                        Console.WriteLine($"The subtraction is: {Sub(num1, num2)}");
                        break;
                    case 3:
                        Console.WriteLine($"The product is: {Mult(num1, num2)}");
                        break;
                    case 4:
                        Console.WriteLine($"The division is: {Divide(num1, num2)}");
                        break;
                    case 5:
                        Console.WriteLine($"The concat is: {num1 + "" + num2}");
                        break;
                    default:
                        Console.WriteLine("Invalid input!");
                        break;
                }
            }
            else
            {
                if (operation == 5)
                {
                    Console.WriteLine("Enter the first value:");
                    string val1 = Console.ReadLine();

                    Console.WriteLine("Enter the second value:");
                    string val2 = Console.ReadLine();
                    Console.WriteLine($"The concat is: {val1 + val2}");
                }
                else
                {
                    Console.WriteLine("Invalid input!");
                }
            }
        }

        public static void RunApp()
        {
            string userIp = "y";
            Calculator c = new Calculator();
            while (userIp == "y")
            {
                c.PrintMainMenu();
                Console.WriteLine("Would you like to do it again? y/n");
                userIp = Console.ReadLine();
            }
        }

        public int Add(int a, int b)
        {
            return a + b;
        }
        public int Sub(int a, int b)
        {
            return a - b;
        }
        public int Mult(int a, int b)
        {
            return a * b;
        }
        public int Divide(int a, int b)
        {
            return a / b;
        }
    }
}
