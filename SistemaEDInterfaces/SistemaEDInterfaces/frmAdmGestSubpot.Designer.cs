namespace SistemaEDInterfaces
{
    partial class frmAdmGestSubpot
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
            this.label1 = new System.Windows.Forms.Label();
            this.txtBuscarPerioCom = new System.Windows.Forms.Label();
            this.lblBuscarNomPot = new System.Windows.Forms.Label();
            this.cmbPuestos = new System.Windows.Forms.ComboBox();
            this.cmbPeriodos = new System.Windows.Forms.ComboBox();
            this.txtGestNombrePot = new System.Windows.Forms.TextBox();
            this.dgvGestCompetencias = new System.Windows.Forms.DataGridView();
            this.Cod_Subcompetencia = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Código = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Nombre = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Descripción = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Cargo = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Peso = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Periodo = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.lblGestionarComp = new System.Windows.Forms.Label();
            this.btnCargarMasivaSubPot = new System.Windows.Forms.Button();
            this.btnCrearCompetencia = new System.Windows.Forms.Button();
            this.button1 = new System.Windows.Forms.Button();
            this.button2 = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.dgvGestCompetencias)).BeginInit();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Century Gothic", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.Black;
            this.label1.Location = new System.Drawing.Point(532, 103);
            this.label1.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(58, 17);
            this.label1.TabIndex = 48;
            this.label1.Text = "Cargo :";
            // 
            // txtBuscarPerioCom
            // 
            this.txtBuscarPerioCom.AutoSize = true;
            this.txtBuscarPerioCom.Font = new System.Drawing.Font("Century Gothic", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtBuscarPerioCom.ForeColor = System.Drawing.Color.Black;
            this.txtBuscarPerioCom.Location = new System.Drawing.Point(728, 103);
            this.txtBuscarPerioCom.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.txtBuscarPerioCom.Name = "txtBuscarPerioCom";
            this.txtBuscarPerioCom.Size = new System.Drawing.Size(68, 17);
            this.txtBuscarPerioCom.TabIndex = 47;
            this.txtBuscarPerioCom.Text = "Periodo :";
            // 
            // lblBuscarNomPot
            // 
            this.lblBuscarNomPot.AutoSize = true;
            this.lblBuscarNomPot.Font = new System.Drawing.Font("Century Gothic", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblBuscarNomPot.ForeColor = System.Drawing.Color.Black;
            this.lblBuscarNomPot.Location = new System.Drawing.Point(921, 103);
            this.lblBuscarNomPot.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lblBuscarNomPot.Name = "lblBuscarNomPot";
            this.lblBuscarNomPot.Size = new System.Drawing.Size(164, 17);
            this.lblBuscarNomPot.TabIndex = 46;
            this.lblBuscarNomPot.Text = "Nombre Subpotencial :";
            // 
            // cmbPuestos
            // 
            this.cmbPuestos.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cmbPuestos.FormattingEnabled = true;
            this.cmbPuestos.Location = new System.Drawing.Point(535, 134);
            this.cmbPuestos.Name = "cmbPuestos";
            this.cmbPuestos.Size = new System.Drawing.Size(157, 21);
            this.cmbPuestos.TabIndex = 45;
            // 
            // cmbPeriodos
            // 
            this.cmbPeriodos.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cmbPeriodos.FormattingEnabled = true;
            this.cmbPeriodos.Location = new System.Drawing.Point(731, 134);
            this.cmbPeriodos.Name = "cmbPeriodos";
            this.cmbPeriodos.Size = new System.Drawing.Size(165, 21);
            this.cmbPeriodos.TabIndex = 44;
            // 
            // txtGestNombrePot
            // 
            this.txtGestNombrePot.Location = new System.Drawing.Point(924, 135);
            this.txtGestNombrePot.Margin = new System.Windows.Forms.Padding(2);
            this.txtGestNombrePot.Name = "txtGestNombrePot";
            this.txtGestNombrePot.Size = new System.Drawing.Size(151, 20);
            this.txtGestNombrePot.TabIndex = 43;
            // 
            // dgvGestCompetencias
            // 
            this.dgvGestCompetencias.AllowUserToAddRows = false;
            this.dgvGestCompetencias.AllowUserToDeleteRows = false;
            this.dgvGestCompetencias.AllowUserToResizeRows = false;
            this.dgvGestCompetencias.AutoSizeRowsMode = System.Windows.Forms.DataGridViewAutoSizeRowsMode.AllCells;
            this.dgvGestCompetencias.BackgroundColor = System.Drawing.Color.White;
            this.dgvGestCompetencias.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.dgvGestCompetencias.ColumnHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.None;
            dataGridViewCellStyle1.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(66)))), ((int)(((byte)(122)))));
            dataGridViewCellStyle1.Font = new System.Drawing.Font("Century Gothic", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle1.ForeColor = System.Drawing.Color.White;
            dataGridViewCellStyle1.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle1.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle1.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dgvGestCompetencias.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle1;
            this.dgvGestCompetencias.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvGestCompetencias.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.Cod_Subcompetencia,
            this.Código,
            this.Nombre,
            this.Descripción,
            this.Cargo,
            this.Peso,
            this.Periodo});
            this.dgvGestCompetencias.EnableHeadersVisualStyles = false;
            this.dgvGestCompetencias.Location = new System.Drawing.Point(21, 204);
            this.dgvGestCompetencias.MultiSelect = false;
            this.dgvGestCompetencias.Name = "dgvGestCompetencias";
            this.dgvGestCompetencias.ReadOnly = true;
            dataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle2.BackColor = System.Drawing.Color.White;
            dataGridViewCellStyle2.Font = new System.Drawing.Font("Century Gothic", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle2.ForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle2.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle2.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle2.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dgvGestCompetencias.RowHeadersDefaultCellStyle = dataGridViewCellStyle2;
            this.dgvGestCompetencias.RowHeadersVisible = false;
            this.dgvGestCompetencias.RowHeadersWidth = 51;
            dataGridViewCellStyle3.BackColor = System.Drawing.Color.White;
            dataGridViewCellStyle3.Font = new System.Drawing.Font("Century Gothic", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle3.SelectionBackColor = System.Drawing.Color.LightGray;
            dataGridViewCellStyle3.SelectionForeColor = System.Drawing.Color.Black;
            this.dgvGestCompetencias.RowsDefaultCellStyle = dataGridViewCellStyle3;
            this.dgvGestCompetencias.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dgvGestCompetencias.Size = new System.Drawing.Size(1073, 480);
            this.dgvGestCompetencias.TabIndex = 42;
            // 
            // Cod_Subcompetencia
            // 
            this.Cod_Subcompetencia.HeaderText = "Código Subpotencial";
            this.Cod_Subcompetencia.MinimumWidth = 6;
            this.Cod_Subcompetencia.Name = "Cod_Subcompetencia";
            this.Cod_Subcompetencia.ReadOnly = true;
            this.Cod_Subcompetencia.Width = 150;
            // 
            // Código
            // 
            this.Código.HeaderText = "Código Potencial";
            this.Código.MinimumWidth = 6;
            this.Código.Name = "Código";
            this.Código.ReadOnly = true;
            this.Código.Width = 125;
            // 
            // Nombre
            // 
            this.Nombre.HeaderText = "Nombre";
            this.Nombre.MinimumWidth = 6;
            this.Nombre.Name = "Nombre";
            this.Nombre.ReadOnly = true;
            this.Nombre.Width = 250;
            // 
            // Descripción
            // 
            this.Descripción.HeaderText = "Descripción";
            this.Descripción.MinimumWidth = 6;
            this.Descripción.Name = "Descripción";
            this.Descripción.ReadOnly = true;
            this.Descripción.Width = 625;
            // 
            // Cargo
            // 
            this.Cargo.HeaderText = "Cargo";
            this.Cargo.MinimumWidth = 6;
            this.Cargo.Name = "Cargo";
            this.Cargo.ReadOnly = true;
            this.Cargo.Width = 125;
            // 
            // Peso
            // 
            this.Peso.HeaderText = "Peso";
            this.Peso.MinimumWidth = 6;
            this.Peso.Name = "Peso";
            this.Peso.ReadOnly = true;
            this.Peso.Width = 125;
            // 
            // Periodo
            // 
            this.Periodo.HeaderText = "Periodo";
            this.Periodo.MinimumWidth = 6;
            this.Periodo.Name = "Periodo";
            this.Periodo.ReadOnly = true;
            this.Periodo.Width = 125;
            // 
            // lblGestionarComp
            // 
            this.lblGestionarComp.Font = new System.Drawing.Font("Century Gothic", 36F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblGestionarComp.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(66)))), ((int)(((byte)(122)))));
            this.lblGestionarComp.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.lblGestionarComp.Location = new System.Drawing.Point(12, 9);
            this.lblGestionarComp.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lblGestionarComp.Name = "lblGestionarComp";
            this.lblGestionarComp.Size = new System.Drawing.Size(701, 79);
            this.lblGestionarComp.TabIndex = 41;
            this.lblGestionarComp.Text = "Gestionar Subpotenciales";
            this.lblGestionarComp.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // btnCargarMasivaSubPot
            // 
            this.btnCargarMasivaSubPot.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(157)))), ((int)(((byte)(6)))), ((int)(((byte)(32)))));
            this.btnCargarMasivaSubPot.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnCargarMasivaSubPot.Font = new System.Drawing.Font("Century Gothic", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnCargarMasivaSubPot.ForeColor = System.Drawing.Color.White;
            this.btnCargarMasivaSubPot.Location = new System.Drawing.Point(271, 129);
            this.btnCargarMasivaSubPot.Margin = new System.Windows.Forms.Padding(2);
            this.btnCargarMasivaSubPot.Name = "btnCargarMasivaSubPot";
            this.btnCargarMasivaSubPot.Size = new System.Drawing.Size(203, 26);
            this.btnCargarMasivaSubPot.TabIndex = 40;
            this.btnCargarMasivaSubPot.Text = " Cargar Masivamente";
            this.btnCargarMasivaSubPot.UseVisualStyleBackColor = false;
            this.btnCargarMasivaSubPot.Click += new System.EventHandler(this.btnCargarMasivaSubPot_Click);
            // 
            // btnCrearCompetencia
            // 
            this.btnCrearCompetencia.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(157)))), ((int)(((byte)(6)))), ((int)(((byte)(32)))));
            this.btnCrearCompetencia.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnCrearCompetencia.Font = new System.Drawing.Font("Century Gothic", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnCrearCompetencia.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.btnCrearCompetencia.Location = new System.Drawing.Point(21, 129);
            this.btnCrearCompetencia.Margin = new System.Windows.Forms.Padding(2);
            this.btnCrearCompetencia.Name = "btnCrearCompetencia";
            this.btnCrearCompetencia.Size = new System.Drawing.Size(204, 26);
            this.btnCrearCompetencia.TabIndex = 39;
            this.btnCrearCompetencia.Text = " Crear Subpotencial +";
            this.btnCrearCompetencia.UseVisualStyleBackColor = false;
            this.btnCrearCompetencia.Click += new System.EventHandler(this.btnCrearCompetencia_Click);
            // 
            // button1
            // 
            this.button1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(157)))), ((int)(((byte)(6)))), ((int)(((byte)(32)))));
            this.button1.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button1.Font = new System.Drawing.Font("Century Gothic", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button1.ForeColor = System.Drawing.Color.White;
            this.button1.Location = new System.Drawing.Point(21, 694);
            this.button1.Margin = new System.Windows.Forms.Padding(2);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(204, 26);
            this.button1.TabIndex = 50;
            this.button1.Text = "Eliminar";
            this.button1.UseVisualStyleBackColor = false;
            // 
            // button2
            // 
            this.button2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(157)))), ((int)(((byte)(6)))), ((int)(((byte)(32)))));
            this.button2.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button2.Font = new System.Drawing.Font("Century Gothic", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button2.ForeColor = System.Drawing.Color.White;
            this.button2.Location = new System.Drawing.Point(924, 167);
            this.button2.Margin = new System.Windows.Forms.Padding(2);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(150, 26);
            this.button2.TabIndex = 51;
            this.button2.Text = "Buscar";
            this.button2.UseVisualStyleBackColor = false;
            // 
            // frmAdmGestSubpot
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(1107, 755);
            this.Controls.Add(this.button2);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.txtBuscarPerioCom);
            this.Controls.Add(this.lblBuscarNomPot);
            this.Controls.Add(this.cmbPuestos);
            this.Controls.Add(this.cmbPeriodos);
            this.Controls.Add(this.txtGestNombrePot);
            this.Controls.Add(this.dgvGestCompetencias);
            this.Controls.Add(this.lblGestionarComp);
            this.Controls.Add(this.btnCargarMasivaSubPot);
            this.Controls.Add(this.btnCrearCompetencia);
            this.Name = "frmAdmGestSubpot";
            this.Text = "frmAdmGestSubpot";
            ((System.ComponentModel.ISupportInitialize)(this.dgvGestCompetencias)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label txtBuscarPerioCom;
        private System.Windows.Forms.Label lblBuscarNomPot;
        private System.Windows.Forms.ComboBox cmbPuestos;
        private System.Windows.Forms.ComboBox cmbPeriodos;
        private System.Windows.Forms.TextBox txtGestNombrePot;
        private System.Windows.Forms.DataGridView dgvGestCompetencias;
        private System.Windows.Forms.Label lblGestionarComp;
        private System.Windows.Forms.Button btnCargarMasivaSubPot;
        private System.Windows.Forms.Button btnCrearCompetencia;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.DataGridViewTextBoxColumn Cod_Subcompetencia;
        private System.Windows.Forms.DataGridViewTextBoxColumn Código;
        private System.Windows.Forms.DataGridViewTextBoxColumn Nombre;
        private System.Windows.Forms.DataGridViewTextBoxColumn Descripción;
        private System.Windows.Forms.DataGridViewTextBoxColumn Cargo;
        private System.Windows.Forms.DataGridViewTextBoxColumn Peso;
        private System.Windows.Forms.DataGridViewTextBoxColumn Periodo;
    }
}