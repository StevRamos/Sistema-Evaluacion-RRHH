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

        private GerenciaPeriodoWS.GerenciaPeriodoWSClient daoGerenciaPeriodo;
        public frmAdmGestCronAgregarPeriodo()
        {
            InitializeComponent();
            /*
            periodo = new PeriodoWS.periodo();
            
            daoPeriodo = new PeriodoWS.PeriodoWSClient();
            daoGerencia = new GerenciaWS.GerenciaWSClient();
            daoGerenciaPeriodo = new GerenciaPeriodoWS.GerenciaPeriodoWSClient();
            BindingList<GerenciaWS.gerencia> gerencias = new BindingList<GerenciaWS.gerencia> 
                                                            (daoGerencia.listarGerencias().ToArray());

            periodo.configuracionFechas = new BindingList<GerenciaPeriodosWS.gerenciaPeriodo>();
            foreach (GerenciaWS.gerencia g in gerencias)
            {
                GerenciaPeriodoWS.gerenciaPeriodo gp = new GerenciaPeriodoWS.gerenciaPeriodo();
                gp.gerencia = g;
                gp.periodo = periodo; 
                periodo.configuracionFechas.Add(gp); 
            }
            
            dgvCronPlanificacion.AutoGenerateColumns = false;
            dgvCronEvPrevia.AutoGenerateColumns = false;
            dgvCronEvFinal.AutoGenerateColumns = false;
            dgvCronPDI.AutoGenerateColumns = false;
            dgvCalibNotas.AutoGenerateColumns = false;

            //Interesante sera ver como saldran en el dgv las fechas que ahorita estan en nulo
            dgvCronPlanificacion.DataSource = periodo.configuracionFechas; 
            dgvCronEvPrevia.DataSource = periodo.configuracionFechas; 
            dgvCronEvFinal.DataSource = periodo.configuracionFechas; 
            dgvCronPDI.DataSource = periodo.configuracionFechas; 
            dgvCalibNotas.DataSource = periodo.configuracionFechas; */
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
            periodo.nombre = txtNombre.Text;
            periodo.fechaInicio = dtpFechaInicio.Value;
            periodo.fechaFin = dtpFechaFin.Value;
            periodo.pesoEvalObj = Double.Parse(txtPesoObjetivos.Text);
            periodo.pesoEvalComp = Double.Parse(txtPesoCompetencia.Text);
            //periodo.diaNotificacion = cboDiaNotificacion.SelectedItem.ToString();
            //periodo.horaNotificacion = dtpHoraNotificacion.Value ;
            //daoPeriodo.registrarPeriodo(periodo);
            MessageBox.Show("Se registro un nuevo periodo.",
                "Mensaje de confirmacion",
                MessageBoxButtons.OK,
                MessageBoxIcon.Information);

            Global.formPrincipal.abrirFormularioHijo(true, new frmAdmGestCron());
        }

        private void frmAdmGestCronAgregarPeriodo_Load(object sender, EventArgs e)
        {

        }

        //Funcion para actualizar las fechas de inicio/fin de una gerencia 
        /*
        private void actualizarGP(int idGerencia, DateTime fechaInicio, DateTime fechaFin, Etapas etapa)
        {
            if (fechaInicio != null)
            {
                foreach(GerenciaPeriodoWS.gerenciaPeriodo gp in periodo.configuracionFechas)
                {
                    if (gp.gerencia.idGerencia == idGerencia)
                    {
                        if (etapa == Etapas.Planificacion)
                        {
                            gp.fechaInicioPlan = fechaInicio;
                        }
                        else if (etapa == Etapas.PreviaD)
                        {
                            gp.fechaInicioEvalPrevD = fechaInicio;
                        }
                        else if (etapa == Etapas.FinalD)
                        {
                            gp.fechaInicioEvalFinD = fechaInicio;
                        }
                        else if (etapa == Etapas.Calibracion)
                        {
                            gp.fechaInicioCal = fechaInicio;
                        }
                        else if (etapa == Etapas.PDI)
                        {
                            gp.fechaInicioPDI = fechaInicio;
                        }
                        break;
                    }
                }


            }
            if (fechaFin != null)
            {
                foreach(GerenciaPeriodoWS.gerenciaPeriodo gp in periodo.configuracionFechas)
                {
                    if (gp.gerencia.idGerencia == idGerencia)
                    {
                        if (etapa == Etapas.Planificacion)
                        {
                            gp.fechaFinPlan = fechaFin;
                        }
                        else if (etapa == Etapas.PreviaD)
                        {
                            gp.fechaFinEvalPrevD = fechaFin;
                        }
                        else if (etapa == Etapas.FinalD)
                        {
                            gp.fechaFinEvalFinD = fechaFin;
                        }
                        else if (etapa == Etapas.Calibracion)
                        {
                            gp.fechaFinCal = fechaFin;
                        }
                        else if (etapa == Etapas.PDI)
                        {
                            gp.fechaFinPDI = fechaFin;
                        }
                        break;
                    }
                }
            }
        }
        */

        void mostrarFormularioFechaYActualizar(DataGridViewCellEventArgs e, Etapas etapa)
        {
            if (e.ColumnIndex == 2)
            {
                frmAdmGestCronVerDetalleFecha form = new frmAdmGestCronVerDetalleFecha();
                form.Titulo = "Fecha de Inicio:";
                if (form.ShowDialog() == DialogResult.OK)
                {
                    DateTime fecha = form.FechaSeleccionada;
                    if (etapa == Etapas.Planificacion) dgvCronPlanificacion.CurrentRow.Cells["FechaInicio"].Value = fecha.ToString("dd/MM/yyyy");
                    if (etapa == Etapas.PreviaD) dgvCronEvPrevia.CurrentRow.Cells["FechaInicio"].Value = fecha.ToString("dd/MM/yyyy");
                    if (etapa == Etapas.FinalD) dgvCronEvFinal.CurrentRow.Cells["FechaInicio"].Value = fecha.ToString("dd/MM/yyyy");
                    if (etapa == Etapas.Calibracion) dgvCalibNotas.CurrentRow.Cells["FechaInicio"].Value = fecha.ToString("dd/MM/yyyy");
                    if (etapa == Etapas.PDI) dgvCronPDI.CurrentRow.Cells["FechaInicio"].Value = fecha.ToString("dd/MM/yyyy");
                    GerenciaPeriodoWS.gerenciaPeriodo gp = (GerenciaPeriodoWS.gerenciaPeriodo)dgvCronPlanificacion.CurrentRow.DataBoundItem;
                    //actualizarGP(gp.gerencia.idGerencia, fecha, null, etapa);
                }

            }
            else if (e.ColumnIndex == 3)
            {
                frmAdmGestCronVerDetalleFecha form = new frmAdmGestCronVerDetalleFecha();
                form.Titulo = "Fecha de Fin:";
                if (form.ShowDialog() == DialogResult.OK)
                {
                    DateTime fecha = form.FechaSeleccionada;
                    if (etapa == Etapas.Planificacion) dgvCronPlanificacion.CurrentRow.Cells["FechaFin"].Value = fecha.ToString("dd/MM/yyyy");
                    if (etapa == Etapas.PreviaD) dgvCronEvPrevia.CurrentRow.Cells["FechaFin"].Value = fecha.ToString("dd/MM/yyyy");
                    if (etapa == Etapas.FinalD) dgvCronEvFinal.CurrentRow.Cells["FechaFin"].Value = fecha.ToString("dd/MM/yyyy");
                    if (etapa == Etapas.Calibracion) dgvCalibNotas.CurrentRow.Cells["FechaFin"].Value = fecha.ToString("dd/MM/yyyy");
                    if (etapa == Etapas.PDI) dgvCronPDI.CurrentRow.Cells["FechaFin"].Value = fecha.ToString("dd/MM/yyyy");
                    GerenciaPeriodoWS.gerenciaPeriodo gp = (GerenciaPeriodoWS.gerenciaPeriodo)dgvCronPlanificacion.CurrentRow.DataBoundItem;
                    //actualizarGP(gp.gerencia.idGerencia, null, fecha, etapa);
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
