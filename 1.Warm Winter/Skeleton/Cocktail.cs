using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace CocktailParty
{
    public class Cocktail
    {
        public Cocktail(string name, int capacity, int maxAlcoholLevel)
        {
            collection = new List<Ingredient>();
            Name = name;
            Capacity = capacity;
            MaxAlcoholLevel = maxAlcoholLevel;
        }

        private List<Ingredient> collection { get; set; }

        public string Name { get; set; }

        public int Capacity { get; set; }

        public int MaxAlcoholLevel { get; set; }

        public int CurrentAlcoholLevel =>collection.Sum(x=>x.Alcohol);
        public void Add(Ingredient ingredient)
        {
            if (this.collection.Count < this.Capacity && this.MaxAlcoholLevel > ingredient.Alcohol &&
                this.collection.Any(x => x.Name == ingredient.Name) == false)
            {
                this.collection.Add(ingredient);
            }
        }

        public bool Remove(string name)
        {
            var findCocktail = collection.FirstOrDefault(x => x.Name == name);
            return collection.Remove(findCocktail);
           
        }

        public Ingredient FindIngredient(string name)
        {
            var findCockTailIngredient=collection.FirstOrDefault(x => x.Name == name);
            return findCockTailIngredient;
        }

        public Ingredient GetMostAlcoholicIngredient()
        {
            return collection.OrderByDescending(x => x.Alcohol).FirstOrDefault();
        }
        

        public string Report()
        {
            StringBuilder sb = new StringBuilder();
            sb.AppendLine($"Cocktail: {Name} - Current Alcohol Level: {CurrentAlcoholLevel}");
            foreach(var ingredient in collection)
            {
                sb.AppendLine(ingredient.ToString());
            }
           return sb.ToString().Trim();
        }

    }
}
