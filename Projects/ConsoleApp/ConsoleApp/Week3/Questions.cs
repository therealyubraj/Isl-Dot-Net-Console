using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp.Week3
{
    public class Questions
    {
        public static bool isPrime(int x)
        {
            // assuming x >= 2
            if (x < 2)
            {
                Console.WriteLine("Cant do this sorry!");
                return false;
            }

            bool p = true;

            for (var i = 2; i < x; i++)
            {
                if (x % i == 0)
                {
                    p = false;
                    break;
                }
            }

            return p;
        }

        public static bool isEven(int x)
        {
            return x % 2 == 0;
        }

        public static void swapValues(int a, int b)
        {
            var tmp = a;
            a = b;
            b = tmp;
            Console.WriteLine($"Swapped: a:{a}, b:{b}");
        }

        public static int searchString(string s, string[] arr)
        {
            for (var i = 0; i < arr.Length; i++)
            {
                if (arr[i] == s.ToLower()) return i;
            }
            return -1;
        }
    }
}
