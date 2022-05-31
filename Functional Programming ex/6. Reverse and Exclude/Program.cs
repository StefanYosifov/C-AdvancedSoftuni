using System;
using System.Linq;

namespace _6._Reverse_and_Exclude
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int[] nums=Console.ReadLine().Split(' ').Select(int.Parse).ToArray();
            int divideBy=int.Parse(Console.ReadLine());
            int[] nonDivisibleArr = nums.Where(x => x % divideBy != 0).Reverse().ToArray();
            Console.WriteLine(String.Join(" ",nonDivisibleArr));
        }
    }
}
