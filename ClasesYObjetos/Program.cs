using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ClasesYObjetos
{
    internal class Program
    {
        static void Main(string[] args)
        {
            sale sale1 = new sale("Hector", "Almonte",
                "Toyota", "Corolla", 100000, DateTime.Now);
            Console.WriteLine(sale1.Recibo());
        }
    }

    class sale
    {
        string Nombre;
        string Apellido;
        string marcaVehiculo;
        string nombreVehiculo;
        int precio;
        DateTime fechaCompra;

        public sale(string nombre, string apellido, string marca,
            string nombreV, int precio, DateTime date)
        {
            this.Nombre = nombre;
            this.Apellido = apellido;
            this.marcaVehiculo = marca;
            this.nombreVehiculo = nombreV;
            this.precio = precio;
            this.fechaCompra = date;
        }

        public string Recibo()
        {
            Console.WriteLine("----------RECIBO DE COMPRA----------");
            return $"Nombre: {Nombre}\n" +
                $"Apellido: {Apellido}\n" +
                $"Marca del Vehiculo: {marcaVehiculo}\n" +
                $"Nombre del Vehiculo: {nombreVehiculo}\n" +
                $"Precio: {precio}\n" +
                $"Fecha de compra: {fechaCompra.ToLongDateString()}";
        }
    }
}
