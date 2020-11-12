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
        private PuestoTrabajoWS.PuestoTrabajoWSClient daoPuestoTrabajo;
        private GerenciaWS.GerenciaWSClient daoGerencia; 
        public frmAdmGestPuestos()
        {
            InitializeComponent();
            daoPuestoTrabajo = new PuestoTrabajoWS.PuestoTrabajoWSClient();
            daoGerencia = new GerenciaWS.GerenciaWSClient();
            dgbCargos.DataSource = daoPuestoTrabajo.listarPuestoTrabajos("");

            cmbGestCargosNomGeren.DataSource = daoGerencia.listarGerencias();
            cmbGestCargosNomGeren.DisplayMember = "nombre";
            cmbGestCargosNomGeren.ValueMember = "idGerencia";
            dgbCargos.AutoGenerateColumns = false;

        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void btnGestCargoCargaMav_Click(object sender, EventArgs e)
        {
            Form formulario = new frmAdmGestCargoCargaMav();
            if (formulario.ShowDialog() == DialogResult.OK) {
                dgbCargos.DataSource = daoPuestoTrabajo.listarPuestoTrabajos("");
            }
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
                    PuestoTrabajoWS.puestoTrabajo puesto = (PuestoTrabajoWS.puestoTrabajo)dgbCargos.CurrentRow.DataBoundItem;
                    daoPuestoTrabajo.eliminarPuestoTrabajo(puesto.idPuestoTrabajo);
                    dgbCargos.DataSource = daoPuestoTrabajo.listarPuestoTrabajos("");
                }

            }
        }

        private void btnGestCargosBuscar_Click(object sender, EventArgs e)
        {
            GerenciaWS.gerencia gerencia;

            gerencia = (GerenciaWS.gerencia)cmbGestCargosNomGeren.SelectedItem;

            dgbCargos.DataSource = daoPuestoTrabajo.listarPuestoTrabajos(gerencia.nombre);
        }
    }
}
