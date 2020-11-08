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



        private void btnRegreCargMavSubPot_Click_1(object sender, EventArgs e)
        {
            this.Close();
        }

        private void btnGestSubPotSelecSubPot_Click_1(object sender, EventArgs e)
        {
            OpenFileDialog buscar = new OpenFileDialog();
            if (buscar.ShowDialog() == DialogResult.OK)
            {
                txtNomArchSubPotMav.Text = buscar.FileName;
            }
        }

        private void btnGestSubPotSelecPesos_Click(object sender, EventArgs e)
        {
            OpenFileDialog buscar = new OpenFileDialog();
            if (buscar.ShowDialog() == DialogResult.OK)
            {
                txtNomArchSubPotPesosMav.Text = buscar.FileName;
            }
        }

        private void btnCargarMasivaGestSubPot_Click(object sender, EventArgs e)
        {
            MessageBox.Show("Se cargaron los archivos exitosamente");
            this.Close();
        }
    }
}
