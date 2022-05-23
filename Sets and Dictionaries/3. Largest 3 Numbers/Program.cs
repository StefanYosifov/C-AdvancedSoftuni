using System;
using System.Linq;

namespace _3._Largest_3_Numbers
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int[] numbers=Console.ReadLine().Split(' ').Select(int.Parse).ToArray();
            int[] sortedNumbers=numbers.OrderByDescending(x=>x).ToArray();
            if (sortedNumbers.Count() < 3)
            {
                foreach(var number in sortedNumbers)
                {
                    Console.Write($"{number} ");
                }
            }
            else
            {
                for(int i = 0; i < 3; i++)
                {
                    Console.Write($"{sortedNumbers[i]} ");
                }
            }
        }
    }
}
