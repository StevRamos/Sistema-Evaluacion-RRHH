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
    public partial class frmEvMisTrabajadoresOpciones : Form
    {
        public frmEvMisTrabajadoresOpciones()
        {
            InitializeComponent();
        }

        private void btnRegresar_Click(object sender, EventArgs e)
        {
            Global.formPrincipal.cerrarFormularioHijo();
        }

        private void btnPrevia_Click(object sender, EventArgs e)
        {
            Global.formPrincipal.abrirFormularioHijo(false, new frmEvMisTrabajadoresPrevia());
        }

        private void btnFinal_Click(object sender, EventArgs e)
        {
            Global.formPrincipal.abrirFormularioHijo(false, new frmEvMisTrabajadoresFinal());
        }

        private void btnPotencial_Click(object sender, EventArgs e)
        {
            Global.formPrincipal.abrirFormularioHijo(false, new frmEvMisTrabajadoresEvPotencial());
        }
    }
}
