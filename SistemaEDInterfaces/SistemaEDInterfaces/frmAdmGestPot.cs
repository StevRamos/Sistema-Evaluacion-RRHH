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
    public partial class frmAdmGestPot : Form
    {
        public frmAdmGestPot()
        {
            InitializeComponent();
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void btnCrearPotencial_Click(object sender, EventArgs e)
        {
            Global.formPrincipal.abrirFormularioHijo(false, new frmAdmGestPotAdd());
        }

        private void btnCargarMasivaPot_Click(object sender, EventArgs e)
        {
            Form formulario = new frmAdmGestPotCrgMav();
            formulario.Show();
        }
    }
}
