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
    public partial class frmPlanEditarObjetivo : Form
    {
        private bool seRealizaronCambios; 

        private double sumaPesoObjetivos; 

        private int estado;

        private ObjetivoWS.objetivo objetivo;

        private ObjetivoWS.ObjetivoWSClient daoObjetivo;

        private EvaluacionDesempenhoWS.evaluacionDesempenho evaluacionDesempenho;
        public ObjetivoWS.objetivo Objetivo { get => objetivo; set => objetivo = value; }
        public evaluacionDesempenho EvaluacionDesempenho { get => evaluacionDesempenho; set => evaluacionDesempenho = value; }
        public double SumaPesoObjetivos { get => sumaPesoObjetivos; set => sumaPesoObjetivos = value; }

        public frmPlanEditarObjetivo()
        {
            InitializeComponent();
            evaluacionDesempenho = new evaluacionDesempenho();
            daoObjetivo = new ObjetivoWS.ObjetivoWSClient();
            seRealizaronCambios = false; 

        }

        void cambiarEstadoComponentes(int nuevoEstado)
        {
            estado = nuevoEstado;
            if (estado == 1)
            {
                txtBoxDescripcion.Enabled = true;
                txtPeso.Enabled = true;
                txtMeta.Enabled = true;
                txtUnidadMedida.Enabled = true;
            }
            else if (estado == 2)
            {
                txtBoxDescripcion.Enabled = false;
                txtPeso.Enabled = false;
                txtMeta.Enabled = false;
                txtUnidadMedida.Enabled = false;
            }
            else if (estado == 3)
            {
                txtBoxDescripcion.Enabled = false;
                txtPeso.Enabled = false;
                txtMeta.Enabled = false;
                txtUnidadMedida.Enabled = false;
                btnEditar.Enabled = false;
                btnGuardar.Enabled = false;

            }
        }

        private int realizarValidacion()
        {
            int valido = 1;
            double peso = Double.Parse(txtPeso.Text);
            //Validar el peso
            if (peso < 0 || peso > 100)
            {
                MessageBox.Show("Peso incorrecto, debe ingresar un peso entre 0 y 100.",
                    "Mensaje de error",
                    MessageBoxButtons.OK,
                    MessageBoxIcon.Error);
                valido = 0;
            }
            else
            {
                //Validar la suma de pesos

                if ((sumaPesoObjetivos + peso) > 100 || (sumaPesoObjetivos + peso) < 0)
                {
                    MessageBox.Show("Los pesos de los objetivos no pueden sumar mas de 100",
                    "Mensaje de error",
                    MessageBoxButtons.OK,
                    MessageBoxIcon.Error);
                    valido = 0;
                }


            }
            return valido; 
        }
        private void btnGuardar_Click(object sender, EventArgs e)
        {
            if(realizarValidacion() == 0)
            {
                return; 
            }
            cambiarEstadoComponentes(2);
            objetivo.meta = Double.Parse(txtMeta.Text); ;
            objetivo.unidadMedida = txtUnidadMedida.Text;
            objetivo.peso = Double.Parse(txtPeso.Text);
            objetivo.descripcion = txtBoxDescripcion.Text;

            if (daoObjetivo.actualizarObjetivo(objetivo) != 0)
            {
               MessageBox.Show("Se guardaron los cambios.",
               "Mensaje de confirmacion",
               MessageBoxButtons.OK,
               MessageBoxIcon.Information);
                seRealizaronCambios = false; 
            }
            else
            {
                MessageBox.Show("Ocurrio en error al guardar los cambios, intentelo de nuevo.",
               "Mensaje de error",
               MessageBoxButtons.OK,
               MessageBoxIcon.Error);
            }



        }

        private void btnAtras_Click(object sender, EventArgs e)
        {
            if (seRealizaronCambios)
            {
                var result = MessageBox.Show("Datos no guardados se perderan. Retroceder de todos modos?",
                                            "Mensaje de advertencia",
                                            MessageBoxButtons.YesNo,
                                            MessageBoxIcon.Warning);
                if (result == DialogResult.Yes)
                    Global.formPrincipal.abrirFormularioHijo(true, new frmPlanMisObjetivos());
            }
            else
            {
                Global.formPrincipal.abrirFormularioHijo(true, new frmPlanMisObjetivos());
            }


        }


        private void txtUnidadMedida_TextChanged(object sender, EventArgs e)
        {

        }

        private void btnEditar_Click(object sender, EventArgs e)
        {

            cambiarEstadoComponentes(1);

        }

        private void frmPlanEditarObjetivo_Load(object sender, EventArgs e)
        {

            switch (objetivo.estado)
            {
                case (int)EstadoObjetivo.EsperandoRevision:
                    txtEstado.Text = "Esperando Revision";
                    break;
                case (int)EstadoObjetivo.Denegado:
                    txtEstado.Text = "Denegado";
                    break;
                case (int)EstadoObjetivo.Aprobado:
                    txtEstado.Text = "Aprobado";
                    break;
            }

            txtID.Text = objetivo.idObjetivo.ToString();
            txtEstado.Text = objetivo.estado.ToString();
            txtMeta.Text = objetivo.meta.ToString();
            txtUnidadMedida.Text = objetivo.unidadMedida;
            if (objetivo.estado == (int)EstadoObjetivo.Aprobado)
            {
                dtpFechaAprobacion.Value = objetivo.fechaAprobacion;
            }
            else
            {
                lblFechaAprobacion.Hide();
                dtpFechaAprobacion.Hide(); 
            }
            dtpFechaFormulacion.Value = objetivo.fechaFormulacion;
            txtPeso.Text = objetivo.peso.ToString();
            txtBoxDescripcion.Text = objetivo.descripcion;
            txtBoxObservacionJefe.Text = objetivo.observacion;

            //Si el objetivo se encuentra aprobado o la planificacion se envio para revision
            //el colaborador no podra editar 
            if (objetivo.estado == (int)EstadoObjetivo.Aprobado
                || evaluacionDesempenho.estadoPlanificacion == (int)EstadoPlanificacion.OcultoParaColaborador)
            {
                cambiarEstadoComponentes(3);
            }
            else
            {
                cambiarEstadoComponentes(2);
            }
        }

        private void txtMeta_KeyPress(object sender, KeyPressEventArgs e)
        {
            seRealizaronCambios = true;
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
            seRealizaronCambios = true; 
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

        private void txtUnidadMedida_KeyPress(object sender, KeyPressEventArgs e)
        {

        }
    }
}
