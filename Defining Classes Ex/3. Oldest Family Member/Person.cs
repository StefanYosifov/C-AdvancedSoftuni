using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace DefiningClasses
{
    public class Person
    {
        public Person()
        {
            this.Name = "No name";
            this.Age = 1;
        }
        public Person(int age)
        {
            this.Name = "No name";
            this.Age = age;
        }
        public Person(string name, int age)
        {
            this.Name = name;
            this.Age = age;
        }

        private string name;
        private int age;
        List<Person> people=new List<Person>();

        public string Name
        {
            get { return name; }
            set { name = value; }
        }

        public int Age
        {
            get { return age; }
            set { age = value; }
        }

        public void printOlderThan30(List<Person> list)
        {
            var ageList = list.OrderBy(x => x.Name).Where(x => x.Age > 30).ToList();
            foreach(var person in ageList)
            {
                Console.WriteLine($"{person.Name} - {person.Age}");
            }
        }
    }
}
