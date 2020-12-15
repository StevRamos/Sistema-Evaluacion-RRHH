using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Diagnostics;
using System.IO;

namespace SistemaEDInterfaces
{
    public partial class frmAdmGestPotCrgMav : Form
    {
        CriterioWS.CriterioWSClient daoCriterio;
        PesoCriterioWS.PesoCriterioWSClient daoPesoCriterio;
        //para las validaciones
        int resultado;
        string errores = "";
        public frmAdmGestPotCrgMav()
        {
            InitializeComponent();
            daoCriterio = new CriterioWS.CriterioWSClient();
            daoPesoCriterio = new PesoCriterioWS.PesoCriterioWSClient();
        }



        private void btnRegreCargMavPot_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void btnCargarMasivaGestPot_Click(object sender, EventArgs e)
        {
            Global.iniciarEspera(this);
            int resultadoVal = realizarValidaciones();
            if (resultadoVal == 0)
            {
                Global.terminarEspera(this);
                return;
            }

            if (txtNomArchPotMav.Text != "")
            {

                string[] lineasPotenciales = File.ReadAllLines(txtNomArchPotMav.Text);

                //Para Actualizar: 
                if (rdbActMavPot.Checked)
                {
                    foreach (var linea in lineasPotenciales)
                    {
                        var valores = linea.Split(',');

                        CriterioWS.criterio criterio = new CriterioWS.criterio();
                        int id = Int32.Parse(valores[0]);
                        String nombre = valores[1];
                        String descripcion = valores[2];
                        criterio.idCriterio = id;

                        if (nombre != "no")
                        {

                            //Se actualiza
                            criterio.nombre = nombre;
                        }
                        else
                        {
                            //No se actualiza 
                            criterio.nombre = "";
                        }

                        if (descripcion != "no")
                        {
                            //Se actualiza
                            criterio.descripcion = descripcion;
                        }
                        else
                        {
                            //No se actualiza
                            criterio.descripcion = "";
                        }
                        //No actualizar potencial
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
                        MessageBox.Show("Error: Hubo errores en algunas filas, ya que no ingresaron correctamente los ID's de los potenciales." +
                        "Por favor, ingrese la dirección donde desea descargar el archivo con los datos no actualizados:");
                        cargarErrores();
                    }
                    else if (errores == "")
                    {
                        MessageBox.Show("El archivo se cargó correctamente de potenciales");
                    }
                }
                //Para insertar
                else if (rdbInsMavPot.Checked)
                {
                    BindingList<CriterioWS.criterio> listapotenciales = new BindingList<CriterioWS.criterio>(daoCriterio.listar(1, ""));
                    int validar = 0;
                    foreach (var linea in lineasPotenciales)
                    {
                        var valores = linea.Split(',');
                        CriterioWS.criterio criterio = new CriterioWS.criterio();
                        int id = int.Parse(valores[0]);
                        String nombre = valores[1];
                        String descripcion = valores[2];
                        criterio.idCriterio = id;
                        criterio.nombre = nombre;
                        criterio.descripcion = descripcion;
                        criterio.tipo = (int)TipoCriterio.Potencial;
                        criterio.criterioPadre = new CriterioWS.criterio();
                        criterio.criterioPadre.idCriterio = -1;

                        foreach (CriterioWS.criterio potencial in listapotenciales)
                        {
                            if (potencial.nombre.Equals(criterio.nombre))
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
                        MessageBox.Show("Alerta: Hubo datos del archivo csv de potenciales que ya existian en el sistema; sin embargo, no se ingresaron." +
                            "Por favor, ingrese la dirección donde desea descargar el archivo con los datos que no se ingresaron:");
                        cargarErrores();
                    }
                    else if (errores == "")
                    {
                        MessageBox.Show("El archivo se cargó correctamente");
                    }
                }

            }


            if (txtNomArchPotMavPesos.Text != "")
            {
                string[] lineasPesos = File.ReadAllLines(txtNomArchPotMavPesos.Text);

                //Para actualizar
                if (rdbActMavPotPesos.Checked)
                {
                    foreach (var linea in lineasPesos)
                    {
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

                        resultado=daoPesoCriterio.actualizarPesoCriterio(pesoCriterio);
                        if (resultado == 0)
                        {
                            errores = errores + linea + "\n";
                        }

                    }
                    if (errores != "")
                    {
                        MessageBox.Show("Error: Hubo errores en algunas filas, ya que no ingresó correctamente el nombre del potencial" +
                            ",el nombre del puesto de trabajo o el nombre del periodo actual." +
                        "Por favor, ingrese la dirección donde desea descargar el archivo con los datos no actualizados:");
                        cargarErrores();
                    }
                    else if (errores == "")
                    {
                        MessageBox.Show("El archivo se cargó correctamente de los pesos de los potenciales.");
                    }
                }
                //Para insertar 
                if (rdbInsMavPotPesos.Checked)
                {
                    BindingList<PesoCriterioWS.pesoCriterio> listapesospotenciales = new BindingList<PesoCriterioWS.pesoCriterio>(daoPesoCriterio.listarPesosCriterios(1,"","",""));
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
                        foreach (PesoCriterioWS.pesoCriterio pesos in listapesospotenciales)
                        {
                            if ((pesos.periodo.idPeriodo == pesoCriterio.periodo.idPeriodo) && (pesos.puestoTrabajo.idPuestoTrabajo == pesoCriterio.puestoTrabajo.idPuestoTrabajo) && (pesos.criterio.idCriterio == pesoCriterio.criterio.idCriterio))
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
                        MessageBox.Show("Alerta: Hubo datos del archivo csv de pesos potenciales que ya existian en el sistema; sin embargo, no se ingresaron." +
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

        private void btnGestPotSelecPot_Click(object sender, EventArgs e)
        {
            OpenFileDialog buscar = new OpenFileDialog();
            if (buscar.ShowDialog() == DialogResult.OK)
            {
                txtNomArchPotMav.Text = buscar.FileName;
            }
        }

        private int realizarValidaciones()
        {
            int valido = 1;

            //Accion para cargar los datos a la base de datos
            if (!(rdbActMavPot.Checked) && !(rdbInsMavPot.Checked) && txtNomArchPotMav.Text != "")
            {
                MessageBox.Show("Debe seleccionar si desea insertar o actualizar potenciales.",
                                   "Mensaje de error",
                                   MessageBoxButtons.OK,
                                   MessageBoxIcon.Error);
                return 0;
            }
            else if (!(rdbActMavPotPesos.Checked) && !(rdbInsMavPotPesos.Checked) && txtNomArchPotMavPesos.Text != "")
            {
                MessageBox.Show("Debe seleccionar si desea insertar o actualizar pesos.",
                                   "Mensaje de error",
                                   MessageBoxButtons.OK,
                                   MessageBoxIcon.Error);
                return 0;
            }
            else if ((txtNomArchPotMav.Text == "") && (txtNomArchPotMavPesos.Text == ""))
            {
                MessageBox.Show("No ha insertado ningun archivo.",
                                   "Mensaje de error",
                                   MessageBoxButtons.OK,
                                   MessageBoxIcon.Error);
                return 0;
            }
            return valido;


        }

        private void btnGestPotSelecPotPesos_Click(object sender, EventArgs e)
        {
            OpenFileDialog buscar = new OpenFileDialog();
            if (buscar.ShowDialog() == DialogResult.OK)
            {
                txtNomArchPotMavPesos.Text = buscar.FileName;
            }
        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {
            Form frmAyuda = new frmAyudaPotenciales();
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
