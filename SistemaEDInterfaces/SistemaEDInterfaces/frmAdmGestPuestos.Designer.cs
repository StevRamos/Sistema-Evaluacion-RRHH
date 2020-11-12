namespace SistemaEDInterfaces
{
    partial class frmAdmGestPuestos
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
            this.cmbGestCargosNomGeren = new System.Windows.Forms.ComboBox();
            this.dgbCargos = new System.Windows.Forms.DataGridView();
            this.label2 = new System.Windows.Forms.Label();
            this.btnGestCargoCargaMav = new System.Windows.Forms.Button();
            this.btnGestPuestoEliminar = new System.Windows.Forms.Button();
            this.btnGestCargosBuscar = new System.Windows.Forms.Button();
            this.dataGridViewTextBoxColumn1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn2 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn3 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            ((System.ComponentModel.ISupportInitialize)(this.dgbCargos)).BeginInit();
            this.SuspendLayout();
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Century Gothic", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(680, 126);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(96, 19);
            this.label3.TabIndex = 37;
            this.label3.Text = "Gerencia :";
            // 
            // cmbGestCargosNomGeren
            // 
            this.cmbGestCargosNomGeren.FormattingEnabled = true;
            this.cmbGestCargosNomGeren.Location = new System.Drawing.Point(684, 159);
            this.cmbGestCargosNomGeren.Margin = new System.Windows.Forms.Padding(4);
            this.cmbGestCargosNomGeren.Name = "cmbGestCargosNomGeren";
            this.cmbGestCargosNomGeren.Size = new System.Drawing.Size(208, 24);
            this.cmbGestCargosNomGeren.TabIndex = 35;
            // 
            // dgbCargos
            // 
            this.dgbCargos.AllowUserToAddRows = false;
            this.dgbCargos.AllowUserToDeleteRows = false;
            this.dgbCargos.AllowUserToResizeColumns = false;
            this.dgbCargos.AllowUserToResizeRows = false;
            this.dgbCargos.AutoSizeRowsMode = System.Windows.Forms.DataGridViewAutoSizeRowsMode.AllCells;
            this.dgbCargos.BackgroundColor = System.Drawing.Color.White;
            this.dgbCargos.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.dgbCargos.ColumnHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.None;
            dataGridViewCellStyle1.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(66)))), ((int)(((byte)(122)))));
            dataGridViewCellStyle1.Font = new System.Drawing.Font("Century Gothic", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle1.ForeColor = System.Drawing.Color.White;
            dataGridViewCellStyle1.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle1.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle1.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dgbCargos.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle1;
            this.dgbCargos.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgbCargos.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.dataGridViewTextBoxColumn1,
            this.dataGridViewTextBoxColumn2,
            this.dataGridViewTextBoxColumn3});
            this.dgbCargos.EnableHeadersVisualStyles = false;
            this.dgbCargos.Location = new System.Drawing.Point(25, 229);
            this.dgbCargos.Margin = new System.Windows.Forms.Padding(4);
            this.dgbCargos.Name = "dgbCargos";
            this.dgbCargos.ReadOnly = true;
            dataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle2.BackColor = System.Drawing.Color.White;
            dataGridViewCellStyle2.Font = new System.Drawing.Font("Century Gothic", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle2.ForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle2.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle2.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle2.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dgbCargos.RowHeadersDefaultCellStyle = dataGridViewCellStyle2;
            this.dgbCargos.RowHeadersVisible = false;
            this.dgbCargos.RowHeadersWidth = 51;
            dataGridViewCellStyle3.BackColor = System.Drawing.Color.White;
            dataGridViewCellStyle3.Font = new System.Drawing.Font("Century Gothic", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle3.SelectionBackColor = System.Drawing.Color.LightGray;
            dataGridViewCellStyle3.SelectionForeColor = System.Drawing.Color.Black;
            this.dgbCargos.RowsDefaultCellStyle = dataGridViewCellStyle3;
            this.dgbCargos.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dgbCargos.Size = new System.Drawing.Size(1431, 591);
            this.dgbCargos.TabIndex = 31;
            this.dgbCargos.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridView1_CellContentClick);
            // 
            // label2
            // 
            this.label2.Font = new System.Drawing.Font("Century Gothic", 36F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(66)))), ((int)(((byte)(122)))));
            this.label2.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.label2.Location = new System.Drawing.Point(12, 9);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(752, 97);
            this.label2.TabIndex = 30;
            this.label2.Text = "Gestionar Cargos";
            this.label2.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.label2.Click += new System.EventHandler(this.label2_Click);
            // 
            // btnGestCargoCargaMav
            // 
            this.btnGestCargoCargaMav.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(157)))), ((int)(((byte)(6)))), ((int)(((byte)(32)))));
            this.btnGestCargoCargaMav.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnGestCargoCargaMav.Font = new System.Drawing.Font("Century Gothic", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnGestCargoCargaMav.ForeColor = System.Drawing.Color.White;
            this.btnGestCargoCargaMav.Location = new System.Drawing.Point(25, 155);
            this.btnGestCargoCargaMav.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.btnGestCargoCargaMav.Name = "btnGestCargoCargaMav";
            this.btnGestCargoCargaMav.Size = new System.Drawing.Size(251, 32);
            this.btnGestCargoCargaMav.TabIndex = 29;
            this.btnGestCargoCargaMav.Text = " Cargar Masivamente";
            this.btnGestCargoCargaMav.UseVisualStyleBackColor = false;
            this.btnGestCargoCargaMav.Click += new System.EventHandler(this.btnGestCargoCargaMav_Click);
            // 
            // btnGestPuestoEliminar
            // 
            this.btnGestPuestoEliminar.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(157)))), ((int)(((byte)(6)))), ((int)(((byte)(32)))));
            this.btnGestPuestoEliminar.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnGestPuestoEliminar.Font = new System.Drawing.Font("Century Gothic", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnGestPuestoEliminar.ForeColor = System.Drawing.Color.White;
            this.btnGestPuestoEliminar.Location = new System.Drawing.Point(25, 854);
            this.btnGestPuestoEliminar.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.btnGestPuestoEliminar.Name = "btnGestPuestoEliminar";
            this.btnGestPuestoEliminar.Size = new System.Drawing.Size(251, 32);
            this.btnGestPuestoEliminar.TabIndex = 38;
            this.btnGestPuestoEliminar.Text = "Eliminar";
            this.btnGestPuestoEliminar.UseVisualStyleBackColor = false;
            this.btnGestPuestoEliminar.Click += new System.EventHandler(this.btnGestPuestoEliminar_Click);
            // 
            // btnGestCargosBuscar
            // 
            this.btnGestCargosBuscar.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(157)))), ((int)(((byte)(6)))), ((int)(((byte)(32)))));
            this.btnGestCargosBuscar.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnGestCargosBuscar.Font = new System.Drawing.Font("Century Gothic", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnGestCargosBuscar.ForeColor = System.Drawing.Color.White;
            this.btnGestCargosBuscar.Location = new System.Drawing.Point(1102, 151);
            this.btnGestCargosBuscar.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.btnGestCargosBuscar.Name = "btnGestCargosBuscar";
            this.btnGestCargosBuscar.Size = new System.Drawing.Size(200, 32);
            this.btnGestCargosBuscar.TabIndex = 52;
            this.btnGestCargosBuscar.Text = "Buscar";
            this.btnGestCargosBuscar.UseVisualStyleBackColor = false;
            this.btnGestCargosBuscar.Click += new System.EventHandler(this.btnGestCargosBuscar_Click);
            // 
            // dataGridViewTextBoxColumn1
            // 
            this.dataGridViewTextBoxColumn1.DataPropertyName = "idPuestoTrabajo";
            this.dataGridViewTextBoxColumn1.HeaderText = "ID";
            this.dataGridViewTextBoxColumn1.MinimumWidth = 6;
            this.dataGridViewTextBoxColumn1.Name = "dataGridViewTextBoxColumn1";
            this.dataGridViewTextBoxColumn1.ReadOnly = true;
            this.dataGridViewTextBoxColumn1.Width = 125;
            // 
            // dataGridViewTextBoxColumn2
            // 
            this.dataGridViewTextBoxColumn2.DataPropertyName = "nombre";
            this.dataGridViewTextBoxColumn2.HeaderText = "Nombre";
            this.dataGridViewTextBoxColumn2.MinimumWidth = 6;
            this.dataGridViewTextBoxColumn2.Name = "dataGridViewTextBoxColumn2";
            this.dataGridViewTextBoxColumn2.ReadOnly = true;
            this.dataGridViewTextBoxColumn2.Width = 300;
            // 
            // dataGridViewTextBoxColumn3
            // 
            this.dataGridViewTextBoxColumn3.DataPropertyName = "descripcion";
            this.dataGridViewTextBoxColumn3.HeaderText = "Descripción";
            this.dataGridViewTextBoxColumn3.MinimumWidth = 6;
            this.dataGridViewTextBoxColumn3.Name = "dataGridViewTextBoxColumn3";
            this.dataGridViewTextBoxColumn3.ReadOnly = true;
            this.dataGridViewTextBoxColumn3.Width = 700;
            // 
            // frmAdmGestPuestos
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(1476, 929);
            this.Controls.Add(this.btnGestCargosBuscar);
            this.Controls.Add(this.btnGestPuestoEliminar);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.cmbGestCargosNomGeren);
            this.Controls.Add(this.dgbCargos);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.btnGestCargoCargaMav);
            this.ForeColor = System.Drawing.SystemColors.ControlText;
            this.Margin = new System.Windows.Forms.Padding(4);
            this.Name = "frmAdmGestPuestos";
            this.Text = "frmAdmGestPuestos";
            ((System.ComponentModel.ISupportInitialize)(this.dgbCargos)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.ComboBox cmbGestCargosNomGeren;
        private System.Windows.Forms.DataGridView dgbCargos;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Button btnGestCargoCargaMav;
        private System.Windows.Forms.Button btnGestPuestoEliminar;
        private System.Windows.Forms.Button btnGestCargosBuscar;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn1;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn2;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn3;
    }
}