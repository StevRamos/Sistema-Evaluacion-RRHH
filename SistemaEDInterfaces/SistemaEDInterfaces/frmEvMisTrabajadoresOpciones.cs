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
    public partial class frmEvMisTrabajadoresOpciones : Form
    {
        private ColaboradorWS.colaborador colaborador;

        public colaborador Colaborador { get => colaborador; set => colaborador = value; }

        public frmEvMisTrabajadoresOpciones()
        {
            InitializeComponent();
        }

        private void btnRegresar_Click(object sender, EventArgs e)
        {
            Global.formPrincipal.cerrarFormularioHijo();
        }

        private void btnPrevia_Click(object sender, EventArgs e)
        {
            frmEvMisTrabajadoresPrevia form = new frmEvMisTrabajadoresPrevia();
            form.Colaborador = colaborador; 
            Global.formPrincipal.abrirFormularioHijo(false, form);
        }

        private void btnFinal_Click(object sender, EventArgs e)
        {
            frmEvMisTrabajadoresFinal form = new frmEvMisTrabajadoresFinal();
            form.Colaborador = colaborador; 
            Global.formPrincipal.abrirFormularioHijo(false, form);
        }

        private void btnPotencial_Click(object sender, EventArgs e)
        {
            frmEvMisTrabajadoresEvPotencial form = new frmEvMisTrabajadoresEvPotencial();
            form.Colaborador = colaborador; 
            Global.formPrincipal.abrirFormularioHijo(false, form);
        }
    }
}
