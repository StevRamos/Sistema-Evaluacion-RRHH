using SistemaEDInterfaces.CriterioWS;
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
    public partial class frmAdmGestSubPotBuscarPot : Form
    {
        CriterioWS.CriterioWSClient daoCriterio;
        CriterioWS.criterio potencial;

        public criterio Potencial { get => potencial; set => potencial = value; }

        public frmAdmGestSubPotBuscarPot()
        {
            InitializeComponent();
            daoCriterio = new CriterioWS.CriterioWSClient();
            dgvPotenciales.AutoGenerateColumns = false;
            dgvPotenciales.DataSource = daoCriterio.listar((int)TipoCriterio.Competencia, txtNombrePotencial.Text);
        }

        private void btnSeleccionar_Click(object sender, EventArgs e)
        {
            if (dgvPotenciales.CurrentCell == null)
            {
                MessageBox.Show("Debe seleccionar una competencia.",
                                   "Mensaje de error",
                                   MessageBoxButtons.OK,
                                   MessageBoxIcon.Error);
                return;
            }
            potencial = (CriterioWS.criterio)dgvPotenciales.CurrentRow.DataBoundItem;
            this.DialogResult = DialogResult.OK;
            this.Close();
        }

        private void btnBuscar_Click(object sender, EventArgs e)
        {
            dgvPotenciales.DataSource = daoCriterio.listar((int)TipoCriterio.Competencia, txtNombrePotencial.Text);
        }
    }
}
