using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TiposDeDatos
{
    class TipoDeDatos
    {
        private string _nombre;
        private char _Sexo;
        

        static void Main(string[] args)
        {
            bool _IsDead = false;

            TipoDeDatos prueba1 = new TipoDeDatos("Hector", 'M');
            Console.WriteLine(prueba1);
            isDead(_IsDead);
            double double1 = 1.2222;
            float float2 = 7.555F;

            double result = double1 + float2;
            Console.WriteLine(result);
        }

        public TipoDeDatos(string nombre, char sexo)
        {
            _nombre = nombre;
            _Sexo = sexo;
            
        }

        public static void isDead(bool boolean)
        {
            if (boolean == true)
            {
                Console.WriteLine("Estás vivo");
            }
            else
            {
                Console.WriteLine("Estás muerto");
            }
        }

        public override string ToString()
        {
            return $"Nombre: {_nombre} \nSexo: {_Sexo}";
        }
    }
}
