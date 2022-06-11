using System;
using System.Linq;
using System.Collections.Generic;

namespace _4._Fast_Food
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int foodQuanity=int.Parse(Console.ReadLine());
            int[] orders=Console.ReadLine().Split(' ').Select(int.Parse).ToArray();
            Queue<int> leftOverOrders = new Queue<int>();

            foreach(int order in orders)
            {
                foodQuanity-=order;
                if (foodQuanity < 0)
                {
                    leftOverOrders.Enqueue(order);
                }
            }

            Console.WriteLine(orders.Max());
            if (leftOverOrders.Count == 0)
            {
                Console.WriteLine("Orders complete");
                return;
            }
            Console.Write($"Orders left: ");
            Console.Write(string.Join(' ',leftOverOrders));
        }
    }
}
