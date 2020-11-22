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
    public partial class frmAdmGestComAdd : Form
    {
        private PuestoTrabajoWS.PuestoTrabajoWSClient daoPuestoTrabajo;
        //private CriterioWS.CriterioWSClient daoCriterio;
        //private CriterioWS.criterio criterio; 
        public frmAdmGestComAdd()
        {
            
            InitializeComponent();
            daoPuestoTrabajo = new PuestoTrabajoWS.PuestoTrabajoWSClient();
            /*
            daoCriterio = new CriterioWS.CriterioWSClient();
            criterio = new CriterioWS.criterio(); 

            */
            txtPeriodo.Text =  Global.periodoActual.nombre;
            
            cmbPuestos.DataSource = daoPuestoTrabajo.listarPuestoTrabajos("");
            
            cmbPuestos.ValueMember = "idPuestoTrabajo";
            cmbPuestos.DisplayMember = "nombre"; 
            

        }

        private void frmAdmGestSubComAdd_Load(object sender, EventArgs e)
        {

        }

        private void btnGuardar_Click(object sender, EventArgs e)
        {
            /*
            criterio.nombre = txtNombre.Text;
            criterio.descripcion = txtDescripcion.Text; 
            criterio.pesosCriterios = new BindingList<CriterioWS.pesoCriterio> ();

            CriterioWS.pesoCriterio pesoCriterio = new CriterioWS.pesoCriterio();

            //Obteniendo cargo 

            PesoCriterioWS.puestoTrabajo puesto = (PesoCriterioWS.puestoTrabajo)cmbPuestos.SelectedItem;
            PesoCriterioWS.periodo periodo = new PesoCriterioWS.periodo();

            periodo.idPeriodo = Global.periodoActual.idPeriodo; 

            pesoCriterio.peso = Double.Parse(txtPeso.Text);
            pesoCriterio.periodo = new PesoCriterioWS.periodo(); 
            pesoCriterio.puesto = new PesoCriterioWS.puestoTrabajo(); 
            pesoCriterio.
            //criterio.pesosCriterios; 
            */
            MessageBox.Show("La competencia se registro exitosamente");
            this.Close();
        }

        private void btnRegresarAddCom_Click(object sender, EventArgs e)
        {
            Global.formPrincipal.abrirFormularioHijo(true, new frmAdmGestComp());
        }
    }
}
