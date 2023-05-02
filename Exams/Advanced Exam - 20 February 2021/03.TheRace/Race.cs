using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace TheRace
{
    public class Race
    {
        public Race(string name, int capacity)
        {
            this.collection = new List<Racer>();
            Name = name;
            Capacity = capacity;
        }

        private List<Racer> collection { get; set; }

        public string Name { get; set; }
        public int Capacity { get; set; }

        public int Count => this.collection.Count;

        public void Add(Racer racer)
        {
            if (this.collection.Count < this.Capacity)
            {
                this.collection.Add(racer);
            }
        }

        public bool Remove(string name)
        {
            if (this.collection.Any(x => x.Name == name))
            {
                var removeRacer = collection.FirstOrDefault(x => x.Name == name);
                return true;
            }
            return false;
        }

        public Racer GetOldestRacer()
        {
            if (collection.Count == 0)
            {
                return null;
            }
            return this.collection.OrderByDescending(x => x.Age).FirstOrDefault();
        }

        public Racer GetRacer(string name)
        {
            if (collection.Any(x => x.Name == name))
            {
                return this.collection.FirstOrDefault(x => x.Name == name);
            }
            return null;
        }

        public Racer GetFastestRacer()
        {
            if (collection.Count == 0)
            {
                return null;
            }
            return this.collection.OrderByDescending(x=>x.car.Speed).FirstOrDefault();
        }

        public string Report()
        {
            StringBuilder sb = new StringBuilder();
            sb.AppendLine($"Racers participating at {Name}:");
            foreach(var racer in collection)
            {
                sb.AppendLine(racer.ToString());
            }
            return sb.ToString().TrimEnd();
        }
    }
}
