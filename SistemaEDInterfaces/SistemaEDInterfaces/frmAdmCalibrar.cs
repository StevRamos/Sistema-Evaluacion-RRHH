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
        EscalaPeriodoWS.EscalaPeriodoWSClient daoEscalaPeriodo;
        BindingList<EscalaPeriodoWS.escalaPeriodo> escalasPeriodo;

        public frmAdmCalibrar()
        {
            InitializeComponent();

            daoGerencia = new GerenciaWS.GerenciaWSClient();
            daoColaborador = new ColaboradorWS.ColaboradorWSClient();
            daoEscalaPeriodo = new EscalaPeriodoWS.EscalaPeriodoWSClient();

            gerencias = new BindingList<GerenciaWS.gerencia>(daoGerencia.listarGerencias().ToList());
            jefes = new BindingList<ColaboradorWS.colaborador>(daoColaborador.listarJefeXGerenciaXPeriodoActual(gerencias[0].idGerencia).ToList());
            escalasPeriodo = new BindingList<EscalaPeriodoWS.escalaPeriodo>(daoEscalaPeriodo.listarXPeriodoActual().ToList());

            this.cbGerencia.DataSource = gerencias;
            this.cbGerencia.ValueMember = "idGerencia";
            this.cbGerencia.DisplayMember = "nombre";

            if( jefes != null || jefes.Count != 0)
            {
                this.cbJefe.DataSource = jefes;
                this.cbJefe.ValueMember = "idColaborador";
                this.cbJefe.DisplayMember = "nombre";
            }

            this.dgvCupos.DataSource = escalasPeriodo;
        }

        private void cbJefe_Format(object sender, ListControlConvertEventArgs e)
        {
            string nombre = ((ColaboradorWS.colaborador)e.ListItem).nombres;
            string apellido = ((ColaboradorWS.colaborador)e.ListItem).apellidos;
            e.Value = nombre + " " + apellido;
        }

        private void cbGerencia_SelectedValueChanged(object sender, EventArgs e)
        {
            BindingList<ColaboradorWS.colaborador> aux = new BindingList<ColaboradorWS.colaborador>(
                daoColaborador.listarJefeXGerenciaXPeriodoActual(
                ((GerenciaWS.gerencia)this.cbGerencia.SelectedItem).idGerencia));

            if( aux == null )
            {
                MessageBox.Show("Esta gerencia no tiene jefes disponibles",
                    "Mensaje de error",
                    MessageBoxButtons.OK,
                    MessageBoxIcon.Error);
                return;
            }

            jefes = aux;
        }
    }
}
