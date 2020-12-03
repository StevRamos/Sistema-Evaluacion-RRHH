using SistemaEDInterfaces.ColaboradorWS;
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
    public partial class frmEvMisTrabajadoresPrevia : Form
    {
        private int idColaborador;
        private int idPeriodo;
        private int idPuestoTrabajo;
        private EstadoFormulario estado;
        private EvaluacionDesempenhoWS.EvaluacionDesempenhoWSClient daoEvaluacionDesempenho;
        private PesoCriterioWS.PesoCriterioWSClient daoPesoCriterio;
        private EvaluacionDesempenhoWS.evaluacionDesempenho evaluacionDesempenho;
        private ColaboradorWS.colaborador colaborador;

        public colaborador Colaborador { get => colaborador; set => colaborador = value; }

        public frmEvMisTrabajadoresPrevia()
        {
            InitializeComponent();
            dgvCompetencias.AutoGenerateColumns = false;
            dgvObjetivos.AutoGenerateColumns = false;
        }

        private void asignarCompetencias()
        {
            int j;
            String nombrePuestoTrabajo = Global.colaboradorLoggeado.puestoTrabajo.nombre;
            String nombrePeriodo = Global.periodoActual.nombre;

            BindingList<EvaluacionDesempenhoWS.lineaEvaluacion> lineasEv = new BindingList<EvaluacionDesempenhoWS.lineaEvaluacion>();
            //Obtener la lista de criterios evaluados para el puesto de trabajo del colaborador en el periodo actual 
            PesoCriterioWS.pesoCriterio[] lista =
                daoPesoCriterio.listarPesosCriterios((int)TipoCriterio.Competencia, nombrePuestoTrabajo, nombrePeriodo, "");
            if (lista == null) return;

            for (int i = 0; i < lista.Count(); i++)
            {

                PesoCriterioWS.pesoCriterio pc = lista[i];

                EvaluacionDesempenhoWS.lineaEvaluacion linea = new EvaluacionDesempenhoWS.lineaEvaluacion();

                linea.pesoCriterio = new EvaluacionDesempenhoWS.pesoCriterio();
                linea.pesoCriterio.idPesoCriterio = pc.idPesoCriterio;
                linea.pesoCriterio.criterio = new EvaluacionDesempenhoWS.criterio();
                linea.pesoCriterio.criterio.idCriterio = pc.criterio.idCriterio;
                linea.pesoCriterio.criterio.nombre = pc.criterio.nombre;
                linea.pesoCriterio.criterio.descripcion = pc.criterio.descripcion;
                linea.pesoCriterio.puestoTrabajo = new EvaluacionDesempenhoWS.puestoTrabajo();
                linea.pesoCriterio.puestoTrabajo.idPuestoTrabajo = pc.puestoTrabajo.idPuestoTrabajo;
                linea.pesoCriterio.puestoTrabajo.nombre = pc.puestoTrabajo.nombre;
                linea.pesoCriterio.periodo = new EvaluacionDesempenhoWS.periodo();
                linea.pesoCriterio.periodo.idPeriodo = pc.periodo.idPeriodo;
                linea.pesoCriterio.peso = pc.peso;

                //Subcriterios
                PesoCriterioWS.pesoCriterio[] temp = daoPesoCriterio.listarSubcriterios_x_CriPadre(pc.criterio.idCriterio, idPuestoTrabajo,
                                                                                            idPeriodo);
                if (temp != null)
                {
                    BindingList<PesoCriterioWS.pesoCriterio> pesos = new BindingList<PesoCriterioWS.pesoCriterio>
                                                                            (temp);

                    BindingList<EvaluacionDesempenhoWS.lineaEvaluacion> subLineasEv = new BindingList<EvaluacionDesempenhoWS.lineaEvaluacion>();

                    foreach (PesoCriterioWS.pesoCriterio ps in pesos)
                    {
                        EvaluacionDesempenhoWS.lineaEvaluacion subLinea = new EvaluacionDesempenhoWS.lineaEvaluacion();

                        subLinea.pesoCriterio = new EvaluacionDesempenhoWS.pesoCriterio();
                        subLinea.pesoCriterio.idPesoCriterio = ps.idPesoCriterio;
                        subLinea.pesoCriterio.criterio = new EvaluacionDesempenhoWS.criterio();
                        subLinea.pesoCriterio.criterio.idCriterio = ps.criterio.idCriterio;
                        subLinea.pesoCriterio.criterio.nombre = ps.criterio.nombre;
                        subLinea.pesoCriterio.criterio.descripcion = ps.criterio.descripcion;
                        subLinea.pesoCriterio.puestoTrabajo = new EvaluacionDesempenhoWS.puestoTrabajo();
                        subLinea.pesoCriterio.puestoTrabajo.idPuestoTrabajo = ps.puestoTrabajo.idPuestoTrabajo;
                        subLinea.pesoCriterio.puestoTrabajo.nombre = ps.puestoTrabajo.nombre;
                        subLinea.pesoCriterio.periodo = new EvaluacionDesempenhoWS.periodo();
                        subLinea.pesoCriterio.periodo.idPeriodo = ps.periodo.idPeriodo;
                        subLinea.pesoCriterio.peso = ps.peso;
                        subLineasEv.Add(subLinea);

                    }

                    linea.sublineasEvaluacion = subLineasEv.ToArray();
                }

                lineasEv.Add(linea);
            }
            evaluacionDesempenho.lineasEvaluacion = lineasEv.ToArray();
        }
        private void cambiarEstado(EstadoFormulario estadoNuevo)
        {
            this.estado = estadoNuevo;

            if (estadoNuevo.Equals(EstadoFormulario.Inicial))
            {
                dgvObjetivos.Columns["nota"].ReadOnly = true;
                btnGuardar.Enabled = false;
                btnEditar.Enabled = true;
                btnFinalizar.Enabled = false;
            }
            else if (estadoNuevo.Equals(EstadoFormulario.Editable))
            {
                dgvObjetivos.Columns["nota"].ReadOnly = false;
                btnGuardar.Enabled = true;
                btnEditar.Enabled = false;
                btnFinalizar.Enabled = true;
            }
            else if (estadoNuevo.Equals(EstadoFormulario.NoEditable))
            {
                dgvObjetivos.Columns["nota"].ReadOnly = true;
                btnGuardar.Enabled = false;
                btnEditar.Enabled = false;
                btnFinalizar.Enabled = false;
            }
        }
        public void actualizarLinea(EvaluacionDesempenhoWS.lineaEvaluacion linea)
        {
            //Busca linea a actualizar 

            for (int i = 0; i < evaluacionDesempenho.lineasEvaluacion.Count(); i++)
            {
                if (evaluacionDesempenho.lineasEvaluacion[i].pesoCriterio.criterio.idCriterio == linea.pesoCriterio.criterio.idCriterio)
                {
                    evaluacionDesempenho.lineasEvaluacion[i] = linea;

                    dgvCompetencias.DataSource = evaluacionDesempenho.lineasEvaluacion;
                    break;
                }
            }

        }
        private void asignarObjetivos()
        {

            BindingList<EvaluacionDesempenhoWS.objetivo> objetivos = new BindingList<EvaluacionDesempenhoWS.objetivo>();
            for (int i = 0; i < dgvObjetivos.Rows.Count; i++)
            {
                EvaluacionDesempenhoWS.objetivo objetivo =
                    dgvObjetivos.Rows[i].DataBoundItem as EvaluacionDesempenhoWS.objetivo;

                objetivos.Add(objetivo);
            }
            if (objetivos != null)
            {
                evaluacionDesempenho.objetivos = objetivos.ToArray();
            }
        }
        private void asignarDatosNoActualizables()
        {
            evaluacionDesempenho.notaAutoEvalComp = -1;
            evaluacionDesempenho.notaFinalComp = -1;
            evaluacionDesempenho.observacionesObj = "";
            evaluacionDesempenho.observacionesComp = "";
            evaluacionDesempenho.notaAutoEvalObj = -1;
            evaluacionDesempenho.notaFinalObj = -1;
            evaluacionDesempenho.notaAutoEval = -1;
            evaluacionDesempenho.observaciones = "";
            evaluacionDesempenho.estadoPDI = -1;
            evaluacionDesempenho.notaFinal = -1;
            evaluacionDesempenho.escalaFinal = new EvaluacionDesempenhoWS.escala();
            evaluacionDesempenho.escalaFinal.idEscala = -1;
            evaluacionDesempenho.escalaPreCupos = new EvaluacionDesempenhoWS.escala();
            evaluacionDesempenho.escalaPreCupos.idEscala = -1;
            evaluacionDesempenho.escalaSinCalibrar = new EvaluacionDesempenhoWS.escala();
            evaluacionDesempenho.escalaSinCalibrar.idEscala = -1;

            for (int i = 0; i < evaluacionDesempenho.lineasEvaluacion.Count(); i++)
            {

                evaluacionDesempenho.lineasEvaluacion[i].notaAutoEval = -1;
                evaluacionDesempenho.lineasEvaluacion[i].notaFinal = -1;
                evaluacionDesempenho.lineasEvaluacion[i].accionesAtomar = "";
                evaluacionDesempenho.lineasEvaluacion[i].fechaCumplimiento = DateTime.Parse("01/01/2010");
                evaluacionDesempenho.lineasEvaluacion[i].fechaCumplimientoSpecified = true;
                evaluacionDesempenho.lineasEvaluacion[i].itemPDI = new EvaluacionDesempenhoWS.itemPDI();
                evaluacionDesempenho.lineasEvaluacion[i].itemPDI.idItemPDI = -1;
                for (int j = 0; j < evaluacionDesempenho.lineasEvaluacion[i].sublineasEvaluacion.Count(); j++)
                {
                    evaluacionDesempenho.lineasEvaluacion[i].sublineasEvaluacion[j].notaAutoEval = -1;
                    evaluacionDesempenho.lineasEvaluacion[i].sublineasEvaluacion[j].notaFinal = -1;
                    evaluacionDesempenho.lineasEvaluacion[i].sublineasEvaluacion[j].accionesAtomar = "";
                    evaluacionDesempenho.lineasEvaluacion[i].sublineasEvaluacion[j].fechaCumplimiento = DateTime.Parse("01/01/2010");
                    evaluacionDesempenho.lineasEvaluacion[i].sublineasEvaluacion[j].fechaCumplimientoSpecified = true;
                    evaluacionDesempenho.lineasEvaluacion[i].sublineasEvaluacion[j].itemPDI = new EvaluacionDesempenhoWS.itemPDI();
                    evaluacionDesempenho.lineasEvaluacion[i].sublineasEvaluacion[j].itemPDI.idItemPDI = -1;
                }
            }
        }
        private void calcularNotaAutoEv()
        {
            double notaObj = 0.0, notaComp = 0.0;

            for (int i = 0; i < evaluacionDesempenho.lineasEvaluacion.Count(); i++)
            {
                notaComp += evaluacionDesempenho.lineasEvaluacion[i].notaPrevia * (evaluacionDesempenho.lineasEvaluacion[i].pesoCriterio.peso / 100);
            }
            for (int i = 0; i < evaluacionDesempenho.objetivos.Count(); i++)
            {
                notaObj += (evaluacionDesempenho.objetivos[i].notaPrevia / evaluacionDesempenho.objetivos[i].meta) * (evaluacionDesempenho.objetivos[i].peso / 100);
            }
            evaluacionDesempenho.notaPreviaComp = Math.Round(notaComp);
            evaluacionDesempenho.notaPreviaObj = Math.Round(notaObj,2);
        }

        private void btnGuardar_Click(object sender, EventArgs e)
        {
            //Verificar si se deben registrar o actualizar las lineas de evaluacion 
            bool seRegistra = evaluacionDesempenho.estadoAutoEval.Equals(0) && evaluacionDesempenho.estado.Equals(0);
            //Obtener la lista de objetivos del dgv 
            asignarObjetivos();
            //Se marca los datos que no se actualizaran 
            asignarDatosNoActualizables();
            //calcular la notaAutoEvalObj y notaAutoEvalComp 
            calcularNotaAutoEv();
            //cambiar el estado de la evaluacionDesemepenho 
            evaluacionDesempenho.estado = (int)EstadoEvD.PrevIniciada;
            //Se actualiza 
            int resultado = 0;
            if (seRegistra) resultado = daoEvaluacionDesempenho.insertarLineasEvaluacionDesempenho(evaluacionDesempenho);
            else resultado = daoEvaluacionDesempenho.actualizarEvaluacionDesempenho(evaluacionDesempenho);
            if (resultado == 0)
            {
                MessageBox.Show("Ocurrio un error, intentelo nuevamente",
                    "Mensaje de Error", MessageBoxButtons.OK,
                     MessageBoxIcon.Error);
                return;
            }
            MessageBox.Show("Se guardaron los cambios",
            "Mensaje Informativo", MessageBoxButtons.OK,
            MessageBoxIcon.Information);
            double notaObj;
            notaObj = evaluacionDesempenho.notaPreviaObj * 100;
            txtNotaCompetencias.Text = evaluacionDesempenho.notaPreviaComp.ToString();
            txtNotaObjetivos.Text = notaObj.ToString();
            cambiarEstado(EstadoFormulario.Inicial);
        }

        private void btnRegresar_Click(object sender, EventArgs e)
        {
            if (estado.Equals(EstadoFormulario.Editable)){
                var result = MessageBox.Show("¿Esta seguro que desea salir? No se guardarán los cambios",
                 "Mensaje de Advertencia", MessageBoxButtons.YesNo,
                 MessageBoxIcon.Information);
            }
            if(DialogResult == DialogResult.Yes)
            {
                Global.formPrincipal.cerrarFormularioHijo(); 
            }
        }

        private void btnSeleccionar_Click(object sender, EventArgs e)
        {
            if (dgvCompetencias.CurrentCell == null)
            {
                MessageBox.Show("Debe seleccionar una competencia.",
                                   "Mensaje de error",
                                   MessageBoxButtons.OK,
                                   MessageBoxIcon.Error);
                return;
            }
            EvaluacionDesempenhoWS.lineaEvaluacion lineaSeleccionada = (EvaluacionDesempenhoWS.lineaEvaluacion)
                                                                                dgvCompetencias.CurrentRow.DataBoundItem;

            frmEvMisTrabajadoresPreviaCompetencias form = new frmEvMisTrabajadoresPreviaCompetencias();
            form.Linea = lineaSeleccionada;
            form.FormPadre = this;
            form.Estado = estado;
            Global.formPrincipal.abrirFormularioHijo(false, form);

        }

        private void btnFinalizar_Click(object sender, EventArgs e)
        {
            var result = MessageBox.Show("¿Desea finalizar la evaluación?",
                 "Mensaje de Pregunta", MessageBoxButtons.YesNo,
                 MessageBoxIcon.Information);

            if (result == DialogResult.Yes)
            {
                //Verificar si se deben registrar o actualizar las lineas de evaluacion 
                bool seRegistra = evaluacionDesempenho.estadoAutoEval.Equals(0) && evaluacionDesempenho.estado.Equals(0);
                //Obtener la lista de objetivos del dgv 
                asignarObjetivos();
                //Se marca los datos que no se actualizaran 
                asignarDatosNoActualizables();
                //calcular la notaAutoEvalObj y notaAutoEvalComp 
                calcularNotaAutoEv();
                //cambiar el estado de la evaluacionDesemepenho 
                evaluacionDesempenho.estado = (int)EstadoEvD.PrevFinalizada;
                //Se actualiza 
                int resultado = 0;
                if (seRegistra) resultado = daoEvaluacionDesempenho.insertarLineasEvaluacionDesempenho(evaluacionDesempenho);
                else resultado = daoEvaluacionDesempenho.actualizarEvaluacionDesempenho(evaluacionDesempenho);
                if (resultado == 0)
                {
                    MessageBox.Show("Ocurrio un error, intentelo nuevamente",
                        "Mensaje de Error", MessageBoxButtons.OK,
                         MessageBoxIcon.Error);
                    return;
                }
                MessageBox.Show("Ha finalizado la autoevaluación",
                "Mensaje Informativo", MessageBoxButtons.OK,
                MessageBoxIcon.Information);
                double notaObj;
                notaObj = evaluacionDesempenho.notaPreviaObj * 100;
                txtNotaCompetencias.Text = evaluacionDesempenho.notaPreviaComp.ToString();
                txtNotaObjetivos.Text = notaObj.ToString();
                cambiarEstado(EstadoFormulario.NoEditable);
            }
        }

        private void dgvCompetencias_CellFormatting(object sender, DataGridViewCellFormattingEventArgs e)
        {
            EvaluacionDesempenhoWS.lineaEvaluacion data = dgvCompetencias.Rows[e.RowIndex].DataBoundItem as EvaluacionDesempenhoWS.lineaEvaluacion;
            dgvCompetencias.Rows[e.RowIndex].Cells["ID"].Value = data.pesoCriterio.criterio.idCriterio;
            dgvCompetencias.Rows[e.RowIndex].Cells["nombre"].Value = data.pesoCriterio.criterio.nombre;
            dgvCompetencias.Rows[e.RowIndex].Cells["DescripcionComp"].Value = data.pesoCriterio.criterio.descripcion;
            dgvCompetencias.Rows[e.RowIndex].Cells["PesoComp"].Value = data.pesoCriterio.peso;
        }

        private void frmEvMisTrabajadoresPrevia_Load(object sender, EventArgs e)
        {
            daoEvaluacionDesempenho = new EvaluacionDesempenhoWS.EvaluacionDesempenhoWSClient();
            daoPesoCriterio = new PesoCriterioWS.PesoCriterioWSClient();
            idColaborador = colaborador.idColaborador;
            idPuestoTrabajo = colaborador.puestoTrabajo.idPuestoTrabajo;
            idPeriodo = Global.periodoActual.idPeriodo;

            evaluacionDesempenho = daoEvaluacionDesempenho.obtenerEvaluacionDesempenho(idColaborador, idPeriodo);
            // Evaluacion previa No iniciada
            if (evaluacionDesempenho.estado.Equals(0) && evaluacionDesempenho.estadoAutoEval.Equals(0))
            {
                //Se deben asignar las competencias y subcompetencias 
                asignarCompetencias();
            }
            //Si ha sido iniciada 
            else
            {
                double notaObj;
                notaObj = evaluacionDesempenho.notaPreviaObj * 100;
                txtNotaCompetencias.Text = evaluacionDesempenho.notaPreviaComp.ToString();
                txtNotaObjetivos.Text = notaObj.ToString();
            }

            dgvObjetivos.DataSource = evaluacionDesempenho.objetivos;
            dgvCompetencias.DataSource = evaluacionDesempenho.lineasEvaluacion;
            cambiarEstado(EstadoFormulario.Inicial);
        }

        private void btnEditar_Click(object sender, EventArgs e)
        {
            cambiarEstado(EstadoFormulario.Editable);
        }
    }
}
