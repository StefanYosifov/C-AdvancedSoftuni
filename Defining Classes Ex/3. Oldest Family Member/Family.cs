using System;
using System.Collections.Generic;
using System.Text;
using System.Linq;

namespace DefiningClasses
{
    public class Family
    {

        List<Person> people=new List<Person>();

        public Family()
        {
            people=new List<Person>();
        }

       public void AddPerson(Person member)
        {
            people.Add(member);
        }

        public Person GetOldestMembers()
        {
          Person ppl=people.OrderByDescending(x=>x.Age).FirstOrDefault();
          return ppl;
                

        }
    }
}
