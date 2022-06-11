using System;
using System.Collections.Generic;
using System.Linq;



    internal class Program
    {
        static void Main(string[] args)
        {


            int[] elements = Console.ReadLine().Split(' ').Select(int.Parse).ToArray();
            int N = elements[0];
            int S = elements[1];
            int X = elements[2];


        Queue<int> queue = new Queue<int>();
            int[] ElementsToPush = Console.ReadLine().Split(' ', StringSplitOptions.RemoveEmptyEntries).Select(int.Parse).ToArray();
            for (int i = 0; i < N; i++)
            {
                queue.Enqueue(ElementsToPush[i]);
            }

            for (int i = 0; i < S; i++)
            {
                queue.Dequeue();
            }

            if (queue.Count == 0)
            {
                Console.WriteLine(0);
            }
            else if (queue.Contains(X))
            {
                Console.WriteLine("true");
            }
            else
            {
                Console.WriteLine(queue.Min());
            }

        }
    }

