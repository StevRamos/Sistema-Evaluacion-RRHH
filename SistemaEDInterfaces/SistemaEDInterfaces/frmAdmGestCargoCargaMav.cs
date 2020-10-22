using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace SistemaEDInterfaces
{
    public partial class frmAdmGestCargoCargaMav : Form
    {
        public frmAdmGestCargoCargaMav()
        {
            InitializeComponent();
        }

        private void btnGestCargoSelecCargo_Click(object sender, EventArgs e)
        {
            OpenFileDialog buscar = new OpenFileDialog();
            if (buscar.ShowDialog() == DialogResult.OK)
            {
                txtNomArchCargoMav.Text = buscar.FileName;
            }
        }

        private void btnCargarCargoMasiva_Click(object sender, EventArgs e)
        {
            if ((rdbActCargaMavCargo.Checked || rdbInsCargaMavCargo.Checked) && txtNomArchCargoMav.Text != "")
            {
                MessageBox.Show("El archivo se cargó correctamente");
                this.Close();
            }
            else if ((rdbActCargaMavCargo.Checked == false) && (rdbInsCargaMavCargo.Checked == false) && txtNomArchCargoMav.Text != "")
            {
                MessageBox.Show("Elija la opción insertar o actualizar");
            }
            else if ((txtNomArchCargoMav.Text == "") && (rdbInsCargaMavCargo.Checked || rdbActCargaMavCargo.Checked))
            {
                MessageBox.Show("Inserte su archivo");
            }
            else if ((rdbActCargaMavCargo.Checked == false || rdbInsCargaMavCargo.Checked == false) && txtNomArchCargoMav.Text == "")
            {
                MessageBox.Show("Ingrese los datos");
            }
        }

        private void btnRegreCargMavCargo_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
