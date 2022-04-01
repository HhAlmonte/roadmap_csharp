using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Generics
{
    internal class Program
    {
        static void Main(string[] args)
        {
            /*MyList<string> number = new MyList<string>(10);

            List<int> number1 = new List<int>();
            number1.Add(1);
            number1.Add(2);
            number1.Add(3);
            number1.Add(4);
            number1.Add(5);

            foreach(var numbers in number1)
                Console.WriteLine(numbers);*/

            Message<String> mensaje = new Message<string>("Hola");
            Console.WriteLine(mensaje.MostrarMensaje());
        }
    }
    /*public class MyList<T>
    {
        private T[] _elements;
        private int _index = 0;

        public MyList(int n)
        {
            _elements = new T[n];
        }

        public void Add(T e)
        {
            if (_index < _elements.Length)
            {
                _elements[_index] = e;
                _index++;
            }
        }

        public T GetElement(int i)
        {
            if (i <= _index && i >= 0)
            {
                return _elements[i];
            }

            return default(T);
        }

        public string GetString()
        {
            int i = 0;
            string result = "";
            while (i < _index)
            {
                result += _elements[i].ToString() + "|";
                i++;
            }

            return result;
        }
    }*/

    public class Message<H>
    {
        public H elemnts { get; set; }

        public Message(H value)
        {
            elemnts = value;
        }

        public H MostrarMensaje ()
        {
            return elemnts;
        }
    }
}
