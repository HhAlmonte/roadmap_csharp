using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Funciones
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int op = 0;
            int num1 = 0;
            int num2 = 0;

            Console.WriteLine("Operaciones");
            Console.WriteLine("1.- Sumar \n" +
                "2.- Restar \n" +
                "3.- Dividir \n" +
                "4.- Multiplicar");
            Console.Write("Elige una opción: ");
            op = int.Parse(Console.ReadLine());

            switch (op)
            {
                case 1:
                    Console.Write("Ingrese el numero 1: ");
                    num1 = int.Parse(Console.ReadLine());
                    Console.Write("Ingrese el numero 2: ");
                    num2 = int.Parse(Console.ReadLine());
                    Console.WriteLine($"El total: {sum(num1, num2)}");
                    break;
                case 2:
                    Console.Write("Ingrese el numero 1: ");
                    num1 = int.Parse(Console.ReadLine());
                    Console.Write("Ingrese el numero 2: ");
                    num2 = int.Parse(Console.ReadLine());
                    Console.WriteLine($"El resto: {resta(num1, num2)}");
                    break;
                case 3:
                    Console.Write("Ingrese el numero 1: ");
                    num1 = int.Parse(Console.ReadLine());
                    Console.Write("Ingrese el numero 2: ");
                    num2 = int.Parse(Console.ReadLine());
                    Console.WriteLine($"El resultado de la división: {division(num1, num2)}");
                    break;
                case 4:
                    Console.Write("Ingrese el numero 1: ");
                    num1 = int.Parse(Console.ReadLine());
                    Console.Write("Ingrese el numero 2: ");
                    num2 = int.Parse(Console.ReadLine());
                    Console.WriteLine($"El producto de los factores: {mult(num1, num2)}");
                    break;
            }
        }
        public static int sum(int num1, int num2)
        {
            return num1 + num2;
        }
        public static int mult(int num1, int num2)
        {
            return num1 * num2;
        }
        public static int division(int num1, int num2)
        {
            return num1 / num2;
        }
        public static int resta(int num1, int num2)
        {
            return num1 - num2;
        }
    }
}
