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
        private int idPeriodo; 
        private BindingList<ColaboradorWS.colaborador> colaboradores;
        public frmEvMisTrabajadores()
        {
            InitializeComponent();
            idPeriodo = Global.periodoActual.idPeriodo; 
            colaboradores = new BindingList<ColaboradorWS.colaborador>();
            idJefe = Global.colaboradorLoggeado.idColaborador; 
            daoColaborador = new ColaboradorWS.ColaboradorWSClient();
            dgvColaboradores.AutoGenerateColumns = false;
            ColaboradorWS.colaborador[] lista
                = daoColaborador.listarColaboradoresXJefe(idJefe);
            if(lista != null)
            {
                colaboradores = new BindingList<ColaboradorWS.colaborador>(lista.ToList());
                dgvColaboradores.DataSource = colaboradores; 
            }
            
        }

        
        private void btnSeleccionar_Click(object sender, EventArgs e)
        {
            frmEvMisTrabajadoresOpciones form = new frmEvMisTrabajadoresOpciones();
            form.Colaborador = (ColaboradorWS.colaborador)dgvColaboradores.CurrentRow.DataBoundItem;
            form.Periodo = Global.periodoActual; 
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
