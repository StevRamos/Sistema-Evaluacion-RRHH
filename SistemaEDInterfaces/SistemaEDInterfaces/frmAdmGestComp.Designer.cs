namespace SistemaEDInterfaces
{
    partial class frmAdmGestComp
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
            this.label3 = new System.Windows.Forms.Label();
            this.txtBuscarPerioCom = new System.Windows.Forms.Label();
            this.cmbCargos = new System.Windows.Forms.ComboBox();
            this.cmbPeriodos = new System.Windows.Forms.ComboBox();
            this.dgvCompetencias = new System.Windows.Forms.DataGridView();
            this.idCriterio = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.nombreCriterio = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.descripcion = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Cargo = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.peso = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.periodo = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.label2 = new System.Windows.Forms.Label();
            this.btnCargarMasivaCom = new System.Windows.Forms.Button();
            this.btnCrearCompetencia = new System.Windows.Forms.Button();
            this.txtComp = new System.Windows.Forms.TextBox();
            this.lblBuscarNomCom = new System.Windows.Forms.Label();
            this.btnEliminar = new System.Windows.Forms.Button();
            this.btnBuscar = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.dgvCompetencias)).BeginInit();
            this.SuspendLayout();
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Century Gothic", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(531, 106);
            this.label3.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(58, 17);
            this.label3.TabIndex = 45;
            this.label3.Text = "Cargo :";
            // 
            // txtBuscarPerioCom
            // 
            this.txtBuscarPerioCom.AutoSize = true;
            this.txtBuscarPerioCom.Font = new System.Drawing.Font("Century Gothic", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtBuscarPerioCom.Location = new System.Drawing.Point(727, 106);
            this.txtBuscarPerioCom.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.txtBuscarPerioCom.Name = "txtBuscarPerioCom";
            this.txtBuscarPerioCom.Size = new System.Drawing.Size(68, 17);
            this.txtBuscarPerioCom.TabIndex = 44;
            this.txtBuscarPerioCom.Text = "Periodo :";
            // 
            // cmbCargos
            // 
            this.cmbCargos.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cmbCargos.FormattingEnabled = true;
            this.cmbCargos.Location = new System.Drawing.Point(534, 132);
            this.cmbCargos.Name = "cmbCargos";
            this.cmbCargos.Size = new System.Drawing.Size(157, 21);
            this.cmbCargos.TabIndex = 43;
            // 
            // cmbPeriodos
            // 
            this.cmbPeriodos.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cmbPeriodos.FormattingEnabled = true;
            this.cmbPeriodos.Location = new System.Drawing.Point(730, 132);
            this.cmbPeriodos.Name = "cmbPeriodos";
            this.cmbPeriodos.Size = new System.Drawing.Size(165, 21);
            this.cmbPeriodos.TabIndex = 42;
            // 
            // dgvCompetencias
            // 
            this.dgvCompetencias.AllowUserToAddRows = false;
            this.dgvCompetencias.AllowUserToDeleteRows = false;
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
            this.idCriterio,
            this.nombreCriterio,
            this.descripcion,
            this.Cargo,
            this.peso,
            this.periodo});
            this.dgvCompetencias.EnableHeadersVisualStyles = false;
            this.dgvCompetencias.Location = new System.Drawing.Point(19, 210);
            this.dgvCompetencias.MultiSelect = false;
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
            this.dgvCompetencias.RowHeadersWidth = 51;
            dataGridViewCellStyle3.BackColor = System.Drawing.Color.White;
            dataGridViewCellStyle3.Font = new System.Drawing.Font("Century Gothic", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle3.SelectionBackColor = System.Drawing.Color.LightGray;
            dataGridViewCellStyle3.SelectionForeColor = System.Drawing.Color.Black;
            this.dgvCompetencias.RowsDefaultCellStyle = dataGridViewCellStyle3;
            this.dgvCompetencias.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dgvCompetencias.Size = new System.Drawing.Size(1073, 363);
            this.dgvCompetencias.TabIndex = 41;
            this.dgvCompetencias.CellFormatting += new System.Windows.Forms.DataGridViewCellFormattingEventHandler(this.dgvCompetencias_CellFormatting);
            // 
            // idCriterio
            // 
            this.idCriterio.HeaderText = "Id";
            this.idCriterio.MinimumWidth = 6;
            this.idCriterio.Name = "idCriterio";
            this.idCriterio.ReadOnly = true;
            this.idCriterio.Width = 50;
            // 
            // nombreCriterio
            // 
            this.nombreCriterio.HeaderText = "Nombre";
            this.nombreCriterio.MinimumWidth = 6;
            this.nombreCriterio.Name = "nombreCriterio";
            this.nombreCriterio.ReadOnly = true;
            this.nombreCriterio.Width = 300;
            // 
            // descripcion
            // 
            this.descripcion.HeaderText = "Descripción";
            this.descripcion.MinimumWidth = 6;
            this.descripcion.Name = "descripcion";
            this.descripcion.ReadOnly = true;
            this.descripcion.Width = 500;
            // 
            // Cargo
            // 
            this.Cargo.HeaderText = "Cargo";
            this.Cargo.MinimumWidth = 6;
            this.Cargo.Name = "Cargo";
            this.Cargo.ReadOnly = true;
            this.Cargo.Width = 200;
            // 
            // peso
            // 
            this.peso.DataPropertyName = "peso";
            this.peso.HeaderText = "Peso";
            this.peso.MinimumWidth = 6;
            this.peso.Name = "peso";
            this.peso.ReadOnly = true;
            this.peso.Width = 125;
            // 
            // periodo
            // 
            this.periodo.HeaderText = "Periodo";
            this.periodo.MinimumWidth = 6;
            this.periodo.Name = "periodo";
            this.periodo.ReadOnly = true;
            this.periodo.Width = 125;
            // 
            // label2
            // 
            this.label2.Font = new System.Drawing.Font("Century Gothic", 36F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(66)))), ((int)(((byte)(122)))));
            this.label2.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.label2.Location = new System.Drawing.Point(9, 7);
            this.label2.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(627, 79);
            this.label2.TabIndex = 40;
            this.label2.Text = "Gestionar Competencias";
            this.label2.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // btnCargarMasivaCom
            // 
            this.btnCargarMasivaCom.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(157)))), ((int)(((byte)(6)))), ((int)(((byte)(32)))));
            this.btnCargarMasivaCom.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnCargarMasivaCom.Font = new System.Drawing.Font("Century Gothic", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnCargarMasivaCom.ForeColor = System.Drawing.Color.White;
            this.btnCargarMasivaCom.Location = new System.Drawing.Point(280, 128);
            this.btnCargarMasivaCom.Margin = new System.Windows.Forms.Padding(2);
            this.btnCargarMasivaCom.Name = "btnCargarMasivaCom";
            this.btnCargarMasivaCom.Size = new System.Drawing.Size(188, 26);
            this.btnCargarMasivaCom.TabIndex = 39;
            this.btnCargarMasivaCom.Text = " Cargar Masivamente";
            this.btnCargarMasivaCom.UseVisualStyleBackColor = false;
            this.btnCargarMasivaCom.Click += new System.EventHandler(this.btnCargarMasivaCom_Click_1);
            // 
            // btnCrearCompetencia
            // 
            this.btnCrearCompetencia.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(157)))), ((int)(((byte)(6)))), ((int)(((byte)(32)))));
            this.btnCrearCompetencia.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnCrearCompetencia.Font = new System.Drawing.Font("Century Gothic", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnCrearCompetencia.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.btnCrearCompetencia.Location = new System.Drawing.Point(19, 127);
            this.btnCrearCompetencia.Margin = new System.Windows.Forms.Padding(2);
            this.btnCrearCompetencia.Name = "btnCrearCompetencia";
            this.btnCrearCompetencia.Size = new System.Drawing.Size(188, 26);
            this.btnCrearCompetencia.TabIndex = 38;
            this.btnCrearCompetencia.Text = " Crear Competencia +";
            this.btnCrearCompetencia.UseVisualStyleBackColor = false;
            this.btnCrearCompetencia.Click += new System.EventHandler(this.btnCrearCompetencia_Click_1);
            // 
            // txtComp
            // 
            this.txtComp.Location = new System.Drawing.Point(936, 134);
            this.txtComp.Margin = new System.Windows.Forms.Padding(2);
            this.txtComp.Name = "txtComp";
            this.txtComp.Size = new System.Drawing.Size(150, 20);
            this.txtComp.TabIndex = 47;
            // 
            // lblBuscarNomCom
            // 
            this.lblBuscarNomCom.AutoSize = true;
            this.lblBuscarNomCom.Font = new System.Drawing.Font("Century Gothic", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblBuscarNomCom.Location = new System.Drawing.Point(933, 106);
            this.lblBuscarNomCom.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lblBuscarNomCom.Name = "lblBuscarNomCom";
            this.lblBuscarNomCom.Size = new System.Drawing.Size(170, 17);
            this.lblBuscarNomCom.TabIndex = 46;
            this.lblBuscarNomCom.Text = "Nombre Competencia :";
            // 
            // btnEliminar
            // 
            this.btnEliminar.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(157)))), ((int)(((byte)(6)))), ((int)(((byte)(32)))));
            this.btnEliminar.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnEliminar.Font = new System.Drawing.Font("Century Gothic", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnEliminar.ForeColor = System.Drawing.Color.White;
            this.btnEliminar.Location = new System.Drawing.Point(19, 590);
            this.btnEliminar.Margin = new System.Windows.Forms.Padding(2);
            this.btnEliminar.Name = "btnEliminar";
            this.btnEliminar.Size = new System.Drawing.Size(188, 26);
            this.btnEliminar.TabIndex = 48;
            this.btnEliminar.Text = "Eliminar";
            this.btnEliminar.UseVisualStyleBackColor = false;
            this.btnEliminar.Click += new System.EventHandler(this.btnEliminar_Click);
            // 
            // btnBuscar
            // 
            this.btnBuscar.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(157)))), ((int)(((byte)(6)))), ((int)(((byte)(32)))));
            this.btnBuscar.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnBuscar.Font = new System.Drawing.Font("Century Gothic", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnBuscar.ForeColor = System.Drawing.Color.White;
            this.btnBuscar.Location = new System.Drawing.Point(936, 167);
            this.btnBuscar.Margin = new System.Windows.Forms.Padding(2);
            this.btnBuscar.Name = "btnBuscar";
            this.btnBuscar.Size = new System.Drawing.Size(150, 26);
            this.btnBuscar.TabIndex = 49;
            this.btnBuscar.Text = "Buscar";
            this.btnBuscar.UseVisualStyleBackColor = false;
            this.btnBuscar.Click += new System.EventHandler(this.btnBuscar_Click);
            // 
            // frmAdmGestComp
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(1107, 749);
            this.Controls.Add(this.btnBuscar);
            this.Controls.Add(this.btnEliminar);
            this.Controls.Add(this.txtComp);
            this.Controls.Add(this.lblBuscarNomCom);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.txtBuscarPerioCom);
            this.Controls.Add(this.cmbCargos);
            this.Controls.Add(this.cmbPeriodos);
            this.Controls.Add(this.dgvCompetencias);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.btnCargarMasivaCom);
            this.Controls.Add(this.btnCrearCompetencia);
            this.Name = "frmAdmGestComp";
            this.Text = "frmAdmGestComp";
            ((System.ComponentModel.ISupportInitialize)(this.dgvCompetencias)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label txtBuscarPerioCom;
        private System.Windows.Forms.ComboBox cmbCargos;
        private System.Windows.Forms.ComboBox cmbPeriodos;
        private System.Windows.Forms.DataGridView dgvCompetencias;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Button btnCargarMasivaCom;
        private System.Windows.Forms.Button btnCrearCompetencia;
        private System.Windows.Forms.TextBox txtComp;
        private System.Windows.Forms.Label lblBuscarNomCom;
        private System.Windows.Forms.Button btnEliminar;
        private System.Windows.Forms.Button btnBuscar;
        private System.Windows.Forms.DataGridViewTextBoxColumn idCriterio;
        private System.Windows.Forms.DataGridViewTextBoxColumn nombreCriterio;
        private System.Windows.Forms.DataGridViewTextBoxColumn descripcion;
        private System.Windows.Forms.DataGridViewTextBoxColumn Cargo;
        private System.Windows.Forms.DataGridViewTextBoxColumn peso;
        private System.Windows.Forms.DataGridViewTextBoxColumn periodo;
    }
}