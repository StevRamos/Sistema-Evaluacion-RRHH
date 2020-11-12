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
    public partial class frmAdmGestCron : Form
    {
        private PeriodoWS.PeriodoWSClient daoPeriodo; 
        public frmAdmGestCron()
        {
            InitializeComponent();
            daoPeriodo = new PeriodoWS.PeriodoWSClient();
            dgvPeriodos.AutoGenerateColumns = false;
            dgvPeriodos.DataSource = daoPeriodo.listarPeriodos(); 
            
        }

        private void btnVerDetalle_Click(object sender, EventArgs e)
        {
            frmAdmGestCronVerDetalle form = new frmAdmGestCronVerDetalle();
            form.Periodo = (PeriodoWS.periodo)dgvPeriodos.CurrentRow.DataBoundItem;
            Global.formPrincipal.abrirFormularioHijo(true, form);
        }

        private void btnEliminar_Click(object sender, EventArgs e)
        {
            var result = MessageBox.Show("Se eliminaran todos los datos relacionados al periodo seleccionado.",
                                            "Mensaje de advertencia",
                                            MessageBoxButtons.OKCancel,
                                            MessageBoxIcon.Warning);
            if (result == DialogResult.OK)
            {
                foreach (DataGridViewRow row in dgvPeriodos.SelectedRows)
                {

                    PeriodoWS.periodo periodo = (PeriodoWS.periodo)dgvPeriodos.CurrentRow.DataBoundItem;
                    daoPeriodo.eliminar
                    dgvPeriodos.Rows.RemoveAt(row.Index);
                }

            }
        }

        public void agregarDatosDummyDGV()
        {
            int rowId1 = dgvPeriodos.Rows.Add();

            DataGridViewRow row1 = dgvPeriodos.Rows[rowId1];

            row1.Cells["ID"].Value = "1";
            row1.Cells["Nombre"].Value = "Periodo 2019-1";
            row1.Cells["FechaInicio"].Value = "01/01/2019";
            row1.Cells["FechaFin"].Value = "31/06/2019";
            row1.Cells["Estado"].Value = "Finalizado";

            int rowId2 = dgvPeriodos.Rows.Add();

            DataGridViewRow row2 = dgvPeriodos.Rows[rowId2];

            row2.Cells["ID"].Value = "2";
            row2.Cells["Nombre"].Value = "Periodo 2019-2";
            row2.Cells["FechaInicio"].Value = "01/07/2019";
            row2.Cells["FechaFin"].Value = "30/12/2019";
            row2.Cells["Estado"].Value = "Finalizado";

            int rowId3 = dgvPeriodos.Rows.Add();

            DataGridViewRow row3 = dgvPeriodos.Rows[rowId3];

            row3.Cells["ID"].Value = "3";
            row3.Cells["Nombre"].Value = "Periodo 2020";
            row3.Cells["FechaInicio"].Value = "01/01/2020";
            row3.Cells["FechaFin"].Value = "31/12/2020";
            row3.Cells["Estado"].Value = "En proceso";

        }
        private void frmAdmGestCron_Load(object sender, EventArgs e)
        {
            agregarDatosDummyDGV();
        }

        private void btnAgregar_Click(object sender, EventArgs e)
        {
            Global.formPrincipal.abrirFormularioHijo(true, new frmAdmGestCronAgregarPeriodo());
        }
    }
}
