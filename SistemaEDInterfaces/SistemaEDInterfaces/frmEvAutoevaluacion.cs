﻿using System;
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
    public partial class frmEvAutoevaluacion : Form
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
        private BindingList<BindingList<SeccionSubcompetencia>> secciones;

        public EstadoFormulario Estado { get => estado; set => estado = value; }

        public frmEvAutoevaluacion()
        {
            InitializeComponent();

            

        }

        private void cargarObjetivosYCompetenciasEnPantalla()
        {
            int y = lblObjetivo.Location.Y + lblObjetivo.Height + 20, sumaY = 20;
            int x;
            txtBoxObjetivos = new BindingList<TextBox>(); 
            foreach(EvaluacionDesempenhoWS.objetivo o in evaluacionDesempenho.objetivos)
            {
                x = lblObjetivo.Location.X; 
                //Label de nombre 
                Label labelNombre = new Label();
                labelNombre.Location = new Point(x, y);
                labelNombre.Text = o.descripcion;
                labelNombre.AutoSize = true;
                labelNombre.MaximumSize = new Size(350, 0);
                labelNombre.Font = new Font("Microsoft Sans Serif",15);
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
                txtLogro.Text = o.notaAutoEval.ToString(); 

                txtBoxObjetivos.Add(txtLogro);
                this.Controls.Add(labelNombre);
                this.Controls.Add(labelCantidad); 
                this.Controls.Add(labelPeso);
                this.Controls.Add(txtLogro);

                y += labelNombre.Height + 20;
                sumaY += labelNombre.Height + 20;
            }
            //sumaY += 15;
            
            lblTituloCompetencias.Location = new Point(lblTituloCompetencias.Location.X,lblTituloCompetencias.Location.Y + sumaY);
            lblDescripcionCompetencias.Location = new Point(lblDescripcionCompetencias.Location.X, lblDescripcionCompetencias.Location.Y + sumaY);
            lblNotaCompetencias.Location = new Point(lblNotaCompetencias.Location.X, lblNotaCompetencias.Location.Y + sumaY);
            txtNotaCompetencias.Location = new Point(txtNotaCompetencias.Location.X, txtNotaCompetencias.Location.Y + sumaY);
            btnGuardar.Location = new Point(btnGuardar.Location.X, btnGuardar.Location.Y + sumaY);
            btnFinalizar.Location = new Point(btnFinalizar.Location.X, btnFinalizar.Location.Y + sumaY);
            lbl1.Location = new Point(lbl1.Location.X, lbl1.Location.Y + sumaY);
            lbl2.Location = new Point(lbl2.Location.X, lbl2.Location.Y + sumaY);
            lbl3.Location = new Point(lbl3.Location.X, lbl3.Location.Y + sumaY);
            lbl4.Location = new Point(lbl4.Location.X, lbl4.Location.Y + sumaY);
            lbl5.Location = new Point(lbl5.Location.X, lbl5.Location.Y + sumaY);

            /*lbl1.Hide();
            lbl2.Hide();
            lbl3.Hide();
            lbl4.Hide();
            lbl5.Hide(); 
            */
            //Competencias 
            y = lblDescripcionCompetencias.Location.Y + lblDescripcionCompetencias.Height + 20;
            sumaY = 20;
            txtBoxCompetencias = new BindingList<TextBox>();
            foreach (EvaluacionDesempenhoWS.lineaEvaluacion l in evaluacionDesempenho.lineasEvaluacion)
            {
                x = lblDescripcionCompetencias.Location.X; 
                Label labelNombre = new Label();
                labelNombre.Location = new Point(x, y);
                labelNombre.Text = l.pesoCriterio.criterio.nombre + "("+ l.pesoCriterio.peso +"%)";
                labelNombre.AutoSize = true;
                labelNombre.MaximumSize = new Size(350, 0);
                labelNombre.Font = new Font("Microsoft Sans Serif", 15,FontStyle.Bold);
                labelNombre.ForeColor = new Color();
                labelNombre.ForeColor =  Color.FromArgb(0,66,122);
                x = lblNotaCompetencias.Location.X;
                TextBox txtNota = new TextBox();
                txtNota.Location = new Point(x, y);
                txtNota.Font = new Font("Microsoft Sans Serif", 15);
                txtNota.Text = l.notaAutoEval.ToString();
                txtNota.Enabled = false;
                txtBoxCompetencias.Add(txtNota);

                this.Controls.Add(labelNombre);
                this.Controls.Add(txtNota);

                /*
                Label lblNota1 = new Label();
                lblNota1.Text = lbl1.Text;
                lblNota1.Width = lbl1.Width; 
                lblNota1.Font = new Font("Microsoft Sans Serif", 16, FontStyle.Bold);
                lblNota1.Location = new Point(lbl1.Location.X, labelNombre.Location.Y );
                this.Controls.Add(lblNota1);
                Label lblNota2 = new Label();
                lblNota2.Text = lbl2.Text;
                lblNota2.Width = lbl2.Width; 
                lblNota2.Font = new Font("Microsoft Sans Serif", 16, FontStyle.Bold);
                lblNota2.Location = new Point(lbl2.Location.X, labelNombre.Location.Y);
                this.Controls.Add(lblNota2);
                Label lblNota3 = new Label();
                lblNota3.Text = lbl3.Text;
                lblNota3.Width = lbl3.Width; 
                lblNota3.Font = new Font("Microsoft Sans Serif", 16, FontStyle.Bold);
                lblNota3.Location = new Point(lbl3.Location.X, labelNombre.Location.Y);
                this.Controls.Add(lblNota3);
                Label lblNota4 = new Label();
                lblNota4.Text = lbl4.Text;
                lblNota4.Width = lbl4.Width; 
                lblNota4.Font = new Font("Microsoft Sans Serif", 16, FontStyle.Bold);
                lblNota4.Location = new Point(lbl4.Location.X, labelNombre.Location.Y);
                this.Controls.Add(lblNota4);
                Label lblNota5 = new Label();
                lblNota5.Text = lbl5.Text;
                lblNota5.Width = lbl5.Width; 
                lblNota5.Font = new Font("Microsoft Sans Serif", 16, FontStyle.Bold);
                lblNota5.Location = new Point(lbl5.Location.X, labelNombre.Location.Y);
                this.Controls.Add(lblNota5);
                
                */
                y += labelNombre.Height + 20;
                sumaY += labelNombre.Height + 20;
                BindingList<SeccionSubcompetencia> agrupacionCompetencia;
                agrupacionCompetencia = new BindingList<SeccionSubcompetencia>();
                foreach (EvaluacionDesempenhoWS.lineaEvaluacion sl in l.sublineasEvaluacion)
                {
                    SeccionSubcompetencia agrupacionSubcompetencia = new SeccionSubcompetencia();
                    x = lblDescripcionCompetencias.Location.X + 40 ;
                    Label lblGuion = new Label();
                    lblGuion.Location = new Point(x, y);
                    lblGuion.Font = new Font("Microsoft Sans Serif", 15);
                    lblGuion.Text = "-";
                    lblGuion.Width = 20;
                    this.Controls.Add(lblGuion);
                    x = lblGuion.Location.X +  lblGuion.Width ;
                    Label lblNombreSubcriterio = new Label();
                    lblNombreSubcriterio.Location = new Point(x, y);
                    lblNombreSubcriterio.AutoSize = true;
                    lblNombreSubcriterio.MaximumSize = new Size(350, 0);
                    lblNombreSubcriterio.Font = new Font("Microsoft Sans Serif", 15);
                    lblNombreSubcriterio.Text = sl.pesoCriterio.criterio.nombre + "(" + sl.pesoCriterio.peso + "%)"; 
                    this.Controls.Add(lblNombreSubcriterio);

                    //Crear radiobuttons
                    RadioButton2 rb1 = new RadioButton2();
                    rb1.Location = new Point(lbl1.Location.X + 5, lblNombreSubcriterio.Location.Y);
                    rb1.Width = lbl1.Width;
                    rb1.GroupName = lblNombreSubcriterio.Text;
                    rb1.AutoSize = true;
                    rb1.AutoCheck = false;
                    rb1.Click += RadioButton2_Clicked;
                    RadioButton2 rb2 = new RadioButton2();
                    rb2.Location = new Point(lbl2.Location.X + 5, lblNombreSubcriterio.Location.Y);
                    rb2.Width = lbl2.Width;
                    rb2.GroupName = lblNombreSubcriterio.Text;
                    rb2.AutoSize = true;
                    rb2.AutoCheck = false;
                    rb2.Click += RadioButton2_Clicked;
                    RadioButton2 rb3 = new RadioButton2();
                    rb3.Location = new Point(lbl3.Location.X + 5, lblNombreSubcriterio.Location.Y);
                    rb3.Width = lbl3.Width;
                    rb3.GroupName = lblNombreSubcriterio.Text;
                    rb3.AutoSize = true;
                    rb3.AutoCheck = false;
                    rb3.Click += RadioButton2_Clicked;
                    RadioButton2 rb4 = new RadioButton2();
                    rb4.Location = new Point(lbl4.Location.X + 5, lblNombreSubcriterio.Location.Y);
                    rb4.Width = lbl4.Width;
                    rb4.GroupName = lblNombreSubcriterio.Text;
                    rb4.AutoSize = true;
                    rb4.AutoCheck = false;
                    rb4.Click += RadioButton2_Clicked;
                    RadioButton2 rb5 = new RadioButton2();
                    rb5.Location = new Point(lbl5.Location.X + 5, lblNombreSubcriterio.Location.Y);
                    rb5.Width = lbl5.Width;
                    rb5.GroupName = lblNombreSubcriterio.Text;
                    rb5.AutoSize = true;
                    rb5.AutoCheck = false;
                    rb5.Click += RadioButton2_Clicked;

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
                    agrupacionCompetencia.Add(agrupacionSubcompetencia);
                    if (sl.notaAutoEval == 5)
                    {
                        rb5.Checked = true;
                    } else if (sl.notaAutoEval == 4)
                    {
                        rb4.Checked = true;
                    } else if (sl.notaAutoEval == 3)
                    {
                        rb3.Checked = true;
                    } else if (sl.notaAutoEval == 2)
                    {
                        rb2.Checked = true;
                    }
                    else
                    {
                        rb1.Checked = true;
                    }

                    y += lblNombreSubcriterio.Height + 30;
                    sumaY += lblNombreSubcriterio.Height + 30;

                }
                secciones.Add(agrupacionCompetencia);


            }
            sumaY += 15;

            btnGuardar.Location = new Point(btnGuardar.Location.X, btnGuardar.Location.Y + sumaY);
            btnFinalizar.Location = new Point(btnFinalizar.Location.X, btnFinalizar.Location.Y + sumaY);

        }

        private void cargarCompetenciasEnPantalla()
        {

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

            for(int i = 0; i < lista.Count(); i++)
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
                for(int i = 0; i < txtBoxObjetivos.Count(); i++)
                {
                    txtBoxObjetivos.ElementAt(i).Enabled = false; 
                }
                for(int i = 0; i < secciones.Count(); i++)
                {
                    for(int j = 0; j < secciones.ElementAt(i).Count(); j++)
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

            for(int i = 0; i < evaluacionDesempenho.lineasEvaluacion.Count(); i++)
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
        private void calcularNotaAutoEv()
        {
            double notaObj=0.0, notaComp=0.0,notaCriterio;

            for(int i = 0; i < evaluacionDesempenho.lineasEvaluacion.Count(); i++)
            {
                //Asignar notas de subcriterios 
                notaCriterio = 0.0; 
                for(int j = 0; j < evaluacionDesempenho.lineasEvaluacion[i].sublineasEvaluacion.Count(); j++)
                {
                    SeccionSubcompetencia agrupacionSubcompetencia = secciones.ElementAt(i).ElementAt(j);
                    if (agrupacionSubcompetencia.RbNota1.Checked)
                    {
                        evaluacionDesempenho.lineasEvaluacion[i].sublineasEvaluacion[j].notaAutoEval = 1; 
                    
                    }else if (agrupacionSubcompetencia.RbNota2.Checked)
                    {
                        evaluacionDesempenho.lineasEvaluacion[i].sublineasEvaluacion[j].notaAutoEval = 2;

                    }else if (agrupacionSubcompetencia.RbNota3.Checked)
                    {
                        evaluacionDesempenho.lineasEvaluacion[i].sublineasEvaluacion[j].notaAutoEval = 3;
                    }
                    else if (agrupacionSubcompetencia.RbNota4.Checked)
                    {
                        evaluacionDesempenho.lineasEvaluacion[i].sublineasEvaluacion[j].notaAutoEval = 4;
                    }
                    else if (agrupacionSubcompetencia.RbNota5.Checked)
                    {
                        evaluacionDesempenho.lineasEvaluacion[i].sublineasEvaluacion[j].notaAutoEval = 5;
                    }
                    notaCriterio += evaluacionDesempenho.lineasEvaluacion[i].sublineasEvaluacion[j].notaAutoEval
                                                * (evaluacionDesempenho.lineasEvaluacion[i].sublineasEvaluacion[j].pesoCriterio.peso/100);

                }
                evaluacionDesempenho.lineasEvaluacion[i].notaAutoEval = Math.Round(notaCriterio,2);
                notaComp += notaCriterio * (evaluacionDesempenho.lineasEvaluacion[i].pesoCriterio.peso/100);
            }
            for(int i = 0; i < evaluacionDesempenho.objetivos.Count(); i++)
            {
                evaluacionDesempenho.objetivos[i].notaAutoEval = Double.Parse(txtBoxObjetivos.ElementAt(i).Text);
                notaObj += (evaluacionDesempenho.objetivos[i].notaAutoEval/evaluacionDesempenho.objetivos[i].meta) *(evaluacionDesempenho.objetivos[i].peso/100);
            }
            evaluacionDesempenho.notaAutoEvalComp = Math.Round(notaComp,2);
            evaluacionDesempenho.notaAutoEvalObj = Math.Round(notaObj,2); 
            
        }

        private void actualizarInformacionFormulario()
        {
            double notaObj, notaComp;
            notaObj = Math.Round(evaluacionDesempenho.notaAutoEvalObj * 100);
            notaComp = Math.Round((evaluacionDesempenho.notaAutoEvalComp / 5) * 100);
            txtNotaObjetivos.Text = notaObj.ToString() + "/100";
            txtNotaCompetencias.Text = notaComp + "/100";

            for(int i = 0; i < txtBoxCompetencias.Count(); i++)
            {
                txtBoxCompetencias.ElementAt(i).Text = evaluacionDesempenho.lineasEvaluacion[i].notaAutoEval.ToString();
            }
        }
        private void btnGuardar_Click(object sender, EventArgs e)
        {
            //Verificar si se deben registrar o actualizar las lineas de evaluacion 
            bool seRegistra = evaluacionDesempenho.estadoAutoEval.Equals(0) && evaluacionDesempenho.estado.Equals(0);
            //Se marca los datos que no se actualizaran 
            asignarDatosNoActualizables(); 
            //calcular la notaAutoEvalObj y notaAutoEvalComp 
            calcularNotaAutoEv();
            //cambiar el estado de la evaluacionDesemepenho 
            evaluacionDesempenho.estadoAutoEval = (int)EstadoAutoEval.Iniciada;
            //Se actualiza 
            int resultado=0;
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
            
            if(result == DialogResult.Yes)
            {
                //Verificar si se deben registrar o actualizar las lineas de evaluacion 
                bool seRegistra = evaluacionDesempenho.estadoAutoEval.Equals(0) && evaluacionDesempenho.estado.Equals(0);
                
                //Se marca los datos que no se actualizaran 
                asignarDatosNoActualizables();
                //calcular la notaAutoEvalObj y notaAutoEvalComp 
                calcularNotaAutoEv();
                //cambiar el estado de la evaluacionDesemepenho 
                evaluacionDesempenho.estadoAutoEval = (int)EstadoAutoEval.Finalizada;
                //Se actualiza 
                int resultado=0; 
                if(seRegistra) resultado = daoEvaluacionDesempenho.insertarLineasEvaluacionDesempenho(evaluacionDesempenho);
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
            Global.formPrincipal.abrirFormularioHijo(true, new frmEvAutoevaluacionPantallaPrevia());
        }

        private void frmEvAutoevaluacion_Load(object sender, EventArgs e)
        {
            secciones = new BindingList<BindingList<SeccionSubcompetencia>>();
            daoEvaluacionDesempenho = new EvaluacionDesempenhoWS.EvaluacionDesempenhoWSClient();
            daoPesoCriterio = new PesoCriterioWS.PesoCriterioWSClient();
            idColaborador = Global.colaboradorLoggeado.idColaborador;
            idPuestoTrabajo = Global.colaboradorLoggeado.puestoTrabajo.idPuestoTrabajo;
            idPeriodo = Global.periodoActual.idPeriodo;

            evaluacionDesempenho = daoEvaluacionDesempenho.obtenerEvaluacionDesempenho(idColaborador, idPeriodo);
            // Evaluacion previa No iniciada
            if (evaluacionDesempenho.estado.Equals(0) && evaluacionDesempenho.estadoAutoEval.Equals(0))
            {
                //Se deben asignar las competencias y subcompetencias 
                asignarCompetencias();
                txtNotaObjetivos.Text = "-/100";
                txtNotaCompetencias.Text = "-/100";
            }
            //Si ha sido iniciada 
            else
            {
                double notaObj, notaComp;
                notaObj = Math.Round(evaluacionDesempenho.notaAutoEvalObj * 100);
                notaComp = Math.Round((evaluacionDesempenho.notaAutoEvalComp / 5) * 100);
                txtNotaObjetivos.Text = notaObj.ToString() + "/100";
                txtNotaCompetencias.Text = notaComp + "/100";
            }

            //Cargar Objetivos y competencias en pantalla 
            cargarObjetivosYCompetenciasEnPantalla();
            cambiarEstado(Estado);
        }
    }
}
