using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows;

namespace BD
{
    public class ImportadoraDB
    {
        private string connectionString = @"Data Source=BRYAN\SQLEXPRESS; Initial Catalog=Importadora_el_Charco;
            User= sa; Password=123456";
        public bool StatusConnection()
        {
            try
            {
                SqlConnection connection = new SqlConnection(connectionString);
                connection.Open();
            }
            catch (Exception)
            {
                return false;
                throw;
            }
            return true;
        }

        #region Metodos de la seccion de productos
        public List<producto> GetProductos()
        {
            List<producto> productos = new List<producto>();

            string query = "select id_producto, nombre_del_producto, peso, precio, color_del_producto from productos";

            using(SqlConnection connection = new SqlConnection(connectionString))
            {
                SqlCommand command = new SqlCommand(query, connection);
                try
                {
                    connection.Open();
                    SqlDataReader reader = command.ExecuteReader();
                    while (reader.Read())
                    {
                        producto producto = new producto();
                        producto.Id = reader.GetInt32(0);
                        producto.nombre = reader.GetString(1);
                        producto.peso = reader.GetString(2);
                        producto.precio = reader.GetString(3);
                        producto.color = reader.GetString(4);
                        productos.Add(producto);
                    }
                    reader.Close();
                    connection.Close();
                }
                catch (Exception ex)
                {
                    MessageBox.Show($"Ocurrió un error de {ex}");
                    throw;
                }
            }
            return productos;
        }
        public void AddProductos(string nombre, string precio, string peso, string color)
        {
            string query = "INSERT INTO productos(nombre_del_producto, peso, precio, color_del_producto) " +
                "values (@nombre, @peso, @precio, @color)";
            using (SqlConnection connection = new SqlConnection(connectionString))
            {
                SqlCommand command = new SqlCommand(query, connection);
                command.Parameters.AddWithValue("@nombre", nombre);
                command.Parameters.AddWithValue("@peso", peso);
                command.Parameters.AddWithValue("@precio", precio);
                command.Parameters.AddWithValue("@color", color);
                try
                {
                    connection.Open();
                    command.ExecuteNonQuery();
                    connection.Close();
                }
                catch (Exception)
                {

                    throw;
                }
            }
        }
        public void UpdateProductos(string nombre, string precio, string peso, string color, int id)
        {
            string query = "update productos set nombre_del_producto = @nombre, peso = @peso, " +
                "precio = @precio, color_del_producto = @color where id_producto = @id";
            using(SqlConnection connection = new SqlConnection(connectionString))
            {
                SqlCommand command = new SqlCommand(query, connection);
                command.Parameters.AddWithValue("@nombre", nombre);
                command.Parameters.AddWithValue("@peso", peso);
                command.Parameters.AddWithValue("@precio", precio);
                command.Parameters.AddWithValue("@color", color);
                command.Parameters.AddWithValue("@id", id);
                try
                {
                    connection.Open();
                    command.ExecuteNonQuery();
                    connection.Close();
                }
                catch (Exception)
                {

                    throw;
                }
            }
        }
        public void DeleteProductos(int id)
        {
            string query = "DELETE FROM productos where id_producto = @id";
            using (SqlConnection connection = new SqlConnection(connectionString))
            {
                SqlCommand command = new SqlCommand(query, connection);
                command.Parameters.AddWithValue("@id",id);
                try
                {
                    connection.Open();
                    command.ExecuteNonQuery();
                    connection.Close();
                }
                catch (Exception)
                {
                    MessageBox.Show("Hubo un error borrando los datos de la base de datos");
                    throw;
                }
            }
        }
        #endregion

        
        #region Metodos de la seccion de empleados
        public List<empleado> GetEmpleados()
        {
            List<empleado> empleados = new List<empleado>();

            string query = "select ID_empleado, posición, nombre_completo, direccion, Email from empleados";

            using (SqlConnection connection = new SqlConnection(connectionString))
            {
                SqlCommand command = new SqlCommand(query, connection);
                try
                {
                    connection.Open();
                    SqlDataReader reader = command.ExecuteReader();
                    while (reader.Read())
                    {
                        empleado empleado = new empleado();
                        empleado.Id = reader.GetInt32(0);
                        empleado.posicion = reader.GetString(1);
                        empleado.nombre = reader.GetString(2);
                        empleado.direccion = reader.GetString(3);
                        empleado.email = reader.GetString(4);
                        empleados.Add(empleado);
                    }
                    reader.Close();
                    connection.Close();
                }
                catch (Exception)
                {
                    throw;
                }
            }

            return empleados;
        }
        public void Add(string posicion, string nombre, string direccion, string email)
        {
            string query = "INSERT INTO empleados(posición, nombre_completo, direccion, Email) " +
                "values (@posicion, @nombre_completo, @direccion, @email)";

            using (SqlConnection connection = new SqlConnection(connectionString))
            {
                SqlCommand command = new SqlCommand(query, connection);

                command.Parameters.AddWithValue("@posicion", posicion);
                command.Parameters.AddWithValue("@nombre_completo", nombre);
                command.Parameters.AddWithValue("@direccion", direccion);
                command.Parameters.AddWithValue("@email", email);
                try
                {
                    connection.Open();
                    command.ExecuteNonQuery();

                    connection.Close();
                }
                catch (Exception)
                {

                    throw;
                }
            }
        }
        public void Update(string posicion, string nombre, string direccion, string email, int id)
        {
            string query = "update empleados set posición = @posicion, nombre_completo = @nombre_completo, " +
                "direccion = @direccion, email = @email where ID_empleado = @id";

            using (SqlConnection connection = new SqlConnection(connectionString))
            {
                SqlCommand command = new SqlCommand(query, connection);

                command.Parameters.AddWithValue("@posicion", posicion);
                command.Parameters.AddWithValue("@nombre_completo", nombre);
                command.Parameters.AddWithValue("@direccion", direccion);
                command.Parameters.AddWithValue("@email", email);
                command.Parameters.AddWithValue("@id", id);
                try
                {
                    connection.Open();
                    command.ExecuteNonQuery();

                    connection.Close();
                }
                catch (Exception)
                {

                    throw;
                }
            }
        }
        public void Delete(int id)
        {
            string query = "DELETE FROM empleados WHERE ID_empleado = @id ";

            using (SqlConnection connection = new SqlConnection(connectionString))
            {
                SqlCommand command = new SqlCommand(query, connection);
                command.Parameters.AddWithValue("@id", id);
                try
                {
                    connection.Open();
                    command.ExecuteNonQuery();
                    connection.Close();
                }
                catch (Exception)
                {

                    throw;
                }
            }
        }
        #endregion   
    }
}
