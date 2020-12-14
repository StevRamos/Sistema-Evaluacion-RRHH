namespace SistemaEDInterfaces
{
    partial class frmAdmGestPotCrgMav
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmAdmGestPotCrgMav));
            this.label3 = new System.Windows.Forms.Label();
            this.gbPotencial = new System.Windows.Forms.GroupBox();
            this.btnGestPotSelecPot = new System.Windows.Forms.Button();
            this.txtNomArchPotMav = new System.Windows.Forms.TextBox();
            this.rdbActMavPot = new System.Windows.Forms.RadioButton();
            this.label1 = new System.Windows.Forms.Label();
            this.rdbInsMavPot = new System.Windows.Forms.RadioButton();
            this.label4 = new System.Windows.Forms.Label();
            this.gbPotencialesPesos = new System.Windows.Forms.GroupBox();
            this.btnGestPotSelecPotPesos = new System.Windows.Forms.Button();
            this.txtNomArchPotMavPesos = new System.Windows.Forms.TextBox();
            this.rdbActMavPotPesos = new System.Windows.Forms.RadioButton();
            this.label2 = new System.Windows.Forms.Label();
            this.rdbInsMavPotPesos = new System.Windows.Forms.RadioButton();
            this.label5 = new System.Windows.Forms.Label();
            this.btnRegreCargMavPot = new System.Windows.Forms.Button();
            this.btnCargarMasivaGestPot = new System.Windows.Forms.Button();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.sfdReporte = new System.Windows.Forms.SaveFileDialog();
            this.gbPotencial.SuspendLayout();
            this.gbPotencialesPesos.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Century Gothic", 36F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(66)))), ((int)(((byte)(122)))));
            this.label3.Location = new System.Drawing.Point(10, 8);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(712, 56);
            this.label3.TabIndex = 82;
            this.label3.Text = "Carga Masiva de Potenciales";
            // 
            // gbPotencial
            // 
            this.gbPotencial.Controls.Add(this.btnGestPotSelecPot);
            this.gbPotencial.Controls.Add(this.txtNomArchPotMav);
            this.gbPotencial.Controls.Add(this.rdbActMavPot);
            this.gbPotencial.Controls.Add(this.label1);
            this.gbPotencial.Controls.Add(this.rdbInsMavPot);
            this.gbPotencial.Controls.Add(this.label4);
            this.gbPotencial.Font = new System.Drawing.Font("Century Gothic", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.gbPotencial.Location = new System.Drawing.Point(19, 83);
            this.gbPotencial.Margin = new System.Windows.Forms.Padding(2);
            this.gbPotencial.Name = "gbPotencial";
            this.gbPotencial.Padding = new System.Windows.Forms.Padding(2);
            this.gbPotencial.Size = new System.Drawing.Size(979, 170);
            this.gbPotencial.TabIndex = 93;
            this.gbPotencial.TabStop = false;
            this.gbPotencial.Text = "Potenciales";
            // 
            // btnGestPotSelecPot
            // 
            this.btnGestPotSelecPot.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(157)))), ((int)(((byte)(6)))), ((int)(((byte)(32)))));
            this.btnGestPotSelecPot.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnGestPotSelecPot.Font = new System.Drawing.Font("Century Gothic", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnGestPotSelecPot.ForeColor = System.Drawing.Color.White;
            this.btnGestPotSelecPot.Location = new System.Drawing.Point(807, 57);
            this.btnGestPotSelecPot.Name = "btnGestPotSelecPot";
            this.btnGestPotSelecPot.Size = new System.Drawing.Size(158, 26);
            this.btnGestPotSelecPot.TabIndex = 68;
            this.btnGestPotSelecPot.Text = "Seleccionar archivo";
            this.btnGestPotSelecPot.UseVisualStyleBackColor = false;
            this.btnGestPotSelecPot.Click += new System.EventHandler(this.btnGestPotSelecPot_Click);
            // 
            // txtNomArchPotMav
            // 
            this.txtNomArchPotMav.Enabled = false;
            this.txtNomArchPotMav.Font = new System.Drawing.Font("Century Gothic", 7.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtNomArchPotMav.Location = new System.Drawing.Point(375, 61);
            this.txtNomArchPotMav.Margin = new System.Windows.Forms.Padding(2);
            this.txtNomArchPotMav.Name = "txtNomArchPotMav";
            this.txtNomArchPotMav.Size = new System.Drawing.Size(410, 20);
            this.txtNomArchPotMav.TabIndex = 69;
            // 
            // rdbActMavPot
            // 
            this.rdbActMavPot.AutoSize = true;
            this.rdbActMavPot.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.rdbActMavPot.Location = new System.Drawing.Point(687, 122);
            this.rdbActMavPot.Margin = new System.Windows.Forms.Padding(2);
            this.rdbActMavPot.Name = "rdbActMavPot";
            this.rdbActMavPot.Size = new System.Drawing.Size(108, 25);
            this.rdbActMavPot.TabIndex = 72;
            this.rdbActMavPot.TabStop = true;
            this.rdbActMavPot.Text = "Actualizar";
            this.rdbActMavPot.UseVisualStyleBackColor = true;
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
            // rdbInsMavPot
            // 
            this.rdbInsMavPot.AutoSize = true;
            this.rdbInsMavPot.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.rdbInsMavPot.Location = new System.Drawing.Point(375, 122);
            this.rdbInsMavPot.Margin = new System.Windows.Forms.Padding(2);
            this.rdbInsMavPot.Name = "rdbInsMavPot";
            this.rdbInsMavPot.Size = new System.Drawing.Size(87, 25);
            this.rdbInsMavPot.TabIndex = 71;
            this.rdbInsMavPot.TabStop = true;
            this.rdbInsMavPot.Text = "Insertar";
            this.rdbInsMavPot.UseVisualStyleBackColor = true;
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
            // gbPotencialesPesos
            // 
            this.gbPotencialesPesos.Controls.Add(this.btnGestPotSelecPotPesos);
            this.gbPotencialesPesos.Controls.Add(this.txtNomArchPotMavPesos);
            this.gbPotencialesPesos.Controls.Add(this.rdbActMavPotPesos);
            this.gbPotencialesPesos.Controls.Add(this.label2);
            this.gbPotencialesPesos.Controls.Add(this.rdbInsMavPotPesos);
            this.gbPotencialesPesos.Controls.Add(this.label5);
            this.gbPotencialesPesos.Font = new System.Drawing.Font("Century Gothic", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.gbPotencialesPesos.Location = new System.Drawing.Point(19, 268);
            this.gbPotencialesPesos.Margin = new System.Windows.Forms.Padding(2);
            this.gbPotencialesPesos.Name = "gbPotencialesPesos";
            this.gbPotencialesPesos.Padding = new System.Windows.Forms.Padding(2);
            this.gbPotencialesPesos.Size = new System.Drawing.Size(979, 170);
            this.gbPotencialesPesos.TabIndex = 94;
            this.gbPotencialesPesos.TabStop = false;
            this.gbPotencialesPesos.Text = "Pesos";
            // 
            // btnGestPotSelecPotPesos
            // 
            this.btnGestPotSelecPotPesos.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(157)))), ((int)(((byte)(6)))), ((int)(((byte)(32)))));
            this.btnGestPotSelecPotPesos.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnGestPotSelecPotPesos.Font = new System.Drawing.Font("Century Gothic", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnGestPotSelecPotPesos.ForeColor = System.Drawing.Color.White;
            this.btnGestPotSelecPotPesos.Location = new System.Drawing.Point(807, 57);
            this.btnGestPotSelecPotPesos.Name = "btnGestPotSelecPotPesos";
            this.btnGestPotSelecPotPesos.Size = new System.Drawing.Size(158, 26);
            this.btnGestPotSelecPotPesos.TabIndex = 68;
            this.btnGestPotSelecPotPesos.Text = "Seleccionar archivo";
            this.btnGestPotSelecPotPesos.UseVisualStyleBackColor = false;
            this.btnGestPotSelecPotPesos.Click += new System.EventHandler(this.btnGestPotSelecPotPesos_Click);
            // 
            // txtNomArchPotMavPesos
            // 
            this.txtNomArchPotMavPesos.Enabled = false;
            this.txtNomArchPotMavPesos.Font = new System.Drawing.Font("Century Gothic", 7.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtNomArchPotMavPesos.Location = new System.Drawing.Point(375, 61);
            this.txtNomArchPotMavPesos.Margin = new System.Windows.Forms.Padding(2);
            this.txtNomArchPotMavPesos.Name = "txtNomArchPotMavPesos";
            this.txtNomArchPotMavPesos.Size = new System.Drawing.Size(410, 20);
            this.txtNomArchPotMavPesos.TabIndex = 69;
            // 
            // rdbActMavPotPesos
            // 
            this.rdbActMavPotPesos.AutoSize = true;
            this.rdbActMavPotPesos.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.rdbActMavPotPesos.Location = new System.Drawing.Point(687, 122);
            this.rdbActMavPotPesos.Margin = new System.Windows.Forms.Padding(2);
            this.rdbActMavPotPesos.Name = "rdbActMavPotPesos";
            this.rdbActMavPotPesos.Size = new System.Drawing.Size(108, 25);
            this.rdbActMavPotPesos.TabIndex = 72;
            this.rdbActMavPotPesos.TabStop = true;
            this.rdbActMavPotPesos.Text = "Actualizar";
            this.rdbActMavPotPesos.UseVisualStyleBackColor = true;
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
            // rdbInsMavPotPesos
            // 
            this.rdbInsMavPotPesos.AutoSize = true;
            this.rdbInsMavPotPesos.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.rdbInsMavPotPesos.Location = new System.Drawing.Point(375, 122);
            this.rdbInsMavPotPesos.Margin = new System.Windows.Forms.Padding(2);
            this.rdbInsMavPotPesos.Name = "rdbInsMavPotPesos";
            this.rdbInsMavPotPesos.Size = new System.Drawing.Size(87, 25);
            this.rdbInsMavPotPesos.TabIndex = 71;
            this.rdbInsMavPotPesos.TabStop = true;
            this.rdbInsMavPotPesos.Text = "Insertar";
            this.rdbInsMavPotPesos.UseVisualStyleBackColor = true;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Century Gothic", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.Location = new System.Drawing.Point(20, 117);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(310, 24);
            this.label5.TabIndex = 70;
            this.label5.Text = "Seleccionar tipo de proceso :";
            // 
            // btnRegreCargMavPot
            // 
            this.btnRegreCargMavPot.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(157)))), ((int)(((byte)(6)))), ((int)(((byte)(32)))));
            this.btnRegreCargMavPot.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnRegreCargMavPot.Font = new System.Drawing.Font("Century Gothic", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnRegreCargMavPot.ForeColor = System.Drawing.Color.White;
            this.btnRegreCargMavPot.Location = new System.Drawing.Point(227, 466);
            this.btnRegreCargMavPot.Name = "btnRegreCargMavPot";
            this.btnRegreCargMavPot.Size = new System.Drawing.Size(158, 26);
            this.btnRegreCargMavPot.TabIndex = 97;
            this.btnRegreCargMavPot.Text = "Regresar";
            this.btnRegreCargMavPot.UseVisualStyleBackColor = false;
            this.btnRegreCargMavPot.Click += new System.EventHandler(this.btnRegreCargMavPot_Click);
            // 
            // btnCargarMasivaGestPot
            // 
            this.btnCargarMasivaGestPot.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(157)))), ((int)(((byte)(6)))), ((int)(((byte)(32)))));
            this.btnCargarMasivaGestPot.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnCargarMasivaGestPot.Font = new System.Drawing.Font("Century Gothic", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnCargarMasivaGestPot.ForeColor = System.Drawing.Color.White;
            this.btnCargarMasivaGestPot.Location = new System.Drawing.Point(596, 466);
            this.btnCargarMasivaGestPot.Name = "btnCargarMasivaGestPot";
            this.btnCargarMasivaGestPot.Size = new System.Drawing.Size(158, 26);
            this.btnCargarMasivaGestPot.TabIndex = 96;
            this.btnCargarMasivaGestPot.Text = "Cargar Archivo";
            this.btnCargarMasivaGestPot.UseVisualStyleBackColor = false;
            this.btnCargarMasivaGestPot.Click += new System.EventHandler(this.btnCargarMasivaGestPot_Click);
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox1.Image")));
            this.pictureBox1.Location = new System.Drawing.Point(937, 17);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(47, 47);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBox1.TabIndex = 98;
            this.pictureBox1.TabStop = false;
            this.pictureBox1.Click += new System.EventHandler(this.pictureBox1_Click);
            // 
            // frmAdmGestPotCrgMav
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(1017, 527);
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.btnRegreCargMavPot);
            this.Controls.Add(this.gbPotencialesPesos);
            this.Controls.Add(this.btnCargarMasivaGestPot);
            this.Controls.Add(this.gbPotencial);
            this.Controls.Add(this.label3);
            this.Margin = new System.Windows.Forms.Padding(2);
            this.Name = "frmAdmGestPotCrgMav";
            this.Text = "frmAdmGestPotCrgMav";
            this.gbPotencial.ResumeLayout(false);
            this.gbPotencial.PerformLayout();
            this.gbPotencialesPesos.ResumeLayout(false);
            this.gbPotencialesPesos.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.GroupBox gbPotencial;
        private System.Windows.Forms.Button btnGestPotSelecPot;
        private System.Windows.Forms.TextBox txtNomArchPotMav;
        private System.Windows.Forms.RadioButton rdbActMavPot;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.RadioButton rdbInsMavPot;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.GroupBox gbPotencialesPesos;
        private System.Windows.Forms.Button btnGestPotSelecPotPesos;
        private System.Windows.Forms.TextBox txtNomArchPotMavPesos;
        private System.Windows.Forms.RadioButton rdbActMavPotPesos;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.RadioButton rdbInsMavPotPesos;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Button btnRegreCargMavPot;
        private System.Windows.Forms.Button btnCargarMasivaGestPot;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.SaveFileDialog sfdReporte;
    }
}