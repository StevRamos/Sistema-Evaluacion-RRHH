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
    public partial class frmRepPDIColaborador : Form
    {
        ColaboradorWS.colaborador colaborador;
        private int idColaborador;
        private int idPeriodo;
        private int idPuestoTrabajo;
        private BindingList<RichTextBox> txtBoxCompetencias;
        private BindingList<DateTimePicker> dtpFechas;
        private EvaluacionDesempenhoWS.EvaluacionDesempenhoWSClient daoEvaluacionDesempenho;
        private EvaluacionDesempenhoWS.evaluacionDesempenho evaluacionDesempenho;
        private ReporteWS.ReporteWSClient daoReporte;

        public frmRepPDIColaborador()
        {
            InitializeComponent();
        }

        public ColaboradorWS.colaborador Colaborador { get => colaborador; set => colaborador = value; }


        private void CargarCompetencias()
        {
            int y = lblInstrucciones.Location.Y + lblInstrucciones.Height + 20, sumaY = 50;
            int x;
            txtBoxCompetencias= new BindingList<RichTextBox>();
            dtpFechas = new BindingList<DateTimePicker>();

            if (this.evaluacionDesempenho.lineasEvaluacion == null)
                return;

            foreach (EvaluacionDesempenhoWS.lineaEvaluacion l in evaluacionDesempenho.lineasEvaluacion)
            {
                x = lblInstrucciones.Location.X;
                Label labelCompetencia = new Label();
                labelCompetencia.Location = new Point(x, y);
                labelCompetencia.Text = l.pesoCriterio.criterio.nombre;
                labelCompetencia.AutoSize = true;
                labelCompetencia.MaximumSize = new Size(350, 0);
                labelCompetencia.Font = new Font("Microsoft Sans Serif", 15, FontStyle.Bold);
                this.Controls.Add(labelCompetencia);

                x = lblInstrucciones.Location.X + 300;
                Label labelPDI = new Label();
                labelPDI.Location = new Point(x, y);
                labelPDI.Text = l.itemPDI.nombre;
                labelPDI.AutoSize = true;
                labelPDI.MaximumSize = new Size(350, 0);
                labelPDI.Font = new Font("Microsoft Sans Serif", 15, FontStyle.Bold);
                this.Controls.Add(labelPDI);

                y += sumaY;

                x = lblInstrucciones.Location.X;
                Label labelAcciones = new Label();
                labelAcciones.Location = new Point(x, y);
                labelAcciones.Text = "Acciones a tomar:";
                labelAcciones.AutoSize = true;
                labelAcciones.MaximumSize = new Size(350, 0);
                labelAcciones.Font = new Font("Microsoft Sans Serif", 11);
                this.Controls.Add(labelAcciones);

                y += sumaY;

                x = lblInstrucciones.Location.X;
                RichTextBox txtAcciones = new RichTextBox();
                txtAcciones.Location = new Point(x, y);
                txtAcciones.Enabled = true;
                txtAcciones.BorderStyle = BorderStyle.FixedSingle;
                txtAcciones.Size = new Size(700, 180);
                txtAcciones.Font = new Font("Microsoft Sans Serif", 11);
                txtAcciones.MaxLength = 200;
                txtAcciones.Text = l.accionesAtomar;

                txtBoxCompetencias.Add(txtAcciones);
                this.Controls.Add(txtAcciones);

                y += (sumaY+ txtAcciones.Size.Height);

                x = lblInstrucciones.Location.X;
                Label labelFecha = new Label();
                labelFecha.Location = new Point(x, y);
                labelFecha.Text = "Fecha de Cumplimiento:";
                labelFecha.AutoSize = true;
                labelFecha.MaximumSize = new Size(350, 0);
                labelFecha.Font = new Font("Microsoft Sans Serif", 11);
                this.Controls.Add(labelFecha);

                x = lblInstrucciones.Location.X + 300;
                DateTimePicker dtpFecha = new DateTimePicker();
                dtpFecha.Location = new Point(x, y);
                dtpFecha.Size = new Size(200, 20);
                dtpFecha.Value = l.fechaCumplimiento;
                this.dtpFechas.Add(dtpFecha);
                this.Controls.Add(dtpFecha);



                y += sumaY;


            }

            btnGuardar.Location = new Point(705, y);
            btnFinalizar.Location = new Point(896, y);
        }

        private void asignarDatosNoActualizables()
        {
            evaluacionDesempenho.notaPreviaComp = -1;
            evaluacionDesempenho.notaFinalComp = -1;
            evaluacionDesempenho.observacionesObj = "";
            evaluacionDesempenho.observacionesComp = "";
            evaluacionDesempenho.notaPreviaObj = -1;
            evaluacionDesempenho.notaFinalObj = -1;
            evaluacionDesempenho.notaPrevia = -1;
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

                evaluacionDesempenho.lineasEvaluacion[i].notaPrevia = -1;
                evaluacionDesempenho.lineasEvaluacion[i].notaFinal = -1;
                evaluacionDesempenho.lineasEvaluacion[i].accionesAtomar = "";
                evaluacionDesempenho.lineasEvaluacion[i].fechaCumplimiento = DateTime.Parse("01/01/2010");
                evaluacionDesempenho.lineasEvaluacion[i].fechaCumplimientoSpecified = true;
                evaluacionDesempenho.lineasEvaluacion[i].itemPDI = new EvaluacionDesempenhoWS.itemPDI();
                evaluacionDesempenho.lineasEvaluacion[i].itemPDI.idItemPDI = -1;
                for (int j = 0; j < evaluacionDesempenho.lineasEvaluacion[i].sublineasEvaluacion.Count(); j++)
                {
                    evaluacionDesempenho.lineasEvaluacion[i].sublineasEvaluacion[j].notaPrevia = -1;
                    evaluacionDesempenho.lineasEvaluacion[i].sublineasEvaluacion[j].notaFinal = -1;
                    evaluacionDesempenho.lineasEvaluacion[i].sublineasEvaluacion[j].accionesAtomar = "";
                    evaluacionDesempenho.lineasEvaluacion[i].sublineasEvaluacion[j].fechaCumplimiento = DateTime.Parse("01/01/2010");
                    evaluacionDesempenho.lineasEvaluacion[i].sublineasEvaluacion[j].fechaCumplimientoSpecified = true;
                    evaluacionDesempenho.lineasEvaluacion[i].sublineasEvaluacion[j].itemPDI = new EvaluacionDesempenhoWS.itemPDI();
                    evaluacionDesempenho.lineasEvaluacion[i].sublineasEvaluacion[j].itemPDI.idItemPDI = -1;
                }
            }
        }

        private void verificarEstado()
        {
            if (evaluacionDesempenho.estadoPDI == 1)
            {
                //btnFinalizar.Enabled = false;
                btnGuardar.Enabled = false;
            }

        }

        private void frmRepPDIColaborador_Load(object sender, EventArgs e)
        {
            txtNombre.Text = colaborador.nombres + " " + colaborador.apellidos;
            txtPuesto.Text = colaborador.puestoTrabajo.nombre;
            txtGerencia.Text = colaborador.gerencia.nombre;
            txtJefe.Text = Global.colaboradorLoggeado.jefe.nombres + " " + Global.colaboradorLoggeado.jefe.apellidos;

            daoEvaluacionDesempenho = new EvaluacionDesempenhoWS.EvaluacionDesempenhoWSClient();
            idColaborador = colaborador.idColaborador;
            idPuestoTrabajo = colaborador.puestoTrabajo.idPuestoTrabajo;
            idPeriodo = Global.periodoActual.idPeriodo;
            evaluacionDesempenho = daoEvaluacionDesempenho.obtenerEvaluacionDesempenho(idColaborador, idPeriodo);
            CargarCompetencias();
            verificarEstado();

        }

        private void btnGuardar_Click(object sender, EventArgs e)
        {
            int resultado;
            int i = 0;
            asignarDatosNoActualizables();
            foreach (EvaluacionDesempenhoWS.lineaEvaluacion l in evaluacionDesempenho.lineasEvaluacion)
            {
                evaluacionDesempenho.lineasEvaluacion[i].accionesAtomar = txtBoxCompetencias[i].Text;
                evaluacionDesempenho.lineasEvaluacion[i].fechaCumplimiento = dtpFechas[i].Value;
                i++;
            }
            evaluacionDesempenho.estadoPDI = 0;
            resultado=daoEvaluacionDesempenho.actualizarEvaluacionDesempenho(evaluacionDesempenho);

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
        }

        private void btnFinalizar_Click(object sender, EventArgs e)
        {
            asignarDatosNoActualizables();
            daoReporte = new ReporteWS.ReporteWSClient();
            int resultado;
            var result = MessageBox.Show("¿Desea finalizar la evaluación?",
                "Mensaje de Pregunta", MessageBoxButtons.YesNo,
                MessageBoxIcon.Information);
            if (result == DialogResult.Yes)
            {
                evaluacionDesempenho.estadoPDI = 1;
                resultado = daoEvaluacionDesempenho.actualizarEvaluacionDesempenho(evaluacionDesempenho);
                if (resultado == 0)
                {
                    MessageBox.Show("Ocurrio un error, intentelo nuevamente",
                        "Mensaje de Error", MessageBoxButtons.OK,
                         MessageBoxIcon.Error);
                    return;
                }
                enviarReporte();
                MessageBox.Show("Ha finalizado la autoevaluación",
                "Mensaje Informativo", MessageBoxButtons.OK,
                MessageBoxIcon.Information);
                verificarEstado();
            }

        }

        private void enviarReporte()
        {
            ReporteWS.colaborador colab = new ReporteWS.colaborador();
            colab.idColaborador = this.colaborador.idColaborador;
            colab.nombres = this.colaborador.nombres;
            colab.apellidos = this.colaborador.apellidos;
            colab.correo = this.colaborador.correo;
            colab.periodo = new ReporteWS.periodo();
            colab.periodo.idPeriodo = Global.periodoActual.idPeriodo;
            colab.periodo.nombre = Global.periodoActual.nombre;
            daoReporte = new ReporteWS.ReporteWSClient();
            daoReporte.enviarReportePDI(colab);
        }
    }
}
