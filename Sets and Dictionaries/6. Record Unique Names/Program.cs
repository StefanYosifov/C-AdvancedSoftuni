using System;
using System.Collections.Generic;

namespace _6._Record_Unique_Names
{
    internal class Program
    {
        static void Main(string[] args)
        {
            HashSet<string> uniqueNames=new HashSet<string>();
            int loops=int.Parse(Console.ReadLine());
            for(int i=0; i<loops; i++)
            {
                uniqueNames.Add(Console.ReadLine());
            }
          
           foreach(var name in uniqueNames)
            {
                Console.WriteLine(name);
            }
        }
    }
}
