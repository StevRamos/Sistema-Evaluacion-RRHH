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
    public partial class frmPerfilColaborador : Form
    {
        public frmPerfilColaborador()
        {
            InitializeComponent();
            cargarColaborador();
        }

        public void cargarColaborador()
        {
            ColaboradorWS.colaborador colaborador = Global.colaboradorLoggeado;
            txtCargo.Text = colaborador.puestoTrabajo.nombre;
            txtCorreo.Text = colaborador.correo;
            txtDireccion.Text = colaborador.direccion;
            txtDNI.Text = colaborador.dni;
            txtGerencia.Text = colaborador.gerencia.nombre;
            txtID.Text = colaborador.idColaborador.ToString();
            txtJefe.Text = colaborador.jefe.nombres;
            txtNombreCompleto.Text = colaborador.nombres + " " + colaborador.apellidos;
            txtTelefono.Text = colaborador.telefono;
            dtpFechaNacimiento.Value = colaborador.fechaNac;
        }
    }
}
