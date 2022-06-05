using System;
using System.Collections.Generic;
using System.Text;

namespace _9._Pokemon_Trainer
{
    public class Trainer
    {

        public Trainer(string name)
        {
            this.Name = name;
            this.NumberOfBadgets = 0;
            this.Collection = new List<Pokemon>();
        }

        public Trainer(string name,int numberOfBadgets,List<Pokemon> pokemons)
        {
            this.Name = name;
            this.NumberOfBadgets = numberOfBadgets;
            this.Collection = pokemons;
        }

        public void IncreaceNumberOfBadges()
        {
            NumberOfBadgets++;
        }

        public string Name { get; set; }

        public int NumberOfBadgets { get; set; }
        public List<Pokemon> Collection { get; set; }
    }
}
