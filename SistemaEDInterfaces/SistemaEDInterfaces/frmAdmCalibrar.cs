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
    public partial class frmAdmCalibrar : Form
    {
        GerenciaWS.GerenciaWSClient daoGerencia;
        ColaboradorWS.ColaboradorWSClient daoColaborador;
        BindingList<GerenciaWS.gerencia> gerencias;
        BindingList<ColaboradorWS.colaborador> jefes;
        BindingList<ColaboradorWS.colaborador> colaboradores;

        public frmAdmCalibrar()
        {
            InitializeComponent();

            daoGerencia = new GerenciaWS.GerenciaWSClient();
            daoColaborador = new ColaboradorWS.ColaboradorWSClient();

            gerencias = new BindingList<GerenciaWS.gerencia>(daoGerencia.listarGerencias().ToList());
            jefes = new BindingList<ColaboradorWS.colaborador>(daoColaborador.listarJefeXGerenciaXPeriodoActual(gerencias[0].idGerencia));

            this.cbGerencia.DataSource = gerencias;
            this.cbGerencia.ValueMember = "idGerencia";
            this.cbGerencia.DisplayMember = "nombre";

            this.cbJefe.DataSource = jefes;
            this.cbJefe.ValueMember = "idColaborador";
            this.cbJefe.DisplayMember = "nombre";

        }

        private void cbJefe_Format(object sender, ListControlConvertEventArgs e)
        {
            string nombre = ((ColaboradorWS.colaborador)e.ListItem).nombres;
            string apellido = ((ColaboradorWS.colaborador)e.ListItem).apellidos;
            e.Value = nombre + " " + apellido;
        }

        private void cbGerencia_SelectedValueChanged(object sender, EventArgs e)
        {
            jefes = new BindingList<ColaboradorWS.colaborador>(daoColaborador.listarJefeXGerenciaXPeriodoActual(
                ((GerenciaWS.gerencia)this.cbGerencia.SelectedItem).idGerencia));
        }
    }
}
