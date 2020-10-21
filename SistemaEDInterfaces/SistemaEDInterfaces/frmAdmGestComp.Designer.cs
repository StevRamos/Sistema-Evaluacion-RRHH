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
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle7 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle8 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle9 = new System.Windows.Forms.DataGridViewCellStyle();
            this.btnCrearCompetencia = new System.Windows.Forms.Button();
            this.btnCargarMasiva = new System.Windows.Forms.Button();
            this.lblGestionarComp = new System.Windows.Forms.Label();
            this.dgvMisObjetivos = new System.Windows.Forms.DataGridView();
            this.Código = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Nombre = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Descripción = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Cargo = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Peso = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Periodo = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Estado = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Opciones = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.lblBuscarComp = new System.Windows.Forms.Label();
            this.textBox1 = new System.Windows.Forms.TextBox();
            ((System.ComponentModel.ISupportInitialize)(this.dgvMisObjetivos)).BeginInit();
            this.SuspendLayout();
            // 
            // btnCrearCompetencia
            // 
            this.btnCrearCompetencia.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(157)))), ((int)(((byte)(6)))), ((int)(((byte)(32)))));
            this.btnCrearCompetencia.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnCrearCompetencia.Font = new System.Drawing.Font("Century Gothic", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnCrearCompetencia.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.btnCrearCompetencia.Location = new System.Drawing.Point(40, 162);
            this.btnCrearCompetencia.Name = "btnCrearCompetencia";
            this.btnCrearCompetencia.Size = new System.Drawing.Size(250, 32);
            this.btnCrearCompetencia.TabIndex = 0;
            this.btnCrearCompetencia.Text = " Crear Competencia +";
            this.btnCrearCompetencia.UseVisualStyleBackColor = false;
            this.btnCrearCompetencia.Click += new System.EventHandler(this.button1_Click);
            // 
            // btnCargarMasiva
            // 
            this.btnCargarMasiva.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(157)))), ((int)(((byte)(6)))), ((int)(((byte)(32)))));
            this.btnCargarMasiva.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnCargarMasiva.Font = new System.Drawing.Font("Century Gothic", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnCargarMasiva.ForeColor = System.Drawing.Color.White;
            this.btnCargarMasiva.Location = new System.Drawing.Point(424, 162);
            this.btnCargarMasiva.Name = "btnCargarMasiva";
            this.btnCargarMasiva.Size = new System.Drawing.Size(250, 32);
            this.btnCargarMasiva.TabIndex = 1;
            this.btnCargarMasiva.Text = " Cargar Masivamente";
            this.btnCargarMasiva.UseVisualStyleBackColor = false;
            this.btnCargarMasiva.Click += new System.EventHandler(this.button2_Click);
            // 
            // lblGestionarComp
            // 
            this.lblGestionarComp.Font = new System.Drawing.Font("Century Gothic", 36F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblGestionarComp.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(66)))), ((int)(((byte)(122)))));
            this.lblGestionarComp.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.lblGestionarComp.Location = new System.Drawing.Point(12, 9);
            this.lblGestionarComp.Name = "lblGestionarComp";
            this.lblGestionarComp.Size = new System.Drawing.Size(836, 97);
            this.lblGestionarComp.TabIndex = 2;
            this.lblGestionarComp.Text = "Gestionar Competencias";
            this.lblGestionarComp.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.lblGestionarComp.Click += new System.EventHandler(this.label1_Click);
            // 
            // dgvMisObjetivos
            // 
            this.dgvMisObjetivos.AllowUserToOrderColumns = true;
            this.dgvMisObjetivos.AllowUserToResizeColumns = false;
            this.dgvMisObjetivos.AllowUserToResizeRows = false;
            this.dgvMisObjetivos.AutoSizeRowsMode = System.Windows.Forms.DataGridViewAutoSizeRowsMode.AllCells;
            this.dgvMisObjetivos.BackgroundColor = System.Drawing.Color.White;
            this.dgvMisObjetivos.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.dgvMisObjetivos.ColumnHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.None;
            dataGridViewCellStyle7.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle7.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(66)))), ((int)(((byte)(122)))));
            dataGridViewCellStyle7.Font = new System.Drawing.Font("Century Gothic", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle7.ForeColor = System.Drawing.Color.White;
            dataGridViewCellStyle7.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle7.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle7.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dgvMisObjetivos.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle7;
            this.dgvMisObjetivos.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvMisObjetivos.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.Código,
            this.Nombre,
            this.Descripción,
            this.Cargo,
            this.Peso,
            this.Periodo,
            this.Estado,
            this.Opciones});
            this.dgvMisObjetivos.EnableHeadersVisualStyles = false;
            this.dgvMisObjetivos.Location = new System.Drawing.Point(32, 232);
            this.dgvMisObjetivos.Margin = new System.Windows.Forms.Padding(4);
            this.dgvMisObjetivos.Name = "dgvMisObjetivos";
            dataGridViewCellStyle8.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle8.BackColor = System.Drawing.Color.White;
            dataGridViewCellStyle8.Font = new System.Drawing.Font("Century Gothic", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle8.ForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle8.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle8.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle8.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dgvMisObjetivos.RowHeadersDefaultCellStyle = dataGridViewCellStyle8;
            this.dgvMisObjetivos.RowHeadersVisible = false;
            this.dgvMisObjetivos.RowHeadersWidth = 51;
            dataGridViewCellStyle9.BackColor = System.Drawing.Color.White;
            dataGridViewCellStyle9.SelectionBackColor = System.Drawing.Color.White;
            dataGridViewCellStyle9.SelectionForeColor = System.Drawing.Color.White;
            this.dgvMisObjetivos.RowsDefaultCellStyle = dataGridViewCellStyle9;
            this.dgvMisObjetivos.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dgvMisObjetivos.Size = new System.Drawing.Size(1431, 591);
            this.dgvMisObjetivos.TabIndex = 3;
            this.dgvMisObjetivos.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgvMisObjetivos_CellContentClick);
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
            this.Nombre.Width = 125;
            // 
            // Descripción
            // 
            this.Descripción.HeaderText = "Descripción";
            this.Descripción.MinimumWidth = 6;
            this.Descripción.Name = "Descripción";
            this.Descripción.Width = 350;
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
            // Opciones
            // 
            this.Opciones.HeaderText = "Opciones";
            this.Opciones.MinimumWidth = 6;
            this.Opciones.Name = "Opciones";
            this.Opciones.Width = 125;
            // 
            // lblBuscarComp
            // 
            this.lblBuscarComp.AutoSize = true;
            this.lblBuscarComp.Font = new System.Drawing.Font("Century Gothic", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblBuscarComp.Location = new System.Drawing.Point(918, 169);
            this.lblBuscarComp.Name = "lblBuscarComp";
            this.lblBuscarComp.Size = new System.Drawing.Size(74, 19);
            this.lblBuscarComp.TabIndex = 4;
            this.lblBuscarComp.Text = "Buscar: ";
            // 
            // textBox1
            // 
            this.textBox1.Location = new System.Drawing.Point(1026, 166);
            this.textBox1.Name = "textBox1";
            this.textBox1.Size = new System.Drawing.Size(242, 22);
            this.textBox1.TabIndex = 5;
            // 
            // frmAdmGestComp
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(1476, 929);
            this.Controls.Add(this.textBox1);
            this.Controls.Add(this.lblBuscarComp);
            this.Controls.Add(this.dgvMisObjetivos);
            this.Controls.Add(this.lblGestionarComp);
            this.Controls.Add(this.btnCargarMasiva);
            this.Controls.Add(this.btnCrearCompetencia);
            this.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.Name = "frmAdmGestComp";
            this.Text = "frmAdmGestComp";
            this.Load += new System.EventHandler(this.frmAdmGestComp_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dgvMisObjetivos)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btnCrearCompetencia;
        private System.Windows.Forms.Button btnCargarMasiva;
        private System.Windows.Forms.Label lblGestionarComp;
        private System.Windows.Forms.DataGridView dgvMisObjetivos;
        private System.Windows.Forms.DataGridViewTextBoxColumn Código;
        private System.Windows.Forms.DataGridViewTextBoxColumn Nombre;
        private System.Windows.Forms.DataGridViewTextBoxColumn Descripción;
        private System.Windows.Forms.DataGridViewTextBoxColumn Cargo;
        private System.Windows.Forms.DataGridViewTextBoxColumn Peso;
        private System.Windows.Forms.DataGridViewTextBoxColumn Periodo;
        private System.Windows.Forms.DataGridViewTextBoxColumn Estado;
        private System.Windows.Forms.DataGridViewTextBoxColumn Opciones;
        private System.Windows.Forms.Label lblBuscarComp;
        private System.Windows.Forms.TextBox textBox1;
    }
}