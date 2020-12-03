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
    public partial class frmEvMisResultadosCompetencias : Form
    {
        private EvaluacionDesempenhoWS.lineaEvaluacion linea;
        private frmEvMisResultados formPadre;
        public EvaluacionDesempenhoWS.lineaEvaluacion Linea { get => linea; set => linea = value; }
        public frmEvMisResultados FormPadre { get => formPadre; set => formPadre = value; }
        public frmEvMisResultadosCompetencias()
        {
            InitializeComponent();
            dgvSubcompetencias.AutoGenerateColumns = false;
        }

        private void btnRegresar_Click(object sender, EventArgs e)
        {
            Global.formPrincipal.cerrarFormularioHijo();
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
