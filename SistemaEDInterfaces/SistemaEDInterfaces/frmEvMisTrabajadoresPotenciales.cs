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
    public partial class frmEvMisTrabajadoresPotenciales : Form
    {
        private EvaluacionPotencialWS.lineaEvaluacion linea;
        private frmEvMisTrabajadoresEvPotencial formPadre;
        private EstadoFormulario estado;
        public EvaluacionPotencialWS.lineaEvaluacion Linea { get => linea; set => linea = value; }
        public frmEvMisTrabajadoresEvPotencial FormPadre { get => formPadre; set => formPadre = value; }
        public EstadoFormulario Estado { get => estado; set => estado = value; }
        public frmEvMisTrabajadoresPotenciales()
        {
            InitializeComponent();
            dgvSubpotenciales.AutoGenerateColumns = false; 
        }


        private void asignarSublineasYCalcularNotaLinea()
        {
            BindingList<EvaluacionPotencialWS.lineaEvaluacion> lineas = new BindingList<EvaluacionPotencialWS.lineaEvaluacion>();
            double notaLinea = 0.0;
            for (int i = 0; i < dgvSubpotenciales.Rows.Count; i++)
            {
                EvaluacionPotencialWS.lineaEvaluacion lineaActual =
                    dgvSubpotenciales.Rows[i].DataBoundItem as EvaluacionPotencialWS.lineaEvaluacion;
                //Por si acaso 
                lineaActual.notaFinal = Double.Parse(dgvSubpotenciales.Rows[i].Cells["nota3"].Value.ToString());
                //Se calcula la nota de la linea 
                notaLinea += lineaActual.notaFinal * (lineaActual.pesoCriterio.peso / 100);
                //Se agrega a la lista de lineas 
                lineas.Add(lineaActual);

            }
            //Asignar las nuevas sublineas 
            if (lineas != null) linea.sublineasEvaluacion = lineas.ToArray();
            linea.notaFinal = notaLinea;
            FormPadre.actualizarLinea(linea);
        }

        private void btnRegresar_Click(object sender, EventArgs e)
        {
            //Asignar lineas 
            if (estado.Equals(EstadoFormulario.Editable))
            {
                asignarSublineasYCalcularNotaLinea();
            }

            Global.formPrincipal.cerrarFormularioHijo();

        }


        private void dgvSubpotenciales_CellFormatting(object sender, DataGridViewCellFormattingEventArgs e)
        {
            EvaluacionPotencialWS.lineaEvaluacion data = dgvSubpotenciales.Rows[e.RowIndex].DataBoundItem as EvaluacionPotencialWS.lineaEvaluacion;
            dgvSubpotenciales.Rows[e.RowIndex].Cells["ID"].Value = data.pesoCriterio.criterio.idCriterio;
            dgvSubpotenciales.Rows[e.RowIndex].Cells["nombre"].Value = data.pesoCriterio.criterio.nombre;
            dgvSubpotenciales.Rows[e.RowIndex].Cells["descripcion"].Value = data.pesoCriterio.criterio.descripcion;
            dgvSubpotenciales.Rows[e.RowIndex].Cells["peso"].Value = data.pesoCriterio.peso;
        }

        private void frmEvMisTrabajadoresPotenciales_Load(object sender, EventArgs e)
        {
            dgvSubpotenciales.DataSource = linea.sublineasEvaluacion;
            if (estado.Equals(EstadoFormulario.Inicial) || estado.Equals(EstadoFormulario.NoEditable))
            {
                dgvSubpotenciales.Columns["nota3"].ReadOnly = true;
            }
        }
    }
    
}
