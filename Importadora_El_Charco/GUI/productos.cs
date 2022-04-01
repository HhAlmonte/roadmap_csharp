using System;
using BD;
using System.Windows.Forms;

namespace Importadora_El_Charcho
{
    public partial class productos : Form
    {
        public productos()
        {
            InitializeComponent();
        }
        private void productos_Load(object sender, EventArgs e)
        {
            Refresh_();
        }
        private void Refresh_()
        {
            ImportadoraDB productos = new ImportadoraDB();
            productosTable.DataSource = productos.GetProductos();
        }
        private void LimpiarCampos()
        {
            nameField.Text = null;
            precioField.Text = null;
            pesoField.Text = null;
            colorField.Text = null;
        }
        private void GuardarBtn_Click(object sender, EventArgs e)
        {
            ImportadoraDB productos = new ImportadoraDB();
            try
            {
                productos.AddProductos(nameField.Text, precioField.Text, pesoField.Text, colorField.Text);
                Refresh_();
                LimpiarCampos();
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Ocurrió un error de {ex}");
                throw;
            }
        }
        private void productosTable_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            try
            {
                idField.Text = productosTable.CurrentRow.Cells[0].Value.ToString();
                nameField.Text = productosTable.CurrentRow.Cells[1].Value.ToString();
                precioField.Text = productosTable.CurrentRow.Cells[2].Value.ToString();
                pesoField.Text = productosTable.CurrentRow.Cells[3].Value.ToString();
                colorField.Text = productosTable.CurrentRow.Cells[4].Value.ToString();
            }
            catch (Exception)
            {

                throw;
            }
        }
        private void EditBtn_Click(object sender, EventArgs e)
        {
            ImportadoraDB productos = new ImportadoraDB();
            try
            {
                productos.UpdateProductos(nameField.Text, precioField.Text, pesoField.Text, colorField.Text,
                    int.Parse(idField.Text));
                Refresh_();
                LimpiarCampos();
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Ocurrió un error modificando la fila: {ex}");
                throw;
            }
        }
        private void DeleteBtn_Click(object sender, EventArgs e)
        {
            ImportadoraDB productos = new ImportadoraDB();
            try
            {
                productos.DeleteProductos(int.Parse(idField.Text));
                Refresh_();
                LimpiarCampos();
            }
            catch (Exception)
            {
                MessageBox.Show("Hubo un error eliminando los datos de la tabla");
                throw;
            }
        }
        private void RefreshBtn_Click(object sender, EventArgs e)
        {
            Refresh_();
            LimpiarCampos();
        }
    }
}
