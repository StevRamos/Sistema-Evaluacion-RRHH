namespace SistemaEDInterfaces
{
    partial class frmAdmCalibrar
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
            this.lblCalibracion = new System.Windows.Forms.Label();
            this.gbBusqueda = new System.Windows.Forms.GroupBox();
            this.btnBuscar = new System.Windows.Forms.Button();
            this.cbJefe = new System.Windows.Forms.ComboBox();
            this.cbGerencia = new System.Windows.Forms.ComboBox();
            this.lblJefe = new System.Windows.Forms.Label();
            this.lblGerencia = new System.Windows.Forms.Label();
            this.gbCupos = new System.Windows.Forms.GroupBox();
            this.dgvCupos = new System.Windows.Forms.DataGridView();
            this.A = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.B = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.C = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.D = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.E = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.panel9Box = new System.Windows.Forms.Panel();
            this.nineBox = new SistemaEDInterfaces.NineBox();
            this.btnGuardar = new System.Windows.Forms.Button();
            this.lblE = new System.Windows.Forms.Label();
            this.lblD = new System.Windows.Forms.Label();
            this.lblC = new System.Windows.Forms.Label();
            this.lblA = new System.Windows.Forms.Label();
            this.lblB = new System.Windows.Forms.Label();
            this.lblBajo = new System.Windows.Forms.Label();
            this.lblMedio = new System.Windows.Forms.Label();
            this.lblAlto = new System.Windows.Forms.Label();
            this.gbBusqueda.SuspendLayout();
            this.gbCupos.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvCupos)).BeginInit();
            this.panel9Box.SuspendLayout();
            this.SuspendLayout();
            // 
            // lblCalibracion
            // 
            this.lblCalibracion.AutoSize = true;
            this.lblCalibracion.Font = new System.Drawing.Font("Century Gothic", 36F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblCalibracion.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(66)))), ((int)(((byte)(122)))));
            this.lblCalibracion.Location = new System.Drawing.Point(16, 11);
            this.lblCalibracion.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblCalibracion.Name = "lblCalibracion";
            this.lblCalibracion.Size = new System.Drawing.Size(648, 70);
            this.lblCalibracion.TabIndex = 12;
            this.lblCalibracion.Text = "Calibración de Notas";
            // 
            // gbBusqueda
            // 
            this.gbBusqueda.Controls.Add(this.btnBuscar);
            this.gbBusqueda.Controls.Add(this.cbJefe);
            this.gbBusqueda.Controls.Add(this.cbGerencia);
            this.gbBusqueda.Controls.Add(this.lblJefe);
            this.gbBusqueda.Controls.Add(this.lblGerencia);
            this.gbBusqueda.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.gbBusqueda.Location = new System.Drawing.Point(28, 116);
            this.gbBusqueda.Name = "gbBusqueda";
            this.gbBusqueda.Size = new System.Drawing.Size(671, 235);
            this.gbBusqueda.TabIndex = 13;
            this.gbBusqueda.TabStop = false;
            this.gbBusqueda.Text = "Opciones de Búsqueda";
            // 
            // btnBuscar
            // 
            this.btnBuscar.Anchor = System.Windows.Forms.AnchorStyles.Right;
            this.btnBuscar.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(157)))), ((int)(((byte)(6)))), ((int)(((byte)(32)))));
            this.btnBuscar.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnBuscar.Font = new System.Drawing.Font("Century Gothic", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnBuscar.ForeColor = System.Drawing.Color.White;
            this.btnBuscar.Location = new System.Drawing.Point(425, 178);
            this.btnBuscar.Margin = new System.Windows.Forms.Padding(4);
            this.btnBuscar.Name = "btnBuscar";
            this.btnBuscar.Size = new System.Drawing.Size(211, 32);
            this.btnBuscar.TabIndex = 12;
            this.btnBuscar.Text = "Buscar";
            this.btnBuscar.UseVisualStyleBackColor = false;
            this.btnBuscar.Click += new System.EventHandler(this.btnBuscar_Click);
            // 
            // cbJefe
            // 
            this.cbJefe.FormattingEnabled = true;
            this.cbJefe.Location = new System.Drawing.Point(189, 117);
            this.cbJefe.Name = "cbJefe";
            this.cbJefe.Size = new System.Drawing.Size(447, 37);
            this.cbJefe.TabIndex = 3;
            this.cbJefe.Format += new System.Windows.Forms.ListControlConvertEventHandler(this.cbJefe_Format);
            // 
            // cbGerencia
            // 
            this.cbGerencia.FormattingEnabled = true;
            this.cbGerencia.Location = new System.Drawing.Point(189, 58);
            this.cbGerencia.Name = "cbGerencia";
            this.cbGerencia.Size = new System.Drawing.Size(447, 37);
            this.cbGerencia.TabIndex = 2;
            this.cbGerencia.SelectedValueChanged += new System.EventHandler(this.cbGerencia_SelectedValueChanged);
            // 
            // lblJefe
            // 
            this.lblJefe.AutoSize = true;
            this.lblJefe.Location = new System.Drawing.Point(99, 120);
            this.lblJefe.Name = "lblJefe";
            this.lblJefe.Size = new System.Drawing.Size(71, 29);
            this.lblJefe.TabIndex = 1;
            this.lblJefe.Text = "Jefe :";
            // 
            // lblGerencia
            // 
            this.lblGerencia.AutoSize = true;
            this.lblGerencia.Location = new System.Drawing.Point(47, 61);
            this.lblGerencia.Name = "lblGerencia";
            this.lblGerencia.Size = new System.Drawing.Size(123, 29);
            this.lblGerencia.TabIndex = 0;
            this.lblGerencia.Text = "Gerencia :";
            // 
            // gbCupos
            // 
            this.gbCupos.Controls.Add(this.dgvCupos);
            this.gbCupos.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.gbCupos.Location = new System.Drawing.Point(783, 116);
            this.gbCupos.Name = "gbCupos";
            this.gbCupos.Size = new System.Drawing.Size(659, 235);
            this.gbCupos.TabIndex = 14;
            this.gbCupos.TabStop = false;
            this.gbCupos.Text = "Cupos";
            // 
            // dgvCupos
            // 
            this.dgvCupos.AllowUserToAddRows = false;
            this.dgvCupos.AllowUserToDeleteRows = false;
            this.dgvCupos.AllowUserToResizeColumns = false;
            this.dgvCupos.AllowUserToResizeRows = false;
            this.dgvCupos.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.dgvCupos.AutoSizeRowsMode = System.Windows.Forms.DataGridViewAutoSizeRowsMode.AllCells;
            this.dgvCupos.BackgroundColor = System.Drawing.Color.White;
            this.dgvCupos.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.dgvCupos.ColumnHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.None;
            dataGridViewCellStyle4.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle4.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(66)))), ((int)(((byte)(122)))));
            dataGridViewCellStyle4.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle4.ForeColor = System.Drawing.Color.White;
            dataGridViewCellStyle4.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle4.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle4.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dgvCupos.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle4;
            this.dgvCupos.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvCupos.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.A,
            this.B,
            this.C,
            this.D,
            this.E});
            this.dgvCupos.EnableHeadersVisualStyles = false;
            this.dgvCupos.GridColor = System.Drawing.SystemColors.ControlText;
            this.dgvCupos.Location = new System.Drawing.Point(40, 61);
            this.dgvCupos.Margin = new System.Windows.Forms.Padding(4);
            this.dgvCupos.Name = "dgvCupos";
            this.dgvCupos.ReadOnly = true;
            dataGridViewCellStyle5.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle5.BackColor = System.Drawing.Color.White;
            dataGridViewCellStyle5.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle5.ForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle5.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle5.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle5.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dgvCupos.RowHeadersDefaultCellStyle = dataGridViewCellStyle5;
            this.dgvCupos.RowHeadersVisible = false;
            this.dgvCupos.RowHeadersWidth = 51;
            dataGridViewCellStyle6.BackColor = System.Drawing.Color.White;
            dataGridViewCellStyle6.SelectionBackColor = System.Drawing.Color.White;
            dataGridViewCellStyle6.SelectionForeColor = System.Drawing.Color.White;
            this.dgvCupos.RowsDefaultCellStyle = dataGridViewCellStyle6;
            this.dgvCupos.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dgvCupos.Size = new System.Drawing.Size(589, 130);
            this.dgvCupos.TabIndex = 2;
            // 
            // A
            // 
            this.A.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.A.HeaderText = "A";
            this.A.MinimumWidth = 6;
            this.A.Name = "A";
            this.A.ReadOnly = true;
            this.A.Resizable = System.Windows.Forms.DataGridViewTriState.False;
            this.A.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.Programmatic;
            // 
            // B
            // 
            this.B.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.B.HeaderText = "B";
            this.B.MinimumWidth = 6;
            this.B.Name = "B";
            this.B.ReadOnly = true;
            this.B.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.Programmatic;
            // 
            // C
            // 
            this.C.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.C.HeaderText = "C";
            this.C.MinimumWidth = 6;
            this.C.Name = "C";
            this.C.ReadOnly = true;
            this.C.Resizable = System.Windows.Forms.DataGridViewTriState.False;
            this.C.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.Programmatic;
            // 
            // D
            // 
            this.D.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.D.HeaderText = "D";
            this.D.MinimumWidth = 6;
            this.D.Name = "D";
            this.D.ReadOnly = true;
            this.D.Resizable = System.Windows.Forms.DataGridViewTriState.False;
            this.D.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.Programmatic;
            // 
            // E
            // 
            this.E.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.E.HeaderText = "E";
            this.E.MinimumWidth = 6;
            this.E.Name = "E";
            this.E.ReadOnly = true;
            // 
            // panel9Box
            // 
            this.panel9Box.Controls.Add(this.nineBox);
            this.panel9Box.Controls.Add(this.btnGuardar);
            this.panel9Box.Controls.Add(this.lblE);
            this.panel9Box.Controls.Add(this.lblD);
            this.panel9Box.Controls.Add(this.lblC);
            this.panel9Box.Controls.Add(this.lblA);
            this.panel9Box.Controls.Add(this.lblB);
            this.panel9Box.Controls.Add(this.lblBajo);
            this.panel9Box.Controls.Add(this.lblMedio);
            this.panel9Box.Controls.Add(this.lblAlto);
            this.panel9Box.Location = new System.Drawing.Point(0, 390);
            this.panel9Box.Name = "panel9Box";
            this.panel9Box.Size = new System.Drawing.Size(1455, 922);
            this.panel9Box.TabIndex = 15;
            // 
            // nineBox
            // 
            this.nineBox.AutoSize = true;
            this.nineBox.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.nineBox.ColaboradorSeleccionado = null;
            this.nineBox.Location = new System.Drawing.Point(174, 35);
            this.nineBox.Name = "nineBox";
            this.nineBox.Size = new System.Drawing.Size(952, 508);
            this.nineBox.TabIndex = 0;
            // 
            // btnGuardar
            // 
            this.btnGuardar.Anchor = System.Windows.Forms.AnchorStyles.Right;
            this.btnGuardar.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(157)))), ((int)(((byte)(6)))), ((int)(((byte)(32)))));
            this.btnGuardar.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnGuardar.Font = new System.Drawing.Font("Century Gothic", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnGuardar.ForeColor = System.Drawing.Color.White;
            this.btnGuardar.Location = new System.Drawing.Point(1192, 816);
            this.btnGuardar.Margin = new System.Windows.Forms.Padding(4);
            this.btnGuardar.Name = "btnGuardar";
            this.btnGuardar.Size = new System.Drawing.Size(211, 32);
            this.btnGuardar.TabIndex = 21;
            this.btnGuardar.Text = "Guardar";
            this.btnGuardar.UseVisualStyleBackColor = false;
            // 
            // lblE
            // 
            this.lblE.AutoSize = true;
            this.lblE.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F);
            this.lblE.Location = new System.Drawing.Point(284, 716);
            this.lblE.Name = "lblE";
            this.lblE.Size = new System.Drawing.Size(29, 29);
            this.lblE.TabIndex = 20;
            this.lblE.Text = "E";
            // 
            // lblD
            // 
            this.lblD.AutoSize = true;
            this.lblD.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F);
            this.lblD.Location = new System.Drawing.Point(522, 716);
            this.lblD.Name = "lblD";
            this.lblD.Size = new System.Drawing.Size(30, 29);
            this.lblD.TabIndex = 19;
            this.lblD.Text = "D";
            // 
            // lblC
            // 
            this.lblC.AutoSize = true;
            this.lblC.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F);
            this.lblC.Location = new System.Drawing.Point(778, 716);
            this.lblC.Name = "lblC";
            this.lblC.Size = new System.Drawing.Size(30, 29);
            this.lblC.TabIndex = 18;
            this.lblC.Text = "C";
            // 
            // lblA
            // 
            this.lblA.AutoSize = true;
            this.lblA.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F);
            this.lblA.Location = new System.Drawing.Point(1286, 716);
            this.lblA.Name = "lblA";
            this.lblA.Size = new System.Drawing.Size(28, 29);
            this.lblA.TabIndex = 17;
            this.lblA.Text = "A";
            // 
            // lblB
            // 
            this.lblB.AutoSize = true;
            this.lblB.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F);
            this.lblB.Location = new System.Drawing.Point(1016, 716);
            this.lblB.Name = "lblB";
            this.lblB.Size = new System.Drawing.Size(29, 29);
            this.lblB.TabIndex = 16;
            this.lblB.Text = "B";
            // 
            // lblBajo
            // 
            this.lblBajo.AutoSize = true;
            this.lblBajo.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F);
            this.lblBajo.Location = new System.Drawing.Point(51, 540);
            this.lblBajo.Name = "lblBajo";
            this.lblBajo.Size = new System.Drawing.Size(62, 29);
            this.lblBajo.TabIndex = 15;
            this.lblBajo.Text = "Bajo";
            // 
            // lblMedio
            // 
            this.lblMedio.AutoSize = true;
            this.lblMedio.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F);
            this.lblMedio.Location = new System.Drawing.Point(51, 323);
            this.lblMedio.Name = "lblMedio";
            this.lblMedio.Size = new System.Drawing.Size(81, 29);
            this.lblMedio.TabIndex = 14;
            this.lblMedio.Text = "Medio";
            // 
            // lblAlto
            // 
            this.lblAlto.AutoSize = true;
            this.lblAlto.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F);
            this.lblAlto.Location = new System.Drawing.Point(51, 125);
            this.lblAlto.Name = "lblAlto";
            this.lblAlto.Size = new System.Drawing.Size(54, 29);
            this.lblAlto.TabIndex = 13;
            this.lblAlto.Text = "Alto";
            // 
            // frmAdmCalibrar
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoScroll = true;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(1544, 929);
            this.Controls.Add(this.panel9Box);
            this.Controls.Add(this.gbCupos);
            this.Controls.Add(this.gbBusqueda);
            this.Controls.Add(this.lblCalibracion);
            this.Margin = new System.Windows.Forms.Padding(4);
            this.Name = "frmAdmCalibrar";
            this.Text = "frmAdmCalibrar";
            this.gbBusqueda.ResumeLayout(false);
            this.gbBusqueda.PerformLayout();
            this.gbCupos.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dgvCupos)).EndInit();
            this.panel9Box.ResumeLayout(false);
            this.panel9Box.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Label lblCalibracion;
        private System.Windows.Forms.GroupBox gbBusqueda;
        private System.Windows.Forms.ComboBox cbJefe;
        private System.Windows.Forms.ComboBox cbGerencia;
        private System.Windows.Forms.Label lblJefe;
        private System.Windows.Forms.Label lblGerencia;
        private System.Windows.Forms.GroupBox gbCupos;
        private System.Windows.Forms.Button btnBuscar;
        private System.Windows.Forms.DataGridView dgvCupos;
        private System.Windows.Forms.DataGridViewTextBoxColumn A;
        private System.Windows.Forms.DataGridViewTextBoxColumn B;
        private System.Windows.Forms.DataGridViewTextBoxColumn C;
        private System.Windows.Forms.DataGridViewTextBoxColumn D;
        private System.Windows.Forms.DataGridViewTextBoxColumn E;
        private System.Windows.Forms.Panel panel9Box;
        private System.Windows.Forms.Button btnGuardar;
        private System.Windows.Forms.Label lblE;
        private System.Windows.Forms.Label lblD;
        private System.Windows.Forms.Label lblC;
        private System.Windows.Forms.Label lblA;
        private System.Windows.Forms.Label lblB;
        private System.Windows.Forms.Label lblBajo;
        private System.Windows.Forms.Label lblMedio;
        private System.Windows.Forms.Label lblAlto;
        private NineBox nineBox;
    }
}