using System;
using System.Collections.Generic;
using System.Text;

namespace _9._Pokemon_Trainer
{
    public class Pokemon
    {

        public Pokemon(string name,string element,int health)
        {
            this.Name = name;
            this.Element = element;
            this.Health = health;
        }

        public string Name { get; set; }    

        public string Element { get; set; }

        public int Health { get; set; }


        public void ReduceHealth()
        {
            Health -= 10;
        }

        public void IncreaceNumberOfBadges()
        {
            Element += 1;
        }
    }
}
