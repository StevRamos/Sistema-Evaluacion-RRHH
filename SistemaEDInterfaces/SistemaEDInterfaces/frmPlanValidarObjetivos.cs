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
        /*
        private ColaboradorWS.ColaboradorWSClient daoColaborador;
        */
        private int idColaboradorLoggeado;

        public int IdColaboradorLoggeado { get => idColaboradorLoggeado; set => idColaboradorLoggeado = value; }
        
        public frmPlanValidarObjetivos()
        {
            //daoColaborador = new ColaboradorWS.ColaboradorWSClient();
            //dgvListaTrabajadores.DataSource = daoColaborador.listarColaboradoresPorIdJefe(IdColaboradorLoggeado); 
            InitializeComponent();
        }

        private void btnRealizarRevision_Click(object sender, EventArgs e)
        {

            frmPlanRealizarRevision form = new frmPlanRealizarRevision();
            //form.Colaborador = (ColaboradorWS.colaborador)dgvListaTrabajadores.CurrentRow.DataBoundItem; 
            Global.formPrincipal.abrirFormularioHijo(true, new frmPlanRealizarRevision()); 
        }
    }
}
