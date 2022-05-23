using System;
using System.Collections.Generic;
using System.Linq;

namespace _8._SoftUni_Party
{
    internal class Program
    {
        static void Main(string[] args)
        {
            HashSet<string> party=new HashSet<string>();
            string input=Console.ReadLine();
            while (input != "PARTY")
            {
                party.Add(input);
                input = Console.ReadLine();
            }
            input = Console.ReadLine();
            while (input != "END")
            {
                party.Remove(input);
                input = Console.ReadLine();
            }
            Console.WriteLine(party.Count);
         
            
            foreach(var guest in party)
            {
                Console.WriteLine(guest);
            }
        }
    }
}
