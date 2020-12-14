namespace SistemaEDInterfaces
{
    partial class frmAdmGestSubComCrgMav
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmAdmGestSubComCrgMav));
            this.lblRegistrarObjetivo = new System.Windows.Forms.Label();
            this.gbSubCompetencia = new System.Windows.Forms.GroupBox();
            this.btnGestSubComSelecSubCom = new System.Windows.Forms.Button();
            this.txtNomArchSubComMav = new System.Windows.Forms.TextBox();
            this.rdbActMavSubCom = new System.Windows.Forms.RadioButton();
            this.label3 = new System.Windows.Forms.Label();
            this.rdbInsMavSubCom = new System.Windows.Forms.RadioButton();
            this.label4 = new System.Windows.Forms.Label();
            this.gbPesosSubcompetencia = new System.Windows.Forms.GroupBox();
            this.btnGestSubComSelecPesos = new System.Windows.Forms.Button();
            this.txtNomArchSubComPesosMav = new System.Windows.Forms.TextBox();
            this.rdbActMavSubComPesos = new System.Windows.Forms.RadioButton();
            this.label1 = new System.Windows.Forms.Label();
            this.rdbInsMavSubComPesos = new System.Windows.Forms.RadioButton();
            this.label2 = new System.Windows.Forms.Label();
            this.btnRegreCargMavGestSubCom = new System.Windows.Forms.Button();
            this.btnCargarMasivaGestSubCom = new System.Windows.Forms.Button();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.sfdReporte = new System.Windows.Forms.SaveFileDialog();
            this.gbSubCompetencia.SuspendLayout();
            this.gbPesosSubcompetencia.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // lblRegistrarObjetivo
            // 
            this.lblRegistrarObjetivo.AutoSize = true;
            this.lblRegistrarObjetivo.Font = new System.Drawing.Font("Century Gothic", 36F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblRegistrarObjetivo.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(66)))), ((int)(((byte)(122)))));
            this.lblRegistrarObjetivo.Location = new System.Drawing.Point(10, 7);
            this.lblRegistrarObjetivo.Name = "lblRegistrarObjetivo";
            this.lblRegistrarObjetivo.Size = new System.Drawing.Size(867, 56);
            this.lblRegistrarObjetivo.TabIndex = 73;
            this.lblRegistrarObjetivo.Text = "Carga Masiva de Subcompetencias";
            // 
            // gbSubCompetencia
            // 
            this.gbSubCompetencia.Controls.Add(this.btnGestSubComSelecSubCom);
            this.gbSubCompetencia.Controls.Add(this.txtNomArchSubComMav);
            this.gbSubCompetencia.Controls.Add(this.rdbActMavSubCom);
            this.gbSubCompetencia.Controls.Add(this.label3);
            this.gbSubCompetencia.Controls.Add(this.rdbInsMavSubCom);
            this.gbSubCompetencia.Controls.Add(this.label4);
            this.gbSubCompetencia.Font = new System.Drawing.Font("Century Gothic", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.gbSubCompetencia.Location = new System.Drawing.Point(19, 83);
            this.gbSubCompetencia.Margin = new System.Windows.Forms.Padding(2);
            this.gbSubCompetencia.Name = "gbSubCompetencia";
            this.gbSubCompetencia.Padding = new System.Windows.Forms.Padding(2);
            this.gbSubCompetencia.Size = new System.Drawing.Size(979, 170);
            this.gbSubCompetencia.TabIndex = 75;
            this.gbSubCompetencia.TabStop = false;
            this.gbSubCompetencia.Text = "Subcompetencias";
            // 
            // btnGestSubComSelecSubCom
            // 
            this.btnGestSubComSelecSubCom.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(157)))), ((int)(((byte)(6)))), ((int)(((byte)(32)))));
            this.btnGestSubComSelecSubCom.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnGestSubComSelecSubCom.Font = new System.Drawing.Font("Century Gothic", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnGestSubComSelecSubCom.ForeColor = System.Drawing.Color.White;
            this.btnGestSubComSelecSubCom.Location = new System.Drawing.Point(807, 57);
            this.btnGestSubComSelecSubCom.Name = "btnGestSubComSelecSubCom";
            this.btnGestSubComSelecSubCom.Size = new System.Drawing.Size(158, 26);
            this.btnGestSubComSelecSubCom.TabIndex = 68;
            this.btnGestSubComSelecSubCom.Text = "Seleccionar archivo";
            this.btnGestSubComSelecSubCom.UseVisualStyleBackColor = false;
            this.btnGestSubComSelecSubCom.Click += new System.EventHandler(this.btnGestSubComSelecSubCom_Click_1);
            // 
            // txtNomArchSubComMav
            // 
            this.txtNomArchSubComMav.Enabled = false;
            this.txtNomArchSubComMav.Font = new System.Drawing.Font("Century Gothic", 7.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtNomArchSubComMav.Location = new System.Drawing.Point(375, 61);
            this.txtNomArchSubComMav.Margin = new System.Windows.Forms.Padding(2);
            this.txtNomArchSubComMav.Name = "txtNomArchSubComMav";
            this.txtNomArchSubComMav.Size = new System.Drawing.Size(410, 20);
            this.txtNomArchSubComMav.TabIndex = 69;
            // 
            // rdbActMavSubCom
            // 
            this.rdbActMavSubCom.AutoSize = true;
            this.rdbActMavSubCom.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.rdbActMavSubCom.Location = new System.Drawing.Point(687, 122);
            this.rdbActMavSubCom.Margin = new System.Windows.Forms.Padding(2);
            this.rdbActMavSubCom.Name = "rdbActMavSubCom";
            this.rdbActMavSubCom.Size = new System.Drawing.Size(108, 25);
            this.rdbActMavSubCom.TabIndex = 72;
            this.rdbActMavSubCom.TabStop = true;
            this.rdbActMavSubCom.Text = "Actualizar";
            this.rdbActMavSubCom.UseVisualStyleBackColor = true;
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
            // rdbInsMavSubCom
            // 
            this.rdbInsMavSubCom.AutoSize = true;
            this.rdbInsMavSubCom.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.rdbInsMavSubCom.Location = new System.Drawing.Point(375, 122);
            this.rdbInsMavSubCom.Margin = new System.Windows.Forms.Padding(2);
            this.rdbInsMavSubCom.Name = "rdbInsMavSubCom";
            this.rdbInsMavSubCom.Size = new System.Drawing.Size(87, 25);
            this.rdbInsMavSubCom.TabIndex = 71;
            this.rdbInsMavSubCom.TabStop = true;
            this.rdbInsMavSubCom.Text = "Insertar";
            this.rdbInsMavSubCom.UseVisualStyleBackColor = true;
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
            // gbPesosSubcompetencia
            // 
            this.gbPesosSubcompetencia.Controls.Add(this.btnGestSubComSelecPesos);
            this.gbPesosSubcompetencia.Controls.Add(this.txtNomArchSubComPesosMav);
            this.gbPesosSubcompetencia.Controls.Add(this.rdbActMavSubComPesos);
            this.gbPesosSubcompetencia.Controls.Add(this.label1);
            this.gbPesosSubcompetencia.Controls.Add(this.rdbInsMavSubComPesos);
            this.gbPesosSubcompetencia.Controls.Add(this.label2);
            this.gbPesosSubcompetencia.Font = new System.Drawing.Font("Century Gothic", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.gbPesosSubcompetencia.Location = new System.Drawing.Point(19, 268);
            this.gbPesosSubcompetencia.Margin = new System.Windows.Forms.Padding(2);
            this.gbPesosSubcompetencia.Name = "gbPesosSubcompetencia";
            this.gbPesosSubcompetencia.Padding = new System.Windows.Forms.Padding(2);
            this.gbPesosSubcompetencia.Size = new System.Drawing.Size(979, 170);
            this.gbPesosSubcompetencia.TabIndex = 76;
            this.gbPesosSubcompetencia.TabStop = false;
            this.gbPesosSubcompetencia.Text = "Pesos";
            // 
            // btnGestSubComSelecPesos
            // 
            this.btnGestSubComSelecPesos.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(157)))), ((int)(((byte)(6)))), ((int)(((byte)(32)))));
            this.btnGestSubComSelecPesos.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnGestSubComSelecPesos.Font = new System.Drawing.Font("Century Gothic", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnGestSubComSelecPesos.ForeColor = System.Drawing.Color.White;
            this.btnGestSubComSelecPesos.Location = new System.Drawing.Point(807, 57);
            this.btnGestSubComSelecPesos.Name = "btnGestSubComSelecPesos";
            this.btnGestSubComSelecPesos.Size = new System.Drawing.Size(158, 26);
            this.btnGestSubComSelecPesos.TabIndex = 68;
            this.btnGestSubComSelecPesos.Text = "Seleccionar archivo";
            this.btnGestSubComSelecPesos.UseVisualStyleBackColor = false;
            this.btnGestSubComSelecPesos.Click += new System.EventHandler(this.btnGestSubComSelecPesos_Click);
            // 
            // txtNomArchSubComPesosMav
            // 
            this.txtNomArchSubComPesosMav.Enabled = false;
            this.txtNomArchSubComPesosMav.Font = new System.Drawing.Font("Century Gothic", 7.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtNomArchSubComPesosMav.Location = new System.Drawing.Point(375, 61);
            this.txtNomArchSubComPesosMav.Margin = new System.Windows.Forms.Padding(2);
            this.txtNomArchSubComPesosMav.Name = "txtNomArchSubComPesosMav";
            this.txtNomArchSubComPesosMav.Size = new System.Drawing.Size(410, 20);
            this.txtNomArchSubComPesosMav.TabIndex = 69;
            // 
            // rdbActMavSubComPesos
            // 
            this.rdbActMavSubComPesos.AutoSize = true;
            this.rdbActMavSubComPesos.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.rdbActMavSubComPesos.Location = new System.Drawing.Point(687, 122);
            this.rdbActMavSubComPesos.Margin = new System.Windows.Forms.Padding(2);
            this.rdbActMavSubComPesos.Name = "rdbActMavSubComPesos";
            this.rdbActMavSubComPesos.Size = new System.Drawing.Size(108, 25);
            this.rdbActMavSubComPesos.TabIndex = 72;
            this.rdbActMavSubComPesos.TabStop = true;
            this.rdbActMavSubComPesos.Text = "Actualizar";
            this.rdbActMavSubComPesos.UseVisualStyleBackColor = true;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Century Gothic", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(20, 52);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(234, 24);
            this.label1.TabIndex = 67;
            this.label1.Text = "Nombre del archivo : ";
            // 
            // rdbInsMavSubComPesos
            // 
            this.rdbInsMavSubComPesos.AutoSize = true;
            this.rdbInsMavSubComPesos.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.rdbInsMavSubComPesos.Location = new System.Drawing.Point(375, 122);
            this.rdbInsMavSubComPesos.Margin = new System.Windows.Forms.Padding(2);
            this.rdbInsMavSubComPesos.Name = "rdbInsMavSubComPesos";
            this.rdbInsMavSubComPesos.Size = new System.Drawing.Size(87, 25);
            this.rdbInsMavSubComPesos.TabIndex = 71;
            this.rdbInsMavSubComPesos.TabStop = true;
            this.rdbInsMavSubComPesos.Text = "Insertar";
            this.rdbInsMavSubComPesos.UseVisualStyleBackColor = true;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Century Gothic", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(20, 117);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(310, 24);
            this.label2.TabIndex = 70;
            this.label2.Text = "Seleccionar tipo de proceso :";
            // 
            // btnRegreCargMavGestSubCom
            // 
            this.btnRegreCargMavGestSubCom.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(157)))), ((int)(((byte)(6)))), ((int)(((byte)(32)))));
            this.btnRegreCargMavGestSubCom.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnRegreCargMavGestSubCom.Font = new System.Drawing.Font("Century Gothic", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnRegreCargMavGestSubCom.ForeColor = System.Drawing.Color.White;
            this.btnRegreCargMavGestSubCom.Location = new System.Drawing.Point(227, 466);
            this.btnRegreCargMavGestSubCom.Name = "btnRegreCargMavGestSubCom";
            this.btnRegreCargMavGestSubCom.Size = new System.Drawing.Size(158, 26);
            this.btnRegreCargMavGestSubCom.TabIndex = 78;
            this.btnRegreCargMavGestSubCom.Text = "Regresar";
            this.btnRegreCargMavGestSubCom.UseVisualStyleBackColor = false;
            this.btnRegreCargMavGestSubCom.Click += new System.EventHandler(this.btnRegreCargMavGestSubCom_Click);
            // 
            // btnCargarMasivaGestSubCom
            // 
            this.btnCargarMasivaGestSubCom.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(157)))), ((int)(((byte)(6)))), ((int)(((byte)(32)))));
            this.btnCargarMasivaGestSubCom.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnCargarMasivaGestSubCom.Font = new System.Drawing.Font("Century Gothic", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnCargarMasivaGestSubCom.ForeColor = System.Drawing.Color.White;
            this.btnCargarMasivaGestSubCom.Location = new System.Drawing.Point(596, 466);
            this.btnCargarMasivaGestSubCom.Name = "btnCargarMasivaGestSubCom";
            this.btnCargarMasivaGestSubCom.Size = new System.Drawing.Size(158, 26);
            this.btnCargarMasivaGestSubCom.TabIndex = 77;
            this.btnCargarMasivaGestSubCom.Text = "Cargar Archivo";
            this.btnCargarMasivaGestSubCom.UseVisualStyleBackColor = false;
            this.btnCargarMasivaGestSubCom.Click += new System.EventHandler(this.btnCargarMasivaGestSubCom_Click);
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox1.Image")));
            this.pictureBox1.Location = new System.Drawing.Point(937, 16);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(47, 47);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBox1.TabIndex = 99;
            this.pictureBox1.TabStop = false;
            this.pictureBox1.Click += new System.EventHandler(this.pictureBox1_Click);
            // 
            // frmAdmGestSubComCrgMav
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(1017, 527);
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.btnRegreCargMavGestSubCom);
            this.Controls.Add(this.btnCargarMasivaGestSubCom);
            this.Controls.Add(this.gbPesosSubcompetencia);
            this.Controls.Add(this.gbSubCompetencia);
            this.Controls.Add(this.lblRegistrarObjetivo);
            this.Margin = new System.Windows.Forms.Padding(2);
            this.MaximumSize = new System.Drawing.Size(1033, 566);
            this.MinimumSize = new System.Drawing.Size(1033, 566);
            this.Name = "frmAdmGestSubComCrgMav";
            this.Text = "frmAdmGestSubComCrgMav";
            this.gbSubCompetencia.ResumeLayout(false);
            this.gbSubCompetencia.PerformLayout();
            this.gbPesosSubcompetencia.ResumeLayout(false);
            this.gbPesosSubcompetencia.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Label lblRegistrarObjetivo;
        private System.Windows.Forms.GroupBox gbSubCompetencia;
        private System.Windows.Forms.Button btnGestSubComSelecSubCom;
        private System.Windows.Forms.TextBox txtNomArchSubComMav;
        private System.Windows.Forms.RadioButton rdbActMavSubCom;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.RadioButton rdbInsMavSubCom;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.GroupBox gbPesosSubcompetencia;
        private System.Windows.Forms.Button btnGestSubComSelecPesos;
        private System.Windows.Forms.TextBox txtNomArchSubComPesosMav;
        private System.Windows.Forms.RadioButton rdbActMavSubComPesos;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.RadioButton rdbInsMavSubComPesos;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Button btnRegreCargMavGestSubCom;
        private System.Windows.Forms.Button btnCargarMasivaGestSubCom;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.SaveFileDialog sfdReporte;
    }
}