using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
//using System.Threading.Tasks;
using System.Windows.Forms;
using System.Diagnostics;
using System.IO;

namespace SistemaEDInterfaces
{
    public partial class frmAdmGestComCrgMav : Form
    {
        CriterioWS.CriterioWSClient daoCriterio;
        PesoCriterioWS.PesoCriterioWSClient daoPesoCriterio;
        int resultado;
        string errores = "";

        public frmAdmGestComCrgMav()
        {
            InitializeComponent();
            daoCriterio = new CriterioWS.CriterioWSClient();
            daoPesoCriterio = new PesoCriterioWS.PesoCriterioWSClient(); 
        }

        private void btnGestComSelecCom_Click(object sender, EventArgs e)
        {
            OpenFileDialog buscar = new OpenFileDialog();
            if (buscar.ShowDialog()== DialogResult.OK ) {
                txtNomArchComMav.Text = buscar.FileName;
            }
        }


        private int realizarValidaciones()
        {
            int valido = 1;

            if (!(rdbActCargaMavCom.Checked) && !(rdbInsCargaMavCom.Checked) && txtNomArchComMav.Text != "")
            {
                MessageBox.Show("Debe seleccionar si desea insertar o actualizar competencias.",
                                   "Mensaje de error",
                                   MessageBoxButtons.OK,
                                   MessageBoxIcon.Error);
                return 0; 
            }
            else if (!(rdbActCargaMavCompePesos.Checked) && !(rdbInsCargaMavCompePesos.Checked) && txtNomArchCompePesosMav.Text != "")
            {
                MessageBox.Show("Debe seleccionar si desea insertar o actualizar pesos.",
                                   "Mensaje de error",
                                   MessageBoxButtons.OK,
                                   MessageBoxIcon.Error);
                return 0;
            }
            else if ((txtNomArchComMav.Text == "") && (txtNomArchCompePesosMav.Text == ""))
            {
                MessageBox.Show("No ha insertado ningun archivo.",
                                   "Mensaje de error",
                                   MessageBoxButtons.OK,
                                   MessageBoxIcon.Error);
                return 0;
            }
            return valido; 


        }
        private void groupBox1_Enter(object sender, EventArgs e)
        {

        }

        private void btnGestComSelecComPesos_Click(object sender, EventArgs e)
        {
            OpenFileDialog buscar = new OpenFileDialog();
            if (buscar.ShowDialog() == DialogResult.OK)
            {
                txtNomArchCompePesosMav.Text = buscar.FileName;
            }
        }

