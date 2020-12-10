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
        BindingList<ColaboradorWS.colaborador> colaboradores;
        EscalaPeriodoWS.EscalaPeriodoWSClient daoEscalaPeriodo;
        BindingList<EscalaPeriodoWS.escalaPeriodo> escalasPeriodo;
        Hashtable escalas;
        Hashtable notasD;
        Hashtable notasP;
        Queue<ColaboradorWS.colaborador> cola;

        public frmAdmCalibrar()
        {
            InitializeComponent();

            daoGerencia = new GerenciaWS.GerenciaWSClient();
            daoColaborador = new ColaboradorWS.ColaboradorWSClient();
            daoEscalaPeriodo = new EscalaPeriodoWS.EscalaPeriodoWSClient();

            this.nineBox.Cupos = this.dgvCupos;

            GerenciaWS.gerencia[] g = daoGerencia.listarGerencias();
            if( g != null)
            {
                gerencias = new BindingList<GerenciaWS.gerencia>(g.ToList());
                
                this.cbGerencia.DataSource = gerencias;
                this.cbGerencia.ValueMember = "idGerencia";
                this.cbGerencia.DisplayMember = "nombre";

                EscalaPeriodoWS.escalaPeriodo[] ep = daoEscalaPeriodo.listarEPXPeriodoActual();
                if(ep != null)
                {
                    escalasPeriodo = new BindingList<EscalaPeriodoWS.escalaPeriodo>(ep.ToList());
                }
                else
                {
                    MessageBox.Show("No hay cupos cargados", "Mensaje de error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
                escalas = cargarHashTable();
                

                this.llena9Box();
            }
            else
            {
                MessageBox.Show("No hay gerencias cargadas", "Mensaje de error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            

            //evaluacionDesempenho actualizar
            //Evaluacion actualizar
        }

        private int[] calcularCupos()
        {
            int suma = 0, col = colaboradores.ToList().Count;
            int[] cupos = new int[5];
            for (int i = 0; i < 4; i++)
            {
                cupos[i] = (int)Math.Round((escalasPeriodo[i].porcentajeCupos * col) / 100);
                suma += cupos[i];
            }

            cupos[4] = col - suma;

            return cupos;
        }

        private void btnBuscar_Click(object sender, EventArgs e)
        {
            this.llena9Box();
        }

        private void llena9Box()
        {
            ColaboradorWS.colaborador[] colab = daoColaborador.listarColaboradoresXGerencia9Box(
                ((GerenciaWS.gerencia)this.cbGerencia.SelectedItem).idGerencia,
                    Global.periodoActual.idPeriodo);                        

            if (colab != null)
            {
                colaboradores = new BindingList<ColaboradorWS.colaborador>(colab.ToList());

                this.dgvCupos.setCupos(this.calcularCupos());
            }
            else
            {
                MessageBox.Show("Esta gerencia no tiene Colaboradores que mostrar",
                        "Mensaje de Error", MessageBoxButtons.OK, MessageBoxIcon.Error
                     );
                return;
            }
            this.nineBox.vaciar9Box();

            int a, b;

            foreach (ColaboradorWS.colaborador c in colaboradores)
            {
                BtnColaborador btnColab = new BtnColaborador(c);
                if (c.evaluaciones[0].escalaPreCupos.nombre != null && c.evaluaciones[1].escalaPreCupos.nombre != null)
                {
                    a = (int)escalas[c.evaluaciones[1].escalaPreCupos.nombre];
                    b = (int)escalas[c.evaluaciones[0].escalaPreCupos.nombre];
                    this.nineBox.insertarBtnColaborador(btnColab,a,b);
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

    }
}
