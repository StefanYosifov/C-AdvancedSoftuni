using System;
using System.Collections.Generic;
using System.Linq;

namespace _4._Find_Evens_or_Odds
{
    internal class Program
    {
        static void Main(string[] args)
        { 
            int[] bounds=Console.ReadLine().Split(' ').Select(int.Parse).ToArray();
            int lower=bounds[0];
            int upper = bounds[1];
            List<int> nums = new List<int>();
            for(int i=lower; i<=upper; i++)
            {
                nums.Add(i);
            }

            Predicate<int> isEven = number => number % 2 == 0;

            string action=Console.ReadLine();
            if (action == "even")
            {
                foreach(int number in nums)
                {
                    if (isEven(number))
                    {
                        Console.Write($"{number} ");
                    }
                }
            }
            else if(action =="odd")
            {
                foreach (int number in nums)
                {
                    if (!isEven(number))
                    {
                        Console.Write($"{number} ");
                    }
                }
            }
           
            
        }

        static bool IsEven(int[] array)
        {
            return array.Where(x=>x%2 == 0).Any();
        }
        static bool isOdd(int[] array)
        {
            return array.Where(x=>x%2== 1).Any();   
        }
    }
}
