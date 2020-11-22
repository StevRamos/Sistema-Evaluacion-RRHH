namespace SistemaEDInterfaces
{
    partial class frmAdmGestSubcomp
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
            this.cmbPuestos = new System.Windows.Forms.ComboBox();
            this.cmbPeriodos = new System.Windows.Forms.ComboBox();
            this.txtGestNombrePot = new System.Windows.Forms.TextBox();
            this.dgvGestSubCom = new System.Windows.Forms.DataGridView();
            this.IdSubComp = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.IdCompetencia = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Nombre = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Descripción = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Cargo = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Peso = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Periodo = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.btnCargarMasivaSubCom = new System.Windows.Forms.Button();
            this.btnGestCrearSubCom = new System.Windows.Forms.Button();
            this.lblGestSubComp = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.txtBuscarPerioCom = new System.Windows.Forms.Label();
            this.lblBuscarNomPot = new System.Windows.Forms.Label();
            this.btnEliminar = new System.Windows.Forms.Button();
            this.btnBuscar = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.dgvGestSubCom)).BeginInit();
            this.SuspendLayout();
            // 
            // cmbPuestos
            // 
            this.cmbPuestos.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cmbPuestos.FormattingEnabled = true;
            this.cmbPuestos.Location = new System.Drawing.Point(536, 134);
            this.cmbPuestos.Name = "cmbPuestos";
            this.cmbPuestos.Size = new System.Drawing.Size(157, 21);
            this.cmbPuestos.TabIndex = 35;
            // 
            // cmbPeriodos
            // 
            this.cmbPeriodos.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cmbPeriodos.FormattingEnabled = true;
            this.cmbPeriodos.Location = new System.Drawing.Point(732, 134);
            this.cmbPeriodos.Name = "cmbPeriodos";
            this.cmbPeriodos.Size = new System.Drawing.Size(165, 21);
            this.cmbPeriodos.TabIndex = 34;
            // 
            // txtGestNombrePot
            // 
            this.txtGestNombrePot.Location = new System.Drawing.Point(925, 135);
            this.txtGestNombrePot.Margin = new System.Windows.Forms.Padding(2);
            this.txtGestNombrePot.Name = "txtGestNombrePot";
            this.txtGestNombrePot.Size = new System.Drawing.Size(150, 20);
            this.txtGestNombrePot.TabIndex = 33;
            // 
            // dgvGestSubCom
            // 
            this.dgvGestSubCom.AllowUserToAddRows = false;
            this.dgvGestSubCom.AllowUserToDeleteRows = false;
            this.dgvGestSubCom.AllowUserToResizeRows = false;
            this.dgvGestSubCom.AutoSizeRowsMode = System.Windows.Forms.DataGridViewAutoSizeRowsMode.AllCells;
            this.dgvGestSubCom.BackgroundColor = System.Drawing.Color.White;
            this.dgvGestSubCom.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.dgvGestSubCom.ColumnHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.None;
            dataGridViewCellStyle1.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(66)))), ((int)(((byte)(122)))));
            dataGridViewCellStyle1.Font = new System.Drawing.Font("Century Gothic", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle1.ForeColor = System.Drawing.Color.White;
            dataGridViewCellStyle1.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle1.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle1.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dgvGestSubCom.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle1;
            this.dgvGestSubCom.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvGestSubCom.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.IdSubComp,
            this.IdCompetencia,
            this.Nombre,
            this.Descripción,
            this.Cargo,
            this.Peso,
            this.Periodo});
            this.dgvGestSubCom.EnableHeadersVisualStyles = false;
            this.dgvGestSubCom.Location = new System.Drawing.Point(22, 202);
            this.dgvGestSubCom.MultiSelect = false;
            this.dgvGestSubCom.Name = "dgvGestSubCom";
            this.dgvGestSubCom.ReadOnly = true;
            dataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle2.BackColor = System.Drawing.Color.White;
            dataGridViewCellStyle2.Font = new System.Drawing.Font("Century Gothic", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle2.ForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle2.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle2.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle2.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dgvGestSubCom.RowHeadersDefaultCellStyle = dataGridViewCellStyle2;
            this.dgvGestSubCom.RowHeadersVisible = false;
            this.dgvGestSubCom.RowHeadersWidth = 51;
            dataGridViewCellStyle3.BackColor = System.Drawing.Color.White;
            dataGridViewCellStyle3.Font = new System.Drawing.Font("Century Gothic", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle3.SelectionBackColor = System.Drawing.Color.LightGray;
            dataGridViewCellStyle3.SelectionForeColor = System.Drawing.Color.Black;
            this.dgvGestSubCom.RowsDefaultCellStyle = dataGridViewCellStyle3;
            this.dgvGestSubCom.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dgvGestSubCom.Size = new System.Drawing.Size(1073, 480);
            this.dgvGestSubCom.TabIndex = 31;
            // 
            // IdSubComp
            // 
            this.IdSubComp.HeaderText = "Id Subcompetencia";
            this.IdSubComp.MinimumWidth = 6;
            this.IdSubComp.Name = "IdSubComp";
            this.IdSubComp.ReadOnly = true;
            this.IdSubComp.Width = 150;
            // 
            // IdCompetencia
            // 
            this.IdCompetencia.HeaderText = "Id Competencia";
            this.IdCompetencia.MinimumWidth = 6;
            this.IdCompetencia.Name = "IdCompetencia";
            this.IdCompetencia.ReadOnly = true;
            this.IdCompetencia.Width = 125;
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
            // btnCargarMasivaSubCom
            // 
            this.btnCargarMasivaSubCom.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(157)))), ((int)(((byte)(6)))), ((int)(((byte)(32)))));
            this.btnCargarMasivaSubCom.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnCargarMasivaSubCom.Font = new System.Drawing.Font("Century Gothic", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnCargarMasivaSubCom.ForeColor = System.Drawing.Color.White;
            this.btnCargarMasivaSubCom.Location = new System.Drawing.Point(258, 129);
            this.btnCargarMasivaSubCom.Margin = new System.Windows.Forms.Padding(2);
            this.btnCargarMasivaSubCom.Name = "btnCargarMasivaSubCom";
            this.btnCargarMasivaSubCom.Size = new System.Drawing.Size(194, 26);
            this.btnCargarMasivaSubCom.TabIndex = 29;
            this.btnCargarMasivaSubCom.Text = " Cargar Masivamente";
            this.btnCargarMasivaSubCom.UseVisualStyleBackColor = false;
            this.btnCargarMasivaSubCom.Click += new System.EventHandler(this.btnCargarMasivaSubCom_Click);
            // 
            // btnGestCrearSubCom
            // 
            this.btnGestCrearSubCom.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(157)))), ((int)(((byte)(6)))), ((int)(((byte)(32)))));
            this.btnGestCrearSubCom.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnGestCrearSubCom.Font = new System.Drawing.Font("Century Gothic", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnGestCrearSubCom.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.btnGestCrearSubCom.Location = new System.Drawing.Point(22, 129);
            this.btnGestCrearSubCom.Margin = new System.Windows.Forms.Padding(2);
            this.btnGestCrearSubCom.Name = "btnGestCrearSubCom";
            this.btnGestCrearSubCom.Size = new System.Drawing.Size(194, 26);
            this.btnGestCrearSubCom.TabIndex = 28;
            this.btnGestCrearSubCom.Text = " Crear Subcompetencia +";
            this.btnGestCrearSubCom.UseVisualStyleBackColor = false;
            this.btnGestCrearSubCom.Click += new System.EventHandler(this.btnGestCrearSubCom_Click);
            // 
            // lblGestSubComp
            // 
            this.lblGestSubComp.Font = new System.Drawing.Font("Century Gothic", 36F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblGestSubComp.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(66)))), ((int)(((byte)(122)))));
            this.lblGestSubComp.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.lblGestSubComp.Location = new System.Drawing.Point(12, 9);
            this.lblGestSubComp.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lblGestSubComp.Name = "lblGestSubComp";
            this.lblGestSubComp.Size = new System.Drawing.Size(701, 79);
            this.lblGestSubComp.TabIndex = 30;
            this.lblGestSubComp.Text = "Gestionar Subcompetencias";
            this.lblGestSubComp.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Century Gothic", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.Black;
            this.label1.Location = new System.Drawing.Point(533, 103);
            this.label1.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(58, 17);
            this.label1.TabIndex = 38;
            this.label1.Text = "Cargo :";
            // 
            // txtBuscarPerioCom
            // 
            this.txtBuscarPerioCom.AutoSize = true;
            this.txtBuscarPerioCom.Font = new System.Drawing.Font("Century Gothic", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtBuscarPerioCom.ForeColor = System.Drawing.Color.Black;
            this.txtBuscarPerioCom.Location = new System.Drawing.Point(729, 103);
            this.txtBuscarPerioCom.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.txtBuscarPerioCom.Name = "txtBuscarPerioCom";
            this.txtBuscarPerioCom.Size = new System.Drawing.Size(68, 17);
            this.txtBuscarPerioCom.TabIndex = 37;
            this.txtBuscarPerioCom.Text = "Periodo :";
            // 
            // lblBuscarNomPot
            // 
            this.lblBuscarNomPot.AutoSize = true;
            this.lblBuscarNomPot.Font = new System.Drawing.Font("Century Gothic", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblBuscarNomPot.ForeColor = System.Drawing.Color.Black;
            this.lblBuscarNomPot.Location = new System.Drawing.Point(922, 103);
            this.lblBuscarNomPot.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lblBuscarNomPot.Name = "lblBuscarNomPot";
            this.lblBuscarNomPot.Size = new System.Drawing.Size(192, 17);
            this.lblBuscarNomPot.TabIndex = 36;
            this.lblBuscarNomPot.Text = "Nombre Subcompetencia :";
            // 
            // btnEliminar
            // 
            this.btnEliminar.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(157)))), ((int)(((byte)(6)))), ((int)(((byte)(32)))));
            this.btnEliminar.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnEliminar.Font = new System.Drawing.Font("Century Gothic", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnEliminar.ForeColor = System.Drawing.Color.White;
            this.btnEliminar.Location = new System.Drawing.Point(21, 694);
            this.btnEliminar.Margin = new System.Windows.Forms.Padding(2);
            this.btnEliminar.Name = "btnEliminar";
            this.btnEliminar.Size = new System.Drawing.Size(195, 26);
            this.btnEliminar.TabIndex = 49;
            this.btnEliminar.Text = "Eliminar";
            this.btnEliminar.UseVisualStyleBackColor = false;
            // 
            // btnBuscar
            // 
            this.btnBuscar.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(157)))), ((int)(((byte)(6)))), ((int)(((byte)(32)))));
            this.btnBuscar.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnBuscar.Font = new System.Drawing.Font("Century Gothic", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnBuscar.ForeColor = System.Drawing.Color.White;
            this.btnBuscar.Location = new System.Drawing.Point(924, 166);
            this.btnBuscar.Margin = new System.Windows.Forms.Padding(2);
            this.btnBuscar.Name = "btnBuscar";
            this.btnBuscar.Size = new System.Drawing.Size(150, 26);
            this.btnBuscar.TabIndex = 51;
            this.btnBuscar.Text = "Buscar";
            this.btnBuscar.UseVisualStyleBackColor = false;
            // 
            // frmAdmGestSubcomp
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(1107, 755);
            this.Controls.Add(this.btnBuscar);
            this.Controls.Add(this.btnEliminar);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.txtBuscarPerioCom);
            this.Controls.Add(this.lblBuscarNomPot);
            this.Controls.Add(this.cmbPuestos);
            this.Controls.Add(this.cmbPeriodos);
            this.Controls.Add(this.txtGestNombrePot);
            this.Controls.Add(this.dgvGestSubCom);
            this.Controls.Add(this.lblGestSubComp);
            this.Controls.Add(this.btnCargarMasivaSubCom);
            this.Controls.Add(this.btnGestCrearSubCom);
            this.ForeColor = System.Drawing.Color.White;
            this.Name = "frmAdmGestSubcomp";
            this.Text = "frmAdmGestSubcomp";
            ((System.ComponentModel.ISupportInitialize)(this.dgvGestSubCom)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.ComboBox cmbPuestos;
        private System.Windows.Forms.ComboBox cmbPeriodos;
        private System.Windows.Forms.TextBox txtGestNombrePot;
        private System.Windows.Forms.DataGridView dgvGestSubCom;
        private System.Windows.Forms.Button btnCargarMasivaSubCom;
        private System.Windows.Forms.Button btnGestCrearSubCom;
        private System.Windows.Forms.Label lblGestSubComp;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label txtBuscarPerioCom;
        private System.Windows.Forms.Label lblBuscarNomPot;
        private System.Windows.Forms.Button btnEliminar;
        private System.Windows.Forms.Button btnBuscar;
        private System.Windows.Forms.DataGridViewTextBoxColumn IdSubComp;
        private System.Windows.Forms.DataGridViewTextBoxColumn IdCompetencia;
        private System.Windows.Forms.DataGridViewTextBoxColumn Nombre;
        private System.Windows.Forms.DataGridViewTextBoxColumn Descripción;
        private System.Windows.Forms.DataGridViewTextBoxColumn Cargo;
        private System.Windows.Forms.DataGridViewTextBoxColumn Peso;
        private System.Windows.Forms.DataGridViewTextBoxColumn Periodo;
    }
}