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
    public partial class frmPlanValidarObjetivos : Form
    {
        private ColaboradorWS.colaborador colaboradorSeleccionado; 
        private ColaboradorWS.ColaboradorWSClient daoColaborador;
        private BindingList<ObjetivoWS.objetivo> objetivos; 
        private int idColaboradorLoggeado=1;

        private EvaluacionDesempenhoWS.EvaluacionDesempenhoWSClient daoEvaluacionDesempenho; 
        public int IdColaboradorLoggeado { get => idColaboradorLoggeado; set => idColaboradorLoggeado = value; }
        
        public frmPlanValidarObjetivos()
        {
            InitializeComponent();
            daoEvaluacionDesempenho = new EvaluacionDesempenhoWS.EvaluacionDesempenhoWSClient(); 
            daoColaborador = new ColaboradorWS.ColaboradorWSClient();
            dgvListaTrabajadores.AutoGenerateColumns = false;
            BindingList < ColaboradorWS.colaborador > colaboradores
                = new BindingList<ColaboradorWS.colaborador>
                (daoColaborador.listarColaboradoresXJefe(IdColaboradorLoggeado).ToArray());
            if(colaboradores!=null)dgvListaTrabajadores.DataSource = colaboradores; 
        }

        private void iniciarEspera()
        {
            this.Cursor = Cursors.WaitCursor;
        }

        private void terminarEspera()
        {
            this.Cursor = Cursors.Default;
        }

        private void btnRealizarRevision_Click(object sender, EventArgs e)
        {

            iniciarEspera();

            if (dgvListaTrabajadores.CurrentCell == null)
            {
                MessageBox.Show("Debe seleccionar un objetivo.",
                                      "Mensaje de error",
                                      MessageBoxButtons.OK,
                                      MessageBoxIcon.Error);
                return;

            }
            colaboradorSeleccionado = (ColaboradorWS.colaborador)dgvListaTrabajadores.CurrentRow.DataBoundItem;

            BindingList <EvaluacionDesempenhoWS.evaluacionDesempenho> evaluaciones;
            EvaluacionDesempenhoWS.evaluacionDesempenho evaluacionDesempenho;
            evaluaciones = new BindingList<EvaluacionDesempenhoWS.evaluacionDesempenho>
                (daoEvaluacionDesempenho.listarDesempenhoPorPeriodo(colaboradorSeleccionado.idColaborador,
                                                                    Global.periodoActual.idPeriodo).ToArray());
            evaluacionDesempenho = evaluaciones.ElementAt(0);
            terminarEspera();

            //Verificar si se puede realizar la revision de objetivos para el colaborador seleccionado 
            if (evaluacionDesempenho.estadoPlanificacion == (int)EstadoPlanificacion.OcultoParaJefe)
            {
               MessageBox.Show("El colaborador aún no envia sus objetivos para revision",
                        "Mensaje de error",
                        MessageBoxButtons.OK,
                        MessageBoxIcon.Error);
                return; 
            }
            frmPlanRealizarRevision form = new frmPlanRealizarRevision();
            form.Colaborador = colaboradorSeleccionado;
            form.EvaluacionDesempenho = evaluacionDesempenho; 
            Global.formPrincipal.abrirFormularioHijo(false, form); 
        }

        private void frmPlanValidarObjetivos_Load(object sender, EventArgs e)
        {
            //Verificar si se encuentra en las fechas para la planificacion de objetivos
        }
    }
}
