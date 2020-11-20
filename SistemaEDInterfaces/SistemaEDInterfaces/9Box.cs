﻿using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Runtime.InteropServices;

namespace SistemaEDInterfaces
{
    public partial class _9Box : UserControl
    {
        private BtnColaborador colaboradorSeleccionado;
        private BindingList<BtnColaborador> colaboradores;

        public _9Box()
        {
            InitializeComponent();

            InitializeFlowLayoutPanels(3,5);

            colaboradores = new BindingList<BtnColaborador>();

        }

        public void InitializeFlowLayoutPanels(int rows = 3, int columns = 3)
        {
            InitializeTableLayoutPanel(rows, columns, this.tlp9Box.Size);


            for (int i = 0; i < this.tlp9Box.ColumnCount; i++)
            {
                for (int j = 0; j < this.tlp9Box.RowCount; j++)
                {

                    FlowLayoutPanel p = new FlowLayoutPanel();
                    p.Name = "flp" + i.ToString() + j.ToString();
                    p.BackColor = Color.White;
                    p.AllowDrop = true;
                    p.AutoScroll = true;
                    p.Visible = true;

                    p.DragEnter += P_DragEnter;
                    p.DragDrop += P_DragDrop;

                    this.tlp9Box.SetCellPosition(p,
                        new TableLayoutPanelCellPosition(i, j));
                    this.tlp9Box.Controls.Add(p);
                    TableLayoutPanelCellPosition celda =
                        this.tlp9Box.GetCellPosition(p);
                    p.Height = this.tlp9Box.GetRowHeights()[celda.Row];
                    p.Width = this.tlp9Box.GetColumnWidths()[celda.Column];

                }
            }
        }

        public BtnColaborador ColaboradorSeleccionado { get => colaboradorSeleccionado; set => colaboradorSeleccionado = value; }

        private void P_DragDrop(object sender, DragEventArgs e)
        {
            FlowLayoutPanel panel = (FlowLayoutPanel)sender;
            foreach (BtnColaborador c in colaboradores)
                if (c.Clicked)
                    colaboradorSeleccionado = c;
            FlowLayoutPanel org = (FlowLayoutPanel) colaboradorSeleccionado.Contenedor;

            if (org.Name != panel.Name)
            {
                panel.Controls.Add(colaboradorSeleccionado);
                org.Controls.Remove(colaboradorSeleccionado);
                colaboradorSeleccionado.Clicked = false;
                colaboradorSeleccionado.Contenedor = panel;
            }

        }

        private void P_DragEnter(object sender, DragEventArgs e)
        {
            //falta hacer la validacion
            e.Effect = DragDropEffects.Move;
        }

        private void InitializeTableLayoutPanel(int rows, int columns, Size size)
        {
            this.tlp9Box.RowStyles.Clear();
            this.tlp9Box.ColumnStyles.Clear();

            this.tlp9Box.RowCount = rows;
            this.tlp9Box.ColumnCount = columns;

            for (int i = 0; i < rows; i++)
                this.tlp9Box.RowStyles.Add(new RowStyle(SizeType.Absolute, 
                    size.Height / rows));

            for (int j = 0; j < columns; j++)
                this.tlp9Box.ColumnStyles.Add(new ColumnStyle(SizeType.Absolute,
                    size.Width / columns));
        }

        public void setColor(Color c)
        {
            this.tlp9Box.BackColor = c;
        }

        public void setPanelsColor(Color c)
        {
            this.tlp9Box.Controls.OfType<Control>().Where(p => p is FlowLayoutPanel).ToList().ForEach( panel => {
                panel.BackColor = c;
            });
        }

        public void insertarBtnColaborador(BtnColaborador btn, int column = 0, int row = 0)
        {
            Control panel = this.tlp9Box.GetControlFromPosition(column,row);
            if (panel != null && !colaboradores.Contains(btn))
            {
                panel.Controls.Add(btn);
                btn.Contenedor = (FlowLayoutPanel) panel;
                colaboradores.Add(btn);
            }
        }

        public void eliminarBtnColaborador(BtnColaborador btn, int column, int row)
        {
            Control panel = this.tlp9Box.GetControlFromPosition(column, row);
            if (panel != null && panel.Contains(btn) && !colaboradores.Contains(btn))
            {
                panel.Controls.Remove(btn);
                colaboradores.Remove(btn);
            }
        }

    }
}
