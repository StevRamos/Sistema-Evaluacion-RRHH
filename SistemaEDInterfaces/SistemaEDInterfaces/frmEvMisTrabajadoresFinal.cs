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
    public partial class frmEvMisTrabajadoresFinal : Form
    {
        public frmEvMisTrabajadoresFinal()
        {
            InitializeComponent();
        }

        private void btnGuardar_Click(object sender, EventArgs e)
        {
            MessageBox.Show("Se ha registrado correctamente",
                "Mensaje Informativo", MessageBoxButtons.OK,
                MessageBoxIcon.Information);
        }

        private void btnRegresar_Click(object sender, EventArgs e)
        {
            Global.formPrincipal.cerrarFormularioHijo();
        }

        private void btnSeleccionar_Click(object sender, EventArgs e)
        {
            Global.formPrincipal.abrirFormularioHijo(false, new frmEvMisTrabajadoresFinalCompetencias());
        }

        private void btnFinalizar_Click(object sender, EventArgs e)
        {
            Global.formPrincipal.cerrarFormularioHijo();
        }
    }
}
