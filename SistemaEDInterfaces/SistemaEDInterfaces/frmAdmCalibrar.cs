using System;
using System.Collections.Generic;
using System.Collections;
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
        Hashtable escalas;
        Queue<ColaboradorWS.colaborador> cola;

        public frmAdmCalibrar()
        {
            InitializeComponent();

            daoGerencia = new GerenciaWS.GerenciaWSClient();
            daoColaborador = new ColaboradorWS.ColaboradorWSClient();
            daoEscalaPeriodo = new EscalaPeriodoWS.EscalaPeriodoWSClient();

            gerencias = new BindingList<GerenciaWS.gerencia>(daoGerencia.listarGerencias().ToList());
            jefes = new BindingList<ColaboradorWS.colaborador>(daoColaborador.listarJefeXGerenciaXPeriodoActual(gerencias[0].idGerencia).ToList());
            escalasPeriodo = new BindingList<EscalaPeriodoWS.escalaPeriodo>(daoEscalaPeriodo.listarEPXPeriodoActual().ToList());
            escalas = cargarHashTable();


            this.cbGerencia.DataSource = gerencias;
            this.cbGerencia.ValueMember = "idGerencia";
            this.cbGerencia.DisplayMember = "nombre";

            if( jefes != null || jefes.Count != 0)
            {
                this.cbJefe.DataSource = jefes;
                this.cbJefe.ValueMember = "idColaborador";
                this.cbJefe.DisplayMember = "nombre";
            }

            colaboradores = new BindingList<ColaboradorWS.colaborador>(
                daoColaborador.listarColaboradoresXJefe9Box(
                    ((ColaboradorWS.colaborador)this.cbJefe.SelectedItem).idColaborador,
                    Global.periodoActual.idPeriodo).ToList());
            
            foreach (ColaboradorWS.colaborador c in colaboradores)
            {
                BtnColaborador btnColab = new BtnColaborador(c);
                if (c.evaluaciones[0].escalaPreCupos.nombre != null && c.evaluaciones[1].escalaPreCupos.nombre != null)
                {
                    this.nineBox.insertarBtnColaborador(btnColab,
                        (int)escalas[c.evaluaciones[1].escalaPreCupos.nombre],
                        (int)escalas[c.evaluaciones[0].escalaPreCupos.nombre]);
                }
                else
                    this.nineBox.insertarBtnColaborador(btnColab, 0, 2);
            }

            this.dgvCupos.setCupos(this.calcularCupos());
            this.dgvCupos.NumeroColab = this.nineBox.Colab;

            this.dgvCupos.Location = new Point(710, 60);
            
        }

        private int[] calcularCupos()
        {
            int[] cupos = new int[5];
            for (int i = 0; i < 5; i++)
                cupos[i] = (int)Math.Round((escalasPeriodo[i].porcentajeCupos * colaboradores.ToList().Count) / 100);

            return cupos;
        }

        private void cbJefe_Format(object sender, ListControlConvertEventArgs e)
        {
            string nombre = ((ColaboradorWS.colaborador)e.ListItem).nombres;
            string apellido = ((ColaboradorWS.colaborador)e.ListItem).apellidos;
            e.Value = nombre + " " + apellido;
        }

        private void cbGerencia_SelectedValueChanged(object sender, EventArgs e)
        {
            BindingList<ColaboradorWS.colaborador> aux = jefes;

            try
            {
                aux = new BindingList<ColaboradorWS.colaborador>(
                    daoColaborador.listarJefeXGerenciaXPeriodoActual(
                    ((GerenciaWS.gerencia)this.cbGerencia.SelectedItem).idGerencia));
            }
            catch(Exception ex)
            {
                MessageBox.Show("Esta gerencia no tiene jefes disponibles",
                    "Mensaje de error",
                    MessageBoxButtons.OK,
                    MessageBoxIcon.Error);
                return;
            }

            jefes = aux;
        }

        private void btnBuscar_Click(object sender, EventArgs e)
        {
            colaboradores = new BindingList<ColaboradorWS.colaborador>(
                daoColaborador.listarColaboradoresXJefe9Box(
                    ((ColaboradorWS.colaborador)this.cbJefe.SelectedItem).idColaborador,
                    Global.periodoActual.idPeriodo).ToList());

            this.nineBox.vaciar9Box();

            foreach (ColaboradorWS.colaborador c in colaboradores)
            {
                BtnColaborador btnColab = new BtnColaborador(c);
                if (c.evaluaciones[0].escalaPreCupos.nombre != null && c.evaluaciones[1].escalaPreCupos.nombre != null)
                {
                    this.nineBox.insertarBtnColaborador(btnColab,
                        (int)escalas[c.evaluaciones[1].escalaPreCupos.nombre],
                        (int)escalas[c.evaluaciones[0].escalaPreCupos.nombre]);
                }
                else
                    this.nineBox.insertarBtnColaborador(btnColab, 0, 2);

            }

        }

        private Hashtable cargarHashTable()
        {
            Hashtable ret = new Hashtable();

            ret.Add("A", 4);
            ret.Add("B", 3);
            ret.Add("C", 2);
            ret.Add("D", 1);
            ret.Add("E", 0);
            ret.Add("Alto", 0);
            ret.Add("Medio", 1);
            ret.Add("Bajo", 2);

            return ret;
        }

        private void gbCupos_Enter(object sender, EventArgs e)
        {

        }

        private void dgvCupos_Load(object sender, EventArgs e)
        {

        }
    }
}
