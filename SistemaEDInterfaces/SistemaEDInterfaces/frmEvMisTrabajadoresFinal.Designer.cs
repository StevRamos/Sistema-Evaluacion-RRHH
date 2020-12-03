namespace SistemaEDInterfaces
{
    partial class frmEvMisTrabajadoresFinal
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
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle1 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle2 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle3 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle4 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle5 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle6 = new System.Windows.Forms.DataGridViewCellStyle();
            this.btnRegresar = new System.Windows.Forms.Button();
            this.btnGuardar = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.lblMisObjetivos = new System.Windows.Forms.Label();
            this.btnSeleccionar = new System.Windows.Forms.Button();
            this.label2 = new System.Windows.Forms.Label();
            this.dgvCompetencias = new System.Windows.Forms.DataGridView();
            this.btnFinalizar = new System.Windows.Forms.Button();
            this.dgvObjetivos = new System.Windows.Forms.DataGridView();
            this.txtObservacionesObjetivos = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.txtObservacionesCompetencias = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.txtNotaDesempenho = new System.Windows.Forms.TextBox();
            this.txtNotaObjetivos = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.txtNotaCompetencias = new System.Windows.Forms.TextBox();
            this.label7 = new System.Windows.Forms.Label();
            this.btnEditar = new System.Windows.Forms.Button();
            this.ID = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.nombre = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.DescripcionComp = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.PesoComp = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.nota2 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.notaP2 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.notaF2 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.numero = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.meta = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Cantidad = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.descripcion = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.peso = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.notaAutoeval = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.notaPrev = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.notaFinal = new System.Windows.Forms.DataGridViewTextBoxColumn();
            ((System.ComponentModel.ISupportInitialize)(this.dgvCompetencias)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgvObjetivos)).BeginInit();
            this.SuspendLayout();
            // 
            // btnRegresar
            // 
            this.btnRegresar.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(157)))), ((int)(((byte)(6)))), ((int)(((byte)(32)))));
            this.btnRegresar.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnRegresar.Font = new System.Drawing.Font("Century Gothic", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnRegresar.ForeColor = System.Drawing.Color.White;
            this.btnRegresar.Location = new System.Drawing.Point(22, 1241);
            this.btnRegresar.Name = "btnRegresar";
            this.btnRegresar.Size = new System.Drawing.Size(158, 26);
            this.btnRegresar.TabIndex = 28;
            this.btnRegresar.Text = "Regresar";
            this.btnRegresar.UseVisualStyleBackColor = false;
            this.btnRegresar.Click += new System.EventHandler(this.btnRegresar_Click);
            // 
            // btnGuardar
            // 
            this.btnGuardar.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(157)))), ((int)(((byte)(6)))), ((int)(((byte)(32)))));
            this.btnGuardar.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnGuardar.Font = new System.Drawing.Font("Century Gothic", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnGuardar.ForeColor = System.Drawing.Color.White;
            this.btnGuardar.Location = new System.Drawing.Point(918, 1241);
            this.btnGuardar.Name = "btnGuardar";
            this.btnGuardar.Size = new System.Drawing.Size(158, 26);
            this.btnGuardar.TabIndex = 27;
            this.btnGuardar.Text = "Guardar";
            this.btnGuardar.UseVisualStyleBackColor = false;
            this.btnGuardar.Click += new System.EventHandler(this.btnGuardar_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(20, 131);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(88, 24);
            this.label1.TabIndex = 26;
            this.label1.Text = "Objetivos";
            // 
            // lblMisObjetivos
            // 
            this.lblMisObjetivos.AutoSize = true;
            this.lblMisObjetivos.Font = new System.Drawing.Font("Century Gothic", 36F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblMisObjetivos.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(66)))), ((int)(((byte)(122)))));
            this.lblMisObjetivos.Location = new System.Drawing.Point(12, 9);
            this.lblMisObjetivos.Name = "lblMisObjetivos";
            this.lblMisObjetivos.Size = new System.Drawing.Size(779, 56);
            this.lblMisObjetivos.TabIndex = 25;
            this.lblMisObjetivos.Text = "Evaluación Final de Desempeño";
            // 
            // btnSeleccionar
            // 
            this.btnSeleccionar.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(157)))), ((int)(((byte)(6)))), ((int)(((byte)(32)))));
            this.btnSeleccionar.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnSeleccionar.Font = new System.Drawing.Font("Century Gothic", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnSeleccionar.ForeColor = System.Drawing.Color.White;
            this.btnSeleccionar.Location = new System.Drawing.Point(920, 1020);
            this.btnSeleccionar.Name = "btnSeleccionar";
            this.btnSeleccionar.Size = new System.Drawing.Size(158, 26);
            this.btnSeleccionar.TabIndex = 31;
            this.btnSeleccionar.Text = "Seleccionar";
            this.btnSeleccionar.UseVisualStyleBackColor = false;
            this.btnSeleccionar.Click += new System.EventHandler(this.btnSeleccionar_Click);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(25, 702);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(131, 24);
            this.label2.TabIndex = 30;
            this.label2.Text = "Competencias";
            // 
            // dgvCompetencias
            // 
            this.dgvCompetencias.AllowUserToAddRows = false;
            this.dgvCompetencias.AllowUserToDeleteRows = false;
            this.dgvCompetencias.AllowUserToResizeColumns = false;
            this.dgvCompetencias.AllowUserToResizeRows = false;
            this.dgvCompetencias.AutoSizeRowsMode = System.Windows.Forms.DataGridViewAutoSizeRowsMode.AllCells;
            this.dgvCompetencias.BackgroundColor = System.Drawing.Color.White;
            this.dgvCompetencias.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.dgvCompetencias.ColumnHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.None;
            dataGridViewCellStyle1.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(66)))), ((int)(((byte)(122)))));
            dataGridViewCellStyle1.Font = new System.Drawing.Font("Century Gothic", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle1.ForeColor = System.Drawing.Color.White;
            dataGridViewCellStyle1.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle1.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle1.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dgvCompetencias.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle1;
            this.dgvCompetencias.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvCompetencias.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.ID,
            this.nombre,
            this.DescripcionComp,
            this.PesoComp,
            this.nota2,
            this.notaP2,
            this.notaF2});
            this.dgvCompetencias.EnableHeadersVisualStyles = false;
            this.dgvCompetencias.Location = new System.Drawing.Point(22, 756);
            this.dgvCompetencias.Name = "dgvCompetencias";
            this.dgvCompetencias.ReadOnly = true;
            dataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle2.BackColor = System.Drawing.Color.White;
            dataGridViewCellStyle2.Font = new System.Drawing.Font("Century Gothic", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle2.ForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle2.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle2.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle2.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dgvCompetencias.RowHeadersDefaultCellStyle = dataGridViewCellStyle2;
            this.dgvCompetencias.RowHeadersVisible = false;
            dataGridViewCellStyle3.BackColor = System.Drawing.Color.White;
            dataGridViewCellStyle3.ForeColor = System.Drawing.Color.Black;
            dataGridViewCellStyle3.SelectionBackColor = System.Drawing.Color.LightGray;
            dataGridViewCellStyle3.SelectionForeColor = System.Drawing.Color.Black;
            this.dgvCompetencias.RowsDefaultCellStyle = dataGridViewCellStyle3;
            this.dgvCompetencias.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dgvCompetencias.Size = new System.Drawing.Size(1054, 244);
            this.dgvCompetencias.TabIndex = 32;
            this.dgvCompetencias.CellFormatting += new System.Windows.Forms.DataGridViewCellFormattingEventHandler(this.dgvCompetencias_CellFormatting);
            // 
            // btnFinalizar
            // 
            this.btnFinalizar.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(157)))), ((int)(((byte)(6)))), ((int)(((byte)(32)))));
            this.btnFinalizar.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnFinalizar.Font = new System.Drawing.Font("Century Gothic", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnFinalizar.ForeColor = System.Drawing.Color.White;
            this.btnFinalizar.Location = new System.Drawing.Point(918, 1289);
            this.btnFinalizar.Name = "btnFinalizar";
            this.btnFinalizar.Size = new System.Drawing.Size(158, 26);
            this.btnFinalizar.TabIndex = 34;
            this.btnFinalizar.Text = "Finalizar";
            this.btnFinalizar.UseVisualStyleBackColor = false;
            this.btnFinalizar.Click += new System.EventHandler(this.btnFinalizar_Click);
            // 
            // dgvObjetivos
            // 
            this.dgvObjetivos.AllowUserToAddRows = false;
            this.dgvObjetivos.AllowUserToDeleteRows = false;
            this.dgvObjetivos.AllowUserToResizeColumns = false;
            this.dgvObjetivos.AllowUserToResizeRows = false;
            this.dgvObjetivos.AutoSizeRowsMode = System.Windows.Forms.DataGridViewAutoSizeRowsMode.AllCells;
            this.dgvObjetivos.BackgroundColor = System.Drawing.Color.White;
            this.dgvObjetivos.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.dgvObjetivos.ColumnHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.None;
            dataGridViewCellStyle4.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle4.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(66)))), ((int)(((byte)(122)))));
            dataGridViewCellStyle4.Font = new System.Drawing.Font("Century Gothic", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle4.ForeColor = System.Drawing.Color.White;
            dataGridViewCellStyle4.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle4.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle4.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dgvObjetivos.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle4;
            this.dgvObjetivos.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvObjetivos.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.numero,
            this.meta,
            this.Cantidad,
            this.descripcion,
            this.peso,
            this.notaAutoeval,
            this.notaPrev,
            this.notaFinal});
            this.dgvObjetivos.EnableHeadersVisualStyles = false;
            this.dgvObjetivos.Location = new System.Drawing.Point(22, 169);
            this.dgvObjetivos.Name = "dgvObjetivos";
            dataGridViewCellStyle5.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle5.BackColor = System.Drawing.Color.White;
            dataGridViewCellStyle5.Font = new System.Drawing.Font("Century Gothic", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle5.ForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle5.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle5.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle5.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dgvObjetivos.RowHeadersDefaultCellStyle = dataGridViewCellStyle5;
            this.dgvObjetivos.RowHeadersVisible = false;
            dataGridViewCellStyle6.BackColor = System.Drawing.Color.White;
            dataGridViewCellStyle6.ForeColor = System.Drawing.Color.Black;
            dataGridViewCellStyle6.SelectionBackColor = System.Drawing.Color.LightGray;
            dataGridViewCellStyle6.SelectionForeColor = System.Drawing.Color.Black;
            this.dgvObjetivos.RowsDefaultCellStyle = dataGridViewCellStyle6;
            this.dgvObjetivos.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dgvObjetivos.Size = new System.Drawing.Size(1054, 347);
            this.dgvObjetivos.TabIndex = 35;
            // 
            // txtObservacionesObjetivos
            // 
            this.txtObservacionesObjetivos.Enabled = false;
            this.txtObservacionesObjetivos.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F);
            this.txtObservacionesObjetivos.Location = new System.Drawing.Point(222, 555);
            this.txtObservacionesObjetivos.Multiline = true;
            this.txtObservacionesObjetivos.Name = "txtObservacionesObjetivos";
            this.txtObservacionesObjetivos.Size = new System.Drawing.Size(711, 84);
            this.txtObservacionesObjetivos.TabIndex = 37;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(20, 555);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(142, 24);
            this.label3.TabIndex = 36;
            this.label3.Text = "Observaciones:";
            // 
            // txtObservacionesCompetencias
            // 
            this.txtObservacionesCompetencias.Enabled = false;
            this.txtObservacionesCompetencias.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F);
            this.txtObservacionesCompetencias.Location = new System.Drawing.Point(224, 1090);
            this.txtObservacionesCompetencias.Multiline = true;
            this.txtObservacionesCompetencias.Name = "txtObservacionesCompetencias";
            this.txtObservacionesCompetencias.Size = new System.Drawing.Size(711, 84);
            this.txtObservacionesCompetencias.TabIndex = 39;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(25, 1090);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(142, 24);
            this.label4.TabIndex = 38;
            this.label4.Text = "Observaciones:";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.Location = new System.Drawing.Point(640, 70);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(299, 25);
            this.label6.TabIndex = 40;
            this.label6.Text = "Calificación de Desempeño";
            this.label6.Click += new System.EventHandler(this.label6_Click);
            // 
            // txtNotaDesempenho
            // 
            this.txtNotaDesempenho.Enabled = false;
            this.txtNotaDesempenho.Location = new System.Drawing.Point(967, 75);
            this.txtNotaDesempenho.Name = "txtNotaDesempenho";
            this.txtNotaDesempenho.Size = new System.Drawing.Size(109, 20);
            this.txtNotaDesempenho.TabIndex = 41;
            // 
            // txtNotaObjetivos
            // 
            this.txtNotaObjetivos.Enabled = false;
            this.txtNotaObjetivos.Location = new System.Drawing.Point(967, 131);
            this.txtNotaObjetivos.Name = "txtNotaObjetivos";
            this.txtNotaObjetivos.Size = new System.Drawing.Size(109, 20);
            this.txtNotaObjetivos.TabIndex = 43;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.Location = new System.Drawing.Point(616, 126);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(323, 25);
            this.label5.TabIndex = 42;
            this.label5.Text = "Nota Evaluacion de Objetivos";
            // 
            // txtNotaCompetencias
            // 
            this.txtNotaCompetencias.Enabled = false;
            this.txtNotaCompetencias.Location = new System.Drawing.Point(967, 713);
            this.txtNotaCompetencias.Name = "txtNotaCompetencias";
            this.txtNotaCompetencias.Size = new System.Drawing.Size(109, 20);
            this.txtNotaCompetencias.TabIndex = 45;
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label7.Location = new System.Drawing.Point(566, 708);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(373, 25);
            this.label7.TabIndex = 44;
            this.label7.Text = "Nota Evaluacion de Competencias";
            // 
            // btnEditar
            // 
            this.btnEditar.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(157)))), ((int)(((byte)(6)))), ((int)(((byte)(32)))));
            this.btnEditar.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnEditar.Font = new System.Drawing.Font("Century Gothic", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnEditar.ForeColor = System.Drawing.Color.White;
            this.btnEditar.Location = new System.Drawing.Point(732, 1241);
            this.btnEditar.Name = "btnEditar";
            this.btnEditar.Size = new System.Drawing.Size(158, 26);
            this.btnEditar.TabIndex = 46;
            this.btnEditar.Text = "Editar";
            this.btnEditar.UseVisualStyleBackColor = false;
            this.btnEditar.Click += new System.EventHandler(this.btnEditar_Click);
            // 
            // ID
            // 
            this.ID.HeaderText = "Número";
            this.ID.Name = "ID";
            this.ID.ReadOnly = true;
            this.ID.Resizable = System.Windows.Forms.DataGridViewTriState.True;
            this.ID.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.Programmatic;
            this.ID.Width = 70;
            // 
            // nombre
            // 
            this.nombre.HeaderText = "Nombre";
            this.nombre.Name = "nombre";
            this.nombre.ReadOnly = true;
            this.nombre.Width = 300;
            // 
            // DescripcionComp
            // 
            this.DescripcionComp.HeaderText = "Descripción";
            this.DescripcionComp.Name = "DescripcionComp";
            this.DescripcionComp.ReadOnly = true;
            this.DescripcionComp.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.Programmatic;
            this.DescripcionComp.Width = 500;
            // 
            // PesoComp
            // 
            this.PesoComp.HeaderText = "Peso";
            this.PesoComp.Name = "PesoComp";
            this.PesoComp.ReadOnly = true;
            // 
            // nota2
            // 
            this.nota2.DataPropertyName = "notaAutoEval";
            this.nota2.HeaderText = "Nota Autoevaluación";
            this.nota2.Name = "nota2";
            this.nota2.ReadOnly = true;
            this.nota2.Width = 150;
            // 
            // notaP2
            // 
            this.notaP2.DataPropertyName = "notaPrevia";
            this.notaP2.HeaderText = "Nota Previa";
            this.notaP2.Name = "notaP2";
            this.notaP2.ReadOnly = true;
            this.notaP2.Width = 150;
            // 
            // notaF2
            // 
            this.notaF2.DataPropertyName = "notaFinal";
            this.notaF2.HeaderText = "Nota Final";
            this.notaF2.Name = "notaF2";
            this.notaF2.ReadOnly = true;
            this.notaF2.Width = 150;
            // 
            // numero
            // 
            this.numero.DataPropertyName = "idObjetivo";
            this.numero.HeaderText = "ID";
            this.numero.Name = "numero";
            this.numero.ReadOnly = true;
            this.numero.Resizable = System.Windows.Forms.DataGridViewTriState.True;
            this.numero.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.Programmatic;
            this.numero.Width = 70;
            // 
            // meta
            // 
            this.meta.DataPropertyName = "unidadMedida";
            this.meta.HeaderText = "Meta";
            this.meta.Name = "meta";
            this.meta.ReadOnly = true;
            this.meta.Width = 200;
            // 
            // Cantidad
            // 
            this.Cantidad.DataPropertyName = "meta";
            this.Cantidad.HeaderText = "Cantidad";
            this.Cantidad.Name = "Cantidad";
            this.Cantidad.ReadOnly = true;
            // 
            // descripcion
            // 
            this.descripcion.DataPropertyName = "descripcion";
            this.descripcion.HeaderText = "Descripción";
            this.descripcion.Name = "descripcion";
            this.descripcion.ReadOnly = true;
            this.descripcion.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.Programmatic;
            this.descripcion.Width = 500;
            // 
            // peso
            // 
            this.peso.DataPropertyName = "peso";
            this.peso.HeaderText = "Peso";
            this.peso.Name = "peso";
            this.peso.ReadOnly = true;
            this.peso.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.Programmatic;
            // 
            // notaAutoeval
            // 
            this.notaAutoeval.DataPropertyName = "notaAutoEval";
            this.notaAutoeval.HeaderText = "Nota AutoEvaluación";
            this.notaAutoeval.Name = "notaAutoeval";
            this.notaAutoeval.ReadOnly = true;
            this.notaAutoeval.Width = 150;
            // 
            // notaPrev
            // 
            this.notaPrev.DataPropertyName = "notaPrevia";
            this.notaPrev.HeaderText = "Nota Previa";
            this.notaPrev.Name = "notaPrev";
            this.notaPrev.ReadOnly = true;
            // 
            // notaFinal
            // 
            this.notaFinal.DataPropertyName = "notaFinal";
            this.notaFinal.HeaderText = "Nota Final";
            this.notaFinal.Name = "notaFinal";
            // 
            // frmEvMisTrabajadoresFinal
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoScroll = true;
            this.AutoScrollMargin = new System.Drawing.Size(0, 150);
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(1107, 749);
            this.Controls.Add(this.btnEditar);
            this.Controls.Add(this.txtNotaCompetencias);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.txtNotaObjetivos);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.txtNotaDesempenho);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.txtObservacionesCompetencias);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.txtObservacionesObjetivos);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.dgvObjetivos);
            this.Controls.Add(this.btnFinalizar);
            this.Controls.Add(this.dgvCompetencias);
            this.Controls.Add(this.btnSeleccionar);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.btnRegresar);
            this.Controls.Add(this.btnGuardar);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.lblMisObjetivos);
            this.Name = "frmEvMisTrabajadoresFinal";
            this.Text = "frmEvMisTrabajadoresFinal";
            this.Load += new System.EventHandler(this.frmEvMisTrabajadoresFinal_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dgvCompetencias)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgvObjetivos)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Button btnRegresar;
        private System.Windows.Forms.Button btnGuardar;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label lblMisObjetivos;
        private System.Windows.Forms.Button btnSeleccionar;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.DataGridView dgvCompetencias;
        private System.Windows.Forms.Button btnFinalizar;
        private System.Windows.Forms.DataGridView dgvObjetivos;
        private System.Windows.Forms.TextBox txtObservacionesObjetivos;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox txtObservacionesCompetencias;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.TextBox txtNotaDesempenho;
        private System.Windows.Forms.TextBox txtNotaObjetivos;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.TextBox txtNotaCompetencias;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Button btnEditar;
        private System.Windows.Forms.DataGridViewTextBoxColumn ID;
        private System.Windows.Forms.DataGridViewTextBoxColumn nombre;
        private System.Windows.Forms.DataGridViewTextBoxColumn DescripcionComp;
        private System.Windows.Forms.DataGridViewTextBoxColumn PesoComp;
        private System.Windows.Forms.DataGridViewTextBoxColumn nota2;
        private System.Windows.Forms.DataGridViewTextBoxColumn notaP2;
        private System.Windows.Forms.DataGridViewTextBoxColumn notaF2;
        private System.Windows.Forms.DataGridViewTextBoxColumn numero;
        private System.Windows.Forms.DataGridViewTextBoxColumn meta;
        private System.Windows.Forms.DataGridViewTextBoxColumn Cantidad;
        private System.Windows.Forms.DataGridViewTextBoxColumn descripcion;
        private System.Windows.Forms.DataGridViewTextBoxColumn peso;
        private System.Windows.Forms.DataGridViewTextBoxColumn notaAutoeval;
        private System.Windows.Forms.DataGridViewTextBoxColumn notaPrev;
        private System.Windows.Forms.DataGridViewTextBoxColumn notaFinal;
    }
}