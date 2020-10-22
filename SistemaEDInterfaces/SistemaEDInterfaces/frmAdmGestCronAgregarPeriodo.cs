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
    public partial class frmAdmGestCronAgregarPeriodo : Form
    {
        public frmAdmGestCronAgregarPeriodo()
        {
            InitializeComponent();
        }

        private void btnRegresar_Click(object sender, EventArgs e)
        {
            Global.formPrincipal.abrirFormularioHijo(true, new frmAdmGestCron());
        }

        private void btnRegistrar_Click(object sender, EventArgs e)
        {
            MessageBox.Show("Se registro un nuevo periodo.",
                "Mensaje de confirmacion",
                MessageBoxButtons.OK,
                MessageBoxIcon.Information);

            Global.formPrincipal.abrirFormularioHijo(true, new frmAdmGestCron());
        }
    }
}
