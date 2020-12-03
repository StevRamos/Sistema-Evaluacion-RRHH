using SistemaEDInterfaces.ColaboradorWS;
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
    public partial class frmEvMisTrabajadoresEvPotencial : Form
    {
        private ColaboradorWS.colaborador colaborador; 
        public frmEvMisTrabajadoresEvPotencial()
        {
            InitializeComponent();

        }

        public colaborador Colaborador { get => colaborador; set => colaborador = value; }

        private void btnRegresar_Click(object sender, EventArgs e)
        {
            Global.formPrincipal.cerrarFormularioHijo();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            Global.formPrincipal.abrirFormularioHijo(false, new frmEvMisTrabajadoresPotenciales());
        }
    }
}
