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
    public partial class frmAdmGestSubcomp : Form
    {
        private PesoCriterioWS.PesoCriterioWSClient daoPesoCriterio;
        private PeriodoWS.PeriodoWSClient daoPeriodo;
        private PuestoTrabajoWS.PuestoTrabajoWSClient daoPuestoTrabajo;
        public frmAdmGestSubcomp()
        {
            InitializeComponent();
            daoPesoCriterio = new PesoCriterioWS.PesoCriterioWSClient();
            daoPeriodo = new PeriodoWS.PeriodoWSClient();
            daoPuestoTrabajo = new PuestoTrabajoWS.PuestoTrabajoWSClient();
            dgvGestSubCom.AutoGenerateColumns = false;
            dgvGestSubCom.DataSource = daoPesoCriterio.listarPesosCriterios((int)TipoCriterio.Subcompetencia, "", "", "");


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
        private void btnGestCrearSubCom_Click(object sender, EventArgs e)
        {
            Global.formPrincipal.abrirFormularioHijo(true, new frmAdmGestSubComAdd());
        }

        private void btnCargarMasivaSubCom_Click(object sender, EventArgs e)
        {
            Form formulario = new frmAdmGestSubComCrgMav();
            if (formulario.ShowDialog() == DialogResult.OK)
            {
                Global.iniciarEspera(this);
                String nombreCargoSeleccionado, nombrePeriodoSeleccionado, nombreSubcompetencia;
                nombreSubcompetencia = txtSubcomp.Text;
                nombreCargoSeleccionado = (String)cmbPuestos.SelectedItem;
                nombrePeriodoSeleccionado = (String)cmbPeriodos.SelectedItem;
                if (nombreCargoSeleccionado == "-") nombreCargoSeleccionado = "";
                if (nombrePeriodoSeleccionado == "-") nombrePeriodoSeleccionado = "";
                dgvGestSubCom.DataSource = daoPesoCriterio.listarPesosCriterios((int)TipoCriterio.Subcompetencia,
                                                                                nombreCargoSeleccionado,
                                                                                nombrePeriodoSeleccionado,
                                                                                nombreSubcompetencia);
                Global.terminarEspera(this);
            }
        }

        private void btnEliminar_Click(object sender, EventArgs e)
        {
            if (dgvGestSubCom.CurrentCell == null)
            {
                MessageBox.Show("Debe seleccionar una subcompetencia.",
                                   "Mensaje de error",
                                   MessageBoxButtons.OK,
                                   MessageBoxIcon.Error);
                return;
            }

            var result = MessageBox.Show("¿Esta seguro que desea eliminar la subcompetencia seleccionada?",
                                            "Mensaje de advertencia",
                                            MessageBoxButtons.YesNo,
                                            MessageBoxIcon.Warning);

            if (result == DialogResult.Yes)
            {
                Global.iniciarEspera(this);

                PesoCriterioWS.pesoCriterio pesoCriterio;
                pesoCriterio = (PesoCriterioWS.pesoCriterio)dgvGestSubCom.CurrentRow.DataBoundItem;
                if (daoPesoCriterio.eliminarPesoCriterio(pesoCriterio) != 0)
                {
                    Global.terminarEspera(this);
                    MessageBox.Show("Se elimino la subcompetencia seleccionada.",
                                "Mensaje de confirmacion",
                                MessageBoxButtons.OK,
                                MessageBoxIcon.Information);
                    btnBuscar_Click(sender, e);
                }
                else
                {
                    Global.terminarEspera(this);
                    MessageBox.Show("Ocurrió un error al eliminar la subcompetencia, intentelo nuevamente.",
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
            nombreSubcompetencia = txtSubcomp.Text;
            nombreCargoSeleccionado = (String)cmbPuestos.SelectedItem;
            nombrePeriodoSeleccionado = (String)cmbPeriodos.SelectedItem;
            if (nombreCargoSeleccionado == "-") nombreCargoSeleccionado = "";
            if (nombrePeriodoSeleccionado == "-") nombrePeriodoSeleccionado = "";
            dgvGestSubCom.DataSource = daoPesoCriterio.listarPesosCriterios((int)TipoCriterio.Subcompetencia,
                                                                            nombreCargoSeleccionado,
                                                                            nombrePeriodoSeleccionado,
                                                                            nombreSubcompetencia);
            Global.terminarEspera(this); 
        }

        private void dgvGestSubCom_CellFormatting(object sender, DataGridViewCellFormattingEventArgs e)
        {
            PesoCriterioWS.pesoCriterio data = dgvGestSubCom.Rows[e.RowIndex].DataBoundItem as PesoCriterioWS.pesoCriterio;

            dgvGestSubCom.Rows[e.RowIndex].Cells["IdCriterio"].Value = data.criterio.criterioPadre.idCriterio;
            dgvGestSubCom.Rows[e.RowIndex].Cells["NombreCriterio"].Value = data.criterio.criterioPadre.nombre;
            dgvGestSubCom.Rows[e.RowIndex].Cells["IdSubcriterio"].Value = data.criterio.idCriterio;
            dgvGestSubCom.Rows[e.RowIndex].Cells["NombreSubcriterio"].Value = data.criterio.nombre;
            dgvGestSubCom.Rows[e.RowIndex].Cells["Descripcion"].Value = data.criterio.descripcion;
            dgvGestSubCom.Rows[e.RowIndex].Cells["Cargo"].Value = data.puestoTrabajo.nombre;
            dgvGestSubCom.Rows[e.RowIndex].Cells["Periodo"].Value = data.periodo.nombre;

        }
    }
}
