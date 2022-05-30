using System;
using System.Linq;

namespace Functional_Programming
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine(
                Console.ReadLine()
                .Split()
                .Select(int.Parse)
                .Max()

                );
            Print();

        }

        static void Print() => Console.WriteLine("Hi");

       
    }
}
