using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.IO;
using System.Threading.Tasks;

/*namespace Excepciones
{
    internal class Program
    {
        static void Main(string[] args)
        {
            string file = @"C:\Users\Hector Almonte\OneDrive\Documentos\Integrantes del grupo.txt";
            try
            {
                string content = File.ReadAllText(file);
                Console.WriteLine(content);
            }
            catch (FileNotFoundException)
            {
                Console.WriteLine($"No se encontró el archivo");
                throw;
            }
        }
    }
}*/

namespace ExcepcionesPersonalizadas
{

    internal class program
    {
        static void Main(string[] args)
        {
            try
            {
                People Pablo = new People()
                {
                };
                Console.WriteLine(Pablo);
            }
            catch (PeopleNotFoundException ex)
            {
                Console.WriteLine(ex.Message);
                throw;
            }
        }
    }
    public class PeopleNotFoundException : Exception
    {
        public PeopleNotFoundException() :
            base("No se encontró a la persona")
        {}
    }
    public class People
    {
        public string Name { get; set; }
        public int Age { get; set; }

        public override string ToString()
        {
            if (Name == null && Age == 0)
                throw new PeopleNotFoundException();
            return $"Nombre: {Name} Edad: {Age}";
        }
    }
}
