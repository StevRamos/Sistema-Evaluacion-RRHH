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
    public partial class frmAdmGestCronVerDetalleFecha : Form
    {
        private DateTime fechaSeleccionada;
        private String titulo; 
        public frmAdmGestCronVerDetalleFecha()
        {
            InitializeComponent();
        }

        public DateTime FechaSeleccionada { get => fechaSeleccionada; set => fechaSeleccionada = value; }

        public String Titulo { get => titulo; set => titulo = value; }
        private void btnSeleccionar_Click(object sender, EventArgs e)
        {
            fechaSeleccionada = dtpFecha.Value;
            this.DialogResult = DialogResult.OK;
            this.Close(); 
        }

        private void frmAdmGestCronVerDetalleFecha_Load(object sender, EventArgs e)
        {
            lblTitulo.Text = titulo; 
        }
    }
}
