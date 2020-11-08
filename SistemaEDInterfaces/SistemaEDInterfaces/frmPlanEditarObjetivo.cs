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
    public partial class frmPlanEditarObjetivo : Form
    {
        public frmPlanEditarObjetivo()
        {
            InitializeComponent();
        }

        void cambiarEstadoComponentes(int estado)
        {
            if (estado == 1)
            {
                txtBoxDescripcion.Enabled = true;
                txtPeso.Enabled = true;
                txtMeta.Enabled = true;
                txtUnidadMedida.Enabled = true; 
            }
            else
            {
                txtBoxDescripcion.Enabled = false;
                txtPeso.Enabled = false;
                txtMeta.Enabled = false;
                txtUnidadMedida.Enabled = false;
            }
        }

        private void btnGuardar_Click(object sender, EventArgs e)
        {
            cambiarEstadoComponentes(2);
            MessageBox.Show("Se guardaron los cambios.",
                "Mensaje de confirmacion",
                MessageBoxButtons.OK,
                MessageBoxIcon.Information);
            
        }

        private void btnAtras_Click(object sender, EventArgs e)
        {
            var result = MessageBox.Show("Datos no guardados se perderan. Retroceder de todos modos?",
                                            "Mensaje de advertencia",
                                            MessageBoxButtons.YesNo,
                                            MessageBoxIcon.Warning);
            if (result == DialogResult.Yes)
                Global.formPrincipal.cerrarFormularioHijo();
            

        }

        
        private void txtUnidadMedida_TextChanged(object sender, EventArgs e)
        {

        }

        private void btnEditar_Click(object sender, EventArgs e)
        {
            cambiarEstadoComponentes(1); 
        }
    }
}
