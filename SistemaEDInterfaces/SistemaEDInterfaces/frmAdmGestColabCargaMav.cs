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
    public partial class frmAdmGestColabCargaMav : Form
    {
        public frmAdmGestColabCargaMav()
        {
            InitializeComponent();
        }

        private void btnGestColabSelecColab_Click(object sender, EventArgs e)
        {
            OpenFileDialog buscar = new OpenFileDialog();
            if (buscar.ShowDialog() == DialogResult.OK)
            {
                txtNomArchColabMav.Text = buscar.FileName;
            }
        }

        private void btnCargarColabMasiva_Click(object sender, EventArgs e)
        {
            if ((rdbActCargaMavColab.Checked || rdbInsCargaMavColab.Checked) && txtNomArchColabMav.Text != "")
            {
                MessageBox.Show("El archivo se cargó correctamente");
                this.Close();
            }
            else if ((rdbActCargaMavColab.Checked == false) && (rdbInsCargaMavColab.Checked == false) && txtNomArchColabMav.Text != "")
            {
                MessageBox.Show("Elija la opción insertar o actualizar");
            }
            else if ((txtNomArchColabMav.Text == "") && (rdbInsCargaMavColab.Checked || rdbActCargaMavColab.Checked))
            {
                MessageBox.Show("Inserte su archivo");
            }
            else if ((rdbActCargaMavColab.Checked == false || rdbInsCargaMavColab.Checked == false) && txtNomArchColabMav.Text == "")
            {
                MessageBox.Show("Ingrese los datos");
            }
        }

        private void btnRegreCargMavColab_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
