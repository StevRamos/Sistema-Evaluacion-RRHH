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
    public partial class frmEvAutoevaluacionPantallaPrevia : Form
    {
        private EvaluacionDesempenhoWS.EvaluacionDesempenhoWSClient daoEvaluacionDesempenho;
        private EvaluacionDesempenhoWS.evaluacionDesempenho evaluacionDesempenho;
        private int idColaborador;
        private int idPeriodo;

        public int IdColaborador { get => idColaborador; set => idColaborador = value; }
        public int IdPeriodo { get => idPeriodo; set => idPeriodo = value; }

        public frmEvAutoevaluacionPantallaPrevia()
        {

            InitializeComponent();
            daoEvaluacionDesempenho = new EvaluacionDesempenhoWS.EvaluacionDesempenhoWSClient();
            idColaborador = Global.colaboradorLoggeado.idColaborador;
            idPeriodo = Global.periodoActual.idPeriodo; 
            evaluacionDesempenho = daoEvaluacionDesempenho.obtenerEvaluacionDesempenho(idColaborador, idPeriodo);
            lblDescripcion.Text = "A continuación puede acceder a su autoevaluación del " + Global.periodoActual.nombre;
            switch (evaluacionDesempenho.estadoAutoEval)
            {
                case (int)EstadoAutoEval.NoIniciada:
                    lblEstadoNombre.Text = "No iniciada";
                    btnAccion.Text = "Iniciar Evaluación"; 
                    break;
                case (int)EstadoAutoEval.Iniciada:  
                    lblEstadoNombre.Text = "Iniciada";
                    btnAccion.Text = "Continuar Evaluación"; 
                    break;
                case (int)EstadoAutoEval.Finalizada:
                    lblEstadoNombre.Text = "Finalizada";
                    btnAccion.Text = "Visualizar Resultados"; 
                    break;
            }
        }

        private void btnAccion_Click(object sender, EventArgs e)
        {
            frmEvAutoevaluacion form = new frmEvAutoevaluacion();
            switch (evaluacionDesempenho.estadoAutoEval)
            {
                case (int)EstadoAutoEval.NoIniciada:
                    form.Estado = EstadoFormulario.Editable; 
                    break;
                case (int)EstadoAutoEval.Iniciada:
                    form.Estado = EstadoFormulario.Editable;
                    break;
                case (int)EstadoAutoEval.Finalizada:
                    form.Estado = EstadoFormulario.NoEditable;
                    break;
            }
            Global.formPrincipal.abrirFormularioHijo(true, form);
        }
    }
}
