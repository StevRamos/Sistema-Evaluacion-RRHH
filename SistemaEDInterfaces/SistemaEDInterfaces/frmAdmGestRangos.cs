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
        private PeriodoWS.PeriodoWSClient daoPeriodo;
        private PeriodoWS.periodo periodo; 

        private BindingList<PeriodoWS.itemPDIPeriodo> itemsPDIPeriodos;
        private BindingList<PeriodoWS.escalaPeriodo> escalasPeriodos;

        public frmAdmGestRangos()
        {
            InitializeComponent();
            

            daoPeriodo = new PeriodoWS.PeriodoWSClient();
            periodo = Global.periodoActual;

<<<<<<< HEAD
            escalasPeriodos =
               new BindingList<PeriodoWS.escalaPeriodo>(daoPeriodo.listarEscalaPeriodo(periodo.idPeriodo).ToArray()); 
=======
           /* escalasPeriodos = new BindingList<PeriodoWS.escalaPeriodo>();
            itemsPDIPeriodos = new BindingList<PeriodoWS.itemPDIPeriodo>();
           */
            
           escalasPeriodos =
               new BindingList<PeriodoWS.escalaPeriodo>(daoPeriodo.listarEscalaPeriodo(periodo.idPeriodo).ToArray());
>>>>>>> 9805d051d5760062e80f415d52c839b7dc70f25e

            itemsPDIPeriodos 
                = new BindingList<PeriodoWS.itemPDIPeriodo>(daoPeriodo.listarItemPDIPeriodo(periodo.idPeriodo).ToArray());

            foreach (PeriodoWS.escalaPeriodo ep in escalasPeriodos)
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
            
            foreach(PeriodoWS.itemPDIPeriodo ip in itemsPDIPeriodos)
            {
                switch (ip.itemPDI.nombre)
                {
                    case "FORTALEZAS":
                        txtFortalezaMax.Text = ip.notaMax.ToString();
                        txtFortalezaMin.Text = ip.notaMin.ToString();
                        break;
                    case "OPORTUNIDADES DE MEJORA":
                        txtOportunidadMax.Text = ip.notaMax.ToString();
                        txtOportunidadMin.Text = ip.notaMin.ToString();
                        break;
                    case "DEBILIDADES":
                        txtDebilidadMax.Text = ip.notaMax.ToString();
                        txtDebilidadMin.Text = ip.notaMin.ToString();
                        break; 
                }
            }
            
            
        }

        private int mostrarMensajeErrorPeso()
        {
            MessageBox.Show("Error: Los pesos deben estar entre 0 y 100.",
                "Error",
                MessageBoxButtons.OK,
                MessageBoxIcon.Error);
            return 0; 
        }

        private int realizarValidaciones()
        {
            int valido = 1;
            double suma;
            //Verificar que los numeros esten entre 0 y 100 
            if (Double.Parse(txtAMax.Text)<0 || Double.Parse(txtAMax.Text)>100) return mostrarMensajeErrorPeso();
            if (Double.Parse(txtAMin.Text) < 0 || Double.Parse(txtAMin.Text) > 100) return mostrarMensajeErrorPeso();
            if (Double.Parse(txtBMax.Text) < 0 || Double.Parse(txtBMax.Text) > 100) return mostrarMensajeErrorPeso();
            if (Double.Parse(txtBMin.Text) < 0 || Double.Parse(txtBMin.Text) > 100) return mostrarMensajeErrorPeso();
            if (Double.Parse(txtCMax.Text) < 0 || Double.Parse(txtCMax.Text) > 100) return mostrarMensajeErrorPeso();
            if (Double.Parse(txtCMin.Text) < 0 || Double.Parse(txtCMin.Text) > 100) return mostrarMensajeErrorPeso();
            if (Double.Parse(txtDMax.Text) < 0 || Double.Parse(txtDMax.Text) > 100) return mostrarMensajeErrorPeso();
            if (Double.Parse(txtDMin.Text) < 0 || Double.Parse(txtDMin.Text) > 100) return mostrarMensajeErrorPeso();
            if (Double.Parse(txtEMax.Text) < 0 || Double.Parse(txtEMax.Text) > 100) return mostrarMensajeErrorPeso();
            if (Double.Parse(txtEMin.Text) < 0 || Double.Parse(txtEMin.Text) > 100) return mostrarMensajeErrorPeso();

            if (Double.Parse(txtAltoMax.Text) < 0 || Double.Parse(txtAltoMax.Text) > 100) return mostrarMensajeErrorPeso();
            if (Double.Parse(txtAltoMin.Text) < 0 || Double.Parse(txtAltoMin.Text) > 100) return mostrarMensajeErrorPeso();
            if (Double.Parse(txtMedioMax.Text) < 0 || Double.Parse(txtMedioMax.Text) > 100) return mostrarMensajeErrorPeso();
            if (Double.Parse(txtMedioMin.Text) < 0 || Double.Parse(txtMedioMin.Text) > 100) return mostrarMensajeErrorPeso();
            if (Double.Parse(txtBajoMax.Text) < 0 || Double.Parse(txtBajoMax.Text) > 100) return mostrarMensajeErrorPeso();
            if (Double.Parse(txtBajoMin.Text) < 0 || Double.Parse(txtBajoMin.Text) > 100) return mostrarMensajeErrorPeso();

            if (Double.Parse(txtFortalezaMax.Text) < 0 || Double.Parse(txtFortalezaMax.Text) > 100) return mostrarMensajeErrorPeso();
            if (Double.Parse(txtFortalezaMin.Text) < 0 || Double.Parse(txtFortalezaMin.Text) > 100) return mostrarMensajeErrorPeso();
            if (Double.Parse(txtOportunidadMax.Text) < 0 || Double.Parse(txtOportunidadMax.Text) > 100) return mostrarMensajeErrorPeso();
            if (Double.Parse(txtOportunidadMin.Text) < 0 || Double.Parse(txtOportunidadMin.Text) > 100) return mostrarMensajeErrorPeso();
            if (Double.Parse(txtDebilidadMax.Text) < 0 || Double.Parse(txtDebilidadMax.Text) > 100) return mostrarMensajeErrorPeso();
            if (Double.Parse(txtDebilidadMin.Text) < 0 || Double.Parse(txtDebilidadMin.Text) > 100) return mostrarMensajeErrorPeso()    ;

            //Verificar que la suma de Cupos sea equivalente a 100
            suma = Double.Parse(txtCuposA.Text)
                + Double.Parse(txtCuposB.Text)
                + Double.Parse(txtCuposC.Text)
                + Double.Parse(txtCuposD.Text)
                + Double.Parse(txtCuposE.Text);
            if (suma != 100)
            {
                MessageBox.Show("Error: Los valores de cupos no suman 100%.",
                   "Error",
                   MessageBoxButtons.OK,
                   MessageBoxIcon.Error);
                return 0; 

            }
            return valido; 
        }
        private void btnGuardar_Click(object sender, EventArgs e)
        {
            
            iniciarEspera();
            
            /*
            if (realizarValidaciones()==0)
            {
                terminarEspera();
                return; 
            }*/

            actualizarEscalaPeriodo();
            actualizarPDI();
            periodo.escalas = escalasPeriodos.ToArray();
            periodo.rangosPDI = itemsPDIPeriodos.ToArray();
            int resultado = 0;
            resultado = daoPeriodo.actualizarRangos(periodo);
            
            terminarEspera(); 
            if (resultado == 0)
            {
                MessageBox.Show("Ocurrió un error, intentelo nuevamente.",
                "Mensaje de error",
                MessageBoxButtons.OK,
                MessageBoxIcon.Error);
                return;
            }
            
            MessageBox.Show("Se guardaron los cambios realizados.",
                "Mensaje de información",
                MessageBoxButtons.OK,
                MessageBoxIcon.Information);
           
        }
        private void iniciarEspera()
        {
            this.Cursor = Cursors.WaitCursor;
        }

        private void terminarEspera()
        {
            this.Cursor = Cursors.Default;
        }
        
        private void actualizarEscalaPeriodo()
        {
            for (int i = 0; i < escalasPeriodos.Count(); i++)
            {
                switch (escalasPeriodos[i].escala.nombre)
                {
                    case "A":
                        escalasPeriodos[i].notaMax = Double.Parse(txtAMax.Text);
                        escalasPeriodos[i].notaMin = Double.Parse(txtAMin.Text);
                        escalasPeriodos[i].porcentajeCupos = Double.Parse(txtCuposA.Text);
                        break;
                    case "B":
                        escalasPeriodos[i].notaMax = Double.Parse(txtBMax.Text);
                        escalasPeriodos[i].notaMin = Double.Parse(txtBMin.Text);
                        escalasPeriodos[i].porcentajeCupos = Double.Parse(txtCuposB.Text);
                        break;
                    case "C":
                        escalasPeriodos[i].notaMax = Double.Parse(txtCMax.Text);
                        escalasPeriodos[i].notaMin = Double.Parse(txtCMin.Text);
                        escalasPeriodos[i].porcentajeCupos = Double.Parse(txtCuposC.Text);
                        break;
                    case "D":
                        escalasPeriodos[i].notaMax = Double.Parse(txtDMax.Text);
                        escalasPeriodos[i].notaMin = Double.Parse(txtDMin.Text);
                        escalasPeriodos[i].porcentajeCupos = Double.Parse(txtCuposD.Text);
                        break;
                    case "E":
                        escalasPeriodos[i].notaMax = Double.Parse(txtEMax.Text);
                        escalasPeriodos[i].notaMin = Double.Parse(txtEMin.Text);
                        escalasPeriodos[i].porcentajeCupos = Double.Parse(txtCuposE.Text);
                        break;
                    case "Alto":
                        escalasPeriodos[i].notaMax = Double.Parse(txtAltoMax.Text);
                        escalasPeriodos[i].notaMin = Double.Parse(txtAltoMin.Text);
                        break;
                    case "Medio":
                        escalasPeriodos[i].notaMax = Double.Parse(txtMedioMax.Text);
                        escalasPeriodos[i].notaMin = Double.Parse(txtMedioMin.Text);
                        break;
                    case "Bajo":
                        escalasPeriodos[i].notaMax = Double.Parse(txtBajoMax.Text);
                        escalasPeriodos[i].notaMin = Double.Parse(txtBajoMin.Text);
                        break;


                }
                
            }
        }


        private void actualizarPDI()
        {
            for (int i = 0; i < itemsPDIPeriodos.Count(); i++)
            {
                switch (itemsPDIPeriodos[i].itemPDI.nombre)
                {
                    case "FORTALEZAS":
                        itemsPDIPeriodos[i].notaMax = Double.Parse(txtFortalezaMax.Text);
                        itemsPDIPeriodos[i].notaMin = Double.Parse(txtFortalezaMin.Text); 
                        break;
                    case "OPORTUNIDADES DE MEJORA":
                        itemsPDIPeriodos[i].notaMax = Double.Parse(txtOportunidadMax.Text);
                        itemsPDIPeriodos[i].notaMin = Double.Parse(txtOportunidadMin.Text);
                        break;
                    case "DEBILIDADES":
                        itemsPDIPeriodos[i].notaMax = Double.Parse(txtDebilidadMax.Text);
                        itemsPDIPeriodos[i].notaMin = Double.Parse(txtDebilidadMin.Text);
                        break;
                }
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

        private void txtAMin_KeyPress(object sender, KeyPressEventArgs e)
        {
            Global.restringirADecimal(sender, e); 
        }

        private void txtBMin_KeyPress(object sender, KeyPressEventArgs e)
        {
            Global.restringirADecimal(sender, e);
        }

        private void txtCMin_KeyPress(object sender, KeyPressEventArgs e)
        {
            Global.restringirADecimal(sender, e);
        }

        private void txtDMin_KeyPress(object sender, KeyPressEventArgs e)
        {
            Global.restringirADecimal(sender, e);
        }

        private void txtAltoMin_KeyPress(object sender, KeyPressEventArgs e)
        {
            Global.restringirADecimal(sender, e);
        }

        private void txtMedioMin_KeyPress(object sender, KeyPressEventArgs e)
        {
            Global.restringirADecimal(sender, e);
        }

        private void txtFortalezaMin_KeyPress(object sender, KeyPressEventArgs e)
        {
            Global.restringirADecimal(sender, e);
        }

        private void txtOportunidadMin_KeyPress(object sender, KeyPressEventArgs e)
        {
            Global.restringirADecimal(sender, e);
        }

        private void txtCuposA_KeyPress(object sender, KeyPressEventArgs e)
        {
            Global.restringirADecimal(sender, e);
        }

        private void txtCuposB_KeyPress(object sender, KeyPressEventArgs e)
        {
            Global.restringirADecimal(sender, e);
        }

        private void txtCuposC_KeyPress(object sender, KeyPressEventArgs e)
        {
            Global.restringirADecimal(sender, e);
        }

        private void txtCuposD_KeyPress(object sender, KeyPressEventArgs e)
        {
            Global.restringirADecimal(sender, e);
        }

        private void txtCuposE_KeyPress(object sender, KeyPressEventArgs e)
        {
            Global.restringirADecimal(sender, e);
        }
    }
}
