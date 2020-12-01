using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.IO;
using SistemaEDInterfaces.ColaboradorWS;

namespace SistemaEDInterfaces
{
    public partial class frmAdmGestColabCargaMav : Form
    {
        private ColaboradorWS.ColaboradorWSClient daoColaborador;
        public frmAdmGestColabCargaMav()
        {
            InitializeComponent();
            daoColaborador = new ColaboradorWS.ColaboradorWSClient();
        }

        private void btnGestColabSelecColab_Click(object sender, EventArgs e)
        {
            OpenFileDialog buscar = new OpenFileDialog();
            if (buscar.ShowDialog() == DialogResult.OK)
            {
                txtNomArchColabMav.Text = buscar.FileName;
            }
        }

        private void btnCargarColabMasiva_Click(object sender, EventArgs e)
        {
            string[] lineas = File.ReadAllLines(txtNomArchColabMav.Text);


            if ((rdbActCargaMavColab.Checked || rdbInsCargaMavColab.Checked) && txtNomArchColabMav.Text != "")
            {
                if (rdbActCargaMavColab.Checked != false)
                {
                    foreach (var linea in lineas)
                    {
                        var valores = linea.Split(',');
                        ColaboradorWS.colaborador colaborador = new ColaboradorWS.colaborador();
                        colaborador.puestoTrabajo = new ColaboradorWS.puestoTrabajo();
                        colaborador.gerencia = new ColaboradorWS.gerencia();
                        colaborador.usuario = new ColaboradorWS.usuario();

                        int dato = int.Parse(valores[0].ToString());
                        colaborador.idColaborador=dato;

                        dato = int.Parse(valores[1].ToString());
                        colaborador.gerencia.idGerencia = dato;

                        dato = int.Parse(valores[2].ToString());
                        colaborador.puestoTrabajo.idPuestoTrabajo = dato;

                        if (valores[3] != "NO")
                        {
                            colaborador.dni = valores[3].ToString();
                        }
                        else
                        {
                            colaborador.dni = "";
                        }

                        if (valores[4] != "NO")
                        {
                            colaborador.jefe.idColaborador = int.Parse(valores[4].ToString());
                        }
                        else
                        {
                            colaborador.jefe.idColaborador = -1;
                        }

                        if (valores[5] != "NO")
                        {
                            colaborador.nombres = valores[5].ToString();
                        }
                        else
                        {
                            colaborador.nombres = "";
                        }

                        if (valores[6] != "NO")
                        {
                            colaborador.apellidos= valores[6].ToString();
                        }
                        else
                        {
                            colaborador.apellidos = "";
                        }

                        if (valores[7] != "NO")
                        {
                            colaborador.direccion= valores[7].ToString();
                        }
                        else
                        {
                            colaborador.direccion = "";
                        }

                        if (valores[8] != "NO")
                        {
                            colaborador.correo = valores[8].ToString();
                        }
                        else
                        {
                            colaborador.correo = "";
                        }

                        if (valores[9] != "NO")
                        {
                            colaborador.telefono= valores[7].ToString();
                        }
                        else
                        {
                            colaborador.telefono = "";
                        }

                        if (valores[10] != "NO")
                        {
                            colaborador.fechaNac = DateTime.Parse(valores[7].ToString());
                        }
                        else
                        {
                            colaborador.fechaNac = DateTime.Parse("000");
                        }

                        daoColaborador.actualizarColaborador(colaborador);
                    }
                }
                else if (rdbInsCargaMavColab.Checked != false)
                {
                    foreach (var linea in lineas)
                    {
                        if (linea == "") continue;
                        int resultado;
                        var valores = linea.Split(';');
                        ColaboradorWS.colaborador colaborador = new ColaboradorWS.colaborador();
                        colaborador.dni = valores[0];
                        colaborador.jefe = new ColaboradorWS.colaborador();
                        colaborador.jefe.idColaborador = int.Parse(valores[1]);
                        colaborador.nombres = valores[2];
                        colaborador.apellidos = valores[3];
                        colaborador.direccion = valores[4];
                        colaborador.correo = valores[5];
                        colaborador.telefono = valores[6];
                        colaborador.fechaNacSpecified = true;
                        colaborador.fechaNac = DateTime.Parse(valores[7]);

                        colaborador.puestoTrabajo = new ColaboradorWS.puestoTrabajo();
                        colaborador.gerencia = new ColaboradorWS.gerencia();
                        colaborador.usuario = new ColaboradorWS.usuario();
                        colaborador.periodo = new ColaboradorWS.periodo();
<<<<<<< HEAD

                        colaborador.periodo.idPeriodo = 1;
=======
>>>>>>> b77d7f25b2f468d55c57631bc26294758700bf28
                        colaborador.puestoTrabajo.idPuestoTrabajo = int.Parse(valores[8]);
                        colaborador.gerencia.idGerencia = int.Parse(valores[9]);
                        colaborador.usuario.contrasenha = valores[11];
                        colaborador.usuario.nivelAcceso = int.Parse(valores[10]);
                        
                        colaborador.periodo.idPeriodo = 1; 
                        resultado=daoColaborador.insertarColaborador(colaborador);
                        if (resultado == 0)
                        {
                            MessageBox.Show("Error al registrar colaborador",
                                  "Mensaje de error",
                                  MessageBoxButtons.OK,
                                  MessageBoxIcon.Error);
                        }
                    }
                }
                MessageBox.Show("El archivo se cargó correctamente");
                this.Close();
            }
            else if ((rdbActCargaMavColab.Checked == false) && (rdbInsCargaMavColab.Checked == false) && txtNomArchColabMav.Text != "")
            {
                MessageBox.Show("Elija la opción insertar o actualizar");
            }
            else if ((txtNomArchColabMav.Text == "") && (rdbInsCargaMavColab.Checked || rdbActCargaMavColab.Checked))
            {
                MessageBox.Show("Inserte su archivo");
            }
            else if ((rdbActCargaMavColab.Checked == false || rdbInsCargaMavColab.Checked == false) && txtNomArchColabMav.Text == "")
            {
                MessageBox.Show("Ingrese los datos");
            }
        }

        private void btnRegreCargMavColab_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
