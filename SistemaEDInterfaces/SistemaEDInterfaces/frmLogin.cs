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
    public partial class frmLogin : Form
    {
        public frmLogin()
        {
            InitializeComponent();
        }

        private void txtUsuario_Enter(object sender, EventArgs e)
        {
            if (txtUsuario.Text == "USUARIO")
            {
                txtUsuario.Text = "";
                txtUsuario.ForeColor = Color.LightGray;
            }
        }

        private void txtUsuario_Leave(object sender, EventArgs e)
        {
            if (txtUsuario.Text == "")
            {
                txtUsuario.Text = "USUARIO";
                txtUsuario.ForeColor = Color.DimGray;
            }
        }

        private void txtContraseña_Enter(object sender, EventArgs e)
        {
            if (txtContraseña.Text == "CONTRASEÑA")
            {
                txtContraseña.Text = "";
                txtContraseña.ForeColor = Color.LightGray;
                txtContraseña.UseSystemPasswordChar = true;
            }
        }

        private void txtContraseña_Leave(object sender, EventArgs e)
        {
            if (txtContraseña.Text == "")
            {
                txtContraseña.Text = "CONTRASEÑA";
                txtContraseña.ForeColor = Color.DimGray;
                txtContraseña.UseSystemPasswordChar = false;
            }
        }

        private void btnCerrar_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void btnMinimizar_Click(object sender, EventArgs e)
        {
            this.WindowState = FormWindowState.Minimized;
        }

        private void btnAcceder_Click(object sender, EventArgs e)
        {
            if (txtUsuario.Text != "USUARIO")
            {
                if (txtContraseña.Text != "CONTRASEÑA")
                {
                    ColaboradorWS.ColaboradorWSClient daoColaborador = new ColaboradorWS.ColaboradorWSClient();
                    ColaboradorWS.colaborador colaborador;

                    colaborador = daoColaborador.autenticarUsuario(txtUsuario.Text,txtContraseña.Text);
                    
                    if (colaborador.apellidos == null)
                    {
                        msgError("Usuario o contraseña incorrectos");
                    }
                    else
                    {
                        Global.colaboradorLoggeado = colaborador;

                        this.Hide();
                        frmBienvenida bienvenida = new frmBienvenida();
                        bienvenida.ShowDialog();
                        frmInicio Inicio = new frmInicio();
                        Inicio.ShowDialog();
                        this.Close();
                    }
                    
                    /*
                        this.Hide();
                    frmBienvenida bienvenida = new frmBienvenida();
                    bienvenida.ShowDialog();
                    frmInicio Inicio = new frmInicio();
                    Inicio.ShowDialog();
                    this.Close();
                    */


                }
                else msgError("Por favor ingresa la contraseña");

            }
            else msgError("Por favor ingresa el usuario");

            
            
            
            
        }
        private void msgError(string msg)
        {
            lblError.Text = "    " + msg;
            lblError.Visible = true;
            picError.Visible = true;
        }

    }
}
