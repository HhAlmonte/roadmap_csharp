using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Tuplas
{
    internal class Program
    {
        static void Main(string[] args)
        {
            (int age, string name) people = (19, "Hector Almonte");
            Console.WriteLine(people.age +" "+ people.name);

            (int id, string empleado) personal = (1, "Ventas");
            Console.WriteLine(personal);

            var countries = (1, "hola");
            Console.WriteLine(countries.Item2);

            var country = new []{
                (1, "Republica Dominicana"),
                (2, "Mexico"),
                (3, "Estados Unidos"),
                (4, "Venezuela")
            };
            foreach(var countriies in country)
                Console.WriteLine(countriies.Item2);

            (int id, string marca)[] cervezas = new[]
            {
                (1, "Presidente"),
                (2, "The One")
            };
            foreach(var beers in cervezas)
                Console.WriteLine(beers.id);
        }
    }
}
