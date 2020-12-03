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
    public partial class frmEvMisTrabajadores : Form
    {
        private ColaboradorWS.ColaboradorWSClient daoColaborador;
        private int idJefe; 
        public frmEvMisTrabajadores()
        {
            InitializeComponent();
            idJefe = Global.colaboradorLoggeado.idColaborador; 
            daoColaborador = new ColaboradorWS.ColaboradorWSClient();
            dgvColaboradores.AutoGenerateColumns = false;
            dgvColaboradores.DataSource= daoColaborador.listarColaboradoresXJefe(idJefe); 
        }

        private void btnSeleccionar_Click(object sender, EventArgs e)
        {
            frmEvMisTrabajadoresOpciones form = new frmEvMisTrabajadoresOpciones();
            form.Colaborador = (ColaboradorWS.colaborador)dgvColaboradores.CurrentRow.DataBoundItem; 
            Global.formPrincipal.abrirFormularioHijo(false, form);
        }

        private void dgvColaboradores_CellFormatting(object sender, DataGridViewCellFormattingEventArgs e)
        {
            ColaboradorWS.colaborador data = dgvColaboradores.Rows[e.RowIndex].DataBoundItem as ColaboradorWS.colaborador;
            dgvColaboradores.Rows[e.RowIndex].Cells["nombre"].Value = data.nombres + " " + data.apellidos; 
            dgvColaboradores.Rows[e.RowIndex].Cells["puesto"].Value = data.puestoTrabajo.nombre;
        }
    }
}
