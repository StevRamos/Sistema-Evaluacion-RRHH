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
    public partial class frmAdmGestPuestos : Form
    {
        private PuestoTrabajoWS.PuestoTrabajoWSWSClient daoPuestoTrabajo;
        private GerenciaWS.GerenciaWSClient daoGerencia; 
        public frmAdmGestPuestos()
        {
            InitializeComponent();
            daoPuestoTrabajo = new PuestoTrabajoWS.PuestoTrabajoWSWSClient();
            daoGerencia = new GerenciaWS.GerenciaWSClient(); 
            dgbCargos.DataSource = daoPuestoTrabajo.listarGerencias("");
            cmbGestCargosNomGeren.DataSource = daoGerencia.listarGerencias(); 
            dgbCargos.AutoGenerateColumns = false;
        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void btnGestCargoCargaMav_Click(object sender, EventArgs e)
        {
            Form formulario = new frmAdmGestCargoCargaMav();
            formulario.Show();
        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void btnGestPuestoEliminar_Click(object sender, EventArgs e)
        {
            var result = MessageBox.Show("Se eliminara el puesto de trabajo seleccionado.",
                                            "Mensaje de advertencia",
                                            MessageBoxButtons.OKCancel,
                                            MessageBoxIcon.Warning);
            if (result == DialogResult.OK)
            {
                foreach (DataGridViewRow row in dgbCargos.SelectedRows)
                {
                    PuestoTrabajoWS.PuestoTrabajo puesto = (PuestoTrabajoWS.PuestoTrabajo)dgvGerencias.CurrentRow.DataBoundItem;
                    puesto.estado = 0;
                    dgbCargos.eliminarPuestoTrabajo(puesto);
                    dgbCargos.Rows.RemoveAt(row.Index);
                }

            }
        }

        private void btnGestCargosBuscar_Click(object sender, EventArgs e)
        {
            GerenciaWS.gerencia gerencia;
            gerencia = (GerenciaWS.gerencia)cmbGestCargosNomGeren.SelectedItem;
            dgbCargos.DataSource = daoPuestoTrabajo.listarPuestosTrabajo(gerencia.nombre);
        }
    }
}
