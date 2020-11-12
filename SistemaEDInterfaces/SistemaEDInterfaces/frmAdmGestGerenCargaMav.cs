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
    public partial class frmAdmGestGerenCargaMav : Form
    {
        private GerenciaWS.GerenciaWSClient daoGerencia;
        
        public frmAdmGestGerenCargaMav()
        {
            InitializeComponent();
            daoGerencia = new GerenciaWS.ObjetivoWSClient();
        }

        private void btnCargarComMasiva_Click(object sender, EventArgs e)
        {
            string[] lineas = File.ReadAllLines(txtNomArchGerenMav.Text);

            if ((rdbActCargaMavGer.Checked || rdbInsCargaMavGer.Checked) && txtNomArchGerenMav.Text != "")
            {

                if (rdbActCargaMavGer.Checked!=false) {
                    foreach (var linea in lineas)
                    {
                        var valores = linea.Split(';');
                        GerenciaWS.Gerencia gerencia = new GerenciaWS.Gerencia();
                        
                        int dato = int.Parse(valores[0].ToString);
                        gerencia.setIdGerencia(dato);

                        if (valores[1] != "no") {
                            gerencia.setNombre(valores[0].ToString());
                        } else {
                            gerencia.setNombre("");
                        }
                        if (valores[2] != "no") {
                            gerencia.setDescripcion(valores[1].ToString());
                        }
                        else
                        {
                            gerencia.setDescripcion("");
                        }
                        
                        daoGerencia.actualizarGerencia(gerencia);
                    }
                } else if (rdbInsCargaMavGer.Checked!=false) {
                    foreach (var linea in lineas)
                    {
                        var valores = linea.Split(';');
                        GerenciaWS.Gerencia gerencia = new GerenciaWS.Gerencia();
                        gerencia.setNombre(valores[0].ToString());
                        gerencia.setDescripcion(valores[1].ToString());
                        daoGerencia.insertarGerencia(gerencia);
                    }
                }

                MessageBox.Show("El archivo se cargó correctamente");
                this.Close();
            }
            else if ((rdbActCargaMavGer.Checked == false) && (rdbInsCargaMavGer.Checked == false) && txtNomArchGerenMav.Text != "")
            {
                MessageBox.Show("Elija la opción insertar o actualizar");
            }
            else if ((txtNomArchGerenMav.Text == "") && (rdbInsCargaMavGer.Checked || rdbActCargaMavGer.Checked))
            {
                MessageBox.Show("Inserte su archivo");
            }
            else if ((rdbActCargaMavGer.Checked == false || rdbInsCargaMavGer.Checked == false) && txtNomArchGerenMav.Text == "")
            {
                MessageBox.Show("Ingrese los datos");
            }
        }

        private void btnGestGerSelecGer_Click(object sender, EventArgs e)
        {
            OpenFileDialog buscar = new OpenFileDialog();
            if (buscar.ShowDialog() == DialogResult.OK)
            {
                txtNomArchGerenMav.Text = buscar.FileName;
            }
        }

        private void btnRegreCargMavGer_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
