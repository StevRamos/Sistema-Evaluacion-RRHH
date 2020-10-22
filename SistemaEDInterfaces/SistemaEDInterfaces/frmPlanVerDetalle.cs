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
    public partial class frmPlanVerDetalle : Form
    {
        public frmPlanVerDetalle()
        {
            InitializeComponent();
        }

        
        private void btnRegresar_Click(object sender, EventArgs e)
        {
            var result = MessageBox.Show("Datos no guardados se perderan. Retroceder de todos modos?",
                                            "Mensaje de advertencia",
                                            MessageBoxButtons.YesNo,
                                            MessageBoxIcon.Warning);
            if (result == DialogResult.Yes)
                Global.formPrincipal.cerrarFormularioHijo();
        }

        private void btnRealizar_Click(object sender, EventArgs e)
        {
            if (rbAprobar.Checked)
            {
                var result = MessageBox.Show("¿Desea agregar un comentario?",
                                            "Mensaje de pregunta",
                                            MessageBoxButtons.YesNo,
                                            MessageBoxIcon.Question);
                if (result == DialogResult.Yes)
                {
                    frmPlanAgregarObservacionObj form = new frmPlanAgregarObservacionObj();
                    if(form.ShowDialog() == DialogResult.OK)
                    {
                        
                            MessageBox.Show("Se aprobó el objetivo.",
                                               "Mensaje de confirmacion",
                                               MessageBoxButtons.OK,
                                               MessageBoxIcon.Information);
                            txtBoxObservacionJefe.Text = form.ObservacionesTextBox;
                        
                 
                    }
                }
                else
                {
                    MessageBox.Show("Se aprobó el objetivo.",
                                               "Mensaje de confirmacion",
                                               MessageBoxButtons.OK,
                                               MessageBoxIcon.Information);
                }

            }
            else if(rbDenegar.Checked)
            {
                frmPlanAgregarObservacionObj form = new frmPlanAgregarObservacionObj();
                if (form.ShowDialog() == DialogResult.OK)
                {
                   
                        MessageBox.Show("Se denegó el objetivo.",
                                           "Mensaje de confirmacion",
                                           MessageBoxButtons.OK,
                                           MessageBoxIcon.Information);
                        txtBoxObservacionJefe.Text = form.ObservacionesTextBox;

                }
            }
            else
            {
                MessageBox.Show("Error: Debe aprobar o denegar el objetivo",
                                            "Mensaje de error",
                                            MessageBoxButtons.OK,
                                            MessageBoxIcon.Error);
            }
        }
    }
}
