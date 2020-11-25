namespace SistemaEDInterfaces
{
    partial class frmAdmGestComCrgMav
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
            this.label2 = new System.Windows.Forms.Label();
            this.lblRegistrarObjetivo = new System.Windows.Forms.Label();
            this.btnGestComSelecCom = new System.Windows.Forms.Button();
            this.txtNomArchComMav = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.rdbInsCargaMavCom = new System.Windows.Forms.RadioButton();
            this.rdbActCargaMavCom = new System.Windows.Forms.RadioButton();
            this.gbCompetencias = new System.Windows.Forms.GroupBox();
            this.gbPesosCompetencia = new System.Windows.Forms.GroupBox();
            this.btnGestComSelecComPesos = new System.Windows.Forms.Button();
            this.txtNomArchCompePesosMav = new System.Windows.Forms.TextBox();
            this.rdbActCargaMavCompePesos = new System.Windows.Forms.RadioButton();
            this.label3 = new System.Windows.Forms.Label();
            this.rdbInsCargaMavCompePesos = new System.Windows.Forms.RadioButton();
            this.label4 = new System.Windows.Forms.Label();
            this.btnRegreCargMavCompePesos = new System.Windows.Forms.Button();
            this.btnCargarCompetMasiva = new System.Windows.Forms.Button();
            this.gbCompetencias.SuspendLayout();
            this.gbPesosCompetencia.SuspendLayout();
            this.SuspendLayout();
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Century Gothic", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(20, 52);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(234, 24);
            this.label2.TabIndex = 67;
            this.label2.Text = "Nombre del archivo : ";
            // 
            // lblRegistrarObjetivo
            // 
            this.lblRegistrarObjetivo.AutoSize = true;
            this.lblRegistrarObjetivo.Font = new System.Drawing.Font("Century Gothic", 36F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblRegistrarObjetivo.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(66)))), ((int)(((byte)(122)))));
            this.lblRegistrarObjetivo.Location = new System.Drawing.Point(10, 7);
            this.lblRegistrarObjetivo.Name = "lblRegistrarObjetivo";
            this.lblRegistrarObjetivo.Size = new System.Drawing.Size(787, 56);
            this.lblRegistrarObjetivo.TabIndex = 64;
            this.lblRegistrarObjetivo.Text = "Carga Masiva de Competencias";
            // 
            // btnGestComSelecCom
            // 
            this.btnGestComSelecCom.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(157)))), ((int)(((byte)(6)))), ((int)(((byte)(32)))));
            this.btnGestComSelecCom.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnGestComSelecCom.Font = new System.Drawing.Font("Century Gothic", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnGestComSelecCom.ForeColor = System.Drawing.Color.White;
            this.btnGestComSelecCom.Location = new System.Drawing.Point(807, 58);
            this.btnGestComSelecCom.Name = "btnGestComSelecCom";
            this.btnGestComSelecCom.Size = new System.Drawing.Size(158, 26);
            this.btnGestComSelecCom.TabIndex = 68;
            this.btnGestComSelecCom.Text = "Seleccionar archivo";
            this.btnGestComSelecCom.UseVisualStyleBackColor = false;
            this.btnGestComSelecCom.Click += new System.EventHandler(this.btnGestComSelecCom_Click);
            // 
            // txtNomArchComMav
            // 
            this.txtNomArchComMav.Enabled = false;
            this.txtNomArchComMav.Font = new System.Drawing.Font("Century Gothic", 7.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtNomArchComMav.Location = new System.Drawing.Point(375, 61);
            this.txtNomArchComMav.Margin = new System.Windows.Forms.Padding(2);
            this.txtNomArchComMav.Name = "txtNomArchComMav";
            this.txtNomArchComMav.Size = new System.Drawing.Size(410, 20);
            this.txtNomArchComMav.TabIndex = 69;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Century Gothic", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(20, 117);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(310, 24);
            this.label1.TabIndex = 70;
            this.label1.Text = "Seleccionar tipo de proceso :";
            // 
            // rdbInsCargaMavCom
            // 
            this.rdbInsCargaMavCom.AutoSize = true;
            this.rdbInsCargaMavCom.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.rdbInsCargaMavCom.Location = new System.Drawing.Point(375, 122);
            this.rdbInsCargaMavCom.Margin = new System.Windows.Forms.Padding(2);
            this.rdbInsCargaMavCom.Name = "rdbInsCargaMavCom";
            this.rdbInsCargaMavCom.Size = new System.Drawing.Size(87, 25);
            this.rdbInsCargaMavCom.TabIndex = 71;
            this.rdbInsCargaMavCom.TabStop = true;
            this.rdbInsCargaMavCom.Text = "Insertar";
            this.rdbInsCargaMavCom.UseVisualStyleBackColor = true;
            // 
            // rdbActCargaMavCom
            // 
            this.rdbActCargaMavCom.AutoSize = true;
            this.rdbActCargaMavCom.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.rdbActCargaMavCom.Location = new System.Drawing.Point(687, 122);
            this.rdbActCargaMavCom.Margin = new System.Windows.Forms.Padding(2);
            this.rdbActCargaMavCom.Name = "rdbActCargaMavCom";
            this.rdbActCargaMavCom.Size = new System.Drawing.Size(108, 25);
            this.rdbActCargaMavCom.TabIndex = 72;
            this.rdbActCargaMavCom.TabStop = true;
            this.rdbActCargaMavCom.Text = "Actualizar";
            this.rdbActCargaMavCom.UseVisualStyleBackColor = true;
            // 
            // gbCompetencias
            // 
            this.gbCompetencias.Controls.Add(this.btnGestComSelecCom);
            this.gbCompetencias.Controls.Add(this.txtNomArchComMav);
            this.gbCompetencias.Controls.Add(this.rdbActCargaMavCom);
            this.gbCompetencias.Controls.Add(this.label2);
            this.gbCompetencias.Controls.Add(this.rdbInsCargaMavCom);
            this.gbCompetencias.Controls.Add(this.label1);
            this.gbCompetencias.Font = new System.Drawing.Font("Century Gothic", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.gbCompetencias.Location = new System.Drawing.Point(19, 83);
            this.gbCompetencias.Margin = new System.Windows.Forms.Padding(2);
            this.gbCompetencias.Name = "gbCompetencias";
            this.gbCompetencias.Padding = new System.Windows.Forms.Padding(2);
            this.gbCompetencias.Size = new System.Drawing.Size(979, 170);
            this.gbCompetencias.TabIndex = 73;
            this.gbCompetencias.TabStop = false;
            this.gbCompetencias.Text = "Competencias";
            this.gbCompetencias.Enter += new System.EventHandler(this.groupBox1_Enter);
            // 
            // gbPesosCompetencia
            // 
            this.gbPesosCompetencia.Controls.Add(this.btnGestComSelecComPesos);
            this.gbPesosCompetencia.Controls.Add(this.txtNomArchCompePesosMav);
            this.gbPesosCompetencia.Controls.Add(this.rdbActCargaMavCompePesos);
            this.gbPesosCompetencia.Controls.Add(this.label3);
            this.gbPesosCompetencia.Controls.Add(this.rdbInsCargaMavCompePesos);
            this.gbPesosCompetencia.Controls.Add(this.label4);
            this.gbPesosCompetencia.Font = new System.Drawing.Font("Century Gothic", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.gbPesosCompetencia.Location = new System.Drawing.Point(19, 268);
            this.gbPesosCompetencia.Margin = new System.Windows.Forms.Padding(2);
            this.gbPesosCompetencia.Name = "gbPesosCompetencia";
            this.gbPesosCompetencia.Padding = new System.Windows.Forms.Padding(2);
            this.gbPesosCompetencia.Size = new System.Drawing.Size(979, 170);
            this.gbPesosCompetencia.TabIndex = 74;
            this.gbPesosCompetencia.TabStop = false;
            this.gbPesosCompetencia.Text = "Pesos";
            // 
            // btnGestComSelecComPesos
            // 
            this.btnGestComSelecComPesos.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(157)))), ((int)(((byte)(6)))), ((int)(((byte)(32)))));
            this.btnGestComSelecComPesos.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnGestComSelecComPesos.Font = new System.Drawing.Font("Century Gothic", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnGestComSelecComPesos.ForeColor = System.Drawing.Color.White;
            this.btnGestComSelecComPesos.Location = new System.Drawing.Point(807, 57);
            this.btnGestComSelecComPesos.Name = "btnGestComSelecComPesos";
            this.btnGestComSelecComPesos.Size = new System.Drawing.Size(158, 26);
            this.btnGestComSelecComPesos.TabIndex = 68;
            this.btnGestComSelecComPesos.Text = "Seleccionar archivo";
            this.btnGestComSelecComPesos.UseVisualStyleBackColor = false;
            this.btnGestComSelecComPesos.Click += new System.EventHandler(this.btnGestComSelecComPesos_Click);
            // 
            // txtNomArchCompePesosMav
            // 
            this.txtNomArchCompePesosMav.Enabled = false;
            this.txtNomArchCompePesosMav.Font = new System.Drawing.Font("Century Gothic", 7.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtNomArchCompePesosMav.Location = new System.Drawing.Point(375, 61);
            this.txtNomArchCompePesosMav.Margin = new System.Windows.Forms.Padding(2);
            this.txtNomArchCompePesosMav.Name = "txtNomArchCompePesosMav";
            this.txtNomArchCompePesosMav.Size = new System.Drawing.Size(410, 20);
            this.txtNomArchCompePesosMav.TabIndex = 69;
            // 
            // rdbActCargaMavCompePesos
            // 
            this.rdbActCargaMavCompePesos.AutoSize = true;
            this.rdbActCargaMavCompePesos.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.rdbActCargaMavCompePesos.Location = new System.Drawing.Point(687, 122);
            this.rdbActCargaMavCompePesos.Margin = new System.Windows.Forms.Padding(2);
            this.rdbActCargaMavCompePesos.Name = "rdbActCargaMavCompePesos";
            this.rdbActCargaMavCompePesos.Size = new System.Drawing.Size(108, 25);
            this.rdbActCargaMavCompePesos.TabIndex = 72;
            this.rdbActCargaMavCompePesos.TabStop = true;
            this.rdbActCargaMavCompePesos.Text = "Actualizar";
            this.rdbActCargaMavCompePesos.UseVisualStyleBackColor = true;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Century Gothic", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(20, 52);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(234, 24);
            this.label3.TabIndex = 67;
            this.label3.Text = "Nombre del archivo : ";
            // 
            // rdbInsCargaMavCompePesos
            // 
            this.rdbInsCargaMavCompePesos.AutoSize = true;
            this.rdbInsCargaMavCompePesos.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.rdbInsCargaMavCompePesos.Location = new System.Drawing.Point(375, 122);
            this.rdbInsCargaMavCompePesos.Margin = new System.Windows.Forms.Padding(2);
            this.rdbInsCargaMavCompePesos.Name = "rdbInsCargaMavCompePesos";
            this.rdbInsCargaMavCompePesos.Size = new System.Drawing.Size(87, 25);
            this.rdbInsCargaMavCompePesos.TabIndex = 71;
            this.rdbInsCargaMavCompePesos.TabStop = true;
            this.rdbInsCargaMavCompePesos.Text = "Insertar";
            this.rdbInsCargaMavCompePesos.UseVisualStyleBackColor = true;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Century Gothic", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(20, 117);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(310, 24);
            this.label4.TabIndex = 70;
            this.label4.Text = "Seleccionar tipo de proceso :";
            // 
            // btnRegreCargMavCompePesos
            // 
            this.btnRegreCargMavCompePesos.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(157)))), ((int)(((byte)(6)))), ((int)(((byte)(32)))));
            this.btnRegreCargMavCompePesos.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnRegreCargMavCompePesos.Font = new System.Drawing.Font("Century Gothic", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnRegreCargMavCompePesos.ForeColor = System.Drawing.Color.White;
            this.btnRegreCargMavCompePesos.Location = new System.Drawing.Point(227, 466);
            this.btnRegreCargMavCompePesos.Name = "btnRegreCargMavCompePesos";
            this.btnRegreCargMavCompePesos.Size = new System.Drawing.Size(158, 26);
            this.btnRegreCargMavCompePesos.TabIndex = 66;
            this.btnRegreCargMavCompePesos.Text = "Regresar";
            this.btnRegreCargMavCompePesos.UseVisualStyleBackColor = false;
            this.btnRegreCargMavCompePesos.Click += new System.EventHandler(this.btnRegreCargMavCompePesos_Click);
            // 
            // btnCargarCompetMasiva
            // 
            this.btnCargarCompetMasiva.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(157)))), ((int)(((byte)(6)))), ((int)(((byte)(32)))));
            this.btnCargarCompetMasiva.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnCargarCompetMasiva.Font = new System.Drawing.Font("Century Gothic", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnCargarCompetMasiva.ForeColor = System.Drawing.Color.White;
            this.btnCargarCompetMasiva.Location = new System.Drawing.Point(596, 466);
            this.btnCargarCompetMasiva.Name = "btnCargarCompetMasiva";
            this.btnCargarCompetMasiva.Size = new System.Drawing.Size(158, 26);
            this.btnCargarCompetMasiva.TabIndex = 65;
            this.btnCargarCompetMasiva.Text = "Cargar Archivo";
            this.btnCargarCompetMasiva.UseVisualStyleBackColor = false;
            this.btnCargarCompetMasiva.Click += new System.EventHandler(this.btnCargarCompetMasiva_Click);
            // 
            // frmAdmGestComCrgMav
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(1017, 527);
            this.Controls.Add(this.gbPesosCompetencia);
            this.Controls.Add(this.lblRegistrarObjetivo);
            this.Controls.Add(this.gbCompetencias);
            this.Controls.Add(this.btnRegreCargMavCompePesos);
            this.Controls.Add(this.btnCargarCompetMasiva);
            this.Margin = new System.Windows.Forms.Padding(2);
            this.MaximumSize = new System.Drawing.Size(1033, 566);
            this.MinimumSize = new System.Drawing.Size(1033, 566);
            this.Name = "frmAdmGestComCrgMav";
            this.Text = "frmAdmGestComCrgMav";
            this.gbCompetencias.ResumeLayout(false);
            this.gbCompetencias.PerformLayout();
            this.gbPesosCompetencia.ResumeLayout(false);
            this.gbPesosCompetencia.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label lblRegistrarObjetivo;
        private System.Windows.Forms.Button btnGestComSelecCom;
        private System.Windows.Forms.TextBox txtNomArchComMav;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.RadioButton rdbInsCargaMavCom;
        private System.Windows.Forms.RadioButton rdbActCargaMavCom;
        private System.Windows.Forms.GroupBox gbCompetencias;
        private System.Windows.Forms.GroupBox gbPesosCompetencia;
        private System.Windows.Forms.Button btnGestComSelecComPesos;
        private System.Windows.Forms.TextBox txtNomArchCompePesosMav;
        private System.Windows.Forms.RadioButton rdbActCargaMavCompePesos;
        private System.Windows.Forms.Button btnRegreCargMavCompePesos;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.RadioButton rdbInsCargaMavCompePesos;
        private System.Windows.Forms.Button btnCargarCompetMasiva;
        private System.Windows.Forms.Label label4;
    }
}