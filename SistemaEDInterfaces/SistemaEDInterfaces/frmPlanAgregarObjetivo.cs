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
        private ObjetivoWS.ObjetivoWSClient daoObjetivo;

        public ObjetivoWS.objetivo Objetivo { get => objetivo; set => objetivo = value; }
        public frmPlanAgregarObjetivo()
        {
            objetivo = new ObjetivoWS.objetivo();
            objetivo.colaborador = new ObjetivoWS.colaborador(); 
            daoObjetivo = new ObjetivoWS.ObjetivoWSClient();
            InitializeComponent();
        }

        private void btnRegistrar_Click(object sender, EventArgs e)
        {
            
            objetivo.descripcion = txtDescripcion.Text;
            objetivo.peso = Double.Parse(txtPeso.Text);
            objetivo.meta = Double.Parse(txtMeta.Text);
            objetivo.unidadMedida = txtUnidadMedida.Text;
            objetivo.estado = (int)EstadoObjetivo.Oculto;
            objetivo.fechaFormulacion = DateTime.Now;

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
                
            
        }
    }
}
