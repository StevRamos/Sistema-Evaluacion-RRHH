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
    [ComplexBindingProperties("DataSource", "DataMember")]
    public partial class dgvCupos : UserControl
    {
        Control[] cupos;
        Control[] nineBox;
        String[] numeroColab;

        public dgvCupos()
        {
            InitializeComponent();
            cupos = this.inicializaCupos();
            nineBox = this.inicializaNineBox();
        }

        public String[] NumeroColab
        {
            get
            {
                return this.numeroColab;
            }

            set
            {
                this.numeroColab = value;
            }
        }

        private Control[] inicializaNineBox()
        {
            Control[] aux = new Control[5];

            aux[0] = this.lblA9Box;
            aux[1] = this.lblB9Box;
            aux[2] = this.lblC9Box;
            aux[3] = this.lblD9Box;
            aux[4] = this.lblE9Box;

            for (int i = 0; i < 5; i++)
                aux[i].Text = "";

            return aux;
        }

        private Control[] inicializaCupos()
        {
            Control[] aux = new Control[5];

            aux[0] = this.lblACupo;
            aux[1] = this.lblBCupo;
            aux[2] = this.lblCCupo;
            aux[3] = this.lblDCupo;
            aux[4] = this.lblECupo;

            for (int i = 0; i < 5; i++)
                aux[i].Text = "";

            return aux;
        }

        public void setCupos(int[] cupos)
        {
            for (int i = 0; i < this.cupos.Length; i++)
                this.cupos[i].Text = cupos[i].ToString();
        }

        public void setNineBox(int[] num)
        {
            for (int i = 0; i < this.nineBox.Length; i++)
            {
                this.nineBox[i].DataBindings.Add(new Binding("Checked", 
                                    num[i], ""));
            }
                

        }

    }
}
