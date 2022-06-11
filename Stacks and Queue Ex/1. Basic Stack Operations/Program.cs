using System;
using System.Collections.Generic;
using System.Linq;

namespace _1._Basic_Stack_Operations
{
    internal class Program
    {
        static void Main(string[] args)
        {
            
        
            int[] elements=Console.ReadLine().Split(' ').Select(int.Parse).ToArray();
            int N = elements[0];
            int S=elements[1];
            int X=elements[2];


            Stack<int> stack = new Stack<int>();
            int[] ElementsToPush=Console.ReadLine().Split(' ',StringSplitOptions.RemoveEmptyEntries).Select(int.Parse).ToArray();
            for(int i = 0; i < N; i++)
            {
                stack.Push(ElementsToPush[i]);
            }

            for(int i=0; i < S; i++)
            {
                stack.Pop();
            }

            if(stack.Count == 0)
            {
                Console.WriteLine(0);
            }
            else if (stack.Contains(X))
            {
                Console.WriteLine("true");
            }
            else
            {
                Console.WriteLine(stack.Min());
            }

        }
    }
}
