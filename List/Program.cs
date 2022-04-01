using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace List
{
    internal class Program
    {
        static void Main(string[] args)
        {
            List<int> numbers = new List<int>();

            numbers.Add(1);
            numbers.Add(1);
            numbers.Add(1);
            numbers.Add(1);

            foreach(var number in numbers)
                Console.WriteLine(number);

            List<string> countries = new List<string>()
            {
                "Mexico", "Usa", "RD", "Colombia"
            };

            foreach(var country in countries)
                Console.WriteLine(country);
        }
    }
}
