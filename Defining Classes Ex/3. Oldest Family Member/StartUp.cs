using System;
using System.Linq;

namespace DefiningClasses
{
    public class StartUp
    {
        static void Main()
        {
            Family family=new Family();
            int n=int.Parse(Console.ReadLine());
            for(int i = 0; i < n; i++)
            {
                Person person=new Person();
                string[] tokens = Console.ReadLine().Split(' ').ToArray();
                person.Name = tokens[0];
                person.Age = int.Parse(tokens[1]);
                family.AddPerson(person);
            }

            Person oldestPerson=(family.GetOldestMembers());
            Console.WriteLine($"{oldestPerson.Name} {oldestPerson.Age}");
        

        }
    }
}
