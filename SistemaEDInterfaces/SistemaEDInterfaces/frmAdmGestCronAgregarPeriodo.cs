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

        private void llenarEscalasValoresPredeterminados()
        {
            BindingList<PeriodoWS.escalaPeriodo> escalasPredeterminadas = new BindingList<PeriodoWS.escalaPeriodo>();


            String[] nombresEscalas = new string[] { "A", "B", "C", "D", "E", "Alto", "Medio", "Bajo" }; 

            for(int i = 1; i <=nombresEscalas.Count(); i++)
            {
                PeriodoWS.escalaPeriodo ep = new PeriodoWS.escalaPeriodo();

                ep.escala = new PeriodoWS.escala();
                ep.escala.idEscala = i;
                switch (nombresEscalas[i-1])
                {
                    case "A":
                        ep.notaMax = 100;
                        ep.notaMin = 80;
                        ep.porcentajeCupos = 20; 
                        break;
                    case "B":
                        ep.notaMax = 80;
                        ep.notaMin = 60;
                        ep.porcentajeCupos = 20;

                        break;
                    case "C":
                        ep.notaMax = 60;
                        ep.notaMin = 40;
                        ep.porcentajeCupos = 20;
                        break;
                    case "D":
                        ep.notaMax = 40;
                        ep.notaMin = 20;
                        ep.porcentajeCupos = 20;
                        break;
                    case "E":
                        ep.notaMax = 20;
                        ep.notaMin = 0;
                        ep.porcentajeCupos = 20;
                        break;
                    case "Alto":
                        ep.notaMax = 100;
                        ep.notaMin = 80;
                        ep.porcentajeCupos = 0; 
                        break;
                    case "Medio":
                        ep.notaMax = 80;
                        ep.notaMin = 50;
                        ep.porcentajeCupos = 0; 
                        break;
                    case "Bajo":
                        ep.notaMax = 50;
                        ep.notaMin = 0;
                        ep.porcentajeCupos = 0; 
                        break; 
                }
                
                escalasPredeterminadas.Add(ep); 
                
            }

            periodo.escalas = escalasPredeterminadas.ToArray(); 
        }
        private void llenarItemsPDIValoresPredeterminados()
        {
            BindingList<PeriodoWS.itemPDIPeriodo> rangosPredeterminados = new BindingList<PeriodoWS.itemPDIPeriodo>();

            String[] nombresPDI = new string[] { "FORTALEZAS", "OPORTUNIDADES DE MEJORA", "DEBILIDADES" }; 
            for(int i=1; i <= nombresPDI.Count(); i++)
            {
                PeriodoWS.itemPDIPeriodo ip = new PeriodoWS.itemPDIPeriodo();

                ip.itemPDI = new PeriodoWS.itemPDI();
                ip.itemPDI.idItemPDI = i;
                switch (nombresPDI[i - 1])
                {
                    case "FORTALEZAS":
                        ip.notaMax = 100;
                        ip.notaMin = 75; 
                        break;
                    case "OPORTUNIDADES DE MEJORA":
                        ip.notaMax = 75;
                        ip.notaMin = 50; 
                        break;
                    case "DEBILIDADES":
                        ip.notaMax = 50;
                        ip.notaMin = 0; 
                        break; 
                }
                rangosPredeterminados.Add(ip); 
            }
            periodo.rangosPDI = rangosPredeterminados.ToArray();
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
            periodo.diaNotificacion = cboDiaNotificacion.SelectedItem.ToString();
            periodo.horaNotificacion = dtpHoraNotificacion.Value.ToString("HH:mm:ss"); 
            
            periodo.configuracionFechas = gerenciasPeriodos.ToArray();
            llenarEscalasValoresPredeterminados();
            llenarItemsPDIValoresPredeterminados();
            int resultado=1;
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
            GerenciaWS.gerencia[] lista = daoGerencia.listarGerencias();

            BindingList<GerenciaWS.gerencia> gerencias = new BindingList<GerenciaWS.gerencia>(); 
            if (lista != null)
            {
                gerencias = new BindingList<GerenciaWS.gerencia>(lista); 
            }
            //Crear la lista de gerenciaXperiodos
            gerenciasPeriodos = new BindingList<PeriodoWS.gerenciaPeriodo>();
            dtpHoraNotificacion.Value = DateTime.Parse("08:00:00");
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

            //POSIBLE ERROR SI GERENCIASPERIODOS ES LISTA VACIA 
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

        private void dgvCronPlanificacion_CellFormatting(object sender, DataGridViewCellFormattingEventArgs e)
        {
            
            PeriodoWS.gerenciaPeriodo data = dgvCronPlanificacion.Rows[e.RowIndex].DataBoundItem as PeriodoWS.gerenciaPeriodo;

            dgvCronPlanificacion.Rows[e.RowIndex].Cells["ID1"].Value = data.gerencia.idGerencia;
            dgvCronPlanificacion.Rows[e.RowIndex].Cells["Nombre1"].Value = data.gerencia.nombre;

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

        private void dgvCronPDI_CellFormatting(object sender, DataGridViewCellFormattingEventArgs e)
        {
            PeriodoWS.gerenciaPeriodo data = dgvCronPDI.Rows[e.RowIndex].DataBoundItem as PeriodoWS.gerenciaPeriodo;

            dgvCronPDI.Rows[e.RowIndex].Cells["ID5"].Value = data.gerencia.idGerencia;
            dgvCronPDI.Rows[e.RowIndex].Cells["Nombre5"].Value = data.gerencia.nombre;
        }

        private void txtPesoObjetivos_KeyPress(object sender, KeyPressEventArgs e)
        {
            Global.restringirADecimal(sender, e); 
        }

        private void txtPesoCompetencia_KeyPress(object sender, KeyPressEventArgs e)
        {
            Global.restringirADecimal(sender, e);
        }
    }
}
