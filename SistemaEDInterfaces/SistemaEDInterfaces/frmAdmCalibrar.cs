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
        EvaluacionDesempenhoWS.EvaluacionDesempenhoWSClient daoEvaluacionDesempenho;
        EvaluacionPotencialWS.EvaluacionPotencialWSClient daoEvaluacionPotencial;
        BindingList<GerenciaWS.gerencia> gerencias;
        BindingList<ColaboradorWS.colaborador> colaboradores;
        EscalaPeriodoWS.EscalaPeriodoWSClient daoEscalaPeriodo;
        BindingList<EscalaPeriodoWS.escalaPeriodo> escalasPeriodo;
        Hashtable escalas;
        Hashtable notasD;
        Hashtable notasP;

        public frmAdmCalibrar()
        {
            InitializeComponent();

            daoGerencia = new GerenciaWS.GerenciaWSClient();
            daoColaborador = new ColaboradorWS.ColaboradorWSClient();
            daoEvaluacionDesempenho = new EvaluacionDesempenhoWS.EvaluacionDesempenhoWSClient();
            daoEvaluacionPotencial = new EvaluacionPotencialWS.EvaluacionPotencialWSClient();
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

            this.asignaEscalaSinCalibrar();

            foreach (ColaboradorWS.colaborador c in colaboradores)
            {
                BtnColaborador btnColab = new BtnColaborador(c);
                if (c.evaluaciones[0].escalaSinCalibrar.nombre != null && c.evaluaciones[1].escalaSinCalibrar.nombre != null)
                {
                    this.nineBox.insertarBtnColaborador(btnColab, 
                        (int)escalas[c.evaluaciones[1].escalaSinCalibrar.nombre],
                        (int)escalas[c.evaluaciones[0].escalaSinCalibrar.nombre]);
                }
                else
                    this.nineBox.insertarBtnColaborador(btnColab, 0, 2);

            }
        }

        private void asignaEscalaSinCalibrar()
        {
            bool calificado = false;
            foreach (ColaboradorWS.colaborador c in colaboradores)
                if (c.evaluaciones[0].escalaSinCalibrar.idEscala == 0 && c.evaluaciones[1].escalaSinCalibrar.idEscala == 0)
                    calificado = true;
                else
                    calificado = false;
            if (calificado)
                return;

            EvaluacionDesempenhoWS.evaluacionDesempenho evalD = new EvaluacionDesempenhoWS.evaluacionDesempenho();
            EvaluacionPotencialWS.evaluacion evalP = new EvaluacionPotencialWS.evaluacion();

            int[] cupos = this.calcularCupos();
            int aux = 0;

            this.invertirArreglo();

            for (int i = 0; i < 5; i++)
            {
                for(int j = 0; j < cupos[i]; j++)
                {
                    colaboradores[aux + j].evaluaciones[1].escalaSinCalibrar.idEscala = escalasPeriodo[i].escala.idEscala;
                    colaboradores[aux + j].evaluaciones[1].escalaSinCalibrar.nombre = escalasPeriodo[i].escala.nombre;
                    colaboradores[aux + j].evaluaciones[0].escalaSinCalibrar.idEscala = colaboradores[aux + j].evaluaciones[0].escalaPreCupos.idEscala;
                    colaboradores[aux + j].evaluaciones[0].escalaSinCalibrar.nombre = colaboradores[aux + j].evaluaciones[0].escalaPreCupos.nombre;
                }
                aux += cupos[i];
            }

            for(int i = 0; i < colaboradores.Count; i++)
            {
                this.setEvalPotencial(evalP);
                evalP.idEvaluacion = colaboradores[i].evaluaciones[0].idEvaluacion;
                evalP.escalaSinCalibrar.idEscala = colaboradores[i].evaluaciones[0].escalaSinCalibrar.idEscala;
                evalP.escalaSinCalibrar.nombre = colaboradores[i].evaluaciones[0].escalaSinCalibrar.nombre;
                daoEvaluacionPotencial.actualizarEvaluacionPotencial(evalP);

                this.setEvalDesempenho(evalD);
                evalD.idEvaluacion = colaboradores[i].evaluaciones[1].idEvaluacion;
                evalD.escalaSinCalibrar.idEscala = colaboradores[i].evaluaciones[1].escalaSinCalibrar.idEscala;
                evalD.escalaSinCalibrar.nombre = colaboradores[i].evaluaciones[1].escalaSinCalibrar.nombre;
                daoEvaluacionDesempenho.actualizarEvaluacionDesempenho(evalD);
            }

        }

        private void invertirArreglo()
        {
            BindingList<ColaboradorWS.colaborador> aux = new BindingList<ColaboradorWS.colaborador>();
            for (int i = colaboradores.Count - 1; i >= 0; i--)
                aux.Add(colaboradores[i]);
            colaboradores = aux;
        }

        public void setEvalDesempenho(EvaluacionDesempenhoWS.evaluacionDesempenho evalD)
        {
            evalD.idEvaluacion = -1;
            evalD.escalaFinal = new EvaluacionDesempenhoWS.escala();
            evalD.escalaFinal.idEscala = -1;
            evalD.escalaPreCupos = new EvaluacionDesempenhoWS.escala();
            evalD.escalaPreCupos.idEscala = -1;
            evalD.escalaSinCalibrar = new EvaluacionDesempenhoWS.escala();
            evalD.escalaSinCalibrar.idEscala = -1;
            evalD.estadoPDI = -1;
            evalD.observaciones = "";
            evalD.notaAutoEval = -1;
            evalD.notaFinal = -1;
            evalD.estado = -1;
            evalD.observacionesObj = "";
            evalD.observacionesComp = "";
            evalD.notaAutoEvalComp = -1;
            evalD.notaPreviaComp = -1;
            evalD.notaFinalComp = -1;
            evalD.notaAutoEvalObj = -1;
            evalD.notaPreviaObj = -1;
            evalD.notaFinalObj = -1;
            evalD.notaPrevia = -1;
            evalD.estadoAutoEval = -1;
            evalD.estadoPlanificacion = -1;

        }
        public void setEvalPotencial(EvaluacionPotencialWS.evaluacion evalP)
        {
            evalP.idEvaluacion = -1;
            evalP.escalaFinal = new EvaluacionPotencialWS.escala();
            evalP.escalaFinal.idEscala = -1;
            evalP.escalaPreCupos = new EvaluacionPotencialWS.escala();
            evalP.escalaPreCupos.idEscala = -1;
            evalP.escalaSinCalibrar = new EvaluacionPotencialWS.escala();
            evalP.escalaSinCalibrar.idEscala = -1;
            evalP.estado = -1;
            evalP.observaciones = "";
            evalP.notaFinal = -1;
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
