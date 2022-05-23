using System;
using System.Collections.Generic;
using System.Linq;

namespace _1._Count_Same_Values_in_Array
{
    internal class Program
    {
        static void Main(string[] args)
        {
           double[] numbers=Console.ReadLine().Split(' ').Select(double.Parse).ToArray();
            var countNumbers = new Dictionary<double, int>();

            foreach (var number in numbers)
            {
                if (countNumbers.ContainsKey(number))
                {
                    countNumbers[number]++;
                }
                else
                {
                    countNumbers[number] = 1;
                }
            }

            foreach(var numberCount in countNumbers)
            {
                double number = numberCount.Key;
                int numberRepeats=numberCount.Value;

                Console.WriteLine($"{number} - {numberRepeats} times");
            }
        }
    }
}
