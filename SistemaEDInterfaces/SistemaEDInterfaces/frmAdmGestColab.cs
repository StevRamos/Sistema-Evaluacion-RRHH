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
        public frmAdmGestColab()
        {
            InitializeComponent();
        }

        private void btnGestColabCargaMav_Click(object sender, EventArgs e)
        {
            Form formulario = new frmAdmGestColabCargaMav();
            formulario.Show();
        }

        private void btnGestColabVerDetalle_Click(object sender, EventArgs e)
        {
            Form formulario = new frmAdmGestColabVerDetalle();
            formulario.Show();
        }
    }
}
