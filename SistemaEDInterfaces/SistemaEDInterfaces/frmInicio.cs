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
    public partial class frmInicio : Form
    {
        public frmInicio()
        {
            InitializeComponent();
        }

        private void panelMenu_Paint(object sender, PaintEventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            if(panelPlanificacion.Visible == true)
            {
                panelPlanificacion.Visible = false;
                btnEvaluacion.Location = new Point(12, 207);
                panelLeftEvaluacion.Location = new Point(3, 207);
            }
            else
            {
                panelPlanificacion.Location = new Point(12, 202);
                panelPlanificacion.Visible = true;
                
                btnEvaluacion.Location = new Point(12, 308);
                panelLeftEvaluacion.Location = new Point(3, 308); 
                
            }
            //btnPlanificacion.Location = new Point(12, 154);
            //panelPlanificacion.Location = new Point(12, 207);
            //if (panelPlanificacion.Visible == false)
            //{
            //    btnPlanificacion.Location = new Point(12, 154);
            //    btnEvaluacion.Location = new Point(12, 308);
            //}
        }

        private void panelPlanificacion_Paint(object sender, PaintEventArgs e)
        {

        }

        private void panel3_Paint(object sender, PaintEventArgs e)
        {

        }

        private void frmInicio_Load(object sender, EventArgs e)
        {
            panelPlanificacion.Hide();
            panelEvaluacion.Hide(); 
            btnPlanificacion.Location = new Point(12, 154);
            panelLeftPlanificacion.Location = new Point(3, 154); 
            btnEvaluacion.Location = new Point(12, 207);
            panelLeftEvaluacion.Location = new Point(3, 207); 
        }

        private void btnMisObjetivos_Click(object sender, EventArgs e)
        {

        }
    }
}
