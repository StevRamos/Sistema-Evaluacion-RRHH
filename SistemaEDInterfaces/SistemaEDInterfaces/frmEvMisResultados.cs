using SistemaEDInterfaces.EvaluacionPotencialWS;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace SistemaEDInterfaces
{
    public partial class frmEvMisResultados : Form
    {
        private int idColaborador;
        private int idPeriodo;
        private int idPuestoTrabajo;
        private EvaluacionDesempenhoWS.EvaluacionDesempenhoWSClient daoEvaluacionDesempenho;
        private EvaluacionPotencialWS.EvaluacionPotencialWSClient daoEvaluacionPotencial; 
        private EvaluacionDesempenhoWS.evaluacionDesempenho evaluacionDesempenho;
        private ReporteWS.ReporteWSClient daoReporte;
        private EvaluacionPotencialWS.evaluacion evaluacionPotencial;
        private ColaboradorWS.colaborador colaborador;
        private PeriodoWS.periodo periodo; 
        private ModoResultados modo; 
        public evaluacion EvaluacionPotencial { get => evaluacionPotencial; set => evaluacionPotencial = value; }
        public ColaboradorWS.colaborador Colaborador { get => colaborador; set => colaborador = value; }
        public EvaluacionDesempenhoWS.evaluacionDesempenho EvaluacionDesempenho { get => evaluacionDesempenho; set => evaluacionDesempenho = value; }
        public ModoResultados Modo { get => modo; set => modo = value; }
        public PeriodoWS.periodo Periodo { get => periodo; set => periodo = value; }

        public frmEvMisResultados()
        {
            InitializeComponent();
            daoEvaluacionDesempenho = new EvaluacionDesempenhoWS.EvaluacionDesempenhoWSClient();
            daoEvaluacionPotencial = new EvaluacionPotencialWS.EvaluacionPotencialWSClient();
            daoReporte = new ReporteWS.ReporteWSClient();

        }
        private void cargarDatosColaboradorEnPantalla()
        {
            txtIDColab.Text = Colaborador.idColaborador.ToString();
            txtNombre.Text = Colaborador.nombres + " " + Colaborador.apellidos;
            txtCargo.Text = Colaborador.puestoTrabajo.nombre;
            txtGerencia.Text = Colaborador.gerencia.nombre;
            txtDNI.Text = Colaborador.dni;
        }

        private void reposicionarElementosObjetivos(int diferenciaY)
        {
            //Widgets de la parte de objetivos 
            lblObservacionesObj.Location = new Point(lblObservacionesObj.Location.X, lblObservacionesObj.Location.Y + diferenciaY);
            txtObservacionesObjetivos.Location = new Point(txtObservacionesObjetivos.Location.X, txtObservacionesObjetivos.Location.Y + diferenciaY);
            lblMaxCarObj.Location = new Point(lblMaxCarObj.Location.X, lblMaxCarObj.Location.Y + diferenciaY);
            
            lblTituloCompetencias.Location = new Point(lblTituloCompetencias.Location.X, lblTituloCompetencias.Location.Y + diferenciaY);
            lblDescripcionCompetencias.Location = new Point(lblDescripcionCompetencias.Location.X, lblDescripcionCompetencias.Location.Y + diferenciaY);
            lblNotaCompetencias.Location = new Point(lblNotaCompetencias.Location.X, lblNotaCompetencias.Location.Y + diferenciaY);
            txtNotaCompetencias.Location = new Point(txtNotaCompetencias.Location.X, txtNotaCompetencias.Location.Y + diferenciaY);
            lbl1.Location = new Point(lbl1.Location.X, lbl1.Location.Y + diferenciaY);
            lbl2.Location = new Point(lbl2.Location.X, lbl2.Location.Y + diferenciaY);
            lbl3.Location = new Point(lbl3.Location.X, lbl3.Location.Y + diferenciaY);
            lbl4.Location = new Point(lbl4.Location.X, lbl4.Location.Y + diferenciaY);
            lbl5.Location = new Point(lbl5.Location.X, lbl5.Location.Y + diferenciaY);
            lblCompetenciasAuto.Location = new Point(lblCompetenciasAuto.Location.X, lblCompetenciasAuto.Location.Y + diferenciaY);
            lblCompetenciasPrevia.Location = new Point(lblCompetenciasPrevia.Location.X, lblCompetenciasPrevia.Location.Y + diferenciaY);
            lblCompetenciasFinal.Location = new Point(lblCompetenciasFinal.Location.X, lblCompetenciasFinal.Location.Y + diferenciaY);


        }

        private void reposicionarElementosCompetencias(int diferenciaY)
        {

            lblObservacionesComp.Location = new Point(lblObservacionesComp.Location.X, lblObservacionesComp.Location.Y + diferenciaY);
            txtObservacionesCompetencias.Location = new Point(txtObservacionesCompetencias.Location.X, txtObservacionesCompetencias.Location.Y + diferenciaY);
            lblMaxCarComp.Location = new Point(lblMaxCarComp.Location.X, lblMaxCarComp.Location.Y + diferenciaY);
            lblTituloEvaluacionPotencial.Location = new Point(lblTituloEvaluacionPotencial.Location.X, lblTituloEvaluacionPotencial.Location.Y + diferenciaY);
            lblTituloPotenciales.Location = new Point(lblTituloPotenciales.Location.X, lblTituloPotenciales.Location.Y + diferenciaY);
            lblDescripcionPotenciales.Location = new Point(lblDescripcionPotenciales.Location.X, lblDescripcionPotenciales.Location.Y + diferenciaY);
            lblSi.Location = new Point(lblSi.Location.X, lblSi.Location.Y + diferenciaY);
            lblNo.Location = new Point(lblNo.Location.X, lblNo.Location.Y + diferenciaY);
            lblNotaPotenciales.Location = new Point(lblNotaPotenciales.Location.X, lblNotaPotenciales.Location.Y + diferenciaY);
        }

        private void reposicionarElementosPotenciales(int diferenciaY)
        {
            lblObservacionesPotencial.Location = new Point(lblObservacionesPotencial.Location.X, lblObservacionesPotencial.Location.Y + diferenciaY);
            txtObservacionesPotencial.Location = new Point(txtObservacionesPotencial.Location.X, txtObservacionesPotencial.Location.Y + diferenciaY);
            lblMaxCarPot.Location = new Point(lblMaxCarPot.Location.X, lblMaxCarPot.Location.Y + diferenciaY);
            lblFantasma.Location = new Point(lblFantasma.Location.X, lblFantasma.Location.Y + diferenciaY);
        }

        private Label crearLabelSublinea(Label lblNombre, Label lblCumplio)
        {
            Label lblNuevo = new Label();
            lblNuevo.Text = lblCumplio.Text;
            lblNuevo.Font = lblCumplio.Font;
            lblNuevo.Size = lblCumplio.Size;
            lblNuevo.ForeColor = lblCumplio.ForeColor;
            lblNuevo.Location = new Point(lblCumplio.Location.X, lblNombre.Location.Y);
            return lblNuevo;
        }

        private RadioButton2 crearRadioButtonSubcompetencia(Label lblCalificacion, Label lblNombreGrupo)
        {
            RadioButton2 rb = new RadioButton2();
            rb.Location = new Point(lblCalificacion.Location.X + 5, lblNombreGrupo.Location.Y + 10);
            rb.Width = lblCalificacion.Width;
            rb.GroupName = lblNombreGrupo.Text;
            rb.AutoSize = true;
            rb.AutoCheck = false;
            rb.Enabled = false;
            return rb;
        }

        private RadioButton2 crearRadioButtonSubpotencial(Label lblOpcion, Label lblNombreGrupo)
        {
            RadioButton2 rb = new RadioButton2();
            rb.Location = new Point(lblOpcion.Location.X + lblOpcion.Width + 10, lblOpcion.Location.Y + 5);
            rb.Width = lblOpcion.Width;
            rb.GroupName = lblNombreGrupo.Text;
            rb.AutoSize = true;
            rb.AutoCheck = false;
            rb.Enabled = false;
            return rb;
        }

        private void agregarRadioButtonsPotenciales(double nota, Label lblNombre)
        {
            //Crear label si/no de la sublinea 
            Label lblSiLinea = crearLabelSublinea(lblNombre, lblSi);
            Label lblNoLinea = crearLabelSublinea(lblNombre, lblNo);

            this.Controls.Add(lblSiLinea);
            this.Controls.Add(lblNoLinea);

            RadioButton2 rbOpcionSi = crearRadioButtonSubpotencial(lblSiLinea, lblNombre);
            RadioButton2 rbOpcionNo = crearRadioButtonSubpotencial(lblNoLinea, lblNombre);


            this.Controls.Add(rbOpcionSi);
            this.Controls.Add(rbOpcionNo);

            if (nota == 1)
            {
                rbOpcionSi.Checked = true;
            }
            else
            {
                rbOpcionNo.Checked = true;
            }

        }
        private void agregarRadioButtonsCompetencias(double nota, Label lblNombre)
        {
            RadioButton2 rb1 = crearRadioButtonSubcompetencia(lbl1, lblNombre);
            RadioButton2 rb2 = crearRadioButtonSubcompetencia(lbl2, lblNombre);
            RadioButton2 rb3 = crearRadioButtonSubcompetencia(lbl3, lblNombre);
            RadioButton2 rb4 = crearRadioButtonSubcompetencia(lbl4, lblNombre);
            RadioButton2 rb5 = crearRadioButtonSubcompetencia(lbl5, lblNombre);
            this.Controls.Add(rb1);
            this.Controls.Add(rb2);
            this.Controls.Add(rb3);
            this.Controls.Add(rb4);
            this.Controls.Add(rb5);

            if (nota == 5)
            {
                rb5.Checked = true;
            }
            else if (nota == 4)
            {
                rb4.Checked = true;
            }
            else if (nota == 3)
            {
                rb3.Checked = true;
            }
            else if (nota == 2)
            {
                rb2.Checked = true;
            }
            else
            {
                rb1.Checked = true;
            }

        }


        private void cargarObjetivosEnPantalla()
        {
            int y = lblObjetivo.Location.Y + lblObjetivo.Height + 20, sumaY = 20;
            int x;
            foreach (EvaluacionDesempenhoWS.objetivo o in EvaluacionDesempenho.objetivos)
            {
                x = lblObjetivo.Location.X;
                //Label de nombre 
                Label labelNombre = new Label();
                labelNombre.Location = new Point(x, y);
                labelNombre.Text = o.descripcion;
                labelNombre.AutoSize = true;
                labelNombre.MaximumSize = new Size(350, 0);
                labelNombre.Font = new Font("Microsoft Sans Serif", 15);
                x = lblCantidad.Location.X;

                Label labelCantidad = new Label();
                labelCantidad.Location = new Point(x, y);
                labelCantidad.Text = o.meta.ToString();
                labelCantidad.Font = new Font("Microsoft Sans Serif", 15);
                x = lblPeso.Location.X;

                Label labelPeso = new Label();
                labelPeso.Location = new Point(x, y);
                labelPeso.Text = o.peso.ToString();
                labelPeso.Font = new Font("Microsoft Sans Serif", 15);
                labelPeso.Width = 50;

                x = lblLogroAuto.Location.X;
                TextBox txtLogroAuto = new TextBox();
                txtLogroAuto.Location = new Point(x, y);
                txtLogroAuto.Font = new Font("Microsoft Sans Serif", 15);
                txtLogroAuto.Text = o.notaAutoEval.ToString();
                txtLogroAuto.Enabled = false;


                x = lblLogroPrevia.Location.X;
                TextBox txtLogroPrev = new TextBox();
                txtLogroPrev.Location = new Point(x, y);
                txtLogroPrev.Font = new Font("Microsoft Sans Serif", 15);
                txtLogroPrev.Text = o.notaPrevia.ToString();
                txtLogroPrev.Enabled = false;



                x = lblLogro.Location.X;
                TextBox txtLogro = new TextBox();
                txtLogro.Location = new Point(x, y);
                txtLogro.Font = new Font("Microsoft Sans Serif", 15);
                txtLogro.Text = o.notaFinal.ToString();
                txtLogro.Enabled = false; 
                this.Controls.Add(labelNombre);
                this.Controls.Add(labelCantidad);
                this.Controls.Add(labelPeso);
                this.Controls.Add(txtLogro);
                this.Controls.Add(txtLogroPrev);
                this.Controls.Add(txtLogroAuto);

                y += labelNombre.Height + 20;
                sumaY += labelNombre.Height + 20;
            }
            reposicionarElementosObjetivos(sumaY);
            reposicionarElementosCompetencias(sumaY);
            reposicionarElementosPotenciales(sumaY);
        }

        private void cargarCompetenciasEnPantalla()
        {
            int y, sumaY = 20, x;
            y = lblDescripcionCompetencias.Location.Y + lblDescripcionCompetencias.Height + 20;
            sumaY = 20;
            foreach (EvaluacionDesempenhoWS.lineaEvaluacion l in EvaluacionDesempenho.lineasEvaluacion)
            {
                x = lblObjetivo.Location.X;
                Label labelNombre = new Label();
                labelNombre.Location = new Point(x, y);
                labelNombre.Text = l.pesoCriterio.criterio.nombre + "(" + l.pesoCriterio.peso + "%)";
                labelNombre.AutoSize = true;
                labelNombre.MaximumSize = new Size(350, 0);
                labelNombre.Font = new Font("Microsoft Sans Serif", 15, FontStyle.Bold);
                labelNombre.ForeColor = new Color();
                labelNombre.ForeColor = Color.FromArgb(0, 66, 122);

                x = lblCompetenciasAuto.Location.X;
                TextBox txtAuto = new TextBox();
                txtAuto.Location = new Point(x, y);
                txtAuto.Font = new Font("Microsoft Sans Serif", 15);
                txtAuto.Text = l.notaAutoEval.ToString();
                txtAuto.Enabled = false;

                x = lblCompetenciasPrevia.Location.X;
                TextBox txtPrevia = new TextBox();
                txtPrevia.Location = new Point(x, y);
                txtPrevia.Font = new Font("Microsoft Sans Serif", 15);
                txtPrevia.Text = l.notaPrevia.ToString();
                txtPrevia.Enabled = false;

                x = lblCompetenciasFinal.Location.X;
                TextBox txtNota = new TextBox();
                txtNota.Location = new Point(x, y);
                txtNota.Font = new Font("Microsoft Sans Serif", 15);
                txtNota.Text = l.notaFinal.ToString();
                txtNota.Enabled = false;


                this.Controls.Add(labelNombre);
                this.Controls.Add(txtNota);
                this.Controls.Add(txtAuto);
                this.Controls.Add(txtPrevia);

                y += labelNombre.Height + 20;
                sumaY += labelNombre.Height + 20;
                foreach (EvaluacionDesempenhoWS.lineaEvaluacion sl in l.sublineasEvaluacion)
                {
                    x = lblObjetivo.Location.X + 40;
                    Label lblGuion = new Label();
                    lblGuion.Location = new Point(x, y);
                    lblGuion.Font = new Font("Microsoft Sans Serif", 15);
                    lblGuion.Text = "-";
                    lblGuion.Width = 20;
                    this.Controls.Add(lblGuion);
                    x = lblGuion.Location.X + lblGuion.Width;
                    Label lblNombreSubcriterio = new Label();
                    lblNombreSubcriterio.Location = new Point(x, y);
                    lblNombreSubcriterio.AutoSize = true;
                    lblNombreSubcriterio.MaximumSize = new Size(350, 0);
                    lblNombreSubcriterio.Font = new Font("Microsoft Sans Serif", 15);
                    lblNombreSubcriterio.Text = sl.pesoCriterio.criterio.nombre + "(" + sl.pesoCriterio.peso + "%)";

                    //Nota previa y de autoevaluacion
                    x = lblCompetenciasAuto.Location.X;
                    TextBox txtAutoSubComp = new TextBox();
                    txtAutoSubComp.Location = new Point(x, y);
                    txtAutoSubComp.Font = new Font("Microsoft Sans Serif", 15);
                    txtAutoSubComp.Text = sl.notaAutoEval.ToString();
                    txtAutoSubComp.Enabled = false;

                    x = lblCompetenciasPrevia.Location.X;
                    TextBox txtPreviaSubComp = new TextBox();
                    txtPreviaSubComp.Location = new Point(x, y);
                    txtPreviaSubComp.Font = new Font("Microsoft Sans Serif", 15);
                    txtPreviaSubComp.Text = sl.notaPrevia.ToString();
                    txtPreviaSubComp.Enabled = false;

                    this.Controls.Add(lblNombreSubcriterio);
                    this.Controls.Add(txtAutoSubComp);
                    this.Controls.Add(txtPreviaSubComp);
                    //Crear radiobuttons
                    agregarRadioButtonsCompetencias(sl.notaFinal, lblNombreSubcriterio);
                    y += lblNombreSubcriterio.Height + 30;
                    sumaY += lblNombreSubcriterio.Height + 30;
                }
            }
            sumaY += 15;
            reposicionarElementosCompetencias(sumaY);
            reposicionarElementosPotenciales(sumaY);
        }


        private void cargarPotencialesEnPantalla()
        {
            int y, sumaY = 20, x;
            y = lblDescripcionPotenciales.Location.Y + lblDescripcionPotenciales.Height + 20;
            sumaY = 20;
            foreach (EvaluacionPotencialWS.lineaEvaluacion l in evaluacionPotencial.lineasEvaluacion)
            {
                x = lblTituloPotenciales.Location.X;
                Label labelNombre = new Label();
                labelNombre.Location = new Point(x, y);
                labelNombre.Text = l.pesoCriterio.criterio.nombre + "(" + l.pesoCriterio.peso + "%)";
                labelNombre.AutoSize = true;
                labelNombre.MaximumSize = new Size(350, 0);
                labelNombre.Font = new Font("Microsoft Sans Serif", 15, FontStyle.Bold);
                labelNombre.ForeColor = new Color();
                labelNombre.ForeColor = Color.FromArgb(0, 66, 122);

                x = lblNotaPotenciales.Location.X;
                TextBox txtNota = new TextBox();
                txtNota.Location = new Point(x, y);
                txtNota.Font = new Font("Microsoft Sans Serif", 15);
                double auxNota = Math.Round(l.notaFinal * 100);
                txtNota.Text = auxNota.ToString() + "/100";
                txtNota.Enabled = false;

                this.Controls.Add(labelNombre);
                this.Controls.Add(txtNota);

                y += labelNombre.Height + 20;
                sumaY += labelNombre.Height + 20;

                foreach (EvaluacionPotencialWS.lineaEvaluacion sl in l.sublineasEvaluacion)
                {
                    x = lblTituloPotenciales.Location.X + 40;
                    Label lblGuion = new Label();
                    lblGuion.Location = new Point(x, y);
                    lblGuion.Font = new Font("Microsoft Sans Serif", 15);
                    lblGuion.Text = "-";
                    lblGuion.Width = 20;
                    this.Controls.Add(lblGuion);
                    x = lblGuion.Location.X + lblGuion.Width;
                    Label lblNombreSubcriterio = new Label();
                    lblNombreSubcriterio.Location = new Point(x, y);
                    lblNombreSubcriterio.AutoSize = true;
                    lblNombreSubcriterio.MaximumSize = new Size(350, 0);
                    lblNombreSubcriterio.Font = new Font("Microsoft Sans Serif", 15);
                    lblNombreSubcriterio.Text = sl.pesoCriterio.criterio.nombre + "(" + sl.pesoCriterio.peso + "%)";

                    this.Controls.Add(lblNombreSubcriterio);

                    //Crear radiobuttons
                    agregarRadioButtonsPotenciales(sl.notaFinal, lblNombreSubcriterio);
                    y += lblNombreSubcriterio.Height + 30;
                    sumaY += lblNombreSubcriterio.Height + 30;
                }
            }
            sumaY += 15;
            reposicionarElementosPotenciales(sumaY);

        }
        private void btnGenerar_Click(object sender, EventArgs e)
        {
            sfdReporte.FileOk += SfdReporte_FileOk;
            sfdReporte.FileName = "Reporte de Evaluacion.pdf";
            sfdReporte.ShowDialog();
            if (sfdReporte.FileName != null && sfdReporte.FileName != "")
            {
                byte[] arreglo;
                //arreglo = daoReporte.generarReporteEvaluacion();
                Global.iniciarEspera(this);
                //File.WriteAllBytes(sfdReporte.FileName, arreglo);
                Global.terminarEspera(this);
            }
        }

        private void SfdReporte_FileOk(object sender, CancelEventArgs e)
        {
            MessageBox.Show("Reporte generado exitosamente .",
                                "Mensaje de confirmacion",
                                MessageBoxButtons.OK,
                                MessageBoxIcon.Information);
        }


        private void btnRegresar_Click(object sender, EventArgs e)
        {
            Global.formPrincipal.cerrarFormularioHijo(); 
        }

        private void frmEvMisResultados_Load(object sender, EventArgs e)
        {
            idPeriodo = periodo.idPeriodo;
            idColaborador = colaborador.idColaborador;
            lblSi.Hide();
            lblNo.Hide();
            if (modo.Equals(ModoResultados.MisResultados))
            {
                evaluacionDesempenho = daoEvaluacionDesempenho.obtenerEvaluacionDesempenho(idColaborador, idPeriodo);
                evaluacionPotencial = daoEvaluacionPotencial.obtenerEvaluacionPotencial(idColaborador, idPeriodo);
                btnRegresar.Hide(); 
            }
            txtNotaDesempenho.Text = evaluacionDesempenho.escalaFinal.nombre;
            txtNotaPotencial.Text = evaluacionPotencial.escalaFinal.nombre; 
            double notaObj, notaComp;
            notaObj = Math.Round(evaluacionDesempenho.notaFinalObj * 100);
            notaComp = Math.Round((evaluacionDesempenho.notaFinalComp / 5) * 100);
            txtNotaObjetivos.Text = notaObj.ToString() + "/100";
            txtNotaCompetencias.Text = notaComp + "/100";
            //Observaciones 
            txtObservacionesCompetencias.Text = evaluacionDesempenho.observacionesComp;
            txtObservacionesObjetivos.Text = evaluacionDesempenho.observacionesObj;
            txtObservacionesPotencial.Text = evaluacionPotencial.observaciones; 
            //Cargar datos de colaborador en pantalla 
            cargarDatosColaboradorEnPantalla();
            //Cargar datos de evaluacion de desempeño 
            cargarObjetivosEnPantalla();
            cargarCompetenciasEnPantalla();
            //Cargar datos de evaluacion de potencial 
            cargarPotencialesEnPantalla(); 
        }

    }
}
