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
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle1 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle2 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle3 = new System.Windows.Forms.DataGridViewCellStyle();
            this.txtGestNombrePot = new System.Windows.Forms.TextBox();
            this.lblBuscarNomPot = new System.Windows.Forms.Label();
            this.dgvGestPot = new System.Windows.Forms.DataGridView();
            this.lblGestionarPotencial = new System.Windows.Forms.Label();
            this.btnCargarMasivaPot = new System.Windows.Forms.Button();
            this.btnCrearPotencial = new System.Windows.Forms.Button();
            this.cmbPeriodo = new System.Windows.Forms.ComboBox();
            this.cmbPuestos = new System.Windows.Forms.ComboBox();
            this.txtBuscarPerioPot = new System.Windows.Forms.Label();
            this.lblCargoPot = new System.Windows.Forms.Label();
            this.btnEliminar = new System.Windows.Forms.Button();
            this.btnBuscar = new System.Windows.Forms.Button();
            this.Id = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Nombre = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Descripción = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Cargo = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Peso = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Periodo = new System.Windows.Forms.DataGridViewTextBoxColumn();
            ((System.ComponentModel.ISupportInitialize)(this.dgvGestPot)).BeginInit();
            this.SuspendLayout();
            // 
            // txtGestNombrePot
            // 
            this.txtGestNombrePot.Location = new System.Drawing.Point(971, 134);
            this.txtGestNombrePot.Margin = new System.Windows.Forms.Padding(2);
            this.txtGestNombrePot.Name = "txtGestNombrePot";
            this.txtGestNombrePot.Size = new System.Drawing.Size(150, 20);
            this.txtGestNombrePot.TabIndex = 17;
            // 
            // lblBuscarNomPot
            // 
            this.lblBuscarNomPot.AutoSize = true;
            this.lblBuscarNomPot.Font = new System.Drawing.Font("Century Gothic", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblBuscarNomPot.Location = new System.Drawing.Point(970, 106);
            this.lblBuscarNomPot.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lblBuscarNomPot.Name = "lblBuscarNomPot";
            this.lblBuscarNomPot.Size = new System.Drawing.Size(139, 17);
            this.lblBuscarNomPot.TabIndex = 16;
            this.lblBuscarNomPot.Text = "Nombre Potencial :";
            // 
            // dgvGestPot
            // 
            this.dgvGestPot.AllowUserToAddRows = false;
            this.dgvGestPot.AllowUserToDeleteRows = false;
            this.dgvGestPot.AllowUserToResizeRows = false;
            this.dgvGestPot.AutoSizeRowsMode = System.Windows.Forms.DataGridViewAutoSizeRowsMode.AllCells;
            this.dgvGestPot.BackgroundColor = System.Drawing.Color.White;
            this.dgvGestPot.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.dgvGestPot.ColumnHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.None;
            dataGridViewCellStyle1.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(66)))), ((int)(((byte)(122)))));
            dataGridViewCellStyle1.Font = new System.Drawing.Font("Century Gothic", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle1.ForeColor = System.Drawing.Color.White;
            dataGridViewCellStyle1.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle1.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle1.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dgvGestPot.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle1;
            this.dgvGestPot.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvGestPot.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.Id,
            this.Nombre,
            this.Descripción,
            this.Cargo,
            this.Peso,
            this.Periodo});
            this.dgvGestPot.EnableHeadersVisualStyles = false;
            this.dgvGestPot.Location = new System.Drawing.Point(24, 205);
            this.dgvGestPot.MultiSelect = false;
            this.dgvGestPot.Name = "dgvGestPot";
            this.dgvGestPot.ReadOnly = true;
            dataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle2.BackColor = System.Drawing.Color.White;
            dataGridViewCellStyle2.Font = new System.Drawing.Font("Century Gothic", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle2.ForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle2.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle2.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle2.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dgvGestPot.RowHeadersDefaultCellStyle = dataGridViewCellStyle2;
            this.dgvGestPot.RowHeadersVisible = false;
            this.dgvGestPot.RowHeadersWidth = 51;
            dataGridViewCellStyle3.BackColor = System.Drawing.Color.White;
            dataGridViewCellStyle3.Font = new System.Drawing.Font("Century Gothic", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle3.SelectionBackColor = System.Drawing.Color.LightGray;
            dataGridViewCellStyle3.SelectionForeColor = System.Drawing.Color.Black;
            this.dgvGestPot.RowsDefaultCellStyle = dataGridViewCellStyle3;
            this.dgvGestPot.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dgvGestPot.Size = new System.Drawing.Size(1073, 388);
            this.dgvGestPot.TabIndex = 15;
            this.dgvGestPot.CellFormatting += new System.Windows.Forms.DataGridViewCellFormattingEventHandler(this.dgvGestPot_CellFormatting);
            // 
            // lblGestionarPotencial
            // 
            this.lblGestionarPotencial.Font = new System.Drawing.Font("Century Gothic", 36F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblGestionarPotencial.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(66)))), ((int)(((byte)(122)))));
            this.lblGestionarPotencial.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.lblGestionarPotencial.Location = new System.Drawing.Point(12, 9);
            this.lblGestionarPotencial.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lblGestionarPotencial.Name = "lblGestionarPotencial";
            this.lblGestionarPotencial.Size = new System.Drawing.Size(707, 79);
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
            this.btnCargarMasivaPot.Location = new System.Drawing.Point(293, 128);
            this.btnCargarMasivaPot.Margin = new System.Windows.Forms.Padding(2);
            this.btnCargarMasivaPot.Name = "btnCargarMasivaPot";
            this.btnCargarMasivaPot.Size = new System.Drawing.Size(188, 26);
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
            this.btnCrearPotencial.Location = new System.Drawing.Point(24, 128);
            this.btnCrearPotencial.Margin = new System.Windows.Forms.Padding(2);
            this.btnCrearPotencial.Name = "btnCrearPotencial";
            this.btnCrearPotencial.Size = new System.Drawing.Size(188, 26);
            this.btnCrearPotencial.TabIndex = 12;
            this.btnCrearPotencial.Text = " Crear Potencial +";
            this.btnCrearPotencial.UseVisualStyleBackColor = false;
            this.btnCrearPotencial.Click += new System.EventHandler(this.btnCrearPotencial_Click);
            // 
            // cmbPeriodo
            // 
            this.cmbPeriodo.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cmbPeriodo.FormattingEnabled = true;
            this.cmbPeriodo.Location = new System.Drawing.Point(778, 133);
            this.cmbPeriodo.Name = "cmbPeriodo";
            this.cmbPeriodo.Size = new System.Drawing.Size(165, 21);
            this.cmbPeriodo.TabIndex = 18;
            // 
            // cmbPuestos
            // 
            this.cmbPuestos.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cmbPuestos.FormattingEnabled = true;
            this.cmbPuestos.Location = new System.Drawing.Point(582, 133);
            this.cmbPuestos.Name = "cmbPuestos";
            this.cmbPuestos.Size = new System.Drawing.Size(157, 21);
            this.cmbPuestos.TabIndex = 19;
            // 
            // txtBuscarPerioPot
            // 
            this.txtBuscarPerioPot.AutoSize = true;
            this.txtBuscarPerioPot.Font = new System.Drawing.Font("Century Gothic", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtBuscarPerioPot.Location = new System.Drawing.Point(775, 106);
            this.txtBuscarPerioPot.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.txtBuscarPerioPot.Name = "txtBuscarPerioPot";
            this.txtBuscarPerioPot.Size = new System.Drawing.Size(64, 17);
            this.txtBuscarPerioPot.TabIndex = 20;
            this.txtBuscarPerioPot.Text = "Periodo:";
            this.txtBuscarPerioPot.Click += new System.EventHandler(this.label1_Click);
            // 
            // lblCargoPot
            // 
            this.lblCargoPot.AutoSize = true;
            this.lblCargoPot.Font = new System.Drawing.Font("Century Gothic", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblCargoPot.Location = new System.Drawing.Point(579, 106);
            this.lblCargoPot.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lblCargoPot.Name = "lblCargoPot";
            this.lblCargoPot.Size = new System.Drawing.Size(50, 17);
            this.lblCargoPot.TabIndex = 21;
            this.lblCargoPot.Text = "Cargo";
            // 
            // btnEliminar
            // 
            this.btnEliminar.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(157)))), ((int)(((byte)(6)))), ((int)(((byte)(32)))));
            this.btnEliminar.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnEliminar.Font = new System.Drawing.Font("Century Gothic", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnEliminar.ForeColor = System.Drawing.Color.White;
            this.btnEliminar.Location = new System.Drawing.Point(24, 625);
            this.btnEliminar.Margin = new System.Windows.Forms.Padding(2);
            this.btnEliminar.Name = "btnEliminar";
            this.btnEliminar.Size = new System.Drawing.Size(188, 26);
            this.btnEliminar.TabIndex = 22;
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
            this.btnBuscar.Location = new System.Drawing.Point(970, 164);
            this.btnBuscar.Margin = new System.Windows.Forms.Padding(2);
            this.btnBuscar.Name = "btnBuscar";
            this.btnBuscar.Size = new System.Drawing.Size(150, 26);
            this.btnBuscar.TabIndex = 50;
            this.btnBuscar.Text = "Buscar";
            this.btnBuscar.UseVisualStyleBackColor = false;
            this.btnBuscar.Click += new System.EventHandler(this.btnBuscar_Click);
            // 
            // Id
            // 
            this.Id.HeaderText = "Id";
            this.Id.MinimumWidth = 6;
            this.Id.Name = "Id";
            this.Id.ReadOnly = true;
            this.Id.Width = 40;
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
            this.Descripción.Width = 390;
            // 
            // Cargo
            // 
            this.Cargo.HeaderText = "Cargo";
            this.Cargo.MinimumWidth = 6;
            this.Cargo.Name = "Cargo";
            this.Cargo.ReadOnly = true;
            this.Cargo.Width = 200;
            // 
            // Peso
            // 
            this.Peso.DataPropertyName = "peso";
            this.Peso.HeaderText = "Peso";
            this.Peso.MinimumWidth = 6;
            this.Peso.Name = "Peso";
            this.Peso.ReadOnly = true;
            this.Peso.Width = 50;
            // 
            // Periodo
            // 
            this.Periodo.HeaderText = "Periodo";
            this.Periodo.MinimumWidth = 6;
            this.Periodo.Name = "Periodo";
            this.Periodo.ReadOnly = true;
            this.Periodo.Width = 110;
            // 
            // frmAdmGestPot
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(1107, 749);
            this.Controls.Add(this.btnBuscar);
            this.Controls.Add(this.btnEliminar);
            this.Controls.Add(this.lblCargoPot);
            this.Controls.Add(this.txtBuscarPerioPot);
            this.Controls.Add(this.cmbPuestos);
            this.Controls.Add(this.cmbPeriodo);
            this.Controls.Add(this.txtGestNombrePot);
            this.Controls.Add(this.lblBuscarNomPot);
            this.Controls.Add(this.dgvGestPot);
            this.Controls.Add(this.lblGestionarPotencial);
            this.Controls.Add(this.btnCargarMasivaPot);
            this.Controls.Add(this.btnCrearPotencial);
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
        private System.Windows.Forms.ComboBox cmbPeriodo;
        private System.Windows.Forms.ComboBox cmbPuestos;
        private System.Windows.Forms.Label txtBuscarPerioPot;
        private System.Windows.Forms.Label lblCargoPot;
        private System.Windows.Forms.Button btnEliminar;
        private System.Windows.Forms.Button btnBuscar;
        private System.Windows.Forms.DataGridViewTextBoxColumn Id;
        private System.Windows.Forms.DataGridViewTextBoxColumn Nombre;
        private System.Windows.Forms.DataGridViewTextBoxColumn Descripción;
        private System.Windows.Forms.DataGridViewTextBoxColumn Cargo;
        private System.Windows.Forms.DataGridViewTextBoxColumn Peso;
        private System.Windows.Forms.DataGridViewTextBoxColumn Periodo;
    }
}