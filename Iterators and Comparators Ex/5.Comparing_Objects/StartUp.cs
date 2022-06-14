using System;
using System.Collections.Generic;

namespace _5.Comparing_Objects
{
    internal class StartUp
    {
        static void Main(string[] args)
        {
            List<Person> people = new List<Person>();

            while (true)
            {
                var tokens = Console.ReadLine().Split(' ');
                if (tokens[0] == "END")
                {
                    break;
                }
                string personName = tokens[0];
                int personAge = int.Parse(tokens[1]);
                string personTown=tokens[2];

                people.Add(new Person(personName, personAge, personTown));
            }

            var index = int.Parse(Console.ReadLine())-1;
            int equal = 0;
            int notEqual = 0;

            foreach(var person in people)
            {
                if (people[index].CompareTo(person) == 0)
                {
                    equal++;
                }
                else
                {
                    notEqual++;
                }


                if (equal <= 1)
                {
                    Console.WriteLine("No matches");
                }
                else
                {
                    Console.WriteLine($"{equal} {notEqual} {people.Count}");
                }
            }
        }
    }
}
