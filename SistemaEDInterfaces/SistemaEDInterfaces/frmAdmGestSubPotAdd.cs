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
    public partial class frmAdmGestSubPotAdd : Form
    {
        public frmAdmGestSubPotAdd()
        {
            InitializeComponent();
        }

 

        private void btnGuardar_Click(object sender, EventArgs e)
        {
            MessageBox.Show("El subpotencial se agregó exitosamente");
            this.Close();
        }

        private void btnBusRegSubPot_Click(object sender, EventArgs e)
        {
            Form formulario = new frmAdmGestSubPotBuscarPot();
            formulario.Show();
        }

        private void btnRegresarAddSubPot_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
