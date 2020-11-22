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
    public partial class frmEvMisTrabajadoresPotenciales : Form
    {
        public frmEvMisTrabajadoresPotenciales()
        {
            InitializeComponent();
        }

        private void btnRegresar_Click(object sender, EventArgs e)
        {
            Global.formPrincipal.cerrarFormularioHijo();
        }

        private void btnGuardar_Click(object sender, EventArgs e)
        {
            MessageBox.Show("Se ha registrado correctamente",
                "Mensaje Informativo", MessageBoxButtons.OK,
                MessageBoxIcon.Information);
        }

        private void btnFinalizar_Click(object sender, EventArgs e)
        {
            Global.formPrincipal.cerrarFormularioHijo();
        }
    }
    
}
