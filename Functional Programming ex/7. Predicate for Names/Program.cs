using System;
using System.Linq;

namespace _7._Predicate_for_Names
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int lenght=int.Parse(Console.ReadLine());
            string[] namesArr=Console.ReadLine().Split(' ').ToArray();
            Predicate<string> isLessThan=x=>x.Length<=lenght;
            foreach(var name in namesArr)
            {
                if (isLessThan(name))
                {
                    Console.WriteLine(name);
                }
            }
        }
    }
}
