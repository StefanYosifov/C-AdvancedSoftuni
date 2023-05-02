using System;
using System.Collections.Generic;
using System.Linq;

namespace Advanced_Exam___22_Feb_2020
{
    internal class Program
    {
        static void Main(string[] args)
        {
            List<int> firtsArr = Console.ReadLine().Split(' ').Select(int.Parse).ToList();
            List<int> secondArr = Console.ReadLine().Split(' ').Select(int.Parse).ToList();

            LinkedList<int> queue = new LinkedList<int>(firtsArr);
            LinkedList<int> stack = new LinkedList<int>(secondArr);
            int collection = 0;

            while (queue.Count > 0 && stack.Count > 0)
            {
                int peekFromQueue = queue.ElementAt(0);
                int peekFromStack = stack.ElementAt(stack.Count - 1);
                int total = peekFromStack + peekFromQueue;

                if (total % 2 == 0)
                {

                    collection += peekFromQueue;
                    collection += peekFromStack;
                    stack.RemoveLast();
                    queue.RemoveFirst();
                }
                else
                {
                    int addLast = stack.Last();
                    stack.RemoveLast();
                    queue.AddLast(addLast);
                }


            }

            if (queue.Count <= 0)
            {
                Console.WriteLine($"First lootbox is empty");
            }
            else if (stack.Count <= 0)
            {
                Console.WriteLine($"Second lootbox is empty");
            }

            if (collection >= 100)
            {
                Console.WriteLine($"Your loot was epic! Value: {collection}");
            }
            else
            {
                Console.WriteLine($"Your loot was poor... Value: {collection}");
            }

        }
    }
}
