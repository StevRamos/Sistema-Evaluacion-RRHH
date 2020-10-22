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
    public partial class frmPlanMisObjetivos : Form
    {
        
        public frmPlanMisObjetivos()
        {
            InitializeComponent();
            
        }


        public void agregarDatosDummyDGV()
        {
            int rowId1 = dgvMisObjetivos.Rows.Add();

            DataGridViewRow row1 = dgvMisObjetivos.Rows[rowId1];

            row1.Cells["Descripcion"].Value= "Vender 2000 laptops de las marcas Asus, Dell, Lenovo";
            row1.Cells["Numero"].Value = "1";
            row1.Cells["Peso"].Value = "60%";
            row1.Cells["Estado"].Value = "Revision Pendiente";

            int rowId2 = dgvMisObjetivos.Rows.Add();

            DataGridViewRow row2 = dgvMisObjetivos.Rows[rowId2];

            row2.Cells["Descripcion"].Value = "Vender 100 tablets";
            row2.Cells["Numero"].Value = "2";
            row2.Cells["Peso"].Value = "20%";
            row2.Cells["Estado"].Value = "Aprobado";

            int rowId3 = dgvMisObjetivos.Rows.Add();

            DataGridViewRow row3 = dgvMisObjetivos.Rows[rowId3];

            row3.Cells["Descripcion"].Value = "Vender 30 Celulares marca IPhone";
            row3.Cells["Numero"].Value = "3";
            row3.Cells["Peso"].Value = "20%";
            row3.Cells["Estado"].Value = "Rechazado";



        }
        private void frmPlanMisObjetivos_Load(object sender, EventArgs e)
        {
            agregarDatosDummyDGV();
        }

        private void btnAgregar_Click(object sender, EventArgs e)
        {
           
            frmPlanAgregarObjetivo form = new frmPlanAgregarObjetivo();
            form.ShowDialog();
        }

        private void panelContenedor_Paint(object sender, PaintEventArgs e)
        {

        }

        private void dgvMisObjetivos_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void btnEnviar_Click(object sender, EventArgs e)
        {
            MessageBox.Show("Objetivos enviados para revision.",
                            "Mensaje de confirmacion",
                            MessageBoxButtons.OK,
                            MessageBoxIcon.Information); 
        }

        private void btnEditar_Click(object sender, EventArgs e)
        {
            Global.formPrincipal.abrirFormularioHijo(false,new frmPlanEditarObjetivo()); 
            
            
        }

        private void btnEliminar_Click(object sender, EventArgs e)
        {
            var result = MessageBox.Show("Se eliminara el objetivo seleccionado.",
                                            "Mensaje de advertencia",
                                            MessageBoxButtons.OKCancel,
                                            MessageBoxIcon.Warning);
            if (result == DialogResult.OK)
            {
                foreach (DataGridViewRow row in dgvMisObjetivos.SelectedRows)
                {
                    dgvMisObjetivos.Rows.RemoveAt(row.Index);
                    //Eliminar de la BD 
                }

            }
                
        }

        private void dgvMisObjetivos_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }
    }
}
