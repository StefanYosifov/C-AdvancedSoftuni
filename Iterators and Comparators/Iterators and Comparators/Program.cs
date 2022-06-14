using System;
using System.Collections.Generic;
using System.Linq;

namespace Iterators_and_Comparators
{
    internal class Program
    {
        static void Main(string[] args)
        {
            List<int> nums = new List<int>() { 10, 20, 30, 40, 50 };
            IEnumerable<int> eNums = nums;

            foreach(int num in eNums)
            {
                Console.WriteLine(num);
            }

            string[] arr = { "Hello", "World", "Of", "C#" };
            IEnumerable<string> eArr = arr.OrderBy(x => x);

        }
    }
}
