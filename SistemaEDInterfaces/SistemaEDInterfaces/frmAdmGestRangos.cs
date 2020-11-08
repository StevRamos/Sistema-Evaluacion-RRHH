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
    public partial class frmAdmGestRangos : Form
    {
        //bool datosGuardados; 
        public frmAdmGestRangos()
        {
            InitializeComponent();
        }

        private void btnGuardar_Click(object sender, EventArgs e)
        {
            MessageBox.Show("Se guardaron los cambios realizados.",
                "Mensaje de información",
                MessageBoxButtons.OK,
                MessageBoxIcon.Information);
        }

        private void txtAMin_Leave(object sender, EventArgs e)
        {
            txtBMax.Text = txtAMin.Text;
        }

        private void txtBMin_Leave(object sender, EventArgs e)
        {
            txtCMax.Text = txtBMin.Text;
        }

        private void txtCMin_Leave(object sender, EventArgs e)
        {
            txtDMax.Text = txtCMin.Text;
        }

        private void txtDMin_Leave(object sender, EventArgs e)
        {
            txtEMax.Text = txtDMin.Text;
        }

        private void txtAltoMin_Leave(object sender, EventArgs e)
        {
            txtMedioMax.Text = txtAltoMin.Text;
        }

        private void txtMedioMin_Leave(object sender, EventArgs e)
        {
            txtBajoMax.Text = txtMedioMin.Text; 
        }

        private void txtFortalezaMin_Leave(object sender, EventArgs e)
        {
            txtOportunidadMax.Text = txtFortalezaMin.Text; 
        }

        private void txtOportunidadMin_Leave(object sender, EventArgs e)
        {
            txtDebilidadMax.Text = txtOportunidadMin.Text;
        }

        private void label12_Click(object sender, EventArgs e)
        {

        }
    }
}
