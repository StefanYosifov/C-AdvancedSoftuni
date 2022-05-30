using System;
using System.Linq;
using System.Text.RegularExpressions;

namespace _3._Count_Uppercase_Words
{
    internal class Program
    {
        static void Main(string[] args)
        {
           
            Predicate<string> filter=(string x) => char.IsUpper(x[0]);
            Console.WriteLine(String.Join("\r\n",Console.ReadLine().Split(' ').Where(x=>x.Length>0 && char.IsUpper(x[0]))));

        }
    }
}
