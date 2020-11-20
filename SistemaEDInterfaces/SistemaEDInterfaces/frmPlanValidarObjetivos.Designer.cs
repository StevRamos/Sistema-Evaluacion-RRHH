namespace SistemaEDInterfaces
{
    partial class frmPlanValidarObjetivos
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
            this.lblValidarObjetivos = new System.Windows.Forms.Label();
            this.dgvListaTrabajadores = new System.Windows.Forms.DataGridView();
            this.ID = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Nombre = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.DNI = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.btnRealizarRevision = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.dgvListaTrabajadores)).BeginInit();
            this.SuspendLayout();
            // 
            // lblValidarObjetivos
            // 
            this.lblValidarObjetivos.AutoSize = true;
            this.lblValidarObjetivos.Font = new System.Drawing.Font("Century Gothic", 36F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblValidarObjetivos.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(66)))), ((int)(((byte)(122)))));
            this.lblValidarObjetivos.Location = new System.Drawing.Point(12, 9);
            this.lblValidarObjetivos.Name = "lblValidarObjetivos";
            this.lblValidarObjetivos.Size = new System.Drawing.Size(426, 56);
            this.lblValidarObjetivos.TabIndex = 1;
            this.lblValidarObjetivos.Text = "Validar Objetivos";
            // 
            // dgvListaTrabajadores
            // 
            this.dgvListaTrabajadores.AllowUserToAddRows = false;
            this.dgvListaTrabajadores.AllowUserToDeleteRows = false;
            this.dgvListaTrabajadores.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.dgvListaTrabajadores.AutoSizeRowsMode = System.Windows.Forms.DataGridViewAutoSizeRowsMode.AllCells;
            this.dgvListaTrabajadores.BackgroundColor = System.Drawing.Color.White;
            this.dgvListaTrabajadores.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.dgvListaTrabajadores.ColumnHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.None;
            dataGridViewCellStyle1.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(66)))), ((int)(((byte)(122)))));
            dataGridViewCellStyle1.Font = new System.Drawing.Font("Century Gothic", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle1.ForeColor = System.Drawing.Color.White;
            dataGridViewCellStyle1.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle1.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle1.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dgvListaTrabajadores.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle1;
            this.dgvListaTrabajadores.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvListaTrabajadores.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.ID,
            this.Nombre,
            this.DNI});
            this.dgvListaTrabajadores.EnableHeadersVisualStyles = false;
            this.dgvListaTrabajadores.Location = new System.Drawing.Point(17, 137);
            this.dgvListaTrabajadores.MultiSelect = false;
            this.dgvListaTrabajadores.Name = "dgvListaTrabajadores";
            this.dgvListaTrabajadores.ReadOnly = true;
            dataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle2.BackColor = System.Drawing.Color.White;
            dataGridViewCellStyle2.Font = new System.Drawing.Font("Century Gothic", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle2.ForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle2.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle2.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle2.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dgvListaTrabajadores.RowHeadersDefaultCellStyle = dataGridViewCellStyle2;
            this.dgvListaTrabajadores.RowHeadersVisible = false;
            dataGridViewCellStyle3.BackColor = System.Drawing.Color.White;
            dataGridViewCellStyle3.Font = new System.Drawing.Font("Century Gothic", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle3.SelectionBackColor = System.Drawing.Color.LightGray;
            dataGridViewCellStyle3.SelectionForeColor = System.Drawing.Color.Black;
            this.dgvListaTrabajadores.RowsDefaultCellStyle = dataGridViewCellStyle3;
            this.dgvListaTrabajadores.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dgvListaTrabajadores.Size = new System.Drawing.Size(1073, 480);
            this.dgvListaTrabajadores.TabIndex = 2;
            // 
            // ID
            // 
            this.ID.DataPropertyName = "idColaborador";
            this.ID.HeaderText = "ID";
            this.ID.Name = "ID";
            this.ID.ReadOnly = true;
            this.ID.Resizable = System.Windows.Forms.DataGridViewTriState.False;
            this.ID.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.Programmatic;
            // 
            // Nombre
            // 
            this.Nombre.DataPropertyName = "nombres";
            this.Nombre.HeaderText = "Nombre";
            this.Nombre.Name = "Nombre";
            this.Nombre.ReadOnly = true;
            this.Nombre.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.Programmatic;
            this.Nombre.Width = 550;
            // 
            // DNI
            // 
            this.DNI.DataPropertyName = "dni";
            this.DNI.HeaderText = "DNI";
            this.DNI.Name = "DNI";
            this.DNI.ReadOnly = true;
            this.DNI.Resizable = System.Windows.Forms.DataGridViewTriState.False;
            this.DNI.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.Programmatic;
            // 
            // btnRealizarRevision
            // 
            this.btnRealizarRevision.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(157)))), ((int)(((byte)(6)))), ((int)(((byte)(32)))));
            this.btnRealizarRevision.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnRealizarRevision.Font = new System.Drawing.Font("Century Gothic", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnRealizarRevision.ForeColor = System.Drawing.Color.White;
            this.btnRealizarRevision.Location = new System.Drawing.Point(17, 623);
            this.btnRealizarRevision.Name = "btnRealizarRevision";
            this.btnRealizarRevision.Size = new System.Drawing.Size(158, 26);
            this.btnRealizarRevision.TabIndex = 28;
            this.btnRealizarRevision.Text = "Realizar Revisión";
            this.btnRealizarRevision.UseVisualStyleBackColor = false;
            this.btnRealizarRevision.Click += new System.EventHandler(this.btnRealizarRevision_Click);
            // 
            // frmPlanValidarObjetivos
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(1107, 749);
            this.Controls.Add(this.btnRealizarRevision);
            this.Controls.Add(this.dgvListaTrabajadores);
            this.Controls.Add(this.lblValidarObjetivos);
            this.Name = "frmPlanValidarObjetivos";
            this.Text = "frmPlanValidarObjetivos";
            this.Load += new System.EventHandler(this.frmPlanValidarObjetivos_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dgvListaTrabajadores)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lblValidarObjetivos;
        private System.Windows.Forms.DataGridView dgvListaTrabajadores;
        private System.Windows.Forms.Button btnRealizarRevision;
        private System.Windows.Forms.DataGridViewTextBoxColumn ID;
        private System.Windows.Forms.DataGridViewTextBoxColumn Nombre;
        private System.Windows.Forms.DataGridViewTextBoxColumn DNI;
    }
}