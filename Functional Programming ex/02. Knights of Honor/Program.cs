using System;
using System.Linq;

namespace _02._Knights_of_Honor
{
    internal class Program
    {
        static void Main(string[] args)
        {
            string inputNames = Console.ReadLine();
            Action<string> action = PrintNamesWithHonors;
            action(inputNames);

        }


        public static void PrintNamesWithHonors(string text)
        {
            string[] names = text.Split(' ').ToArray();
            names.ToList().ForEach(name => Console.WriteLine($"Sir {name}"));
        }
    }
}

