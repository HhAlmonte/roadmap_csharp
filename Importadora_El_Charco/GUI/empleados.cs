using System;
using BD;
using System.Windows.Forms;

namespace Importadora_El_Charcho
{
    public partial class empleados : Form
    {
        public empleados()
        {
            InitializeComponent();
        
        }
        private void empleados_Load(object sender, EventArgs e)
        {
            Refresh_();
        }
        private void Refresh_()
        {
            ImportadoraDB empleado = new ImportadoraDB();
            EmpleadosTable.DataSource = empleado.GetEmpleados();
        }
        private void limpiarCampos()
        {
            PosicionField.Text = "";
            NameField.Text = "";
            DireccionField.Text = "";
            EmailField.Text = "";
        }
        private void EmpleadosTable_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            try
            {
                IdField.Text = EmpleadosTable.CurrentRow.Cells[0].Value.ToString();
                NameField.Text = EmpleadosTable.CurrentRow.Cells[1].Value.ToString();
                PosicionField.Text = EmpleadosTable.CurrentRow.Cells[2].Value.ToString();
                EmailField.Text = EmpleadosTable.CurrentRow.Cells[3].Value.ToString();
                DireccionField.Text = EmpleadosTable.CurrentRow.Cells[4].Value.ToString();

            }
            catch (Exception)
            {

                throw;
            }
        }
        private void GuardarBtn_Click(object sender, EventArgs e)
        {
            ImportadoraDB empleadoAdd = new ImportadoraDB();

            try
            {
                empleadoAdd.Add(PosicionField.Text, NameField.Text, DireccionField.Text, EmailField.Text);
                Refresh_();
                limpiarCampos();
            }
            catch (Exception)
            {
                MessageBox.Show("Ocurrió un error ingresando los datos. Intentelo nuevamente");
                throw;
            }
        }
        private void EditBtn_Click(object sender, EventArgs e)
        {
            ImportadoraDB empleadoEdit = new ImportadoraDB();

            try
            {
                empleadoEdit.Update(PosicionField.Text, NameField.Text, DireccionField.Text, EmailField.Text, int.Parse(IdField.Text));
                Refresh_();
                limpiarCampos();
            }
            catch (Exception)
            {
                MessageBox.Show("Ocurrió un error editando los datos. Intentelo nuevamente.");
            }
        }
        private void DeleteBtn_Click(object sender, EventArgs e)
        {
            ImportadoraDB empleadoDelete = new ImportadoraDB();
            try
            {
                empleadoDelete.Delete(int.Parse(IdField.Text));
                Refresh_();
                limpiarCampos();
            }
            catch (Exception)
            {
                MessageBox.Show("Ocurrió un error eliminando los datos. Intentelo nuevamente.");
            }
        }
        private void RefreshBtn_Click(object sender, EventArgs e)
        {
            Refresh_();
            limpiarCampos();
        }
    }
}
