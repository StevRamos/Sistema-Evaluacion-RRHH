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
    public partial class frmAdmGestCronVerDetalle : Form
    {
        public frmAdmGestCronVerDetalle()
        {
            InitializeComponent();
        }

        private void btnGuardar_Click(object sender, EventArgs e)
        {
            MessageBox.Show("Se guardaron los cambios.",
                "Mensaje de confirmacion",
                MessageBoxButtons.OK,
                MessageBoxIcon.Information);

            Global.formPrincipal.abrirFormularioHijo(true, new frmAdmGestCron());
        }

        private void btnRegresar_Click(object sender, EventArgs e)
        {
            var result = MessageBox.Show("Datos no guardados se perderan. Retroceder de todos modos?",
                                            "Mensaje de advertencia",
                                            MessageBoxButtons.YesNo,
                                            MessageBoxIcon.Warning);
            if (result == DialogResult.Yes)
                Global.formPrincipal.abrirFormularioHijo(true, new frmAdmGestCron());
        }

        private void lblGhost_Click(object sender, EventArgs e)
        {

        }

        private void llenarDatosDummy()
        {
            txtID.Text = "3";
            txtNombre.Text = "Periodo 2020";
            txtEstado.Text = "En proceso";
            dtpFechaInicio.Value = new DateTime(2020,01,01);
            dtpFechaFin.Value = new DateTime(2020,12,30);
            txtPesoDesempenho.Text = "50";
            txtPesoPotencial.Text = "50";

            txtDia.Text = "Lunes";
            txtHora.Text = "07:00";

            //// Planificacion 
            int rowId1 = dgvPlanificacion.Rows.Add();

            DataGridViewRow row11 = dgvPlanificacion.Rows[rowId1];

            row11.Cells["ID"].Value = "1";
            row11.Cells["Nombre"].Value = "Gerencia de Finanzas";
            row11.Cells["FechaInicio"].Value = "20/01/2020";
            row11.Cells["FechaFin"].Value = "15/02/2020";

            int rowId2 = dgvPlanificacion.Rows.Add();

            DataGridViewRow row12 = dgvPlanificacion.Rows[rowId2];

            row12.Cells["ID"].Value = "2";
            row12.Cells["Nombre"].Value = "Gerencia de Comercialización";
            row12.Cells["FechaInicio"].Value = "26/01/2020";
            row12.Cells["FechaFin"].Value = "15/03/2020";

            int rowId3 = dgvPlanificacion.Rows.Add();

            DataGridViewRow row13 = dgvPlanificacion.Rows[rowId3];

            row13.Cells["ID"].Value = "3";
            row13.Cells["Nombre"].Value = "Gerencia de Producción";
            row13.Cells["FechaInicio"].Value = "15/02/2020";
            row13.Cells["FechaFin"].Value = "10/04/2020";

            //Evaluacion 

            //int rowId1 = dgvEvaluaciones.Rows.Add();

            //DataGridViewRow row21 = dgvEvaluaciones.Rows[rowId1];

            //row21.Cells["IDEv"].Value = "1";
            //row21.Cells["Nombre"].Value = "Gerencia de Finanzas";
            //row21.Cells["FechaInicio"].Value = "15/10/2020";
            //row21.Cells["FechaFin"].Value = "31/11/2020";

            //int rowId2 = dgvEvaluaciones.Rows.Add();

            //DataGridViewRow row22 = dgvEvaluaciones.Rows[rowId2];

            //row22.Cells["IDEv"].Value = "2";
            //row22.Cells["Nombre"].Value = "Gerencia de Comercialización";
            //row22.Cells["FechaInicio"].Value = "30/10/2020";
            //row22.Cells["FechaFin"].Value = "10/12/2020";

            //int rowId3 = dgvEvaluaciones.Rows.Add();

            //DataGridViewRow row23 = dgvEvaluaciones.Rows[rowId3];

            //row23.Cells["ID"].Value = "3";
            //row23.Cells["Nombre"].Value = "Gerencia de Producción";
            //row23.Cells["FechaInicio"].Value = "31/11/2020";
            //row23.Cells["FechaFin"].Value = "10/12/2020";

            ////PDI 

            //rowId1 = dgvPDI.Rows.Add();

            //DataGridViewRow row31 = dgvPDI.Rows[rowId1];

            //row31.Cells["ID"].Value = "1";
            //row31.Cells["Nombre"].Value = "Gerencia de Finanzas";
            //row31.Cells["FechaInicio"].Value = "15/12/2020";
            //row31.Cells["FechaFin"].Value = "20/12/2020";

            //rowId2 = dgvPDI.Rows.Add();

            //DataGridViewRow row32 = dgvPDI.Rows[rowId2];

            //row32.Cells["ID"].Value = "2";
            //row32.Cells["Nombre"].Value = "Gerencia de Comercialización";
            //row32.Cells["FechaInicio"].Value = "15/12/2020";
            //row32.Cells["FechaFin"].Value = "20/12/2020";

            //rowId3 = dgvPDI.Rows.Add();

            //DataGridViewRow row33 = dgvPDI.Rows[rowId3];

            //row33.Cells["ID"].Value = "3";
            //row33.Cells["Nombre"].Value = "Gerencia de Producción";
            //row33.Cells["FechaInicio"].Value = "15/12/2020";
            //row33.Cells["FechaFin"].Value = "20/12/2020";

        }
        private void frmAdmGestCronVerDetalle_Load(object sender, EventArgs e)
        {
            llenarDatosDummy();
            
        }
    }
}
