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
    public partial class frmAdmGestSubComCrgMav : Form
    {
        CriterioWS.CriterioWSClient daoCriterio;
        PesoCriterioWS.PesoCriterioWSClient daoPesoCriterio;
        int resultado;
        string errores = "";
        public frmAdmGestSubComCrgMav()
        {
            InitializeComponent();
            daoCriterio = new CriterioWS.CriterioWSClient();
            daoPesoCriterio = new PesoCriterioWS.PesoCriterioWSClient();
        }


        private int realizarValidaciones()
        {
            int valido = 1;

            //Accion para cargar los datos a la base de datos
            if (!(rdbActMavSubCom.Checked) && !(rdbInsMavSubCom.Checked) && txtNomArchSubComMav.Text != "")
            {
                MessageBox.Show("Debe seleccionar si desea insertar o actualizar subcompetencias.",
                                   "Mensaje de error",
                                   MessageBoxButtons.OK,
                                   MessageBoxIcon.Error);
                return 0;
            }
            else if (!(rdbActMavSubComPesos.Checked) && !(rdbInsMavSubComPesos.Checked) && txtNomArchSubComPesosMav.Text != "")
            {
                MessageBox.Show("Debe seleccionar si desea insertar o actualizar pesos.",
                                   "Mensaje de error",
                                   MessageBoxButtons.OK,
                                   MessageBoxIcon.Error);
                return 0;
            }
            else if ((txtNomArchSubComMav.Text == "") && (txtNomArchSubComPesosMav.Text == ""))
            {
                MessageBox.Show("No ha insertado ningun archivo.",
                                   "Mensaje de error",
                                   MessageBoxButtons.OK,
                                   MessageBoxIcon.Error);
                return 0;
            }
            return valido;


        }

        private void btnRegreCargMavSubComp_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void btnGestSubComSelecSubCom_Click_1(object sender, EventArgs e)
        {
            OpenFileDialog buscar = new OpenFileDialog();
            if (buscar.ShowDialog() == DialogResult.OK)
            {
                txtNomArchSubComMav.Text = buscar.FileName;
            }
        }

        private void btnGestSubComSelecPesos_Click(object sender, EventArgs e)
        {
            OpenFileDialog buscar = new OpenFileDialog();
            if (buscar.ShowDialog() == DialogResult.OK)
            {
                txtNomArchSubComPesosMav.Text = buscar.FileName;
            }
        }

        private void btnRegreCargMavGestSubCom_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void btnCargarMasivaGestSubCom_Click(object sender, EventArgs e)
        {
            Global.iniciarEspera(this);
            int resultadoVal = realizarValidaciones();
            if (resultadoVal == 0)
            {
                Global.terminarEspera(this);
                return;
            }

            if (txtNomArchSubComMav.Text != "")
            {

                string[] lineasSubcompetencias = File.ReadAllLines(txtNomArchSubComMav.Text);

                //Para Actualizar: 
                if (rdbActMavSubCom.Checked)
                {

                    foreach (var linea in lineasSubcompetencias)
                    {
                        if (linea == "") continue;
                        var valores = linea.Split(',');

                        CriterioWS.criterio criterio = new CriterioWS.criterio();
                        int idCriterio = Int32.Parse(valores[0]);
                        String strIdCriterioPadre= valores[1];
                        String nombre = valores[2];
                        String descripcion = valores[3];
                        criterio.idCriterio = idCriterio;
                        criterio.criterioPadre = new CriterioWS.criterio(); 

                        //en estos momentos no se puede actualizar el idCriterioPadre
                        if (strIdCriterioPadre != "no")
                        {
                            //se actualiza
                            criterio.criterioPadre.idCriterio = Int32.Parse(strIdCriterioPadre); 
                        }
                        else
                        {
                            //No se actualiza 
                            criterio.criterioPadre.idCriterio = -1; 
                        }
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

                        resultado = daoCriterio.actualizarCriterio(criterio);
                        if (resultado == 0)
                        {
                            errores = errores + linea + "\n";
                        }
                    }
                    if (errores != "")
                    {
                        MessageBox.Show("Error: Hubo errores en algunas filas, ya que no ingresaron correctamente los ID's de las subcompetencias." +
                        "Por favor, ingrese la dirección donde desea descargar el archivo con los datos no actualizados:");
                        cargarErrores();
                    }
                    else if (errores == "")
                    {
                        MessageBox.Show("El archivo se cargó correctamente de competencias");
                    }
                }
                //Para insertar
                else if (rdbInsMavSubCom.Checked)
                {
                    BindingList<CriterioWS.criterio> listaSubcompetencias = new BindingList<CriterioWS.criterio>(daoCriterio.listar(2,""));
                    int validar = 0;
                    foreach (var linea in lineasSubcompetencias)
                    {
                        validar = 0;
                        if (linea == "") continue; 
                        var valores = linea.Split(',');

                        CriterioWS.criterio criterio = new CriterioWS.criterio();
                        int id = int.Parse(valores[0]);
                        int idCriterioPadre = Int32.Parse(valores[1]); 
                        String nombre = valores[2];
                        String descripcion = valores[3];
                        criterio.idCriterio = id;
                        criterio.nombre = nombre;
                        criterio.descripcion = descripcion;
                        criterio.tipo = (int)TipoCriterio.Subcompetencia;
                        criterio.criterioPadre = new CriterioWS.criterio();
                        criterio.criterioPadre.idCriterio = idCriterioPadre;
                        foreach (CriterioWS.criterio subcompetencia in listaSubcompetencias)
                        {
                            if (subcompetencia.nombre.Equals(criterio.nombre))
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
                        MessageBox.Show("Alerta: Hubo datos del archivo csv de subcompetencias que ya existian en el sistema; sin embargo, no se ingresaron." +
                            "Por favor, ingrese la dirección donde desea descargar el archivo con los datos que no se ingresaron:");
                        cargarErrores();
                    }
                    else if (errores == "")
                    {
                        MessageBox.Show("El archivo se cargó correctamente");
                    }
                }

            }


            if (txtNomArchSubComPesosMav.Text != "")
            {
                string[] lineasPesos = File.ReadAllLines(txtNomArchSubComPesosMav.Text);

                //Para actualizar
                if (rdbActMavSubComPesos.Checked)
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
                        MessageBox.Show("Error: Hubo errores en algunas filas, ya que no ingresó correctamente el nombre de la subcompetencia" +
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
                if (rdbInsMavSubComPesos.Checked)
                {
                    BindingList<PesoCriterioWS.pesoCriterio> listapesossubcompetencias = new BindingList<PesoCriterioWS.pesoCriterio>(daoPesoCriterio.listarPesosCriterios(2, "", "", ""));
                    int validar = 0;
                    foreach (var linea in lineasPesos)
                    {
                        validar = 0;
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

                        foreach (PesoCriterioWS.pesoCriterio pesos in listapesossubcompetencias)
                        {
                            if (pesos.periodo.idPeriodo == pesoCriterio.periodo.idPeriodo && pesos.puestoTrabajo.idPuestoTrabajo == pesoCriterio.puestoTrabajo.idPuestoTrabajo && pesos.criterio.idCriterio == pesoCriterio.criterio.idCriterio)
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
                        MessageBox.Show("Alerta: Hubo datos del archivo csv de pesos subcompetencias que ya existian en el sistema; sin embargo, no se ingresaron." +
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
            this.DialogResult = DialogResult.OK;
            this.Close(); 
        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {
            Form frmAyuda = new frmAyudaSubCompetencias();
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

