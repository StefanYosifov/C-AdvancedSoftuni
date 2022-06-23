using System;
using System.Collections.Generic;
using System.Linq;

namespace _1.Meal_Plan
{
    internal class Program
    {
        static void Main(string[] args)
        {
            string[] meals = Console.ReadLine().Split(' ').ToArray();
            int[] dailyCalories = Console.ReadLine().Split(' ',StringSplitOptions.RemoveEmptyEntries).Select(int.Parse).ToArray();


            Dictionary<string, int> caloriesByMeal = new Dictionary<string, int>()
            {
                {"salad",350 },
                {"soup",490 },
                {"pasta",680 },
                {"steak",790 },
            };

            var mealsQueue = new Queue<string>(meals);
            Stack<int> calories=new Stack<int>(dailyCalories);
            int mealsCount = 0;

            while (mealsQueue.Count > 0 && calories.Count>0)
            {
                string currentMeal = mealsQueue.Peek();
                int mealCalories=caloriesByMeal[currentMeal];
                int totalCalories=calories.Pop()-mealCalories;
                
                if (totalCalories > 0)
                {
                    calories.Push(totalCalories);
                    mealsCount++;
                }
                if(totalCalories < 0)
                {
                    int caloriesToPop=calories.Peek()-totalCalories;
                    calories.Push(caloriesToPop);
                    Console.WriteLine($"John had {mealsCount} meals.");
                    mealsCount = 0;
                }
                
            }

            Console.WriteLine($"For the next few days, he can eat {string.Join(", ",calories)} calories.");
            

        }
    }
}
