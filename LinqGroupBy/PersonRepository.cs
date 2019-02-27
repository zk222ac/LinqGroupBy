using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LinqGroupBy
{
    public class PersonRepository
    {
       public static List<Person> GetPersons()
        {
          return new List<Person>()
            {
                new Person("John", "Doe", 14),
                new Person("Jane", "Doe", 24),
                new Person("Steen", "williams",34),
                new Person("Micheal", "williams", 44),
                new Person("Bob", "walters", 55)
            };
        }

    }
}
