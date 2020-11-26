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
    public partial class frmAdmGestPot : Form
    {
        private PesoCriterioWS.PesoCriterioWSClient daoPesoCriterio;
        private PeriodoWS.PeriodoWSClient daoPeriodo;
        private PuestoTrabajoWS.PuestoTrabajoWSClient daoPuestoTrabajo;
        public frmAdmGestPot()
        {
            InitializeComponent();
            daoPesoCriterio = new PesoCriterioWS.PesoCriterioWSClient();
            daoPeriodo = new PeriodoWS.PeriodoWSClient();
            daoPuestoTrabajo = new PuestoTrabajoWS.PuestoTrabajoWSClient();
            dgvGestPot.AutoGenerateColumns = false;
            PesoCriterioWS.pesoCriterio[] lista = daoPesoCriterio.listarPesosCriterios((int)TipoCriterio.Potencial, "", "", "");
            dgvGestPot.DataSource = lista;

            BindingList<PeriodoWS.periodo> periodos = new BindingList<PeriodoWS.periodo>
                                                    ((daoPeriodo.listarPeriodos() ?? new PeriodoWS.periodo[0]).ToArray());
            BindingList<PuestoTrabajoWS.puestoTrabajo> puestos = new BindingList<PuestoTrabajoWS.puestoTrabajo>
                                         ((daoPuestoTrabajo.listarPuestoTrabajos("") ?? new PuestoTrabajoWS.puestoTrabajo[0]).ToArray());

            BindingList<String> nombresPuestos = new BindingList<string>();
            BindingList<String> nombresPeriodos = new BindingList<string>();

            cargarNombres(periodos, puestos, nombresPeriodos, nombresPuestos);

            cmbPuestos.DataSource = nombresPuestos;
            cmbPeriodo.DataSource = nombresPeriodos;
        }

        private void cargarNombres(BindingList<PeriodoWS.periodo> periodos, BindingList<PuestoTrabajoWS.puestoTrabajo> puestos,
                                  BindingList<String> nombresPeriodos, BindingList<String> nombresPuestos)
        {
            nombresPeriodos.Add("-");
            nombresPuestos.Add("-");

            foreach (PeriodoWS.periodo p in periodos)
            {
                nombresPeriodos.Add(p.nombre);
            }
            foreach (PuestoTrabajoWS.puestoTrabajo pt in puestos)
            {
                nombresPuestos.Add(pt.nombre);
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

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void btnCrearPotencial_Click(object sender, EventArgs e)
        {
            Global.formPrincipal.abrirFormularioHijo(false, new frmAdmGestPotAdd());
        }

        private void btnCargarMasivaPot_Click(object sender, EventArgs e)
        {
            Form formulario = new frmAdmGestPotCrgMav();
            formulario.Show();
        }

        private void btnBuscar_Click(object sender, EventArgs e)
        {
            iniciarEspera();
            String nombreCargoSeleccionado, nombrePeriodoSeleccionado, nombreCompetencia;
            nombreCompetencia = txtGestNombrePot.Text;
            nombreCargoSeleccionado = (String)cmbPuestos.SelectedItem;
            nombrePeriodoSeleccionado = (String)cmbPeriodo.SelectedItem;
            if (nombreCargoSeleccionado == "-") nombreCargoSeleccionado = "";
            if (nombrePeriodoSeleccionado == "-") nombrePeriodoSeleccionado = "";
            dgvGestPot.DataSource = daoPesoCriterio.listarPesosCriterios((int)TipoCriterio.Competencia,
                                                                            nombreCargoSeleccionado,
                                                                            nombrePeriodoSeleccionado,
                                                                            nombreCompetencia);
            terminarEspera();
        }

        private void btnEliminar_Click(object sender, EventArgs e)
        {
            if (dgvGestPot.CurrentCell == null)
            {
                MessageBox.Show("Debe seleccionar un potencial.",
                                   "Mensaje de error",
                                   MessageBoxButtons.OK,
                                   MessageBoxIcon.Error);
                return;
            }

            var result = MessageBox.Show("¿Esta seguro que desea eliminar el potencial seleccionado?",
                                            "Mensaje de advertencia",
                                            MessageBoxButtons.YesNo,
                                            MessageBoxIcon.Warning);

            if (result == DialogResult.Yes)
            {
                iniciarEspera();

                PesoCriterioWS.pesoCriterio pesoCriterio;
                pesoCriterio = (PesoCriterioWS.pesoCriterio)dgvGestPot.CurrentRow.DataBoundItem;
                if (daoPesoCriterio.eliminarPesoCriterio(pesoCriterio) != 0)
                {
                    terminarEspera();
                    MessageBox.Show("Se elimino el potencial seleccionado.",
                                "Mensaje de confirmacion",
                                MessageBoxButtons.OK,
                                MessageBoxIcon.Information);
                    btnBuscar_Click(sender, e);
                }
                else
                {
                    terminarEspera();
                    MessageBox.Show("Ocurrió un error al eliminar el potencial, intentelo nuevamente.",
                                "Mensaje de error",
                                MessageBoxButtons.OK,
                                MessageBoxIcon.Error);
                }


            }
        }

        private void dgvGestPot_CellFormatting(object sender, DataGridViewCellFormattingEventArgs e)
        {
            PesoCriterioWS.pesoCriterio data = dgvGestPot.Rows[e.RowIndex].DataBoundItem as PesoCriterioWS.pesoCriterio;

            dgvGestPot.Rows[e.RowIndex].Cells[0].Value = data.criterio.idCriterio;
            dgvGestPot.Rows[e.RowIndex].Cells[1].Value = data.criterio.nombre;
            dgvGestPot.Rows[e.RowIndex].Cells[2].Value = data.criterio.descripcion;
            dgvGestPot.Rows[e.RowIndex].Cells[3].Value = data.puestoTrabajo.nombre;
            dgvGestPot.Rows[e.RowIndex].Cells[5].Value = data.periodo.nombre;
        }
    }
}
