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
        int resultado;
        string errores = "";
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
                        colaborador.jefe = new ColaboradorWS.colaborador();

                        int dato = int.Parse(valores[0].ToString());
                        colaborador.idColaborador=dato;

                        dato = int.Parse(valores[1].ToString());
                        colaborador.gerencia.idGerencia = dato;

                        dato = int.Parse(valores[2].ToString());
                        colaborador.puestoTrabajo.idPuestoTrabajo = dato;


                        if (valores[3] != "no")
                        {
                            colaborador.jefe.idColaborador = int.Parse(valores[4].ToString());
                        }
                        else
                        {
                            colaborador.jefe.idColaborador = -1;
                        }
                        if (valores[4] != "no")
                        {
                            colaborador.direccion= valores[7].ToString();
                        }
                        else
                        {
                            colaborador.direccion = "";
                        }

                        if (valores[5] != "no")
                        {
                            colaborador.correo = valores[8].ToString();
                        }
                        else
                        {
                            colaborador.correo = "";
                        }

                        if (valores[6] != "no")
                        {
                            colaborador.telefono= valores[7].ToString();
                        }
                        else
                        {
                            colaborador.telefono = "";
                        }

                        if (valores[7] != "no")
                        {
                            colaborador.fechaNac = DateTime.Parse(valores[7].ToString());
                        }
                        else
                        {
                            colaborador.fechaNac = DateTime.Parse("000");
                        }

                        resultado = daoColaborador.actualizarColaborador(colaborador);
                        if (resultado == 0)
                        {
                            errores = errores + linea + "\n";
                        }
                    }
                    if (errores != "")
                    {
                        MessageBox.Show("Error: Hubo errores en algunas filas, ya que no se ingresó los ID's correctos de los colaboradores." +
                            "Por favor, ingrese la dirección donde desea descargar el archivo con los datos no actualizados:");
                        cargarErrores();
                    }
                    else if (errores == "")
                    {
                        MessageBox.Show("El archivo se cargó correctamente");
                    }
                }
                else if (rdbInsCargaMavColab.Checked != false)
                {
                    int validar = 0;
                    foreach (var linea in lineas)
                    {
                        if (linea == "") continue;
                        int resultado;
                        var valores = linea.Split(',');
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

                        colaborador.periodo.idPeriodo = 1;
                        colaborador.puestoTrabajo.idPuestoTrabajo = int.Parse(valores[8]);
                        colaborador.gerencia.idGerencia = int.Parse(valores[9]);
                        colaborador.usuario.contrasenha = valores[11];
                        colaborador.usuario.nivelAcceso = int.Parse(valores[10]);
                        
                        colaborador.periodo.idPeriodo = 1; 
                        resultado=daoColaborador.insertarColaborador(colaborador);
                        if (resultado == 0)
                        {
                            validar = 1;
                            errores = errores + linea + "\n";
                        }
                    }
                    if (validar == 1) {
                        MessageBox.Show("Error: Existen datos que no se ingresaron." 
                        + "Por favor, ingrese la dirección donde desea descargar el archivo con los datos no ingresados:");
                        cargarErrores();
                    }
                    else
                    {
                        MessageBox.Show("El archivo se cargó correctamente");
                    }
                }
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

        private void pictureBox1_Click(object sender, EventArgs e)
        {

        }

        private void pictureBox1_Click_1(object sender, EventArgs e)
        {
            Form frmAyuda = new frmAyudaColaboradores();
            frmAyuda.Show();
        }
        private void cargarErrores()
        {
            if (errores == "") return;
            sfdReporte.FileName = "Errores de la Carga Masiva.csv";
            sfdReporte.ShowDialog();
            if (sfdReporte.FileName != null && sfdReporte.FileName != "")
            {
                File.WriteAllText(sfdReporte.FileName, errores);
            }
            errores = "";
        }
    }
}
