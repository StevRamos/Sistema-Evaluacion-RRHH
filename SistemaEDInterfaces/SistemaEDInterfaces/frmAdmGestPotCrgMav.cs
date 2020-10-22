using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Diagnostics;
namespace SistemaEDInterfaces
{
    public partial class frmAdmGestPotCrgMav : Form
    {
        public frmAdmGestPotCrgMav()
        {
            InitializeComponent();
        }

        private void btnGestPotSelecPot_Click(object sender, EventArgs e)
        {
            OpenFileDialog buscar = new OpenFileDialog();
            if (buscar.ShowDialog() == DialogResult.OK)
            {
                txtNomArchPotMav.Text = buscar.FileName;
            }
        }

        private void btnCargarPotMasiva_Click(object sender, EventArgs e)
        {
            
            if ((rdbActCargaMavPot.Checked || rdbInsCargaMavPot.Checked) && txtNomArchPotMav.Text != "") {
                MessageBox.Show("El archivo se cargó correctamente");
                this.Close();
            }
            else if ((rdbActCargaMavPot.Checked == false) && (rdbInsCargaMavPot.Checked == false) && txtNomArchPotMav.Text != "")
            {
                MessageBox.Show("Elija la opción insertar o actualizar");
            } else if ((txtNomArchPotMav.Text == "") && (rdbActCargaMavPot.Checked || rdbInsCargaMavPot.Checked))
            {
                MessageBox.Show("Inserte su archivo");
            } else if ((rdbActCargaMavPot.Checked==false || rdbInsCargaMavPot.Checked==false) && txtNomArchPotMav.Text == "") {
                MessageBox.Show("Ingrese los datos");
            }
        }
        private void btnRegreCargMavPot_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
