using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Collections;

namespace SistemaEDInterfaces
{
    public partial class NineBox : UserControl
    {
        private BtnColaborador colaboradorSeleccionado;
        private BindingList<BtnColaborador> colaboradores;

        /* opcional para cupos */
        private dgvCupos cupos;

        public NineBox()
        {
            InitializeComponent();

            this.tlp9Box.Size = new Size(940, 500);

            InitializeFlowLayoutPanels(3, 5);

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
        public dgvCupos Cupos { get => cupos; set => cupos = value; }

        private void P_DragDrop(object sender, DragEventArgs e)
        {
            FlowLayoutPanel panel = (FlowLayoutPanel)sender;
            foreach (BtnColaborador c in colaboradores)
                if (c.Clicked)
                    colaboradorSeleccionado = c;
            FlowLayoutPanel org = (FlowLayoutPanel)colaboradorSeleccionado.Contenedor;

            if (org.Name != panel.Name)
            {
                panel.Controls.Add(colaboradorSeleccionado);
                org.Controls.Remove(colaboradorSeleccionado);
                colaboradorSeleccionado.Clicked = false;
                colaboradorSeleccionado.Contenedor = panel;
                this.sumatoriaColaboradores();
            }

        }

        private void P_DragEnter(object sender, DragEventArgs e)
        {
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
            this.tlp9Box.Controls.OfType<Control>().Where(p => p is FlowLayoutPanel).ToList().ForEach(panel => {
                panel.BackColor = c;
            });
        }

        public void insertarBtnColaborador(BtnColaborador btn, int column = 0, int row = 0)
        {
            Control panel = this.tlp9Box.GetControlFromPosition(column, row);
            if (panel != null && !colaboradores.Contains(btn))
            {
                panel.Controls.Add(btn);
                btn.Contenedor = (FlowLayoutPanel)panel;
                colaboradores.Add(btn);
                this.sumatoriaColaboradores();
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

        public void SetDrop(bool drop)
        {
            this.tlp9Box.Controls.OfType<Control>().Where(p => p is FlowLayoutPanel).ToList().ForEach(panel => {
                panel.AllowDrop = drop;
            });
        }

        public void sumatoriaColaboradores()
        {
            int[] colab;
            int x;
            Control panel;

            colab = new int[this.tlp9Box.ColumnCount];

            for (int i = 0, k = this.tlp9Box.ColumnCount - 1; i < this.tlp9Box.ColumnCount; i++, k-- )
            {
                x = 0;
                for(int j=0; j < tlp9Box.RowCount; j++)
                {
                    panel = this.tlp9Box.GetControlFromPosition(i, j);
                    panel.Controls.OfType<BtnColaborador>().ToList().ForEach(btn => {
                        x++;
                    });
                }
                colab[k] = x;
            }
            if( this.cupos != null)
                this.cupos.setNineBox(colab);

        }

        public void vaciar9Box()
        {
            Control panel;

            for (int i = 0; i < this.tlp9Box.ColumnCount; i++)
            {
                for (int j = 0; j < tlp9Box.RowCount; j++)
                {
                    panel = this.tlp9Box.GetControlFromPosition(i, j);
                    panel.Controls.OfType<BtnColaborador>().ToList().ForEach(btn => {
                        panel.Controls.Remove(btn);
                        colaboradores.Remove(btn);
                    });
                }
            }
        }

        public BindingList<BtnColaborador> asignarNotas(Hashtable potencial, Hashtable desempenho)
        {
            BindingList<BtnColaborador> lista = new BindingList<BtnColaborador>();

            Control panel;

            for (int i = 0; i < this.tlp9Box.ColumnCount; i++)
            {
                for (int j = 0; j < tlp9Box.RowCount; j++)
                {
                    panel = this.tlp9Box.GetControlFromPosition(i, j);
                    panel.Controls.OfType<BtnColaborador>().ToList().ForEach(btn => {
                        btn.GetColaborador().evaluaciones[0].escalaFinal.idEscala = (int)potencial[j];
                        btn.GetColaborador().evaluaciones[1].escalaFinal.idEscala = (int)desempenho[j];
                        lista.Add(btn);
                    });
                }
            }

            return lista;

        }
    }
}
