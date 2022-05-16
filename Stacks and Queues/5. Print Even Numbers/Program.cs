using System;
using System.Collections.Generic;
using System.Linq;

namespace _5._Print_Even_Numbers
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int[] inputArr=Console.ReadLine().Split(' ').Select(int.Parse).ToArray();
            Queue<int> queue = new Queue<int>(inputArr);

            Console.WriteLine(String.Join(", ",queue.Where(x=>x%2==0)));

        }
    }
}


