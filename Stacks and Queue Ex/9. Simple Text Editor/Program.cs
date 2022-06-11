using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Problem_9.__Simple_Text_Editor
{
    class Program
    {
        static void Main()
        {
            var n = int.Parse(Console.ReadLine());
            var builder = new StringBuilder();
            var stack = new Stack<string>();

            for (int i = 0; i < n; i++)
            {
                var commandLine = Console.ReadLine().Split().ToArray();
                var command = commandLine[0];

                switch (command)
                {
                    case "1":
                        builder.Append(commandLine[1]);
                        stack.Push(builder.ToString());
                        break;

                    case "2":
                        var count = int.Parse(commandLine[1]);
                        builder.Remove(builder.Length - count, count);
                        stack.Push(builder.ToString());
                        break;
                    case "3":
                        var index = int.Parse(commandLine[1]);
                        Console.WriteLine(builder[index - 1]);
                        break;
                    case "4":
                        if (stack.Any())
                        {
                            stack.Pop();
                            builder = new StringBuilder();
                            builder.Append(stack.Peek());

                        }

                        break;
                }
            }
        }
    }
}

 


