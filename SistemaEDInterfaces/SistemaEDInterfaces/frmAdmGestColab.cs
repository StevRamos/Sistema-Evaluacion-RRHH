using SistemaEDInterfaces.ColaboradorWS;
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

    public partial class frmAdmGestColab : Form
    {

        private ColaboradorWS.ColaboradorWSClient daoColaborador;
        private PuestoTrabajoWS.PuestoTrabajoWSClient daoPuestoTrabajo;
        private ColaboradorWS.colaborador colaboradorSeleccionado;

        public ColaboradorWS.colaborador ColaboradorSeleccionado 
        { get => colaboradorSeleccionado; set => colaboradorSeleccionado = value; }

        public frmAdmGestColab()
        {
            InitializeComponent();
            daoPuestoTrabajo = new PuestoTrabajoWS.PuestoTrabajoWSClient();
            daoColaborador = new ColaboradorWS.ColaboradorWSClient();

            dgvColaboradores.AutoGenerateColumns = false;
            //dgvColaboradores.DataSource = new BindingList<ColaboradorWS.colaborador>
            //    (daoColaborador.listarColaboradores(-1,"").ToArray());
            dgvColaboradores.DataSource = daoColaborador.listarColaboradores(-1,"");

            cboCargo.DataSource = new BindingList<PuestoTrabajoWS.puestoTrabajo>
                (daoPuestoTrabajo.listarPuestoTrabajos("").ToArray() );
            cboCargo.ValueMember = "idPuestoTrabajo";
            cboCargo.DisplayMember = "nombre";
            
        }



        private void btnGestColabCargaMav_Click(object sender, EventArgs e)
        {
            Form formulario = new frmAdmGestColabCargaMav();
            formulario.Show();
        }

        private void btnGestColabVerDetalle_Click(object sender, EventArgs e)
        {
            colaboradorSeleccionado =
               (ColaboradorWS.colaborador)dgvColaboradores.CurrentRow.DataBoundItem;

            frmAdmGestColabVerDetalle form = new frmAdmGestColabVerDetalle();
            form.Colaborador = colaboradorSeleccionado;
            Global.formPrincipal.abrirFormularioHijo(false, form);
        }

        private void btnBuscar_Click(object sender, EventArgs e)
        {
            PuestoTrabajoWS.puestoTrabajo puestoTrabajo;
            puestoTrabajo = (PuestoTrabajoWS.puestoTrabajo)cboCargo.SelectedItem;
            

            if (string.IsNullOrEmpty(txtDni.Text))
            {
                dgvColaboradores.DataSource = daoColaborador.listarColaboradores(puestoTrabajo.idPuestoTrabajo, "");
            }
            else
            {
                dgvColaboradores.DataSource = daoColaborador.listarColaboradores(puestoTrabajo.idPuestoTrabajo, txtDni.Text);
            }
        }

        private void dgvColaboradores_CellFormatting(object sender, DataGridViewCellFormattingEventArgs e)
        {
            ColaboradorWS.colaborador data = dgvColaboradores.Rows[e.RowIndex].DataBoundItem as ColaboradorWS.colaborador;
            dgvColaboradores.Rows[e.RowIndex].Cells["nombre"].Value = data.nombres + " " + data.apellidos;
            dgvColaboradores.Rows[e.RowIndex].Cells["Cargo"].Value = data.puestoTrabajo.nombre;
            dgvColaboradores.Rows[e.RowIndex].Cells["nombreJefe"].Value = data.jefe.nombres + " " + data.jefe.apellidos;

        }

        private void btnDesactivar_Click(object sender, EventArgs e)
        {
            var result = MessageBox.Show("Se eliminaran todos los colaboradores seleccionados",
                                            "Mensaje de advertencia",
                                            MessageBoxButtons.OKCancel,
                                            MessageBoxIcon.Warning);
            if (result == DialogResult.OK)
            {
                foreach (DataGridViewRow row in dgvColaboradores.SelectedRows)
                {

                    ColaboradorWS.colaborador colaborador = (ColaboradorWS.colaborador)dgvColaboradores.CurrentRow.DataBoundItem;
                    daoColaborador.eliminarColaborador(colaborador.idColaborador);
                    dgvColaboradores.DataSource = daoColaborador.listarColaboradores(-1, "");
                }

            }
        }
    }
}
