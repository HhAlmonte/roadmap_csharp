using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Herencia
{
    class program
    {
        static void Main(string[] args)
        {
            dev dev1 = new dev("Hector", 19, "Backend");
            Console.WriteLine(dev1.getData());
        }
    }
    class people
    {
        private string _name;
        private int _age;

        public people(string name, int age)
        {
            _name = name;
            _age = age;
        }
        public string getInfo()
        {
            return $"Nombre: {_name}\nEdad: {_age}";
        }
    }
    class doctor : people
    {
        private string _speciality;
        public doctor(string name, int age, string speciality) : base(name, age)
        {
            _speciality = speciality;
        }
        public string getData()
        {
            return getInfo() + $"\nEspecialidad: {_speciality}";
        }
    }
    class dev : people
    {
        private string _typeDeveloper;
        public dev(string name, int age, string typeDeveloper) : base(name, age)
        {
            _typeDeveloper = typeDeveloper;
        }
        public string getData()
        {
            return getInfo() + $"\nDesarrollador: {_typeDeveloper}";
        }
    }
}
