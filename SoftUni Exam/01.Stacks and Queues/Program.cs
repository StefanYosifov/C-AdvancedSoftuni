using System;
using System.Linq;
using System.Collections.Generic;

namespace _01.Stacks_and_Queues
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int[] firstArr;
            int[] secondArr;

            Dictionary<string, int> createdTails = new Dictionary<string, int>();
            createdTails.Add("Sink", 0);
            createdTails.Add("Oven", 0);
            createdTails.Add("Countertop", 0);
            createdTails.Add("Wall", 0);
            createdTails.Add("Floor", 0);

            Stack<int> white=new Stack<int>(Console.ReadLine().Split(' ',StringSplitOptions.RemoveEmptyEntries).Select(int.Parse).ToArray());
            Queue<int> grey = new Queue<int>(Console.ReadLine().Split(' ', StringSplitOptions.RemoveEmptyEntries).Select(int.Parse).ToArray());

            while(white.Count > 0 && grey.Count > 0)
            {
                int peekWhite = white.Peek();
                int peekGrey = grey.Peek();
                int total = peekWhite + peekGrey;

                if (peekWhite == peekGrey)
                {
                    if (total == 40)
                    {
                        createdTails["Sink"]++;
                        grey.Dequeue();
                        white.Pop();
                    }
                    else if (total == 50)
                    {
                        createdTails["Oven"]++;
                        grey.Dequeue();
                        white.Pop();
                    }
                    else if (total == 60)
                    {
                        createdTails["Countertop"]++;
                        grey.Dequeue();
                        white.Pop();
                    }
                    else if (total == 70)
                    {
                        createdTails["Wall"]++;
                        grey.Dequeue();
                        white.Pop();
                    }
                    else
                    {
                        createdTails["Floor"]++;
                        grey.Dequeue();
                        white.Pop();
                    }
                }
                else
                {
                    white.Pop();
                    white.Push(peekWhite / 2);
                    grey.Dequeue();
                    grey.Enqueue(peekGrey);
                }

            }
            if (white.Count == 0)
            {
                Console.WriteLine("White tiles left: none");
            }
            else
            {
                Console.WriteLine($"White tiles left: {string.Join(", ", white)}");
            }

            if (grey.Count == 0)
            {
                Console.WriteLine("Grey tiles left: none");
            }
            else
            {
                Console.WriteLine($"Grey tiles left: {string.Join(", ", grey)}");
            }

            foreach (var floor in createdTails.OrderByDescending(x => x.Value).ThenBy(x => x.Key).Where(x=>x.Value>0))
            {
                string floorName = floor.Key;
                int floorCount = floor.Value;
                Console.WriteLine($"{floorName}: {floorCount}");
            }
        }
    }
}
