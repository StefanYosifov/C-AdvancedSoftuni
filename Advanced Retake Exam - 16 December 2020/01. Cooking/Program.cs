using System;
using System.Collections.Generic;
using System.Linq;

namespace _01._Cooking
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int[] firstArr = Console.ReadLine().Split(' ').Select(int.Parse).ToArray();
            int[] secondArr = Console.ReadLine().Split(' ').Select(int.Parse).ToArray();

            Queue<int> liquid=new Queue<int>(firstArr);
            Stack<int> ingredient=new Stack<int>(secondArr);
            Dictionary<string,int> cookedFood=new Dictionary<string,int>();
            cookedFood.Add("Bread", 0);
            cookedFood.Add("Cake", 0);
            cookedFood.Add("Pastry", 0);
            cookedFood.Add("Fruit Pie", 0);


            while (liquid.Count > 0 && ingredient.Count > 0)
            {
                int peekLiquid = liquid.Peek();
                int peekIngredient = ingredient.Peek();
                int total = peekLiquid + peekIngredient;

                if (total == 25)
                {
                    cookedFood["Bread"]++;
                    liquid.Dequeue();
                    ingredient.Pop();
                }
                else if (total == 50)
                {
                    cookedFood["Cake"]++;
                    liquid.Dequeue();
                    ingredient.Pop();
                }
                else if (total == 75)
                {
                    cookedFood["Pastry"]++;
                    liquid.Dequeue();
                    ingredient.Pop();
                }
                else if (total == 100)
                {
                    cookedFood["Fruit Pie"]++;
                    liquid.Dequeue();
                    ingredient.Pop();
                }
                else
                {
                    liquid.Dequeue();
                    ingredient.Pop();
                    ingredient.Push(peekIngredient + 3);
                }
            
            }

            if(cookedFood.All(x=>x.Value >= 1))
            {
                Console.WriteLine($"Wohoo! You succeeded in cooking all the food!");
            }
            else
            {
                Console.WriteLine($"Ugh, what a pity! You didn't have enough materials to cook everything.");
            }

            if(liquid.Count == 0)
            {
                Console.WriteLine("Liquids left: none");
            }
            else
            {
                Console.WriteLine($"Liquids left: {string.Join(", ",liquid)}");
            }

            if (ingredient.Count == 0)
            {
                Console.WriteLine("Ingredients left: none");
            }
            else
            {
                Console.WriteLine($"Ingredients left: {string.Join(", ", ingredient)}");
            }

            foreach(var food in cookedFood.OrderBy(x=>x.Key))
            {
                string foodName = food.Key;
                int foodCount = food.Value;

                Console.WriteLine($"{foodName}: {foodCount}");
            }

        }
    }
}
