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
        /*
        private ColaboradorWS.colaborador colaborador;

        private ObjetivoWS.ObjetivoWSClient daoObjetivo;
        public ColaboradorWS.colaborador Colaborador { get => colaborador; set => colaborador = value; }
        */
        public frmPlanRealizarRevision()
        {

            //colaborador = new ColaboradorWS.colaborador();
            //daoObjetivo = new ObjetivoWS.ObjetivoWSClient();
            dgvMisObjetivos.AutoGenerateColumns = false;
            InitializeComponent();
        }

        private void btnEnviar_Click(object sender, EventArgs e)
        {
            /*
            ObjetivoWS.objetivo objetivo;
            foreach (DataGridViewRow row in dgvMisObjetivos.Rows)
            {
                objetivo = (ObjetivoWS.objetivo)row.DataBoundItem;
                if(objetivo.estado == EstadoObjetivo.AprobOculto)objetivo.estado = EstadoObjetivo.AprobVisible;
                if (objetivo.estado == EstadoObjetivo.DenOculto) objetivo.estado = EstadoObjetivo.DenVisible;

                daoObjetivo.actualizarObjetivo(objetivo);
            }
            */
            MessageBox.Show("Validaciones enviadas a colaborador",
                                           "Mensaje de confirmacion",
                                           MessageBoxButtons.OK,
                                           MessageBoxIcon.Information);

            Global.formPrincipal.abrirFormularioHijo(true,new frmPlanValidarObjetivos());
        }

        private void btnVerDetalle_Click(object sender, EventArgs e)
        {
            frmPlanVerDetalle form = new frmPlanVerDetalle();
            /*
            form.Colaborador = Colaborador;
            form.Objetivo = (ObjetivoWS.objetivo)dgvMisObjetivos.CurrentRow.DataBoundItem; 
            */
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
            /*
            txtIDColab.Text = colaborador.idColaborador;
            txtNombreColab.Text = colaborador.nombres;
            txtDNI.Text = colaborador.dni.ToString();
            txtGerencia.Text = colaborador.gerencia.nombre;
            txtCargo.Text = colaborador.puestoTrabajo.nombre;

            dgvMisObjetivos.DataSource = daoObjetivo.listarObjetivosPorIdColab(colaborador.idColaborador);
            */
        }
    }
}
