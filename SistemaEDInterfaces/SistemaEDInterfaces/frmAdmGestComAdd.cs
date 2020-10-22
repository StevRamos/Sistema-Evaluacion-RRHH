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
    public partial class frmAdmGestComAdd : Form
    {
        public frmAdmGestComAdd()
        {
            InitializeComponent();
        }

        private void frmAdmGestSubComAdd_Load(object sender, EventArgs e)
        {

        }

        private void btnGuardar_Click(object sender, EventArgs e)
        {
            MessageBox.Show("La competencia se agregó exitosamente");
            this.Close();
        }

        private void btnRegresarAddCom_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
