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



        private void btnRegreCargMavPot_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void btnCargarMasivaGestPot_Click(object sender, EventArgs e)
        {
            MessageBox.Show("Se cargaron los archivos exitosamente");
            this.Close();
        }

        private void btnGestPotSelecPot_Click(object sender, EventArgs e)
        {
            OpenFileDialog buscar = new OpenFileDialog();
            if (buscar.ShowDialog() == DialogResult.OK)
            {
                txtNomArchPotMav.Text = buscar.FileName;
            }
        }

        private void btnGestPotSelecPotPesos_Click(object sender, EventArgs e)
        {
            OpenFileDialog buscar = new OpenFileDialog();
            if (buscar.ShowDialog() == DialogResult.OK)
            {
                txtNomArchPotMavPesos.Text = buscar.FileName;
            }
        }
    }
}
