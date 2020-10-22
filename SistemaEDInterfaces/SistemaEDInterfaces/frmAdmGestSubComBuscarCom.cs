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
    public partial class frmAdmGestSubComBuscarCom : Form
    {
        public frmAdmGestSubComBuscarCom()
        {
            InitializeComponent();
        }

        private void label5_Click(object sender, EventArgs e)
        {

        }

        private void btnObtCodCom_Click(object sender, EventArgs e)
        {
            MessageBox.Show("El proceso fue realizado con éxito");
            this.Close();
        }

        private void btnRegresarAddCom_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }
    }
}
