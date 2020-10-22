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
    public partial class frmAdmGestPotAdd : Form
    {
        public frmAdmGestPotAdd()
        {
            InitializeComponent();
        }

        private void btnAddGuardarPot_Click(object sender, EventArgs e)
        {
            MessageBox.Show("El potencial se agregó exitosamente");
            this.Close();
        }

        private void btnAddRegresarPot_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
