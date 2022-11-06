using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp.Week2
{
    internal class IterationStatement
    {
        public static void DoWhile(int num)
        {
            do
            {
                Console.WriteLine(num++);
            }
            while (num < 10);
        }

        public static void ForLoop()
        {
            int[] arr = { 1, 2, 3, 4, 5, 6, 7, 8, 9 };

            for (int i = 0; i < arr.Length; i++)
            {
                Console.WriteLine(arr[i]);
            }
        }

        public static void ForEachLoop()
        {
            int[] arr = { 1, 2, 3, 4, 5, 6, 7, 8, 9 };

            foreach(int i in arr)
            {
                Console.WriteLine(i);
            }

        }
    }
}
