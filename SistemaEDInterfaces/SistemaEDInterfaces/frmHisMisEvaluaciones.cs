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
    public partial class frmHisMisEvaluaciones : Form
    {
        private PeriodoWS.PeriodoWSClient daoPeriodo;
        private BindingList<PeriodoWS.periodo> periodosPasados;
        private EvaluacionPotencialWS.EvaluacionPotencialWSClient daoEvaluacionPotencial;
        private EvaluacionDesempenhoWS.EvaluacionDesempenhoWSClient daoEvaluacionDesempenho; 
        public frmHisMisEvaluaciones()
        {
            InitializeComponent();
            daoPeriodo = new PeriodoWS.PeriodoWSClient();
            daoEvaluacionPotencial = new EvaluacionPotencialWS.EvaluacionPotencialWSClient();
            daoEvaluacionDesempenho = new EvaluacionDesempenhoWS.EvaluacionDesempenhoWSClient(); 
            periodosPasados = new BindingList<PeriodoWS.periodo>(); 
            dgvPeriodos.AutoGenerateColumns = false;
            PeriodoWS.periodo []lista = daoPeriodo.listarPeriodos();
            if (lista != null)
            {
                for(int i = 0; i < lista.Count(); i++)
                {
                    if(lista[i].idPeriodo!=Global.periodoActual.idPeriodo)periodosPasados.Add(lista[i]); 
                }
                dgvPeriodos.DataSource = periodosPasados; 
            }
            
        }

        private int validarEvaluacion(PeriodoWS.periodo periodoSeleccionado)
        {
            int esValido = 1;
            EvaluacionDesempenhoWS.evaluacionDesempenho evaluacionDesempenho = 
                                                daoEvaluacionDesempenho.obtenerEvaluacionDesempenho(Global.colaboradorLoggeado.idColaborador, periodoSeleccionado.idPeriodo);
            EvaluacionPotencialWS.evaluacion evaluacionPotencial
                                                = daoEvaluacionPotencial.obtenerEvaluacionPotencial(Global.colaboradorLoggeado.idColaborador, periodoSeleccionado.idPeriodo);
            int resultado = 0; 
            if(evaluacionDesempenho == null || evaluacionPotencial == null)
            {
                return 0; 
            }
            if(evaluacionDesempenho.idEvaluacion == 0 || evaluacionPotencial.idEvaluacion == 0)
            {
                return 0; 
            }
            return esValido; 
        }
        private void btnSeleccionar_Click(object sender, EventArgs e)
        {
            if (dgvPeriodos.CurrentCell == null)
            {
                MessageBox.Show("Debe seleccionar un periodo.",
                               "Mensaje de error",
                               MessageBoxButtons.OK,
                               MessageBoxIcon.Error);
                return;
            }

            PeriodoWS.periodo periodoSeleccionado = (PeriodoWS.periodo)dgvPeriodos.CurrentRow.DataBoundItem; 
            //Verificar si tiene evaluacion en ese periodo 
            Global.iniciarEspera(this);
            if (validarEvaluacion(periodoSeleccionado) == 0)
            {
                MessageBox.Show("Usted no tiene una evaluación en ese periodo .",
                               "Mensaje de error",
                               MessageBoxButtons.OK,
                               MessageBoxIcon.Error);
                Global.terminarEspera(this);
                return;
            }
            Global.terminarEspera(this); 
            frmEvMisResultados form = new frmEvMisResultados();
            form.Colaborador = Global.colaboradorLoggeado;
            form.Periodo = periodoSeleccionado;
            form.Modo = ModoResultados.HisMisEval;
            Global.formPrincipal.abrirFormularioHijo(false, form);
        }
        public void agregarDatosDummyDGV()
        {
            int rowId1 = dgvPeriodos.Rows.Add();

            DataGridViewRow row1 = dgvPeriodos.Rows[rowId1];

            row1.Cells["ID"].Value = "1";
            row1.Cells["Nombre"].Value = "Periodo 2019-1";
            row1.Cells["FechaInicio"].Value = "01/01/2019";
            row1.Cells["FechaFin"].Value = "31/06/2019";
            
            int rowId2 = dgvPeriodos.Rows.Add();

            DataGridViewRow row2 = dgvPeriodos.Rows[rowId2];

            row2.Cells["ID"].Value = "2";
            row2.Cells["Nombre"].Value = "Periodo 2019-2";
            row2.Cells["FechaInicio"].Value = "01/07/2019";
            row2.Cells["FechaFin"].Value = "30/12/2019";
            
            int rowId3 = dgvPeriodos.Rows.Add();

            DataGridViewRow row3 = dgvPeriodos.Rows[rowId3];

            row3.Cells["ID"].Value = "3";
            row3.Cells["Nombre"].Value = "Periodo 2020-1";
            row3.Cells["FechaInicio"].Value = "01/01/2020";
            row3.Cells["FechaFin"].Value = "31/06/2020";
            

        }
        private void frmHisMisEvaluaciones_Load(object sender, EventArgs e)
        {

            //agregarDatosDummyDGV();
        }
    }
}
