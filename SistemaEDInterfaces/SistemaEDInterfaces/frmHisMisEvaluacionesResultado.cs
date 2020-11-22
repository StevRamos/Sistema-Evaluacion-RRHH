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
    public partial class frmHisMisEvaluacionesResultado : Form
    {
        public frmHisMisEvaluacionesResultado()
        {
            InitializeComponent();
        }

        private void btnSeleccionar_Click(object sender, EventArgs e)
        {
            Global.formPrincipal.abrirFormularioHijo(false, new frmHisMisEvaluacionesResultadoC());
        }

        private void button1_Click(object sender, EventArgs e)
        {
            Global.formPrincipal.abrirFormularioHijo(false, new frmHisMisEvaluacionesResultadoP());
        }

        private void btnRegresar_Click(object sender, EventArgs e)
        {
            Global.formPrincipal.cerrarFormularioHijo();
        }
    }
}
