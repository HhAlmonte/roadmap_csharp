using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SobreCarga
{
    internal class program
    {
        static void Main(string[] args)
        {
            Console.WriteLine(operaciones.sum("10","10"));
            Console.WriteLine(operaciones.sum(10,10));
            Console.WriteLine(operaciones.sum(10,10,10));

            Console.WriteLine(operaciones.restar("10", "10"));
            Console.WriteLine(operaciones.restar(10, 10));
            Console.WriteLine(operaciones.restar(10, 10, 10));
        }
    }
    class operaciones
    {
        public static int sum(int num1, int num2)
        {
            return num1 + num2;
        }
        public static int sum(string num1, string num2)
        {
            return int.Parse(num1) + int.Parse(num2);
        }
        public static int sum(int num1, int num2, int num3)
        {
            return num1 + num2 + num3;
        }


        public static int restar(int num1, int num2)
        {
            return num1 - num2;
        }
        public static int restar(string num1, string num2)
        {
            return int.Parse(num1) - int.Parse(num2);
        }
        public static int restar(int num1, int num2, int num3)
        {
            return num1 - num2 - num3;
        }
    }
}
