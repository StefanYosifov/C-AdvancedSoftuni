﻿using System;
using System.Collections.Generic;
using System.Linq;

namespace Box
{
    public class StartUp
    {
        static void Main(string[] args)
        {
            int loops = int.Parse(Console.ReadLine());
            var list = new List<int>();
            for(int i = 0; i < loops; i++)
            {
                int input=int.Parse(Console.ReadLine());
                list.Add(input);
            }
            var box=new Box<int>(list);
            int[] indexes=Console.ReadLine().Split(' ').Select(int.Parse).ToArray();
            box.Swap(list, indexes[0], indexes[1]);
            Console.WriteLine(box);

        }
    }
}
