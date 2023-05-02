using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace BakeryOpenning
{
    public class Bakery
    {
        public Bakery(string name, int capacity)
        {
            this.collection = new List<Employee>();
            Name = name;
            Capacity = capacity;
        }

        private List<Employee> collection { get; set; }
        public string Name { get; set; }
        public int Capacity { get; set; }

        public int Count => this.collection.Count;

        public void Add(Employee employee)
        {
            if (this.collection.Count < this.Capacity)
            {
                this.collection.Add(employee);
            }
        }

        public bool Remove(string name)
        {
            if (collection.Any(x => x.Name == name))
            {
                var employee = this.collection.FirstOrDefault(x => x.Name == name);
                this.collection.Remove(employee);
                return true;
            }
            return false;
        }

        public Employee GetOldestEmployee()
        {
            return this.collection.OrderByDescending(x => x.Age).FirstOrDefault();
        }

        public Employee GetEmployee(string name)
        {
            if (this.collection.Any(x => x.Name == name))
            {
                return this.collection.FirstOrDefault(x => x.Name == name);
            }
            return null;
        }

        public string Report()
        {
            StringBuilder sb = new StringBuilder();
            sb.AppendLine($"Employees working at Bakery {Name})");
            foreach(var employee in this.collection)
            {
                sb.AppendLine(employee.ToString());
            }
            return sb.ToString().TrimEnd();
        }

    }
}
