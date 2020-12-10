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
    public partial class frmRepPDIColaborador : Form
    {
        ColaboradorWS.colaborador colaborador;

        public frmRepPDIColaborador()
        {
            InitializeComponent();
        }

        public ColaboradorWS.colaborador Colaborador { get => colaborador; set => colaborador = value; }
    }
}
