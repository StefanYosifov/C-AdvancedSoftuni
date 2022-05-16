using System;
using System.Collections.Generic;

namespace _8._Traffic_Jam
{
    internal class Program
    {
        static void Main(string[] args)
        {
        
            
            int numberOfCarsThatCanPass=int.Parse(Console.ReadLine());
            Queue<string> cars = new Queue<string>();
            string nameOfCar=Console.ReadLine();
            int carsPassed = 0;

            while (nameOfCar != "end")
            {
                if (nameOfCar == "green")
                {
                    for(int i = 0; i < numberOfCarsThatCanPass; i++)
                    {
                        if (cars.Count == 0)
                        {
                            break;
                        }
                        string car = cars.Dequeue();
                        Console.WriteLine($"{car} passed!");
                        carsPassed++;
                    }
                }
                else
                {
                    cars.Enqueue(nameOfCar);
                }


                nameOfCar = Console.ReadLine();
            }
            Console.WriteLine($"{carsPassed} cars passed the crossroads.");
        }
    }
}
