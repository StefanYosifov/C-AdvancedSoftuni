using System;
using System.Collections.Generic;
using System.Linq;

namespace _4._Even_Times
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int loops = int.Parse(Console.ReadLine());
            //HashSet<int> uniqueNumbers=new HashSet<int>();
            //HashSet<int> repeatNumbers=new HashSet<int>();
            //for(int i=0; i<loops; i++)
            //{
            //    int inputNumber = int.Parse(Console.ReadLine());
            //    if (uniqueNumbers.Contains(inputNumber))
            //    {
            //        repeatNumbers.Add(inputNumber);
            //    }
            //    else
            //    {
            //        uniqueNumbers.Add(inputNumber);
            //    }
            //}

            //Console.WriteLine(String.Join(" ",repeatNumbers));



            var numbers=new Dictionary<int, int>();
            for(int i= 0; i < loops; i++)
            {
                int inputNumber=int.Parse(Console.ReadLine());
                if (numbers.ContainsKey(inputNumber))
                {
                    numbers[inputNumber]++;
                }
                else
                {
                    numbers.Add(inputNumber, 1);
                }
            }

            var orderedDictionary = numbers.First(x => x.Value % 2 == 0).Key;

            Console.WriteLine(orderedDictionary);
        }
    }
}
