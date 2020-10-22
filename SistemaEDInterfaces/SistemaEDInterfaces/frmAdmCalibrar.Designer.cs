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
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle1 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle2 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle3 = new System.Windows.Forms.DataGridViewCellStyle();
            this.lblCalibracion = new System.Windows.Forms.Label();
            this.gbBusqueda = new System.Windows.Forms.GroupBox();
            this.gbCupos = new System.Windows.Forms.GroupBox();
            this.lblGerencia = new System.Windows.Forms.Label();
            this.lblJefe = new System.Windows.Forms.Label();
            this.cbGerencia = new System.Windows.Forms.ComboBox();
            this.cbJefe = new System.Windows.Forms.ComboBox();
            this.btnBuscar = new System.Windows.Forms.Button();
            this.dgvCupos = new System.Windows.Forms.DataGridView();
            this.A = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.B = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.C = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.D = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.E = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.panel9Box = new System.Windows.Forms.Panel();
            this.btnGuardar = new System.Windows.Forms.Button();
            this.lblE = new System.Windows.Forms.Label();
            this.lblD = new System.Windows.Forms.Label();
            this.lblC = new System.Windows.Forms.Label();
            this.lblA = new System.Windows.Forms.Label();
            this.lblB = new System.Windows.Forms.Label();
            this.lblBajo = new System.Windows.Forms.Label();
            this.lblMedio = new System.Windows.Forms.Label();
            this.lblAlto = new System.Windows.Forms.Label();
            this.tlp9Box = new System.Windows.Forms.TableLayoutPanel();
            this.lpAltoE = new System.Windows.Forms.FlowLayoutPanel();
            this.lpAltoD = new System.Windows.Forms.FlowLayoutPanel();
            this.lpAltoC = new System.Windows.Forms.FlowLayoutPanel();
            this.lpAltoB = new System.Windows.Forms.FlowLayoutPanel();
            this.lpAltoA = new System.Windows.Forms.FlowLayoutPanel();
            this.lpMedioE = new System.Windows.Forms.FlowLayoutPanel();
            this.lpMedioD = new System.Windows.Forms.FlowLayoutPanel();
            this.lpMedioC = new System.Windows.Forms.FlowLayoutPanel();
            this.lpMedioB = new System.Windows.Forms.FlowLayoutPanel();
            this.lpMedioA = new System.Windows.Forms.FlowLayoutPanel();
            this.lpBajoE = new System.Windows.Forms.FlowLayoutPanel();
            this.lpBajoD = new System.Windows.Forms.FlowLayoutPanel();
            this.lpBajoC = new System.Windows.Forms.FlowLayoutPanel();
            this.lpBajoB = new System.Windows.Forms.FlowLayoutPanel();
            this.lpBajoA = new System.Windows.Forms.FlowLayoutPanel();
            this.gbBusqueda.SuspendLayout();
            this.gbCupos.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvCupos)).BeginInit();
            this.panel9Box.SuspendLayout();
            this.tlp9Box.SuspendLayout();
            this.SuspendLayout();
            // 
            // lblCalibracion
            // 
            this.lblCalibracion.AutoSize = true;
            this.lblCalibracion.Font = new System.Drawing.Font("Century Gothic", 36F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblCalibracion.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(66)))), ((int)(((byte)(122)))));
            this.lblCalibracion.Location = new System.Drawing.Point(25, 27);
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
            this.gbBusqueda.Location = new System.Drawing.Point(37, 135);
            this.gbBusqueda.Name = "gbBusqueda";
            this.gbBusqueda.Size = new System.Drawing.Size(671, 235);
            this.gbBusqueda.TabIndex = 13;
            this.gbBusqueda.TabStop = false;
            this.gbBusqueda.Text = "Opciones de Búsqueda";
            // 
            // gbCupos
            // 
            this.gbCupos.Controls.Add(this.dgvCupos);
            this.gbCupos.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.gbCupos.Location = new System.Drawing.Point(775, 135);
            this.gbCupos.Name = "gbCupos";
            this.gbCupos.Size = new System.Drawing.Size(659, 235);
            this.gbCupos.TabIndex = 14;
            this.gbCupos.TabStop = false;
            this.gbCupos.Text = "Cupos";
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
            // lblJefe
            // 
            this.lblJefe.AutoSize = true;
            this.lblJefe.Location = new System.Drawing.Point(99, 120);
            this.lblJefe.Name = "lblJefe";
            this.lblJefe.Size = new System.Drawing.Size(71, 29);
            this.lblJefe.TabIndex = 1;
            this.lblJefe.Text = "Jefe :";
            // 
            // cbGerencia
            // 
            this.cbGerencia.FormattingEnabled = true;
            this.cbGerencia.Location = new System.Drawing.Point(189, 58);
            this.cbGerencia.Name = "cbGerencia";
            this.cbGerencia.Size = new System.Drawing.Size(447, 37);
            this.cbGerencia.TabIndex = 2;
            // 
            // cbJefe
            // 
            this.cbJefe.FormattingEnabled = true;
            this.cbJefe.Location = new System.Drawing.Point(189, 117);
            this.cbJefe.Name = "cbJefe";
            this.cbJefe.Size = new System.Drawing.Size(447, 37);
            this.cbJefe.TabIndex = 3;
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
            dataGridViewCellStyle1.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(66)))), ((int)(((byte)(122)))));
            dataGridViewCellStyle1.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle1.ForeColor = System.Drawing.Color.White;
            dataGridViewCellStyle1.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle1.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle1.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dgvCupos.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle1;
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
            dataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle2.BackColor = System.Drawing.Color.White;
            dataGridViewCellStyle2.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle2.ForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle2.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle2.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle2.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dgvCupos.RowHeadersDefaultCellStyle = dataGridViewCellStyle2;
            this.dgvCupos.RowHeadersVisible = false;
            this.dgvCupos.RowHeadersWidth = 51;
            dataGridViewCellStyle3.BackColor = System.Drawing.Color.White;
            dataGridViewCellStyle3.SelectionBackColor = System.Drawing.Color.White;
            dataGridViewCellStyle3.SelectionForeColor = System.Drawing.Color.White;
            this.dgvCupos.RowsDefaultCellStyle = dataGridViewCellStyle3;
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
            this.panel9Box.Controls.Add(this.btnGuardar);
            this.panel9Box.Controls.Add(this.lblE);
            this.panel9Box.Controls.Add(this.lblD);
            this.panel9Box.Controls.Add(this.lblC);
            this.panel9Box.Controls.Add(this.lblA);
            this.panel9Box.Controls.Add(this.lblB);
            this.panel9Box.Controls.Add(this.lblBajo);
            this.panel9Box.Controls.Add(this.lblMedio);
            this.panel9Box.Controls.Add(this.lblAlto);
            this.panel9Box.Controls.Add(this.tlp9Box);
            this.panel9Box.Location = new System.Drawing.Point(-2, 409);
            this.panel9Box.Name = "panel9Box";
            this.panel9Box.Size = new System.Drawing.Size(1467, 889);
            this.panel9Box.TabIndex = 15;
            // 
            // btnGuardar
            // 
            this.btnGuardar.Anchor = System.Windows.Forms.AnchorStyles.Right;
            this.btnGuardar.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(157)))), ((int)(((byte)(6)))), ((int)(((byte)(32)))));
            this.btnGuardar.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnGuardar.Font = new System.Drawing.Font("Century Gothic", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnGuardar.ForeColor = System.Drawing.Color.White;
            this.btnGuardar.Location = new System.Drawing.Point(1204, 799);
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
            // tlp9Box
            // 
            this.tlp9Box.BackColor = System.Drawing.Color.WhiteSmoke;
            this.tlp9Box.ColumnCount = 5;
            this.tlp9Box.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 20F));
            this.tlp9Box.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 20F));
            this.tlp9Box.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 20F));
            this.tlp9Box.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 20F));
            this.tlp9Box.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 20F));
            this.tlp9Box.Controls.Add(this.lpAltoE, 0, 0);
            this.tlp9Box.Controls.Add(this.lpAltoD, 1, 0);
            this.tlp9Box.Controls.Add(this.lpAltoC, 2, 0);
            this.tlp9Box.Controls.Add(this.lpAltoB, 3, 0);
            this.tlp9Box.Controls.Add(this.lpAltoA, 4, 0);
            this.tlp9Box.Controls.Add(this.lpMedioE, 0, 1);
            this.tlp9Box.Controls.Add(this.lpMedioD, 1, 1);
            this.tlp9Box.Controls.Add(this.lpMedioC, 2, 1);
            this.tlp9Box.Controls.Add(this.lpMedioB, 3, 1);
            this.tlp9Box.Controls.Add(this.lpMedioA, 4, 1);
            this.tlp9Box.Controls.Add(this.lpBajoE, 0, 2);
            this.tlp9Box.Controls.Add(this.lpBajoD, 1, 2);
            this.tlp9Box.Controls.Add(this.lpBajoC, 2, 2);
            this.tlp9Box.Controls.Add(this.lpBajoB, 3, 2);
            this.tlp9Box.Controls.Add(this.lpBajoA, 4, 2);
            this.tlp9Box.Location = new System.Drawing.Point(167, 58);
            this.tlp9Box.Name = "tlp9Box";
            this.tlp9Box.RowCount = 3;
            this.tlp9Box.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 33.34F));
            this.tlp9Box.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 33.33F));
            this.tlp9Box.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 33.33F));
            this.tlp9Box.Size = new System.Drawing.Size(1248, 631);
            this.tlp9Box.TabIndex = 12;
            // 
            // lpAltoE
            // 
            this.lpAltoE.BackColor = System.Drawing.Color.White;
            this.lpAltoE.Location = new System.Drawing.Point(3, 3);
            this.lpAltoE.Name = "lpAltoE";
            this.lpAltoE.Size = new System.Drawing.Size(243, 204);
            this.lpAltoE.TabIndex = 0;
            // 
            // lpAltoD
            // 
            this.lpAltoD.BackColor = System.Drawing.Color.White;
            this.lpAltoD.Location = new System.Drawing.Point(252, 3);
            this.lpAltoD.Name = "lpAltoD";
            this.lpAltoD.Size = new System.Drawing.Size(243, 204);
            this.lpAltoD.TabIndex = 1;
            // 
            // lpAltoC
            // 
            this.lpAltoC.BackColor = System.Drawing.Color.White;
            this.lpAltoC.Location = new System.Drawing.Point(501, 3);
            this.lpAltoC.Name = "lpAltoC";
            this.lpAltoC.Size = new System.Drawing.Size(243, 204);
            this.lpAltoC.TabIndex = 2;
            // 
            // lpAltoB
            // 
            this.lpAltoB.BackColor = System.Drawing.Color.White;
            this.lpAltoB.Location = new System.Drawing.Point(750, 3);
            this.lpAltoB.Name = "lpAltoB";
            this.lpAltoB.Size = new System.Drawing.Size(243, 204);
            this.lpAltoB.TabIndex = 3;
            // 
            // lpAltoA
            // 
            this.lpAltoA.BackColor = System.Drawing.Color.White;
            this.lpAltoA.Location = new System.Drawing.Point(999, 3);
            this.lpAltoA.Name = "lpAltoA";
            this.lpAltoA.Size = new System.Drawing.Size(246, 204);
            this.lpAltoA.TabIndex = 4;
            // 
            // lpMedioE
            // 
            this.lpMedioE.BackColor = System.Drawing.Color.White;
            this.lpMedioE.Location = new System.Drawing.Point(3, 213);
            this.lpMedioE.Name = "lpMedioE";
            this.lpMedioE.Size = new System.Drawing.Size(243, 204);
            this.lpMedioE.TabIndex = 5;
            // 
            // lpMedioD
            // 
            this.lpMedioD.BackColor = System.Drawing.Color.White;
            this.lpMedioD.Location = new System.Drawing.Point(252, 213);
            this.lpMedioD.Name = "lpMedioD";
            this.lpMedioD.Size = new System.Drawing.Size(243, 204);
            this.lpMedioD.TabIndex = 6;
            // 
            // lpMedioC
            // 
            this.lpMedioC.BackColor = System.Drawing.Color.White;
            this.lpMedioC.Location = new System.Drawing.Point(501, 213);
            this.lpMedioC.Name = "lpMedioC";
            this.lpMedioC.Size = new System.Drawing.Size(243, 204);
            this.lpMedioC.TabIndex = 7;
            // 
            // lpMedioB
            // 
            this.lpMedioB.BackColor = System.Drawing.Color.White;
            this.lpMedioB.Location = new System.Drawing.Point(750, 213);
            this.lpMedioB.Name = "lpMedioB";
            this.lpMedioB.Size = new System.Drawing.Size(243, 204);
            this.lpMedioB.TabIndex = 8;
            // 
            // lpMedioA
            // 
            this.lpMedioA.BackColor = System.Drawing.Color.White;
            this.lpMedioA.Location = new System.Drawing.Point(999, 213);
            this.lpMedioA.Name = "lpMedioA";
            this.lpMedioA.Size = new System.Drawing.Size(246, 204);
            this.lpMedioA.TabIndex = 9;
            // 
            // lpBajoE
            // 
            this.lpBajoE.BackColor = System.Drawing.Color.White;
            this.lpBajoE.Location = new System.Drawing.Point(3, 423);
            this.lpBajoE.Name = "lpBajoE";
            this.lpBajoE.Size = new System.Drawing.Size(243, 205);
            this.lpBajoE.TabIndex = 10;
            // 
            // lpBajoD
            // 
            this.lpBajoD.BackColor = System.Drawing.Color.White;
            this.lpBajoD.Location = new System.Drawing.Point(252, 423);
            this.lpBajoD.Name = "lpBajoD";
            this.lpBajoD.Size = new System.Drawing.Size(243, 205);
            this.lpBajoD.TabIndex = 11;
            // 
            // lpBajoC
            // 
            this.lpBajoC.BackColor = System.Drawing.Color.White;
            this.lpBajoC.Location = new System.Drawing.Point(501, 423);
            this.lpBajoC.Name = "lpBajoC";
            this.lpBajoC.Size = new System.Drawing.Size(243, 205);
            this.lpBajoC.TabIndex = 12;
            // 
            // lpBajoB
            // 
            this.lpBajoB.BackColor = System.Drawing.Color.White;
            this.lpBajoB.Location = new System.Drawing.Point(750, 423);
            this.lpBajoB.Name = "lpBajoB";
            this.lpBajoB.Size = new System.Drawing.Size(243, 205);
            this.lpBajoB.TabIndex = 13;
            // 
            // lpBajoA
            // 
            this.lpBajoA.BackColor = System.Drawing.Color.White;
            this.lpBajoA.Location = new System.Drawing.Point(999, 423);
            this.lpBajoA.Name = "lpBajoA";
            this.lpBajoA.Size = new System.Drawing.Size(246, 205);
            this.lpBajoA.TabIndex = 14;
            // 
            // frmAdmCalibrar
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoScroll = true;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(1476, 929);
            this.Controls.Add(this.panel9Box);
            this.Controls.Add(this.gbCupos);
            this.Controls.Add(this.gbBusqueda);
            this.Controls.Add(this.lblCalibracion);
            this.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.Name = "frmAdmCalibrar";
            this.Text = "frmAdmCalibrar";
            this.gbBusqueda.ResumeLayout(false);
            this.gbBusqueda.PerformLayout();
            this.gbCupos.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dgvCupos)).EndInit();
            this.panel9Box.ResumeLayout(false);
            this.panel9Box.PerformLayout();
            this.tlp9Box.ResumeLayout(false);
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
        private System.Windows.Forms.TableLayoutPanel tlp9Box;
        private System.Windows.Forms.FlowLayoutPanel lpAltoE;
        private System.Windows.Forms.FlowLayoutPanel lpAltoD;
        private System.Windows.Forms.FlowLayoutPanel lpAltoC;
        private System.Windows.Forms.FlowLayoutPanel lpAltoB;
        private System.Windows.Forms.FlowLayoutPanel lpAltoA;
        private System.Windows.Forms.FlowLayoutPanel lpMedioE;
        private System.Windows.Forms.FlowLayoutPanel lpMedioD;
        private System.Windows.Forms.FlowLayoutPanel lpMedioC;
        private System.Windows.Forms.FlowLayoutPanel lpMedioB;
        private System.Windows.Forms.FlowLayoutPanel lpMedioA;
        private System.Windows.Forms.FlowLayoutPanel lpBajoE;
        private System.Windows.Forms.FlowLayoutPanel lpBajoD;
        private System.Windows.Forms.FlowLayoutPanel lpBajoC;
        private System.Windows.Forms.FlowLayoutPanel lpBajoB;
        private System.Windows.Forms.FlowLayoutPanel lpBajoA;
    }
}