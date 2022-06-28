using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;

namespace A
{
    internal class Program
    {
        static int firstNumber;
        static int secondNumber;
        static void Main()
        {
            firstNumber = 1;
            secondNumber = 2;
            Change();
            Console.WriteLine(firstNumber);
            Console.WriteLine(secondNumber);
             
            
        }

        static void Change()
        {
            int firstNumber = 2;
            int secondNumber += 1;
        }

        static void Recursion(int a)
        {
            if (a > 0)
            {
                Recursion(a - 1);
            }
            Console.WriteLine(a);
        }

        public static void PrintArray(int[] arr)
        {
           for(int i = 0; i < arr.Length; i++)
            {
                Console.WriteLine(arr[i]);
            }
        }

        static int ReturnNumber(int[] arr)
        {
            for (int i = 0; i < arr.Length; i++)
            {
                if (arr[i] >= 100)
                {
                    return arr[i];
                }
            }
            return 0;
        }
    }
}