        private void btnRegreCargMavCompePesos_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void btnCargarCompetMasiva_Click(object sender, EventArgs e)
        {
            Global.iniciarEspera(this); 
            int resultadoVal = realizarValidaciones();
            if (resultadoVal == 0) 
            {
                Global.terminarEspera(this); 
                return; 
            }

            if (txtNomArchComMav.Text != "")
            {

                string[] lineasCompetencias = File.ReadAllLines(txtNomArchComMav.Text);
                if (rdbActCargaMavCom.Checked)
                {
                    foreach (var linea in lineasCompetencias)
                    {
                        var valores = linea.Split(',');

                        CriterioWS.criterio criterio = new CriterioWS.criterio();
                        int id = Int32.Parse(valores[0]);
                        String nombre = valores[1];
                        String descripcion = valores[2];
                        criterio.idCriterio = id;

                        if (nombre != "no")
                        {
                            criterio.nombre = nombre;
                        }
                        else
                        {
                            criterio.nombre = "";
                        }

                        if (descripcion != "no")
                        {
                            criterio.descripcion = descripcion;
                        }
                        else
                        {
                            criterio.descripcion = "";
                        }
                        //No actualizar competencia
                        criterio.criterioPadre = new CriterioWS.criterio();
                        criterio.criterioPadre.idCriterio = -1;
                        resultado = daoCriterio.actualizarCriterio(criterio);
                        if (resultado == 0)
                        {
                            errores = errores + linea + "\n";
                        }
                    }
                    if (errores != "")
                    {
                        MessageBox.Show("Error: Hubo errores en algunas filas, ya que no ingresaron correctamente los ID's de las competencias." +
                        "Por favor, ingrese la dirección donde desea descargar el archivo con los datos no actualizados:");
                        cargarErrores();
                    }
                    else if (errores == "")
                    {
                        MessageBox.Show("El archivo se cargó correctamente de competencias");
                    }
                }
                //Para insertar
                else if (rdbInsCargaMavCom.Checked)
                {
                    BindingList<CriterioWS.criterio> listacompetencias = new BindingList<CriterioWS.criterio>(daoCriterio.listar(0, ""));
                    int validar = 0;
                    
                    foreach (var linea in lineasCompetencias)
                    {
                        validar = 0;
                        var valores = linea.Split(',');

                        CriterioWS.criterio criterio = new CriterioWS.criterio();
                        int id = int.Parse(valores[0]);
                        String nombre = valores[1];
                        String descripcion = valores[2];
                        criterio.idCriterio = id;
                        criterio.nombre = nombre;
                        criterio.descripcion = descripcion;
                        criterio.tipo = (int)TipoCriterio.Competencia;
                        criterio.criterioPadre = new CriterioWS.criterio();
                        criterio.criterioPadre.idCriterio = -1;

                        foreach (CriterioWS.criterio competencia in listacompetencias)
                        {
                            if (competencia.nombre.Equals(criterio.nombre))
                            {
                                validar = 1;
                            }
                        }
                        if (validar == 0)
                        {
                            resultado = daoCriterio.insertarMasivo(criterio);
                        }
                        if (resultado == 0 || validar == 1)
                        {
                            errores = errores + linea + "\n";
                        }
                    }
                    if (errores != "")
                    {
                        MessageBox.Show("Alerta: Hubo datos del archivo csv de competencias que ya existian en el sistema; sin embargo, no se ingresaron." +
                            "Por favor, ingrese la dirección donde desea descargar el archivo con los datos que no se ingresaron:");
                        cargarErrores();
                    }
                    else if (errores == "")
                    {
                        MessageBox.Show("El archivo se cargó correctamente");
                    }
                }

            }


            if (txtNomArchCompePesosMav.Text != "")
            {
                string[] lineasPesos = File.ReadAllLines(txtNomArchCompePesosMav.Text);

                //Para actualizar
                if (rdbActCargaMavCompePesos.Checked)
                {
                    foreach (var linea in lineasPesos)
                    {
                        if (linea == "") continue;
                        var valores = linea.Split(',');

                        PesoCriterioWS.pesoCriterio pesoCriterio = new PesoCriterioWS.pesoCriterio();

                        String nombreCriterio = valores[0];
                        String nombrePuesto = valores[1];
                        String nombrePeriodo = valores[2];
                        double peso = Double.Parse(valores[3]);

                        pesoCriterio.criterio = new PesoCriterioWS.criterio();
                        pesoCriterio.criterio.nombre = nombreCriterio;
                        pesoCriterio.puestoTrabajo = new PesoCriterioWS.puestoTrabajo();
                        pesoCriterio.puestoTrabajo.nombre = nombrePuesto;
                        pesoCriterio.periodo = new PesoCriterioWS.periodo();
                        pesoCriterio.periodo.nombre = nombrePeriodo;
                        pesoCriterio.peso = peso;

                        resultado = daoPesoCriterio.actualizarPesoCriterio(pesoCriterio);
                        if (resultado == 0)
                        {
                            errores = errores + linea + "\n";
                        }

                    }
                    if (errores != "")
                    {
                        MessageBox.Show("Error: Hubo errores en algunas filas, ya que no ingresó correctamente el nombre de la competencia" +
                            ",el nombre del puesto de trabajo o el nombre del periodo actual." +
                        "Por favor, ingrese la dirección donde desea descargar el archivo con los datos no actualizados:");
                        cargarErrores();
                    }
                    else if (errores == "")
                    {
                        MessageBox.Show("El archivo se cargó correctamente");
                    }
                }
                //Para insertar 
                if (rdbInsCargaMavCompePesos.Checked)
                {
                    BindingList<PesoCriterioWS.pesoCriterio> listapesoscompetencias = new BindingList<PesoCriterioWS.pesoCriterio>(daoPesoCriterio.listarPesosCriterios(0,"","",""));
                    int validar = 0;
                    foreach (var linea in lineasPesos)
                    {
                        validar = 0;
                        var valores = linea.Split(',');

                        PesoCriterioWS.pesoCriterio pesoCriterio = new PesoCriterioWS.pesoCriterio();

                        String nombreCriterio = valores[0];
                        String nombrePuesto = valores[1];
                        String nombrePeriodo = valores[2];
                        double peso = Double.Parse(valores[3]);

                        pesoCriterio.criterio = new PesoCriterioWS.criterio();
                        pesoCriterio.criterio.nombre = nombreCriterio;
                        pesoCriterio.puestoTrabajo = new PesoCriterioWS.puestoTrabajo();
                        pesoCriterio.puestoTrabajo.nombre = nombrePuesto;
                        pesoCriterio.periodo = new PesoCriterioWS.periodo();
                        pesoCriterio.periodo.nombre = nombrePeriodo;
                        pesoCriterio.peso = peso;

                        foreach (PesoCriterioWS.pesoCriterio pesos in listapesoscompetencias)
                        {
                            if ((pesos.periodo.idPeriodo == pesoCriterio.periodo.idPeriodo) && (pesos.puestoTrabajo.idPuestoTrabajo == pesoCriterio.puestoTrabajo.idPuestoTrabajo)  && (pesos.criterio.idCriterio == pesoCriterio.criterio.idCriterio))
                            {
                                validar = 1;
                            }
                        }
                        if (validar == 0)
                        {
                            resultado = daoPesoCriterio.insertarPesoCriterio(pesoCriterio);
                        }
                        if (resultado == 0 || validar == 1)
                        {
                            errores = errores + linea + "\n";
                        }

                    }
                    if (errores != "")
                    {
                        MessageBox.Show("Alerta: Hubo datos del archivo csv de pesos competencias que ya existian en el sistema; sin embargo, no se ingresaron." +
                            "Por favor, ingrese la dirección donde desea descargar el archivo con los datos que no se ingresaron:");
                        cargarErrores();
                    }
                    else if (errores == "")
                    {
                        MessageBox.Show("El archivo se cargó correctamente");
                    }
                }
            }


            //Falta realizar validacion para ver si se insertaron/actualizarion correctamente las competencias/pesos 
            Global.terminarEspera(this);
            //MessageBox.Show("Se procesaron correctamente los archivos.",
            //                       "Mensaje de confirmación",
            //                       MessageBoxButtons.OK,
            //                       MessageBoxIcon.Information);
        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {
            Form frmAyuda = new frmAyudaCompetencias();
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
