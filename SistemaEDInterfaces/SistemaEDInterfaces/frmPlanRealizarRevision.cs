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

        private ObjetivoWS.ObjetivoWSClient daoObjetivo;
        private EvaluacionDesempenhoWS.EvaluacionDesempenhoWSClient daoEvaluacionDesempenho; 
        private EvaluacionDesempenhoWS.evaluacionDesempenho evaluacionDesempenho; 
        private ColaboradorWS.colaborador colaborador;
        private BindingList<ObjetivoWS.objetivo> objetivos; 
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
        private void iniciarEspera()
        {
            this.Cursor = Cursors.WaitCursor;
        }

        private void terminarEspera()
        {
            this.Cursor = Cursors.Default;
        }
        private int realizarValidacion()
        {
            int valido = 1;
            foreach(ObjetivoWS.objetivo o in objetivos)
            {
                if (o.estado == (int)EstadoObjetivo.EsperandoRevision)
                {
                    MessageBox.Show("Debe revisar todos los objetivos antes de enviar la revisión.",
                                   "Mensaje de error",
                                   MessageBoxButtons.OK,
                                   MessageBoxIcon.Error);
                    return 0;
                }
            }
            return valido;
        }
        private void btnEnviar_Click(object sender, EventArgs e)
        {
            
            iniciarEspera();
            if (realizarValidacion() == 0)
            {
                terminarEspera();
                return;
            }
            evaluacionDesempenho.estadoPlanificacion = (int)EstadoPlanificacion.OcultoParaJefe;
            if (daoEvaluacionDesempenho.actualizarEvaluacionDesempenho(evaluacionDesempenho) != 0)
            {
                //Enviar correo
                Correo.enviarCorreo("rodriguez.diego@pucp.edu.pe",
                                         Mensaje.TituloRevisionObjetivos(),
                                         Mensaje.CuerpoRevisionObjetivos("Jorge Baca"));
                //////////////////
                terminarEspera();
                MessageBox.Show("Validaciones enviadas a colaborador",
                                           "Mensaje de confirmacion",
                                           MessageBoxButtons.OK,
                                           MessageBoxIcon.Information);
                
                btnEnviar.Enabled = false; 
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
            objetivos 
                = new BindingList<ObjetivoWS.objetivo>
                (daoObjetivo.listarObjetivosXColaborador(colaborador.idColaborador).ToArray());
            if(objetivos!=null)dgvMisObjetivos.DataSource = objetivos; 
        }
    }
}
