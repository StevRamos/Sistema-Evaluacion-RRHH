namespace SistemaEDInterfaces
{
    partial class frmAdmGestPot
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
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle7 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle8 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle9 = new System.Windows.Forms.DataGridViewCellStyle();
            this.txtGestNombrePot = new System.Windows.Forms.TextBox();
            this.lblBuscarNomPot = new System.Windows.Forms.Label();
            this.dgvGestPot = new System.Windows.Forms.DataGridView();
            this.Código = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Nombre = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Descripción = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Cargo = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Peso = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Periodo = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Estado = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.lblGestionarPotencial = new System.Windows.Forms.Label();
            this.btnCargarMasivaPot = new System.Windows.Forms.Button();
            this.btnCrearPotencial = new System.Windows.Forms.Button();
            this.comboBox1 = new System.Windows.Forms.ComboBox();
            this.comboBox2 = new System.Windows.Forms.ComboBox();
            this.txtBuscarPerioPot = new System.Windows.Forms.Label();
            this.lblCargoPot = new System.Windows.Forms.Label();
            this.button1 = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.dgvGestPot)).BeginInit();
            this.SuspendLayout();
            // 
            // txtGestNombrePot
            // 
            this.txtGestNombrePot.Location = new System.Drawing.Point(1295, 165);
            this.txtGestNombrePot.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.txtGestNombrePot.Name = "txtGestNombrePot";
            this.txtGestNombrePot.Size = new System.Drawing.Size(199, 22);
            this.txtGestNombrePot.TabIndex = 17;
            // 
            // lblBuscarNomPot
            // 
            this.lblBuscarNomPot.AutoSize = true;
            this.lblBuscarNomPot.Font = new System.Drawing.Font("Century Gothic", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblBuscarNomPot.Location = new System.Drawing.Point(1293, 130);
            this.lblBuscarNomPot.Name = "lblBuscarNomPot";
            this.lblBuscarNomPot.Size = new System.Drawing.Size(167, 19);
            this.lblBuscarNomPot.TabIndex = 16;
            this.lblBuscarNomPot.Text = "Nombre Potencial :";
            // 
            // dgvGestPot
            // 
            this.dgvGestPot.AllowUserToAddRows = false;
            this.dgvGestPot.AllowUserToDeleteRows = false;
            this.dgvGestPot.AllowUserToResizeColumns = false;
            this.dgvGestPot.AllowUserToResizeRows = false;
            this.dgvGestPot.AutoSizeRowsMode = System.Windows.Forms.DataGridViewAutoSizeRowsMode.AllCells;
            this.dgvGestPot.BackgroundColor = System.Drawing.Color.White;
            this.dgvGestPot.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.dgvGestPot.ColumnHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.None;
            dataGridViewCellStyle7.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle7.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(66)))), ((int)(((byte)(122)))));
            dataGridViewCellStyle7.Font = new System.Drawing.Font("Century Gothic", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle7.ForeColor = System.Drawing.Color.White;
            dataGridViewCellStyle7.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle7.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle7.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dgvGestPot.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle7;
            this.dgvGestPot.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvGestPot.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.Código,
            this.Nombre,
            this.Descripción,
            this.Cargo,
            this.Peso,
            this.Periodo,
            this.Estado});
            this.dgvGestPot.EnableHeadersVisualStyles = false;
            this.dgvGestPot.Location = new System.Drawing.Point(32, 231);
            this.dgvGestPot.Margin = new System.Windows.Forms.Padding(4);
            this.dgvGestPot.Name = "dgvGestPot";
            dataGridViewCellStyle8.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle8.BackColor = System.Drawing.Color.White;
            dataGridViewCellStyle8.Font = new System.Drawing.Font("Century Gothic", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle8.ForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle8.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle8.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle8.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dgvGestPot.RowHeadersDefaultCellStyle = dataGridViewCellStyle8;
            this.dgvGestPot.RowHeadersVisible = false;
            this.dgvGestPot.RowHeadersWidth = 51;
            dataGridViewCellStyle9.BackColor = System.Drawing.Color.White;
            dataGridViewCellStyle9.SelectionBackColor = System.Drawing.Color.White;
            dataGridViewCellStyle9.SelectionForeColor = System.Drawing.Color.White;
            this.dgvGestPot.RowsDefaultCellStyle = dataGridViewCellStyle9;
            this.dgvGestPot.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dgvGestPot.Size = new System.Drawing.Size(1431, 591);
            this.dgvGestPot.TabIndex = 15;
            // 
            // Código
            // 
            this.Código.HeaderText = "Código";
            this.Código.MinimumWidth = 6;
            this.Código.Name = "Código";
            this.Código.Width = 125;
            // 
            // Nombre
            // 
            this.Nombre.HeaderText = "Nombre";
            this.Nombre.MinimumWidth = 6;
            this.Nombre.Name = "Nombre";
            this.Nombre.Width = 300;
            // 
            // Descripción
            // 
            this.Descripción.HeaderText = "Descripción";
            this.Descripción.MinimumWidth = 6;
            this.Descripción.Name = "Descripción";
            this.Descripción.Width = 500;
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
            // lblGestionarPotencial
            // 
            this.lblGestionarPotencial.Font = new System.Drawing.Font("Century Gothic", 36F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblGestionarPotencial.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(66)))), ((int)(((byte)(122)))));
            this.lblGestionarPotencial.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.lblGestionarPotencial.Location = new System.Drawing.Point(16, 11);
            this.lblGestionarPotencial.Name = "lblGestionarPotencial";
            this.lblGestionarPotencial.Size = new System.Drawing.Size(943, 97);
            this.lblGestionarPotencial.TabIndex = 14;
            this.lblGestionarPotencial.Text = "Gestionar Potenciales";
            this.lblGestionarPotencial.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // btnCargarMasivaPot
            // 
            this.btnCargarMasivaPot.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(157)))), ((int)(((byte)(6)))), ((int)(((byte)(32)))));
            this.btnCargarMasivaPot.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnCargarMasivaPot.Font = new System.Drawing.Font("Century Gothic", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnCargarMasivaPot.ForeColor = System.Drawing.Color.White;
            this.btnCargarMasivaPot.Location = new System.Drawing.Point(391, 158);
            this.btnCargarMasivaPot.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.btnCargarMasivaPot.Name = "btnCargarMasivaPot";
            this.btnCargarMasivaPot.Size = new System.Drawing.Size(251, 32);
            this.btnCargarMasivaPot.TabIndex = 13;
            this.btnCargarMasivaPot.Text = " Cargar Masivamente";
            this.btnCargarMasivaPot.UseVisualStyleBackColor = false;
            this.btnCargarMasivaPot.Click += new System.EventHandler(this.btnCargarMasivaPot_Click);
            // 
            // btnCrearPotencial
            // 
            this.btnCrearPotencial.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(157)))), ((int)(((byte)(6)))), ((int)(((byte)(32)))));
            this.btnCrearPotencial.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnCrearPotencial.Font = new System.Drawing.Font("Century Gothic", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnCrearPotencial.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.btnCrearPotencial.Location = new System.Drawing.Point(32, 158);
            this.btnCrearPotencial.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.btnCrearPotencial.Name = "btnCrearPotencial";
            this.btnCrearPotencial.Size = new System.Drawing.Size(251, 32);
            this.btnCrearPotencial.TabIndex = 12;
            this.btnCrearPotencial.Text = " Crear Potencial +";
            this.btnCrearPotencial.UseVisualStyleBackColor = false;
            this.btnCrearPotencial.Click += new System.EventHandler(this.btnCrearPotencial_Click);
            // 
            // comboBox1
            // 
            this.comboBox1.FormattingEnabled = true;
            this.comboBox1.Location = new System.Drawing.Point(1037, 164);
            this.comboBox1.Margin = new System.Windows.Forms.Padding(4);
            this.comboBox1.Name = "comboBox1";
            this.comboBox1.Size = new System.Drawing.Size(219, 24);
            this.comboBox1.TabIndex = 18;
            // 
            // comboBox2
            // 
            this.comboBox2.FormattingEnabled = true;
            this.comboBox2.Location = new System.Drawing.Point(776, 164);
            this.comboBox2.Margin = new System.Windows.Forms.Padding(4);
            this.comboBox2.Name = "comboBox2";
            this.comboBox2.Size = new System.Drawing.Size(208, 24);
            this.comboBox2.TabIndex = 19;
            // 
            // txtBuscarPerioPot
            // 
            this.txtBuscarPerioPot.AutoSize = true;
            this.txtBuscarPerioPot.Font = new System.Drawing.Font("Century Gothic", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtBuscarPerioPot.Location = new System.Drawing.Point(1033, 130);
            this.txtBuscarPerioPot.Name = "txtBuscarPerioPot";
            this.txtBuscarPerioPot.Size = new System.Drawing.Size(77, 19);
            this.txtBuscarPerioPot.TabIndex = 20;
            this.txtBuscarPerioPot.Text = "Periodo:";
            this.txtBuscarPerioPot.Click += new System.EventHandler(this.label1_Click);
            // 
            // lblCargoPot
            // 
            this.lblCargoPot.AutoSize = true;
            this.lblCargoPot.Font = new System.Drawing.Font("Century Gothic", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblCargoPot.Location = new System.Drawing.Point(772, 130);
            this.lblCargoPot.Name = "lblCargoPot";
            this.lblCargoPot.Size = new System.Drawing.Size(60, 19);
            this.lblCargoPot.TabIndex = 21;
            this.lblCargoPot.Text = "Cargo";
            // 
            // button1
            // 
            this.button1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(157)))), ((int)(((byte)(6)))), ((int)(((byte)(32)))));
            this.button1.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button1.Font = new System.Drawing.Font("Century Gothic", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button1.ForeColor = System.Drawing.Color.White;
            this.button1.Location = new System.Drawing.Point(32, 854);
            this.button1.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(251, 32);
            this.button1.TabIndex = 22;
            this.button1.Text = "Eliminar";
            this.button1.UseVisualStyleBackColor = false;
            // 
            // frmAdmGestPot
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(1476, 906);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.lblCargoPot);
            this.Controls.Add(this.txtBuscarPerioPot);
            this.Controls.Add(this.comboBox2);
            this.Controls.Add(this.comboBox1);
            this.Controls.Add(this.txtGestNombrePot);
            this.Controls.Add(this.lblBuscarNomPot);
            this.Controls.Add(this.dgvGestPot);
            this.Controls.Add(this.lblGestionarPotencial);
            this.Controls.Add(this.btnCargarMasivaPot);
            this.Controls.Add(this.btnCrearPotencial);
            this.Margin = new System.Windows.Forms.Padding(4);
            this.Name = "frmAdmGestPot";
            this.Text = "frmAdmGestPot";
            ((System.ComponentModel.ISupportInitialize)(this.dgvGestPot)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox txtGestNombrePot;
        private System.Windows.Forms.Label lblBuscarNomPot;
        private System.Windows.Forms.DataGridView dgvGestPot;
        private System.Windows.Forms.Label lblGestionarPotencial;
        private System.Windows.Forms.Button btnCargarMasivaPot;
        private System.Windows.Forms.Button btnCrearPotencial;
        private System.Windows.Forms.ComboBox comboBox1;
        private System.Windows.Forms.ComboBox comboBox2;
        private System.Windows.Forms.Label txtBuscarPerioPot;
        private System.Windows.Forms.Label lblCargoPot;
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