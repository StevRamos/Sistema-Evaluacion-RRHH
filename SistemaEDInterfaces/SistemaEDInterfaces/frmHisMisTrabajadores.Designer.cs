namespace SistemaEDInterfaces
{
    partial class frmHisMisTrabajadores
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
            this.dgvMisObjetivos = new System.Windows.Forms.DataGridView();
            this.id = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.nombre = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dni = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.correo = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.puesto = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.notaDesempeño = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.notaPotencial = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.lblMisObjetivos = new System.Windows.Forms.Label();
            this.comboBox1 = new System.Windows.Forms.ComboBox();
            this.btnSeleccionar = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.dgvMisObjetivos)).BeginInit();
            this.SuspendLayout();
            // 
            // dgvMisObjetivos
            // 
            this.dgvMisObjetivos.AllowUserToAddRows = false;
            this.dgvMisObjetivos.AllowUserToDeleteRows = false;
            this.dgvMisObjetivos.AllowUserToResizeColumns = false;
            this.dgvMisObjetivos.AllowUserToResizeRows = false;
            this.dgvMisObjetivos.AutoSizeRowsMode = System.Windows.Forms.DataGridViewAutoSizeRowsMode.AllCells;
            this.dgvMisObjetivos.BackgroundColor = System.Drawing.Color.White;
            this.dgvMisObjetivos.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.dgvMisObjetivos.ColumnHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.None;
            dataGridViewCellStyle4.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle4.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(66)))), ((int)(((byte)(122)))));
            dataGridViewCellStyle4.Font = new System.Drawing.Font("Century Gothic", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle4.ForeColor = System.Drawing.Color.White;
            dataGridViewCellStyle4.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle4.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle4.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dgvMisObjetivos.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle4;
            this.dgvMisObjetivos.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvMisObjetivos.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.id,
            this.nombre,
            this.dni,
            this.correo,
            this.puesto,
            this.notaDesempeño,
            this.notaPotencial});
            this.dgvMisObjetivos.EnableHeadersVisualStyles = false;
            this.dgvMisObjetivos.Location = new System.Drawing.Point(24, 186);
            this.dgvMisObjetivos.Name = "dgvMisObjetivos";
            this.dgvMisObjetivos.ReadOnly = true;
            dataGridViewCellStyle5.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle5.BackColor = System.Drawing.Color.White;
            dataGridViewCellStyle5.Font = new System.Drawing.Font("Century Gothic", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle5.ForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle5.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle5.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle5.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dgvMisObjetivos.RowHeadersDefaultCellStyle = dataGridViewCellStyle5;
            this.dgvMisObjetivos.RowHeadersVisible = false;
            dataGridViewCellStyle6.BackColor = System.Drawing.Color.White;
            dataGridViewCellStyle6.SelectionBackColor = System.Drawing.Color.White;
            dataGridViewCellStyle6.SelectionForeColor = System.Drawing.Color.White;
            this.dgvMisObjetivos.RowsDefaultCellStyle = dataGridViewCellStyle6;
            this.dgvMisObjetivos.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dgvMisObjetivos.Size = new System.Drawing.Size(1004, 443);
            this.dgvMisObjetivos.TabIndex = 7;
            // 
            // id
            // 
            this.id.HeaderText = "ID";
            this.id.Name = "id";
            this.id.ReadOnly = true;
            // 
            // nombre
            // 
            this.nombre.HeaderText = "Nombre";
            this.nombre.Name = "nombre";
            this.nombre.ReadOnly = true;
            this.nombre.Width = 200;
            // 
            // dni
            // 
            this.dni.HeaderText = "DNI";
            this.dni.Name = "dni";
            this.dni.ReadOnly = true;
            // 
            // correo
            // 
            this.correo.HeaderText = "Correo";
            this.correo.Name = "correo";
            this.correo.ReadOnly = true;
            this.correo.Width = 200;
            // 
            // puesto
            // 
            this.puesto.HeaderText = "Puesto de Trabajo";
            this.puesto.Name = "puesto";
            this.puesto.ReadOnly = true;
            this.puesto.Width = 200;
            // 
            // notaDesempeño
            // 
            this.notaDesempeño.HeaderText = "Nota Evaluación Desempeño";
            this.notaDesempeño.Name = "notaDesempeño";
            this.notaDesempeño.ReadOnly = true;
            this.notaDesempeño.Width = 150;
            // 
            // notaPotencial
            // 
            this.notaPotencial.HeaderText = "Nota Evaluación Potencial";
            this.notaPotencial.Name = "notaPotencial";
            this.notaPotencial.ReadOnly = true;
            this.notaPotencial.Width = 150;
            // 
            // lblMisObjetivos
            // 
            this.lblMisObjetivos.AutoSize = true;
            this.lblMisObjetivos.Font = new System.Drawing.Font("Century Gothic", 36F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblMisObjetivos.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(66)))), ((int)(((byte)(122)))));
            this.lblMisObjetivos.Location = new System.Drawing.Point(12, 9);
            this.lblMisObjetivos.Name = "lblMisObjetivos";
            this.lblMisObjetivos.Size = new System.Drawing.Size(615, 56);
            this.lblMisObjetivos.TabIndex = 6;
            this.lblMisObjetivos.Text = "Historial mis Trabajadores";
            // 
            // comboBox1
            // 
            this.comboBox1.FormattingEnabled = true;
            this.comboBox1.Location = new System.Drawing.Point(288, 112);
            this.comboBox1.Name = "comboBox1";
            this.comboBox1.Size = new System.Drawing.Size(297, 21);
            this.comboBox1.TabIndex = 10;
            // 
            // btnSeleccionar
            // 
            this.btnSeleccionar.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(157)))), ((int)(((byte)(6)))), ((int)(((byte)(32)))));
            this.btnSeleccionar.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnSeleccionar.Font = new System.Drawing.Font("Century Gothic", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnSeleccionar.ForeColor = System.Drawing.Color.White;
            this.btnSeleccionar.Location = new System.Drawing.Point(870, 107);
            this.btnSeleccionar.Name = "btnSeleccionar";
            this.btnSeleccionar.Size = new System.Drawing.Size(158, 26);
            this.btnSeleccionar.TabIndex = 11;
            this.btnSeleccionar.Text = "Seleccionar Período";
            this.btnSeleccionar.UseVisualStyleBackColor = false;
            this.btnSeleccionar.Click += new System.EventHandler(this.btnSeleccionar_Click_1);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Century Gothic", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(66)))), ((int)(((byte)(122)))));
            this.label1.Location = new System.Drawing.Point(20, 110);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(223, 23);
            this.label1.TabIndex = 34;
            this.label1.Text = "Seleccione un periodo:";
            // 
            // frmHisMisTrabajadores
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoScroll = true;
            this.AutoScrollMargin = new System.Drawing.Size(0, 100);
            this.AutoSize = true;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(1107, 749);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.btnSeleccionar);
            this.Controls.Add(this.comboBox1);
            this.Controls.Add(this.dgvMisObjetivos);
            this.Controls.Add(this.lblMisObjetivos);
            this.Name = "frmHisMisTrabajadores";
            this.Text = "frmHisMisTrabajadores";
            ((System.ComponentModel.ISupportInitialize)(this.dgvMisObjetivos)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.DataGridView dgvMisObjetivos;
        private System.Windows.Forms.DataGridViewTextBoxColumn id;
        private System.Windows.Forms.DataGridViewTextBoxColumn nombre;
        private System.Windows.Forms.DataGridViewTextBoxColumn dni;
        private System.Windows.Forms.DataGridViewTextBoxColumn correo;
        private System.Windows.Forms.DataGridViewTextBoxColumn puesto;
        private System.Windows.Forms.DataGridViewTextBoxColumn notaDesempeño;
        private System.Windows.Forms.DataGridViewTextBoxColumn notaPotencial;
        private System.Windows.Forms.Label lblMisObjetivos;
        private System.Windows.Forms.ComboBox comboBox1;
        private System.Windows.Forms.Button btnSeleccionar;
        private System.Windows.Forms.Label label1;
    }
}