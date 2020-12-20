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
    public partial class frmEvMisTrabajadoresFinal : Form
    {
        private int idColaborador;
        private int idPeriodo;
        private int idPuestoTrabajo;
        private EstadoFormulario estado;
        private PeriodoWS.PeriodoWSClient daoPeriodo;
        private PeriodoWS.periodo periodo; 
        private EvaluacionDesempenhoWS.EvaluacionDesempenhoWSClient daoEvaluacionDesempenho;
        private PesoCriterioWS.PesoCriterioWSClient daoPesoCriterio;
        private EvaluacionDesempenhoWS.evaluacionDesempenho evaluacionDesempenho;
        private ColaboradorWS.colaborador colaborador;
        private BindingList<TextBox> txtBoxObjetivos;
        private BindingList<TextBox> txtBoxCompetencias;
        private BindingList<BindingList<SeccionSubcompetencia>> secciones;

        public colaborador Colaborador { get => colaborador; set => colaborador = value; }
        public EstadoFormulario Estado { get => estado; set => estado = value; }
        public EvaluacionDesempenhoWS.evaluacionDesempenho EvaluacionDesempenho { get => evaluacionDesempenho; set => evaluacionDesempenho = value; }
        public PeriodoWS.periodo Periodo { get => periodo; set => periodo = value; }

        public frmEvMisTrabajadoresFinal()
        {
            InitializeComponent();
        }


        private void cargarDatosColaboradorEnPantalla()
        {
            txtIDColab.Text = colaborador.idColaborador.ToString();
            txtNombre.Text = colaborador.nombres + " " + colaborador.apellidos;
            txtCargo.Text = colaborador.puestoTrabajo.nombre;
            txtGerencia.Text = colaborador.gerencia.nombre;
            txtDNI.Text = colaborador.dni;
        }

        private void reposicionarElementos(int diferenciaY)
        {
            lblTituloCompetencias.Location = new Point(lblTituloCompetencias.Location.X, lblTituloCompetencias.Location.Y + diferenciaY);
            lblDescripcionCompetencias.Location = new Point(lblDescripcionCompetencias.Location.X, lblDescripcionCompetencias.Location.Y + diferenciaY);
            lblNotaCompetencias.Location = new Point(lblNotaCompetencias.Location.X, lblNotaCompetencias.Location.Y + diferenciaY);
            txtNotaCompetencias.Location = new Point(txtNotaCompetencias.Location.X, txtNotaCompetencias.Location.Y + diferenciaY);
            btnGuardar.Location = new Point(btnGuardar.Location.X, btnGuardar.Location.Y + diferenciaY);
            btnFinalizar.Location = new Point(btnFinalizar.Location.X, btnFinalizar.Location.Y + diferenciaY);
            lbl1.Location = new Point(lbl1.Location.X, lbl1.Location.Y + diferenciaY);
            lbl2.Location = new Point(lbl2.Location.X, lbl2.Location.Y + diferenciaY);
            lbl3.Location = new Point(lbl3.Location.X, lbl3.Location.Y + diferenciaY);
            lbl4.Location = new Point(lbl4.Location.X, lbl4.Location.Y + diferenciaY);
            lbl5.Location = new Point(lbl5.Location.X, lbl5.Location.Y + diferenciaY);
            lblObservacionesObj.Location = new Point(lblObservacionesObj.Location.X, lblObservacionesObj.Location.Y + diferenciaY);
            txtObservacionesObjetivos.Location = new Point(txtObservacionesObjetivos.Location.X, txtObservacionesObjetivos.Location.Y + diferenciaY);
            lblMaxCarObj.Location = new Point(lblMaxCarObj.Location.X, lblMaxCarObj.Location.Y + diferenciaY);

            lblObservacionesComp.Location = new Point(lblObservacionesComp.Location.X, lblObservacionesComp.Location.Y + diferenciaY);
            txtObservacionesCompetencias.Location = new Point(txtObservacionesCompetencias.Location.X, txtObservacionesCompetencias.Location.Y + diferenciaY);
            lblMaxCarComp.Location = new Point(lblMaxCarComp.Location.X, lblMaxCarComp.Location.Y + diferenciaY);

            lblCompetenciasAuto.Location = new Point(lblCompetenciasAuto.Location.X, lblCompetenciasAuto.Location.Y + diferenciaY);
            lblCompetenciasPrevia.Location = new Point(lblCompetenciasPrevia.Location.X, lblCompetenciasPrevia.Location.Y + diferenciaY);
            lblCompetenciasFinal.Location = new Point(lblCompetenciasFinal.Location.X, lblCompetenciasFinal.Location.Y + diferenciaY);
        }
        private RadioButton2 crearRadioButtonSubcompetencia(Label lblCalificacion, Label lblNombreGrupo)
        {
            RadioButton2 rb = new RadioButton2();
            rb.Location = new Point(lblCalificacion.Location.X + 5, lblNombreGrupo.Location.Y+10);
            rb.Width = lblCalificacion.Width;
            rb.GroupName = lblNombreGrupo.Text;
            rb.AutoSize = true;
            rb.AutoCheck = false;
            rb.Click += RadioButton2_Clicked;
            return rb;
        }
        private void agregarRadioButtons(double nota, SeccionSubcompetencia agrupacionSubcompetencia,
                                                            Label lblNombre)
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
            agrupacionSubcompetencia.RbNota1 = rb1;
            agrupacionSubcompetencia.RbNota2 = rb2;
            agrupacionSubcompetencia.RbNota3 = rb3;
            agrupacionSubcompetencia.RbNota4 = rb4;
            agrupacionSubcompetencia.RbNota5 = rb5;

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
            txtBoxObjetivos = new BindingList<TextBox>();
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
                txtLogroAuto.KeyPress += txt_KeyPress;


                x = lblLogroPrevia.Location.X;
                TextBox txtLogroPrev = new TextBox();
                txtLogroPrev.Location = new Point(x, y);
                txtLogroPrev.Font = new Font("Microsoft Sans Serif", 15);
                txtLogroPrev.Text = o.notaPrevia.ToString();
                txtLogroPrev.Enabled = false;
                txtLogroPrev.KeyPress += txt_KeyPress;



                x = lblLogro.Location.X;
                TextBox txtLogro = new TextBox();
                txtLogro.Location = new Point(x, y);
                txtLogro.Font = new Font("Microsoft Sans Serif", 15);
                txtLogro.Text = o.notaFinal.ToString();
                txtLogro.KeyPress += txt_KeyPress;

                txtBoxObjetivos.Add(txtLogro);
                this.Controls.Add(labelNombre);
                this.Controls.Add(labelCantidad);
                this.Controls.Add(labelPeso);
                this.Controls.Add(txtLogro);
                this.Controls.Add(txtLogroPrev);
                this.Controls.Add(txtLogroAuto); 
                
                y += labelNombre.Height + 20;
                sumaY += labelNombre.Height + 20;
            }
            reposicionarElementos(sumaY);


        }
        private void txt_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!char.IsControl(e.KeyChar) && !char.IsDigit(e.KeyChar) &&
            (e.KeyChar != '.'))
            {
                e.Handled = true;
            }

            // Solo permitir un punto decimal
            if ((e.KeyChar == '.') && ((sender as TextBox).Text.IndexOf('.') > -1))
            {
                e.Handled = true;
            }
        }

        private void cargarCompetenciasEnPantalla()
        {
            int y, sumaY = 20, x;
            y = lblDescripcionCompetencias.Location.Y + lblDescripcionCompetencias.Height + 20;
            sumaY = 20;
            txtBoxCompetencias = new BindingList<TextBox>();
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
                //txtNota.Width = 50; 
                //txtNota.Width = txtNotaCompetencias.Width; 
                txtNota.Enabled = false;

                txtBoxCompetencias.Add(txtNota);
                this.Controls.Add(labelNombre);
                this.Controls.Add(txtNota);
                this.Controls.Add(txtAuto);
                this.Controls.Add(txtPrevia);

                y += labelNombre.Height + 20;
                sumaY += labelNombre.Height + 20;
                BindingList<SeccionSubcompetencia> agrupacionCompetencia;
                agrupacionCompetencia = new BindingList<SeccionSubcompetencia>();
                foreach (EvaluacionDesempenhoWS.lineaEvaluacion sl in l.sublineasEvaluacion)
                {
                    SeccionSubcompetencia agrupacionSubcompetencia = new SeccionSubcompetencia();
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
                    agregarRadioButtons(sl.notaFinal, agrupacionSubcompetencia, lblNombreSubcriterio);
                    y += lblNombreSubcriterio.Height + 30;
                    sumaY += lblNombreSubcriterio.Height + 30;
                    agrupacionCompetencia.Add(agrupacionSubcompetencia);
                }
                secciones.Add(agrupacionCompetencia);
            }
            sumaY += 15;
            btnGuardar.Location = new Point(btnGuardar.Location.X, btnGuardar.Location.Y + sumaY);
            btnFinalizar.Location = new Point(btnFinalizar.Location.X, btnFinalizar.Location.Y + sumaY);
            lblObservacionesComp.Location = new Point(lblObservacionesComp.Location.X, lblObservacionesComp.Location.Y + sumaY);
            txtObservacionesCompetencias.Location = new Point(txtObservacionesCompetencias.Location.X, txtObservacionesCompetencias.Location.Y + sumaY);
            lblMaxCarComp.Location = new Point(lblMaxCarComp.Location.X, lblMaxCarComp.Location.Y + sumaY);
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
            EvaluacionDesempenho.lineasEvaluacion = lineasEv.ToArray();
        }
        private void cambiarEstado(EstadoFormulario estadoNuevo)
        {
            this.Estado = estadoNuevo;

            if (estadoNuevo.Equals(EstadoFormulario.Editable))
            {
                btnGuardar.Enabled = true;
                btnFinalizar.Enabled = true;
            }
            else if (estadoNuevo.Equals(EstadoFormulario.NoEditable))
            {
                btnGuardar.Enabled = false;
                btnFinalizar.Enabled = false;
                txtObservacionesCompetencias.Enabled = false;
                txtObservacionesObjetivos.Enabled = false;
                for (int i = 0; i < txtBoxObjetivos.Count(); i++)
                {
                    txtBoxObjetivos.ElementAt(i).Enabled = false;
                }
                for (int i = 0; i < secciones.Count(); i++)
                {
                    for (int j = 0; j < secciones.ElementAt(i).Count(); j++)
                    {
                        secciones.ElementAt(i).ElementAt(j).RbNota1.Enabled = false;
                        secciones.ElementAt(i).ElementAt(j).RbNota2.Enabled = false;
                        secciones.ElementAt(i).ElementAt(j).RbNota3.Enabled = false;
                        secciones.ElementAt(i).ElementAt(j).RbNota4.Enabled = false;
                        secciones.ElementAt(i).ElementAt(j).RbNota5.Enabled = false;

                    }
                }

            }
        }
       

        private void asignarDatosNoActualizables()
        {
            EvaluacionDesempenho.observaciones = "";
            EvaluacionDesempenho.estadoPDI = -1;
            

            for (int i = 0; i < EvaluacionDesempenho.lineasEvaluacion.Count(); i++)
            {

                EvaluacionDesempenho.lineasEvaluacion[i].accionesAtomar = "";
                EvaluacionDesempenho.lineasEvaluacion[i].fechaCumplimiento = DateTime.Parse("01/01/2010");
                EvaluacionDesempenho.lineasEvaluacion[i].fechaCumplimientoSpecified = true;
                EvaluacionDesempenho.lineasEvaluacion[i].itemPDI = new EvaluacionDesempenhoWS.itemPDI();
                EvaluacionDesempenho.lineasEvaluacion[i].itemPDI.idItemPDI = -1;
                EvaluacionDesempenho.escalaSinCalibrar = new EvaluacionDesempenhoWS.escala();
                EvaluacionDesempenho.escalaSinCalibrar.idEscala = -1;
                EvaluacionDesempenho.escalaFinal = new EvaluacionDesempenhoWS.escala();
                EvaluacionDesempenho.escalaFinal.idEscala = -1;

                for (int j = 0; j < EvaluacionDesempenho.lineasEvaluacion[i].sublineasEvaluacion.Count(); j++)
                {
                    EvaluacionDesempenho.lineasEvaluacion[i].sublineasEvaluacion[j].accionesAtomar = "";
                    EvaluacionDesempenho.lineasEvaluacion[i].sublineasEvaluacion[j].fechaCumplimiento = DateTime.Parse("01/01/2010");
                    EvaluacionDesempenho.lineasEvaluacion[i].sublineasEvaluacion[j].fechaCumplimientoSpecified = true;
                    EvaluacionDesempenho.lineasEvaluacion[i].sublineasEvaluacion[j].itemPDI = new EvaluacionDesempenhoWS.itemPDI();
                    EvaluacionDesempenho.lineasEvaluacion[i].sublineasEvaluacion[j].itemPDI.idItemPDI = -1;
                }
            }
        }
        private void calcularNotaFinal()
        {
            double notaObj = 0.0, notaComp = 0.0, notaCriterio;

            for (int i = 0; i < EvaluacionDesempenho.lineasEvaluacion.Count(); i++)
            {
                //Asignar notas de subcriterios 
                notaCriterio = 0.0;
                for (int j = 0; j < EvaluacionDesempenho.lineasEvaluacion[i].sublineasEvaluacion.Count(); j++)
                {
                    SeccionSubcompetencia agrupacionSubcompetencia = secciones.ElementAt(i).ElementAt(j);
                    if (agrupacionSubcompetencia.RbNota1.Checked)
                    {
                        EvaluacionDesempenho.lineasEvaluacion[i].sublineasEvaluacion[j].notaFinal = 1;

                    }
                    else if (agrupacionSubcompetencia.RbNota2.Checked)
                    {
                        EvaluacionDesempenho.lineasEvaluacion[i].sublineasEvaluacion[j].notaFinal = 2;

                    }
                    else if (agrupacionSubcompetencia.RbNota3.Checked)
                    {
                        EvaluacionDesempenho.lineasEvaluacion[i].sublineasEvaluacion[j].notaFinal = 3;
                    }
                    else if (agrupacionSubcompetencia.RbNota4.Checked)
                    {
                        EvaluacionDesempenho.lineasEvaluacion[i].sublineasEvaluacion[j].notaFinal = 4;
                    }
                    else if (agrupacionSubcompetencia.RbNota5.Checked)
                    {
                        EvaluacionDesempenho.lineasEvaluacion[i].sublineasEvaluacion[j].notaFinal = 5;
                    }
                    notaCriterio += EvaluacionDesempenho.lineasEvaluacion[i].sublineasEvaluacion[j].notaFinal
                                                * (EvaluacionDesempenho.lineasEvaluacion[i].sublineasEvaluacion[j].pesoCriterio.peso / 100);

                }
                EvaluacionDesempenho.lineasEvaluacion[i].notaFinal = Math.Round(notaCriterio,2);
                notaComp += notaCriterio
                            * (EvaluacionDesempenho.lineasEvaluacion[i].pesoCriterio.peso / 100);
            }
            for (int i = 0; i < EvaluacionDesempenho.objetivos.Count(); i++)
            {
                EvaluacionDesempenho.objetivos[i].notaFinal = Double.Parse(txtBoxObjetivos.ElementAt(i).Text);
                if (EvaluacionDesempenho.objetivos[i].notaFinal > EvaluacionDesempenho.objetivos[i].meta)
                {
                    notaObj += 1 * (EvaluacionDesempenho.objetivos[i].peso / 100);
                }
                else notaObj += (EvaluacionDesempenho.objetivos[i].notaFinal / EvaluacionDesempenho.objetivos[i].meta) * (EvaluacionDesempenho.objetivos[i].peso / 100);
            }
            EvaluacionDesempenho.notaFinalComp = Math.Round(notaComp, 2);
            EvaluacionDesempenho.notaFinalObj = Math.Round(notaObj, 2);

            EvaluacionDesempenho.notaFinal = (evaluacionDesempenho.notaFinalComp / 5) * periodo.pesoEvalComp
                                            + (evaluacionDesempenho.notaFinalObj) * periodo.pesoEvalObj;
        }


        private void actualizarInformacionFormulario()
        {
            double notaObj, notaComp;
            notaObj = Math.Round(EvaluacionDesempenho.notaFinalObj * 100);
            notaComp = Math.Round((EvaluacionDesempenho.notaFinalComp / 5) * 100);
            txtNotaObjetivos.Text = notaObj.ToString() + "/100";
            txtNotaCompetencias.Text = notaComp + "/100";
            txtNotaDesempenho.Text = evaluacionDesempenho.escalaPreCupos.nombre;
            for (int i = 0; i < txtBoxCompetencias.Count(); i++)
            {
                txtBoxCompetencias.ElementAt(i).Text = EvaluacionDesempenho.lineasEvaluacion[i].notaFinal.ToString();
            }
            
        }

        private void asignarEscala()
        {
            EvaluacionDesempenho.escalaPreCupos = new EvaluacionDesempenhoWS.escala();
            /*EvaluacionDesempenho.escalaSinCalibrar = new EvaluacionDesempenhoWS.escala();
            EvaluacionDesempenho.escalaFinal = new EvaluacionDesempenhoWS.escala(); */
            PeriodoWS.escalaPeriodo[] lista = daoPeriodo.listarEscalaPeriodo(Periodo.idPeriodo);
            BindingList<PeriodoWS.escalaPeriodo> escalasPeriodos;
            if (lista != null) {
                escalasPeriodos = new BindingList<PeriodoWS.escalaPeriodo>(lista);
                foreach (PeriodoWS.escalaPeriodo ep in escalasPeriodos)
                {
                    if ( ((EvaluacionDesempenho.notaFinal*100) < ep.notaMax &&
                        (EvaluacionDesempenho.notaFinal * 100) >= ep.notaMin && !ep.escala.tipo) || ((EvaluacionDesempenho.notaFinal * 100) == ep.notaMax && ep.escala.nombre == "A"))
                    {
                        EvaluacionDesempenho.escalaPreCupos.idEscala = ep.escala.idEscala;
                        EvaluacionDesempenho.escalaPreCupos.nombre = ep.escala.nombre;
                        /*EvaluacionDesempenho.escalaSinCalibrar.idEscala = ep.escala.idEscala;
                        EvaluacionDesempenho.escalaSinCalibrar.nombre = ep.escala.nombre; 
                        EvaluacionDesempenho.escalaFinal.idEscala = ep.escala.idEscala;
                        EvaluacionDesempenho.escalaFinal.nombre = ep.escala.nombre; */
                    }
                }   
            }
            
        }


            
        

        private void btnGuardar_Click(object sender, EventArgs e)
        {
            //Verificar si se deben registrar o actualizar las lineas de evaluacion 
            bool seRegistra = EvaluacionDesempenho.estadoAutoEval.Equals(0) && EvaluacionDesempenho.estado.Equals(0);
            //Se marca los datos que no se actualizaran 
            asignarDatosNoActualizables();
            //calcular la notaAutoEvalObj y notaAutoEvalComp 
            calcularNotaFinal();
            //cambiar el estado de la evaluacionDesemepenho 
            EvaluacionDesempenho.estado = (int)EstadoEvD.FinalIniciada;
            //Asignar escala 
            asignarEscala();
            //Asignar observaciones 
            EvaluacionDesempenho.observacionesComp = txtObservacionesCompetencias.Text;
            EvaluacionDesempenho.observacionesObj = txtObservacionesObjetivos.Text; 
            //Se actualiza 
            int resultado = 0;
            if (seRegistra) resultado = daoEvaluacionDesempenho.insertarLineasEvaluacionDesempenho(EvaluacionDesempenho);
            else resultado = daoEvaluacionDesempenho.actualizarEvaluacionDesempenho(EvaluacionDesempenho);
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
            actualizarInformacionFormulario();
        }

        

        private void btnFinalizar_Click(object sender, EventArgs e)
        {
            var result = MessageBox.Show("¿Desea finalizar la evaluación?",
                 "Mensaje de Pregunta", MessageBoxButtons.YesNo,
                 MessageBoxIcon.Information);

            if (result == DialogResult.Yes)
            {
                //Verificar si se deben registrar o actualizar las lineas de evaluacion 
                bool seRegistra = EvaluacionDesempenho.estadoAutoEval.Equals(0) && EvaluacionDesempenho.estado.Equals(0);
                
                //Se marca los datos que no se actualizaran 
                asignarDatosNoActualizables();
                //calcular la notaAutoEvalObj y notaAutoEvalComp 
                calcularNotaFinal();
                //cambiar el estado de la evaluacionDesemepenho 
                EvaluacionDesempenho.estado = (int)EstadoEvD.FinalFinalizada;
                //Asignar escala 
                asignarEscala();
                //Asignar observaciones 
                EvaluacionDesempenho.observacionesComp = txtObservacionesCompetencias.Text;
                EvaluacionDesempenho.observacionesObj = txtObservacionesObjetivos.Text;
                //Se actualiza 
                int resultado = 0;
                if (seRegistra) resultado = daoEvaluacionDesempenho.insertarLineasEvaluacionDesempenho(EvaluacionDesempenho);
                else resultado = daoEvaluacionDesempenho.actualizarEvaluacionDesempenho(EvaluacionDesempenho);
                if (resultado == 0)
                {
                    MessageBox.Show("Ocurrio un error, intentelo nuevamente",
                        "Mensaje de Error", MessageBoxButtons.OK,
                         MessageBoxIcon.Error);
                    return;
                }
                MessageBox.Show("Ha finalizado la Evaluación Final de Desempeño",
                "Mensaje Informativo", MessageBoxButtons.OK,
                MessageBoxIcon.Information);
                actualizarInformacionFormulario();
                cambiarEstado(EstadoFormulario.NoEditable);
            }
        }

        private void RadioButton2_Clicked(object sender, EventArgs e)
        {
            RadioButton2 rb = (sender as RadioButton2);

            if (!rb.Checked)
            {
                foreach (var c in Controls)
                {
                    if (c is RadioButton2 && (c as RadioButton2).GroupName == rb.GroupName)
                    {
                        (c as RadioButton2).Checked = false;
                    }
                }

                rb.Checked = true;
            }
        }

        private void btnRegresar_Click(object sender, EventArgs e)
        {
            var result = DialogResult.Yes;
            if (Estado.Equals(EstadoFormulario.Editable))
            {
                result = MessageBox.Show("¿Esta seguro que desea salir? Se perderán los cambios no guardados.",
                "Mensaje de Advertencia", MessageBoxButtons.YesNo,
                MessageBoxIcon.Information);
            }
            if (result == DialogResult.Yes)
            {
                frmEvMisTrabajadoresOpciones form = new frmEvMisTrabajadoresOpciones();
                form.Periodo = periodo;
                form.Colaborador = colaborador;
                Global.formPrincipal.abrirFormularioHijo(true, form);
            }
        }

        private void frmEvMisTrabajadoresFinal_Load(object sender, EventArgs e)
        {
            daoEvaluacionDesempenho = new EvaluacionDesempenhoWS.EvaluacionDesempenhoWSClient();
            daoPesoCriterio = new PesoCriterioWS.PesoCriterioWSClient();
            daoPeriodo = new PeriodoWS.PeriodoWSClient();
            secciones = new BindingList<BindingList<SeccionSubcompetencia>>();
            idColaborador = colaborador.idColaborador;
            idPuestoTrabajo = colaborador.puestoTrabajo.idPuestoTrabajo;
            idPeriodo = Periodo.idPeriodo;

            //Cargar datos de colaborador en pantalla 
            cargarDatosColaboradorEnPantalla();
            //Si por algun motivo no se realizo la evaluacion previa ni la autoevaluacion
            if (EvaluacionDesempenho.estado.Equals(0) && EvaluacionDesempenho.estadoAutoEval.Equals(0))
            {
                //Se deben asignar las competencias y subcompetencias 
                asignarCompetencias();
            }

            if (EvaluacionDesempenho.estado <= (int)EstadoEvD.PrevFinalizada)
            {
                txtNotaObjetivos.Text = "-/100";
                txtNotaCompetencias.Text = "-/100";
            }
            //Si ha sido iniciada la evaluacion final
            else
            {
                double notaObj, notaComp;
                notaObj = Math.Round(EvaluacionDesempenho.notaFinalObj * 100);
                notaComp = Math.Round((EvaluacionDesempenho.notaFinalComp / 5) * 100);
                txtNotaObjetivos.Text = notaObj.ToString() + "/100";
                txtNotaCompetencias.Text = notaComp + "/100";
                txtNotaDesempenho.Text = evaluacionDesempenho.escalaPreCupos.nombre; 
            }

            txtObservacionesCompetencias.Text = evaluacionDesempenho.observacionesComp;
            txtObservacionesObjetivos.Text = evaluacionDesempenho.observacionesObj;

            //Cargar Objetivos y competencias en pantalla 
            cargarObjetivosEnPantalla();
            cargarCompetenciasEnPantalla();
            cambiarEstado(Estado);
        }

    }
}
