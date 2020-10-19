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

        private Form formularioHijoActual; 
        public frmInicio()
        {
            InitializeComponent();
            customizeDesign();
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

        private void abrirFormularioHijo(Form formularioHijo)
        {
            if (formularioHijoActual != null)
            {
                formularioHijoActual.Close();
            }
            formularioHijoActual = formularioHijo;
            formularioHijo.TopLevel = false;
            formularioHijo.FormBorderStyle = FormBorderStyle.None;
            formularioHijo.Dock = DockStyle.Fill;
            panelContenedor.Controls.Add(formularioHijo);
            panelContenedor.Tag = formularioHijo;
            formularioHijo.BringToFront();
            formularioHijo.Show();

        }
        private void panelMenu_Paint(object sender, PaintEventArgs e)
        {

        }

        
       

        private void frmInicio_Load(object sender, EventArgs e)
        {
            
        }

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

        private void btnPlanMisObjetivos_Click(object sender, EventArgs e)
        {
            cambiarTituloBarraSuperior(btnPlanificacion,btnPlanMisObjetivos);
            abrirFormularioHijo(new frmPlanMisObjetivos()); 
        }

        private void btnPlanValidarObjetivos_Click(object sender, EventArgs e)
        {
            cambiarTituloBarraSuperior(btnPlanificacion, btnPlanValidarObjetivos);
            abrirFormularioHijo(new frmPlanValidarObjetivos());
        }

        private void btnEvAutoevaluacion_Click(object sender, EventArgs e)
        {
            cambiarTituloBarraSuperior(btnEvaluacion, btnEvAutoevaluacion);
            abrirFormularioHijo(new frmEvAutoevaluacion());
        }

        private void btnEvMisTrabajadores_Click(object sender, EventArgs e)
        {
            cambiarTituloBarraSuperior(btnEvaluacion, btnEvMisTrabajadores);
            abrirFormularioHijo(new frmEvMisTrabajadores());
        }

        private void btnEvFeedback_Click(object sender, EventArgs e)
        {
            cambiarTituloBarraSuperior(btnEvaluacion, btnEvFeedback);
            abrirFormularioHijo(new frmEvFeedback());
        }

        private void btnEvMisResultados_Click(object sender, EventArgs e)
        {
            cambiarTituloBarraSuperior(btnEvaluacion, btnEvMisResultados);
            abrirFormularioHijo(new frmEvMisResultados());
        }

        private void btnHisMisEvaluaciones_Click(object sender, EventArgs e)
        {
            cambiarTituloBarraSuperior(btnHistorialEv, btnHisMisEvaluaciones);
            abrirFormularioHijo(new frmHisMisEvaluaciones());
        }

        private void btnHisMisTrabajadores_Click(object sender, EventArgs e)
        {
            cambiarTituloBarraSuperior(btnHistorialEv, btnHisMisTrabajadores);
            abrirFormularioHijo(new frmHisMisTrabajadores());
        }

        private void btnAdmGestCron_Click(object sender, EventArgs e)
        {
            cambiarTituloBarraSuperior(btnAdministracion, btnAdmGestCron);
            abrirFormularioHijo(new frmAdmGestCron());
        }

        private void btnAdmGestComp_Click(object sender, EventArgs e)
        {
            cambiarTituloBarraSuperior(btnAdministracion, btnAdmGestComp);
            abrirFormularioHijo(new frmAdmGestComp());
        }

        private void btnAdmGestPot_Click(object sender, EventArgs e)
        {
            cambiarTituloBarraSuperior(btnAdministracion, btnAdmGestPot);
            abrirFormularioHijo(new frmAdmGestPot());
        }

        private void btnAdmGestRangos_Click(object sender, EventArgs e)
        {
            cambiarTituloBarraSuperior(btnAdministracion, btnAdmGestRangos);
            abrirFormularioHijo(new frmAdmGestRangos());
        }

        private void btnAdmSeguimiento_Click(object sender, EventArgs e)
        {
            cambiarTituloBarraSuperior(btnAdministracion, btnAdmSeguimiento);
            abrirFormularioHijo(new frmAdmSeguimiento());
        }

        private void btnAdmCalibrar_Click(object sender, EventArgs e)
        {
            cambiarTituloBarraSuperior(btnAdministracion, btnAdmCalibrar);
            abrirFormularioHijo(new frmAdmCalibrar());
        }

        private void btnRep9Box_Click(object sender, EventArgs e)
        {
            cambiarTituloBarraSuperior(btnReportes, btnRep9Box);
            abrirFormularioHijo(new frmRep9Box());
        }

        private void btnRepPDI_Click(object sender, EventArgs e)
        {
            cambiarTituloBarraSuperior(btnReportes, btnRepPDI);
            abrirFormularioHijo(new frmRepPDI());
        }

        private void btnInicio_Click(object sender, EventArgs e)
        {
            if (formularioHijoActual != null)
            {
                formularioHijoActual.Close();
            }
            lblTituloBarraSuperior.Text = "Inicio";
            
        }

        private void timerFechaHoraActual_Tick(object sender, EventArgs e)
        {
            lblInicioHoraActual.Text = DateTime.Now.ToLongTimeString();

            lblInicioFechaActual.Text = DateTime.Now.ToLongDateString();
            timerFechaHoraActual.Start();
        }



        private void btnMenuCuenta_Click(object sender, EventArgs e)
        {
            
            btnMenuCuenta.Image = Properties.Resources.flecha_hacia_arriba;
        }
    }
}
