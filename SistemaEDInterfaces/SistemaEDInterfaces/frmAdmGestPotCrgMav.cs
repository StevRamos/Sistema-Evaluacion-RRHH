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
                        if (daoCriterio.actualizarCriterio(criterio) == 0)
                        {
                            MessageBox.Show("hubo un error");
                        }
                    }
                }
                //Para insertar
                else if (rdbInsMavPot.Checked)
                {
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

                        daoCriterio.insertarMasivo(criterio);
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

                        daoPesoCriterio.actualizarPesoCriterio(pesoCriterio);


                    }

                }
                //Para insertar 
                if (rdbInsMavPotPesos.Checked)
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
    }
}
