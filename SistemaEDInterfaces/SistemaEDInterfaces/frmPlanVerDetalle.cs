using SistemaEDInterfaces.EvaluacionDesempenhoWS;
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
        private EvaluacionDesempenhoWS.evaluacionDesempenho evaluacionDesempenho; 
        
        private ColaboradorWS.colaborador colaborador;

        private ObjetivoWS.ObjetivoWSClient daoObjetivo;

        private ObjetivoWS.objetivo objetivo;

        public ObjetivoWS.objetivo Objetivo { get => objetivo; set => objetivo = value; }
        public ColaboradorWS.colaborador Colaborador { get => colaborador; set => colaborador = value; }
        public evaluacionDesempenho EvaluacionDesempenho { get => evaluacionDesempenho; set => evaluacionDesempenho = value; }

        public frmPlanVerDetalle()
        {
            objetivo = new ObjetivoWS.objetivo();
            colaborador = new ColaboradorWS.colaborador();
            daoObjetivo = new ObjetivoWS.ObjetivoWSClient();
            InitializeComponent();
        }

        
        private void btnRegresar_Click(object sender, EventArgs e)
        {
            frmPlanRealizarRevision form = new frmPlanRealizarRevision();
            form.Colaborador = colaborador;
            form.EvaluacionDesempenho = evaluacionDesempenho;
            Global.formPrincipal.abrirFormularioHijo(true,form); 
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
                        
                        objetivo.estado = (int)EstadoObjetivo.Aprobado;
                        objetivo.observacion = form.ObservacionesTextBox;
                        objetivo.fechaAprobacion = DateTime.Now;
                        if (daoObjetivo.actualizarObjetivo(objetivo) != 0)
                        {
                            MessageBox.Show("Se aprobó el objetivo.",
                                               "Mensaje de confirmacion",
                                               MessageBoxButtons.OK,
                                               MessageBoxIcon.Information);
                        }
                        else
                        {
                            MessageBox.Show("Ocurrio un error, por favor intentelo de nuevo.",
                                               "Mensaje de error",
                                               MessageBoxButtons.OK,
                                               MessageBoxIcon.Error);
                            return; 
                        }
                        txtEstado.Text = "Aprobado"; 
                        txtBoxObservacionJefe.Text = form.ObservacionesTextBox;
                        lblFechaAprobacion.Show();
                        dtpFechaAprobacion.Show();
                        dtpFechaAprobacion.Value = DateTime.Now;
                    }
                }
                else
                {
                    objetivo.estado = (int)EstadoObjetivo.Aprobado;
                    objetivo.fechaAprobacion = DateTime.Now;
                    if (daoObjetivo.actualizarObjetivo(objetivo) != 0)
                    {
                        MessageBox.Show("Se aprobó el objetivo.",
                                           "Mensaje de confirmacion",
                                           MessageBoxButtons.OK,
                                           MessageBoxIcon.Information);
                    }
                    else
                    {
                        MessageBox.Show("Ocurrio un error, por favor intentelo de nuevo.",
                                           "Mensaje de error",
                                           MessageBoxButtons.OK,
                                           MessageBoxIcon.Error);
                        return;
                    }
                    txtEstado.Text = "Aprobado";
                    lblFechaAprobacion.Show();
                    dtpFechaAprobacion.Show(); 
                    dtpFechaAprobacion.Value = DateTime.Now;
                }

            }
            else if(rbDenegar.Checked)
            {
                frmPlanAgregarObservacionObj form = new frmPlanAgregarObservacionObj();
                if (form.ShowDialog() == DialogResult.OK)
                {
                    int anteriorEstado;
                    anteriorEstado = objetivo.estado; 
                    objetivo.estado = (int)EstadoObjetivo.Denegado;
                    objetivo.observacion = form.ObservacionesTextBox;
                    if (daoObjetivo.actualizarObjetivo(objetivo) != 0)
                    {
                        MessageBox.Show("Se denegó el objetivo.",
                                           "Mensaje de confirmacion",
                                           MessageBoxButtons.OK,
                                           MessageBoxIcon.Information);
                       
                    }
                    else
                    {
                        MessageBox.Show("Ocurrio un error, por favor intentelo de nuevo.",
                                              "Mensaje de error",
                                              MessageBoxButtons.OK,
                                              MessageBoxIcon.Error);
                        return;

                    }
                    txtEstado.Text = "Denegado"; 
                    txtBoxObservacionJefe.Text = form.ObservacionesTextBox;
                    if(anteriorEstado == (int)EstadoObjetivo.Aprobado)
                    {
                        lblFechaAprobacion.Hide();
                        dtpFechaAprobacion.Hide();
                    }
                    
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
                
                case (int)EstadoObjetivo.EsperandoRevision:
                    txtEstado.Text = "Esperando Revision";
                    lblFechaAprobacion.Hide();
                    dtpFechaAprobacion.Hide(); 
                    break;
                case (int)EstadoObjetivo.Denegado:
                    txtEstado.Text = "Denegado";
                    lblFechaAprobacion.Hide();
                    dtpFechaAprobacion.Hide();
                    break;
                case (int)EstadoObjetivo.Aprobado:
                    txtEstado.Text = "Aprobado";
                    dtpFechaAprobacion.Value = objetivo.fechaAprobacion;
                    break;
            }


            //Datos del colaborador 
            txtIDColab.Text = colaborador.idColaborador.ToString();
            txtNombre.Text = colaborador.nombres;
            txtDNI.Text = colaborador.dni.ToString();
            txtGerencia.Text = colaborador.gerencia.nombre;
            txtCargo.Text = colaborador.puestoTrabajo.nombre;
            //Datos del objetivo 
            txtMeta.Text = objetivo.meta.ToString();
            txtUnidadMedida.Text = objetivo.unidadMedida;
            txtBoxObservacionJefe.Text = objetivo.observacion; 
            dtpFechaFormulacion.Value = objetivo.fechaFormulacion;
            txtPeso.Text = objetivo.peso.ToString();
            txtBoxDescripcion.Text = objetivo.descripcion;
            txtBoxObservacionJefe.Text = objetivo.observacion;
            
            
        }
    }
}
