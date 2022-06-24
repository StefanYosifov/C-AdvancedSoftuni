using System;
using System.Collections.Generic;
using System.Linq;

namespace _01._Scheduling
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int[] firstArr = Console.ReadLine().Split(", ", StringSplitOptions.RemoveEmptyEntries).Select(int.Parse).ToArray();
            int[] secondArr = Console.ReadLine().Split(' ', StringSplitOptions.RemoveEmptyEntries).Select(int.Parse).ToArray();
            int taskToKill = int.Parse(Console.ReadLine());

            Queue<int> threads = new Queue<int>(secondArr);
            Stack<int> tasks = new Stack<int>(firstArr);

            while(threads.Count > 0 && tasks.Count > 0)
            {
                int peekTask = tasks.Peek();
                int peekThread = threads.Peek();
                if (peekTask == taskToKill)
                {
                    Console.WriteLine($"Thread with value {peekThread} killed task {peekTask} ");
                    Console.WriteLine(String.Join(' ',threads));
                    return;
                }
                else if (peekThread >= peekTask)
                {
                    tasks.Pop();
                    threads.Dequeue();
                }
                else if (peekThread < peekTask)
                {
                    threads.Dequeue();
                }


            }


        }
    }
}
