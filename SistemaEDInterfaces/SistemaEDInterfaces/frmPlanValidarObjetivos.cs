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
        
        private ColaboradorWS.ColaboradorWSClient daoColaborador;
        
        private int idColaboradorLoggeado=1;

        public int IdColaboradorLoggeado { get => idColaboradorLoggeado; set => idColaboradorLoggeado = value; }
        
        public frmPlanValidarObjetivos()
        {
            InitializeComponent();
            daoColaborador = new ColaboradorWS.ColaboradorWSClient();
            dgvListaTrabajadores.DataSource = daoColaborador.listarColaboradoresXJefe(IdColaboradorLoggeado); 
            
        }

        private void btnRealizarRevision_Click(object sender, EventArgs e)
        {

            frmPlanRealizarRevision form = new frmPlanRealizarRevision();
            form.Colaborador = (ColaboradorWS.colaborador)dgvListaTrabajadores.CurrentRow.DataBoundItem; 
            Global.formPrincipal.abrirFormularioHijo(true, new frmPlanRealizarRevision()); 
        }
    }
}
