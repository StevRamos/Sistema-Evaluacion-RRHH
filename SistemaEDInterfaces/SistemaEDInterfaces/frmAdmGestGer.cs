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
    public partial class frmAdmGestGer : Form
    {
        private GerenciaWS.GerenciaWSClient daoGerencia;

        public frmAdmGestGer()
        {
            InitializeComponent();
            daoGerencia = new GerenciaWS.GerenciaWSClient();
            dgvGerencias.AutoGenerateColumns = false;
            dgvGerencias.DataSource = daoGerencia.listarGerencias();
        }

        private void btnGestGerCargaMav_Click(object sender, EventArgs e)
        {
            Form formulario = new frmAdmGestGerenCargaMav();
            if (formulario.ShowDialog() == DialogResult.OK)
            {
                dgvGerencias.DataSource = daoGerencia.listarGerencias();
            }
        }

        private void frmAdmGestGer_Load(object sender, EventArgs e)
        {

        }

        private void btnGestGerEliminar_Click(object sender, EventArgs e)
        {
            var result = MessageBox.Show("Se eliminara la gerencia seleccionada.",
                                            "Mensaje de advertencia",
                                            MessageBoxButtons.OKCancel,
                                            MessageBoxIcon.Warning);
            if (result == DialogResult.OK)
            {
                foreach (DataGridViewRow row in dgvGerencias.SelectedRows)
                {
                    GerenciaWS.gerencia gerencia = (GerenciaWS.gerencia)dgvGerencias.CurrentRow.DataBoundItem;
                    daoGerencia.eliminarGerencia(gerencia.idGerencia);
                    dgvGerencias.DataSource = daoGerencia.listarGerencias();
                }
            }
        }

        private void dgvGerencias_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }
    }
}
