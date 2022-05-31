using System;
using System.Collections.Generic;
using System.Linq;

namespace _8._List_of_Predicates
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int upperBound=int.Parse(Console.ReadLine());
            List<int> numbers= new List<int>();
            int[] dividers = Console.ReadLine().Split(' ').Select(int.Parse).ToArray();
            for (int i=1; i<=upperBound; i++)
            {
                if (dividers.All(x => i % x == 0))
                {
                    numbers.Add(i);
                }
            }

            Console.WriteLine(String.Join(" ",numbers));

           
        }
    }
}
