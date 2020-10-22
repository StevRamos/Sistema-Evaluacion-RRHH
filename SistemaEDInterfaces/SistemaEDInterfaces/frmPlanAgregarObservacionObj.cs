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
    public partial class frmPlanAgregarObservacionObj : Form
    {
        private bool seRealizoRegistro=false;
        private string observacionesTextBox; 


        public frmPlanAgregarObservacionObj()
        {
            
            InitializeComponent();
        }

        public string ObservacionesTextBox { get => observacionesTextBox; set => observacionesTextBox = value; }

        private void btnRegistrar_Click(object sender, EventArgs e)
        {
            seRealizoRegistro = true;
            this.DialogResult = DialogResult.OK;
            this.Close();
            
            
        }

        private void frmPlanAgregarObservacionObj_FormClosing(object sender, FormClosingEventArgs e)
        {
            if (!seRealizoRegistro)
            {
                var result = MessageBox.Show("Debe agregar un comentario, de lo contrario no se realizara la " +
                                            "validacion del objetivo ¿Cerrar de todos modos?",
                                               "Mensaje de pregunta",
                                               MessageBoxButtons.YesNo,
                                               MessageBoxIcon.Question);
                e.Cancel = (result == DialogResult.No);
                
                    
            }
            ObservacionesTextBox = txtObservaciones.Text;

        }
          
    }
}

