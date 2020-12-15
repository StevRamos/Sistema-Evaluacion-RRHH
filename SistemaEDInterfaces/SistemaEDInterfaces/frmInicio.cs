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
   
    
    public partial class frmInicio : Form
    {
        List<Form>formulariosActuales = new List<Form>();
        PeriodoWS.PeriodoWSClient daoPeriodo;
        public frmInicio()
        {
            Global.formPrincipal = this;
            daoPeriodo = new PeriodoWS.PeriodoWSClient();
            Global.periodoActual = daoPeriodo.obtenerPeriodo();

            InitializeComponent();
            customizeDesign();

            ColaboradorWS.colaborador colaborador = Global.colaboradorLoggeado;
            btnLblNombreColab.Text = colaborador.nombres + " " + colaborador.apellidos;

            //Deshabilitar ventanas segun nivel de acceso del colaborador loggeado (nivel de permiso) 
            deshabilitarVentanasSegunNivelAcceso(); 
        }

        private void deshabilitarBoton(Button btnParaEliminar, Panel panelPadre)
        {
            btnParaEliminar.Hide();
            panelPadre.Height -= btnParaEliminar.Height; 
        }
        private void deshabilitarVentanasSegunNivelAcceso()
        {
            int nivelAcceso = Global.colaboradorLoggeado.usuario.nivelAcceso; 
            
            //Bloquear ventanas que son solo para administradores 
            if(nivelAcceso < (int) NivelAcceso.Admin)
            {
                btnAdministracion.Hide();
                deshabilitarBoton(btnRepPlanificacion, panelReportesSubmenu); 
            }
            if (nivelAcceso < (int)NivelAcceso.Jefe)
            {
                deshabilitarBoton(btnPlanValidarObjetivos,panelPlanificacionSubmenu);
                deshabilitarBoton(btnEvMisTrabajadores, panelEvaluacionSubmenu);
                deshabilitarBoton(btnHisMisTrabajadores, panelHistorialSubmenu);
                btnReportes.Hide(); 
            }
        }



        public void abrirFormularioHijo(bool cerrarPadre, Form formularioHijo)
        {
            if (cerrarPadre)
            {
                int n = formulariosActuales.Count - 1;
                if (n >= 0)
                {
                    if (formulariosActuales[n] != null)
                    {
                        formulariosActuales[n].Close();
                        formulariosActuales.RemoveAt(n);
                    }
                }
             
            }
            formulariosActuales.Add(formularioHijo);
            formularioHijo.TopLevel = false;
            formularioHijo.FormBorderStyle = FormBorderStyle.None;
            formularioHijo.Dock = DockStyle.Fill;
            panelContenedor.Controls.Add(formularioHijo);
            panelContenedor.Tag = formularioHijo;
            formularioHijo.BringToFront();
            formularioHijo.Show();
        }

        public void cerrarFormularioHijo()
        {
            int n = formulariosActuales.Count - 1;
            if (n >= 1)
            {
                if (formulariosActuales[n] != null)
                {
                    formulariosActuales[n].Close();
                    formulariosActuales.RemoveAt(n);
                }
            }
        }


        public void cerrarFormulariosActuales()
        {
            foreach(Form f in formulariosActuales)
            {
                f.Close(); 
            }
            formulariosActuales.Clear(); 
        }


        private void customizeDesign()
        {
            panelPlanificacionSubmenu.Visible = false; 
            panelAdmSubmenu.Visible = false;
            panelEvaluacionSubmenu.Visible = false;
            panelHistorialSubmenu.Visible = false;
            panelReportesSubmenu.Visible = false;

            timerFechaHoraActual.Start();
            lblInicioHoraActual.Text = DateTime.Now.ToLongTimeString();

            lblInicioFechaActual.Text = DateTime.Now.ToLongDateString();
            
        }

        private void hideSubmenu()
        {
            if (panelPlanificacionSubmenu.Visible == true)
                panelPlanificacionSubmenu.Visible = false;
            if (panelEvaluacionSubmenu.Visible == true)
                panelEvaluacionSubmenu.Visible = false;
            if (panelAdmSubmenu.Visible == true)
                panelAdmSubmenu.Visible = false;
            if (panelHistorialSubmenu.Visible == true)
                panelHistorialSubmenu.Visible = false;
            if (panelReportesSubmenu.Visible == true)
                panelReportesSubmenu.Visible = false; 
        }

        private void mostrarSubmenu(Panel subMenu)
        {
            if (subMenu.Visible == false)
            {
                hideSubmenu();
                subMenu.Visible = true;
            }
            else
            {
                subMenu.Visible = false;
            }
               
            
        }

        private void cambiarTituloBarraSuperior(Button btnPadre, Button btnHijo)
        {
            
            lblTituloBarraSuperior.Text = btnPadre.Text + " ➜ " + btnHijo.Text;
        }

        
        private void panelMenu_Paint(object sender, PaintEventArgs e)
        {

        }

        
       

        private void frmInicio_Load(object sender, EventArgs e)
        {
            
        }

        //Menu Principal
        private void btnPlanificacion_Click(object sender, EventArgs e)
        {
            mostrarSubmenu(panelPlanificacionSubmenu);
            
        }

        private void btnEvaluacion_Click(object sender, EventArgs e)
        {
            mostrarSubmenu(panelEvaluacionSubmenu);
            
        }

        private void btnHistorialEv_Click(object sender, EventArgs e)
        {
            mostrarSubmenu(panelHistorialSubmenu);
            
        }

        private void btnAdministracion_Click(object sender, EventArgs e)
        {
            mostrarSubmenu(panelAdmSubmenu);
            
        }

        private void btnReportes_Click(object sender, EventArgs e)
        {
            mostrarSubmenu(panelReportesSubmenu);
            
        }

        //Submenu de Planificacion
        private void btnPlanMisObjetivos_Click(object sender, EventArgs e)
        {
            cambiarTituloBarraSuperior(btnPlanificacion,btnPlanMisObjetivos);
            cerrarFormulariosActuales();
            abrirFormularioHijo(false, new frmPlanMisObjetivos());
        }

        private void btnPlanValidarObjetivos_Click(object sender, EventArgs e)
        {
            cambiarTituloBarraSuperior(btnPlanificacion, btnPlanValidarObjetivos);
            cerrarFormulariosActuales();
            abrirFormularioHijo(false, new frmPlanValidarObjetivos());
        }

        //Submenu de Evaluacion
        private void btnEvAutoevaluacion_Click(object sender, EventArgs e)
        {
            cambiarTituloBarraSuperior(btnEvaluacion, btnEvAutoevaluacion);
            cerrarFormulariosActuales();
            frmEvAutoevaluacionPantallaPrevia form = new frmEvAutoevaluacionPantallaPrevia();
            form.TipoEval = TipoEvaluacion.Autoevaluacion;
            form.Periodo = Global.periodoActual;
            form.Colaborador = Global.colaboradorLoggeado; 
            abrirFormularioHijo(false,form);
        }

        private void btnEvMisTrabajadores_Click(object sender, EventArgs e)
        {
            cambiarTituloBarraSuperior(btnEvaluacion, btnEvMisTrabajadores);
            cerrarFormulariosActuales();
            abrirFormularioHijo(false, new frmEvMisTrabajadores());
        }

        private void btnEvFeedback_Click(object sender, EventArgs e)
        {
            cambiarTituloBarraSuperior(btnEvaluacion, btnEvFeedback);
            cerrarFormulariosActuales();
            abrirFormularioHijo(false, new frmEvFeedback());
        }

        private void btnEvMisResultados_Click(object sender, EventArgs e)
        {
            frmEvMisResultados form = new frmEvMisResultados();
            form.Colaborador = Global.colaboradorLoggeado;
            form.Periodo = Global.periodoActual;
            form.Modo = ModoResultados.MisResultados; 

            cambiarTituloBarraSuperior(btnEvaluacion, btnEvMisResultados);
            cerrarFormulariosActuales();
            abrirFormularioHijo(false, form);
        }

        //Submenu de Historial
        private void btnHisMisEvaluaciones_Click(object sender, EventArgs e)
        {
            cambiarTituloBarraSuperior(btnHistorialEv, btnHisMisEvaluaciones);
            cerrarFormulariosActuales();
            abrirFormularioHijo(false, new frmHisMisEvaluaciones());
        }

        private void btnHisMisTrabajadores_Click(object sender, EventArgs e)
        {
            cambiarTituloBarraSuperior(btnHistorialEv, btnHisMisTrabajadores);
            cerrarFormulariosActuales();
            abrirFormularioHijo(false, new frmHisMisTrabajadores());
        }

        //Submenu de Administracion
        private void btnAdmGestCron_Click(object sender, EventArgs e)
        {
            cambiarTituloBarraSuperior(btnAdministracion, btnAdmGestCron);
            cerrarFormulariosActuales();
            abrirFormularioHijo(false, new frmAdmGestCron());
        }

        private void btnAdmGestComp_Click(object sender, EventArgs e)
        {
            cambiarTituloBarraSuperior(btnAdministracion, btnAdmGestComp);
            cerrarFormulariosActuales();
            abrirFormularioHijo(false, new frmAdmGestComp());
        }

        private void btnAdmGestPot_Click(object sender, EventArgs e)
        {
            cambiarTituloBarraSuperior(btnAdministracion, btnAdmGestPot);
            cerrarFormulariosActuales();
            abrirFormularioHijo(false, new frmAdmGestPot());
        }

        private void btnAdmGestRangos_Click(object sender, EventArgs e)
        {
            cambiarTituloBarraSuperior(btnAdministracion, btnAdmGestRangos);
            cerrarFormulariosActuales();
            abrirFormularioHijo(false, new frmAdmGestRangos());
        }

        //private void btnAdmSeguimiento_Click(object sender, EventArgs e)
        //{
        //    cambiarTituloBarraSuperior(btnAdministracion, btnAdmSeguimiento);
        //    cerrarFormulariosActuales();
        //    abrirFormularioHijo(false, new frmAdmSeguimiento());
        //}

        private void btnAdmCalibrar_Click(object sender, EventArgs e)
        {
            cambiarTituloBarraSuperior(btnAdministracion, btnAdmCalibrar);
            cerrarFormulariosActuales();
            abrirFormularioHijo(false, new frmAdmCalibrar());

        }

        private void btnGestGerencias_Click(object sender, EventArgs e)
        {
            cambiarTituloBarraSuperior(btnAdministracion, btnGestGerencias);
            cerrarFormulariosActuales();
            abrirFormularioHijo(false, new frmAdmGestGer());
        }

        private void btnAdmGestSubcomp_Click(object sender, EventArgs e)
        {
            cambiarTituloBarraSuperior(btnAdministracion, btnAdmGestSubcomp);
            cerrarFormulariosActuales();
            abrirFormularioHijo(false, new frmAdmGestSubcomp());
        }

        private void btnAdmGestSubpot_Click(object sender, EventArgs e)
        {
            cambiarTituloBarraSuperior(btnAdministracion, btnAdmGestSubpot);
            cerrarFormulariosActuales();
            abrirFormularioHijo(false, new frmAdmGestSubpot());
        }

        private void btnGestColaboradores_Click(object sender, EventArgs e)
        {
            cambiarTituloBarraSuperior(btnAdministracion, btnGestColaboradores);
            cerrarFormulariosActuales();
            abrirFormularioHijo(false, new frmAdmGestColab());
        }

        private void btnGestPuestos_Click(object sender, EventArgs e)
        {
            cambiarTituloBarraSuperior(btnAdministracion, btnGestPuestos);
            cerrarFormulariosActuales();
            abrirFormularioHijo(false, new frmAdmGestPuestos());
        }

        //Submenu de Reportes
        private void btnRep9Box_Click(object sender, EventArgs e)
        {
            cambiarTituloBarraSuperior(btnReportes, btnRep9Box);
            cerrarFormulariosActuales();
            abrirFormularioHijo(false, new frmRep9Box());
        }

        private void btnRepPDI_Click(object sender, EventArgs e)
        {
            cambiarTituloBarraSuperior(btnReportes, btnRepPDI);
            cerrarFormulariosActuales();
            abrirFormularioHijo(false, new frmRepPDI());
        }

        //Otros
        private void btnInicio_Click(object sender, EventArgs e)
        {
            cerrarFormulariosActuales();
            lblTituloBarraSuperior.Text = "Inicio";
            
        }

        private void timerFechaHoraActual_Tick(object sender, EventArgs e)
        {
            lblInicioHoraActual.Text = DateTime.Now.ToLongTimeString();

            lblInicioFechaActual.Text = DateTime.Now.ToLongDateString();
            timerFechaHoraActual.Start();
        }



        private void btnLogout_Click(object sender, EventArgs e)
        {
            var result = MessageBox.Show("¿Desea cerrar la sesion?",
                                               "Mensaje de confirmacion",
                                               MessageBoxButtons.YesNo,
                                               MessageBoxIcon.Question);
            if (result == DialogResult.Yes)
            {
                this.Hide();
                frmLogin login = new frmLogin();
                login.ShowDialog();
                cerrarFormulariosActuales();
                this.Close();

            }
                
            

        }

        private void btnLblNombreColab_Click(object sender, EventArgs e)
        {
            lblTituloBarraSuperior.Text = "Mi perfil";
            cerrarFormulariosActuales();
            abrirFormularioHijo(false, new frmPerfilColaborador());
        }

        private void btnRepPlanificacion_Click(object sender, EventArgs e)
        {
            cambiarTituloBarraSuperior(btnReportes, btnRepPlanificacion);
            cerrarFormulariosActuales();
            abrirFormularioHijo(false, new frmRepPlanificacion());
        }
    }
}
