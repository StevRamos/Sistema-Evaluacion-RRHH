using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace SistemaEDInterfaces
{
    public partial class frmAdmGestPotAdd : Form
    {
        private PuestoTrabajoWS.PuestoTrabajoWSClient daoPuestoTrabajo;
        private CriterioWS.CriterioWSClient daoCriterio;
        private CriterioWS.criterio criterio;
        public frmAdmGestPotAdd()
        {
            InitializeComponent();
            daoPuestoTrabajo = new PuestoTrabajoWS.PuestoTrabajoWSClient();
            daoCriterio = new CriterioWS.CriterioWSClient();
            criterio = new CriterioWS.criterio();


            txtAddPeriodoPot.Text = Global.periodoActual.nombre;

            cmbAddCargoPot.DataSource = daoPuestoTrabajo.listarPuestoTrabajos("");

            cmbAddCargoPot.ValueMember = "idPuestoTrabajo";
            cmbAddCargoPot.DisplayMember = "nombre";
        }

        private void btnAddGuardarPot_Click(object sender, EventArgs e)
        {
            Global.iniciarEspera(this);
            //Realizar validacion 
            int resultadoVal = realizarValidaciones();

            if (resultadoVal == 0)
            {
                Global.terminarEspera(this);
                return;
            }

            //Obtener datos del criterio 
            criterio.nombre = txtAddNomPot.Text;
            criterio.descripcion = rctAddDescripPot.Text;
            criterio.tipo = (int)TipoCriterio.Potencial;
            criterio.criterioPadre = new CriterioWS.criterio();
            criterio.criterioPadre.idCriterio = -1;

            //Agregando el pesoCriterio
            BindingList<CriterioWS.pesoCriterio> pesos = new BindingList<CriterioWS.pesoCriterio>();
            CriterioWS.pesoCriterio pesoCriterio = new CriterioWS.pesoCriterio();
            //Obteniendo cargo 
            PuestoTrabajoWS.puestoTrabajo puesto = (PuestoTrabajoWS.puestoTrabajo)cmbAddCargoPot.SelectedItem;
            pesoCriterio.puestoTrabajo = new CriterioWS.puestoTrabajo();
            pesoCriterio.puestoTrabajo.idPuestoTrabajo = puesto.idPuestoTrabajo;
            pesoCriterio.puestoTrabajo.nombre = puesto.nombre;
            pesoCriterio.peso = Double.Parse(txtAddPesoPot.Text);
            pesoCriterio.criterio = new CriterioWS.criterio();
            pesoCriterio.criterio.nombre = criterio.nombre;
            //Obteniendo periodo
            pesoCriterio.periodo = new CriterioWS.periodo();
            pesoCriterio.periodo.idPeriodo = Global.periodoActual.idPeriodo;
            pesoCriterio.periodo.nombre = Global.periodoActual.nombre;

            pesos.Add(pesoCriterio);

            criterio.pesoscriterios = pesos.ToArray();

            int resultado = daoCriterio.insertarIndividual(criterio);
            Global.terminarEspera(this);
            if (resultado == 0)
            {

                MessageBox.Show("Ocurrió un error, intentelo nuevamente.",
                                   "Mensaje de error",
                                   MessageBoxButtons.OK,
                                   MessageBoxIcon.Error);
                return;
            }
            MessageBox.Show("El potencial se registró exitosamente.",
                                   "Mensaje de confirmación",
                                   MessageBoxButtons.OK,
                                   MessageBoxIcon.Information);
            Global.formPrincipal.abrirFormularioHijo(true, new frmAdmGestPot());
        }

        private int realizarValidaciones()
        {

            int valido = 1;
            double peso = Double.Parse(txtAddPesoPot.Text);
            if (peso > 100 || peso < 0)
            {
                MessageBox.Show("El peso del potencial debe estar entre 0 y 100.",
                                      "Mensaje de error",
                                      MessageBoxButtons.OK,
                                      MessageBoxIcon.Error);
                return 0;
            }
            return valido;

        }

        private void btnAddRegresarPot_Click(object sender, EventArgs e)
        {
            var result = MessageBox.Show("¿Esta seguro que desea regresar? No se realizará el registro",
                "Mensaje de información",
                MessageBoxButtons.YesNo,
                MessageBoxIcon.Warning);
            if (result == DialogResult.Yes)
            {
                Global.formPrincipal.abrirFormularioHijo(true, new frmAdmGestPot());
            }
        }

        private void txtAddPesoPot_KeyPress(object sender, KeyPressEventArgs e)
        {
            Global.restringirADecimal(sender, e);
        }
    }
}
