using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Propiedades
{
    internal class Program
    {
        static void Main(string[] args)
        {
            sale sale1 = new sale(1000, DateTime.Now);
            Console.WriteLine(sale1.Total);
        }
    }

    class sale
    {
        private int total;
        private DateTime date;

        public int Total {
            get
            {
                return total;
            }
            set {
                total = value;
            }
        }

        public string Date
        {
            get
            {
                return date.ToLongDateString();
            }
        }

        public sale(int total, DateTime date)
        {
            this.total = total;
            this.date = date;
        }
    }
}
