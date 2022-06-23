using System;
using System.Collections.Generic;
using System.Linq;

namespace _1.Bombs
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int[] firstArr = Console.ReadLine().Split(", ").Select(int.Parse).ToArray();
            int[] secondArr = Console.ReadLine().Split(", ").Select(int.Parse).ToArray();

            Queue<int> queue=new Queue<int>(firstArr);
            Stack<int> stack = new Stack<int>(secondArr);

            Dictionary<string, int> combinedBombs = new Dictionary<string, int>()
            {
                {"Datura Bombs",0 },
                {"Cherry Bombs",0 },
                {"Smoke Decoy Bombs",0 }
            };

            bool bombPouch = false;
            while (stack.Count > 0 && queue.Count > 0)
            {
                int peekQueue=queue.Peek();
                int peekStack = stack.Peek();
                int total=peekStack+peekQueue;
                if (total == 60)
                {
                    combinedBombs["Cherry Bombs"]++;
                    stack.Pop();
                    queue.Dequeue();
                   
                }
                else if (total == 40)
                {
                    combinedBombs["Datura Bombs"]++;
                    stack.Pop();
                    queue.Dequeue();
                    
                }
                else if (total == 120)
                {
                    combinedBombs["Smoke Decoy Bombs"]++;
                    stack.Pop();
                    queue.Dequeue();
                   
                }
                else
                {
                    int lastElementFromStack = stack.Peek()-5;
                    stack.Pop();
                    stack.Push(lastElementFromStack);
                    
                }
                if (combinedBombs.All(x => x.Value >= 3))
                {
                    bombPouch = true;
                    break;
                }
            }

            

            


            if (!bombPouch)
            {
                Console.WriteLine("You don't have enough materials to fill the bomb pouch.");
            }
            else
            {
                Console.WriteLine("Bene! You have successfully filled the bomb pouch!");
            }


            if(queue.Count >= 1)
            {
                Console.WriteLine($"Bomb Effects: {string.Join(", ",queue)}");
            }
            else if (queue.Count == 0)
            {
                Console.WriteLine("Bomb Effects: empty");
            }

            if (stack.Count >= 1)
            {
                Console.WriteLine($"Bomb Casings: {string.Join(", ", stack)}");
            }
            else if (stack.Count == 0)
            {
                Console.WriteLine($"Bomb Casings: empty");
            }

            foreach(var bomb in combinedBombs.OrderBy(x=>x.Key))
            {
                string bombName = bomb.Key;
                int bombCount = bomb.Value;

                Console.WriteLine($"{bombName}: {bombCount}");
            }

        }
    }
}
