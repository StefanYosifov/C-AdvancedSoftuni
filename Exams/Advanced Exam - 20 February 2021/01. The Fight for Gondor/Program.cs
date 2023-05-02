using System;
using System.Collections.Generic;
using System.Linq;

namespace _01._The_Fight_for_Gondor
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int numberOfWaves=int.Parse(Console.ReadLine());
            int[] firstArr = Console.ReadLine().Split(' ').Select(int.Parse).ToArray();
            Queue<int> plate = new Queue<int>(firstArr);
            Stack<int> orcs;
            for (int i = 1; i <= numberOfWaves; i++)
            {
              
                int[] secondArr= Console.ReadLine().Split(' ').Select(int.Parse).ToArray();
                orcs= new Stack<int>(secondArr);

                if (i % 3 == 0)
                {
                    string input = Console.ReadLine();
                    int plateToAdd = int.Parse(input);
                    plate.Enqueue(plateToAdd);
                }

                while(plate.Count > 0 && orcs.Count > 0)
                {
                    int peekPlate = plate.Peek();
                    int peekOrc=orcs.Peek();

                    
                    if (peekPlate <= 0)
                    {
                        plate.Dequeue();
                        continue;
                    }
                    if (peekPlate > peekOrc)
                    {
                        orcs.Pop();
                        plate.Dequeue();
                        plate.Enqueue(peekPlate-peekOrc);
                    }
                    else if (peekOrc > peekPlate)
                    {
                        plate.Dequeue();
                        orcs.Pop();
                        orcs.Push(peekOrc - peekPlate);
                    }
                    else if (peekOrc == peekPlate)
                    {
                        plate.Dequeue();
                        orcs.Pop();
                    }
                    if (peekPlate <= 0)
                    {
                        plate.Dequeue();
                        continue;
                    }

                }
                
            }
            Console.WriteLine(String.Join(", ", plate));
            //Console.WriteLine(String.Join(", ",orcs));
        }
    }
}
