using System;
using System.Linq;

namespace _3.Stack
{
    public class StartUp
    {
        static void Main(string[] args)
        {
            var Stack = new Stack<string>();
            while (true)
            {
                var tokens = Console.ReadLine().Split();
                if (tokens[0] == "END")
                {
                    break;
                }
                else if (tokens[0] == "Push")
                {
                    Stack.Push(tokens.Skip(1).Select(x => x.Split(",").First()).ToArray());
                }
                else if(tokens[0] == "Pop")
                {
                    try
                    {
                        Stack.Pop();
                    }
                    catch (ArgumentException ae)
                    {

                        Console.WriteLine(ae.Message);
                    }
                }
            }
            foreach(var element in Stack)
            {
                Console.WriteLine(element);
            }
        }
    }
}
