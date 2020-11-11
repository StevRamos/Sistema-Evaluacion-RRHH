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
        private ColaboradorWS.colaborador colaborador;

        private ObjetivoWS.ObjetivoWSClient daoObjetivo;

        private ObjetivoWS.objetivo objetivo;

        public ObjetivoWS.objetivo Objetivo { get => objetivo; set => objetivo = value; }
        public ColaboradorWS.colaborador Colaborador { get => colaborador; set => colaborador = value; }
        public frmPlanVerDetalle()
        {
            colaborador = new ColaboradorWS.colaborador();
            daoObjetivo = new ObjetivoWS.ObjetivoWSClient();
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
                        dtpFechaAprobacion.Value = DateTime.Now;
                        objetivo.estado = EstadoObjetivo.AprobOculto;
                        objetivo.observacion = txtBoxObservacionJefe.Text;
                        objetivo.fechaAprobacion = dtpFechaAprobacion.Value;
                        daoObjetivo.actualizarObjetivo(objetivo);

                    }
                }
                else
                {
                    MessageBox.Show("Se aprobó el objetivo.",
                                               "Mensaje de confirmacion",
                                               MessageBoxButtons.OK,
                                               MessageBoxIcon.Information);
                    dtpFechaAprobacion.Value = DateTime.Now;
                    objetivo.estado = EstadoObjetivo.AprobOculto;
                    objetivo.observacion = txtBoxObservacionJefe.Text;
                    objetivo.fechaAprobacion = dtpFechaAprobacion.Value;
                    daoObjetivo.actualizarObjetivo(objetivo);
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
                    objetivo.estado = EstadoObjetivo.DenOculto;
                    objetivo.observacion = txtBoxObservacionJefe.Text;
                    daoObjetivo.actualizarObjetivo(objetivo);
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

        private void frmPlanVerDetalle_Load(object sender, EventArgs e)
        {
            txtIDObjetivo.Text = objetivo.idObjetivo.ToString();
            switch (objetivo.estado)
            {
                
                case EstadoObjetivo.EsperandoRevision:
                    txtEstado.Text = "Esperando Revision";
                    break;
                case EstadoObjetivo.DenOculto:
                    txtEstado.Text = "Denegado, no enviado";
                    break;
                case EstadoObjetivo.DenVisible:
                    txtEstado.Text = "Denegado, enviado";
                    break;
                case EstadoObjetivo.AprobOculto:
                    txtEstado.Text = "Aprobado, no enviado";
                    break;
                case EstadoObjetivo.AprobVisible:
                    txtEstado.Text = "Aprobado, enviado";
                    break;
            }
            txtMeta.Text = objetivo.meta.ToString();
            txtUnidadMedida.Text = objetivo.unidadMedida;
            dtpFechaAprobacion.Value = objetivo.fechaAprobacion;
            dtpFechaFormulacion.Value = objetivo.fechaFormulacion;
            txtPeso.Text = objetivo.peso.ToString();
            txtBoxDescripcion.Text = objetivo.descripcion;
            txtBoxObservacionJefe.Text = objetivo.observacion;
        }
    }
}
