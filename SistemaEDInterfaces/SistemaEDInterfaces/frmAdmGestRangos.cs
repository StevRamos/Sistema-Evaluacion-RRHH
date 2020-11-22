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
    public partial class frmAdmGestRangos : Form
    {
        //bool datosGuardados; 
        /*private EscalaPeriodoWS.EscalaPeriodoWSClient daoEscalaPeriodo;
        private ItemPDIPeriodoWS.ItemPDIPeriodoWSClient daoItemPDIPeriodo;

        private BindingList<ItemPDIPeriodoWS.itemPDIPeriodo> itemsPDIPeriodos;
        private BindingList<EscalaPeriodoWS.escalaPeriodo> escalasPeriodos;*/
        public frmAdmGestRangos()
        {
            InitializeComponent();

            /*daoEscalaPeriodo = new EscalaPeriodoWS.EscalaPeriodoWSClient();
            daoItemPDIPeriodo = new ItemPDIPeriodoWS.ItemPDIPeriodoWSClient(); 

            escalasPeriodos =
               new BindingList<EscalaPeriodoWS.escalaPeriodo>(daoEscalaPeriodo.listarEscalaPeriodos().ToArray());

            itemsPDIPeriodos 
                = new BindingList<ItemPDIPeriodoWS.itemPDIPeriodo>(daoItemPDIPeriodo.listarItemsPDIPeriodos().ToArray());

            foreach(EscalaPeriodoWS.escalaPeriodo ep in escalasPeriodos)
            {
                switch(ep.escala.nombre)
                {
                    case "A":
                        txtAMax.Text = ep.notaMax.ToString();
                        txtAMin.Text = ep.notaMin.ToString();
                        txtCuposA.Text = ep.porcentajeCupos.ToString(); 
                        break;
                    case "B":
                        txtBMax.Text = ep.notaMax.ToString();
                        txtBMin.Text = ep.notaMin.ToString();
                        txtCuposB.Text = ep.porcentajeCupos.ToString();
                        break;
                    case "C":
                        txtCMax.Text = ep.notaMax.ToString();
                        txtCMin.Text = ep.notaMin.ToString();
                        txtCuposC.Text = ep.porcentajeCupos.ToString();
                        break;
                    case "D":
                        txtDMax.Text = ep.notaMax.ToString();
                        txtDMin.Text = ep.notaMin.ToString();
                        txtCuposD.Text = ep.porcentajeCupos.ToString();
                        break;
                    case "E":
                        txtEMax.Text = ep.notaMax.ToString();
                        txtEMin.Text = ep.notaMin.ToString();
                        txtCuposE.Text = ep.porcentajeCupos.ToString();
                        break;
                    case "Alto":
                        txtAltoMax.Text = ep.notaMax.ToString();
                        txtAltoMin.Text = ep.notaMin.ToString();
                        break;
                    case "Medio":
                        txtMedioMax.Text = ep.notaMax.ToString();
                        txtMedioMin.Text = ep.notaMin.ToString();
                        break;
                    case "Bajo":
                        txtBajoMax.Text = ep.notaMax.ToString();
                        txtBajoMin.Text = ep.notaMin.ToString();
                        break; 


                }
            }
            
            foreach(ItemPDIPeriodoWS.itemPDIPeriodo ip in itemsPDIPeriodos)
            {
                switch (ip.itemPDI.nombre)
                {
                    case "Fortaleza":
                        txtFortalezaMax.Text = ip.notaMax.ToString();
                        txtFortalezaMin.Text = ip.notaMin.ToString();
                        break;
                    case "Oportunidad de Mejora":
                        txtOportunidadMax.Text = ip.notaMax.ToString();
                        txtOportunidadMin.Text = ip.notaMin.ToString();
                        break;
                    case "Debilidad":
                        txtDebilidadMax.Text = ip.notaMax.ToString();
                        txtDebilidadMin.Text = ip.notaMin.ToString();
                        break; 
                }
            }
            */

        }


        private bool verificarSumaCupos()
        {
            int suma;
            suma = Int32.Parse(txtCuposA.Text)
                + Int32.Parse(txtCuposB.Text)
                + Int32.Parse(txtCuposC.Text)
                + Int32.Parse(txtCuposD.Text)
                + Int32.Parse(txtCuposE.Text);
            return suma==100; 
        }
        private void btnGuardar_Click(object sender, EventArgs e)
        {
            
            if (verificarSumaCupos())
            {
                //daoEscalaPeriodo.
                MessageBox.Show("Se guardaron los cambios realizados.",
                "Mensaje de información",
                MessageBoxButtons.OK,
                MessageBoxIcon.Information);
            }
            else
            {


                MessageBox.Show("Error: Los valores de cupos no suman 100%.",
                "Error",
                MessageBoxButtons.OK,
                MessageBoxIcon.Error);
            }
        }

        private void txtAMin_Leave(object sender, EventArgs e)
        {
            txtBMax.Text = txtAMin.Text;
        }

        private void txtBMin_Leave(object sender, EventArgs e)
        {
            txtCMax.Text = txtBMin.Text;
        }

        private void txtCMin_Leave(object sender, EventArgs e)
        {
            txtDMax.Text = txtCMin.Text;
        }

        private void txtDMin_Leave(object sender, EventArgs e)
        {
            txtEMax.Text = txtDMin.Text;
        }

        private void txtAltoMin_Leave(object sender, EventArgs e)
        {
            txtMedioMax.Text = txtAltoMin.Text;
        }

        private void txtMedioMin_Leave(object sender, EventArgs e)
        {
            txtBajoMax.Text = txtMedioMin.Text; 
        }

        private void txtFortalezaMin_Leave(object sender, EventArgs e)
        {
            txtOportunidadMax.Text = txtFortalezaMin.Text; 
        }

        private void txtOportunidadMin_Leave(object sender, EventArgs e)
        {
            txtDebilidadMax.Text = txtOportunidadMin.Text;
        }

        private void label12_Click(object sender, EventArgs e)
        {

        }
    }
}
