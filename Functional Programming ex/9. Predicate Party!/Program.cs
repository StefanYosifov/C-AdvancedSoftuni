using System;
using System.Linq;

namespace _9._Predicate_Party_
{
    internal class Program
    {
        static void Main(string[] args)
        {
            string[] names = Console.ReadLine().Split(' ').ToArray();
            string token=Console.ReadLine();
            while (token != "Party!")
            {
                string[] command=token.Split(' ');
                string action=command[0];


                token = Console.ReadLine();
            }
        }
    }
}
