using System;
using System.Collections.Generic;
using System.Linq;

namespace TruckTour
{
    class Program
    {
        static void Main()
        {
            int pupmsCount = int.Parse(Console.ReadLine()); 
            Queue<int> petrolAmount = new Queue<int>(); 
            Queue<int> distance = new Queue<int>(); 

            
            for (int i = 0; i < pupmsCount; i++)
            {
                int[] userInput = Console.ReadLine()
                    .Split(" ", StringSplitOptions.RemoveEmptyEntries)
                    .Select(int.Parse)
                    .ToArray();

                petrolAmount.Enqueue(userInput[0]);
                distance.Enqueue(userInput[1]);
            }

            int fuel = petrolAmount.Peek(); 
            int smallestIndex = 0;
            int currentIndex = 0; 
            int stationsPassedCounter = 0; 

            while (stationsPassedCounter <= pupmsCount) 
            {
                if (stationsPassedCounter == 0)
                {
                    smallestIndex = currentIndex; 
                }

                if (fuel >= distance.Peek()) 
                {
                    fuel -= distance.Peek(); 
                    stationsPassedCounter++; 

                    petrolAmount.Enqueue(petrolAmount.Dequeue());
                    distance.Enqueue(distance.Dequeue());
                    fuel += petrolAmount.Peek(); 
                }
                else 
                {
                    petrolAmount.Enqueue(petrolAmount.Dequeue()); 
                    distance.Enqueue(distance.Dequeue());

                    fuel = petrolAmount.Peek(); 
                    stationsPassedCounter = 0;                  
                }

                currentIndex++;
            }

            
            Console.WriteLine(smallestIndex);
        }
    }
}