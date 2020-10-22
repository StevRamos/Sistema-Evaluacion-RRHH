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
    public partial class frmPlanMisObjetivos : Form
    {
        
        public frmPlanMisObjetivos()
        {
            InitializeComponent();
            
        }


        public void agregarDatosDummyDGV()
        {
            int rowId = dgvMisObjetivos.Rows.Add();

            DataGridViewRow row = dgvMisObjetivos.Rows[rowId];

            row.Cells["Descripcion"].Value= 121212;
            row.Cells["Numero"].Value = 122112;
            row.Cells["Peso"].Value = 122112;
            row.Cells["Estado"].Value = 122121;
            
        }
        private void frmPlanMisObjetivos_Load(object sender, EventArgs e)
        {
            agregarDatosDummyDGV();
        }

        private void btnAgregar_Click(object sender, EventArgs e)
        {
            
              Global.formPrincipal.abrirFormularioHijo(false,new frmPlanAgregarObjetivo());

             //Global.abrirFormularioHijo(panelContenedor, formularioHijoActual, new frmPlanAgregarObjetivo());
           // frmPlanAgregarObjetivo form = new frmPlanAgregarObjetivo();
            //form.ShowDialog();
        }

        private void dgvMisObjetivos_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }
    }
}
