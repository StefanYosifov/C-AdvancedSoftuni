using System;
using System.Collections.Generic;
using System.Linq;

namespace _5._Count_Symbols
{
    internal class Program
    {
        static void Main(string[] args)
        {
            string inputText=Console.ReadLine();
            Dictionary<char,int> charactersOfText=new Dictionary<char,int>();
            foreach(var ch in inputText)
            {
                if (charactersOfText.ContainsKey(ch))
                {
                    charactersOfText[ch]++;
                }
                else
                {
                    charactersOfText.Add(ch, 1);
                }
            }

            var orderedText=charactersOfText.OrderBy(x=>x.Key).ToDictionary(x=>x.Key,x=>x.Value);
            foreach(var characters in orderedText)
            {
                Console.WriteLine($"{characters.Key}: {characters.Value} time/s");
            }
        }
    }
}
