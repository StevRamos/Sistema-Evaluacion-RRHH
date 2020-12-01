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
    public partial class frmRep9Box : Form
    {
        ColaboradorWS.ColaboradorWSClient daoColaborador;
        PeriodoWS.PeriodoWSClient daoPeriodo;
        BindingList<ColaboradorWS.colaborador> colaboradores;
        BindingList<PeriodoWS.periodo> periodos;

        public frmRep9Box()
        {
            InitializeComponent();

            this.nineBox.SetDrop(false);

            daoColaborador = new ColaboradorWS.ColaboradorWSClient();
            daoPeriodo = new PeriodoWS.PeriodoWSClient();

            this.cbPeriodo.DataSource = daoPeriodo.listarPeriodos();
            this.cbPeriodo.ValueMember = "idPeriodo";
            this.cbPeriodo.DisplayMember = "nombre";

            colaboradores = new BindingList<ColaboradorWS.colaborador>(
                daoColaborador.listarColaboradoresXJefe(
                    Global.colaboradorLoggeado.idColaborador).ToList());

            foreach (ColaboradorWS.colaborador colaborador in colaboradores)
            {
                BtnColaborador btnColab = new BtnColaborador();
                btnColab.setNombre(colaborador.nombres + " " + colaborador.apellidos);
                this.nineBox.insertarBtnColaborador(btnColab);

            }

        }

        private void flowLayoutPanel3_Paint(object sender, PaintEventArgs e)
        {

        }

        private void btnBuscar_Click(object sender, EventArgs e)
        {
            //colaboradores = daoColaborador.listarColaboradoresXJefeXPeriodo(
            //    Global.colaboradorLoggeado.idColaborador,
            //    Global.periodoActual.idPeriodo).ToList());
        }
    }
}
