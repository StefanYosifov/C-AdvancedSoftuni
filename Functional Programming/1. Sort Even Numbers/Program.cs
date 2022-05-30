using System;
using System.Linq;

namespace _1._Sort_Even_Numbers
{
    internal class Program
    {
        static void Main(string[] args)
        {
           int[] numbers = Console.ReadLine().Split(", ").Select(int.Parse).OrderBy(x=>x).Where(x=>x%2==0).ToArray();
            Console.WriteLine(String.Join(", ",numbers));
        }
    }
}
