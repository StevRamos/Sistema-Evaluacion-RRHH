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
    public partial class frmAdmGestSubpot : Form
    {
        public frmAdmGestSubpot()
        {
            InitializeComponent();
        }



        private void btnCrearCompetencia_Click(object sender, EventArgs e)
        {
            Global.formPrincipal.abrirFormularioHijo(false, new frmAdmGestSubPotAdd());
        }

        private void btnCargarMasivaSubPot_Click(object sender, EventArgs e)
        {
            Form formulario = new frmAdmGestSubPotCrgMav();
            formulario.Show();
        }
    }
}
