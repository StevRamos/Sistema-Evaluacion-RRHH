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
    public partial class frmAdmGestSubPotCrgMav : Form
    {
        CriterioWS.CriterioWSClient daoCriterio;
        PesoCriterioWS.PesoCriterioWSClient daoPesoCriterio;
        int resultado;
        string errores="";

        public frmAdmGestSubPotCrgMav()
        {
            InitializeComponent();
            daoCriterio = new CriterioWS.CriterioWSClient();
            daoPesoCriterio = new PesoCriterioWS.PesoCriterioWSClient();
        }

        private int realizarValidaciones()
        {
            int valido = 1;

            //Accion para cargar los datos a la base de datos
            if (!(rdbActMavSubPot.Checked) && !(rdbInsMavSubPot.Checked) && txtNomArchSubPotMav.Text != "")
            {
                MessageBox.Show("Debe seleccionar si desea insertar o actualizar subpotenciales.",
                                   "Mensaje de error",
                                   MessageBoxButtons.OK,
                                   MessageBoxIcon.Error);
                return 0;
            }
            else if (!(rdbActMavSubPotPesos.Checked) && !(rdbInsMavSubPotPesos.Checked) && txtNomArchSubPotPesosMav.Text != "")
            {
                MessageBox.Show("Debe seleccionar si desea insertar o actualizar pesos.",
                                   "Mensaje de error",
                                   MessageBoxButtons.OK,
                                   MessageBoxIcon.Error);
                return 0;
            }
            else if ((txtNomArchSubPotMav.Text == "") && (txtNomArchSubPotPesosMav.Text == ""))
            {
                MessageBox.Show("No ha insertado ningun archivo.",
                                   "Mensaje de error",
                                   MessageBoxButtons.OK,
                                   MessageBoxIcon.Error);
                return 0;
            }
            return valido;


        }

        private void btnRegreCargMavSubPot_Click_1(object sender, EventArgs e)
        {
            this.Close();
        }

        private void btnGestSubPotSelecSubPot_Click_1(object sender, EventArgs e)
        {
            OpenFileDialog buscar = new OpenFileDialog();
            if (buscar.ShowDialog() == DialogResult.OK)
            {
                txtNomArchSubPotMav.Text = buscar.FileName;
            }
        }

        private void btnGestSubPotSelecPesos_Click(object sender, EventArgs e)
        {
            OpenFileDialog buscar = new OpenFileDialog();
            if (buscar.ShowDialog() == DialogResult.OK)
            {
                txtNomArchSubPotPesosMav.Text = buscar.FileName;
            }
        }

        private void btnCargarMasivaGestSubPot_Click(object sender, EventArgs e)
        {
            Global.iniciarEspera(this);
            int resultadoVal = realizarValidaciones();
            if (resultadoVal == 0)
            {
                Global.terminarEspera(this);
                return;
            }

            if (txtNomArchSubPotMav.Text != "")
            {

                string[] lineasSubpotenciales = File.ReadAllLines(txtNomArchSubPotMav.Text);

                //Para Actualizar: 
                if (rdbActMavSubPot.Checked)
                {
                    foreach (var linea in lineasSubpotenciales)
                    {
                        if (linea == "") continue;
                        var valores = linea.Split(',');

                        CriterioWS.criterio criterio = new CriterioWS.criterio();
                        int idCriterio = Int32.Parse(valores[0]);
                        String strIdCriterioPadre = valores[1];
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
                        if (resultado==0)
                        {
                            errores = errores + linea + "\n";
                        }

                    }
                    cargarErrores();
                }
                //Para insertar
                else if (rdbInsMavSubPot.Checked)
                {
                    foreach (var linea in lineasSubpotenciales)
                    {
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
                        criterio.tipo = (int)TipoCriterio.Subpotencial;
                        criterio.criterioPadre = new CriterioWS.criterio();
                        criterio.criterioPadre.idCriterio = idCriterioPadre;

                        resultado = daoCriterio.insertarMasivo(criterio);
                        if (resultado==0)
                        {
                            errores = errores + linea + "\n";
                        }
                        
                    }
                    cargarErrores();
                }

            }


            if (txtNomArchSubPotPesosMav.Text != "")
            {
                string[] lineasPesos = File.ReadAllLines(txtNomArchSubPotPesosMav.Text);

                //Para actualizar
                if (rdbActMavSubPotPesos.Checked)
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

                        resultado= daoPesoCriterio.actualizarPesoCriterio(pesoCriterio);
                        if (resultado == 0)
                        {
                            errores = errores + linea + "\n";
                        }

                    }
                    cargarErrores();

                }
                //Para insertar 
                if (rdbInsMavSubPotPesos.Checked)
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

                        resultado = daoPesoCriterio.insertarPesoCriterio(pesoCriterio);
                        if (resultado == 0)
                        {
                            errores = errores + linea + "\n";
                        }


                    }
                    cargarErrores();
                }
            }


            //Falta realizar validacion para ver si se insertaron/actualizarion correctamente las potenciales/pesos 
            Global.terminarEspera(this);
            MessageBox.Show("Se procesaron correctamente los archivos.",
                                   "Mensaje de confirmación",
                                   MessageBoxButtons.OK,
                                   MessageBoxIcon.Information);
            this.DialogResult = DialogResult.OK;
            this.Close();
        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {
            Form frmAyuda = new frmAyudaSubPotenciales();
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
