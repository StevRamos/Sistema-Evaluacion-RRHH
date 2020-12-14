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
    public partial class frmEvMisTrabajadoresOpciones : Form
    {
        private ColaboradorWS.colaborador colaborador;
        private EvaluacionDesempenhoWS.EvaluacionDesempenhoWSClient daoEvaluacionDesempenho;
        private EvaluacionPotencialWS.EvaluacionPotencialWSClient daoEvaluacionPotencial;
        private EvaluacionDesempenhoWS.evaluacionDesempenho evaluacionDesempenho;
        private EvaluacionPotencialWS.evaluacion evaluacionPotencial; 
        private PeriodoWS.periodo periodo; 
        public colaborador Colaborador { get => colaborador; set => colaborador = value; }
        public PeriodoWS.periodo Periodo { get => periodo; set => periodo = value; }

        public frmEvMisTrabajadoresOpciones()
        {
            InitializeComponent();
            daoEvaluacionDesempenho = new EvaluacionDesempenhoWS.EvaluacionDesempenhoWSClient();
            daoEvaluacionPotencial = new EvaluacionPotencialWS.EvaluacionPotencialWSClient(); 
        }

        private void cargarDatosColaboradorEnPantalla()
        {
            txtIDColab.Text = colaborador.idColaborador.ToString();
            txtNombre.Text = colaborador.nombres + " " + colaborador.apellidos;
            txtCargo.Text = colaborador.puestoTrabajo.nombre;
            txtGerencia.Text = colaborador.gerencia.nombre;
            txtDNI.Text = colaborador.dni; 
        }

        private void cambiarLabelsEvaluacion()
        {
            

            switch (evaluacionDesempenho.estadoAutoEval)
            {
                case (int)EstadoAutoEval.NoIniciada:
                    lblEstadoAutoeval.Text = "No iniciada";
                    break;
                case (int)EstadoAutoEval.Iniciada:
                    lblEstadoAutoeval.Text = "Iniciada";
                    break;
                case (int)EstadoAutoEval.Finalizada:
                    lblEstadoAutoeval.Text = "Finalizada";
                    break;
            }


            switch (evaluacionDesempenho.estado)
            {
                case (int)EstadoEvD.PrevNoIniciada:
                    lblEstadoEvPrevia.Text = "No iniciada";
                    btnPrevia.Text = "Iniciar Evaluación";
                    break;
                case (int)EstadoEvD.PrevIniciada:
                    lblEstadoEvPrevia.Text = "Iniciada";
                    btnPrevia.Text = "Continuar Evaluación";
                    break;
                case (int)EstadoEvD.PrevFinalizada:
                    lblEstadoEvPrevia.Text = "Finalizada";
                    btnPrevia.Text = "Visualizar Resultados";
                    lblEstadoEvFinal.Text = "No Iniciada";
                    btnFinal.Text = "Iniciar Evaluación";
                    break;
                case (int)EstadoEvD.FinalIniciada:
                    lblEstadoEvPrevia.Text = "Finalizada";
                    btnPrevia.Text = "Visualizar Resultados";
                    lblEstadoEvFinal.Text = "Iniciada";
                    btnFinal.Text = "Continuar Evaluación";
                    break;
                case (int)EstadoEvD.FinalFinalizada:
                    lblEstadoEvPrevia.Text = "Finalizada";
                    btnPrevia.Text = "Visualizar Resultados";
                    lblEstadoEvFinal.Text = "Finalizada";
                    btnFinal.Text = "Visualizar Resultados";
                    break;
            }


            switch (evaluacionPotencial.estado)
            {
                case (int)EstadoEvalPot.NoIniciada:
                    lblEstadoEvPotencial.Text = "No iniciada";
                    btnPotencial.Text = "Iniciar Evaluación";
                    break;
                case (int)EstadoEvalPot.Iniciada:
                    lblEstadoEvPotencial.Text = "Iniciada";
                    btnPotencial.Text = "Continuar Evaluación";
                    break;
                case (int)EstadoEvalPot.Finalizada:
                    lblEstadoEvPotencial.Text = "Finalizada";
                    btnPotencial.Text = "Visualizar Resultados";
                    break;

            }
            
            if (evaluacionDesempenho.estadoAutoEval!= (int) EstadoAutoEval.Finalizada || ((int)evaluacionDesempenho.estado < (int)EstadoEvD.PrevFinalizada))
            {
                lblEstadoEvFinal.Text = "No disponible";
                lblEstadoEvPotencial.Text = "No disponible";
                btnFinal.Text = "Iniciar Evaluación";
                btnPotencial.Text = "Iniciar Evaluación";
                btnFinal.Enabled = false;
                btnPotencial.Enabled = false;
            }
        }
        private void btnRegresar_Click(object sender, EventArgs e)
        {
            Global.formPrincipal.cerrarFormularioHijo();
        }

        private void btnPrevia_Click(object sender, EventArgs e)
        {
            frmEvMisTrabajadoresPrevia form = new frmEvMisTrabajadoresPrevia();
            form.EvaluacionDesempenho = evaluacionDesempenho;
            form.Colaborador = colaborador;
            form.Periodo = periodo; 
            switch(evaluacionDesempenho.estado)
            {
                case (int)EstadoEvD.PrevNoIniciada:
                    form.Estado = EstadoFormulario.Editable;
                    break;
                case (int)EstadoEvD.PrevIniciada:
                    form.Estado = EstadoFormulario.Editable; 
                    break;
                default:
                    form.Estado = EstadoFormulario.NoEditable;
                    break; 
            }
            Global.formPrincipal.abrirFormularioHijo(true, form);
        }

        private void btnFinal_Click(object sender, EventArgs e)
        {
            frmEvMisTrabajadoresFinal form = new frmEvMisTrabajadoresFinal();
            form.EvaluacionDesempenho = evaluacionDesempenho;
            form.Colaborador = colaborador;
            form.Periodo = periodo;
            switch (evaluacionDesempenho.estado)
            {
                case (int)EstadoEvD.PrevFinalizada:
                    form.Estado = EstadoFormulario.Editable;
                    break;
                case (int)EstadoEvD.FinalIniciada:
                    form.Estado = EstadoFormulario.Editable;
                    break;
                default:
                    form.Estado = EstadoFormulario.NoEditable;
                    break;
            }
            Global.formPrincipal.abrirFormularioHijo(true, form);
        }

        private void btnPotencial_Click(object sender, EventArgs e)
        {
            frmEvMisTrabajadoresEvPotencial form = new frmEvMisTrabajadoresEvPotencial();
            form.Colaborador = colaborador;
            form.EvaluacionPotencial = evaluacionPotencial;
            form.Periodo = periodo;
            switch (evaluacionPotencial.estado)
            {
                case (int)EstadoEvalPot.NoIniciada:
                    form.Estado = EstadoFormulario.Editable; 
                    break;
                case (int)EstadoEvalPot.Iniciada:
                    form.Estado = EstadoFormulario.Editable; 
                    break;
                case (int)EstadoEvalPot.Finalizada:
                    form.Estado = EstadoFormulario.NoEditable;
                    break; 
            }
            Global.formPrincipal.abrirFormularioHijo(true, form);
        }

        private void frmEvMisTrabajadoresOpciones_Load(object sender, EventArgs e)
        {
            //Cargar datos de colaborador en pantalla 
            cargarDatosColaboradorEnPantalla(); 

            //Obtener Evaluaciones 
            evaluacionDesempenho = daoEvaluacionDesempenho.obtenerEvaluacionDesempenho(colaborador.idColaborador,
                                                                                       Periodo.idPeriodo);
            evaluacionPotencial = daoEvaluacionPotencial.obtenerEvaluacionPotencial(colaborador.idColaborador, Periodo.idPeriodo);

            //Cambiar labels y botones de evaluacion 
            cambiarLabelsEvaluacion(); 

           
        }
    }
}
