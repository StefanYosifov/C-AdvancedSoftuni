using System;
using System.Collections.Generic;
using System.Linq;

namespace _2._Sets_of_Elements
{
    internal class Program
    {
        static void Main(string[] args)
        {
           int[] twoNums=Console.ReadLine().Split(' ').Select(int.Parse).ToArray();
           int firstHashSetLenght = twoNums[0];
           int secondHashSetLenght = twoNums[1];

            HashSet<int> firstSet=new HashSet<int>();
            for(int i=0;i<firstHashSetLenght; i++)
            {
                int inputNumber=int.Parse(Console.ReadLine());
                firstSet.Add(inputNumber);
            }


            HashSet<int> secondSet=new HashSet<int>();
            for(int i = 0; i < secondHashSetLenght; i++)
            {
                int inputNumber = int.Parse(Console.ReadLine());
                secondSet.Add(inputNumber);
            }

            foreach(var element in firstSet)
            {
                if (secondSet.Contains(element))
                {
                    Console.Write($"{element} ");
                }
            }
        }
    }
}
