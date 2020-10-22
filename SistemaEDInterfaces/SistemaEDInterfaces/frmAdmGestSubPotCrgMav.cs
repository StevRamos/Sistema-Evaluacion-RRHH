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
    public partial class frmAdmGestSubPotCrgMav : Form
    {
        public frmAdmGestSubPotCrgMav()
        {
            InitializeComponent();
        }

        private void btnGestSubPotSelecSubPot_Click(object sender, EventArgs e)
        {
            OpenFileDialog buscar = new OpenFileDialog();
            if (buscar.ShowDialog() == DialogResult.OK)
            {
                txtNomArchSubPotMav.Text = buscar.FileName;
            }
        }

        private void btnCargarSubPotMasiva_Click(object sender, EventArgs e)
        {
            //Accion para cargar los datos a la base de datos
            if ((rdbActCargaMavSubPot.Checked || rdbInsCargaMavSubPot.Checked) && txtNomArchSubPotMav.Text != "")
            {
                MessageBox.Show("El archivo se cargó correctamente");
                this.Close();
            }
            else if ((rdbActCargaMavSubPot.Checked == false) && (rdbInsCargaMavSubPot.Checked == false) && txtNomArchSubPotMav.Text != "")
            {
                MessageBox.Show("Elija la opción insertar o actualizar");
            }
            else if ((txtNomArchSubPotMav.Text == "") && (rdbActCargaMavSubPot.Checked || rdbInsCargaMavSubPot.Checked))
            {
                MessageBox.Show("Inserte su archivo");
            }
            else if ((rdbInsCargaMavSubPot.Checked == false || rdbActCargaMavSubPot.Checked == false) && txtNomArchSubPotMav.Text == "")
            {
                MessageBox.Show("Ingrese los datos");
            }
        }

        private void btnRegreCargMavSubPot_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
