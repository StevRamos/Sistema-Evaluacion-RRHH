using SistemaEDInterfaces.EvaluacionDesempenhoWS;
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
    public partial class frmPlanRealizarRevision : Form
    {
        private EvaluacionDesempenhoWS.EvaluacionDesempenhoWSClient daoEvaluacionDesempenho; 
        private EvaluacionDesempenhoWS.evaluacionDesempenho evaluacionDesempenho; 

        private ColaboradorWS.colaborador colaborador;

        private ObjetivoWS.ObjetivoWSClient daoObjetivo;
        public ColaboradorWS.colaborador Colaborador { get => colaborador; set => colaborador = value; }
        public evaluacionDesempenho EvaluacionDesempenho { get => evaluacionDesempenho; set => evaluacionDesempenho = value; }

        public frmPlanRealizarRevision()
        {
            daoEvaluacionDesempenho = new EvaluacionDesempenhoWSClient(); 
            evaluacionDesempenho = new evaluacionDesempenho();
            colaborador = new ColaboradorWS.colaborador();
            daoObjetivo = new ObjetivoWS.ObjetivoWSClient();
            
            
            InitializeComponent();
        }

        private void btnEnviar_Click(object sender, EventArgs e)
        {

            evaluacionDesempenho.estadoPlanificacion = (int)EstadoPlanificacion.OcultoParaJefe;
            if (daoEvaluacionDesempenho.actualizarEvaluacionDesempenho(evaluacionDesempenho) != 0)
            {
                //Enviar correo

                //////////////////
                MessageBox.Show("Validaciones enviadas a colaborador",
                                           "Mensaje de confirmacion",
                                           MessageBoxButtons.OK,
                                           MessageBoxIcon.Information);

            }
            else
            {
                evaluacionDesempenho.estadoPlanificacion = (int) EstadoPlanificacion.OcultoParaColaborador;
                MessageBox.Show("Ocurrio un error al enviar validaciones.",
                                           "Mensaje de error",
                                           MessageBoxButtons.OK,
                                           MessageBoxIcon.Error);
            }
            
            
            

            Global.formPrincipal.abrirFormularioHijo(true,new frmPlanValidarObjetivos());
        }

        private void btnVerDetalle_Click(object sender, EventArgs e)
        {
            if(dgvMisObjetivos.CurrentCell == null)
            {
                MessageBox.Show("Debe seleccionar un objetivo.",
                                   "Mensaje de error",
                                   MessageBoxButtons.OK,
                                   MessageBoxIcon.Error);
                return;
            }
            frmPlanVerDetalle form = new frmPlanVerDetalle();
            form.Colaborador = Colaborador;
            form.Objetivo = (ObjetivoWS.objetivo)dgvMisObjetivos.CurrentRow.DataBoundItem;
            form.EvaluacionDesempenho = evaluacionDesempenho;
            Global.formPrincipal.abrirFormularioHijo(true,form);

        }

        private void btnRegresar_Click(object sender, EventArgs e)
        {
            var result = MessageBox.Show("¿Desea regresar? Validaciones no seran enviadas.",
                                           "Mensaje de pregunta",
                                           MessageBoxButtons.YesNo,
                                           MessageBoxIcon.Question);
            if (result == DialogResult.Yes)
            {
                Global.formPrincipal.abrirFormularioHijo(true, new frmPlanValidarObjetivos()); 
            }
            
        }

        private void frmPlanRealizarRevision_Load(object sender, EventArgs e)
        {
            
            txtIDColab.Text = colaborador.idColaborador.ToString();
            txtNombreColab.Text = colaborador.nombres;
            txtDNI.Text = colaborador.dni.ToString();
            txtGerencia.Text = colaborador.gerencia.nombre;
            txtCargo.Text = colaborador.puestoTrabajo.nombre;
            
            dgvMisObjetivos.AutoGenerateColumns = false;
            dgvMisObjetivos.DataSource = new BindingList<ObjetivoWS.objetivo>
                (daoObjetivo.listarObjetivosXColaborador(colaborador.idColaborador).ToArray());

        }
    }
}
