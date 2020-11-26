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
    public partial class frmAdmGestComp : Form
    {
        private PesoCriterioWS.PesoCriterioWSClient daoPesoCriterio;
        private PeriodoWS.PeriodoWSClient daoPeriodo;
        private PuestoTrabajoWS.PuestoTrabajoWSClient daoPuestoTrabajo; 
        public frmAdmGestComp()
        {
            InitializeComponent();
            daoPesoCriterio = new PesoCriterioWS.PesoCriterioWSClient();
            daoPeriodo = new PeriodoWS.PeriodoWSClient();
            daoPuestoTrabajo = new PuestoTrabajoWS.PuestoTrabajoWSClient();
            dgvCompetencias.AutoGenerateColumns = false;
            PesoCriterioWS.pesoCriterio [] lista= daoPesoCriterio.listarPesosCriterios((int)TipoCriterio.Competencia, "", "", "");
            dgvCompetencias.DataSource = lista; 
            

            BindingList<PeriodoWS.periodo> periodos = new BindingList<PeriodoWS.periodo>
                                                    ((daoPeriodo.listarPeriodos() ?? new PeriodoWS.periodo[0]).ToArray());
            BindingList<PuestoTrabajoWS.puestoTrabajo> puestos = new BindingList<PuestoTrabajoWS.puestoTrabajo>
                                         ((daoPuestoTrabajo.listarPuestoTrabajos("") ?? new PuestoTrabajoWS.puestoTrabajo[0]).ToArray());

            BindingList<String> nombresPuestos = new BindingList<string>();
            BindingList<String> nombresPeriodos = new BindingList<string>();

            cargarNombres(periodos,puestos,nombresPeriodos,nombresPuestos);

            cmbCargos.DataSource = nombresPuestos;
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
            foreach(PuestoTrabajoWS.puestoTrabajo pt in puestos)
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

        private void btnCrearCompetencia_Click_1(object sender, EventArgs e)
        {

            Global.formPrincipal.abrirFormularioHijo(true, new frmAdmGestComAdd());
        }

        private void btnCargarMasivaCom_Click_1(object sender, EventArgs e)
        {
            Form formulario = new frmAdmGestComCrgMav();
            formulario.Show();
        }

        private void btnBuscar_Click(object sender, EventArgs e)
        {
            iniciarEspera();
            String nombreCargoSeleccionado,nombrePeriodoSeleccionado,nombreCompetencia;
            nombreCompetencia = txtComp.Text;
            nombreCargoSeleccionado = (String)cmbCargos.SelectedItem;
            nombrePeriodoSeleccionado = (String)cmbPeriodos.SelectedItem; 
            if (nombreCargoSeleccionado == "-") nombreCargoSeleccionado = "";
            if (nombrePeriodoSeleccionado == "-") nombrePeriodoSeleccionado = "";
            dgvCompetencias.DataSource = daoPesoCriterio.listarPesosCriterios((int)TipoCriterio.Competencia, 
                                                                            nombreCargoSeleccionado,
                                                                            nombrePeriodoSeleccionado,
                                                                            nombreCompetencia);
            terminarEspera(); 
        }

        private void btnEliminar_Click(object sender, EventArgs e)
        {
            if (dgvCompetencias.CurrentCell == null)
            {
                MessageBox.Show("Debe seleccionar una competencia.",
                                   "Mensaje de error",
                                   MessageBoxButtons.OK,
                                   MessageBoxIcon.Error);
                return;
            }

            var result = MessageBox.Show("¿Esta seguro que desea eliminar la competencia seleccionada?",
                                            "Mensaje de advertencia",
                                            MessageBoxButtons.YesNo,
                                            MessageBoxIcon.Warning);

            if (result == DialogResult.Yes)
            {
                iniciarEspera();

                PesoCriterioWS.pesoCriterio pesoCriterio;
                pesoCriterio = (PesoCriterioWS.pesoCriterio)dgvCompetencias.CurrentRow.DataBoundItem;
                if (daoPesoCriterio.eliminarPesoCriterio(pesoCriterio) != 0)
                {
                    terminarEspera();
                    MessageBox.Show("Se elimino la competencia seleccionada.",
                                "Mensaje de confirmacion",
                                MessageBoxButtons.OK,
                                MessageBoxIcon.Information);
                    btnBuscar_Click(sender, e);
                }
                else
                {
                    terminarEspera();
                    MessageBox.Show("Ocurrió un error al eliminar la competencia, intentelo nuevamente.",
                                "Mensaje de error",
                                MessageBoxButtons.OK,
                                MessageBoxIcon.Error);
                }


            }
            
        }

        private void dgvCompetencias_CellFormatting(object sender, DataGridViewCellFormattingEventArgs e)
        {
            PesoCriterioWS.pesoCriterio data = dgvCompetencias.Rows[e.RowIndex].DataBoundItem as PesoCriterioWS.pesoCriterio;

            dgvCompetencias.Rows[e.RowIndex].Cells["idCriterio"].Value = data.criterio.idCriterio;
            dgvCompetencias.Rows[e.RowIndex].Cells["nombreCriterio"].Value = data.criterio.nombre;
            dgvCompetencias.Rows[e.RowIndex].Cells["descripcion"].Value = data.criterio.descripcion;
            dgvCompetencias.Rows[e.RowIndex].Cells["Cargo"].Value = data.puestoTrabajo.nombre;
            dgvCompetencias.Rows[e.RowIndex].Cells["periodo"].Value = data.periodo.nombre;
        }
    }
}
