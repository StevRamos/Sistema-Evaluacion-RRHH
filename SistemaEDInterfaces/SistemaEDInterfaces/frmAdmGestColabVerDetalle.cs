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
    public partial class frmAdmGestColabVerDetalle : Form
    {
        private ColaboradorWS.colaborador colaborador;
        public frmAdmGestColabVerDetalle()
        {
            InitializeComponent();
            
        }

        public colaborador Colaborador { get => colaborador; set => colaborador = value; }

        private void btnGestColabDetaRegre_Click(object sender, EventArgs e)
        {
            Global.formPrincipal.cerrarFormularioHijo();
        }

        private void frmAdmGestColabVerDetalle_Load(object sender, EventArgs e)
        {
            txtDni.Text = colaborador.dni.ToString();
            txtNombres.Text = colaborador.nombres;
            txtApellidos.Text = colaborador.apellidos;
            txtDireccion.Text = colaborador.direccion;
            txtCargo.Text = colaborador.puestoTrabajo.nombre;
            txtGerencia.Text = colaborador.gerencia.nombre;
            txtCorreo.Text = colaborador.correo;
            txtTelefono.Text = colaborador.telefono;

        }
    }
}
