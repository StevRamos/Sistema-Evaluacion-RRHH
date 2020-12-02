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
    public partial class frmAdmGestSubpot : Form
    {
        private PesoCriterioWS.PesoCriterioWSClient daoPesoCriterio;
        private PeriodoWS.PeriodoWSClient daoPeriodo;
        private PuestoTrabajoWS.PuestoTrabajoWSClient daoPuestoTrabajo;
        public frmAdmGestSubpot()
        {
            InitializeComponent();
            daoPesoCriterio = new PesoCriterioWS.PesoCriterioWSClient();
            daoPeriodo = new PeriodoWS.PeriodoWSClient();
            daoPuestoTrabajo = new PuestoTrabajoWS.PuestoTrabajoWSClient();
            dgvGestCompetencias.AutoGenerateColumns = false;
            dgvGestCompetencias.DataSource = daoPesoCriterio.listarPesosCriterios((int)TipoCriterio.Subpotencial, "", "", "");


            BindingList<PeriodoWS.periodo> periodos = new BindingList<PeriodoWS.periodo>
                                                    ((daoPeriodo.listarPeriodos() ?? new PeriodoWS.periodo[0]).ToArray());
            BindingList<PuestoTrabajoWS.puestoTrabajo> puestos = new BindingList<PuestoTrabajoWS.puestoTrabajo>
                                         ((daoPuestoTrabajo.listarPuestoTrabajos("") ?? new PuestoTrabajoWS.puestoTrabajo[0]).ToArray());

            BindingList<String> nombresPuestos = new BindingList<string>();
            BindingList<String> nombresPeriodos = new BindingList<string>();

            cargarNombres(periodos, puestos, nombresPeriodos, nombresPuestos);

            cmbPuestos.DataSource = nombresPuestos;
            cmbPeriodos.DataSource = nombresPeriodos;
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

        private void btnCrearCompetencia_Click(object sender, EventArgs e)
        {
            Global.formPrincipal.abrirFormularioHijo(false, new frmAdmGestSubPotAdd());
        }

        private void btnCargarMasivaSubPot_Click(object sender, EventArgs e)
        {
            Form formulario = new frmAdmGestSubPotCrgMav();
            if (formulario.ShowDialog() == DialogResult.OK)
            {
                Global.iniciarEspera(this);
                String nombreCargoSeleccionado, nombrePeriodoSeleccionado, nombreSubcompetencia;
                nombreSubcompetencia = txtGestNombrePot.Text;
                nombreCargoSeleccionado = (String)cmbPuestos.SelectedItem;
                nombrePeriodoSeleccionado = (String)cmbPeriodos.SelectedItem;
                if (nombreCargoSeleccionado == "-") nombreCargoSeleccionado = "";
                if (nombrePeriodoSeleccionado == "-") nombrePeriodoSeleccionado = "";
                dgvGestCompetencias.DataSource = daoPesoCriterio.listarPesosCriterios((int)TipoCriterio.Subpotencial,
                                                                                nombreCargoSeleccionado,
                                                                                nombrePeriodoSeleccionado,
                                                                                nombreSubcompetencia);
                Global.terminarEspera(this);
            }
        }

        private void btnEliminar_Click(object sender, EventArgs e)
        {
            if (dgvGestCompetencias.CurrentCell == null)
            {
                MessageBox.Show("Debe seleccionar un subpotencial.",
                                   "Mensaje de error",
                                   MessageBoxButtons.OK,
                                   MessageBoxIcon.Error);
                return;
            }

            var result = MessageBox.Show("¿Esta seguro que desea eliminar el subpotencial seleccionado?",
                                            "Mensaje de advertencia",
                                            MessageBoxButtons.YesNo,
                                            MessageBoxIcon.Warning);

            if (result == DialogResult.Yes)
            {
                Global.iniciarEspera(this);

                PesoCriterioWS.pesoCriterio pesoCriterio;
                pesoCriterio = (PesoCriterioWS.pesoCriterio)dgvGestCompetencias.CurrentRow.DataBoundItem;
                if (daoPesoCriterio.eliminarPesoCriterio(pesoCriterio) != 0)
                {
                    Global.terminarEspera(this);
                    MessageBox.Show("Se elimino el subpotencial seleccionado.",
                                "Mensaje de confirmacion",
                                MessageBoxButtons.OK,
                                MessageBoxIcon.Information);
                    btnBuscar_Click(sender, e);
                }
                else
                {
                    Global.terminarEspera(this);
                    MessageBox.Show("Ocurrió un error al eliminar el subpotencial, intentelo nuevamente.",
                                "Mensaje de error",
                                MessageBoxButtons.OK,
                                MessageBoxIcon.Error);
                }


            }
        }

        private void btnBuscar_Click(object sender, EventArgs e)
        {
            Global.iniciarEspera(this);
            String nombreCargoSeleccionado, nombrePeriodoSeleccionado, nombreSubcompetencia;
            nombreSubcompetencia = txtGestNombrePot.Text;
            nombreCargoSeleccionado = (String)cmbPuestos.SelectedItem;
            nombrePeriodoSeleccionado = (String)cmbPeriodos.SelectedItem;
            if (nombreCargoSeleccionado == "-") nombreCargoSeleccionado = "";
            if (nombrePeriodoSeleccionado == "-") nombrePeriodoSeleccionado = "";
            dgvGestCompetencias.DataSource = daoPesoCriterio.listarPesosCriterios((int)TipoCriterio.Subpotencial,
                                                                            nombreCargoSeleccionado,
                                                                            nombrePeriodoSeleccionado,
                                                                            nombreSubcompetencia);
            Global.terminarEspera(this);
        }

        private void dgvGestCompetencias_CellFormatting(object sender, DataGridViewCellFormattingEventArgs e)
        {
            PesoCriterioWS.pesoCriterio data = dgvGestCompetencias.Rows[e.RowIndex].DataBoundItem as PesoCriterioWS.pesoCriterio;

            dgvGestCompetencias.Rows[e.RowIndex].Cells[1].Value = data.criterio.criterioPadre.idCriterio;
            dgvGestCompetencias.Rows[e.RowIndex].Cells[0].Value = data.criterio.idCriterio;
            dgvGestCompetencias.Rows[e.RowIndex].Cells[2].Value = data.criterio.nombre;
            dgvGestCompetencias.Rows[e.RowIndex].Cells[3].Value = data.criterio.descripcion;
            dgvGestCompetencias.Rows[e.RowIndex].Cells[4].Value = data.puestoTrabajo.nombre;
            dgvGestCompetencias.Rows[e.RowIndex].Cells[6].Value = data.periodo.nombre;
        }
    }
}
