using System;
using System.Collections.Generic;
using System.Linq;

namespace _5._Fashion_Boutique
{
    internal class Program
    {
        static void Main(string[] args)
        {
            
            int[] nums=Console.ReadLine().Split(' ').Select(int.Parse).ToArray();
            var racks = new Stack<int>(nums);

            int rackCapacity=int.Parse(Console.ReadLine());


            int sumClothes = 0;
            int totalRacks = 1;
            while(racks.Count > 0)
            {
               int nextClothe=racks.Pop();
                if (sumClothes + nextClothe <= rackCapacity)
                {
                        sumClothes+=nextClothe;
                }
                else
                {
                    sumClothes = nextClothe;
                    totalRacks++;
                }



                
            }
            Console.WriteLine(totalRacks);
        }
    }
}
