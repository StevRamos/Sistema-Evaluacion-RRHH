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
    public partial class frmAdmGestSubComAdd : Form
    {
        //CriterioWS.CriterioWSClient daoCriterio;
        //CriterioWS.criterio competencia;

        //public CriterioWS.criterio Competencia { get => competencia; set => competencia = value; }
        public frmAdmGestSubComAdd()
        {
            InitializeComponent();
            //daoCriterio = new CriterioWS.CriterioWSClient();
        }

        private void label3_Click(object sender, EventArgs e)
        {

        }

        private void btnRegresarAddCom_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void btnGuardar_Click(object sender, EventArgs e)
        {
            MessageBox.Show("La subcompetencia se guardó exitosamente");
            this.Close();
        }

        private void btnBusRegSubCom_Click(object sender, EventArgs e)
        {
            Form formulario = new frmAdmGestSubComBuscarCom();
            formulario.Show();
            if(formulario.DialogResult == DialogResult.OK)
            {
                //competencia = formulario.Competencia;
                //txtComp.Text = competencia.nombre; 
            }
        }
    }
}
