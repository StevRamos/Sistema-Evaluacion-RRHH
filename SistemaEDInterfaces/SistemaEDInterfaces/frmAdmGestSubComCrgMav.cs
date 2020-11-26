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

                        daoCriterio.actualizarCriterio(criterio); 
                        
                    }
                }
                //Para insertar
                else if (rdbInsMavSubCom.Checked)
                {
                    foreach (var linea in lineasSubcompetencias)
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
                        criterio.tipo = (int)TipoCriterio.Subcompetencia;
                        criterio.criterioPadre = new CriterioWS.criterio();
                        criterio.criterioPadre.idCriterio = idCriterioPadre;

                        daoCriterio.insertarMasivo(criterio);
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

                        daoPesoCriterio.actualizarPesoCriterio(pesoCriterio);


                    }

                }
                //Para insertar 
                if (rdbInsMavSubComPesos.Checked)
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
                        
                        daoPesoCriterio.insertarPesoCriterio(pesoCriterio);
                        


                    }

                }
            }


            //Falta realizar validacion para ver si se insertaron/actualizarion correctamente las competencias/pesos 
            Global.terminarEspera(this);
            MessageBox.Show("Se procesaron correctamente los archivos.",
                                   "Mensaje de confirmación",
                                   MessageBoxButtons.OK,
                                   MessageBoxIcon.Information);
            this.DialogResult = DialogResult.OK;
            this.Close(); 
        }
    }
}

