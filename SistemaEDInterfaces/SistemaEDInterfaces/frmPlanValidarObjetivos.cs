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
    public partial class frmPlanValidarObjetivos : Form
    {
        public frmPlanValidarObjetivos()
        {
            InitializeComponent();
        }

        private void btnRealizarRevision_Click(object sender, EventArgs e)
        {
            Global.formPrincipal.abrirFormularioHijo(false, new frmPlanRealizarRevision()); 
        }
    }
}
