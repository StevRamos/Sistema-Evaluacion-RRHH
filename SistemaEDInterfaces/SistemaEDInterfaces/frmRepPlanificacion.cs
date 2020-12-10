﻿using System;
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
    public partial class frmRepPlanificacion : Form
    {
        private GerenciaWS.GerenciaWSClient daoGerencia;
        private ReporteWS.ReporteWSClient daoReporte; 
        public frmRepPlanificacion()
        {
            InitializeComponent();
            daoGerencia = new GerenciaWS.GerenciaWSClient();
            daoReporte = new ReporteWS.ReporteWSClient(); 
            cmbGerencias.DataSource = daoGerencia.listarGerencias();
            cmbGerencias.ValueMember = "idGerencia";
            cmbGerencias.DisplayMember = "nombre"; 
        }

        private void btnGenerar_Click(object sender, EventArgs e)
        {
            sfdReporte.FileName = "Reporte de Planificacion.pdf";
            sfdReporte.ShowDialog();
            if(sfdReporte.FileName !=null && sfdReporte.FileName != "")
            {
                byte[] arreglo;
                GerenciaWS.gerencia gerenciaSeleccionada = (GerenciaWS.gerencia)cmbGerencias.SelectedItem; 
                arreglo = daoReporte.generarReporteObjetivos(gerenciaSeleccionada.idGerencia);
                Global.iniciarEspera(this);
                File.WriteAllBytes(sfdReporte.FileName, arreglo);
                Global.terminarEspera(this);
            }
            
            MessageBox.Show("Reporte generado exitosamente .",
                                "Mensaje de confirmacion",
                                MessageBoxButtons.OK,
                                MessageBoxIcon.Information);
        }
    }
}
