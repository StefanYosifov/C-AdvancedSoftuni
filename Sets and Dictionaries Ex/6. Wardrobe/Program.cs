using System;
using System.Collections.Generic;
using System.Linq;

namespace _6._Wardrobe
{
    class WardDrobe
    {
        public WardDrobe()
        {

        }
        public WardDrobe(string clothe,int count)
        {
                this.Clothe = clothe;
            this.Count = count;
        }
        public string Colour { get; set; }

        public string Clothe { get; set; }

        public int Count { get; set; }
    }
    internal class Program
    {
        static void Main(string[] args)
        {
            Dictionary<string, Dictionary<string, int>> wardrobe = new Dictionary<string, Dictionary<string, int>>();

            int number = int.Parse(Console.ReadLine());

            for (int i = 0; i < number; i++)
            {
                string[] clothesLine = Console.ReadLine().Split(" -> ");
                string color = clothesLine[0];
                string[] clothes = clothesLine[1].Split(",");

                if (wardrobe.ContainsKey(color) == false)
                {
                    wardrobe.Add(color, new Dictionary<string, int>());
                }

                foreach (string item in clothes)
                {
                    if (!wardrobe[color].ContainsKey(item))
                    {
                        wardrobe[color].Add(item, 0);
                    }

                    wardrobe[color][item]++;
                }
            }

            string[] wanted = Console.ReadLine().Split();
            string colorNeeded = wanted[0];
            string itemNeeded = wanted[1];

            foreach (var color in wardrobe)
            {
                Console.WriteLine($"{color.Key} clothes:");

                Dictionary<string, int> clothesLine = color.Value;

                foreach (var item in clothesLine)
                {
                    string output = $"* {item.Key} - {item.Value}";

                    if (colorNeeded == color.Key && itemNeeded == item.Key)
                    {
                        output += " (found!)";
                    }

                    Console.WriteLine(output);
                }
            }
        }
    }
}
