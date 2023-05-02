using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Renovators
{
    public class Catalog
    {
        public Catalog(string name, int neededRenovators, string project)
        {
            this.collection = new List<Renovator>();
            Name = name;
            NeededRenovators = neededRenovators;
            Project = project;
        }

        private List<Renovator> collection { get; set; }

        public string Name { get; set; }

        public int NeededRenovators { get; set; }

        public string Project { get; set; }

        public int Count => this.collection.Count;


        public string AddRenovator(Renovator renovator)
        {
            if(renovator.Name==null || renovator.Name==string.Empty ||renovator.Type==null || renovator.Type==string.Empty)
            {
                return "Invalid renovator's information.".Trim();
            }
            if (this.NeededRenovators<=this.collection.Count)
            {
                return "Renovators are no more needed.".Trim();
            }
            if (renovator.Rate >= 350)
            {
                return "Invalid renovator's rate.".Trim();
            }
            this.collection.Add(renovator);
            return $"Successfully added {renovator.Name} to the catalog.".Trim();
        }

        public bool RemoveRenovator(string name)
        {
            if (this.collection.Any(x => x.Name == name))
            {
                var renovator = collection.FirstOrDefault(x => x.Name == name);
                this.collection.Remove(renovator);
                return true;
            }
            return false;
        }

        public int RemoveRenovatorBySpecialty(string type)
        {
            if (this.collection.Any(x => x.Type == type))
            {
                int count=this.collection.RemoveAll(x => x.Type == type);
                return count;
            }
            return 0;
        }

        public Renovator HireRenovator(string name)
        {
            if (this.collection.Any(x => x.Name == name))
            {
                var renovator = this.collection.FirstOrDefault(x => x.Name == name);
                renovator.Hired = true;
                return renovator;
            }
            return null;
        }

        public List<Renovator> PayRenovators(int days)
        {
            var list = new List<Renovator>();
            list = this.collection.FindAll(x => x.Days >= days).ToList();
            return list;
        }

        public string Report()
        {
            StringBuilder sb = new StringBuilder();
            sb.AppendLine($"Renovators available for Project {Project}:");
            foreach(var renovator in this.collection.Where(x=>x.Hired==false))
            {
                sb.AppendLine(renovator.ToString());
            }
            return sb.ToString().TrimEnd();
        }

    }
}
