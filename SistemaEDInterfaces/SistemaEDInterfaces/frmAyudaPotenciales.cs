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
    public partial class frmAyudaPotenciales : Form
    {
        public frmAyudaPotenciales()
        {
            InitializeComponent();
        }

        private void llblOlvContra_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            Form frmAyuda = new frmAyudaCargaMasiva();
            frmAyuda.Show();
        }
    }
}
