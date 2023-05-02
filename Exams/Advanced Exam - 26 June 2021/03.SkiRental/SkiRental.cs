using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace SkiRental
{
    public class SkiRental
    {
        public SkiRental( string name, int capacity)
        {
            this.collection = new List<Ski>();
            Name = name;
            Capacity = capacity;
        }

        private List<Ski> collection { get; set; }
        public string Name { get; set; }
        public int Capacity { get; set; }

        public int Count => this.collection.Count;
        public void Add(Ski ski)
        {
            if (collection.Count < this.Capacity)
            {
                this.collection.Add(ski);
            }
        }

        public bool Remove(string manufacturer,string model)
        {
            if(collection.Any(x=>x.Manufacturer==manufacturer && x.Model == model))
            {
                var removeSki = collection.FirstOrDefault(x => x.Manufacturer == manufacturer && x.Model == model);
                this.collection.Remove(removeSki);
                return true;
            }
            return false;
        }

        public Ski GetNewestSki()
        {
            if(collection.Count == 0)
            {
                return null;
            }
            return collection.OrderByDescending(x => x.Year).First();
        }

        public Ski GetSki(string manufacturer, string model)
        {
            if(collection.Any(x=>x.Manufacturer==manufacturer && x.Model == model))
            {
                var findSki=collection.FirstOrDefault(x => x.Manufacturer == manufacturer && x.Model == model);
                return findSki;
            }
            return null;
        }

        public string GetStatistics()
        {
            StringBuilder sb = new StringBuilder();
            sb.AppendLine($"The skis stored in {Name}:");
            foreach(var ski in collection)
            {
                sb.AppendLine(ski.ToString());
            }
            return sb.ToString().TrimEnd();
        }

    }
}
