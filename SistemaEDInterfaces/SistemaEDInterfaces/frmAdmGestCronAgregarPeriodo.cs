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
    public partial class frmAdmGestCronAgregarPeriodo : Form
    {
        private PeriodoWS.periodo periodo;

        private PeriodoWS.PeriodoWSClient daoPeriodo;

        private GerenciaWS.GerenciaWSClient daoGerencia;

        private BindingList<PeriodoWS.gerenciaPeriodo> gerenciasPeriodos;

        private GerenciaPeriodoWS.GerenciaPeriodoWSClient daoGerenciaPeriodo;
        public frmAdmGestCronAgregarPeriodo()
        {
            InitializeComponent();

            periodo = new PeriodoWS.periodo();

            daoPeriodo = new PeriodoWS.PeriodoWSClient();
            daoGerencia = new GerenciaWS.GerenciaWSClient();
            
        }

        private int realizarValidaciones()
        {
            int valido = 1;
            double pesoEvalObj = Double.Parse(txtPesoObjetivos.Text);
            double pesoEvalComp = Double.Parse(txtPesoCompetencia.Text);
            if (txtNombre.Text == "")
            {
                MessageBox.Show("Debe ingresar un nombre para el periodo",
                                            "Mensaje de error",
                                            MessageBoxButtons.OK,
                                            MessageBoxIcon.Error);
                return 0;
            }
            if (pesoEvalComp > 100 || pesoEvalComp < 0)
            {
                MessageBox.Show("El peso para la evaluación de competencia debe estar entre 0 y 100",
                                            "Mensaje de error",
                                            MessageBoxButtons.OK,
                                            MessageBoxIcon.Error);
                return 0;
            }
            if (pesoEvalObj > 100 || pesoEvalObj < 0)
            {
                MessageBox.Show("El peso para la evaluación de objetivos debe estar entre 0 y 100",
                                            "Mensaje de error",
                                            MessageBoxButtons.OK,
                                            MessageBoxIcon.Error);
                return 0;
            }
            if ((pesoEvalObj + pesoEvalComp) != 100)
            {
                MessageBox.Show("Los pesos de la evaluacion de objetivos y la evaluacion de competencias deben sumar 100",
                                            "Mensaje de error",
                                            MessageBoxButtons.OK,
                                            MessageBoxIcon.Error);
                return 0;
            }
            if (cboDiaNotificacion.SelectedItem == null)
            {
                MessageBox.Show("Debe seleccionar un día para la notificación semanal.",
                                            "Mensaje de error",
                                            MessageBoxButtons.OK,
                                            MessageBoxIcon.Error);
                return 0;
            }

            return valido;
        }


        private void btnRegresar_Click(object sender, EventArgs e)
        {
            var result = MessageBox.Show("No se registrará el periodo. Retroceder de todos modos?",
                                            "Mensaje de advertencia",
                                            MessageBoxButtons.YesNo,
                                            MessageBoxIcon.Warning);
            if (result == DialogResult.Yes)
                Global.formPrincipal.abrirFormularioHijo(true, new frmAdmGestCron());
        }

        private void btnRegistrar_Click(object sender, EventArgs e)
        {
            if (realizarValidaciones() == 0)
            {
                return;
            }
            periodo.nombre = txtNombre.Text;
            periodo.fechaInicio = dtpFechaInicio.Value;
            periodo.fechaFin = dtpFechaFin.Value;
            periodo.fechaFinSpecified = true;
            periodo.fechaInicioSpecified = true; 
            periodo.pesoEvalObj = (Double.Parse(txtPesoObjetivos.Text))/100;
            periodo.pesoEvalComp = (Double.Parse(txtPesoCompetencia.Text))/100;
            //periodo.diaNotificacion = cboDiaNotificacion.SelectedItem;
            //periodo.horaNotificacion = dtpHoraNotificacion.Value.ToString("hh:mm:ss") ;
            periodo.configuracionFechas = gerenciasPeriodos.ToArray();
            if (daoPeriodo.insertarPeriodo(periodo) != 0)
            {

                MessageBox.Show("Se registro un nuevo periodo.",
                   "Mensaje de confirmacion",
                   MessageBoxButtons.OK,
                   MessageBoxIcon.Information);
                Global.formPrincipal.abrirFormularioHijo(true, new frmAdmGestCron());


            }
            else
            {
                MessageBox.Show("Ocurrio un error al registrar, intentelo de nuevo.",
                                                   "Mensaje de error",
                                                   MessageBoxButtons.OK,
                                                   MessageBoxIcon.Error);
            }
        }
        private void frmAdmGestCronAgregarPeriodo_Load(object sender, EventArgs e)
        {
            BindingList<GerenciaWS.gerencia> gerencias = new BindingList<GerenciaWS.gerencia>
                                                            (daoGerencia.listarGerencias().ToArray());

            //Crear la lista de gerenciaXperiodos
            gerenciasPeriodos = new BindingList<PeriodoWS.gerenciaPeriodo>();

            foreach (GerenciaWS.gerencia g in gerencias)
            {
                PeriodoWS.gerenciaPeriodo gp = new PeriodoWS.gerenciaPeriodo();
                gp.gerencia = new PeriodoWS.gerencia();
                gp.gerencia.nombre = g.nombre;
                gp.gerencia.idGerencia = g.idGerencia;

                gp.fechaInicioPlan = DateTime.Now;
                gp.fechaFinPlan = DateTime.Now;
                gp.fechaInicioEvalPrevD = DateTime.Now;
                gp.fechaFinEvalPrevD = DateTime.Now;
                gp.fechaInicioEvalFinD = DateTime.Now;
                gp.fechaFinEvalFinD = DateTime.Now;
                gp.fechaInicioCal = DateTime.Now;
                gp.fechaFinCal = DateTime.Now;
                gp.fechaInicioPDI = DateTime.Now;
                gp.fechaFinPDI = DateTime.Now;
                gp.periodo.idPeriodo = periodo.idPeriodo;

                gp.fechaInicioPlanSpecified = true;
                gp.fechaFinPlanSpecified = true;
                gp.fechaInicioEvalPrevDSpecified = true;
                gp.fechaFinEvalPrevDSpecified = true;
                gp.fechaInicioEvalFinDSpecified = true;
                gp.fechaFinEvalFinDSpecified = true;
                gp.fechaInicioCalSpecified = true;
                gp.fechaFinCalSpecified = true;
                gp.fechaInicioPDISpecified = true;
                gp.fechaFinPDISpecified = true;

                gerenciasPeriodos.Add(gp);
            }

            dgvCronPlanificacion.AutoGenerateColumns = false;
            dgvCronEvPrevia.AutoGenerateColumns = false;
            dgvCronEvFinal.AutoGenerateColumns = false;
            dgvCronPDI.AutoGenerateColumns = false;
            dgvCalibNotas.AutoGenerateColumns = false;

            //Interesante sera ver como saldran en el dgv las fechas que ahorita estan en nulo
            dgvCronPlanificacion.DataSource = gerenciasPeriodos;
            dgvCronEvPrevia.DataSource = gerenciasPeriodos;
            dgvCronEvFinal.DataSource = gerenciasPeriodos;
            dgvCronPDI.DataSource = gerenciasPeriodos;
            dgvCalibNotas.DataSource = gerenciasPeriodos;
        }
        private void iniciarEspera()
        {
            this.Cursor = Cursors.WaitCursor;
        }

        private void terminarEspera()
        {
            this.Cursor = Cursors.Default;
        }
        //Funcion para actualizar las fechas de inicio/fin de una gerencia 

        private void actualizarGP(PeriodoWS.gerenciaPeriodo g)
        {

            for (int i = 0; i < gerenciasPeriodos.Count(); i++)
            {
                if (gerenciasPeriodos[i].gerencia.idGerencia == g.gerencia.idGerencia)
                {
                    gerenciasPeriodos[i] = g;
                }
            }

        }



        void mostrarFormularioFechaYActualizar(DataGridViewCellEventArgs e, Etapas etapa)
        {
            PeriodoWS.gerenciaPeriodo gp = new PeriodoWS.gerenciaPeriodo();

            if (e.ColumnIndex == 2)
            {
                frmAdmGestCronVerDetalleFecha form = new frmAdmGestCronVerDetalleFecha();
                form.Titulo = "Fecha de Inicio:";
                if (form.ShowDialog() == DialogResult.OK)
                {
                    DateTime fecha = form.FechaSeleccionada;


                    if (etapa == Etapas.Planificacion)
                    {
                        gp = (PeriodoWS.gerenciaPeriodo)dgvCronPlanificacion.CurrentRow.DataBoundItem;
                        gp.fechaInicioPlan = fecha;

                    }
                    else if (etapa == Etapas.PreviaD)
                    {
                        gp = (PeriodoWS.gerenciaPeriodo)dgvCronEvPrevia.CurrentRow.DataBoundItem;
                        gp.fechaInicioEvalPrevD = fecha;
                    }
                    else if (etapa == Etapas.FinalD)
                    {
                        gp = (PeriodoWS.gerenciaPeriodo)dgvCronEvFinal.CurrentRow.DataBoundItem;
                        gp.fechaInicioEvalFinD = fecha;
                    }
                    else if (etapa == Etapas.Calibracion)
                    {
                        gp = (PeriodoWS.gerenciaPeriodo)dgvCalibNotas.CurrentRow.DataBoundItem;
                        gp.fechaInicioCal = fecha;
                    }
                    else if (etapa == Etapas.PDI)
                    {
                        gp = (PeriodoWS.gerenciaPeriodo)dgvCronPDI.CurrentRow.DataBoundItem;
                        gp.fechaInicioPDI = fecha;
                    }

                    actualizarGP(gp);
                    dgvCronPlanificacion.DataSource = gerenciasPeriodos;
                    dgvCronEvPrevia.DataSource = gerenciasPeriodos;
                    dgvCronEvFinal.DataSource = gerenciasPeriodos;
                    dgvCronPDI.DataSource = gerenciasPeriodos;
                    dgvCalibNotas.DataSource = gerenciasPeriodos;
                }

            }
            else if (e.ColumnIndex == 3)
            {
                frmAdmGestCronVerDetalleFecha form = new frmAdmGestCronVerDetalleFecha();
                form.Titulo = "Fecha de Fin:";
                if (form.ShowDialog() == DialogResult.OK)
                {
                    DateTime fecha = form.FechaSeleccionada;

                    if (etapa == Etapas.Planificacion)
                    {
                        gp = (PeriodoWS.gerenciaPeriodo)dgvCronPlanificacion.CurrentRow.DataBoundItem;
                        gp.fechaFinPlan = fecha;
                    }
                    else if (etapa == Etapas.PreviaD)
                    {
                        gp = (PeriodoWS.gerenciaPeriodo)dgvCronEvPrevia.CurrentRow.DataBoundItem;
                        gp.fechaFinEvalPrevD = fecha;
                    }
                    else if (etapa == Etapas.FinalD)
                    {
                        gp = (PeriodoWS.gerenciaPeriodo)dgvCronEvFinal.CurrentRow.DataBoundItem;
                        gp.fechaFinEvalFinD = fecha;
                    }
                    else if (etapa == Etapas.Calibracion)
                    {
                        gp = (PeriodoWS.gerenciaPeriodo)dgvCalibNotas.CurrentRow.DataBoundItem;
                        gp.fechaFinCal = fecha;
                    }
                    else if (etapa == Etapas.PDI)
                    {
                        gp = (PeriodoWS.gerenciaPeriodo)dgvCronPDI.CurrentRow.DataBoundItem;
                        gp.fechaFinPDI = fecha;
                    }
                    actualizarGP(gp);
                    dgvCronPlanificacion.DataSource = gerenciasPeriodos;
                    dgvCronEvPrevia.DataSource = gerenciasPeriodos;
                    dgvCronEvFinal.DataSource = gerenciasPeriodos;
                    dgvCronPDI.DataSource = gerenciasPeriodos;
                    dgvCalibNotas.DataSource = gerenciasPeriodos;
                }
            }
        }

        private void dgvCronPlanificacion_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.ColumnIndex == 2 || e.ColumnIndex == 3) mostrarFormularioFechaYActualizar(e, Etapas.Planificacion);
        }

        private void dgvCronEvPrevia_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.ColumnIndex == 2 || e.ColumnIndex == 3) mostrarFormularioFechaYActualizar(e, Etapas.PreviaD);
        }

        private void dgvCronEvFinal_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.ColumnIndex == 2 || e.ColumnIndex == 3) mostrarFormularioFechaYActualizar(e, Etapas.FinalD);
        }

        private void dgvCalibNotas_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.ColumnIndex == 2 || e.ColumnIndex == 3) mostrarFormularioFechaYActualizar(e, Etapas.Calibracion);
        }

        private void dgvCronPDI_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.ColumnIndex == 2 || e.ColumnIndex == 3) mostrarFormularioFechaYActualizar(e, Etapas.PDI);
        }
    }
}
