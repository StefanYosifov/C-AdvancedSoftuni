using System;
using System.Collections.Generic;
using System.Linq;

namespace DefiningClasses
{
    public class StartUp
    {
        static void Main(string[] args)
        {
            int n=int.Parse(Console.ReadLine());
            List<Person> people = new List<Person>();


            for(int i=0;i<n;i++)
            {
                string[] information=Console.ReadLine().Split(' ').ToArray();
                string name=information[0];
                int age=int.Parse(information[1]);
                Person person=new Person(name,age);
                people.Add(person);
            }

            var olderThan30=people.OrderByDescending(x=>x.Name).Where(x=>x.Age>30).ToList();
            foreach(var person in olderThan30)
            {
                Console.WriteLine($"{person.Name} - {person.Age}");
            }
            
        }
    }
}
