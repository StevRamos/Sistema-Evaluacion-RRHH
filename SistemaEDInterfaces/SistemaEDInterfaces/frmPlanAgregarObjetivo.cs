using SistemaEDInterfaces.ObjetivoWS;
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
    public partial class frmPlanAgregarObjetivo : Form
    {

        private ObjetivoWS.objetivo objetivo;
        private double sumaPesoObjetivos; 
        private ObjetivoWS.ObjetivoWSClient daoObjetivo;

        public ObjetivoWS.objetivo Objetivo { get => objetivo; set => objetivo = value; }
        public double SumaPesoObjetivos { get => sumaPesoObjetivos; set => sumaPesoObjetivos = value; }

        public frmPlanAgregarObjetivo()
        {
            objetivo = new ObjetivoWS.objetivo();
            objetivo.colaborador = new ObjetivoWS.colaborador();
            daoObjetivo = new ObjetivoWS.ObjetivoWSClient();
            InitializeComponent();
        }

        private int realizarValidacion()
        {
            int valido = 1;
            double peso = Double.Parse(txtPeso.Text); 
            //Validar el peso
            if ( peso<0 || peso>100)
            {
                MessageBox.Show("Peso incorrecto, debe ingresar un peso entre 0 y 100.",
                    "Mensaje de error",
                    MessageBoxButtons.OK,
                    MessageBoxIcon.Error);
                valido = 0; 
            }
            return valido; 

        }
        private void btnRegistrar_Click(object sender, EventArgs e)
        {

            if (realizarValidacion() == 1) {
                objetivo.descripcion = txtDescripcion.Text;
                objetivo.peso = Double.Parse(txtPeso.Text);
                objetivo.meta = Double.Parse(txtMeta.Text);
                objetivo.unidadMedida = txtUnidadMedida.Text;
                objetivo.estado = (int)EstadoObjetivo.EsperandoRevision;
                objetivo.fechaFormulacion = DateTime.Now;
                sumaPesoObjetivos += objetivo.peso; 

                int resultado = daoObjetivo.insertarObjetivo(objetivo);
                if (resultado != 0)
                {
                    MessageBox.Show("Nuevo objetivo registrado correctamente.",
                    "Mensaje de confirmacion",
                    MessageBoxButtons.OK,
                    MessageBoxIcon.Information);
                    this.DialogResult = DialogResult.OK;
                    this.Close();
                }
                else
                {
                    MessageBox.Show("Ocurrio un error al intentar registrar el objetivo, intentelo nuevamente.",
                    "Mensaje de error",
                    MessageBoxButtons.OK,
                    MessageBoxIcon.Error);
                }
            }
            
            
            
        }

        private void txtMeta_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!char.IsControl(e.KeyChar) && !char.IsDigit(e.KeyChar) &&
            (e.KeyChar != '.'))
            {
                e.Handled = true;
            }

            // Solo permitir un punto decimal
            if ((e.KeyChar == '.') && ((sender as TextBox).Text.IndexOf('.') > -1))
            {
                e.Handled = true;
            }
        }

        private void txtPeso_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!char.IsControl(e.KeyChar) && !char.IsDigit(e.KeyChar) &&
            (e.KeyChar != '.'))
            {
                e.Handled = true;
            }

            // Solo permitir un punto decimal
            if ((e.KeyChar == '.') && ((sender as TextBox).Text.IndexOf('.') > -1))
            {
                e.Handled = true;
            }
        }
    }
}
