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
    public partial class frmEvMisTrabajadoresEvPotencial : Form
    {
        private int idColaborador;
        private int idPeriodo;
        private int idPuestoTrabajo;
        private EstadoFormulario estado;
        private PeriodoWS.PeriodoWSClient daoPeriodo;
        private PeriodoWS.periodo periodo;
        private EvaluacionPotencialWS.EvaluacionPotencialWSClient daoEvaluacionPotencial;
        private PesoCriterioWS.PesoCriterioWSClient daoPesoCriterio;
        private EvaluacionPotencialWS.evaluacion evaluacionPotencial;
        private ColaboradorWS.colaborador colaborador;

        public colaborador Colaborador { get => colaborador; set => colaborador = value; }
        public frmEvMisTrabajadoresEvPotencial()
        {
            InitializeComponent();
            dgvPotenciales.AutoGenerateColumns = false;
            periodo = Global.periodoActual;
        }


        private void asignarPotenciales()
        {
            int j;
            String nombrePuestoTrabajo = Global.colaboradorLoggeado.puestoTrabajo.nombre;
            String nombrePeriodo = Global.periodoActual.nombre;

            BindingList<EvaluacionPotencialWS.lineaEvaluacion> lineasEv = new BindingList<EvaluacionPotencialWS.lineaEvaluacion>();
            //Obtener la lista de criterios evaluados para el puesto de trabajo del colaborador en el periodo actual 
            PesoCriterioWS.pesoCriterio[] lista =
                daoPesoCriterio.listarPesosCriterios((int)TipoCriterio.Potencial, nombrePuestoTrabajo, nombrePeriodo, "");
            if (lista == null) return;

            for (int i = 0; i < lista.Count(); i++)
            {

                PesoCriterioWS.pesoCriterio pc = lista[i];

                EvaluacionPotencialWS.lineaEvaluacion linea = new EvaluacionPotencialWS.lineaEvaluacion();

                linea.pesoCriterio = new EvaluacionPotencialWS.pesoCriterio();
                linea.pesoCriterio.idPesoCriterio = pc.idPesoCriterio;
                linea.pesoCriterio.criterio = new EvaluacionPotencialWS.criterio();
                linea.pesoCriterio.criterio.idCriterio = pc.criterio.idCriterio;
                linea.pesoCriterio.criterio.nombre = pc.criterio.nombre;
                linea.pesoCriterio.criterio.descripcion = pc.criterio.descripcion;
                linea.pesoCriterio.puestoTrabajo = new EvaluacionPotencialWS.puestoTrabajo();
                linea.pesoCriterio.puestoTrabajo.idPuestoTrabajo = pc.puestoTrabajo.idPuestoTrabajo;
                linea.pesoCriterio.puestoTrabajo.nombre = pc.puestoTrabajo.nombre;
                linea.pesoCriterio.periodo = new EvaluacionPotencialWS.periodo();
                linea.pesoCriterio.periodo.idPeriodo = pc.periodo.idPeriodo;
                linea.pesoCriterio.peso = pc.peso;

                //Subcriterios
                PesoCriterioWS.pesoCriterio[] temp = daoPesoCriterio.listarSubcriterios_x_CriPadre(pc.criterio.idCriterio, idPuestoTrabajo,
                                                                                            idPeriodo);
                if (temp != null)
                {
                    BindingList<PesoCriterioWS.pesoCriterio> pesos = new BindingList<PesoCriterioWS.pesoCriterio>
                                                                            (temp);

                    BindingList<EvaluacionPotencialWS.lineaEvaluacion> subLineasEv = new BindingList<EvaluacionPotencialWS.lineaEvaluacion>();

                    foreach (PesoCriterioWS.pesoCriterio ps in pesos)
                    {
                        EvaluacionPotencialWS.lineaEvaluacion subLinea = new EvaluacionPotencialWS.lineaEvaluacion();

                        subLinea.pesoCriterio = new EvaluacionPotencialWS.pesoCriterio();
                        subLinea.pesoCriterio.idPesoCriterio = ps.idPesoCriterio;
                        subLinea.pesoCriterio.criterio = new EvaluacionPotencialWS.criterio();
                        subLinea.pesoCriterio.criterio.idCriterio = ps.criterio.idCriterio;
                        subLinea.pesoCriterio.criterio.nombre = ps.criterio.nombre;
                        subLinea.pesoCriterio.criterio.descripcion = ps.criterio.descripcion;
                        subLinea.pesoCriterio.puestoTrabajo = new EvaluacionPotencialWS.puestoTrabajo();
                        subLinea.pesoCriterio.puestoTrabajo.idPuestoTrabajo = ps.puestoTrabajo.idPuestoTrabajo;
                        subLinea.pesoCriterio.puestoTrabajo.nombre = ps.puestoTrabajo.nombre;
                        subLinea.pesoCriterio.periodo = new EvaluacionPotencialWS.periodo();
                        subLinea.pesoCriterio.periodo.idPeriodo = ps.periodo.idPeriodo;
                        subLinea.pesoCriterio.peso = ps.peso;
                        subLineasEv.Add(subLinea);

                    }

                    linea.sublineasEvaluacion = subLineasEv.ToArray();
                }

                lineasEv.Add(linea);
            }
            evaluacionPotencial.lineasEvaluacion = lineasEv.ToArray();
        }

        private void cambiarEstado(EstadoFormulario estadoNuevo)
        {
            this.estado = estadoNuevo;

            if (estadoNuevo.Equals(EstadoFormulario.Inicial))
            {
                dgvPotenciales.Columns["notaFinal"].ReadOnly = true;
                btnGuardar.Enabled = false;
                btnEditar.Enabled = true;
                btnFinalizar.Enabled = false;
                txtObservaciones.Enabled = false;
            }
            else if (estadoNuevo.Equals(EstadoFormulario.Editable))
            {
                dgvPotenciales.Columns["notaFinal"].ReadOnly = false;
                btnGuardar.Enabled = true;
                btnEditar.Enabled = false;
                btnFinalizar.Enabled = true;
                txtObservaciones.Enabled = true;
            }
            else if (estadoNuevo.Equals(EstadoFormulario.NoEditable))
            {
                dgvPotenciales.Columns["notaFinal"].ReadOnly = true;
                btnGuardar.Enabled = false;
                btnEditar.Enabled = false;
                btnFinalizar.Enabled = false;
                txtObservaciones.Enabled = false;
            }
        }

        public void actualizarLinea(EvaluacionPotencialWS.lineaEvaluacion linea)
        {
            //Busca linea a actualizar 

            for (int i = 0; i < evaluacionPotencial.lineasEvaluacion.Count(); i++)
            {
                if (evaluacionPotencial.lineasEvaluacion[i].pesoCriterio.criterio.idCriterio == linea.pesoCriterio.criterio.idCriterio)
                {
                    evaluacionPotencial.lineasEvaluacion[i] = linea;

                    dgvPotenciales.DataSource = evaluacionPotencial.lineasEvaluacion;
                    break;
                }
            }

        }

        private void asignarDatosNoActualizables()
        {
            evaluacionPotencial.observaciones = "";
            evaluacionPotencial.estadoPDI = -1;


            for (int i = 0; i < evaluacionPotencial.lineasEvaluacion.Count(); i++)
            {

                evaluacionPotencial.lineasEvaluacion[i].accionesAtomar = "";
                evaluacionPotencial.lineasEvaluacion[i].fechaCumplimiento = DateTime.Parse("01/01/2010");
                evaluacionPotencial.lineasEvaluacion[i].fechaCumplimientoSpecified = true;
                evaluacionPotencial.lineasEvaluacion[i].itemPDI = new EvaluacionPotencialWS.itemPDI();
                evaluacionPotencial.lineasEvaluacion[i].itemPDI.idItemPDI = -1;
                for (int j = 0; j < evaluacionPotencial.lineasEvaluacion[i].sublineasEvaluacion.Count(); j++)
                {
                    evaluacionPotencial.lineasEvaluacion[i].sublineasEvaluacion[j].accionesAtomar = "";
                    evaluacionPotencial.lineasEvaluacion[i].sublineasEvaluacion[j].fechaCumplimiento = DateTime.Parse("01/01/2010");
                    evaluacionPotencial.lineasEvaluacion[i].sublineasEvaluacion[j].fechaCumplimientoSpecified = true;
                    evaluacionPotencial.lineasEvaluacion[i].sublineasEvaluacion[j].itemPDI = new EvaluacionPotencialWS.itemPDI();
                    evaluacionPotencial.lineasEvaluacion[i].sublineasEvaluacion[j].itemPDI.idItemPDI = -1;
                }
            }
        }
        private void calcularNotaFinal()
        {
            double  notaPot = 0.0;

            for (int i = 0; i < evaluacionPotencial.lineasEvaluacion.Count(); i++)
            {
                notaPot += evaluacionPotencial.lineasEvaluacion[i].notaFinal * (evaluacionPotencial.lineasEvaluacion[i].pesoCriterio.peso / 100);
            }
            evaluacionPotencial.notaFinal = Math.Round(notaPot,2);
        }


        private void asignarEscala()
        {
            evaluacionPotencial.escalaPreCupos = new EvaluacionPotencialWS.escala();
            evaluacionPotencial.escalaSinCalibrar = new EvaluacionPotencialWS.escala();
            evaluacionPotencial.escalaFinal = new EvaluacionPotencialWS.escala();
            PeriodoWS.escalaPeriodo[] lista = daoPeriodo.listarEscalaPeriodo(periodo.idPeriodo);
            BindingList<PeriodoWS.escalaPeriodo> escalasPeriodos;
            if (lista != null)
            {
                escalasPeriodos = new BindingList<PeriodoWS.escalaPeriodo>(lista);
                foreach (PeriodoWS.escalaPeriodo ep in escalasPeriodos)
                {
                    if (((evaluacionPotencial.notaFinal * 100) < ep.notaMax &&
                        (evaluacionPotencial.notaFinal * 100) >= ep.notaMin && ep.escala.tipo) || ((evaluacionPotencial.notaFinal * 100) == ep.notaMax && ep.escala.nombre == "Alto"))
                    {
                        evaluacionPotencial.escalaPreCupos.idEscala = ep.escala.idEscala;
                        evaluacionPotencial.escalaPreCupos.nombre = ep.escala.nombre;
                        evaluacionPotencial.escalaSinCalibrar.idEscala = ep.escala.idEscala;
                        evaluacionPotencial.escalaSinCalibrar.nombre = ep.escala.nombre;
                        evaluacionPotencial.escalaFinal.idEscala = ep.escala.idEscala;
                        evaluacionPotencial.escalaFinal.nombre = ep.escala.nombre;
                    }
                }
            }

        }


        private void btnRegresar_Click(object sender, EventArgs e)
        {
            if (estado.Equals(EstadoFormulario.Editable))
            {
                var result = MessageBox.Show("¿Esta seguro que desea salir? No se guardarán los cambios",
                 "Mensaje de Advertencia", MessageBoxButtons.YesNo,
                 MessageBoxIcon.Information);
            }
            if (DialogResult == DialogResult.Yes)
            {
                Global.formPrincipal.cerrarFormularioHijo();
            }
        }

        private void btnSeleccionar_Click(object sender, EventArgs e)
        {
            if (dgvPotenciales.CurrentCell == null)
            {
                MessageBox.Show("Debe seleccionar una competencia.",
                                   "Mensaje de error",
                                   MessageBoxButtons.OK,
                                   MessageBoxIcon.Error);
                return;
            }
            EvaluacionPotencialWS.lineaEvaluacion lineaSeleccionada = (EvaluacionPotencialWS.lineaEvaluacion)
                                                                                dgvPotenciales.CurrentRow.DataBoundItem;

            frmEvMisTrabajadoresPotenciales form = new frmEvMisTrabajadoresPotenciales();
            form.Linea = lineaSeleccionada;
            form.FormPadre = this;
            form.Estado = estado;
            Global.formPrincipal.abrirFormularioHijo(false, form);

        }

        private void btnGuardar_Click(object sender, EventArgs e)
        {
            //Verificar si se deben registrar o actualizar las lineas de evaluacion 
            bool seRegistra = evaluacionPotencial.estado.Equals(0);
            //Se marca los datos que no se actualizaran 
            asignarDatosNoActualizables();
            //calcular la notaAutoEvalObj y notaAutoEvalComp 
            calcularNotaFinal();
            //cambiar el estado de la evaluacionPotencial 
            evaluacionPotencial.estado = (int)EstadoEvalPot.Iniciada;
            //Asignar escala 
            asignarEscala();
            //Asignar observaciones 
            evaluacionPotencial.observaciones = txtObservaciones.Text; 
            //Se actualiza 
            int resultado = 0;
            if (seRegistra) resultado = daoEvaluacionPotencial.insertarLineasEvaluacionPotencial(evaluacionPotencial);
            else resultado = daoEvaluacionPotencial.actualizarEvaluacionPotencial(evaluacionPotencial);
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
            txtNotaPotencial.Text = evaluacionPotencial.escalaFinal.nombre;
            cambiarEstado(EstadoFormulario.Inicial);
        }

        private void btnFinalizar_Click(object sender, EventArgs e)
        {
            var result = MessageBox.Show("¿Desea finalizar la evaluación?",
                 "Mensaje de Pregunta", MessageBoxButtons.YesNo,
                 MessageBoxIcon.Information);

            if (result == DialogResult.Yes)
            {
                //Verificar si se deben registrar o actualizar las lineas de evaluacion 
                bool seRegistra = evaluacionPotencial.estado.Equals(0);
                //Se marca los datos que no se actualizaran 
                asignarDatosNoActualizables();
                //calcular la notaAutoEvalObj y notaAutoEvalComp 
                calcularNotaFinal();
                //cambiar el estado de la evaluacionPotencial 
                evaluacionPotencial.estado = (int)EstadoEvalPot.Finalizada;
                //Asignar escala 
                asignarEscala();
                //Asignar observaciones 
                evaluacionPotencial.observaciones = txtObservaciones.Text;
                //Se actualiza 
                int resultado = 0;
                if (seRegistra) resultado = daoEvaluacionPotencial.insertarLineasEvaluacionPotencial(evaluacionPotencial);
                else resultado = daoEvaluacionPotencial.actualizarEvaluacionPotencial(evaluacionPotencial);
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
                txtNotaPotencial.Text = evaluacionPotencial.escalaFinal.nombre;
                cambiarEstado(EstadoFormulario.NoEditable);
            }
        }

        private void btnEditar_Click(object sender, EventArgs e)
        {
            cambiarEstado(EstadoFormulario.Editable);
        }

        private void frmEvMisTrabajadoresEvPotencial_Load(object sender, EventArgs e)
        {
            daoEvaluacionPotencial = new EvaluacionPotencialWS.EvaluacionPotencialWSClient();
            daoPesoCriterio = new PesoCriterioWS.PesoCriterioWSClient();
            daoPeriodo = new PeriodoWS.PeriodoWSClient();
            idColaborador = colaborador.idColaborador;
            //idPuestoTrabajo = colaborador.puestoTrabajo.idPuestoTrabajo;
            idPuestoTrabajo = 1;
            idPeriodo = Global.periodoActual.idPeriodo;

            evaluacionPotencial = daoEvaluacionPotencial.obtenerEvaluacionPotencial(idColaborador, idPeriodo);
            // Evaluacion  No iniciada
            if (evaluacionPotencial.estado.Equals(0))
            {
                //Se deben asignar los potenciales
                asignarPotenciales();
            }
            //Si ha sido iniciada 
            else if (evaluacionPotencial.estado == (int)EstadoEvalPot.Iniciada|| evaluacionPotencial.estado == (int)EstadoEvalPot.Finalizada)
            {
                txtNotaPotencial.Text = evaluacionPotencial.escalaFinal.nombre;
                txtObservaciones.Text = evaluacionPotencial.observaciones;
            }


            dgvPotenciales.DataSource = evaluacionPotencial.lineasEvaluacion;
            cambiarEstado(EstadoFormulario.Inicial);
        }
        private void dgvPotenciales_CellFormatting(object sender, DataGridViewCellFormattingEventArgs e)
        {
            EvaluacionPotencialWS.lineaEvaluacion data = dgvPotenciales.Rows[e.RowIndex].DataBoundItem as EvaluacionPotencialWS.lineaEvaluacion;
            dgvPotenciales.Rows[e.RowIndex].Cells["ID"].Value = data.pesoCriterio.criterio.idCriterio;
            dgvPotenciales.Rows[e.RowIndex].Cells["Nombre"].Value = data.pesoCriterio.criterio.nombre;
            dgvPotenciales.Rows[e.RowIndex].Cells["descripcion"].Value = data.pesoCriterio.criterio.descripcion;
            dgvPotenciales.Rows[e.RowIndex].Cells["peso"].Value = data.pesoCriterio.peso;
        }

    }
}
