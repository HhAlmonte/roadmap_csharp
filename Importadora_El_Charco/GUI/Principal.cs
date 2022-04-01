using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Importadora_El_Charcho
{
    public partial class Principal : Form
    {
        public Principal()
        {
            InitializeComponent();
        }

        private void label7_Click(object sender, EventArgs e)
        {

        }
        private void Principal_Load(object sender, EventArgs e)
        {
            logoInicioBtn_Click(null, e);
        }
        private void AbriFormHija(object formhija)
        {
            if (this.PanelContainer.Controls.Count > 0)
            {
                this.PanelContainer.Controls.RemoveAt(0);
            }
            Form fh = formhija as Form;
            fh.TopLevel = false;
            fh.Dock = DockStyle.Fill;
            this.PanelContainer.Controls.Add(fh);
            this.PanelContainer.Tag = fh;
            fh.Show();  
        }

        private void btnProductos_Click(object sender, EventArgs e)
        {
            AbriFormHija(new productos());
        }

        private void btnVentas_Click(object sender, EventArgs e)
        {
            AbriFormHija(new ventas());
        }

        private void btnEmpleados_Click(object sender, EventArgs e)
        {
            AbriFormHija(new empleados());
        }

        private void btnReportes_Click(object sender, EventArgs e)
        {
            AbriFormHija(new Reporte());
        }

        private void label1_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void logoInicioBtn_Click(object sender, EventArgs e)
        {
            AbriFormHija(new Inicio());
        }

        
    }
}
