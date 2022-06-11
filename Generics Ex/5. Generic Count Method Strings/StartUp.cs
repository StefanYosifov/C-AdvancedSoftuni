using System;
using System.Collections.Generic;

namespace Box 
{
    public class StartUp
    {
        static void Main(string[] args)
        {
            int numberOfLines=int.Parse(Console.ReadLine());
            var list = new List<string>();
            for(int i=0; i<numberOfLines; i++)
            {
                string input=Console.ReadLine();
                list.Add(input);
            }

            var box=new Box<string>(list);
            var elementToCompare=Console.ReadLine();
            var count = box.CountOfGreaterElements(list,elementToCompare);
            Console.WriteLine(count);
        }
    }
}
