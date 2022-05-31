using System;
using System.Collections.Generic;
using System.Linq;

namespace _5._Applied_Arithmetics
{
    internal class Program
    {
        static void Main(string[] args)
        {
            
            List<int> nums=Console.ReadLine().Split(' ').Select(int.Parse).ToList();
            string action = Console.ReadLine();
            while (action!="end")
            {
               
                if (action == "add")
                {
                    Func<List<int>,List<int>> addOne= list=>list.Select(x=>x+=1).ToList();
                    nums=addOne(nums);
                }
                if(action== "subtract")
                {
                    Func<List<int>, List<int>> subtract = list => list.Select(x => x -= 1).ToList();
                    nums=subtract(nums);
                }
                if(action=="multiply")
                {
                    Func<List<int>, List<int>> multiply = list => list.Select(x => x*=2).ToList();
                    nums=multiply(nums);
                }
                if (action == "print")
                {
                    Action<List<int>> print = list => Console.WriteLine(String.Join(" ",list));
                    print(nums);
                }


                action = Console.ReadLine();
            }
        }
      
       
    }
}
