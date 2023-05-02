using System;
using System.Collections.Generic;
using System.Linq;

namespace _01._Blacksmith
{
    internal class Program
    {
        static void Main(string[] args)
        {
            
            int[] steelArray=Console.ReadLine().Split(' ').Select(int.Parse).ToArray();
            int[] carbonArray=Console.ReadLine().Split(' ').Select(int.Parse).ToArray();

            //Dictionary<string, int> swords = new Dictionary<string, int>()
            //{
            //    {"Gladius",70 },
            //    {"Shamshir",80 },
            //    {"Katana",90 },
            //    {"Sabre",110 },
            //    {"Broadsword",150 }
            //};


            Queue<int> steel = new Queue<int>(steelArray);
            Stack<int> carbon = new Stack<int>(carbonArray);


            Dictionary<string, int> swords = new Dictionary<string, int>()
            {
              {"Broadsword",0},
                {"Sabre",0 },
                {"Katana",0 },
                { "Shamshir",0 },
                 {"Gladius",0 },


            };

            int swordsCount = 0;
            
            while(carbon.Count > 0 && steel.Count > 0)
            {
                int elementFromSteel = steel.Peek();
                int elementFromCarbon=carbon.Peek();
                int total = elementFromCarbon + elementFromSteel;
                if (total == 70)
                {
                    swords["Gladius"]++;
                    steel.Dequeue();
                    carbon.Pop();
                    swordsCount++;
                }
                else if (total == 80)
                {
                    swords["Shamshir"]++;
                    steel.Dequeue();
                    carbon.Pop();
                    swordsCount++;
                }
                else if (total == 90)
                {
                    swords["Katana"]++;
                    steel.Dequeue();
                    carbon.Pop();
                    swordsCount++;
                }
                else if (total == 110)
                {
                    swords["Sabre"]++;
                    steel.Dequeue();
                    carbon.Pop();
                    swordsCount++;
                }
                else if (total == 150)
                {
                    swords["Broadsword"]++;
                    steel.Dequeue();
                    carbon.Pop();
                    swordsCount++;
                }
                else
                {
                    steel.Dequeue();
                    elementFromCarbon += 5;
                    carbon.Pop();
                    steel.Enqueue(elementFromCarbon);
                }
            }
            if (swordsCount >= 1)
            {
                Console.WriteLine($"You have forged {swordsCount} swords.");
            }
            else
            {
                Console.WriteLine("You did not have enough resources to forge a sword.");
            }


            if (steel.Count == 0)
            {
                Console.WriteLine("Carbon left: none");
            }
            else
            {
                Console.WriteLine($"Carbon left: {string.Join(", ",steel)}");
            }

            if (carbon.Count == 0)
            {
                Console.WriteLine($"Stee left: none");
            }
            else
            {
                Console.WriteLine($"Carbon left: {string.Join(", ",carbon)}");
            }
            foreach(var swordItem in swords.OrderBy(pair => pair.Key))
            {
                if (swordItem.Value > 0)
                {
                    Console.WriteLine($"{swordItem.Key}: {swordItem.Value}");
                }
            }

        }
    }
}
