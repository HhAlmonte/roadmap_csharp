using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Arreglos
{
    internal class Program
    {
        static void Main(string[] args)
        {
            string[] nombre = new string[5]
            {
                "Pedro",
                "Pablo",
                "Juan",
                "Jose",
                null
            };
            string[] nombreClon = new string[5];
;

            for (int i = 0; i < nombre.Length; i++)
                Console.WriteLine(nombre[i]);
            
        }
    }
}
