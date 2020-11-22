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
    public partial class frmAdmGestSubPotBuscarPot : Form
    {
        public frmAdmGestSubPotBuscarPot()
        {
            InitializeComponent();
        }

        private void btnSeleccionar_Click(object sender, EventArgs e)
        {
            MessageBox.Show("Proceso fue realizado con éxito");
            this.Close();
        }

        private void btnBuscar_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
