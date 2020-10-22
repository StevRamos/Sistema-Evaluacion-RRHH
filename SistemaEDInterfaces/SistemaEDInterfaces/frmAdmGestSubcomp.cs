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
    public partial class frmAdmGestSubcomp : Form
    {
        public frmAdmGestSubcomp()
        {
            InitializeComponent();
        }

        private void btnGestCrearSubCom_Click(object sender, EventArgs e)
        {
            Global.formPrincipal.abrirFormularioHijo(false, new frmAdmGestSubComAdd());
        }

        private void btnCargarMasivaSubCom_Click(object sender, EventArgs e)
        {
            Form formulario = new frmAdmGestSubComCrgMav();
            formulario.Show();
        }
    }
}
