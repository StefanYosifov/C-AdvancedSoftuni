using System;
using System.Collections.Generic;
using System.Linq;

namespace _01._Birthday_Celebration
{
    internal class Program
    {
        static void Main(string[] args)
        {

            int[] firstArr = Console.ReadLine().Split(' ').Select(int.Parse).ToArray();
            int[] secondArr = Console.ReadLine().Split(' ').Select(int.Parse).ToArray();


            Queue<int> guests= new Queue<int>(firstArr);
            Stack<int> plates = new Stack<int>(secondArr);
            int wastedFood = 0;


            while(guests.Count>0 && plates.Count > 0)
            {
                int guestValue=guests.Peek();
                int platesValue = plates.Peek();

                if (guestValue <= 0)
                {
                    guests.Dequeue();
                }
                if (guestValue > platesValue)
                {
                    guests.Dequeue();
                    plates.Pop();

                    // When a guest's integer value reaches 0 or less, it gets removed.
                    // It is possible that the current guest's value is greater than the current food's value.
                    // In that case you pick plates until you reduce the guest's integer value to 0 or less.
                    guests = new Queue<int>(guests.Reverse());
                    guests.Enqueue(guestValue - platesValue);
                    guests = new Queue<int>(guests.Reverse());
                }
                else if (platesValue >= guestValue)
                {
                    wastedFood += platesValue - guestValue;
                    plates.Pop();
                    guests.Dequeue();

                }
                else
                {
                    plates.Pop();
                    guests.Dequeue();
                }

            }
            if (guests.Count > 0)
            {
                Console.WriteLine($"Guests: {String.Join(" ", guests)}");
                Console.WriteLine($"Wasted grams of food: {wastedFood}");
            }
            else
            {
                Console.WriteLine($"Plates: {String.Join(" ", plates)}");
                Console.WriteLine($"Wasted grams of food: {wastedFood}");
            }
        }
    }
}
