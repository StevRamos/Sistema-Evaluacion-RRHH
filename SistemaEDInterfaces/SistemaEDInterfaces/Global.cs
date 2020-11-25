using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace SistemaEDInterfaces
{
    public static class Global
    {
        public static frmInicio formPrincipal;
        public static PeriodoWS.periodo periodoActual;
        public static ColaboradorWS.colaborador colaboradorLoggeado;

        public static void restringirADecimal(object sender, KeyPressEventArgs e)
        {
            if (!char.IsControl(e.KeyChar) && !char.IsDigit(e.KeyChar) &&
            (e.KeyChar != '.'))
            {
                e.Handled = true;
            }

            // Solo permitir un punto decimal
            if ((e.KeyChar == '.') && ((sender as TextBox).Text.IndexOf('.') > -1))
            {
                e.Handled = true;
            }
        }

        public static void iniciarEspera(Form form)
        {
            form.Cursor = Cursors.WaitCursor; 
        }
        public static void terminarEspera(Form form)
        {
            form.Cursor = Cursors.Default;
        }


    }
}
