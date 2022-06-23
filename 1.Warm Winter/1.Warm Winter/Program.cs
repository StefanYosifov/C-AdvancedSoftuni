using System;
using System.Collections.Generic;
using System.Linq;

namespace _1.Warm_Winter
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int[] firstArr = Console.ReadLine().Split(' ', StringSplitOptions.RemoveEmptyEntries).Select(int.Parse).ToArray();
            int[] secondArr= Console.ReadLine().Split(' ', StringSplitOptions.RemoveEmptyEntries).Select(int.Parse).ToArray();

            Queue<int> scarfs=new Queue<int>(secondArr);
            Stack<int> hats=new Stack<int>(firstArr);
            List<int> clothes = new List<int>();


            while(scarfs.Count>0 && hats.Count > 0)
            {
                int peekHats = hats.Peek();
                int peekScarfs = scarfs.Peek();

                int total = peekScarfs + peekHats;


                if (peekHats == peekScarfs)
                {
                    scarfs.Dequeue();
                    int takeLastHat = hats.Peek() + 1;
                    hats.Pop();
                    hats.Push(takeLastHat);
                }
                else if (peekHats > peekScarfs)
                {
                    clothes.Add(hats.Pop() + scarfs.Dequeue());
                }
                else if(peekScarfs> peekHats)
                {
                    hats.Pop();
                    
                }
                else
                {
                    break;
                }
            }


            Console.WriteLine($"The most expensive set is: {clothes.Max()}");
            Console.WriteLine(String.Join(" ",clothes));
        }
    }
}
