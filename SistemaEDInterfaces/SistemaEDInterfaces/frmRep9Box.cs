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

        BindingList<ColaboradorWS.colaborador> colaboradores;

        public frmRep9Box()
        {
            InitializeComponent();

            ColaboradorWS.ColaboradorWSClient daoColaborador = new ColaboradorWS.ColaboradorWSClient();

            //colaboradores = new BindingList<ColaboradorWS.colaborador>(
            //    daoColaborador.listarColaboradoresXJefe(
            //        Global.colaboradorLoggeado.idColaborador).ToList());

            //colaboradores = new BindingList<ColaboradorWS.colaborador>(daoColaborador.listarColaboradoresXJefe(1).ToList()); //pa cambiar el harcodeo

            //foreach (ColaboradorWS.colaborador colaborador in colaboradores)
            //{
            //    BtnColaborador btnColab = new BtnColaborador();
            //    btnColab.setNombre(colaborador.nombres + " " + colaborador.apellidos);
            //    this.nineBox.insertarBtnColaborador(btnColab);

            //}

        }

        private void flowLayoutPanel3_Paint(object sender, PaintEventArgs e)
        {

        }
    }
}
