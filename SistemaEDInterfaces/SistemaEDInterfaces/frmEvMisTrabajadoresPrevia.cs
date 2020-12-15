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
        private BindingList<TextBox> txtBoxObjetivos;
        private BindingList<TextBox> txtBoxCompetencias;
        private ColaboradorWS.colaborador colaborador;
        private PeriodoWS.periodo periodo;
        private BindingList<BindingList<SeccionSubcompetencia>> secciones;

        public colaborador Colaborador { get => colaborador; set => colaborador = value; }
        public EstadoFormulario Estado { get => estado; set => estado = value; }
        public EvaluacionDesempenhoWS.evaluacionDesempenho EvaluacionDesempenho { get => evaluacionDesempenho; set => evaluacionDesempenho = value; }
        public PeriodoWS.periodo Periodo { get => periodo; set => periodo = value; }

        public frmEvMisTrabajadoresPrevia()
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
            foreach (EvaluacionDesempenhoWS.objetivo o in evaluacionDesempenho.objetivos)
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
                x = lblLogro.Location.X;

                TextBox txtLogro = new TextBox();
                txtLogro.Location = new Point(x, y);
                txtLogro.Font = new Font("Microsoft Sans Serif", 15);
                txtLogro.Text = o.notaPrevia.ToString();
                txtLogro.KeyPress += txt_KeyPress;

                txtBoxObjetivos.Add(txtLogro);
                this.Controls.Add(labelNombre);
                this.Controls.Add(labelCantidad);
                this.Controls.Add(labelPeso);
                this.Controls.Add(txtLogro);

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
            foreach (EvaluacionDesempenhoWS.lineaEvaluacion l in evaluacionDesempenho.lineasEvaluacion)
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
                x = lblNotaCompetencias.Location.X;
                TextBox txtNota = new TextBox();
                txtNota.Location = new Point(x, y);
                txtNota.Font = new Font("Microsoft Sans Serif", 15);
                txtNota.Text = l.notaPrevia.ToString();

                txtNota.Enabled = false;

                txtBoxCompetencias.Add(txtNota);
                this.Controls.Add(labelNombre);
                this.Controls.Add(txtNota);


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
                    this.Controls.Add(lblNombreSubcriterio);
                    //Crear radiobuttons
                    agregarRadioButtons(sl.notaPrevia, agrupacionSubcompetencia, lblNombreSubcriterio);
                    y += lblNombreSubcriterio.Height + 30;
                    sumaY += lblNombreSubcriterio.Height + 30;
                    agrupacionCompetencia.Add(agrupacionSubcompetencia);
                }
                secciones.Add(agrupacionCompetencia);
            }
            sumaY += 15;
            btnGuardar.Location = new Point(btnGuardar.Location.X, btnGuardar.Location.Y + sumaY);
            btnFinalizar.Location = new Point(btnFinalizar.Location.X, btnFinalizar.Location.Y + sumaY);
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
            EvaluacionDesempenho.notaAutoEvalComp = -1;
            EvaluacionDesempenho.notaFinalComp = -1;
            EvaluacionDesempenho.observacionesObj = "";
            EvaluacionDesempenho.observacionesComp = "";
            EvaluacionDesempenho.notaAutoEvalObj = -1;
            EvaluacionDesempenho.notaFinalObj = -1;
            EvaluacionDesempenho.notaAutoEval = -1;
            EvaluacionDesempenho.observaciones = "";
            EvaluacionDesempenho.estadoPDI = -1;
            EvaluacionDesempenho.notaFinal = -1;
            EvaluacionDesempenho.escalaFinal = new EvaluacionDesempenhoWS.escala();
            EvaluacionDesempenho.escalaFinal.idEscala = -1;
            EvaluacionDesempenho.escalaPreCupos = new EvaluacionDesempenhoWS.escala();
            EvaluacionDesempenho.escalaPreCupos.idEscala = -1;
            EvaluacionDesempenho.escalaSinCalibrar = new EvaluacionDesempenhoWS.escala();
            EvaluacionDesempenho.escalaSinCalibrar.idEscala = -1;

            for (int i = 0; i < EvaluacionDesempenho.lineasEvaluacion.Count(); i++)
            {

                EvaluacionDesempenho.lineasEvaluacion[i].notaAutoEval = -1;
                EvaluacionDesempenho.lineasEvaluacion[i].notaFinal = -1;
                EvaluacionDesempenho.lineasEvaluacion[i].accionesAtomar = "";
                EvaluacionDesempenho.lineasEvaluacion[i].fechaCumplimiento = DateTime.Parse("01/01/2010");
                EvaluacionDesempenho.lineasEvaluacion[i].fechaCumplimientoSpecified = true;
                EvaluacionDesempenho.lineasEvaluacion[i].itemPDI = new EvaluacionDesempenhoWS.itemPDI();
                EvaluacionDesempenho.lineasEvaluacion[i].itemPDI.idItemPDI = -1;
                for (int j = 0; j < EvaluacionDesempenho.lineasEvaluacion[i].sublineasEvaluacion.Count(); j++)
                {
                    EvaluacionDesempenho.lineasEvaluacion[i].sublineasEvaluacion[j].notaAutoEval = -1;
                    EvaluacionDesempenho.lineasEvaluacion[i].sublineasEvaluacion[j].notaFinal = -1;
                    EvaluacionDesempenho.lineasEvaluacion[i].sublineasEvaluacion[j].accionesAtomar = "";
                    EvaluacionDesempenho.lineasEvaluacion[i].sublineasEvaluacion[j].fechaCumplimiento = DateTime.Parse("01/01/2010");
                    EvaluacionDesempenho.lineasEvaluacion[i].sublineasEvaluacion[j].fechaCumplimientoSpecified = true;
                    EvaluacionDesempenho.lineasEvaluacion[i].sublineasEvaluacion[j].itemPDI = new EvaluacionDesempenhoWS.itemPDI();
                    EvaluacionDesempenho.lineasEvaluacion[i].sublineasEvaluacion[j].itemPDI.idItemPDI = -1;
                }
            }
        }
        private void calcularNotaPrevia()
        {
            double notaObj = 0.0, notaComp = 0.0, notaCriterio;

            for (int i = 0; i < evaluacionDesempenho.lineasEvaluacion.Count(); i++)
            {
                //Asignar notas de subcriterios 
                notaCriterio = 0.0;
                for (int j = 0; j < evaluacionDesempenho.lineasEvaluacion[i].sublineasEvaluacion.Count(); j++)
                {
                    SeccionSubcompetencia agrupacionSubcompetencia = secciones.ElementAt(i).ElementAt(j);
                    if (agrupacionSubcompetencia.RbNota1.Checked)
                    {
                        evaluacionDesempenho.lineasEvaluacion[i].sublineasEvaluacion[j].notaPrevia = 1;

                    }
                    else if (agrupacionSubcompetencia.RbNota2.Checked)
                    {
                        evaluacionDesempenho.lineasEvaluacion[i].sublineasEvaluacion[j].notaPrevia = 2;

                    }
                    else if (agrupacionSubcompetencia.RbNota3.Checked)
                    {
                        evaluacionDesempenho.lineasEvaluacion[i].sublineasEvaluacion[j].notaPrevia = 3;
                    }
                    else if (agrupacionSubcompetencia.RbNota4.Checked)
                    {
                        evaluacionDesempenho.lineasEvaluacion[i].sublineasEvaluacion[j].notaPrevia = 4;
                    }
                    else if (agrupacionSubcompetencia.RbNota5.Checked)
                    {
                        evaluacionDesempenho.lineasEvaluacion[i].sublineasEvaluacion[j].notaPrevia = 5;
                    }
                    notaCriterio += evaluacionDesempenho.lineasEvaluacion[i].sublineasEvaluacion[j].notaPrevia
                                                * (evaluacionDesempenho.lineasEvaluacion[i].sublineasEvaluacion[j].pesoCriterio.peso / 100);

                }
                evaluacionDesempenho.lineasEvaluacion[i].notaPrevia = Math.Round(notaCriterio, 2);
                notaComp += notaCriterio * (evaluacionDesempenho.lineasEvaluacion[i].pesoCriterio.peso / 100);
            }
            for (int i = 0; i < evaluacionDesempenho.objetivos.Count(); i++)
            {
                evaluacionDesempenho.objetivos[i].notaPrevia = Double.Parse(txtBoxObjetivos.ElementAt(i).Text);
                if (evaluacionDesempenho.objetivos[i].notaPrevia > evaluacionDesempenho.objetivos[i].meta)
                {
                    notaObj += 1 * (evaluacionDesempenho.objetivos[i].peso / 100);
                }
                else notaObj += (evaluacionDesempenho.objetivos[i].notaPrevia / evaluacionDesempenho.objetivos[i].meta) * (evaluacionDesempenho.objetivos[i].peso / 100);
            }
            evaluacionDesempenho.notaPreviaComp = Math.Round(notaComp, 2);
            evaluacionDesempenho.notaPreviaObj = Math.Round(notaObj, 2);
        }
        private void actualizarInformacionFormulario()
        {
            double notaObj, notaComp;
            notaObj = Math.Round(evaluacionDesempenho.notaPreviaObj * 100);
            notaComp = Math.Round((evaluacionDesempenho.notaPreviaComp / 5) * 100);
            txtNotaObjetivos.Text = notaObj.ToString() + "/100";
            txtNotaCompetencias.Text = notaComp + "/100";

            for (int i = 0; i < txtBoxCompetencias.Count(); i++)
            {
                txtBoxCompetencias.ElementAt(i).Text = evaluacionDesempenho.lineasEvaluacion[i].notaPrevia.ToString();
            }
        }

        private void btnGuardar_Click(object sender, EventArgs e)
        {
            //Verificar si se deben registrar o actualizar las lineas de evaluacion 
            bool seRegistra = evaluacionDesempenho.estadoAutoEval.Equals(0) && evaluacionDesempenho.estado.Equals(0);
            //Se marca los datos que no se actualizaran 
            asignarDatosNoActualizables();
            //calcular la notaPreviaObj y notaPreviaComp 
            calcularNotaPrevia();
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
                bool seRegistra = evaluacionDesempenho.estadoAutoEval.Equals(0) && evaluacionDesempenho.estado.Equals(0);

                //Se marca los datos que no se actualizaran 
                asignarDatosNoActualizables();
                //calcular la notaPreviaObj y notaPreviaComp 
                calcularNotaPrevia();
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
                MessageBox.Show("Ha finalizado la Evaluación Previa de Desempeño",
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
            if (result== DialogResult.Yes)
            {
                frmEvMisTrabajadoresOpciones form = new frmEvMisTrabajadoresOpciones();
                form.Periodo = Global.periodoActual;
                form.Colaborador = colaborador;
                Global.formPrincipal.abrirFormularioHijo(true, form);
            }
        }
        private void frmEvMisTrabajadoresPrevia_Load(object sender, EventArgs e)
        {
            daoEvaluacionDesempenho = new EvaluacionDesempenhoWS.EvaluacionDesempenhoWSClient();
            daoPesoCriterio = new PesoCriterioWS.PesoCriterioWSClient(); 

            secciones = new BindingList<BindingList<SeccionSubcompetencia>>();
            idColaborador = colaborador.idColaborador;
            idPuestoTrabajo = colaborador.puestoTrabajo.idPuestoTrabajo;
            idPeriodo = periodo.idPeriodo;

            //Cargar datos de colaborador en pantalla 
            cargarDatosColaboradorEnPantalla();

            // Evaluacion previa y autoevaluacion No iniciada
            if (evaluacionDesempenho.estado.Equals(0) && evaluacionDesempenho.estadoAutoEval.Equals(0))
            {
                //Se deben asignar las competencias y subcompetencias 
                asignarCompetencias();
                txtNotaObjetivos.Text = "-/100";
                txtNotaCompetencias.Text = "-/100";
            }
            //Si ha sido iniciada cualquiera de ellas
            else
            {
                double notaObj, notaComp;
                notaObj = Math.Round(evaluacionDesempenho.notaPreviaObj * 100);
                notaComp = Math.Round((evaluacionDesempenho.notaPreviaComp / 5) * 100);
                txtNotaObjetivos.Text = notaObj.ToString() + "/100";
                txtNotaCompetencias.Text = notaComp + "/100";
            }

            //Cargar Objetivos y competencias en pantalla 
            cargarObjetivosEnPantalla();
            cargarCompetenciasEnPantalla();
            cambiarEstado(Estado);
        }

    }
}
