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
            daoGerencia = new GerenciaWS.ObjetivoWSClient();
            dgvGerencias.DataSource = daoGerencia.listarGerencias();
            dgvGerencias.AutoGenerateColumns = false;
        }

        private void btnGestGerCargaMav_Click(object sender, EventArgs e)
        {
            Form formulario = new frmAdmGestGerenCargaMav();
            formulario.Show();
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
            if (result == DialogResult.OK) {
                foreach (DataGridViewRow row in dgvGerencias.SelectedRows)
                {
                    GerenciaWS.Gerencia gerencia = (GerenciaWS.Gerencia)dgvGerencias.CurrentRow.DataBoundItem;
                    gerencia.estado = 0;
                    daoGerencia.eliminarGerencia(gerencia);
                    dgvGerencias.Rows.RemoveAt(row.Index);
                }
            
            }
        }
    }
}
