using System;
using System.Collections.Generic;
using System.Diagnostics.CodeAnalysis;
using System.Text;

namespace _5.Comparing_Objects
{
    public class Person : IComparable<Person>
    {
        public Person(string name,int age,string town)
        {
            this.age = age;
            this.name = name;
            this.town = town;
        }

        private string name;
        private int age;
        private string town;

        public string Name => name;
        public int Age => age;

        public string Town=> town;

        public int CompareTo( Person other)
        {
            int result=name.CompareTo(other.name);
            if (result == 0)
            {
                result = Age.CompareTo(other.Age);
            }

            if (result == 0)
            {
                result = Town.CompareTo(other.Town);
            }
            return result;
        }
    }
}
