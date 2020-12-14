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
    public partial class frmAdmGestCargoCargaMav : Form
    {
        private PuestoTrabajoWS.PuestoTrabajoWSClient daoPuesto;
        int resultado;
        string errores = "";
        public frmAdmGestCargoCargaMav()
        {
            InitializeComponent();
            daoPuesto = new PuestoTrabajoWS.PuestoTrabajoWSClient();
        }

        private void btnGestCargoSelecCargo_Click(object sender, EventArgs e)
        {
            OpenFileDialog buscar = new OpenFileDialog();
            if (buscar.ShowDialog() == DialogResult.OK)
            {
                txtNomArchCargoMav.Text = buscar.FileName;
            }
        }

        private void btnCargarCargoMasiva_Click(object sender, EventArgs e)
        {
            
            if ((rdbActCargaMavCargo.Checked || rdbInsCargaMavCargo.Checked) && txtNomArchCargoMav.Text != "")
            {
                string[] lineas = File.ReadAllLines(txtNomArchCargoMav.Text);
                if (rdbActCargaMavCargo.Checked != false)
                {
                    foreach (var linea in lineas)
                    {
                        var valores = linea.Split(',');
                        PuestoTrabajoWS.puestoTrabajo puesto = new PuestoTrabajoWS.puestoTrabajo();

                        int dato = int.Parse(valores[0].ToString());
                        
                        puesto.idPuestoTrabajo = dato;

                        if (valores[1] != "no")
                        {
                            puesto.nombre = valores[1].ToString();
                        }
                        else
                        {
                            puesto.nombre = "";
                        }
                        if (valores[2] != "no")
                        {
                            puesto.descripcion = valores[2].ToString();
                        }
                        else
                        {
                            puesto.descripcion = "";
                        }

                        resultado = daoPuesto.actualizarPuestoTrabajo(puesto);
                        if (resultado == 0)
                        {
                            errores = errores + linea + "\n";
                        }
                    }
                    cargarErrores();
                }
                else if (rdbInsCargaMavCargo.Checked != false)
                {
                    foreach (var linea in lineas)
                    {
                        var valores = linea.Split(',');
                        PuestoTrabajoWS.puestoTrabajo puesto = new PuestoTrabajoWS.puestoTrabajo();
                        puesto.nombre = valores[0].ToString();
                        puesto.descripcion = valores[1].ToString();

                        resultado = daoPuesto.insertarPuestoTrabajo(puesto);
                        if (resultado == 0)
                        {
                            errores = errores + linea + "\n";
                        }
                    }
                    cargarErrores();
                }
                MessageBox.Show("El archivo se cargó correctamente");
                this.DialogResult = DialogResult.OK;
                this.Close();
            }
            else if ((rdbActCargaMavCargo.Checked == false) && (rdbInsCargaMavCargo.Checked == false) && txtNomArchCargoMav.Text != "")
            {
                MessageBox.Show("Elija la opción insertar o actualizar");
            }
            else if ((txtNomArchCargoMav.Text == "") && (rdbInsCargaMavCargo.Checked || rdbActCargaMavCargo.Checked))
            {
                MessageBox.Show("Inserte su archivo");
            }
            else if ((rdbActCargaMavCargo.Checked == false || rdbInsCargaMavCargo.Checked == false) && txtNomArchCargoMav.Text == "")
            {
                MessageBox.Show("Ingrese los datos");
            }
        }

        private void btnRegreCargMavCargo_Click(object sender, EventArgs e)
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
            Form frmAyuda = new frmAyudaCargo();
            frmAyuda.Show();
        }
    }
}
