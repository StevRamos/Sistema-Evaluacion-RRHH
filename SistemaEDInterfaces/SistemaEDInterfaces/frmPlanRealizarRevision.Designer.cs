namespace SistemaEDInterfaces
{
    partial class frmPlanRealizarRevision
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
            this.btnEnviar = new System.Windows.Forms.Button();
            this.btnVerDetalle = new System.Windows.Forms.Button();
            this.dgvMisObjetivos = new System.Windows.Forms.DataGridView();
            this.Numero = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Descripcion = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Peso = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Estado = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.lblValidarObjetivos = new System.Windows.Forms.Label();
            this.btnRegresar = new System.Windows.Forms.Button();
            this.panelDatosColaborador = new System.Windows.Forms.Panel();
            this.txtIDColab = new System.Windows.Forms.TextBox();
            this.lblDatosColaborador = new System.Windows.Forms.Label();
            this.lblIDColab = new System.Windows.Forms.Label();
            this.lblDNI = new System.Windows.Forms.Label();
            this.lblNombreColab = new System.Windows.Forms.Label();
            this.txtGerencia = new System.Windows.Forms.TextBox();
            this.txtNombreColab = new System.Windows.Forms.TextBox();
            this.txtCargo = new System.Windows.Forms.TextBox();
            this.lblCargo = new System.Windows.Forms.Label();
            this.txtDNI = new System.Windows.Forms.TextBox();
            this.lblGerencia = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.dgvMisObjetivos)).BeginInit();
            this.panelDatosColaborador.SuspendLayout();
            this.SuspendLayout();
            // 
            // btnEnviar
            // 
            this.btnEnviar.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(157)))), ((int)(((byte)(6)))), ((int)(((byte)(32)))));
            this.btnEnviar.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnEnviar.Font = new System.Drawing.Font("Century Gothic", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnEnviar.ForeColor = System.Drawing.Color.White;
            this.btnEnviar.Location = new System.Drawing.Point(227, 665);
            this.btnEnviar.Name = "btnEnviar";
            this.btnEnviar.Size = new System.Drawing.Size(158, 26);
            this.btnEnviar.TabIndex = 8;
            this.btnEnviar.Text = "Enviar";
            this.btnEnviar.UseVisualStyleBackColor = false;
            this.btnEnviar.Click += new System.EventHandler(this.btnEnviar_Click);
            // 
            // btnVerDetalle
            // 
            this.btnVerDetalle.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(157)))), ((int)(((byte)(6)))), ((int)(((byte)(32)))));
            this.btnVerDetalle.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnVerDetalle.Font = new System.Drawing.Font("Century Gothic", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnVerDetalle.ForeColor = System.Drawing.Color.White;
            this.btnVerDetalle.Location = new System.Drawing.Point(928, 665);
            this.btnVerDetalle.Name = "btnVerDetalle";
            this.btnVerDetalle.Size = new System.Drawing.Size(158, 26);
            this.btnVerDetalle.TabIndex = 9;
            this.btnVerDetalle.Text = "Ver detalle";
            this.btnVerDetalle.UseVisualStyleBackColor = false;
            this.btnVerDetalle.Click += new System.EventHandler(this.btnVerDetalle_Click);
            // 
            // dgvMisObjetivos
            // 
            this.dgvMisObjetivos.AllowUserToAddRows = false;
            this.dgvMisObjetivos.AllowUserToDeleteRows = false;
            this.dgvMisObjetivos.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.dgvMisObjetivos.AutoSizeRowsMode = System.Windows.Forms.DataGridViewAutoSizeRowsMode.AllCells;
            this.dgvMisObjetivos.BackgroundColor = System.Drawing.Color.White;
            this.dgvMisObjetivos.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.dgvMisObjetivos.ColumnHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.None;
            dataGridViewCellStyle1.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(66)))), ((int)(((byte)(122)))));
            dataGridViewCellStyle1.Font = new System.Drawing.Font("Century Gothic", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle1.ForeColor = System.Drawing.Color.White;
            dataGridViewCellStyle1.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle1.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle1.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dgvMisObjetivos.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle1;
            this.dgvMisObjetivos.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvMisObjetivos.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.Numero,
            this.Descripcion,
            this.Peso,
            this.Estado});
            this.dgvMisObjetivos.EnableHeadersVisualStyles = false;
            this.dgvMisObjetivos.Location = new System.Drawing.Point(22, 194);
            this.dgvMisObjetivos.MultiSelect = false;
            this.dgvMisObjetivos.Name = "dgvMisObjetivos";
            this.dgvMisObjetivos.ReadOnly = true;
            dataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle2.BackColor = System.Drawing.Color.White;
            dataGridViewCellStyle2.Font = new System.Drawing.Font("Century Gothic", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle2.ForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle2.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle2.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle2.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dgvMisObjetivos.RowHeadersDefaultCellStyle = dataGridViewCellStyle2;
            this.dgvMisObjetivos.RowHeadersVisible = false;
            dataGridViewCellStyle3.BackColor = System.Drawing.Color.White;
            dataGridViewCellStyle3.Font = new System.Drawing.Font("Century Gothic", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle3.SelectionBackColor = System.Drawing.Color.LightGray;
            dataGridViewCellStyle3.SelectionForeColor = System.Drawing.Color.Black;
            this.dgvMisObjetivos.RowsDefaultCellStyle = dataGridViewCellStyle3;
            this.dgvMisObjetivos.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dgvMisObjetivos.Size = new System.Drawing.Size(1073, 417);
            this.dgvMisObjetivos.TabIndex = 7;
            // 
            // Numero
            // 
            this.Numero.DataPropertyName = "Numero";
            this.Numero.HeaderText = "Numero";
            this.Numero.Name = "Numero";
            this.Numero.ReadOnly = true;
            this.Numero.Resizable = System.Windows.Forms.DataGridViewTriState.False;
            this.Numero.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.Programmatic;
            this.Numero.Width = 70;
            // 
            // Descripcion
            // 
            this.Descripcion.DataPropertyName = "Descripcion";
            this.Descripcion.HeaderText = "Descripcion";
            this.Descripcion.Name = "Descripcion";
            this.Descripcion.ReadOnly = true;
            this.Descripcion.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.Programmatic;
            this.Descripcion.Width = 700;
            // 
            // Peso
            // 
            this.Peso.DataPropertyName = "Peso";
            this.Peso.HeaderText = "Peso";
            this.Peso.Name = "Peso";
            this.Peso.ReadOnly = true;
            this.Peso.Resizable = System.Windows.Forms.DataGridViewTriState.False;
            this.Peso.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.Programmatic;
            // 
            // Estado
            // 
            this.Estado.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.None;
            this.Estado.DataPropertyName = "Estado";
            this.Estado.HeaderText = "Estado";
            this.Estado.Name = "Estado";
            this.Estado.ReadOnly = true;
            this.Estado.Resizable = System.Windows.Forms.DataGridViewTriState.False;
            this.Estado.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.Programmatic;
            this.Estado.Width = 200;
            // 
            // lblValidarObjetivos
            // 
            this.lblValidarObjetivos.AutoSize = true;
            this.lblValidarObjetivos.Font = new System.Drawing.Font("Century Gothic", 36F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblValidarObjetivos.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(66)))), ((int)(((byte)(122)))));
            this.lblValidarObjetivos.Location = new System.Drawing.Point(12, 9);
            this.lblValidarObjetivos.Name = "lblValidarObjetivos";
            this.lblValidarObjetivos.Size = new System.Drawing.Size(426, 56);
            this.lblValidarObjetivos.TabIndex = 12;
            this.lblValidarObjetivos.Text = "Validar Objetivos";
            // 
            // btnRegresar
            // 
            this.btnRegresar.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(157)))), ((int)(((byte)(6)))), ((int)(((byte)(32)))));
            this.btnRegresar.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnRegresar.Font = new System.Drawing.Font("Century Gothic", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnRegresar.ForeColor = System.Drawing.Color.White;
            this.btnRegresar.Location = new System.Drawing.Point(29, 665);
            this.btnRegresar.Name = "btnRegresar";
            this.btnRegresar.Size = new System.Drawing.Size(158, 26);
            this.btnRegresar.TabIndex = 23;
            this.btnRegresar.Text = "Regresar";
            this.btnRegresar.UseVisualStyleBackColor = false;
            this.btnRegresar.Click += new System.EventHandler(this.btnRegresar_Click);
            // 
            // panelDatosColaborador
            // 
            this.panelDatosColaborador.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(66)))), ((int)(((byte)(122)))));
            this.panelDatosColaborador.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.panelDatosColaborador.Controls.Add(this.txtIDColab);
            this.panelDatosColaborador.Controls.Add(this.lblDatosColaborador);
            this.panelDatosColaborador.Controls.Add(this.lblIDColab);
            this.panelDatosColaborador.Controls.Add(this.lblDNI);
            this.panelDatosColaborador.Controls.Add(this.lblNombreColab);
            this.panelDatosColaborador.Controls.Add(this.txtGerencia);
            this.panelDatosColaborador.Controls.Add(this.txtNombreColab);
            this.panelDatosColaborador.Controls.Add(this.txtCargo);
            this.panelDatosColaborador.Controls.Add(this.lblCargo);
            this.panelDatosColaborador.Controls.Add(this.txtDNI);
            this.panelDatosColaborador.Controls.Add(this.lblGerencia);
            this.panelDatosColaborador.Location = new System.Drawing.Point(0, 68);
            this.panelDatosColaborador.Name = "panelDatosColaborador";
            this.panelDatosColaborador.Size = new System.Drawing.Size(1123, 120);
            this.panelDatosColaborador.TabIndex = 62;
            // 
            // txtIDColab
            // 
            this.txtIDColab.Enabled = false;
            this.txtIDColab.Location = new System.Drawing.Point(154, 48);
            this.txtIDColab.Name = "txtIDColab";
            this.txtIDColab.Size = new System.Drawing.Size(339, 20);
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
            this.lblDNI.Location = new System.Drawing.Point(858, 48);
            this.lblDNI.Name = "lblDNI";
            this.lblDNI.Size = new System.Drawing.Size(52, 24);
            this.lblDNI.TabIndex = 59;
            this.lblDNI.Text = "DNI:";
            // 
            // lblNombreColab
            // 
            this.lblNombreColab.AutoSize = true;
            this.lblNombreColab.Font = new System.Drawing.Font("Century Gothic", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblNombreColab.ForeColor = System.Drawing.Color.White;
            this.lblNombreColab.Location = new System.Drawing.Point(32, 83);
            this.lblNombreColab.Name = "lblNombreColab";
            this.lblNombreColab.Size = new System.Drawing.Size(100, 24);
            this.lblNombreColab.TabIndex = 52;
            this.lblNombreColab.Text = "Nombre:";
            // 
            // txtGerencia
            // 
            this.txtGerencia.Enabled = false;
            this.txtGerencia.Location = new System.Drawing.Point(637, 87);
            this.txtGerencia.Name = "txtGerencia";
            this.txtGerencia.Size = new System.Drawing.Size(209, 20);
            this.txtGerencia.TabIndex = 58;
            // 
            // txtNombreColab
            // 
            this.txtNombreColab.Enabled = false;
            this.txtNombreColab.Location = new System.Drawing.Point(154, 87);
            this.txtNombreColab.Name = "txtNombreColab";
            this.txtNombreColab.Size = new System.Drawing.Size(339, 20);
            this.txtNombreColab.TabIndex = 53;
            // 
            // txtCargo
            // 
            this.txtCargo.Enabled = false;
            this.txtCargo.Location = new System.Drawing.Point(637, 48);
            this.txtCargo.Name = "txtCargo";
            this.txtCargo.Size = new System.Drawing.Size(209, 20);
            this.txtCargo.TabIndex = 57;
            // 
            // lblCargo
            // 
            this.lblCargo.AutoSize = true;
            this.lblCargo.Font = new System.Drawing.Font("Century Gothic", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblCargo.ForeColor = System.Drawing.Color.White;
            this.lblCargo.Location = new System.Drawing.Point(508, 44);
            this.lblCargo.Name = "lblCargo";
            this.lblCargo.Size = new System.Drawing.Size(80, 24);
            this.lblCargo.TabIndex = 54;
            this.lblCargo.Text = "Cargo:";
            // 
            // txtDNI
            // 
            this.txtDNI.Enabled = false;
            this.txtDNI.Location = new System.Drawing.Point(916, 50);
            this.txtDNI.Name = "txtDNI";
            this.txtDNI.Size = new System.Drawing.Size(177, 20);
            this.txtDNI.TabIndex = 56;
            // 
            // lblGerencia
            // 
            this.lblGerencia.AutoSize = true;
            this.lblGerencia.Font = new System.Drawing.Font("Century Gothic", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblGerencia.ForeColor = System.Drawing.Color.White;
            this.lblGerencia.Location = new System.Drawing.Point(508, 83);
            this.lblGerencia.Name = "lblGerencia";
            this.lblGerencia.Size = new System.Drawing.Size(111, 24);
            this.lblGerencia.TabIndex = 55;
            this.lblGerencia.Text = "Gerencia:";
            // 
            // frmPlanRealizarRevision
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(1107, 755);
            this.Controls.Add(this.panelDatosColaborador);
            this.Controls.Add(this.btnRegresar);
            this.Controls.Add(this.lblValidarObjetivos);
            this.Controls.Add(this.btnEnviar);
            this.Controls.Add(this.btnVerDetalle);
            this.Controls.Add(this.dgvMisObjetivos);
            this.Name = "frmPlanRealizarRevision";
            this.Text = "frmPlanRealizarRevision";
            this.Load += new System.EventHandler(this.frmPlanRealizarRevision_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dgvMisObjetivos)).EndInit();
            this.panelDatosColaborador.ResumeLayout(false);
            this.panelDatosColaborador.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btnEnviar;
        private System.Windows.Forms.Button btnVerDetalle;
        private System.Windows.Forms.DataGridView dgvMisObjetivos;
        private System.Windows.Forms.DataGridViewTextBoxColumn Numero;
        private System.Windows.Forms.DataGridViewTextBoxColumn Descripcion;
        private System.Windows.Forms.DataGridViewTextBoxColumn Peso;
        private System.Windows.Forms.DataGridViewTextBoxColumn Estado;
        private System.Windows.Forms.Label lblValidarObjetivos;
        private System.Windows.Forms.Button btnRegresar;
        private System.Windows.Forms.Panel panelDatosColaborador;
        private System.Windows.Forms.TextBox txtIDColab;
        private System.Windows.Forms.Label lblDatosColaborador;
        private System.Windows.Forms.Label lblIDColab;
        private System.Windows.Forms.Label lblDNI;
        private System.Windows.Forms.Label lblNombreColab;
        private System.Windows.Forms.TextBox txtGerencia;
        private System.Windows.Forms.TextBox txtNombreColab;
        private System.Windows.Forms.TextBox txtCargo;
        private System.Windows.Forms.Label lblCargo;
        private System.Windows.Forms.TextBox txtDNI;
        private System.Windows.Forms.Label lblGerencia;
    }
}