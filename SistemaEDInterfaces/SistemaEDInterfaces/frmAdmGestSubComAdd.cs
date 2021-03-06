﻿using System;
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
    public partial class frmAdmGestSubComAdd : Form
    {
        private PuestoTrabajoWS.PuestoTrabajoWSClient daoPuestoTrabajo;
        CriterioWS.CriterioWSClient daoCriterio;
        CriterioWS.criterio competencia;
        CriterioWS.criterio criterio; 
        public CriterioWS.criterio Competencia { get => competencia; set => competencia = value; }
        public frmAdmGestSubComAdd()
        {
            InitializeComponent();
            daoPuestoTrabajo = new PuestoTrabajoWS.PuestoTrabajoWSClient();
            daoCriterio = new CriterioWS.CriterioWSClient();
            criterio = new CriterioWS.criterio();
            txtPeriodo.Text = Global.periodoActual.nombre;

            cmbCargo.DataSource = daoPuestoTrabajo.listarPuestoTrabajos("");

            cmbCargo.ValueMember = "idPuestoTrabajo";
            cmbCargo.DisplayMember = "nombre";
        }

        private void label3_Click(object sender, EventArgs e)
        {

        }

        private void btnRegresarAddCom_Click(object sender, EventArgs e)
        {
            var result = MessageBox.Show("¿Esta seguro que desea regresar? No se realizará el registro",
                "Mensaje de información",
                MessageBoxButtons.YesNo,
                MessageBoxIcon.Warning);
            if (result == DialogResult.Yes)
            {
                Global.formPrincipal.abrirFormularioHijo(true, new frmAdmGestSubcomp());
            }

        }

        private int realizarValidaciones()
        {

            int valido = 1;
            double peso = Double.Parse(txtPeso.Text);
            if (peso > 100 || peso < 0)
            {
                MessageBox.Show("El peso de la competencia debe estar entre 0 y 100.",
                                      "Mensaje de error",
                                      MessageBoxButtons.OK,
                                      MessageBoxIcon.Error);
                return 0;
            }
            if(txtComp.Text == "")
            {
                MessageBox.Show("Debe seleccionar una competencia a asignar",
                                      "Mensaje de error",
                                      MessageBoxButtons.OK,
                                      MessageBoxIcon.Error);
                return 0;
            }
            return valido;

        }
        private void btnGuardar_Click(object sender, EventArgs e)
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
            criterio.nombre = txtNombreSubcomp.Text;
            criterio.descripcion = txtDescripcion.Text;
            criterio.tipo = (int)TipoCriterio.Subcompetencia;
            criterio.criterioPadre = new CriterioWS.criterio();
            criterio.criterioPadre.idCriterio = competencia.idCriterio;
            criterio.criterioPadre.nombre = competencia.nombre; 
            //Agregando el pesoCriterio
            BindingList<CriterioWS.pesoCriterio> pesos = new BindingList<CriterioWS.pesoCriterio>();
            CriterioWS.pesoCriterio pesoCriterio = new CriterioWS.pesoCriterio();
            //Obteniendo cargo 
            PuestoTrabajoWS.puestoTrabajo puesto = (PuestoTrabajoWS.puestoTrabajo)cmbCargo.SelectedItem;
            pesoCriterio.puestoTrabajo = new CriterioWS.puestoTrabajo();
            pesoCriterio.puestoTrabajo.idPuestoTrabajo = puesto.idPuestoTrabajo;
            pesoCriterio.puestoTrabajo.nombre = puesto.nombre;
            pesoCriterio.peso = Double.Parse(txtPeso.Text);
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
            MessageBox.Show("La subcompetencia se registró exitosamente.",
                                   "Mensaje de confirmación",
                                   MessageBoxButtons.OK,
                                   MessageBoxIcon.Information);
            Global.formPrincipal.abrirFormularioHijo(true, new frmAdmGestSubcomp());
        }

        private void btnBusRegSubCom_Click(object sender, EventArgs e)
        {
            frmAdmGestSubComBuscarCom formulario = new frmAdmGestSubComBuscarCom();
            
            if(formulario.ShowDialog() == DialogResult.OK)
            {
                competencia = formulario.Competencia;
                txtComp.Text = competencia.nombre; 
            }
            
        }

        private void txtPeso_KeyPress(object sender, KeyPressEventArgs e)
        {
            Global.restringirADecimal(sender, e); 
        }
    }
}
