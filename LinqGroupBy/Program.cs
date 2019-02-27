using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LinqGroupBy
{
    class Program
    {
        static void Main(string[] args)
        {
            var persons = PersonRepository.GetPersons();

            var query = from p in persons
                where p.Age > 10
                orderby p.LastName descending
                group p by p.LastName;
                //select p;

            foreach (var item in query)
            {
                Console.WriteLine(item.Key);
                foreach (var i in item)
                {
                    Console.WriteLine($"\tFirst:{i.FirstName},Last:{i.LastName},Age:{i.Age}");
                }
            }
            //Printing(query);


           Console.ReadKey();
        }

        public static void Printing(dynamic type)
        {
            foreach (var t in type)
            {
                Console.WriteLine(t);
            }
        }
    }
}
