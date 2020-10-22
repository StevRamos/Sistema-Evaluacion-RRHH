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
    public partial class frmAdmGestGerenCargaMav : Form
    {
        public frmAdmGestGerenCargaMav()
        {
            InitializeComponent();
        }

        private void btnCargarComMasiva_Click(object sender, EventArgs e)
        {
            if ((rdbActCargaMavGer.Checked || rdbInsCargaMavGer.Checked) && txtNomArchGerenMav.Text != "")
            {
                MessageBox.Show("El archivo se cargó correctamente");
                this.Close();
            }
            else if ((rdbActCargaMavGer.Checked == false) && (rdbInsCargaMavGer.Checked == false) && txtNomArchGerenMav.Text != "")
            {
                MessageBox.Show("Elija la opción insertar o actualizar");
            }
            else if ((txtNomArchGerenMav.Text == "") && (rdbInsCargaMavGer.Checked || rdbActCargaMavGer.Checked))
            {
                MessageBox.Show("Inserte su archivo");
            }
            else if ((rdbActCargaMavGer.Checked == false || rdbInsCargaMavGer.Checked == false) && txtNomArchGerenMav.Text == "")
            {
                MessageBox.Show("Ingrese los datos");
            }
        }

        private void btnGestGerSelecGer_Click(object sender, EventArgs e)
        {
            OpenFileDialog buscar = new OpenFileDialog();
            if (buscar.ShowDialog() == DialogResult.OK)
            {
                txtNomArchGerenMav.Text = buscar.FileName;
            }
        }

        private void btnRegreCargMavGer_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
