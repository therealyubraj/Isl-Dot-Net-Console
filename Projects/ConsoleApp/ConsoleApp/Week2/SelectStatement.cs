using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp.Week2
{
    internal class SelectStatement
    {
        public static void IfElse()
        {
            Console.Write("Enter a number: ");
            var num1 = Convert.ToInt32(Console.ReadLine());
            Console.Write("Enter another number: ");
            var num2 = Convert.ToInt32(Console.ReadLine());

            if (num1 > num2)
            {
                Console.WriteLine($"{num1} is greater");
            }
            else if (num1 < num2)
            {
                Console.WriteLine($"{num2} is greater");
            }
            else
            {
                Console.WriteLine($"{num1} = {num2}");
            }
        }

        public static void SwitchCase()
        {
            Console.WriteLine("Press 1 for apple, 2 for orange: ");
            var usrIp = Convert.ToInt32(Console.ReadLine());

            switch (usrIp)
            {
                case 1:
                    Console.WriteLine("Apple");
                    break;
                case 2:
                    Console.WriteLine("Orange");
                    break;
                default:
                    Console.WriteLine("Inavlid input");
                    break;
            }
        }
    }
}
