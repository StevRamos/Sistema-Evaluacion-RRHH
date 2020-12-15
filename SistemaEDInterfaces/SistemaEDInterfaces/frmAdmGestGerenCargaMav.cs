using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace SistemaEDInterfaces
{
    public partial class frmAdmGestGerenCargaMav : Form
    {
        private GerenciaWS.GerenciaWSClient daoGerencia;
        int resultado;
        string errores = "";
        public frmAdmGestGerenCargaMav()
        {
            InitializeComponent();
            daoGerencia = new GerenciaWS.GerenciaWSClient();
        }

        private void btnCargarComMasiva_Click(object sender, EventArgs e)
        {
            string[] lineas = File.ReadAllLines(txtNomArchGerenMav.Text);

            if ((rdbActCargaMavGer.Checked || rdbInsCargaMavGer.Checked) && txtNomArchGerenMav.Text != "")
            {
                if (rdbActCargaMavGer.Checked != false)
                {
                    foreach (var linea in lineas)
                    {
                        var valores = linea.Split(',');
                        GerenciaWS.gerencia gerencia = new GerenciaWS.gerencia();

                        int dato = int.Parse(valores[0].ToString());

                        gerencia.idGerencia = dato;

                        if (valores[1] != "no")
                        {
                            gerencia.nombre = valores[1].ToString();
                        }
                        else
                        {
                            gerencia.nombre = "";
                        }
                        if (valores[2] != "no")
                        {
                            gerencia.descripcion = valores[2].ToString();
                        }
                        else
                        {
                            gerencia.descripcion = "";
                        }

                        resultado = daoGerencia.actualizarGerencia(gerencia);
                        if (resultado == 0)
                        {
                            errores = errores + linea + "\n";
                        }
                    }
                    if (errores != "") {
                        MessageBox.Show("Error: Hubo errores en algunas filas, ya que no se ingresó los ID's correctos de las gerencias." +
                            "Por favor, ingrese la dirección donde desea descargar el archivo con los datos no actualizados:");
                        cargarErrores();
                    } else if (errores == "") {
                        MessageBox.Show("El archivo se cargó correctamente");
                    }
                }
                else if (rdbInsCargaMavGer.Checked != false)
                {
                    BindingList<GerenciaWS.gerencia> listagerencias = new BindingList<GerenciaWS.gerencia>(daoGerencia.listarGerencias());
                    int validar = 0;
                    foreach (var linea in lineas)
                    {
                        validar = 0;
                        var valores = linea.Split(',');
                        GerenciaWS.gerencia gerencia = new GerenciaWS.gerencia();
                        gerencia.nombre = valores[0].ToString();
                        gerencia.descripcion = valores[1].ToString();
                        foreach(GerenciaWS.gerencia ger in listagerencias)
                        {
                            if (ger.nombre.Equals(gerencia.nombre)) {
                                validar = 1;
                            }
                        }
                        if (validar == 0)
                        {
                            resultado = daoGerencia.insertarGerencia(gerencia);
                        }
                        if (resultado == 0 || validar ==1)
                        { 
                            errores = errores + linea + "\n";
                        }
                    }
                    if (errores != "")
                    {
                        MessageBox.Show("Alerta: Hubo datos del archivo csv que ya existian en el sistema; sin embargo, no se ingresaron." +
                            "Por favor, ingrese la dirección donde desea descargar el archivo con los datos que no se ingresaron:");
                        cargarErrores();
                    }
                    else if (errores == "")
                    {
                        MessageBox.Show("El archivo se cargó correctamente");
                    }
                }
                this.DialogResult = DialogResult.OK;
                this.Close();
            }
            else if ((rdbActCargaMavGer.Checked == false) && (rdbInsCargaMavGer.Checked == false) && txtNomArchGerenMav.Text != "")
            {
                MessageBox.Show("Elija la opción insertar o actualizar");
            }
            else if ((txtNomArchGerenMav.Text == "") && (rdbInsCargaMavGer.Checked || rdbActCargaMavGer.Checked))
            {
                MessageBox.Show("Inserte su archivo");
            }
            else if ((rdbActCargaMavGer.Checked == false || rdbInsCargaMavGer.Checked == false) && txtNomArchGerenMav.Text == "")
            {
                MessageBox.Show("Ingrese los datos");
            }
        }

        private void btnGestGerSelecGer_Click(object sender, EventArgs e)
        {
            OpenFileDialog buscar = new OpenFileDialog();
            if (buscar.ShowDialog() == DialogResult.OK)
            {
                txtNomArchGerenMav.Text = buscar.FileName;
            }
        }

        private void btnRegreCargMavGer_Click(object sender, EventArgs e)
        {
            this.Close();
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

        private void pictureBox1_Click(object sender, EventArgs e)
        {
            Form frmAyuda = new frmAyudaGerencia();
            frmAyuda.Show();
        }
    }
}
