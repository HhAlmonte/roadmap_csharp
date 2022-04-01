using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BD
{
    public class empleado
    {
        public int Id { get; set; }
        public string nombre { get; set; }
        public string posicion { get; set; }
        public string email { get; set; }
        public string direccion { get; set; }

    }
    public class producto
    {
        public int Id { get; set; }
        public string nombre { get; set; }
        public string peso { get; set; }
        public string precio { get; set; }
        public string color { get; set; }
    }
    public class venta
    {
        public int Id { get; set; }
        public string producto { get; set; }
        public string nombre_cliente { get; set; }
        public int cantidad { get; set; }
        public int total { get; set; }
    }
}
