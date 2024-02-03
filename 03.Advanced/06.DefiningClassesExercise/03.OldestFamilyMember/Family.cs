using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DefiningClasses
{
    public class Family
    {
        private List<Person> family = new List<Person>();

        public void AddMember(Person person)
        {
            family.Add(person);
        }

        public Person GetOldestMember()
        {
            return family.FirstOrDefault(p => p.Age == family.Max(p1 => p1.Age));
        }
    }
}