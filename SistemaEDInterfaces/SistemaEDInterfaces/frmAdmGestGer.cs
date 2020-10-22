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
    public partial class frmAdmGestGer : Form
    {
        public frmAdmGestGer()
        {
            InitializeComponent();
        }

        private void btnGestGerCargaMav_Click(object sender, EventArgs e)
        {
            Form formulario = new frmAdmGestGerenCargaMav();
            formulario.Show();
        }
    }
}
