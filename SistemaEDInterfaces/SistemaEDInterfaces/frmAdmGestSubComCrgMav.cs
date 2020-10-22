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
    public partial class frmAdmGestSubComCrgMav : Form
    {
        public frmAdmGestSubComCrgMav()
        {
            InitializeComponent();
        }

        private void btnGestSubComSelecSubCom_Click(object sender, EventArgs e)
        {
            OpenFileDialog buscar = new OpenFileDialog();
            if (buscar.ShowDialog() == DialogResult.OK)
            {
                txtNomArchSubComMav.Text = buscar.FileName;
            }
        }

        private void btnCargarSubComMasiva_Click(object sender, EventArgs e)
        {
            //Accion para cargar los datos a la base de datos
            if ((rdbActCargaMavSubCom.Checked || rdbInsCargaMavSubCom.Checked) && txtNomArchSubComMav.Text != "")
            {
                MessageBox.Show("El archivo se cargó correctamente");
                this.Close();
            }
            else if ((rdbActCargaMavSubCom.Checked == false) && (rdbInsCargaMavSubCom.Checked == false) && txtNomArchSubComMav.Text != "")
            {
                MessageBox.Show("Elija la opción insertar o actualizar");
            }
            else if ((txtNomArchSubComMav.Text == "") && (rdbActCargaMavSubCom.Checked || rdbInsCargaMavSubCom.Checked))
            {
                MessageBox.Show("Inserte su archivo");
            }
            else if ((rdbActCargaMavSubCom.Checked == false || rdbInsCargaMavSubCom.Checked == false) && txtNomArchSubComMav.Text == "")
            {
                MessageBox.Show("Ingrese los datos");
            }
        }

        private void btnRegreCargMavSubComp_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
