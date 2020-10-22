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
    public partial class frmPlanRealizarRevision : Form
    {
        public frmPlanRealizarRevision()
        {
            InitializeComponent();
        }

        private void btnEnviar_Click(object sender, EventArgs e)
        {
            MessageBox.Show("Validaciones enviadas a colaborador",
                                           "Mensaje de confirmacion",
                                           MessageBoxButtons.OK,
                                           MessageBoxIcon.Information);

            Global.formPrincipal.cerrarFormularioHijo();
        }

        private void btnVerDetalle_Click(object sender, EventArgs e)
        {
            Global.formPrincipal.abrirFormularioHijo(false,new frmPlanVerDetalle());
        }

        private void btnRegresar_Click(object sender, EventArgs e)
        {
            var result = MessageBox.Show("¿Desea regresar? Validaciones no seran enviadas.",
                                           "Mensaje de pregunta",
                                           MessageBoxButtons.YesNo,
                                           MessageBoxIcon.Question);
            if (result == DialogResult.Yes)
            {
                Global.formPrincipal.cerrarFormularioHijo();
            }
            
        }
    }
}
