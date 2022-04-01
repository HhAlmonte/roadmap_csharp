using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace @static
{
    internal class program
    {
        static void Main(string[] args)
        {
            People Hector = new People()
            {
               Name = "Hector",
               Age = 19
            };
            Console.WriteLine(Hector);
        }

        public static class Math
        {
            public static int sum(int value1, int valu2)
            {
                return value1 + valu2;
            }
        }
        public class People
        {
            public static int Count = 0;
            public string Name { get; set; }
            public int Age { get; set; }

            public People()
            {
                Count++;
            }

            public static int getCount()
            {
                return Count;
            }
            public override string ToString()
            {
                return $"Name: {Name} \nEdad: {Age}";
            }
        }
    }
}
