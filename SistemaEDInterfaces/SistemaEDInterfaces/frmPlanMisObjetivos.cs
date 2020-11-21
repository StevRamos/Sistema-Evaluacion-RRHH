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
    public partial class frmPlanMisObjetivos : Form
    {

        private ObjetivoWS.ObjetivoWSClient daoObjetivo;
        private EvaluacionDesempenhoWS.EvaluacionDesempenhoWSClient daoEvaluacionDesempenho;
        private EvaluacionDesempenhoWS.evaluacionDesempenho evaluacionDesempenho;
        private BindingList<ObjetivoWS.objetivo> objetivos;
        private int idColaboradorLoggeado;
        private double sumaPesoObjetivos;
        public int IdColaboradorLoggeado { get => idColaboradorLoggeado; set => idColaboradorLoggeado = value; }

        public frmPlanMisObjetivos()
        {
            InitializeComponent();
            daoObjetivo = new ObjetivoWS.ObjetivoWSClient();
            daoEvaluacionDesempenho = new EvaluacionDesempenhoWS.EvaluacionDesempenhoWSClient();
            dgvMisObjetivos.AutoGenerateColumns = false;
            IdColaboradorLoggeado = 1;

            //Obtener la evaluacion de desempenho del periodo actual 
            BindingList<EvaluacionDesempenhoWS.evaluacionDesempenho> evaluaciones;
            evaluaciones = new BindingList<EvaluacionDesempenhoWS.evaluacionDesempenho>
                (daoEvaluacionDesempenho.listarDesempenhoPorPeriodo(IdColaboradorLoggeado, Global.periodoActual.idPeriodo).ToArray());
            evaluacionDesempenho = evaluaciones.ElementAt(0);
            if (evaluacionDesempenho.estadoPlanificacion == (int)EstadoPlanificacion.OcultoParaColaborador)
            {
                btnAgregar.Enabled = false;
                btnEliminar.Enabled = false;
                btnEnviar.Enabled = false;
            }
            objetivos = new BindingList<ObjetivoWS.objetivo>
                                        (daoObjetivo.listarObjetivosXColaborador(IdColaboradorLoggeado).ToArray());
            if(objetivos!=null)dgvMisObjetivos.DataSource = objetivos;
            calcularSumaPesoObjetivos();

        }


        private void calcularSumaPesoObjetivos()
        {
            sumaPesoObjetivos = 0;
            foreach (ObjetivoWS.objetivo o in objetivos)
            {
                sumaPesoObjetivos += o.peso;
            }
        }
        public void agregarDatosDummyDGV()
        {
            int rowId1 = dgvMisObjetivos.Rows.Add();

            DataGridViewRow row1 = dgvMisObjetivos.Rows[rowId1];

            row1.Cells["Descripcion"].Value = "Vender 2000 laptops de las marcas Asus, Dell, Lenovo";
            row1.Cells["Numero"].Value = "1";
            row1.Cells["Peso"].Value = "60%";
            row1.Cells["Estado"].Value = "Revision Pendiente";

            int rowId2 = dgvMisObjetivos.Rows.Add();

            DataGridViewRow row2 = dgvMisObjetivos.Rows[rowId2];

            row2.Cells["Descripcion"].Value = "Vender 100 tablets";
            row2.Cells["Numero"].Value = "2";
            row2.Cells["Peso"].Value = "20%";
            row2.Cells["Estado"].Value = "Aprobado";

            int rowId3 = dgvMisObjetivos.Rows.Add();

            DataGridViewRow row3 = dgvMisObjetivos.Rows[rowId3];

            row3.Cells["Descripcion"].Value = "Vender 30 Celulares marca IPhone";
            row3.Cells["Numero"].Value = "3";
            row3.Cells["Peso"].Value = "20%";
            row3.Cells["Estado"].Value = "Rechazado";



        }
        private void iniciarEspera()
        {
            this.Cursor = Cursors.WaitCursor;
        }

        private void terminarEspera()
        {
            this.Cursor = Cursors.Default;
        }
        private void frmPlanMisObjetivos_Load(object sender, EventArgs e)
        {
            //Primero debe verificar las fechas 

            //Si la fecha actual esta dentro del rango fechas establecidas para la planificacion 
            //entonces podra realizar el registro de objetivos



            //agregarDatosDummyDGV();
        }

        private void btnAgregar_Click(object sender, EventArgs e)
        {

            frmPlanAgregarObjetivo form = new frmPlanAgregarObjetivo();
            form.Objetivo.colaborador.idColaborador = idColaboradorLoggeado;
            form.SumaPesoObjetivos = sumaPesoObjetivos;
            if (form.ShowDialog() == DialogResult.OK)
            {
                iniciarEspera();
                sumaPesoObjetivos = form.SumaPesoObjetivos;
                objetivos = new BindingList<ObjetivoWS.objetivo>
                                        (daoObjetivo.listarObjetivosXColaborador(IdColaboradorLoggeado).ToArray());
                dgvMisObjetivos.DataSource = objetivos;
                terminarEspera();
            }
        }

        private void panelContenedor_Paint(object sender, PaintEventArgs e)
        {

        }

        private void dgvMisObjetivos_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private int realizarValidacion()
        {
            int valido = 1;
            //Validar que los pesos de los objetivos sumen 100 
            if (sumaPesoObjetivos != 100)
            {
                MessageBox.Show("Los pesos de los objetivos deben sumar 100%.",
                                "Mensaje de error",
                                MessageBoxButtons.OK,
                                MessageBoxIcon.Error);
                valido = 0;
            }
            return valido;
        }
        private void btnEnviar_Click(object sender, EventArgs e)
        {
            if (realizarValidacion() == 0) return;

            if (evaluacionDesempenho.estadoPlanificacion == (int)EstadoPlanificacion.OcultoParaColaborador)
            {
                MessageBox.Show("Objetivos ya fueron enviados para revisión previamente.",
                                "Mensaje de error",
                                MessageBoxButtons.OK,
                                MessageBoxIcon.Error);
            }
            else
            {
                iniciarEspera();
                evaluacionDesempenho.estadoPlanificacion = (int)EstadoPlanificacion.OcultoParaColaborador;
                if (daoEvaluacionDesempenho.actualizarEvaluacionDesempenho(evaluacionDesempenho) == 1)
                {
                    //Enviar correo//
                    Correo.enviarCorreo("rodriguez.diego@pucp.edu.pe",
                                         Mensaje.TituloRegistroObjetivos("Jorge Baca"),
                                         Mensaje.CuerpoRegistroObjetivos("Jorge Baca", "Jorge Baca", 123456789));
                    ////////////////////////////////////////////
                    terminarEspera();
                    MessageBox.Show("Objetivos enviados para revision.",
                                "Mensaje de confirmacion",
                                MessageBoxButtons.OK,
                                MessageBoxIcon.Information);
                    btnAgregar.Enabled = false;
                    btnEliminar.Enabled = false;
                    btnEnviar.Enabled = false;

                }
                else
                {
                    MessageBox.Show("Ocurrio un error al enviar para revisión, intentelo nuevamente.",
                                "Mensaje de error",
                                MessageBoxButtons.OK,
                                MessageBoxIcon.Error);
                    evaluacionDesempenho.estadoPlanificacion = (int)EstadoPlanificacion.OcultoParaJefe;
                }
            }


        }

        private void btnVerDetalle_Click(object sender, EventArgs e)
        {
            if (dgvMisObjetivos.CurrentCell == null)
            {
                MessageBox.Show("Debe seleccionar un objetivo.",
                                   "Mensaje de error",
                                   MessageBoxButtons.OK,
                                   MessageBoxIcon.Error);
                return;
            }

            ObjetivoWS.objetivo objetivoSeleccionado =
            (ObjetivoWS.objetivo)dgvMisObjetivos.CurrentRow.DataBoundItem;

            frmPlanEditarObjetivo form = new frmPlanEditarObjetivo();
            form.Objetivo = objetivoSeleccionado;
            form.EvaluacionDesempenho = evaluacionDesempenho;
            form.SumaPesoObjetivos = sumaPesoObjetivos;
            Global.formPrincipal.abrirFormularioHijo(true, form);

        }

        private void btnEliminar_Click(object sender, EventArgs e)
        {

            if (dgvMisObjetivos.CurrentCell == null)
            {
                MessageBox.Show("Debe seleccionar un objetivo.",
                                   "Mensaje de error",
                                   MessageBoxButtons.OK,
                                   MessageBoxIcon.Error);
                return;
            }

            var result = MessageBox.Show("¿Esta seguro que desea eliminar el objetivo seleccionado?",
                                            "Mensaje de advertencia",
                                            MessageBoxButtons.YesNo,
                                            MessageBoxIcon.Warning);
            if (result == DialogResult.Yes)
            {
                ObjetivoWS.objetivo objetivo = (ObjetivoWS.objetivo)dgvMisObjetivos.CurrentRow.DataBoundItem;

                //Si es su turno de registrar objetivos entonces podra eliminarlo, en caso contrario no podra
                //hacerlo, tampoco podra eliminar si el objetivo se encuentra aprobado
                if (evaluacionDesempenho.estadoPlanificacion == (int)EstadoPlanificacion.OcultoParaJefe
                    && objetivo.estado != (int)EstadoObjetivo.Aprobado)
                {
                    sumaPesoObjetivos -= objetivo.peso;
                    daoObjetivo.eliminarObjetivo(objetivo.idObjetivo);
                    objetivos = new BindingList<ObjetivoWS.objetivo>
                                        (daoObjetivo.listarObjetivosXColaborador(IdColaboradorLoggeado).ToArray());
                    dgvMisObjetivos.DataSource = objetivos;

                }
                else
                {
                    MessageBox.Show("No puede eliminar el objetivo mientras se encuentra " +
                            "esperando revisión o si se encuentra aprobado.",
                    "Mensaje de Informacion",
                         MessageBoxButtons.OK,
                        MessageBoxIcon.Error);
                }

            }


        }
    }
}
