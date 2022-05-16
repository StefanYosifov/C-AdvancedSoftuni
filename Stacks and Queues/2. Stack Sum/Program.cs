using System;
using System.Collections.Generic;
using System.Linq;

namespace _2._Stack_Sum
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int[] elements = Console.ReadLine().Split(' ').Select(int.Parse).ToArray();
            Stack<int> stack = new Stack<int>(elements);
           

            string command=Console.ReadLine();

            while (command!="end")
            {
                string[] cmd=command.Split(' ').ToArray();
                string action=cmd[0];
                if (action.ToLower() == "add")
                {
                    int firstNumber = int.Parse(cmd[1]);
                    int secondNumber = int.Parse(cmd[2]);
                    stack.Push(firstNumber);
                    stack.Push(secondNumber);
                }
                if (action.ToLower() == "remove")
                {
                    int removeElements = int.Parse(cmd[1]);
                    if(removeElements > stack.Count)
                    {
                        command=Console.ReadLine();
                        continue;
                    }
                    for(int i = 0; i < removeElements; i++)
                    {
                        stack.Pop();
                    }
                }



                command= Console.ReadLine();    
            }
            Console.WriteLine($"Sum: {stack.Sum()}");
        }
    }
}
