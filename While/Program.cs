using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace While
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int num = 0;
            int sum = 0;
            bool i = true;

            while (i)
            {
                Console.Write("Ingrese un numero: ");
                num = int.Parse(Console.ReadLine());

                if (num >= 0)
                    sum += num;
                else
                    i = false;
            }
            Console.WriteLine(sum);
        }
    }
}
