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
            this.lblCalibracion = new System.Windows.Forms.Label();
            this.gbBusqueda = new System.Windows.Forms.GroupBox();
            this.btnBuscar = new System.Windows.Forms.Button();
            this.cbGerencia = new System.Windows.Forms.ComboBox();
            this.lblGerencia = new System.Windows.Forms.Label();
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
            this.panelCupos = new System.Windows.Forms.Panel();
            this.dgvCupos = new SistemaEDInterfaces.dgvCupos();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.lblCuposAsignados = new System.Windows.Forms.Label();
            this.lblCuposUsados = new System.Windows.Forms.Label();
            this.gbBusqueda.SuspendLayout();
            this.panel9Box.SuspendLayout();
            this.panelCupos.SuspendLayout();
            this.groupBox1.SuspendLayout();
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
            this.gbBusqueda.Controls.Add(this.cbGerencia);
            this.gbBusqueda.Controls.Add(this.lblGerencia);
            this.gbBusqueda.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.gbBusqueda.Location = new System.Drawing.Point(28, 116);
            this.gbBusqueda.Name = "gbBusqueda";
            this.gbBusqueda.Size = new System.Drawing.Size(593, 190);
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
            this.btnBuscar.Location = new System.Drawing.Point(313, 134);
            this.btnBuscar.Margin = new System.Windows.Forms.Padding(4);
            this.btnBuscar.Name = "btnBuscar";
            this.btnBuscar.Size = new System.Drawing.Size(211, 32);
            this.btnBuscar.TabIndex = 12;
            this.btnBuscar.Text = "Buscar";
            this.btnBuscar.UseVisualStyleBackColor = false;
            this.btnBuscar.Click += new System.EventHandler(this.btnBuscar_Click);
            // 
            // cbGerencia
            // 
            this.cbGerencia.FormattingEnabled = true;
            this.cbGerencia.Location = new System.Drawing.Point(152, 70);
            this.cbGerencia.Name = "cbGerencia";
            this.cbGerencia.Size = new System.Drawing.Size(407, 37);
            this.cbGerencia.TabIndex = 2;
            // 
            // lblGerencia
            // 
            this.lblGerencia.AutoSize = true;
            this.lblGerencia.Location = new System.Drawing.Point(23, 73);
            this.lblGerencia.Name = "lblGerencia";
            this.lblGerencia.Size = new System.Drawing.Size(123, 29);
            this.lblGerencia.TabIndex = 0;
            this.lblGerencia.Text = "Gerencia :";
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
            this.panel9Box.Location = new System.Drawing.Point(0, 322);
            this.panel9Box.Name = "panel9Box";
            this.panel9Box.Size = new System.Drawing.Size(1455, 922);
            this.panel9Box.TabIndex = 15;
            // 
            // nineBox
            // 
            this.nineBox.AutoSize = true;
            this.nineBox.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.nineBox.ColaboradorSeleccionado = null;
            this.nineBox.Cupos = null;
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
            this.btnGuardar.Location = new System.Drawing.Point(1192, 779);
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
            this.lblE.Location = new System.Drawing.Point(284, 679);
            this.lblE.Name = "lblE";
            this.lblE.Size = new System.Drawing.Size(29, 29);
            this.lblE.TabIndex = 20;
            this.lblE.Text = "E";
            // 
            // lblD
            // 
            this.lblD.AutoSize = true;
            this.lblD.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F);
            this.lblD.Location = new System.Drawing.Point(522, 679);
            this.lblD.Name = "lblD";
            this.lblD.Size = new System.Drawing.Size(30, 29);
            this.lblD.TabIndex = 19;
            this.lblD.Text = "D";
            // 
            // lblC
            // 
            this.lblC.AutoSize = true;
            this.lblC.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F);
            this.lblC.Location = new System.Drawing.Point(778, 679);
            this.lblC.Name = "lblC";
            this.lblC.Size = new System.Drawing.Size(30, 29);
            this.lblC.TabIndex = 18;
            this.lblC.Text = "C";
            // 
            // lblA
            // 
            this.lblA.AutoSize = true;
            this.lblA.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F);
            this.lblA.Location = new System.Drawing.Point(1286, 679);
            this.lblA.Name = "lblA";
            this.lblA.Size = new System.Drawing.Size(28, 29);
            this.lblA.TabIndex = 17;
            this.lblA.Text = "A";
            // 
            // lblB
            // 
            this.lblB.AutoSize = true;
            this.lblB.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F);
            this.lblB.Location = new System.Drawing.Point(1016, 679);
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
            // panelCupos
            // 
            this.panelCupos.Controls.Add(this.dgvCupos);
            this.panelCupos.Location = new System.Drawing.Point(194, 34);
            this.panelCupos.Name = "panelCupos";
            this.panelCupos.Size = new System.Drawing.Size(592, 132);
            this.panelCupos.TabIndex = 17;
            // 
            // dgvCupos
            // 
            this.dgvCupos.Dock = System.Windows.Forms.DockStyle.Fill;
            this.dgvCupos.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F);
            this.dgvCupos.Location = new System.Drawing.Point(0, 0);
            this.dgvCupos.Margin = new System.Windows.Forms.Padding(0);
            this.dgvCupos.Name = "dgvCupos";
            this.dgvCupos.Size = new System.Drawing.Size(592, 132);
            this.dgvCupos.TabIndex = 0;
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.lblCuposAsignados);
            this.groupBox1.Controls.Add(this.lblCuposUsados);
            this.groupBox1.Controls.Add(this.panelCupos);
            this.groupBox1.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.8F);
            this.groupBox1.Location = new System.Drawing.Point(644, 116);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(811, 190);
            this.groupBox1.TabIndex = 18;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Cupos";
            // 
            // lblCuposAsignados
            // 
            this.lblCuposAsignados.AutoSize = true;
            this.lblCuposAsignados.Location = new System.Drawing.Point(20, 70);
            this.lblCuposAsignados.Name = "lblCuposAsignados";
            this.lblCuposAsignados.Size = new System.Drawing.Size(132, 29);
            this.lblCuposAsignados.TabIndex = 19;
            this.lblCuposAsignados.Text = "Asignados:";
            // 
            // lblCuposUsados
            // 
            this.lblCuposUsados.AutoSize = true;
            this.lblCuposUsados.Location = new System.Drawing.Point(51, 125);
            this.lblCuposUsados.Name = "lblCuposUsados";
            this.lblCuposUsados.Size = new System.Drawing.Size(101, 29);
            this.lblCuposUsados.TabIndex = 18;
            this.lblCuposUsados.Text = "Usados:";
            // 
            // frmAdmCalibrar
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoScroll = true;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(1595, 929);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.panel9Box);
            this.Controls.Add(this.gbBusqueda);
            this.Controls.Add(this.lblCalibracion);
            this.Margin = new System.Windows.Forms.Padding(4);
            this.Name = "frmAdmCalibrar";
            this.Text = "frmAdmCalibrar";
            this.gbBusqueda.ResumeLayout(false);
            this.gbBusqueda.PerformLayout();
            this.panel9Box.ResumeLayout(false);
            this.panel9Box.PerformLayout();
            this.panelCupos.ResumeLayout(false);
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Label lblCalibracion;
        private System.Windows.Forms.GroupBox gbBusqueda;
        private System.Windows.Forms.ComboBox cbGerencia;
        private System.Windows.Forms.Label lblGerencia;
        private System.Windows.Forms.Button btnBuscar;
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
        private System.Windows.Forms.Panel panelCupos;
        private dgvCupos dgvCupos;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Label lblCuposUsados;
        private System.Windows.Forms.Label lblCuposAsignados;
    }
}