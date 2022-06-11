using System;
using System.Collections.Generic;
using System.Linq;

namespace _03._Maximum_and_Minimum_Element
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int numberOfIterations = int.Parse(Console.ReadLine());
            Stack<int> numbers = new Stack<int>();

            for (int i = 0; i < numberOfIterations; i++)
            {
                int[] commandWithValue = Console.ReadLine().Split(' ').Select(int.Parse).ToArray();
                int command = commandWithValue[0];


                if (command == 1)
                {
                    int value = commandWithValue[1];
                    numbers.Push(value);
                }

                if (command == 2)
                {
                    bool emptyStack = StackIsEmpty(numbers);
                    if (!emptyStack)
                    {
                        numbers.Pop();
                    }
                }

                if (command == 3)
                {
                    bool emptyStack=StackIsEmpty(numbers);
                    if (!emptyStack)
                    {
                        Console.WriteLine(numbers.Max());
                    }
                }

                if (command == 4)
                {
                    bool emptyStack = StackIsEmpty(numbers);
                    if (!emptyStack)
                    {
                        Console.WriteLine(numbers.Min());
                    }
                }
            }

            Console.WriteLine(string.Join(", ",numbers));
        }

        static public bool StackIsEmpty(Stack<int> stack)
        {
            return stack.Count==0;
        }
    }
}
