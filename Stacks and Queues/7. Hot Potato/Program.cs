using System;
using System.Collections.Generic;
using System.Linq;

namespace _7._Hot_Potato
{
    internal class Program
    {
        static void Main(string[] args)
        {
            string[] namesArr=Console.ReadLine().Split(' ',StringSplitOptions.RemoveEmptyEntries);
            Queue<string> names=new Queue<string>(namesArr);
            int numberOfPasses=int.Parse(Console.ReadLine());
            
            while (names.Count > 1)
            {
                for(int i = 1; i < numberOfPasses; i++)
                {
                    if (names.Count == 1)
                    {
                        break;
                    }
                    var player=names.Dequeue();
                    names.Enqueue(player);
                }
                string lostPlayer=names.Dequeue();
                Console.WriteLine($"Removed {lostPlayer}");
            }
            
            Console.WriteLine($"Last is {names.Dequeue()}");
        }
    }
}
