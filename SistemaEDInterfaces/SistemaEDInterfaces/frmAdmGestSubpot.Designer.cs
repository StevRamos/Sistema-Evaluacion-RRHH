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
            this.comboBox2 = new System.Windows.Forms.ComboBox();
            this.comboBox1 = new System.Windows.Forms.ComboBox();
            this.txtGestNombrePot = new System.Windows.Forms.TextBox();
            this.dgvGestCompetencias = new System.Windows.Forms.DataGridView();
            this.Cod_Subcompetencia = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Código = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Nombre = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Descripción = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Cargo = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Peso = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Periodo = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Estado = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.lblGestionarComp = new System.Windows.Forms.Label();
            this.btnCargarMasivaSubPot = new System.Windows.Forms.Button();
            this.btnCrearCompetencia = new System.Windows.Forms.Button();
            this.button1 = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.dgvGestCompetencias)).BeginInit();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Century Gothic", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.Black;
            this.label1.Location = new System.Drawing.Point(709, 127);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(70, 19);
            this.label1.TabIndex = 48;
            this.label1.Text = "Cargo :";
            // 
            // txtBuscarPerioCom
            // 
            this.txtBuscarPerioCom.AutoSize = true;
            this.txtBuscarPerioCom.Font = new System.Drawing.Font("Century Gothic", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtBuscarPerioCom.ForeColor = System.Drawing.Color.Black;
            this.txtBuscarPerioCom.Location = new System.Drawing.Point(971, 127);
            this.txtBuscarPerioCom.Name = "txtBuscarPerioCom";
            this.txtBuscarPerioCom.Size = new System.Drawing.Size(82, 19);
            this.txtBuscarPerioCom.TabIndex = 47;
            this.txtBuscarPerioCom.Text = "Periodo :";
            // 
            // lblBuscarNomPot
            // 
            this.lblBuscarNomPot.AutoSize = true;
            this.lblBuscarNomPot.Font = new System.Drawing.Font("Century Gothic", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblBuscarNomPot.ForeColor = System.Drawing.Color.Black;
            this.lblBuscarNomPot.Location = new System.Drawing.Point(1228, 127);
            this.lblBuscarNomPot.Name = "lblBuscarNomPot";
            this.lblBuscarNomPot.Size = new System.Drawing.Size(198, 19);
            this.lblBuscarNomPot.TabIndex = 46;
            this.lblBuscarNomPot.Text = "Nombre Subpotencial :";
            // 
            // comboBox2
            // 
            this.comboBox2.FormattingEnabled = true;
            this.comboBox2.Location = new System.Drawing.Point(713, 165);
            this.comboBox2.Margin = new System.Windows.Forms.Padding(4);
            this.comboBox2.Name = "comboBox2";
            this.comboBox2.Size = new System.Drawing.Size(208, 24);
            this.comboBox2.TabIndex = 45;
            // 
            // comboBox1
            // 
            this.comboBox1.FormattingEnabled = true;
            this.comboBox1.Location = new System.Drawing.Point(975, 165);
            this.comboBox1.Margin = new System.Windows.Forms.Padding(4);
            this.comboBox1.Name = "comboBox1";
            this.comboBox1.Size = new System.Drawing.Size(219, 24);
            this.comboBox1.TabIndex = 44;
            // 
            // txtGestNombrePot
            // 
            this.txtGestNombrePot.Location = new System.Drawing.Point(1232, 166);
            this.txtGestNombrePot.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.txtGestNombrePot.Name = "txtGestNombrePot";
            this.txtGestNombrePot.Size = new System.Drawing.Size(199, 22);
            this.txtGestNombrePot.TabIndex = 43;
            // 
            // dgvGestCompetencias
            // 
            this.dgvGestCompetencias.AllowUserToAddRows = false;
            this.dgvGestCompetencias.AllowUserToDeleteRows = false;
            this.dgvGestCompetencias.AllowUserToResizeColumns = false;
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
            this.Periodo,
            this.Estado});
            this.dgvGestCompetencias.EnableHeadersVisualStyles = false;
            this.dgvGestCompetencias.Location = new System.Drawing.Point(28, 231);
            this.dgvGestCompetencias.Margin = new System.Windows.Forms.Padding(4);
            this.dgvGestCompetencias.Name = "dgvGestCompetencias";
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
            dataGridViewCellStyle3.SelectionBackColor = System.Drawing.Color.White;
            dataGridViewCellStyle3.SelectionForeColor = System.Drawing.Color.White;
            this.dgvGestCompetencias.RowsDefaultCellStyle = dataGridViewCellStyle3;
            this.dgvGestCompetencias.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dgvGestCompetencias.Size = new System.Drawing.Size(1431, 591);
            this.dgvGestCompetencias.TabIndex = 42;
            // 
            // Cod_Subcompetencia
            // 
            this.Cod_Subcompetencia.HeaderText = "Código Subpotencial";
            this.Cod_Subcompetencia.MinimumWidth = 6;
            this.Cod_Subcompetencia.Name = "Cod_Subcompetencia";
            this.Cod_Subcompetencia.Width = 150;
            // 
            // Código
            // 
            this.Código.HeaderText = "Código Potencial";
            this.Código.MinimumWidth = 6;
            this.Código.Name = "Código";
            this.Código.Width = 125;
            // 
            // Nombre
            // 
            this.Nombre.HeaderText = "Nombre";
            this.Nombre.MinimumWidth = 6;
            this.Nombre.Name = "Nombre";
            this.Nombre.Width = 250;
            // 
            // Descripción
            // 
            this.Descripción.HeaderText = "Descripción";
            this.Descripción.MinimumWidth = 6;
            this.Descripción.Name = "Descripción";
            this.Descripción.Width = 550;
            // 
            // Cargo
            // 
            this.Cargo.HeaderText = "Cargo";
            this.Cargo.MinimumWidth = 6;
            this.Cargo.Name = "Cargo";
            this.Cargo.Width = 125;
            // 
            // Peso
            // 
            this.Peso.HeaderText = "Peso";
            this.Peso.MinimumWidth = 6;
            this.Peso.Name = "Peso";
            this.Peso.Width = 125;
            // 
            // Periodo
            // 
            this.Periodo.HeaderText = "Periodo";
            this.Periodo.MinimumWidth = 6;
            this.Periodo.Name = "Periodo";
            this.Periodo.Width = 125;
            // 
            // Estado
            // 
            this.Estado.HeaderText = "Estado";
            this.Estado.MinimumWidth = 6;
            this.Estado.Name = "Estado";
            this.Estado.Width = 125;
            // 
            // lblGestionarComp
            // 
            this.lblGestionarComp.Font = new System.Drawing.Font("Century Gothic", 36F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblGestionarComp.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(66)))), ((int)(((byte)(122)))));
            this.lblGestionarComp.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.lblGestionarComp.Location = new System.Drawing.Point(16, 11);
            this.lblGestionarComp.Name = "lblGestionarComp";
            this.lblGestionarComp.Size = new System.Drawing.Size(935, 97);
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
            this.btnCargarMasivaSubPot.Location = new System.Drawing.Point(361, 159);
            this.btnCargarMasivaSubPot.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.btnCargarMasivaSubPot.Name = "btnCargarMasivaSubPot";
            this.btnCargarMasivaSubPot.Size = new System.Drawing.Size(271, 32);
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
            this.btnCrearCompetencia.Location = new System.Drawing.Point(28, 159);
            this.btnCrearCompetencia.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.btnCrearCompetencia.Name = "btnCrearCompetencia";
            this.btnCrearCompetencia.Size = new System.Drawing.Size(272, 32);
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
            this.button1.Location = new System.Drawing.Point(28, 854);
            this.button1.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(272, 32);
            this.button1.TabIndex = 50;
            this.button1.Text = "Eliminar";
            this.button1.UseVisualStyleBackColor = false;
            // 
            // frmAdmGestSubpot
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(1476, 929);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.txtBuscarPerioCom);
            this.Controls.Add(this.lblBuscarNomPot);
            this.Controls.Add(this.comboBox2);
            this.Controls.Add(this.comboBox1);
            this.Controls.Add(this.txtGestNombrePot);
            this.Controls.Add(this.dgvGestCompetencias);
            this.Controls.Add(this.lblGestionarComp);
            this.Controls.Add(this.btnCargarMasivaSubPot);
            this.Controls.Add(this.btnCrearCompetencia);
            this.Margin = new System.Windows.Forms.Padding(4);
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
        private System.Windows.Forms.ComboBox comboBox2;
        private System.Windows.Forms.ComboBox comboBox1;
        private System.Windows.Forms.TextBox txtGestNombrePot;
        private System.Windows.Forms.DataGridView dgvGestCompetencias;
        private System.Windows.Forms.Label lblGestionarComp;
        private System.Windows.Forms.Button btnCargarMasivaSubPot;
        private System.Windows.Forms.Button btnCrearCompetencia;
        private System.Windows.Forms.DataGridViewTextBoxColumn Cod_Subcompetencia;
        private System.Windows.Forms.DataGridViewTextBoxColumn Código;
        private System.Windows.Forms.DataGridViewTextBoxColumn Nombre;
        private System.Windows.Forms.DataGridViewTextBoxColumn Descripción;
        private System.Windows.Forms.DataGridViewTextBoxColumn Cargo;
        private System.Windows.Forms.DataGridViewTextBoxColumn Peso;
        private System.Windows.Forms.DataGridViewTextBoxColumn Periodo;
        private System.Windows.Forms.DataGridViewTextBoxColumn Estado;
        private System.Windows.Forms.Button button1;
    }
}