using SistemaEDInterfaces.ColaboradorWS;
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
        private EvaluacionPotencialWS.EvaluacionPotencialWSClient daoEvaluacionPotencial; 
        private EvaluacionDesempenhoWS.evaluacionDesempenho evaluacionDesempenho;
        private EvaluacionPotencialWS.evaluacion evaluacionPotencial;
        private ColaboradorWS.colaborador colaborador;
        private PeriodoWS.periodo periodo; 
        private TipoEvaluacion tipoEval; 
        public TipoEvaluacion TipoEval { get => tipoEval; set => tipoEval = value; }
        public colaborador Colaborador { get => colaborador; set => colaborador = value; }
        public PeriodoWS.periodo Periodo { get => periodo; set => periodo = value; }

        public frmEvAutoevaluacionPantallaPrevia()
        {

            InitializeComponent();
            daoEvaluacionDesempenho = new EvaluacionDesempenhoWS.EvaluacionDesempenhoWSClient();
            daoEvaluacionPotencial = new EvaluacionPotencialWS.EvaluacionPotencialWSClient();
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

        private void frmEvAutoevaluacionPantallaPrevia_Load(object sender, EventArgs e)
        {
            if (tipoEval.Equals(TipoEvaluacion.Autoevaluacion))
            {
                evaluacionDesempenho = daoEvaluacionDesempenho.obtenerEvaluacionDesempenho(Colaborador.idColaborador, Periodo.idPeriodo);
                lblDescripcion.Text = "A continuación puede acceder a su autoevaluación del " + Periodo.nombre;
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
            else if (tipoEval.Equals(TipoEvaluacion.PreviaD))
            {
                evaluacionDesempenho = daoEvaluacionDesempenho.obtenerEvaluacionDesempenho(Colaborador.idColaborador, Periodo.idPeriodo);
                lblDescripcion.Text = "A continuación puede acceder a la evaluación previa de desempeño del colaborador "+
                    colaborador.nombres + " " + colaborador.apellidos +" del periodo "+ Periodo.nombre;

                switch (evaluacionDesempenho.estado)
                {
                    case (int)EstadoEvD.PrevNoIniciada:
                        lblEstadoNombre.Text = "No iniciada";
                        btnAccion.Text = "Iniciar Evaluación";
                        break;
                    case (int)EstadoEvD.PrevIniciada:
                        lblEstadoNombre.Text = "Iniciada";
                        btnAccion.Text = "Continuar Evaluación";
                        break;
                     default:
                        lblEstadoNombre.Text = "Finalizada";
                        btnAccion.Text = "Visualizar Resultados";
                        break;
                    
                }
            }
            else if (tipoEval.Equals(TipoEvaluacion.FinalD)) {
                evaluacionDesempenho = daoEvaluacionDesempenho.obtenerEvaluacionDesempenho(Colaborador.idColaborador, Periodo.idPeriodo);
                lblDescripcion.Text = "A continuación puede acceder a la evaluación final de desempeño del colaborador " +
                    colaborador.nombres + " " + colaborador.apellidos + " del periodo " + Periodo.nombre;

                switch (evaluacionDesempenho.estado)
                {
                    
                    case (int)EstadoEvD.FinalIniciada:
                        lblEstadoNombre.Text = "Iniciada";
                        btnAccion.Text = "Continuar Evaluación";
                        break;
                    case (int)EstadoEvD.FinalFinalizada:
                        lblEstadoNombre.Text = "Finalizada";
                        btnAccion.Text = "Visualizar Resultados";
                        break;
                    default:
                        lblEstadoNombre.Text = "No iniciada";
                        btnAccion.Text = "Iniciar Evaluación";
                        break;
                }
            }
            //Evaluacion de potencial 
            else
            {
                evaluacionPotencial = daoEvaluacionPotencial.obtenerEvaluacionPotencial(Colaborador.idColaborador, Periodo.idPeriodo); 
                lblDescripcion.Text = "A continuación puede acceder a la evaluación de potencial del colaborador " +
                    colaborador.nombres + " " + colaborador.apellidos + " del periodo " + Periodo.nombre;

                switch (evaluacionPotencial.estado)
                {
                    case (int)EstadoEvalPot.NoIniciada:
                        lblEstadoNombre.Text = "No iniciada";
                        btnAccion.Text = "Iniciar Evaluación";
                        break;
                    case (int)EstadoEvalPot.Iniciada:
                        lblEstadoNombre.Text = "Iniciada";
                        btnAccion.Text = "Continuar Evaluación";
                        break;
                    case (int)EstadoEvalPot.Finalizada:
                        lblEstadoNombre.Text = "Finalizada";
                        btnAccion.Text = "Visualizar Resultados";
                        break;
                    
                }
            }


            
        }
    }
}
