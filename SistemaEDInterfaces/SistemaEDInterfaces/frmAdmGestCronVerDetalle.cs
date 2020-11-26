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

        private PeriodoWS.periodo periodo;

        private GerenciaPeriodoWS.GerenciaPeriodoWSClient daoGerenciaPeriodo;

        private PeriodoWS.PeriodoWSClient daoPeriodo;

        private BindingList<PeriodoWS.gerenciaPeriodo> gerenciasPeriodos;
        public PeriodoWS.periodo Periodo { get => periodo; set => periodo = value; }
        
        
        public frmAdmGestCronVerDetalle()
        {
            InitializeComponent();
            daoGerenciaPeriodo = new GerenciaPeriodoWS.GerenciaPeriodoWSClient();
            daoPeriodo = new PeriodoWS.PeriodoWSClient(); 
            

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

        private void btnGuardar_Click(object sender, EventArgs e)
        {

            if (realizarValidaciones() == 0)
            {
                return; 

            }

            periodo.nombre = txtNombre.Text;
            periodo.fechaInicio = dtpFechaInicio.Value;
            periodo.fechaFin = dtpFechaFin.Value;
            periodo.fechaInicioSpecified = true; 
            periodo.fechaFinSpecified = true; 
            periodo.pesoEvalObj = (Double.Parse(txtPesoObjetivos.Text))/100;
            periodo.pesoEvalComp = (Double.Parse(txtPesoCompetencia.Text))/100;
            periodo.diaNotificacion = cboDiaNotificacion.SelectedItem.ToString();
            //periodo.horaNotificacion = dtpHoraNotificacion.Value;

            //Specified de GerenciasPeriodos
            if (periodo.configuracionFechas != null)
            {
                for (int i = 0; i < periodo.configuracionFechas.Count(); i++)
                {
                    periodo.configuracionFechas[i].fechaInicioPlanSpecified = true;
                    periodo.configuracionFechas[i].fechaFinPlanSpecified = true;
                    periodo.configuracionFechas[i].fechaInicioEvalPrevDSpecified = true;
                    periodo.configuracionFechas[i].fechaFinEvalPrevDSpecified = true;
                    periodo.configuracionFechas[i].fechaInicioEvalFinDSpecified = true;
                    periodo.configuracionFechas[i].fechaFinEvalFinDSpecified = true;
                    periodo.configuracionFechas[i].fechaInicioCalSpecified = true;
                    periodo.configuracionFechas[i].fechaFinCalSpecified = true;
                    periodo.configuracionFechas[i].fechaInicioPDISpecified = true;
                    periodo.configuracionFechas[i].fechaFinPDISpecified = true;

                }
            }
            

            if (daoPeriodo.actualizarPeriodo(periodo) != 0)
            {
                MessageBox.Show("se guardaron los cambios.",
                "mensaje de confirmacion",
                MessageBoxButtons.OK,
                MessageBoxIcon.Information);
                Global.formPrincipal.abrirFormularioHijo(true, new frmAdmGestCron());
            }
            else
            {
                MessageBox.Show("ocurrio un error, intentelo de nuevo.",
                                                   "mensaje de error",
                                                   MessageBoxButtons.OK,
                                                   MessageBoxIcon.Error);
            }
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
            //Llena configuraciones fecha
            //periodo = daoPeriodo.listarGerenciaPeriodo(periodo);

            txtID.Text = periodo.idPeriodo.ToString();
            txtNombre.Text = periodo.nombre;
            txtEstado.Text = periodo.estado.ToString();
            dtpFechaInicio.Value = periodo.fechaInicio;
            dtpFechaFin.Value = periodo.fechaFin;
            txtPesoCompetencia.Text = (periodo.pesoEvalComp*100).ToString();
            txtPesoObjetivos.Text = (periodo.pesoEvalObj*100).ToString();
            String dia = periodo.diaNotificacion;
            cboDiaNotificacion.SelectedItem = dia; 
            //DGV 
            
            dgvPlanificacion.DataSource = periodo.configuracionFechas;
            dgvCronEvPrevia.DataSource = periodo.configuracionFechas;
            dgvCronEvFinal.DataSource = periodo.configuracionFechas;
            dgvPDI.DataSource = periodo.configuracionFechas;
            dgvCalibNotas.DataSource = periodo.configuracionFechas;

            //llenarDatosDummy();
            
        }


        //Funcion para actualizar las fechas de inicio/fin de una gerencia 
        
        private void actualizarGP(PeriodoWS.gerenciaPeriodo g)
        {
            for (int i = 0; i < periodo.configuracionFechas.Count(); i++)
            {
                if (periodo.configuracionFechas[i].gerencia.idGerencia == g.gerencia.idGerencia)
                {
                    periodo.configuracionFechas[i] = g;
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
                        gp = (PeriodoWS.gerenciaPeriodo)dgvPlanificacion.CurrentRow.DataBoundItem;
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
                        gp = (PeriodoWS.gerenciaPeriodo)dgvPDI.CurrentRow.DataBoundItem;
                        gp.fechaInicioPDI = fecha;
                    }

                    actualizarGP(gp);
                    dgvPlanificacion.DataSource = periodo.configuracionFechas;
                    dgvCronEvPrevia.DataSource = periodo.configuracionFechas;
                    dgvCronEvFinal.DataSource = periodo.configuracionFechas;
                    dgvPDI.DataSource = periodo.configuracionFechas;
                    dgvCalibNotas.DataSource = periodo.configuracionFechas;
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
                        gp = (PeriodoWS.gerenciaPeriodo)dgvPlanificacion.CurrentRow.DataBoundItem;
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
                        gp = (PeriodoWS.gerenciaPeriodo)dgvPDI.CurrentRow.DataBoundItem;
                        gp.fechaFinPDI = fecha;
                    }
                    actualizarGP(gp);
                    dgvPlanificacion.DataSource = periodo.configuracionFechas;
                    dgvCronEvPrevia.DataSource = periodo.configuracionFechas;
                    dgvCronEvFinal.DataSource = periodo.configuracionFechas;
                    dgvPDI.DataSource = periodo.configuracionFechas;
                    dgvCalibNotas.DataSource = periodo.configuracionFechas;
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

        private void dgvPlanificacion_CellFormatting(object sender, DataGridViewCellFormattingEventArgs e)
        {
            PeriodoWS.gerenciaPeriodo data = dgvPlanificacion.Rows[e.RowIndex].DataBoundItem as PeriodoWS.gerenciaPeriodo;

            dgvPlanificacion.Rows[e.RowIndex].Cells["ID1"].Value = data.gerencia.idGerencia;
            dgvPlanificacion.Rows[e.RowIndex].Cells["Nombre1"].Value = data.gerencia.nombre;
        }

        private void dgvCronEvPrevia_CellFormatting(object sender, DataGridViewCellFormattingEventArgs e)
        {
            PeriodoWS.gerenciaPeriodo data = dgvCronEvPrevia.Rows[e.RowIndex].DataBoundItem as PeriodoWS.gerenciaPeriodo;

            dgvCronEvPrevia.Rows[e.RowIndex].Cells["ID2"].Value = data.gerencia.idGerencia;
            dgvCronEvPrevia.Rows[e.RowIndex].Cells["Nombre2"].Value = data.gerencia.nombre;
        }

        private void dgvCronEvFinal_CellFormatting(object sender, DataGridViewCellFormattingEventArgs e)
        {
            PeriodoWS.gerenciaPeriodo data = dgvCronEvFinal.Rows[e.RowIndex].DataBoundItem as PeriodoWS.gerenciaPeriodo;

            dgvCronEvFinal.Rows[e.RowIndex].Cells["ID3"].Value = data.gerencia.idGerencia;
            dgvCronEvFinal.Rows[e.RowIndex].Cells["Nombre3"].Value = data.gerencia.nombre;
        }

        private void dgvCalibNotas_CellFormatting(object sender, DataGridViewCellFormattingEventArgs e)
        {
            PeriodoWS.gerenciaPeriodo data = dgvCalibNotas.Rows[e.RowIndex].DataBoundItem as PeriodoWS.gerenciaPeriodo;

            dgvCalibNotas.Rows[e.RowIndex].Cells["ID4"].Value = data.gerencia.idGerencia;
            dgvCalibNotas.Rows[e.RowIndex].Cells["Nombre4"].Value = data.gerencia.nombre;
        }

        private void dgvPDI_CellFormatting(object sender, DataGridViewCellFormattingEventArgs e)
        {
            PeriodoWS.gerenciaPeriodo data = dgvPDI.Rows[e.RowIndex].DataBoundItem as PeriodoWS.gerenciaPeriodo;

            dgvPDI.Rows[e.RowIndex].Cells["ID5"].Value = data.gerencia.idGerencia;
            dgvPDI.Rows[e.RowIndex].Cells["Nombre5"].Value = data.gerencia.nombre;
        }
    }
}
