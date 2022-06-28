using System;
using System.Linq;

namespace Testing
{
    internal class Program
    {
        static void Main(string[] args)
        {
            string[] input = Console.ReadLine().Split(new string[] {"||"," "},StringSplitOptions.RemoveEmptyEntries).ToArray();
            int fuel = int.Parse(Console.ReadLine());
            int ammunitions=int.Parse(Console.ReadLine());

            for(int i = 0; i < input.Length; i+=2)
            {
                string command = input[i];
                if (command == "Titan")
                {
                    Console.WriteLine($"You have reached Titan, all passengers are safe.");
                    return;
                }
                int number = int.Parse(input[i + 1]);
                if (command == "Travel")
                {
                    if (fuel >= number)
                    {
                        Console.WriteLine($"The spaceship travelled {number} light-years");
                        fuel -= number;
                    }
                    else
                    {
                        Console.WriteLine($"Mission failed");
                        return;
                    }
                }
                else if (command == "Enemy")
                {
                    if (ammunitions >= number)
                    {
                        Console.WriteLine($"An enemy with {number} armour is defeated.");
                    }
                    else
                    {
                        if (number * 2 > fuel)
                        {
                            Console.WriteLine($"Mission failed");
                            return;
                        }
                        else
                        {
                            fuel -= number * 2;
                            Console.WriteLine($"An enemy with {number} armour is outmaneuvered");
                        }
                    }
                }
                else if (command == "Repair")
                {
                    fuel+=number;
                    ammunitions = +number * 2;
                    Console.WriteLine($"Ammunitions added: {number*2}");
                    Console.WriteLine($"Fuel added: {number}");
                }
                
            }

        }
    }
}
