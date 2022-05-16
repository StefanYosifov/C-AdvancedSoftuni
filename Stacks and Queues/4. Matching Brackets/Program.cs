using System;
using System.Collections.Generic;

namespace _4._Matching_Brackets
{
    internal class Program
    {
        static void Main(string[] args)
        {
           string expresion=Console.ReadLine();
            var stack = new Stack<int>();
            int index = 0;
            foreach(var ch in expresion)
            {
                if (ch == '(')
                {
                    stack.Push(index);
                }
                else if(ch == ')')
                {
                    int startIndex=stack.Pop();
                    int endIndex=index;
                    string subString =expresion.Substring(startIndex, endIndex - startIndex + 1);
                    Console.WriteLine(subString);
                }
                index++;
            }
        }
    }
}
