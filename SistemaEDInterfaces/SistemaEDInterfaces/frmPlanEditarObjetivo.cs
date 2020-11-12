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
        /*
        private ObjetivoWS.objetivo objetivo;

        private ObjetivoWS.ObjetivoWSClient daoObjetivo;
        
        public ObjetivoWS.objetivo Objetivo { get => objetivo; set => objetivo = value; }
        */
        public frmPlanEditarObjetivo()
        {
            //daoObjetivo = new ObjetivoWS.ObjetivoWSClient();
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
            
           /*
            objetivo.meta = Double.Parse(txtMeta.Text); ;
            objetivo.UnidadMedida = txtUnidadMedida.Text;
            objetivo.peso = Double.Parse(txtPeso.Text);
            objetivo.descripcion = txtBoxDescripcion.Text; 

            daoObjetivo.actualizarObjetivo(objetivo);*/
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
                Global.formPrincipal.abrirFormularioHijo(true,new frmPlanMisObjetivos());
            

        }

        
        private void txtUnidadMedida_TextChanged(object sender, EventArgs e)
        {

        }

        private void btnEditar_Click(object sender, EventArgs e)
        {
            /*
            if(objetivo.estado== EstadoObjetivo.Oculto || objetivo.estado == EstadoObjetivo.DenVisible)
            {
                cambiarEstadoComponentes(1);
            }
            else
            {
                MessageBox.Show("No puede editar el objetivo mientras se encuentra " +
                                "esperando revisión o si se encuentra aprobado.",
                "Mensaje de Informacion",
                MessageBoxButtons.OK,
                MessageBoxIcon.Information);
            }
            */
        }

        private void frmPlanEditarObjetivo_Load(object sender, EventArgs e)
        {
            /*
            txtID.Text = objetivo.idObjetivo.ToString();
            switch (objetivo.estado)
            {
                case EstadoObjetivo.Oculto:
                    txtEstado.Text = "Creado";
                    break;
                case EstadoObjetivo.EsperandoRevision:
                    txtEstado.Text = "Esperando Revision";
                    break;
                case EstadoObjetivo.DenOculto:
                    txtEstado.Text = "Esperando Revision";
                    break;
                case EstadoObjetivo.DenVisible:
                    txtEstado.Text = "Denegado";
                    break;
                case EstadoObjetivo.AprobOculto:
                    txtEstado.Text = "Esperando Revision";
                    break;
                case EstadoObjetivo.AprobVisible:
                    txtEstado.Text = "Aprobado";
                    break;
            }
            txtMeta.Text = objetivo.meta.ToString();
            txtUnidadMedida.Text = objetivo.unidadMedida;
            dtpFechaAprobacion.Value = objetivo.fechaAprobacion;
            dtpFechaFormulacion.Value = objetivo.fechaFormulacion;
            txtPeso.Text = objetivo.peso.ToString();
            txtBoxDescripcion.Text = objetivo.descripcion;
            txtBoxObservacionJefe.Text = objetivo.observacion;
            */
        }
    }
}
