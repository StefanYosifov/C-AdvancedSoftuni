using System;
using System.Linq;

namespace _1._Action_Point
{
    internal class Program
    {
        static void Main(string[] args)
        {

            string input=Console.ReadLine();
            Action<string> action = ConsolePrint;
            action(input);  
        }

        static void ConsolePrint(string text)
        {
            string[] lines = text.Split(' ').ToArray();
            lines.ToList().ForEach(line => Console.WriteLine(line));
        }
    }
}
