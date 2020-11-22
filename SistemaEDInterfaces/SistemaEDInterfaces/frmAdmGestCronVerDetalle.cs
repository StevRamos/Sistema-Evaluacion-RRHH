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
    public partial class frmAdmGestCronVerDetalle : Form
    {
        private DateTimePicker oDateTimePicker;
        private PeriodoWS.periodo periodo;

        private GerenciaPeriodoWS.GerenciaPeriodoWSClient daoGerenciaPeriodo;

        private PeriodoWS.PeriodoWSClient daoPeriodo; 
        public PeriodoWS.periodo Periodo { get => periodo; set => periodo = value; }
        
        
        public frmAdmGestCronVerDetalle()
        {
            daoGerenciaPeriodo = new GerenciaPeriodoWS.GerenciaPeriodoWSClient();
            daoPeriodo = new PeriodoWS.PeriodoWSClient(); 
            InitializeComponent();

            

        }

        private void btnGuardar_Click(object sender, EventArgs e)
        {

            

            periodo.nombre = txtNombre.Text;
            periodo.fechaInicio = dtpFechaInicio.Value;
            periodo.fechaFin = dtpFechaFin.Value; 
            periodo.pesoEvalObj = Double.Parse(txtPesoObjetivos.Text);
            periodo.pesoEvalComp = Double.Parse(txtPesoCompetencia.Text);
            //periodo.diaNotificacion = cboDiaNotificacion.SelectedItem.ToString();
            //periodo.horaNotificacion = dtpHoraNotificacion.Value;

            //daoPeriodo.actualizarPeriodo(periodo);
            MessageBox.Show("Se guardaron los cambios.",
                "Mensaje de confirmacion",
                MessageBoxButtons.OK,
                MessageBoxIcon.Information);
            Global.formPrincipal.abrirFormularioHijo(true, new frmAdmGestCron());
        }

        private void btnRegresar_Click(object sender, EventArgs e)
        {
            var result = MessageBox.Show("Datos no guardados se perderan. Retroceder de todos modos?",
                                            "Mensaje de advertencia",
                                            MessageBoxButtons.YesNo,
                                            MessageBoxIcon.Warning);
            if (result == DialogResult.Yes)
                Global.formPrincipal.abrirFormularioHijo(true, new frmAdmGestCron());
        }

        private void lblGhost_Click(object sender, EventArgs e)
        {

        }

        private void llenarDatosDummy()
        {
            txtID.Text = "3";
            txtNombre.Text = "Periodo 2020";
            txtEstado.Text = "En proceso";
            dtpFechaInicio.Value = new DateTime(2020,01,01);
            dtpFechaFin.Value = new DateTime(2020,12,30);
            txtPesoObjetivos.Text = "50";
            txtPesoCompetencia.Text = "50";
            cboDiaNotificacion.SelectedIndex = 1; 
            

            //// Planificacion 
            int rowId1 = dgvPlanificacion.Rows.Add();

            DataGridViewRow row11 = dgvPlanificacion.Rows[rowId1];

            row11.Cells["ID"].Value = "1";
            row11.Cells["Nombre"].Value = "Gerencia de Finanzas";
            row11.Cells["FechaInicio"].Value = "20/01/2020";
            row11.Cells["FechaFin"].Value = "15/02/2020";
            
            int rowId2 = dgvPlanificacion.Rows.Add();
            /*
            DataGridViewRow row12 = dgvPlanificacion.Rows[rowId2];

            row12.Cells["ID"].Value = "2";
            row12.Cells["Nombre"].Value = "Gerencia de Comercialización";
            row12.Cells["FechaInicio"].Value = "26/01/2020";
            row12.Cells["FechaFin"].Value = "15/03/2020";

            int rowId3 = dgvPlanificacion.Rows.Add();

            DataGridViewRow row13 = dgvPlanificacion.Rows[rowId3];

            row13.Cells["ID"].Value = "3";
            row13.Cells["Nombre"].Value = "Gerencia de Producción";
            row13.Cells["FechaInicio"].Value = "15/02/2020";
            row13.Cells["FechaFin"].Value = "10/04/2020";

            //Evaluacion 

            //int rowId1 = dgvEvaluaciones.Rows.Add();

            //DataGridViewRow row21 = dgvEvaluaciones.Rows[rowId1];

            //row21.Cells["IDEv"].Value = "1";
            //row21.Cells["Nombre"].Value = "Gerencia de Finanzas";
            //row21.Cells["FechaInicio"].Value = "15/10/2020";
            //row21.Cells["FechaFin"].Value = "31/11/2020";

            //int rowId2 = dgvEvaluaciones.Rows.Add();

            //DataGridViewRow row22 = dgvEvaluaciones.Rows[rowId2];

            //row22.Cells["IDEv"].Value = "2";
            //row22.Cells["Nombre"].Value = "Gerencia de Comercialización";
            //row22.Cells["FechaInicio"].Value = "30/10/2020";
            //row22.Cells["FechaFin"].Value = "10/12/2020";

            //int rowId3 = dgvEvaluaciones.Rows.Add();

            //DataGridViewRow row23 = dgvEvaluaciones.Rows[rowId3];

            //row23.Cells["ID"].Value = "3";
            //row23.Cells["Nombre"].Value = "Gerencia de Producción";
            //row23.Cells["FechaInicio"].Value = "31/11/2020";
            //row23.Cells["FechaFin"].Value = "10/12/2020";

            ////PDI 

            //rowId1 = dgvPDI.Rows.Add();

            //DataGridViewRow row31 = dgvPDI.Rows[rowId1];

            //row31.Cells["ID"].Value = "1";
            //row31.Cells["Nombre"].Value = "Gerencia de Finanzas";
            //row31.Cells["FechaInicio"].Value = "15/12/2020";
            //row31.Cells["FechaFin"].Value = "20/12/2020";

            //rowId2 = dgvPDI.Rows.Add();

            //DataGridViewRow row32 = dgvPDI.Rows[rowId2];

            //row32.Cells["ID"].Value = "2";
            //row32.Cells["Nombre"].Value = "Gerencia de Comercialización";
            //row32.Cells["FechaInicio"].Value = "15/12/2020";
            //row32.Cells["FechaFin"].Value = "20/12/2020";

            //rowId3 = dgvPDI.Rows.Add();

            //DataGridViewRow row33 = dgvPDI.Rows[rowId3];

            //row33.Cells["ID"].Value = "3";
            //row33.Cells["Nombre"].Value = "Gerencia de Producción";
            //row33.Cells["FechaInicio"].Value = "15/12/2020";
            //row33.Cells["FechaFin"].Value = "20/12/2020";
            */
        }
        private void frmAdmGestCronVerDetalle_Load(object sender, EventArgs e)
        {
            /*
            txtID.Text = periodo.idPeriodo.ToString();
            txtNombre.Text = periodo.nombre;
            txtEstado.Text = periodo.estado;
            dtpFechaInicio.Value = periodo.fechaInicio;
            dtpFechaFin.Value = periodo.fechaFin;
            txtPesoCompetencia.Text = periodo.pesoEvalComp.ToString();
            txtPesoObjetivos.Text = periodo.pesoEvalObj.ToString();
            
            //DGV 
            periodo.configuracionFechas = daoGerenciaPeriodo.listarGerenciasPeriodoPorIdPeriodo(periodo.idPeriodo);
            dgvPlanificacion.DataSource = periodo.configuracionFechas;
            dgvCronEvPrevia.DataSource = periodo.configuracionFechas;
            dgvCronEvFinal.DataSource = periodo.configuracionFechas;
            dgvPDI.DataSource = periodo.configuracionFechas;
            dgvCalibNotas.DataSource = periodo.configuracionFechas;*/

            llenarDatosDummy();
            
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
                    if (etapa == Etapas.Planificacion) dgvPlanificacion.CurrentRow.Cells["FechaInicio"].Value = fecha.ToString("dd/MM/yyyy");
                    if (etapa == Etapas.PreviaD) dgvCronEvPrevia.CurrentRow.Cells["FechaInicio"].Value = fecha.ToString("dd/MM/yyyy");
                    if (etapa == Etapas.FinalD) dgvCronEvFinal.CurrentRow.Cells["FechaInicio"].Value = fecha.ToString("dd/MM/yyyy");
                    if (etapa == Etapas.Calibracion) dgvCalibNotas.CurrentRow.Cells["FechaInicio"].Value = fecha.ToString("dd/MM/yyyy");
                    if (etapa == Etapas.PDI) dgvPDI.CurrentRow.Cells["FechaInicio"].Value = fecha.ToString("dd/MM/yyyy");
                    GerenciaPeriodoWS.gerenciaPeriodo gp = (GerenciaPeriodoWS.gerenciaPeriodo)dgvPlanificacion.CurrentRow.DataBoundItem;
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
                    if (etapa == Etapas.Planificacion) dgvPlanificacion.CurrentRow.Cells["FechaFin"].Value = fecha.ToString("dd/MM/yyyy");
                    if(etapa == Etapas.PreviaD) dgvCronEvPrevia.CurrentRow.Cells["FechaFin"].Value = fecha.ToString("dd/MM/yyyy");
                    if(etapa == Etapas.FinalD) dgvCronEvFinal.CurrentRow.Cells["FechaFin"].Value = fecha.ToString("dd/MM/yyyy");
                    if(etapa == Etapas.Calibracion) dgvCalibNotas.CurrentRow.Cells["FechaFin"].Value = fecha.ToString("dd/MM/yyyy");
                    if(etapa == Etapas.PDI) dgvPDI.CurrentRow.Cells["FechaFin"].Value = fecha.ToString("dd/MM/yyyy");
                    GerenciaPeriodoWS.gerenciaPeriodo gp = (GerenciaPeriodoWS.gerenciaPeriodo)dgvPlanificacion.CurrentRow.DataBoundItem;
                    //actualizarGP(gp.gerencia.idGerencia, null, fecha, etapa);
                }
            }
        }
        private void dgvPlanificacion_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            if(e.ColumnIndex == 2 || e.ColumnIndex == 3)mostrarFormularioFechaYActualizar(e, Etapas.Planificacion);
        }

        private void dgvCronEvPrevia_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.ColumnIndex == 2 || e.ColumnIndex == 3)mostrarFormularioFechaYActualizar(e, Etapas.PreviaD);
        }

        private void dgvCronEvFinal_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.ColumnIndex == 2 || e.ColumnIndex == 3) mostrarFormularioFechaYActualizar(e, Etapas.FinalD);
        }

        private void dgvCalibNotas_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.ColumnIndex == 2 || e.ColumnIndex == 3) mostrarFormularioFechaYActualizar(e, Etapas.Calibracion);
        }

        private void dgvPDI_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.ColumnIndex == 2 || e.ColumnIndex == 3) mostrarFormularioFechaYActualizar(e, Etapas.PDI);
        }
    }
}
