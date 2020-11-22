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
    public partial class frmHisMisEvaluaciones : Form
    {
        public frmHisMisEvaluaciones()
        {
            InitializeComponent();
        }

        private void btnSeleccionar_Click(object sender, EventArgs e)
        {
            Global.formPrincipal.abrirFormularioHijo(false, new frmHisMisEvaluacionesResultado());
        }
        public void agregarDatosDummyDGV()
        {
            int rowId1 = dgvPeriodos.Rows.Add();

            DataGridViewRow row1 = dgvPeriodos.Rows[rowId1];

            row1.Cells["ID"].Value = "1";
            row1.Cells["Nombre"].Value = "Periodo 2019-1";
            row1.Cells["FechaInicio"].Value = "01/01/2019";
            row1.Cells["FechaFin"].Value = "31/06/2019";
            
            int rowId2 = dgvPeriodos.Rows.Add();

            DataGridViewRow row2 = dgvPeriodos.Rows[rowId2];

            row2.Cells["ID"].Value = "2";
            row2.Cells["Nombre"].Value = "Periodo 2019-2";
            row2.Cells["FechaInicio"].Value = "01/07/2019";
            row2.Cells["FechaFin"].Value = "30/12/2019";
            
            int rowId3 = dgvPeriodos.Rows.Add();

            DataGridViewRow row3 = dgvPeriodos.Rows[rowId3];

            row3.Cells["ID"].Value = "3";
            row3.Cells["Nombre"].Value = "Periodo 2020-1";
            row3.Cells["FechaInicio"].Value = "01/01/2020";
            row3.Cells["FechaFin"].Value = "31/06/2020";
            

        }
        private void frmHisMisEvaluaciones_Load(object sender, EventArgs e)
        {
            agregarDatosDummyDGV();
        }
    }
}
