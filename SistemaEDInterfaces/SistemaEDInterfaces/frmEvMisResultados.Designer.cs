namespace SistemaEDInterfaces
{
    partial class frmEvMisResultados
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.lblMisObjetivos = new System.Windows.Forms.Label();
            this.btnGenerar = new System.Windows.Forms.Button();
            this.sfdReporte = new System.Windows.Forms.SaveFileDialog();
            this.panelDatosColaborador = new System.Windows.Forms.Panel();
            this.txtIDColab = new System.Windows.Forms.TextBox();
            this.lblDatosColaborador = new System.Windows.Forms.Label();
            this.lblIDColab = new System.Windows.Forms.Label();
            this.lblDNI = new System.Windows.Forms.Label();
            this.lblNombre = new System.Windows.Forms.Label();
            this.txtGerencia = new System.Windows.Forms.TextBox();
            this.txtNombre = new System.Windows.Forms.TextBox();
            this.txtCargo = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.txtDNI = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.txtNotaDesempenho = new System.Windows.Forms.TextBox();
            this.label6 = new System.Windows.Forms.Label();
            this.lblCompetenciasFinal = new System.Windows.Forms.Label();
            this.lblCompetenciasPrevia = new System.Windows.Forms.Label();
            this.lblCompetenciasAuto = new System.Windows.Forms.Label();
            this.lblLogroPrevia = new System.Windows.Forms.Label();
            this.lblLogroAuto = new System.Windows.Forms.Label();
            this.lblMaxCarObj = new System.Windows.Forms.Label();
            this.lblMaxCarComp = new System.Windows.Forms.Label();
            this.lbl4 = new System.Windows.Forms.Label();
            this.lbl5 = new System.Windows.Forms.Label();
            this.lbl3 = new System.Windows.Forms.Label();
            this.lbl2 = new System.Windows.Forms.Label();
            this.lbl1 = new System.Windows.Forms.Label();
            this.lblLogro = new System.Windows.Forms.Label();
            this.lblPeso = new System.Windows.Forms.Label();
            this.lblCantidad = new System.Windows.Forms.Label();
            this.lblObjetivo = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.lblDescripcionCompetencias = new System.Windows.Forms.Label();
            this.txtNotaCompetencias = new System.Windows.Forms.TextBox();
            this.lblNotaCompetencias = new System.Windows.Forms.Label();
            this.txtNotaObjetivos = new System.Windows.Forms.TextBox();
            this.label7 = new System.Windows.Forms.Label();
            this.lblTituloCompetencias = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.txtObservacionesCompetencias = new System.Windows.Forms.TextBox();
            this.lblObservacionesComp = new System.Windows.Forms.Label();
            this.txtObservacionesObjetivos = new System.Windows.Forms.TextBox();
            this.lblObservacionesObj = new System.Windows.Forms.Label();
            this.lblNo = new System.Windows.Forms.Label();
            this.lblSi = new System.Windows.Forms.Label();
            this.lblNotaPotenciales = new System.Windows.Forms.Label();
            this.lblMaxCarPot = new System.Windows.Forms.Label();
            this.lblDescripcionPotenciales = new System.Windows.Forms.Label();
            this.lblTituloPotenciales = new System.Windows.Forms.Label();
            this.txtObservacionesPotencial = new System.Windows.Forms.TextBox();
            this.lblObservacionesPotencial = new System.Windows.Forms.Label();
            this.txtNotaPotencial = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.lblTituloEvaluacionPotencial = new System.Windows.Forms.Label();
            this.lblFantasma = new System.Windows.Forms.Label();
            this.btnRegresar = new System.Windows.Forms.Button();
            this.panelDatosColaborador.SuspendLayout();
            this.SuspendLayout();
            // 
            // lblMisObjetivos
            // 
            this.lblMisObjetivos.AutoSize = true;
            this.lblMisObjetivos.Font = new System.Drawing.Font("Century Gothic", 36F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblMisObjetivos.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(66)))), ((int)(((byte)(122)))));
            this.lblMisObjetivos.Location = new System.Drawing.Point(12, 9);
            this.lblMisObjetivos.Name = "lblMisObjetivos";
            this.lblMisObjetivos.Size = new System.Drawing.Size(275, 56);
            this.lblMisObjetivos.TabIndex = 7;
            this.lblMisObjetivos.Text = "Resultados";
            // 
            // btnGenerar
            // 
            this.btnGenerar.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(157)))), ((int)(((byte)(6)))), ((int)(((byte)(32)))));
            this.btnGenerar.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnGenerar.Font = new System.Drawing.Font("Century Gothic", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnGenerar.ForeColor = System.Drawing.Color.White;
            this.btnGenerar.Location = new System.Drawing.Point(17, 269);
            this.btnGenerar.Margin = new System.Windows.Forms.Padding(2);
            this.btnGenerar.Name = "btnGenerar";
            this.btnGenerar.Size = new System.Drawing.Size(246, 30);
            this.btnGenerar.TabIndex = 54;
            this.btnGenerar.Text = "Generar Reporte de Evaluación";
            this.btnGenerar.UseVisualStyleBackColor = false;
            this.btnGenerar.Click += new System.EventHandler(this.btnGenerar_Click);
            // 
            // panelDatosColaborador
            // 
            this.panelDatosColaborador.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(66)))), ((int)(((byte)(122)))));
            this.panelDatosColaborador.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.panelDatosColaborador.Controls.Add(this.txtIDColab);
            this.panelDatosColaborador.Controls.Add(this.lblDatosColaborador);
            this.panelDatosColaborador.Controls.Add(this.lblIDColab);
            this.panelDatosColaborador.Controls.Add(this.lblDNI);
            this.panelDatosColaborador.Controls.Add(this.lblNombre);
            this.panelDatosColaborador.Controls.Add(this.txtGerencia);
            this.panelDatosColaborador.Controls.Add(this.txtNombre);
            this.panelDatosColaborador.Controls.Add(this.txtCargo);
            this.panelDatosColaborador.Controls.Add(this.label1);
            this.panelDatosColaborador.Controls.Add(this.txtDNI);
            this.panelDatosColaborador.Controls.Add(this.label2);
            this.panelDatosColaborador.Location = new System.Drawing.Point(1, 68);
            this.panelDatosColaborador.Name = "panelDatosColaborador";
            this.panelDatosColaborador.Size = new System.Drawing.Size(1140, 120);
            this.panelDatosColaborador.TabIndex = 67;
            // 
            // txtIDColab
            // 
            this.txtIDColab.Enabled = false;
            this.txtIDColab.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtIDColab.Location = new System.Drawing.Point(154, 43);
            this.txtIDColab.Name = "txtIDColab";
            this.txtIDColab.Size = new System.Drawing.Size(339, 27);
            this.txtIDColab.TabIndex = 51;
            // 
            // lblDatosColaborador
            // 
            this.lblDatosColaborador.AutoSize = true;
            this.lblDatosColaborador.Font = new System.Drawing.Font("Century Gothic", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblDatosColaborador.ForeColor = System.Drawing.Color.White;
            this.lblDatosColaborador.Location = new System.Drawing.Point(32, 10);
            this.lblDatosColaborador.Name = "lblDatosColaborador";
            this.lblDatosColaborador.Size = new System.Drawing.Size(251, 24);
            this.lblDatosColaborador.TabIndex = 60;
            this.lblDatosColaborador.Text = "Datos del Colaborador:";
            // 
            // lblIDColab
            // 
            this.lblIDColab.AutoSize = true;
            this.lblIDColab.Font = new System.Drawing.Font("Century Gothic", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblIDColab.ForeColor = System.Drawing.Color.White;
            this.lblIDColab.Location = new System.Drawing.Point(32, 44);
            this.lblIDColab.Name = "lblIDColab";
            this.lblIDColab.Size = new System.Drawing.Size(36, 24);
            this.lblIDColab.TabIndex = 50;
            this.lblIDColab.Text = "ID:";
            // 
            // lblDNI
            // 
            this.lblDNI.AutoSize = true;
            this.lblDNI.Font = new System.Drawing.Font("Century Gothic", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblDNI.ForeColor = System.Drawing.Color.White;
            this.lblDNI.Location = new System.Drawing.Point(858, 46);
            this.lblDNI.Name = "lblDNI";
            this.lblDNI.Size = new System.Drawing.Size(52, 24);
            this.lblDNI.TabIndex = 59;
            this.lblDNI.Text = "DNI:";
            // 
            // lblNombre
            // 
            this.lblNombre.AutoSize = true;
            this.lblNombre.Font = new System.Drawing.Font("Century Gothic", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblNombre.ForeColor = System.Drawing.Color.White;
            this.lblNombre.Location = new System.Drawing.Point(32, 83);
            this.lblNombre.Name = "lblNombre";
            this.lblNombre.Size = new System.Drawing.Size(100, 24);
            this.lblNombre.TabIndex = 52;
            this.lblNombre.Text = "Nombre:";
            // 
            // txtGerencia
            // 
            this.txtGerencia.Enabled = false;
            this.txtGerencia.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtGerencia.Location = new System.Drawing.Point(637, 80);
            this.txtGerencia.Name = "txtGerencia";
            this.txtGerencia.Size = new System.Drawing.Size(209, 27);
            this.txtGerencia.TabIndex = 58;
            // 
            // txtNombre
            // 
            this.txtNombre.Enabled = false;
            this.txtNombre.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtNombre.Location = new System.Drawing.Point(154, 80);
            this.txtNombre.Name = "txtNombre";
            this.txtNombre.Size = new System.Drawing.Size(339, 27);
            this.txtNombre.TabIndex = 53;
            // 
            // txtCargo
            // 
            this.txtCargo.Enabled = false;
            this.txtCargo.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtCargo.Location = new System.Drawing.Point(637, 44);
            this.txtCargo.Name = "txtCargo";
            this.txtCargo.Size = new System.Drawing.Size(209, 27);
            this.txtCargo.TabIndex = 57;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Century Gothic", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.White;
            this.label1.Location = new System.Drawing.Point(508, 46);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(80, 24);
            this.label1.TabIndex = 54;
            this.label1.Text = "Cargo:";
            // 
            // txtDNI
            // 
            this.txtDNI.Enabled = false;
            this.txtDNI.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtDNI.Location = new System.Drawing.Point(916, 44);
            this.txtDNI.Name = "txtDNI";
            this.txtDNI.Size = new System.Drawing.Size(177, 27);
            this.txtDNI.TabIndex = 56;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Century Gothic", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.ForeColor = System.Drawing.Color.White;
            this.label2.Location = new System.Drawing.Point(508, 83);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(111, 24);
            this.label2.TabIndex = 55;
            this.label2.Text = "Gerencia:";
            // 
            // txtNotaDesempenho
            // 
            this.txtNotaDesempenho.Enabled = false;
            this.txtNotaDesempenho.Font = new System.Drawing.Font("Microsoft Sans Serif", 27.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtNotaDesempenho.Location = new System.Drawing.Point(710, 278);
            this.txtNotaDesempenho.Name = "txtNotaDesempenho";
            this.txtNotaDesempenho.Size = new System.Drawing.Size(153, 49);
            this.txtNotaDesempenho.TabIndex = 70;
            // 
            // label6
            // 
            this.label6.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(66)))), ((int)(((byte)(122)))));
            this.label6.Location = new System.Drawing.Point(706, 230);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(202, 54);
            this.label6.TabIndex = 69;
            this.label6.Text = "Calificación Evaluación Desempeño";
            // 
            // lblCompetenciasFinal
            // 
            this.lblCompetenciasFinal.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblCompetenciasFinal.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(66)))), ((int)(((byte)(122)))));
            this.lblCompetenciasFinal.Location = new System.Drawing.Point(915, 841);
            this.lblCompetenciasFinal.Name = "lblCompetenciasFinal";
            this.lblCompetenciasFinal.Size = new System.Drawing.Size(124, 36);
            this.lblCompetenciasFinal.TabIndex = 139;
            this.lblCompetenciasFinal.Text = "Nota en Evaluación Final";
            // 
            // lblCompetenciasPrevia
            // 
            this.lblCompetenciasPrevia.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblCompetenciasPrevia.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(66)))), ((int)(((byte)(122)))));
            this.lblCompetenciasPrevia.Location = new System.Drawing.Point(581, 841);
            this.lblCompetenciasPrevia.Name = "lblCompetenciasPrevia";
            this.lblCompetenciasPrevia.Size = new System.Drawing.Size(124, 36);
            this.lblCompetenciasPrevia.TabIndex = 138;
            this.lblCompetenciasPrevia.Text = "Nota en Evaluación Previa";
            // 
            // lblCompetenciasAuto
            // 
            this.lblCompetenciasAuto.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblCompetenciasAuto.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(66)))), ((int)(((byte)(122)))));
            this.lblCompetenciasAuto.Location = new System.Drawing.Point(468, 841);
            this.lblCompetenciasAuto.Name = "lblCompetenciasAuto";
            this.lblCompetenciasAuto.Size = new System.Drawing.Size(112, 36);
            this.lblCompetenciasAuto.TabIndex = 137;
            this.lblCompetenciasAuto.Text = "Nota en Autoevaluación";
            // 
            // lblLogroPrevia
            // 
            this.lblLogroPrevia.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblLogroPrevia.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(66)))), ((int)(((byte)(122)))));
            this.lblLogroPrevia.Location = new System.Drawing.Point(788, 467);
            this.lblLogroPrevia.Name = "lblLogroPrevia";
            this.lblLogroPrevia.Size = new System.Drawing.Size(124, 36);
            this.lblLogroPrevia.TabIndex = 136;
            this.lblLogroPrevia.Text = "Logro en Evaluación Previa";
            // 
            // lblLogroAuto
            // 
            this.lblLogroAuto.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblLogroAuto.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(66)))), ((int)(((byte)(122)))));
            this.lblLogroAuto.Location = new System.Drawing.Point(675, 467);
            this.lblLogroAuto.Name = "lblLogroAuto";
            this.lblLogroAuto.Size = new System.Drawing.Size(112, 36);
            this.lblLogroAuto.TabIndex = 135;
            this.lblLogroAuto.Text = "Logro en Autoevaluación";
            // 
            // lblMaxCarObj
            // 
            this.lblMaxCarObj.AutoSize = true;
            this.lblMaxCarObj.Font = new System.Drawing.Font("Century Gothic", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblMaxCarObj.Location = new System.Drawing.Point(212, 684);
            this.lblMaxCarObj.Name = "lblMaxCarObj";
            this.lblMaxCarObj.Size = new System.Drawing.Size(135, 17);
            this.lblMaxCarObj.TabIndex = 134;
            this.lblMaxCarObj.Text = "Max. 100 caracteres";
            // 
            // lblMaxCarComp
            // 
            this.lblMaxCarComp.AutoSize = true;
            this.lblMaxCarComp.Font = new System.Drawing.Font("Century Gothic", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblMaxCarComp.Location = new System.Drawing.Point(212, 1047);
            this.lblMaxCarComp.Name = "lblMaxCarComp";
            this.lblMaxCarComp.Size = new System.Drawing.Size(135, 17);
            this.lblMaxCarComp.TabIndex = 133;
            this.lblMaxCarComp.Text = "Max. 100 caracteres";
            // 
            // lbl4
            // 
            this.lbl4.AutoSize = true;
            this.lbl4.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl4.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(66)))), ((int)(((byte)(122)))));
            this.lbl4.Location = new System.Drawing.Point(826, 847);
            this.lbl4.Name = "lbl4";
            this.lbl4.Size = new System.Drawing.Size(25, 25);
            this.lbl4.TabIndex = 132;
            this.lbl4.Text = "4";
            // 
            // lbl5
            // 
            this.lbl5.AutoSize = true;
            this.lbl5.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl5.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(66)))), ((int)(((byte)(122)))));
            this.lbl5.Location = new System.Drawing.Point(866, 847);
            this.lbl5.Name = "lbl5";
            this.lbl5.Size = new System.Drawing.Size(25, 25);
            this.lbl5.TabIndex = 131;
            this.lbl5.Text = "5";
            // 
            // lbl3
            // 
            this.lbl3.AutoSize = true;
            this.lbl3.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl3.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(66)))), ((int)(((byte)(122)))));
            this.lbl3.Location = new System.Drawing.Point(786, 847);
            this.lbl3.Name = "lbl3";
            this.lbl3.Size = new System.Drawing.Size(25, 25);
            this.lbl3.TabIndex = 130;
            this.lbl3.Text = "3";
            // 
            // lbl2
            // 
            this.lbl2.AutoSize = true;
            this.lbl2.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl2.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(66)))), ((int)(((byte)(122)))));
            this.lbl2.Location = new System.Drawing.Point(746, 847);
            this.lbl2.Name = "lbl2";
            this.lbl2.Size = new System.Drawing.Size(25, 25);
            this.lbl2.TabIndex = 129;
            this.lbl2.Text = "2";
            // 
            // lbl1
            // 
            this.lbl1.AutoSize = true;
            this.lbl1.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl1.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(66)))), ((int)(((byte)(122)))));
            this.lbl1.Location = new System.Drawing.Point(706, 847);
            this.lbl1.Name = "lbl1";
            this.lbl1.Size = new System.Drawing.Size(25, 25);
            this.lbl1.TabIndex = 128;
            this.lbl1.Text = "1";
            // 
            // lblLogro
            // 
            this.lblLogro.AutoSize = true;
            this.lblLogro.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblLogro.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(66)))), ((int)(((byte)(122)))));
            this.lblLogro.Location = new System.Drawing.Point(918, 478);
            this.lblLogro.Name = "lblLogro";
            this.lblLogro.Size = new System.Drawing.Size(72, 25);
            this.lblLogro.TabIndex = 127;
            this.lblLogro.Text = "Logro";
            // 
            // lblPeso
            // 
            this.lblPeso.AutoSize = true;
            this.lblPeso.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblPeso.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(66)))), ((int)(((byte)(122)))));
            this.lblPeso.Location = new System.Drawing.Point(579, 478);
            this.lblPeso.Name = "lblPeso";
            this.lblPeso.Size = new System.Drawing.Size(65, 25);
            this.lblPeso.TabIndex = 126;
            this.lblPeso.Text = "Peso";
            // 
            // lblCantidad
            // 
            this.lblCantidad.AutoSize = true;
            this.lblCantidad.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblCantidad.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(66)))), ((int)(((byte)(122)))));
            this.lblCantidad.Location = new System.Drawing.Point(448, 478);
            this.lblCantidad.Name = "lblCantidad";
            this.lblCantidad.Size = new System.Drawing.Size(106, 25);
            this.lblCantidad.TabIndex = 125;
            this.lblCantidad.Text = "Cantidad";
            // 
            // lblObjetivo
            // 
            this.lblObjetivo.AutoSize = true;
            this.lblObjetivo.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblObjetivo.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(66)))), ((int)(((byte)(122)))));
            this.lblObjetivo.Location = new System.Drawing.Point(50, 478);
            this.lblObjetivo.Name = "lblObjetivo";
            this.lblObjetivo.Size = new System.Drawing.Size(99, 25);
            this.lblObjetivo.TabIndex = 124;
            this.lblObjetivo.Text = "Objetivo";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.Location = new System.Drawing.Point(14, 448);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(312, 20);
            this.label5.TabIndex = 123;
            this.label5.Text = "Ingrese el logro alcanzado de sus objetivos";
            // 
            // lblDescripcionCompetencias
            // 
            this.lblDescripcionCompetencias.AutoSize = true;
            this.lblDescripcionCompetencias.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblDescripcionCompetencias.Location = new System.Drawing.Point(8, 852);
            this.lblDescripcionCompetencias.Name = "lblDescripcionCompetencias";
            this.lblDescripcionCompetencias.Size = new System.Drawing.Size(438, 20);
            this.lblDescripcionCompetencias.TabIndex = 122;
            this.lblDescripcionCompetencias.Text = "Nivel deficiente (1-2). Nivel regular(3-4). Nivel sobresaliente(5)";
            // 
            // txtNotaCompetencias
            // 
            this.txtNotaCompetencias.Enabled = false;
            this.txtNotaCompetencias.Font = new System.Drawing.Font("Microsoft Sans Serif", 27.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtNotaCompetencias.Location = new System.Drawing.Point(918, 782);
            this.txtNotaCompetencias.Name = "txtNotaCompetencias";
            this.txtNotaCompetencias.Size = new System.Drawing.Size(153, 49);
            this.txtNotaCompetencias.TabIndex = 121;
            // 
            // lblNotaCompetencias
            // 
            this.lblNotaCompetencias.AutoSize = true;
            this.lblNotaCompetencias.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblNotaCompetencias.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(66)))), ((int)(((byte)(122)))));
            this.lblNotaCompetencias.Location = new System.Drawing.Point(913, 739);
            this.lblNotaCompetencias.Name = "lblNotaCompetencias";
            this.lblNotaCompetencias.Size = new System.Drawing.Size(61, 25);
            this.lblNotaCompetencias.TabIndex = 120;
            this.lblNotaCompetencias.Text = "Nota";
            // 
            // txtNotaObjetivos
            // 
            this.txtNotaObjetivos.Enabled = false;
            this.txtNotaObjetivos.Font = new System.Drawing.Font("Microsoft Sans Serif", 27.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtNotaObjetivos.Location = new System.Drawing.Point(918, 401);
            this.txtNotaObjetivos.Name = "txtNotaObjetivos";
            this.txtNotaObjetivos.Size = new System.Drawing.Size(153, 49);
            this.txtNotaObjetivos.TabIndex = 119;
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label7.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(66)))), ((int)(((byte)(122)))));
            this.label7.Location = new System.Drawing.Point(913, 364);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(68, 25);
            this.label7.TabIndex = 118;
            this.label7.Text = "Nota ";
            // 
            // lblTituloCompetencias
            // 
            this.lblTituloCompetencias.AutoSize = true;
            this.lblTituloCompetencias.Font = new System.Drawing.Font("Microsoft Sans Serif", 21.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblTituloCompetencias.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(66)))), ((int)(((byte)(122)))));
            this.lblTituloCompetencias.Location = new System.Drawing.Point(4, 793);
            this.lblTituloCompetencias.Name = "lblTituloCompetencias";
            this.lblTituloCompetencias.Size = new System.Drawing.Size(214, 33);
            this.lblTituloCompetencias.TabIndex = 117;
            this.lblTituloCompetencias.Text = "Competencias";
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Font = new System.Drawing.Font("Microsoft Sans Serif", 21.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label8.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(66)))), ((int)(((byte)(122)))));
            this.label8.Location = new System.Drawing.Point(12, 401);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(147, 33);
            this.label8.TabIndex = 116;
            this.label8.Text = "Objetivos";
            // 
            // txtObservacionesCompetencias
            // 
            this.txtObservacionesCompetencias.Enabled = false;
            this.txtObservacionesCompetencias.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F);
            this.txtObservacionesCompetencias.Location = new System.Drawing.Point(215, 948);
            this.txtObservacionesCompetencias.MaxLength = 100;
            this.txtObservacionesCompetencias.Multiline = true;
            this.txtObservacionesCompetencias.Name = "txtObservacionesCompetencias";
            this.txtObservacionesCompetencias.Size = new System.Drawing.Size(711, 84);
            this.txtObservacionesCompetencias.TabIndex = 115;
            // 
            // lblObservacionesComp
            // 
            this.lblObservacionesComp.AutoSize = true;
            this.lblObservacionesComp.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblObservacionesComp.Location = new System.Drawing.Point(16, 948);
            this.lblObservacionesComp.Name = "lblObservacionesComp";
            this.lblObservacionesComp.Size = new System.Drawing.Size(142, 24);
            this.lblObservacionesComp.TabIndex = 114;
            this.lblObservacionesComp.Text = "Observaciones:";
            // 
            // txtObservacionesObjetivos
            // 
            this.txtObservacionesObjetivos.Enabled = false;
            this.txtObservacionesObjetivos.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F);
            this.txtObservacionesObjetivos.Location = new System.Drawing.Point(215, 597);
            this.txtObservacionesObjetivos.MaxLength = 100;
            this.txtObservacionesObjetivos.Multiline = true;
            this.txtObservacionesObjetivos.Name = "txtObservacionesObjetivos";
            this.txtObservacionesObjetivos.Size = new System.Drawing.Size(711, 84);
            this.txtObservacionesObjetivos.TabIndex = 113;
            // 
            // lblObservacionesObj
            // 
            this.lblObservacionesObj.AutoSize = true;
            this.lblObservacionesObj.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblObservacionesObj.Location = new System.Drawing.Point(13, 597);
            this.lblObservacionesObj.Name = "lblObservacionesObj";
            this.lblObservacionesObj.Size = new System.Drawing.Size(142, 24);
            this.lblObservacionesObj.TabIndex = 112;
            this.lblObservacionesObj.Text = "Observaciones:";
            // 
            // lblNo
            // 
            this.lblNo.AutoSize = true;
            this.lblNo.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblNo.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(66)))), ((int)(((byte)(122)))));
            this.lblNo.Location = new System.Drawing.Point(700, 1214);
            this.lblNo.Name = "lblNo";
            this.lblNo.Size = new System.Drawing.Size(41, 25);
            this.lblNo.TabIndex = 153;
            this.lblNo.Text = "No";
            // 
            // lblSi
            // 
            this.lblSi.AutoSize = true;
            this.lblSi.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblSi.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(66)))), ((int)(((byte)(122)))));
            this.lblSi.Location = new System.Drawing.Point(612, 1214);
            this.lblSi.Name = "lblSi";
            this.lblSi.Size = new System.Drawing.Size(33, 25);
            this.lblSi.TabIndex = 152;
            this.lblSi.Text = "Sí";
            // 
            // lblNotaPotenciales
            // 
            this.lblNotaPotenciales.AutoSize = true;
            this.lblNotaPotenciales.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblNotaPotenciales.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(66)))), ((int)(((byte)(122)))));
            this.lblNotaPotenciales.Location = new System.Drawing.Point(891, 1214);
            this.lblNotaPotenciales.Name = "lblNotaPotenciales";
            this.lblNotaPotenciales.Size = new System.Drawing.Size(61, 25);
            this.lblNotaPotenciales.TabIndex = 151;
            this.lblNotaPotenciales.Text = "Nota";
            // 
            // lblMaxCarPot
            // 
            this.lblMaxCarPot.AutoSize = true;
            this.lblMaxCarPot.Font = new System.Drawing.Font("Century Gothic", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblMaxCarPot.Location = new System.Drawing.Point(212, 1428);
            this.lblMaxCarPot.Name = "lblMaxCarPot";
            this.lblMaxCarPot.Size = new System.Drawing.Size(135, 17);
            this.lblMaxCarPot.TabIndex = 150;
            this.lblMaxCarPot.Text = "Max. 100 caracteres";
            // 
            // lblDescripcionPotenciales
            // 
            this.lblDescripcionPotenciales.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblDescripcionPotenciales.Location = new System.Drawing.Point(12, 1214);
            this.lblDescripcionPotenciales.Name = "lblDescripcionPotenciales";
            this.lblDescripcionPotenciales.Size = new System.Drawing.Size(537, 46);
            this.lblDescripcionPotenciales.TabIndex = 149;
            this.lblDescripcionPotenciales.Text = "Indique el cumplimiento de cada subpotencial (Marqué \'Sí\' si considera que hubo c" +
    "umplimiento y \'No\' en caso contrario)";
            // 
            // lblTituloPotenciales
            // 
            this.lblTituloPotenciales.AutoSize = true;
            this.lblTituloPotenciales.Font = new System.Drawing.Font("Microsoft Sans Serif", 21.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblTituloPotenciales.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(66)))), ((int)(((byte)(122)))));
            this.lblTituloPotenciales.Location = new System.Drawing.Point(8, 1155);
            this.lblTituloPotenciales.Name = "lblTituloPotenciales";
            this.lblTituloPotenciales.Size = new System.Drawing.Size(177, 33);
            this.lblTituloPotenciales.TabIndex = 148;
            this.lblTituloPotenciales.Text = "Potenciales";
            // 
            // txtObservacionesPotencial
            // 
            this.txtObservacionesPotencial.Enabled = false;
            this.txtObservacionesPotencial.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F);
            this.txtObservacionesPotencial.Location = new System.Drawing.Point(215, 1329);
            this.txtObservacionesPotencial.MaxLength = 100;
            this.txtObservacionesPotencial.Multiline = true;
            this.txtObservacionesPotencial.Name = "txtObservacionesPotencial";
            this.txtObservacionesPotencial.Size = new System.Drawing.Size(711, 84);
            this.txtObservacionesPotencial.TabIndex = 147;
            // 
            // lblObservacionesPotencial
            // 
            this.lblObservacionesPotencial.AutoSize = true;
            this.lblObservacionesPotencial.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblObservacionesPotencial.Location = new System.Drawing.Point(16, 1329);
            this.lblObservacionesPotencial.Name = "lblObservacionesPotencial";
            this.lblObservacionesPotencial.Size = new System.Drawing.Size(142, 24);
            this.lblObservacionesPotencial.TabIndex = 146;
            this.lblObservacionesPotencial.Text = "Observaciones:";
            // 
            // txtNotaPotencial
            // 
            this.txtNotaPotencial.Enabled = false;
            this.txtNotaPotencial.Font = new System.Drawing.Font("Microsoft Sans Serif", 27.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtNotaPotencial.Location = new System.Drawing.Point(918, 278);
            this.txtNotaPotencial.Name = "txtNotaPotencial";
            this.txtNotaPotencial.Size = new System.Drawing.Size(153, 49);
            this.txtNotaPotencial.TabIndex = 156;
            // 
            // label3
            // 
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(66)))), ((int)(((byte)(122)))));
            this.label3.Location = new System.Drawing.Point(914, 230);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(181, 45);
            this.label3.TabIndex = 157;
            this.label3.Text = "Calificación Evaluación Potencial";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 27.75F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Underline))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(66)))), ((int)(((byte)(122)))));
            this.label4.Location = new System.Drawing.Point(12, 347);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(489, 42);
            this.label4.TabIndex = 158;
            this.label4.Text = "Evaluación de Desempeño";
            // 
            // lblTituloEvaluacionPotencial
            // 
            this.lblTituloEvaluacionPotencial.AutoSize = true;
            this.lblTituloEvaluacionPotencial.Font = new System.Drawing.Font("Microsoft Sans Serif", 27.75F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Underline))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblTituloEvaluacionPotencial.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(66)))), ((int)(((byte)(122)))));
            this.lblTituloEvaluacionPotencial.Location = new System.Drawing.Point(6, 1104);
            this.lblTituloEvaluacionPotencial.Name = "lblTituloEvaluacionPotencial";
            this.lblTituloEvaluacionPotencial.Size = new System.Drawing.Size(441, 42);
            this.lblTituloEvaluacionPotencial.TabIndex = 159;
            this.lblTituloEvaluacionPotencial.Text = "Evaluación de Potencial";
            // 
            // lblFantasma
            // 
            this.lblFantasma.AutoSize = true;
            this.lblFantasma.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblFantasma.ForeColor = System.Drawing.Color.White;
            this.lblFantasma.Location = new System.Drawing.Point(210, 1484);
            this.lblFantasma.Name = "lblFantasma";
            this.lblFantasma.Size = new System.Drawing.Size(61, 25);
            this.lblFantasma.TabIndex = 160;
            this.lblFantasma.Text = "Nota";
            // 
            // btnRegresar
            // 
            this.btnRegresar.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(157)))), ((int)(((byte)(6)))), ((int)(((byte)(32)))));
            this.btnRegresar.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnRegresar.Font = new System.Drawing.Font("Century Gothic", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnRegresar.ForeColor = System.Drawing.Color.White;
            this.btnRegresar.Location = new System.Drawing.Point(17, 208);
            this.btnRegresar.Name = "btnRegresar";
            this.btnRegresar.Size = new System.Drawing.Size(158, 26);
            this.btnRegresar.TabIndex = 161;
            this.btnRegresar.Text = "Regresar";
            this.btnRegresar.UseVisualStyleBackColor = false;
            this.btnRegresar.Click += new System.EventHandler(this.btnRegresar_Click);
            // 
            // frmEvMisResultados
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoScroll = true;
            this.AutoScrollMargin = new System.Drawing.Size(0, 100);
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(1158, 749);
            this.Controls.Add(this.btnRegresar);
            this.Controls.Add(this.lblFantasma);
            this.Controls.Add(this.lblTituloEvaluacionPotencial);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.txtNotaPotencial);
            this.Controls.Add(this.lblNo);
            this.Controls.Add(this.lblSi);
            this.Controls.Add(this.lblNotaPotenciales);
            this.Controls.Add(this.lblMaxCarPot);
            this.Controls.Add(this.lblDescripcionPotenciales);
            this.Controls.Add(this.lblTituloPotenciales);
            this.Controls.Add(this.txtObservacionesPotencial);
            this.Controls.Add(this.lblObservacionesPotencial);
            this.Controls.Add(this.lblCompetenciasFinal);
            this.Controls.Add(this.lblCompetenciasPrevia);
            this.Controls.Add(this.lblCompetenciasAuto);
            this.Controls.Add(this.lblLogroPrevia);
            this.Controls.Add(this.lblLogroAuto);
            this.Controls.Add(this.lblMaxCarObj);
            this.Controls.Add(this.lblMaxCarComp);
            this.Controls.Add(this.lbl4);
            this.Controls.Add(this.lbl5);
            this.Controls.Add(this.lbl3);
            this.Controls.Add(this.lbl2);
            this.Controls.Add(this.lbl1);
            this.Controls.Add(this.lblLogro);
            this.Controls.Add(this.lblPeso);
            this.Controls.Add(this.lblCantidad);
            this.Controls.Add(this.lblObjetivo);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.lblDescripcionCompetencias);
            this.Controls.Add(this.txtNotaCompetencias);
            this.Controls.Add(this.lblNotaCompetencias);
            this.Controls.Add(this.txtNotaObjetivos);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.lblTituloCompetencias);
            this.Controls.Add(this.label8);
            this.Controls.Add(this.txtObservacionesCompetencias);
            this.Controls.Add(this.lblObservacionesComp);
            this.Controls.Add(this.txtObservacionesObjetivos);
            this.Controls.Add(this.lblObservacionesObj);
            this.Controls.Add(this.txtNotaDesempenho);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.panelDatosColaborador);
            this.Controls.Add(this.btnGenerar);
            this.Controls.Add(this.lblMisObjetivos);
            this.Name = "frmEvMisResultados";
            this.Text = "frmEvMisResultados";
            this.Load += new System.EventHandler(this.frmEvMisResultados_Load);
            this.panelDatosColaborador.ResumeLayout(false);
            this.panelDatosColaborador.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lblMisObjetivos;
        private System.Windows.Forms.Button btnGenerar;
        private System.Windows.Forms.SaveFileDialog sfdReporte;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn1;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn2;
        private System.Windows.Forms.DataGridViewTextBoxColumn peso2;
        private System.Windows.Forms.Panel panelDatosColaborador;
        private System.Windows.Forms.TextBox txtIDColab;
        private System.Windows.Forms.Label lblDatosColaborador;
        private System.Windows.Forms.Label lblIDColab;
        private System.Windows.Forms.Label lblDNI;
        private System.Windows.Forms.Label lblNombre;
        private System.Windows.Forms.TextBox txtGerencia;
        private System.Windows.Forms.TextBox txtNombre;
        private System.Windows.Forms.TextBox txtCargo;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox txtDNI;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox txtNotaDesempenho;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label lblCompetenciasFinal;
        private System.Windows.Forms.Label lblCompetenciasPrevia;
        private System.Windows.Forms.Label lblCompetenciasAuto;
        private System.Windows.Forms.Label lblLogroPrevia;
        private System.Windows.Forms.Label lblLogroAuto;
        private System.Windows.Forms.Label lblMaxCarObj;
        private System.Windows.Forms.Label lblMaxCarComp;
        private System.Windows.Forms.Label lbl4;
        private System.Windows.Forms.Label lbl5;
        private System.Windows.Forms.Label lbl3;
        private System.Windows.Forms.Label lbl2;
        private System.Windows.Forms.Label lbl1;
        private System.Windows.Forms.Label lblLogro;
        private System.Windows.Forms.Label lblPeso;
        private System.Windows.Forms.Label lblCantidad;
        private System.Windows.Forms.Label lblObjetivo;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label lblDescripcionCompetencias;
        private System.Windows.Forms.TextBox txtNotaCompetencias;
        private System.Windows.Forms.Label lblNotaCompetencias;
        private System.Windows.Forms.TextBox txtNotaObjetivos;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label lblTituloCompetencias;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.TextBox txtObservacionesCompetencias;
        private System.Windows.Forms.Label lblObservacionesComp;
        private System.Windows.Forms.TextBox txtObservacionesObjetivos;
        private System.Windows.Forms.Label lblObservacionesObj;
        private System.Windows.Forms.Label lblNo;
        private System.Windows.Forms.Label lblSi;
        private System.Windows.Forms.Label lblNotaPotenciales;
        private System.Windows.Forms.Label lblMaxCarPot;
        private System.Windows.Forms.Label lblDescripcionPotenciales;
        private System.Windows.Forms.Label lblTituloPotenciales;
        private System.Windows.Forms.TextBox txtObservacionesPotencial;
        private System.Windows.Forms.Label lblObservacionesPotencial;
        private System.Windows.Forms.TextBox txtNotaPotencial;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label lblTituloEvaluacionPotencial;
        private System.Windows.Forms.Label lblFantasma;
        private System.Windows.Forms.Button btnRegresar;
    }
}