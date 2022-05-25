using System;
using System.Collections.Generic;
using System.Linq;

namespace _3._Periodic_Table
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int loops=int.Parse(Console.ReadLine());
            HashSet<string> chemicalElements=new HashSet<string>();

            for(int i=0; i<loops; i++)
            {
                string[] elements=Console.ReadLine().Split(' ').ToArray();
                foreach(var element in elements)
                {
                    chemicalElements.Add(element);
                }

            }

            Console.WriteLine(string.Join(" ",chemicalElements.OrderBy(x=>x)));
        }
    }
}
