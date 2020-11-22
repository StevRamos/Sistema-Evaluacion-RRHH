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
            BindingList<String> nombresGerencias = new BindingList<string>();
            daoPuestoTrabajo = new PuestoTrabajoWS.PuestoTrabajoWSClient();
            daoGerencia = new GerenciaWS.GerenciaWSClient();
            dgbCargos.DataSource = daoPuestoTrabajo.listarPuestoTrabajos("");

            BindingList<GerenciaWS.gerencia> gerencias = new BindingList<GerenciaWS.gerencia>
                                                  (daoGerencia.listarGerencias().ToArray());
            cargarNombres(gerencias,nombresGerencias);
            cmbGestCargosNomGeren.DataSource = nombresGerencias;
            dgbCargos.AutoGenerateColumns = false;
            /*
            cmbGestCargosNomGeren.DataSource = daoGerencia.listarGerencias();
            cmbGestCargosNomGeren.DisplayMember = "nombre";
            cmbGestCargosNomGeren.ValueMember = "idGerencia";
            
            */
        }
        private void cargarNombres(BindingList<GerenciaWS.gerencia> gerencias, BindingList<String> nombresGerencias)
        {
            //Opcion nula 
            nombresGerencias.Add("-");
            //Nombres de gerencia
            foreach (GerenciaWS.gerencia g in gerencias)
            {
                nombresGerencias.Add(g.nombre);
            }
        }

        private void iniciarEspera()
        {
            this.Cursor = Cursors.WaitCursor;
        }

        private void terminarEspera()
        {
            this.Cursor = Cursors.Default;
        }
        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void btnGestCargoCargaMav_Click(object sender, EventArgs e)
        {
            Form formulario = new frmAdmGestCargoCargaMav();
            if (formulario.ShowDialog() == DialogResult.OK)
            {
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
                iniciarEspera();

                PuestoTrabajoWS.puestoTrabajo puesto = (PuestoTrabajoWS.puestoTrabajo)dgbCargos.CurrentRow.DataBoundItem;
                daoPuestoTrabajo.eliminarPuestoTrabajo(puesto.idPuestoTrabajo);
                dgbCargos.DataSource = daoPuestoTrabajo.listarPuestoTrabajos("");

                terminarEspera(); 
            }
        }

        private void btnGestCargosBuscar_Click(object sender, EventArgs e)
        {
            /*
            GerenciaWS.gerencia gerencia;

            gerencia = (GerenciaWS.gerencia)cmbGestCargosNomGeren.SelectedItem;

            dgbCargos.DataSource = daoPuestoTrabajo.listarPuestoTrabajos(gerencia.nombre);
            */
            iniciarEspera();
            String nombreGerSeleccionada;
            nombreGerSeleccionada = (String)cmbGestCargosNomGeren.SelectedItem;
            if (nombreGerSeleccionada == "-")
            {
                dgbCargos.DataSource = daoPuestoTrabajo.listarPuestoTrabajos("");
            }
            else
            {
                dgbCargos.DataSource = daoPuestoTrabajo.listarPuestoTrabajos(nombreGerSeleccionada);
            }
            terminarEspera();
        }
    }
}
