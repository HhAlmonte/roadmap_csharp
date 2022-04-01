using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SentenciaIf_Else
{
     class Prueba4
    {
        private string _password;
        
        static void Main(string[] args)
        {
            Console.Write("Ingrese su nueva contraseña: ");
            string contrasenia = Console.ReadLine();
            

            Console.Write("Confirme su nueva contraseña: ");
            string confirmContrasenia = Console.ReadLine();
            

            Prueba4 prueba4 = new Prueba4(contrasenia);
            prueba4.passwordExist(confirmContrasenia);
        }

        Prueba4(string password)
        {
            _password = password;
        }
        public void passwordExist(string password)
        {

            if(password.ToLower() == _password.ToLower())
                Console.WriteLine("Contraseña correcta");
            else
                Console.WriteLine("Contraseña incorrecta");
        }
    }
}
