using System;
using System.Collections;
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
        Hashtable escalas;

        public frmRep9Box()
        {
            InitializeComponent();

            this.nineBox.SetDrop(false);

            daoColaborador = new ColaboradorWS.ColaboradorWSClient();
            daoPeriodo = new PeriodoWS.PeriodoWSClient();

            PeriodoWS.periodo[] p = daoPeriodo.listarPeriodos();
            if (p != null)
                periodos = new BindingList<PeriodoWS.periodo>(p.ToList());

            this.cbPeriodo.DataSource = daoPeriodo.listarPeriodos();
            this.cbPeriodo.ValueMember = "idPeriodo";
            this.cbPeriodo.DisplayMember = "nombre";

            escalas = cargarHashTable();

            ColaboradorWS.colaborador[] colab = daoColaborador.listarColaboradoresXJefeXPeriodo(
                Global.colaboradorLoggeado.idColaborador,
                Global.periodoActual.idPeriodo);

            if (colab != null)
                colaboradores = new BindingList<ColaboradorWS.colaborador>(colab.ToList());

            this.llena9Box();
        }


        private void btnBuscar_Click(object sender, EventArgs e)
        {
            this.llena9Box();
        }

        private void llena9Box()
        {
            ColaboradorWS.colaborador[] colab = daoColaborador.listarColaboradoresXJefeXPeriodo(
                Global.colaboradorLoggeado.idColaborador,
                ((PeriodoWS.periodo)cbPeriodo.SelectedItem).idPeriodo);
            if (colab != null)
                colaboradores = new BindingList<ColaboradorWS.colaborador>(colab.ToList());

            this.nineBox.vaciar9Box();

            foreach (ColaboradorWS.colaborador c in colaboradores)
            {
                if(c.evaluaciones != null)
                {
                    BtnColaborador btnColab = new BtnColaborador(c);
                    if (c.evaluaciones[1].escalaFinal.nombre != null && c.evaluaciones[0].escalaFinal.nombre != null)
                    {
                        this.nineBox.insertarBtnColaborador(btnColab,
                            (int)escalas[c.evaluaciones[1].escalaFinal.nombre],
                            (int)escalas[c.evaluaciones[0].escalaFinal.nombre]);
                    }
                    else
                        this.nineBox.insertarBtnColaborador(btnColab, 0, 2);

                }
                else
                {
                    MessageBox.Show("Hay colaboradores que no tienen evaluaciones en este periodo",
                        "Mensaje de error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    break;
                }

                
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
