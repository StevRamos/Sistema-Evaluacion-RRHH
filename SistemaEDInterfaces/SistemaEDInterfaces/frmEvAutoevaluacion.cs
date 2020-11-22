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
    public partial class frmEvAutoevaluacion : Form
    {
        public frmEvAutoevaluacion()
        {
            InitializeComponent();
        }

        private void btnSeleccionar_Click(object sender, EventArgs e)
        {
            Global.formPrincipal.abrirFormularioHijo(false, new frmEvAutoevaluacionComp());
        }

        private void btnGuardar_Click(object sender, EventArgs e)
        {
            MessageBox.Show("Se ha registrado correctamente",
                "Mensaje Informativo", MessageBoxButtons.OK,
                MessageBoxIcon.Information);
        }

        private void btnFinalizar_Click(object sender, EventArgs e)
        {
            MessageBox.Show("Se ha registrado correctamente la auotevaluación",
                "Mensaje Informativo", MessageBoxButtons.OK,
                MessageBoxIcon.Information);
        }
    }
}
