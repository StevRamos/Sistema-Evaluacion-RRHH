namespace SistemaEDInterfaces
{
    partial class frmAdmGestGer
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
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle4 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle5 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle6 = new System.Windows.Forms.DataGridViewCellStyle();
            this.dgvGerencias = new System.Windows.Forms.DataGridView();
            this.dataGridViewTextBoxColumn1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn2 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn3 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn7 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.label2 = new System.Windows.Forms.Label();
            this.btnGestGerCargaMav = new System.Windows.Forms.Button();
            this.btnGestGerEliminar = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.dgvGerencias)).BeginInit();
            this.SuspendLayout();
            // 
            // dgvGerencias
            // 
            this.dgvGerencias.AllowUserToAddRows = false;
            this.dgvGerencias.AllowUserToDeleteRows = false;
            this.dgvGerencias.AllowUserToResizeColumns = false;
            this.dgvGerencias.AllowUserToResizeRows = false;
            this.dgvGerencias.AutoSizeRowsMode = System.Windows.Forms.DataGridViewAutoSizeRowsMode.AllCells;
            this.dgvGerencias.BackgroundColor = System.Drawing.Color.White;
            this.dgvGerencias.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.dgvGerencias.ColumnHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.None;
            dataGridViewCellStyle4.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle4.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(66)))), ((int)(((byte)(122)))));
            dataGridViewCellStyle4.Font = new System.Drawing.Font("Century Gothic", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle4.ForeColor = System.Drawing.Color.White;
            dataGridViewCellStyle4.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle4.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle4.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dgvGerencias.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle4;
            this.dgvGerencias.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvGerencias.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.dataGridViewTextBoxColumn1,
            this.dataGridViewTextBoxColumn2,
            this.dataGridViewTextBoxColumn3,
            this.dataGridViewTextBoxColumn7});
            this.dgvGerencias.EnableHeadersVisualStyles = false;
            this.dgvGerencias.Location = new System.Drawing.Point(25, 229);
            this.dgvGerencias.Margin = new System.Windows.Forms.Padding(4);
            this.dgvGerencias.Name = "dgvGerencias";
            dataGridViewCellStyle5.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle5.BackColor = System.Drawing.Color.White;
            dataGridViewCellStyle5.Font = new System.Drawing.Font("Century Gothic", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle5.ForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle5.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle5.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle5.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dgvGerencias.RowHeadersDefaultCellStyle = dataGridViewCellStyle5;
            this.dgvGerencias.RowHeadersVisible = false;
            this.dgvGerencias.RowHeadersWidth = 51;
            dataGridViewCellStyle6.BackColor = System.Drawing.Color.White;
            dataGridViewCellStyle6.SelectionBackColor = System.Drawing.Color.White;
            dataGridViewCellStyle6.SelectionForeColor = System.Drawing.Color.White;
            this.dgvGerencias.RowsDefaultCellStyle = dataGridViewCellStyle6;
            this.dgvGerencias.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dgvGerencias.Size = new System.Drawing.Size(1431, 591);
            this.dgvGerencias.TabIndex = 40;
            // 
            // dataGridViewTextBoxColumn1
            // 
            this.dataGridViewTextBoxColumn1.HeaderText = "ID";
            this.dataGridViewTextBoxColumn1.MinimumWidth = 6;
            this.dataGridViewTextBoxColumn1.Name = "dataGridViewTextBoxColumn1";
            this.dataGridViewTextBoxColumn1.Width = 125;
            // 
            // dataGridViewTextBoxColumn2
            // 
            this.dataGridViewTextBoxColumn2.HeaderText = "Nombre";
            this.dataGridViewTextBoxColumn2.MinimumWidth = 6;
            this.dataGridViewTextBoxColumn2.Name = "dataGridViewTextBoxColumn2";
            this.dataGridViewTextBoxColumn2.Width = 200;
            // 
            // dataGridViewTextBoxColumn3
            // 
            this.dataGridViewTextBoxColumn3.HeaderText = "Descripción";
            this.dataGridViewTextBoxColumn3.MinimumWidth = 6;
            this.dataGridViewTextBoxColumn3.Name = "dataGridViewTextBoxColumn3";
            this.dataGridViewTextBoxColumn3.Width = 625;
            // 
            // dataGridViewTextBoxColumn7
            // 
            this.dataGridViewTextBoxColumn7.HeaderText = "Estado";
            this.dataGridViewTextBoxColumn7.MinimumWidth = 6;
            this.dataGridViewTextBoxColumn7.Name = "dataGridViewTextBoxColumn7";
            this.dataGridViewTextBoxColumn7.Width = 125;
            // 
            // label2
            // 
            this.label2.Font = new System.Drawing.Font("Century Gothic", 36F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(66)))), ((int)(((byte)(122)))));
            this.label2.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.label2.Location = new System.Drawing.Point(12, 9);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(802, 97);
            this.label2.TabIndex = 39;
            this.label2.Text = "Gestionar Gerencias";
            this.label2.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // btnGestGerCargaMav
            // 
            this.btnGestGerCargaMav.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(157)))), ((int)(((byte)(6)))), ((int)(((byte)(32)))));
            this.btnGestGerCargaMav.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnGestGerCargaMav.Font = new System.Drawing.Font("Century Gothic", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnGestGerCargaMav.ForeColor = System.Drawing.Color.White;
            this.btnGestGerCargaMav.Location = new System.Drawing.Point(25, 155);
            this.btnGestGerCargaMav.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.btnGestGerCargaMav.Name = "btnGestGerCargaMav";
            this.btnGestGerCargaMav.Size = new System.Drawing.Size(251, 32);
            this.btnGestGerCargaMav.TabIndex = 38;
            this.btnGestGerCargaMav.Text = " Cargar Masivamente";
            this.btnGestGerCargaMav.UseVisualStyleBackColor = false;
            this.btnGestGerCargaMav.Click += new System.EventHandler(this.btnGestGerCargaMav_Click);
            // 
            // btnGestGerEliminar
            // 
            this.btnGestGerEliminar.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(157)))), ((int)(((byte)(6)))), ((int)(((byte)(32)))));
            this.btnGestGerEliminar.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnGestGerEliminar.Font = new System.Drawing.Font("Century Gothic", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnGestGerEliminar.ForeColor = System.Drawing.Color.White;
            this.btnGestGerEliminar.Location = new System.Drawing.Point(25, 854);
            this.btnGestGerEliminar.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.btnGestGerEliminar.Name = "btnGestGerEliminar";
            this.btnGestGerEliminar.Size = new System.Drawing.Size(251, 32);
            this.btnGestGerEliminar.TabIndex = 44;
            this.btnGestGerEliminar.Text = "Eliminar";
            this.btnGestGerEliminar.UseVisualStyleBackColor = false;
            this.btnGestGerEliminar.Click += new System.EventHandler(this.btnGestGerEliminar_Click);
            // 
            // frmAdmGestGer
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(1476, 929);
            this.Controls.Add(this.btnGestGerEliminar);
            this.Controls.Add(this.dgvGerencias);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.btnGestGerCargaMav);
            this.Margin = new System.Windows.Forms.Padding(4);
            this.Name = "frmAdmGestGer";
            this.Text = "s";
            this.Load += new System.EventHandler(this.frmAdmGestGer_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dgvGerencias)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion
        private System.Windows.Forms.DataGridView dgvGerencias;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Button btnGestGerCargaMav;
        private System.Windows.Forms.Button btnGestGerEliminar;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn1;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn2;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn3;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn7;
    }
}