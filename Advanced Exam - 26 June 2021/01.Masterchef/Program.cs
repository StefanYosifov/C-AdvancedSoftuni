using System;
using System.Collections.Generic;
using System.Linq;

namespace _01.Masterchef
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int[] firstArr = Console.ReadLine().Split(' ').Select(int.Parse).ToArray();
            int[] secondArr = Console.ReadLine().Split(' ').Select(int.Parse).ToArray();

            Queue<int> ingredient = new Queue<int>(firstArr);
            Stack<int> freshness=new Stack<int>(secondArr);
            Dictionary<string,int> dishes =new Dictionary<string,int>();
            dishes.Add("Dipping sauce", 0);
            dishes.Add("Green salad", 0);
            dishes.Add("Chocolate cake", 0);
            dishes.Add("Lobster", 0);


            while (ingredient.Count>0 && freshness.Count > 0)
            {
                int takeIngredient = ingredient.Peek();
                int takeFreshness = freshness.Peek();
                int multiplication = takeFreshness * takeIngredient;

                if (takeIngredient <= 0)
                {
                    ingredient.Dequeue();
                    continue;
                }


                if (multiplication == 150)
                {
                    dishes["Dipping sauce"]++;
                    ingredient.Dequeue();
                    freshness.Pop();
                }
                else if (multiplication == 250)
                {
                    dishes["Green salad"]++;
                    ingredient.Dequeue();
                    freshness.Pop();
                }
                else if (multiplication == 300)
                {
                    dishes["Chocolate cake"]++;
                    ingredient.Dequeue();
                    freshness.Pop();
                }
                else if (multiplication == 400)
                {
                    dishes["Lobster"]++;
                    ingredient.Dequeue();
                    freshness.Pop();
                }
                else
                {
                    freshness.Pop();
                    ingredient.Dequeue();
                    ingredient.Enqueue(takeIngredient + 5);
                }
               
            }
            bool succesfulCooking = dishes.All(x => x.Value >= 1);
            if (succesfulCooking)
            {
                Console.WriteLine($"Applause! The judges are fascinated by your dishes!");
            }
            else
            {
                Console.WriteLine("You were voted off. Better luck next year.");
            }
            if (ingredient.Count > 0)
            {
                Console.WriteLine($"Ingredients left: {ingredient.Sum()}");
            }

            foreach(var dish in dishes.OrderBy(x=>x.Key).Where(x=>x.Value>=1))
            {
                string dishName = dish.Key;
                int dishCount = dish.Value;
                Console.WriteLine($" # {dishName} --> {dishCount}");
            }
        }
    }
}
