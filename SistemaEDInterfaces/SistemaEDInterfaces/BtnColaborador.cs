using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace SistemaEDInterfaces
{
    public partial class BtnColaborador : UserControl
    {
        private bool clicked = false;
        private FlowLayoutPanel contenedor;

        public BtnColaborador()
        {
            InitializeComponent();
            this.lblNombre = this.Controls.OfType<Label>().First();
        }

        public bool Clicked { get => clicked; set => clicked = value; }
        public FlowLayoutPanel Contenedor { get => contenedor; set => contenedor = value; }

        private void BtnColaborador_MouseDown(object sender, MouseEventArgs e)
        {
            if (e.Button == MouseButtons.Left)
            {
                Clicked = true;
                this.contenedor.DoDragDrop(this, DragDropEffects.Move);
            }

        }

        public void setNombre(String nombre)
        {
            this.lblNombre.Text = nombre;
        }

    }
}
