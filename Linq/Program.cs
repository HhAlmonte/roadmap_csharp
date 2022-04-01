using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Linq
{
    internal class Program
    {
        static void Main(string[] args)
        {
            List<People> peoples = new List<People>()
            {
                new People()
                {
                    Id = 1,
                    Name = "Pablo",
                    Country = "Republica Dominicana"
                },
                new People()
                {
                    Id = 2,
                    Name = "Jose",
                    Country = "Mexico"
                },
                new People()
                {
                    Id = 3,
                    Name = "Miguel",
                    Country = "Mexico"
                },
                new People()
                {
                    Id = 4,
                    Name = "Raul",
                    Country = "Republica Dominicana"
                }
            };

            foreach (var items in peoples)
            {
                Console.WriteLine(items);
                Console.WriteLine("-----------------------");
            }

            var peopleRD = from p in peoples
                           where p.Country == "Republica Dominicana"
                           select p;
            Console.WriteLine("Personas en Republica Dominicana: \n");
            foreach (var item in peopleRD)
            {
                Console.WriteLine(item);
                Console.WriteLine("-----------------------");
            }

            var peopleMX = from p in peoples
                           where p.Country == "Mexico"
                           select p;
            Console.WriteLine("Personas en Mexico: \n");
            foreach (var item in peopleMX)
            {
                Console.WriteLine(item);
                Console.WriteLine("-----------------------");
            }

            var PeopleID = from b in peoples
                           where b.Id == 1
                           select b;
            foreach (var item in PeopleID)
            {
                Console.WriteLine($"ID: {item.Id}\n{item}");
            }
        }
    }
    class People
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public string Country { get; set; }

        public override string ToString()
        {
            return $"Name: {Name} \nPaís: {Country}";
        }
    }
}
