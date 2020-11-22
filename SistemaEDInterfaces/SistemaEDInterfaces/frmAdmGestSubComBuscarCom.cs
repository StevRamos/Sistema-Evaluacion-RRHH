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
    public partial class frmAdmGestSubComBuscarCom : Form
    {
        //CriterioWS.CriterioWSClient daoCriterio; 
        //CriterioWS.criterio competencia;
        //public CriterioWS.criterio Competencia { get => competencia; set => competencia = value; }
        public frmAdmGestSubComBuscarCom()
        {
            InitializeComponent();
            //daoCriterio = new CriterioWS.CriterioWSClient();
            dgvCompetencias.AutoGenerateColumns = false; 
        }

        private void label5_Click(object sender, EventArgs e)
        {

        }

        private void btnBuscar_Click(object sender, EventArgs e)
        {
            //dgvCompetencias.DataSource = daoCriterio.listarCriterios((int)TipoCriterio.Competencia, txtNombreComp.Text); 
        }

        private void btnSeleccionar_Click(object sender, EventArgs e)
        {
            //competencia = (CriterioWS.criterio)dgvCompetencias.CurrentRow.DataBoundItem;
            this.DialogResult = DialogResult.OK;
            this.Close();
        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }
    }
}
