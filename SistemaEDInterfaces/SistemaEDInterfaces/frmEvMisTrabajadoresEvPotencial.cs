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
        private BindingList<TextBox> txtBoxPotenciales;
        private BindingList<BindingList<SeccionSubpotencial>> secciones; 
        public colaborador Colaborador { get => colaborador; set => colaborador = value; }
        public EvaluacionPotencialWS.evaluacion EvaluacionPotencial { get => evaluacionPotencial; set => evaluacionPotencial = value; }
        public PeriodoWS.periodo Periodo { get => periodo; set => periodo = value; }
        public EstadoFormulario Estado { get => estado; set => estado = value; }

        public frmEvMisTrabajadoresEvPotencial()
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

            btnGuardar.Location = new Point(btnGuardar.Location.X, btnGuardar.Location.Y + diferenciaY);
            btnFinalizar.Location = new Point(btnFinalizar.Location.X, btnFinalizar.Location.Y + diferenciaY);
            lblObservaciones.Location = new Point(lblObservaciones.Location.X, lblObservaciones.Location.Y + diferenciaY);
            txtObservaciones.Location = new Point(txtObservaciones.Location.X, txtObservaciones.Location.Y + diferenciaY);
            lblMaxCar.Location = new Point(lblMaxCar.Location.X, lblMaxCar.Location.Y + diferenciaY);
            lblFantasma.Location = new Point(lblFantasma.Location.X, lblFantasma.Location.Y + diferenciaY); 
        }

        private RadioButton2 crearRadioButtonSubpotencial(Label lblOpcion, Label lblNombreGrupo)
        {
            RadioButton2 rb = new RadioButton2();
            rb.Location = new Point(lblOpcion.Location.X + lblOpcion.Width+10, lblOpcion.Location.Y + 5);
            rb.Width = lblOpcion.Width;
            rb.GroupName = lblNombreGrupo.Text;
            rb.AutoSize = true;
            rb.AutoCheck = false;
            rb.Click += RadioButton2_Clicked;
            return rb;
        }

        private void agregarRadioButtons(double nota, SeccionSubpotencial agrupacionSubpotencial,
                                                            Label lblNombre)
        {
            //Crear label si/no de la sublinea 
            Label lblSiLinea =  crearLabelSublinea(lblNombre,lblSi);
            Label lblNoLinea = crearLabelSublinea(lblNombre, lblNo);

            this.Controls.Add(lblSiLinea);
            this.Controls.Add(lblNoLinea);

            RadioButton2 rbOpcionSi = crearRadioButtonSubpotencial(lblSiLinea, lblNombre);
            RadioButton2 rbOpcionNo = crearRadioButtonSubpotencial(lblNoLinea, lblNombre);

           
            this.Controls.Add(rbOpcionSi);
            this.Controls.Add(rbOpcionNo);
            agrupacionSubpotencial.RbOpcionSi = rbOpcionSi;
            agrupacionSubpotencial.RbOpcionNo = rbOpcionNo;

            if (nota == 1)
            {
                rbOpcionSi.Checked = true;
            }
            else
            {
                rbOpcionNo.Checked = true;
            }

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

        private void cargarPotencialesEnPantalla()
        {
            int y, sumaY = 20, x;
            y = lblDescripcionPotenciales.Location.Y + lblDescripcionPotenciales.Height + 20;
            sumaY = 20;
            txtBoxPotenciales = new BindingList<TextBox>();
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
                //txtNota.Width = 50; 
                //txtNota.Width = txtNotaCompetencias.Width; 
                txtNota.Enabled = false;

                txtBoxPotenciales.Add(txtNota);
                this.Controls.Add(labelNombre);
                this.Controls.Add(txtNota);

                y += labelNombre.Height + 20;
                sumaY += labelNombre.Height + 20;
                BindingList<SeccionSubpotencial> agrupacionPotencial;
                agrupacionPotencial = new BindingList<SeccionSubpotencial>();

                foreach (EvaluacionPotencialWS.lineaEvaluacion sl in l.sublineasEvaluacion)
                {
                    SeccionSubpotencial agrupacionSubpotencial = new SeccionSubpotencial();
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
                    agregarRadioButtons(sl.notaFinal, agrupacionSubpotencial, lblNombreSubcriterio);
                    y += lblNombreSubcriterio.Height + 30;
                    sumaY += lblNombreSubcriterio.Height + 30;
                    agrupacionPotencial.Add(agrupacionSubpotencial);
                }
                secciones.Add(agrupacionPotencial);
            }
            sumaY += 15;
            reposicionarElementos(sumaY);

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
            EvaluacionPotencial.lineasEvaluacion = lineasEv.ToArray();
        }

        private void cambiarEstado(EstadoFormulario estadoNuevo)
        {
            this.Estado = estadoNuevo;

            if (estadoNuevo.Equals(EstadoFormulario.Editable))
            {
                btnGuardar.Enabled = true;
                btnFinalizar.Enabled = true;
                txtObservaciones.Enabled = true;
            }
            else if (estadoNuevo.Equals(EstadoFormulario.NoEditable))
            {
                btnGuardar.Enabled = false;
                btnFinalizar.Enabled = false;
                txtObservaciones.Enabled = false;
                for (int i = 0; i < secciones.Count(); i++)
                {
                    for (int j = 0; j < secciones.ElementAt(i).Count(); j++)
                    {
                        secciones.ElementAt(i).ElementAt(j).RbOpcionSi.Enabled = false;
                        secciones.ElementAt(i).ElementAt(j).RbOpcionNo.Enabled = false;

                    }
                }
            }
        }


        private void asignarDatosNoActualizables()
        {
            EvaluacionPotencial.observaciones = "";
            EvaluacionPotencial.estadoPDI = -1;
            EvaluacionPotencial.escalaFinal = new EvaluacionPotencialWS.escala();
            EvaluacionPotencial.escalaFinal.idEscala = -1;
            EvaluacionPotencial.escalaSinCalibrar = new EvaluacionPotencialWS.escala();
            EvaluacionPotencial.escalaSinCalibrar.idEscala = -1;

            for (int i = 0; i < EvaluacionPotencial.lineasEvaluacion.Count(); i++)
            {

                EvaluacionPotencial.lineasEvaluacion[i].accionesAtomar = "";
                EvaluacionPotencial.lineasEvaluacion[i].fechaCumplimiento = DateTime.Parse("01/01/2010");
                EvaluacionPotencial.lineasEvaluacion[i].fechaCumplimientoSpecified = true;
                EvaluacionPotencial.lineasEvaluacion[i].itemPDI = new EvaluacionPotencialWS.itemPDI();
                EvaluacionPotencial.lineasEvaluacion[i].itemPDI.idItemPDI = -1;
                for (int j = 0; j < EvaluacionPotencial.lineasEvaluacion[i].sublineasEvaluacion.Count(); j++)
                {
                    EvaluacionPotencial.lineasEvaluacion[i].sublineasEvaluacion[j].accionesAtomar = "";
                    EvaluacionPotencial.lineasEvaluacion[i].sublineasEvaluacion[j].fechaCumplimiento = DateTime.Parse("01/01/2010");
                    EvaluacionPotencial.lineasEvaluacion[i].sublineasEvaluacion[j].fechaCumplimientoSpecified = true;
                    EvaluacionPotencial.lineasEvaluacion[i].sublineasEvaluacion[j].itemPDI = new EvaluacionPotencialWS.itemPDI();
                    EvaluacionPotencial.lineasEvaluacion[i].sublineasEvaluacion[j].itemPDI.idItemPDI = -1;
                }
            }
        }
        private void calcularNotaFinal()
        {
            double  notaPot = 0.0,notaCriterio;

            for (int i = 0; i < EvaluacionPotencial.lineasEvaluacion.Count(); i++)
            {
                //Asignar notas de subcriterios
                notaCriterio = 0.0; 

                for(int j=0; j< evaluacionPotencial.lineasEvaluacion[i].sublineasEvaluacion.Count();j++)
                {
                    SeccionSubpotencial agrupacionSubpotencial = secciones.ElementAt(i).ElementAt(j);
                    if (agrupacionSubpotencial.RbOpcionSi.Checked)
                    {
                        evaluacionPotencial.lineasEvaluacion[i].sublineasEvaluacion[j].notaFinal = 1; 
                    }
                    else
                    {
                        evaluacionPotencial.lineasEvaluacion[i].sublineasEvaluacion[j].notaFinal = 0;
                    }
                    notaCriterio += evaluacionPotencial.lineasEvaluacion[i].sublineasEvaluacion[j].notaFinal
                                      * (evaluacionPotencial.lineasEvaluacion[i].sublineasEvaluacion[j].pesoCriterio.peso / 100);

                }
                evaluacionPotencial.lineasEvaluacion[i].notaFinal = Math.Round(notaCriterio, 2); 

                notaPot += notaCriterio * (EvaluacionPotencial.lineasEvaluacion[i].pesoCriterio.peso / 100);
            }
            EvaluacionPotencial.notaFinal = notaPot;
        }

        private void actualizarInformacionFormulario()
        {
            txtNotaPotencial.Text = evaluacionPotencial.escalaPreCupos.nombre;
            for (int i = 0; i < txtBoxPotenciales.Count(); i++)
            {
                double auxNota = Math.Round(evaluacionPotencial.lineasEvaluacion[i].notaFinal * 100);
                txtBoxPotenciales.ElementAt(i).Text = auxNota.ToString() + "/100";
            }

        }
        private void asignarEscala()
        {
            EvaluacionPotencial.escalaPreCupos = new EvaluacionPotencialWS.escala();
            //EvaluacionPotencial.escalaSinCalibrar = new EvaluacionPotencialWS.escala();
            //EvaluacionPotencial.escalaFinal = new EvaluacionPotencialWS.escala();
            PeriodoWS.escalaPeriodo[] lista = daoPeriodo.listarEscalaPeriodo(Periodo.idPeriodo);
            BindingList<PeriodoWS.escalaPeriodo> escalasPeriodos;
            if (lista != null)
            {
                escalasPeriodos = new BindingList<PeriodoWS.escalaPeriodo>(lista);
                foreach (PeriodoWS.escalaPeriodo ep in escalasPeriodos)
                {
                    if (((EvaluacionPotencial.notaFinal * 100) < ep.notaMax &&
                        (EvaluacionPotencial.notaFinal * 100) >= ep.notaMin && ep.escala.tipo) || ((EvaluacionPotencial.notaFinal * 100) == ep.notaMax && ep.escala.nombre == "Alto"))
                    {
                        EvaluacionPotencial.escalaPreCupos.idEscala = ep.escala.idEscala;
                        EvaluacionPotencial.escalaPreCupos.nombre = ep.escala.nombre;
                        //EvaluacionPotencial.escalaSinCalibrar.idEscala = ep.escala.idEscala;
                        //EvaluacionPotencial.escalaSinCalibrar.nombre = ep.escala.nombre;
                        //EvaluacionPotencial.escalaFinal.idEscala = ep.escala.idEscala;
                        //EvaluacionPotencial.escalaFinal.nombre = ep.escala.nombre;
                    }
                }
            }

        }


        
        private void btnGuardar_Click(object sender, EventArgs e)
        {
            //Verificar si se deben registrar o actualizar las lineas de evaluacion 
            bool seRegistra = EvaluacionPotencial.estado.Equals(0);
            //Se marca los datos que no se actualizaran 
            asignarDatosNoActualizables();
            //calcular la notaAutoEvalObj y notaAutoEvalComp 
            calcularNotaFinal();
            //cambiar el estado de la evaluacionPotencial 
            EvaluacionPotencial.estado = (int)EstadoEvalPot.Iniciada;
            //Asignar escala 
            asignarEscala();
            //Asignar observaciones 
            EvaluacionPotencial.observaciones = txtObservaciones.Text; 
            //Se actualiza 
            int resultado = 0;
            if (seRegistra) resultado = daoEvaluacionPotencial.insertarLineasEvaluacionPotencial(EvaluacionPotencial);
            else resultado = daoEvaluacionPotencial.actualizarEvaluacionPotencial(EvaluacionPotencial);
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
                bool seRegistra = EvaluacionPotencial.estado.Equals(0);
                //Se marca los datos que no se actualizaran 
                asignarDatosNoActualizables();
                //calcular la notaAutoEvalObj y notaAutoEvalComp 
                calcularNotaFinal();
                //cambiar el estado de la evaluacionPotencial 
                EvaluacionPotencial.estado = (int)EstadoEvalPot.Finalizada;
                //Asignar escala 
                asignarEscala();
                //Asignar observaciones 
                EvaluacionPotencial.observaciones = txtObservaciones.Text;
                //Se actualiza 
                int resultado = 0;
                if (seRegistra) resultado = daoEvaluacionPotencial.insertarLineasEvaluacionPotencial(EvaluacionPotencial);
                else resultado = daoEvaluacionPotencial.actualizarEvaluacionPotencial(EvaluacionPotencial);
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
        private void frmEvMisTrabajadoresEvPotencial_Load(object sender, EventArgs e)
        {
            lblSi.Hide();
            lblNo.Hide();
            daoEvaluacionPotencial = new EvaluacionPotencialWS.EvaluacionPotencialWSClient();
            daoPesoCriterio = new PesoCriterioWS.PesoCriterioWSClient();
            daoPeriodo = new PeriodoWS.PeriodoWSClient();
            secciones = new BindingList<BindingList<SeccionSubpotencial>>();
            idColaborador = colaborador.idColaborador;
            idPuestoTrabajo = colaborador.puestoTrabajo.idPuestoTrabajo;
            idPeriodo = periodo.idPeriodo;

            //Cargar datos de colaborador en pantalla 
            cargarDatosColaboradorEnPantalla();
            EvaluacionPotencial = daoEvaluacionPotencial.obtenerEvaluacionPotencial(idColaborador, idPeriodo);
            // Evaluacion  No iniciada
            if (EvaluacionPotencial.estado.Equals(0))
            {
                //Se deben asignar los potenciales
                asignarPotenciales();
            }
            //Si ha sido iniciada 
            else if (EvaluacionPotencial.estado == (int)EstadoEvalPot.Iniciada|| EvaluacionPotencial.estado == (int)EstadoEvalPot.Finalizada)
            {
                txtNotaPotencial.Text = EvaluacionPotencial.escalaPreCupos.nombre;
                txtObservaciones.Text = EvaluacionPotencial.observaciones;
            }

            cargarPotencialesEnPantalla();
            cambiarEstado(Estado);
        }

    }
}
