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
            this.lblGestionarPot = new System.Windows.Forms.Label();
            this.btnCargarMasivaPot = new System.Windows.Forms.Button();
            this.btnCrearPotencial = new System.Windows.Forms.Button();
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.lblBuscarComp = new System.Windows.Forms.Label();
            this.dgvPotenciales = new System.Windows.Forms.DataGridView();
            this.Código = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Nombre = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Descripción = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Cargo = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Peso = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Periodo = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Estado = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Opciones = new System.Windows.Forms.DataGridViewTextBoxColumn();
            ((System.ComponentModel.ISupportInitialize)(this.dgvPotenciales)).BeginInit();
            this.SuspendLayout();
            // 
            // lblGestionarPot
            // 
            this.lblGestionarPot.Font = new System.Drawing.Font("Century Gothic", 36F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblGestionarPot.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(66)))), ((int)(((byte)(122)))));
            this.lblGestionarPot.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.lblGestionarPot.Location = new System.Drawing.Point(12, 18);
            this.lblGestionarPot.Name = "lblGestionarPot";
            this.lblGestionarPot.Size = new System.Drawing.Size(836, 97);
            this.lblGestionarPot.TabIndex = 3;
            this.lblGestionarPot.Text = "Gestionar Potenciales";
            this.lblGestionarPot.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.lblGestionarPot.Click += new System.EventHandler(this.lblGestionarComp_Click);
            // 
            // btnCargarMasivaPot
            // 
            this.btnCargarMasivaPot.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(157)))), ((int)(((byte)(6)))), ((int)(((byte)(32)))));
            this.btnCargarMasivaPot.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnCargarMasivaPot.Font = new System.Drawing.Font("Century Gothic", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnCargarMasivaPot.ForeColor = System.Drawing.Color.White;
            this.btnCargarMasivaPot.Location = new System.Drawing.Point(406, 135);
            this.btnCargarMasivaPot.Name = "btnCargarMasivaPot";
            this.btnCargarMasivaPot.Size = new System.Drawing.Size(250, 32);
            this.btnCargarMasivaPot.TabIndex = 5;
            this.btnCargarMasivaPot.Text = " Cargar Masivamente";
            this.btnCargarMasivaPot.UseVisualStyleBackColor = false;
            // 
            // btnCrearPotencial
            // 
            this.btnCrearPotencial.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(157)))), ((int)(((byte)(6)))), ((int)(((byte)(32)))));
            this.btnCrearPotencial.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnCrearPotencial.Font = new System.Drawing.Font("Century Gothic", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnCrearPotencial.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.btnCrearPotencial.Location = new System.Drawing.Point(24, 135);
            this.btnCrearPotencial.Name = "btnCrearPotencial";
            this.btnCrearPotencial.Size = new System.Drawing.Size(250, 32);
            this.btnCrearPotencial.TabIndex = 4;
            this.btnCrearPotencial.Text = " Crear Potencial +";
            this.btnCrearPotencial.UseVisualStyleBackColor = false;
            // 
            // textBox1
            // 
            this.textBox1.Location = new System.Drawing.Point(882, 145);
            this.textBox1.Name = "textBox1";
            this.textBox1.Size = new System.Drawing.Size(242, 22);
            this.textBox1.TabIndex = 7;
            // 
            // lblBuscarComp
            // 
            this.lblBuscarComp.AutoSize = true;
            this.lblBuscarComp.Font = new System.Drawing.Font("Century Gothic", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblBuscarComp.Location = new System.Drawing.Point(774, 148);
            this.lblBuscarComp.Name = "lblBuscarComp";
            this.lblBuscarComp.Size = new System.Drawing.Size(74, 19);
            this.lblBuscarComp.TabIndex = 6;
            this.lblBuscarComp.Text = "Buscar: ";
            // 
            // dgvPotenciales
            // 
            this.dgvPotenciales.AllowUserToOrderColumns = true;
            this.dgvPotenciales.AllowUserToResizeColumns = false;
            this.dgvPotenciales.AllowUserToResizeRows = false;
            this.dgvPotenciales.AutoSizeRowsMode = System.Windows.Forms.DataGridViewAutoSizeRowsMode.AllCells;
            this.dgvPotenciales.BackgroundColor = System.Drawing.Color.White;
            this.dgvPotenciales.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.dgvPotenciales.ColumnHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.None;
            dataGridViewCellStyle1.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(66)))), ((int)(((byte)(122)))));
            dataGridViewCellStyle1.Font = new System.Drawing.Font("Century Gothic", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle1.ForeColor = System.Drawing.Color.White;
            dataGridViewCellStyle1.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle1.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle1.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dgvPotenciales.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle1;
            this.dgvPotenciales.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvPotenciales.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.Código,
            this.Nombre,
            this.Descripción,
            this.Cargo,
            this.Peso,
            this.Periodo,
            this.Estado,
            this.Opciones});
            this.dgvPotenciales.EnableHeadersVisualStyles = false;
            this.dgvPotenciales.Location = new System.Drawing.Point(24, 223);
            this.dgvPotenciales.Margin = new System.Windows.Forms.Padding(4);
            this.dgvPotenciales.Name = "dgvPotenciales";
            dataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle2.BackColor = System.Drawing.Color.White;
            dataGridViewCellStyle2.Font = new System.Drawing.Font("Century Gothic", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle2.ForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle2.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle2.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle2.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dgvPotenciales.RowHeadersDefaultCellStyle = dataGridViewCellStyle2;
            this.dgvPotenciales.RowHeadersVisible = false;
            this.dgvPotenciales.RowHeadersWidth = 51;
            dataGridViewCellStyle3.BackColor = System.Drawing.Color.White;
            dataGridViewCellStyle3.SelectionBackColor = System.Drawing.Color.White;
            dataGridViewCellStyle3.SelectionForeColor = System.Drawing.Color.White;
            this.dgvPotenciales.RowsDefaultCellStyle = dataGridViewCellStyle3;
            this.dgvPotenciales.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dgvPotenciales.Size = new System.Drawing.Size(1431, 591);
            this.dgvPotenciales.TabIndex = 8;
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
            // frmAdmGestPot
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(1476, 929);
            this.Controls.Add(this.dgvPotenciales);
            this.Controls.Add(this.textBox1);
            this.Controls.Add(this.lblBuscarComp);
            this.Controls.Add(this.btnCargarMasivaPot);
            this.Controls.Add(this.btnCrearPotencial);
            this.Controls.Add(this.lblGestionarPot);
            this.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.Name = "frmAdmGestPot";
            this.Text = "frmAdmGestPot";
            ((System.ComponentModel.ISupportInitialize)(this.dgvPotenciales)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lblGestionarPot;
        private System.Windows.Forms.Button btnCargarMasivaPot;
        private System.Windows.Forms.Button btnCrearPotencial;
        private System.Windows.Forms.TextBox textBox1;
        private System.Windows.Forms.Label lblBuscarComp;
        private System.Windows.Forms.DataGridView dgvPotenciales;
        private System.Windows.Forms.DataGridViewTextBoxColumn Código;
        private System.Windows.Forms.DataGridViewTextBoxColumn Nombre;
        private System.Windows.Forms.DataGridViewTextBoxColumn Descripción;
        private System.Windows.Forms.DataGridViewTextBoxColumn Cargo;
        private System.Windows.Forms.DataGridViewTextBoxColumn Peso;
        private System.Windows.Forms.DataGridViewTextBoxColumn Periodo;
        private System.Windows.Forms.DataGridViewTextBoxColumn Estado;
        private System.Windows.Forms.DataGridViewTextBoxColumn Opciones;
    }
}