using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace SistemaEDInterfaces
{
    public partial class frmEvMisResultados : Form
    {
        private int idColaborador;
        private int idPeriodo;
        private int idPuestoTrabajo;
        private EvaluacionDesempenhoWS.EvaluacionDesempenhoWSClient daoEvaluacionDesempenho;
        private EvaluacionDesempenhoWS.evaluacionDesempenho evaluacionDesempenho;
        //private EvaluacionWS.EvaluacionWSClient daoEvaluacion;
        //private EvaluacionWS.evaluacion evaluacionPotencial; 
        private ReporteWS.ReporteWSClient daoReporte;

        public frmEvMisResultados()
        {
            InitializeComponent();
            dgvCompetencias.AutoGenerateColumns = false;
            dgvObjetivos.AutoGenerateColumns = false;
            dgvPotenciales.AutoGenerateColumns = false; 
            daoEvaluacionDesempenho = new EvaluacionDesempenhoWS.EvaluacionDesempenhoWSClient();
            //daoEvaluacion = new EvaluacionWS.EvaluacionWSClient();
            daoReporte = new ReporteWS.ReporteWSClient();

            idColaborador = Global.colaboradorLoggeado.idColaborador;
            idPuestoTrabajo = Global.colaboradorLoggeado.puestoTrabajo.idPuestoTrabajo;
            idPeriodo = Global.periodoActual.idPeriodo;

            evaluacionDesempenho = daoEvaluacionDesempenho.obtenerEvaluacionDesempenho(idColaborador, idPeriodo);
            //evaluacionPotencial = daoEvaluacion.obtenerEvaluacion(idColaborador, idPeriodo);
            //Verificar si esta finalizada 
            /*
            if(evaluacionDesempenho.estado != (int)EstadoEvD.FinalFinalizada || evaluacion.estado != (int)EstadoEvalPot.Finalizada)
            {
                MessageBox.Show("Aun no puede visualizar resultados ya que la evaluacion no ha sido finalizada .",
                                "Mensaje de error",
                                MessageBoxButtons.OK,
                                MessageBoxIcon.Error);
                Global.formPrincipal.cerrarFormularioHijo();
                return; 
            }*/
            dgvObjetivos.DataSource = evaluacionDesempenho.objetivos;
            dgvCompetencias.DataSource = evaluacionDesempenho.lineasEvaluacion;
            //dgvPotenciales.DataSource = evaluacion.lineasEvaluacion; 
            txtObservacionesCompetencias.Text = evaluacionDesempenho.observacionesComp;
            txtObservacionesObjetivos.Text = evaluacionDesempenho.observacionesObj;
            //txtObservacionesPotencial.Text = evaluacion.observaciones; 
        }

        private void btnGenerar_Click(object sender, EventArgs e)
        {
            sfdReporte.FileOk += SfdReporte_FileOk;
            sfdReporte.FileName = "Reporte de Evaluacion.pdf";
            sfdReporte.ShowDialog();
            if (sfdReporte.FileName != null && sfdReporte.FileName != "")
            {
                byte[] arreglo;
                arreglo = daoReporte.generarReporteEvaluacion();
                Global.iniciarEspera(this);
                File.WriteAllBytes(sfdReporte.FileName, arreglo);
                Global.terminarEspera(this);
            }
        }

        private void SfdReporte_FileOk(object sender, CancelEventArgs e)
        {
            MessageBox.Show("Reporte generado exitosamente .",
                                "Mensaje de confirmacion",
                                MessageBoxButtons.OK,
                                MessageBoxIcon.Information);
        }

        private void btnSeleccionarPot_Click(object sender, EventArgs e)
        {
            if (dgvPotenciales.CurrentCell == null)
            {
                MessageBox.Show("Debe seleccionar un potencial.",
                                   "Mensaje de error",
                                   MessageBoxButtons.OK,
                                   MessageBoxIcon.Error);
                return;
            }
            /*
            EvaluacionWS.lineaEvaluacion lineaSeleccionada = (EvaluacionWS.lineaEvaluacion)
                                                                                dgvPotenciales.CurrentRow.DataBoundItem;

            frmEvMisResultadosPotenciales form = new frmEvMisResultadosPotenciales();
            form.Linea = lineaSeleccionada;
            form.FormPadre = this;
            form.Estado = estado;
            Global.formPrincipal.abrirFormularioHijo(false, form);
            */
        }

        private void btnSeleccionarComp_Click(object sender, EventArgs e)
        {
            if (dgvCompetencias.CurrentCell == null)
            {
                MessageBox.Show("Debe seleccionar una competencia.",
                                   "Mensaje de error",
                                   MessageBoxButtons.OK,
                                   MessageBoxIcon.Error);
                return;
            }
            EvaluacionDesempenhoWS.lineaEvaluacion lineaSeleccionada = (EvaluacionDesempenhoWS.lineaEvaluacion)
                                                                                dgvCompetencias.CurrentRow.DataBoundItem;

            frmEvMisResultadosCompetencias form = new frmEvMisResultadosCompetencias();
            form.Linea = lineaSeleccionada;
            form.FormPadre = this;
            Global.formPrincipal.abrirFormularioHijo(false, form);

        }

        private void dgvCompetencias_CellFormatting(object sender, DataGridViewCellFormattingEventArgs e)
        {
            EvaluacionDesempenhoWS.lineaEvaluacion data = dgvCompetencias.Rows[e.RowIndex].DataBoundItem as EvaluacionDesempenhoWS.lineaEvaluacion;
            dgvCompetencias.Rows[e.RowIndex].Cells["ID"].Value = data.pesoCriterio.criterio.idCriterio;
            dgvCompetencias.Rows[e.RowIndex].Cells["nombre"].Value = data.pesoCriterio.criterio.nombre;
            dgvCompetencias.Rows[e.RowIndex].Cells["DescripcionComp"].Value = data.pesoCriterio.criterio.descripcion;
            dgvCompetencias.Rows[e.RowIndex].Cells["PesoComp"].Value = data.pesoCriterio.peso;

        }

        private void dgvPotenciales_CellFormatting(object sender, DataGridViewCellFormattingEventArgs e)
        {
            /*
            EvaluacionWS.lineaEvaluacion data = dgvPotenciales.Rows[e.RowIndex].DataBoundItem as EvaluacionWS.lineaEvaluacion;
            dgvCompetencias.Rows[e.RowIndex].Cells["ID"].Value = data.pesoCriterio.criterio.idCriterio;
            dgvCompetencias.Rows[e.RowIndex].Cells["nombre"].Value = data.pesoCriterio.criterio.nombre;
            dgvCompetencias.Rows[e.RowIndex].Cells["descripcionPot"].Value = data.pesoCriterio.criterio.descripcion;
            dgvCompetencias.Rows[e.RowIndex].Cells["pesoPot"].Value = data.pesoCriterio.peso;
            */
        }
    }
}
