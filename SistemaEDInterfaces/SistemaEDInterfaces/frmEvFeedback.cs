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
    public partial class frmEvFeedback : Form
    {
        ColaboradorWS.colaborador colaborador = Global.colaboradorLoggeado;
        private int idColaborador;
        private int idPeriodo;
        private BindingList<RichTextBox> txtBoxCompetencias;
        private BindingList<DateTimePicker> dtpFechas;
        private EvaluacionDesempenhoWS.EvaluacionDesempenhoWSClient daoEvaluacionDesempenho;
        private EvaluacionDesempenhoWS.evaluacionDesempenho evaluacionDesempenho;
        private ReporteWS.ReporteWSClient daoReporte;

        public frmEvFeedback()
        {
            InitializeComponent();
        }


        private void CargarCompetencias()
        {
            int y = lblFeedback.Location.Y + lblFeedback.Height + 20, sumaY = 50;
            int x;
            txtBoxCompetencias = new BindingList<RichTextBox>();
            dtpFechas = new BindingList<DateTimePicker>();

            if (this.evaluacionDesempenho.lineasEvaluacion == null)
                return;

            foreach (EvaluacionDesempenhoWS.lineaEvaluacion l in evaluacionDesempenho.lineasEvaluacion)
            {
                x = lblFeedback.Location.X;
                Label labelCompetencia = new Label();
                labelCompetencia.Location = new Point(x, y);
                labelCompetencia.Text = l.pesoCriterio.criterio.nombre;
                labelCompetencia.AutoSize = true;
                labelCompetencia.MaximumSize = new Size(350, 0);
                labelCompetencia.Font = new Font("Microsoft Sans Serif", 15, FontStyle.Bold);
                this.Controls.Add(labelCompetencia);

                x = lblFeedback.Location.X + 300;
                Label labelPDI = new Label();
                labelPDI.Location = new Point(x, y);
                labelPDI.Text = l.itemPDI.nombre;
                labelPDI.AutoSize = true;
                labelPDI.MaximumSize = new Size(350, 0);
                labelPDI.Font = new Font("Microsoft Sans Serif", 15, FontStyle.Bold);
                this.Controls.Add(labelPDI);

                y += sumaY;

                x = lblFeedback.Location.X;
                Label labelAcciones = new Label();
                labelAcciones.Location = new Point(x, y);
                labelAcciones.Text = "Acciones a tomar:";
                labelAcciones.AutoSize = true;
                labelAcciones.MaximumSize = new Size(350, 0);
                labelAcciones.Font = new Font("Microsoft Sans Serif", 11, FontStyle.Bold);
                this.Controls.Add(labelAcciones);

                y += sumaY;

                x = lblFeedback.Location.X;
                Label lblAcciones = new Label();
                lblAcciones.Location = new Point(x, y);
                lblAcciones.AutoSize = true;
                lblAcciones.Font = new Font("Microsoft Sans Serif", 11);
                labelAcciones.MaximumSize = new Size(350, 0);
                lblAcciones.Text = l.accionesAtomar;

                this.Controls.Add(lblAcciones);

                y += sumaY;

                x = lblFeedback.Location.X;
                Label labelFecha = new Label();
                labelFecha.Location = new Point(x, y);
                labelFecha.Text = "Fecha de Cumplimiento:";
                labelFecha.AutoSize = true;
                labelFecha.MaximumSize = new Size(350, 0);
                labelFecha.Font = new Font("Microsoft Sans Serif", 11, FontStyle.Bold);
                this.Controls.Add(labelFecha);

                x = lblFeedback.Location.X + 300;
                DateTimePicker dtpFecha = new DateTimePicker();
                dtpFecha.Location = new Point(x, y);
                dtpFecha.Size = new Size(200, 20);
                dtpFecha.Value = l.fechaCumplimiento;
                dtpFecha.Enabled = false;
                this.dtpFechas.Add(dtpFecha);
                this.Controls.Add(dtpFecha);



                y += sumaY;


            }

            btnGenerar.Location = new Point(705, y);

        }

        private void frmEvFeedback_Load(object sender, EventArgs e)
        {
            daoEvaluacionDesempenho = new EvaluacionDesempenhoWS.EvaluacionDesempenhoWSClient();
            idColaborador = Global.colaboradorLoggeado.idColaborador;
            idPeriodo = Global.periodoActual.idPeriodo;
            evaluacionDesempenho = daoEvaluacionDesempenho.obtenerEvaluacionDesempenho(idColaborador, idPeriodo);
            CargarCompetencias();
        }

        private void btnGenerar_Click(object sender, EventArgs e)
        {
            
            daoReporte = new ReporteWS.ReporteWSClient();
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
            MessageBox.Show("Se ha enviado el reporte al correo",
                "Mensaje Informativo", MessageBoxButtons.OK,
                MessageBoxIcon.Information);

        }
    }
}
