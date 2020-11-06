using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
//using System.Threading.Tasks;
using System.Windows.Forms;
using System.Diagnostics;

namespace SistemaEDInterfaces
{
    public partial class frmAdmGestComCrgMav : Form
    {
        public frmAdmGestComCrgMav()
        {
            InitializeComponent();
        }

        private void btnGestComSelecCom_Click(object sender, EventArgs e)
        {
            OpenFileDialog buscar = new OpenFileDialog();
            if (buscar.ShowDialog()== DialogResult.OK ) {
                txtNomArchComMav.Text = buscar.FileName;
            }
        }

        private void btnCargarComMasiva_Click(object sender, EventArgs e)
        {
            //Accion para cargar los datos a la base de datos
            if ((rdbActCargaMavCom.Checked || rdbInsCargaMavCom.Checked) && txtNomArchComMav.Text != "")
            {
                MessageBox.Show("El archivo se cargó correctamente");
                this.Close();
            }
            else if ((rdbActCargaMavCom.Checked == false) && (rdbInsCargaMavCom.Checked == false) && txtNomArchComMav.Text != "")
            {
                MessageBox.Show("Elija la opción insertar o actualizar");
            }
            else if ((txtNomArchComMav.Text == "") && (rdbActCargaMavCom.Checked || rdbInsCargaMavCom.Checked))
            {
                MessageBox.Show("Inserte su archivo");
            }
            else if ((rdbActCargaMavCom.Checked == false || rdbInsCargaMavCom.Checked == false) && txtNomArchComMav.Text == "")
            {
                MessageBox.Show("Ingrese los datos");
            }
        }

        private void btnRegreCargMavComp_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void label3_Click(object sender, EventArgs e)
        {

        }

        private void groupBox1_Enter(object sender, EventArgs e)
        {

        }

        private void btnGestComSelecComPesos_Click(object sender, EventArgs e)
        {
            OpenFileDialog buscar = new OpenFileDialog();
            if (buscar.ShowDialog() == DialogResult.OK)
            {
                txtNomArchCompePesosMav.Text = buscar.FileName;
            }
        }

        private void btnRegreCargMavCompePesos_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void btnCargarCompetMasiva_Click(object sender, EventArgs e)
        {
            MessageBox.Show("Se cargaron los archivos exitosamente");
            this.Close();
        }
    }
}
