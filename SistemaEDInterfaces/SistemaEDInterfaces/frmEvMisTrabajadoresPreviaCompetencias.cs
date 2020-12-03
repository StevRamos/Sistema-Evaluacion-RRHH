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
    public partial class frmEvMisTrabajadoresPreviaCompetencias : Form
    {
        private EvaluacionDesempenhoWS.lineaEvaluacion linea;
        private frmEvMisTrabajadoresPrevia formPadre;
        private EstadoFormulario estado;
        public EvaluacionDesempenhoWS.lineaEvaluacion Linea { get => linea; set => linea = value; }
        public frmEvMisTrabajadoresPrevia FormPadre { get => formPadre; set => formPadre = value; }
        public EstadoFormulario Estado { get => estado; set => estado = value; }
        public frmEvMisTrabajadoresPreviaCompetencias()
        {
            InitializeComponent();
            dgvSubcompetencias.AutoGenerateColumns = false;
        }
        private void asignarSublineasYCalcularNotaLinea()
        {
            BindingList<EvaluacionDesempenhoWS.lineaEvaluacion> lineas = new BindingList<EvaluacionDesempenhoWS.lineaEvaluacion>();
            double notaLinea = 0.0;
            for (int i = 0; i < dgvSubcompetencias.Rows.Count; i++)
            {
                EvaluacionDesempenhoWS.lineaEvaluacion lineaActual =
                    dgvSubcompetencias.Rows[i].DataBoundItem as EvaluacionDesempenhoWS.lineaEvaluacion;
                //Por si acaso 
                lineaActual.notaPrevia = Double.Parse(dgvSubcompetencias.Rows[i].Cells["nota"].Value.ToString());
                //Se calcula la nota de la linea 
                notaLinea += lineaActual.notaPrevia * (lineaActual.pesoCriterio.peso / 100);
                //Se agrega a la lista de lineas 
                lineas.Add(lineaActual);

            }
            //Asignar las nuevas sublineas 
            if (lineas != null) linea.sublineasEvaluacion = lineas.ToArray();
            linea.notaPrevia = notaLinea;
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


        private void frmEvMisTrabajadoresPreviaCompetencias_Load(object sender, EventArgs e)
        {
            dgvSubcompetencias.DataSource = linea.sublineasEvaluacion;
            if (estado.Equals(EstadoFormulario.Inicial) || estado.Equals(EstadoFormulario.NoEditable))
            {
                dgvSubcompetencias.Columns["nota"].ReadOnly = true;
            }
        }

        private void dgvSubcompetencias_CellFormatting(object sender, DataGridViewCellFormattingEventArgs e)
        {
            EvaluacionDesempenhoWS.lineaEvaluacion data = dgvSubcompetencias.Rows[e.RowIndex].DataBoundItem as EvaluacionDesempenhoWS.lineaEvaluacion;
            dgvSubcompetencias.Rows[e.RowIndex].Cells["ID"].Value = data.pesoCriterio.criterio.idCriterio;
            dgvSubcompetencias.Rows[e.RowIndex].Cells["nombre"].Value = data.pesoCriterio.criterio.nombre;
            dgvSubcompetencias.Rows[e.RowIndex].Cells["descripcion"].Value = data.pesoCriterio.criterio.descripcion;
            dgvSubcompetencias.Rows[e.RowIndex].Cells["peso"].Value = data.pesoCriterio.peso;
        }
    }
}
