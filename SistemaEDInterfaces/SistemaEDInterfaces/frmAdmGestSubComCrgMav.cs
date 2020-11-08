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



        private void btnCargarSubComMasiva_Click(object sender, EventArgs e)
        {

        }

        private void btnRegreCargMavSubComp_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void btnGestSubComSelecSubCom_Click_1(object sender, EventArgs e)
        {
            OpenFileDialog buscar = new OpenFileDialog();
            if (buscar.ShowDialog() == DialogResult.OK)
            {
                txtNomArchSubComMav.Text = buscar.FileName;
            }
        }

        private void btnGestSubComSelecPesos_Click(object sender, EventArgs e)
        {
            OpenFileDialog buscar = new OpenFileDialog();
            if (buscar.ShowDialog() == DialogResult.OK)
            {
                txtNomArchSubComPesosMav.Text = buscar.FileName;
            }
        }

        private void btnRegreCargMavGestSubCom_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void btnCargarMasivaGestSubCom_Click(object sender, EventArgs e)
        {
            MessageBox.Show("Se cargaron los archivos exitosamente");
            this.Close();
        }
    }
}
