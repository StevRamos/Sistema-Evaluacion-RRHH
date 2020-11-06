namespace SistemaEDInterfaces
{
    partial class frmAdmGestSubPotCrgMav
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
            this.label3 = new System.Windows.Forms.Label();
            this.gbSubPotencial = new System.Windows.Forms.GroupBox();
            this.btnGestSubPotSelecSubPot = new System.Windows.Forms.Button();
            this.txtNomArchSubPotMav = new System.Windows.Forms.TextBox();
            this.rdbActMavSubPot = new System.Windows.Forms.RadioButton();
            this.label1 = new System.Windows.Forms.Label();
            this.rdbInsMavSubPot = new System.Windows.Forms.RadioButton();
            this.label4 = new System.Windows.Forms.Label();
            this.gbSubpotencialesPesos = new System.Windows.Forms.GroupBox();
            this.btnGestSubPotSelecPesos = new System.Windows.Forms.Button();
            this.txtNomArchSubPotPesosMav = new System.Windows.Forms.TextBox();
            this.rdbActMavSubPotPesos = new System.Windows.Forms.RadioButton();
            this.label2 = new System.Windows.Forms.Label();
            this.rdbInsMavSubPotPesos = new System.Windows.Forms.RadioButton();
            this.label5 = new System.Windows.Forms.Label();
            this.btnRegreCargMavSubPot = new System.Windows.Forms.Button();
            this.btnCargarMasivaGestSubPot = new System.Windows.Forms.Button();
            this.gbSubPotencial.SuspendLayout();
            this.gbSubpotencialesPesos.SuspendLayout();
            this.SuspendLayout();
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Century Gothic", 36F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(66)))), ((int)(((byte)(122)))));
            this.label3.Location = new System.Drawing.Point(13, 9);
            this.label3.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(1000, 70);
            this.label3.TabIndex = 91;
            this.label3.Text = "Carga Masiva de Subpotenciales";
            // 
            // gbSubPotencial
            // 
            this.gbSubPotencial.Controls.Add(this.btnGestSubPotSelecSubPot);
            this.gbSubPotencial.Controls.Add(this.txtNomArchSubPotMav);
            this.gbSubPotencial.Controls.Add(this.rdbActMavSubPot);
            this.gbSubPotencial.Controls.Add(this.label1);
            this.gbSubPotencial.Controls.Add(this.rdbInsMavSubPot);
            this.gbSubPotencial.Controls.Add(this.label4);
            this.gbSubPotencial.Font = new System.Drawing.Font("Century Gothic", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.gbSubPotencial.Location = new System.Drawing.Point(25, 102);
            this.gbSubPotencial.Name = "gbSubPotencial";
            this.gbSubPotencial.Size = new System.Drawing.Size(1305, 209);
            this.gbSubPotencial.TabIndex = 92;
            this.gbSubPotencial.TabStop = false;
            this.gbSubPotencial.Text = "Subpotenciales";
            // 
            // btnGestSubPotSelecSubPot
            // 
            this.btnGestSubPotSelecSubPot.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(157)))), ((int)(((byte)(6)))), ((int)(((byte)(32)))));
            this.btnGestSubPotSelecSubPot.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnGestSubPotSelecSubPot.Font = new System.Drawing.Font("Century Gothic", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnGestSubPotSelecSubPot.ForeColor = System.Drawing.Color.White;
            this.btnGestSubPotSelecSubPot.Location = new System.Drawing.Point(1076, 70);
            this.btnGestSubPotSelecSubPot.Margin = new System.Windows.Forms.Padding(4);
            this.btnGestSubPotSelecSubPot.Name = "btnGestSubPotSelecSubPot";
            this.btnGestSubPotSelecSubPot.Size = new System.Drawing.Size(211, 32);
            this.btnGestSubPotSelecSubPot.TabIndex = 68;
            this.btnGestSubPotSelecSubPot.Text = "Seleccionar archivo";
            this.btnGestSubPotSelecSubPot.UseVisualStyleBackColor = false;
            this.btnGestSubPotSelecSubPot.Click += new System.EventHandler(this.btnGestSubPotSelecSubPot_Click_1);
            // 
            // txtNomArchSubPotMav
            // 
            this.txtNomArchSubPotMav.Enabled = false;
            this.txtNomArchSubPotMav.Font = new System.Drawing.Font("Century Gothic", 7.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtNomArchSubPotMav.Location = new System.Drawing.Point(500, 75);
            this.txtNomArchSubPotMav.Name = "txtNomArchSubPotMav";
            this.txtNomArchSubPotMav.Size = new System.Drawing.Size(545, 23);
            this.txtNomArchSubPotMav.TabIndex = 69;
            // 
            // rdbActMavSubPot
            // 
            this.rdbActMavSubPot.AutoSize = true;
            this.rdbActMavSubPot.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.rdbActMavSubPot.Location = new System.Drawing.Point(916, 150);
            this.rdbActMavSubPot.Name = "rdbActMavSubPot";
            this.rdbActMavSubPot.Size = new System.Drawing.Size(129, 27);
            this.rdbActMavSubPot.TabIndex = 72;
            this.rdbActMavSubPot.TabStop = true;
            this.rdbActMavSubPot.Text = "Actualizar";
            this.rdbActMavSubPot.UseVisualStyleBackColor = true;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Century Gothic", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(26, 64);
            this.label1.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(301, 33);
            this.label1.TabIndex = 67;
            this.label1.Text = "Nombre del archivo : ";
            // 
            // rdbInsMavSubPot
            // 
            this.rdbInsMavSubPot.AutoSize = true;
            this.rdbInsMavSubPot.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.rdbInsMavSubPot.Location = new System.Drawing.Point(500, 150);
            this.rdbInsMavSubPot.Name = "rdbInsMavSubPot";
            this.rdbInsMavSubPot.Size = new System.Drawing.Size(102, 27);
            this.rdbInsMavSubPot.TabIndex = 71;
            this.rdbInsMavSubPot.TabStop = true;
            this.rdbInsMavSubPot.Text = "Insertar";
            this.rdbInsMavSubPot.UseVisualStyleBackColor = true;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Century Gothic", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(26, 144);
            this.label4.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(401, 33);
            this.label4.TabIndex = 70;
            this.label4.Text = "Seleccionar tipo de proceso :";
            // 
            // gbSubpotencialesPesos
            // 
            this.gbSubpotencialesPesos.Controls.Add(this.btnGestSubPotSelecPesos);
            this.gbSubpotencialesPesos.Controls.Add(this.txtNomArchSubPotPesosMav);
            this.gbSubpotencialesPesos.Controls.Add(this.rdbActMavSubPotPesos);
            this.gbSubpotencialesPesos.Controls.Add(this.label2);
            this.gbSubpotencialesPesos.Controls.Add(this.rdbInsMavSubPotPesos);
            this.gbSubpotencialesPesos.Controls.Add(this.label5);
            this.gbSubpotencialesPesos.Font = new System.Drawing.Font("Century Gothic", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.gbSubpotencialesPesos.Location = new System.Drawing.Point(25, 330);
            this.gbSubpotencialesPesos.Name = "gbSubpotencialesPesos";
            this.gbSubpotencialesPesos.Size = new System.Drawing.Size(1305, 209);
            this.gbSubpotencialesPesos.TabIndex = 93;
            this.gbSubpotencialesPesos.TabStop = false;
            this.gbSubpotencialesPesos.Text = "Pesos";
            // 
            // btnGestSubPotSelecPesos
            // 
            this.btnGestSubPotSelecPesos.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(157)))), ((int)(((byte)(6)))), ((int)(((byte)(32)))));
            this.btnGestSubPotSelecPesos.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnGestSubPotSelecPesos.Font = new System.Drawing.Font("Century Gothic", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnGestSubPotSelecPesos.ForeColor = System.Drawing.Color.White;
            this.btnGestSubPotSelecPesos.Location = new System.Drawing.Point(1076, 70);
            this.btnGestSubPotSelecPesos.Margin = new System.Windows.Forms.Padding(4);
            this.btnGestSubPotSelecPesos.Name = "btnGestSubPotSelecPesos";
            this.btnGestSubPotSelecPesos.Size = new System.Drawing.Size(211, 32);
            this.btnGestSubPotSelecPesos.TabIndex = 68;
            this.btnGestSubPotSelecPesos.Text = "Seleccionar archivo";
            this.btnGestSubPotSelecPesos.UseVisualStyleBackColor = false;
            this.btnGestSubPotSelecPesos.Click += new System.EventHandler(this.btnGestSubPotSelecPesos_Click);
            // 
            // txtNomArchSubPotPesosMav
            // 
            this.txtNomArchSubPotPesosMav.Enabled = false;
            this.txtNomArchSubPotPesosMav.Font = new System.Drawing.Font("Century Gothic", 7.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtNomArchSubPotPesosMav.Location = new System.Drawing.Point(500, 75);
            this.txtNomArchSubPotPesosMav.Name = "txtNomArchSubPotPesosMav";
            this.txtNomArchSubPotPesosMav.Size = new System.Drawing.Size(545, 23);
            this.txtNomArchSubPotPesosMav.TabIndex = 69;
            // 
            // rdbActMavSubPotPesos
            // 
            this.rdbActMavSubPotPesos.AutoSize = true;
            this.rdbActMavSubPotPesos.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.rdbActMavSubPotPesos.Location = new System.Drawing.Point(916, 150);
            this.rdbActMavSubPotPesos.Name = "rdbActMavSubPotPesos";
            this.rdbActMavSubPotPesos.Size = new System.Drawing.Size(129, 27);
            this.rdbActMavSubPotPesos.TabIndex = 72;
            this.rdbActMavSubPotPesos.TabStop = true;
            this.rdbActMavSubPotPesos.Text = "Actualizar";
            this.rdbActMavSubPotPesos.UseVisualStyleBackColor = true;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Century Gothic", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(26, 64);
            this.label2.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(301, 33);
            this.label2.TabIndex = 67;
            this.label2.Text = "Nombre del archivo : ";
            // 
            // rdbInsMavSubPotPesos
            // 
            this.rdbInsMavSubPotPesos.AutoSize = true;
            this.rdbInsMavSubPotPesos.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.rdbInsMavSubPotPesos.Location = new System.Drawing.Point(500, 150);
            this.rdbInsMavSubPotPesos.Name = "rdbInsMavSubPotPesos";
            this.rdbInsMavSubPotPesos.Size = new System.Drawing.Size(102, 27);
            this.rdbInsMavSubPotPesos.TabIndex = 71;
            this.rdbInsMavSubPotPesos.TabStop = true;
            this.rdbInsMavSubPotPesos.Text = "Insertar";
            this.rdbInsMavSubPotPesos.UseVisualStyleBackColor = true;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Century Gothic", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.Location = new System.Drawing.Point(26, 144);
            this.label5.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(401, 33);
            this.label5.TabIndex = 70;
            this.label5.Text = "Seleccionar tipo de proceso :";
            // 
            // btnRegreCargMavSubPot
            // 
            this.btnRegreCargMavSubPot.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(157)))), ((int)(((byte)(6)))), ((int)(((byte)(32)))));
            this.btnRegreCargMavSubPot.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnRegreCargMavSubPot.Font = new System.Drawing.Font("Century Gothic", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnRegreCargMavSubPot.ForeColor = System.Drawing.Color.White;
            this.btnRegreCargMavSubPot.Location = new System.Drawing.Point(303, 574);
            this.btnRegreCargMavSubPot.Margin = new System.Windows.Forms.Padding(4);
            this.btnRegreCargMavSubPot.Name = "btnRegreCargMavSubPot";
            this.btnRegreCargMavSubPot.Size = new System.Drawing.Size(211, 32);
            this.btnRegreCargMavSubPot.TabIndex = 95;
            this.btnRegreCargMavSubPot.Text = "Regresar";
            this.btnRegreCargMavSubPot.UseVisualStyleBackColor = false;
            this.btnRegreCargMavSubPot.Click += new System.EventHandler(this.btnRegreCargMavSubPot_Click_1);
            // 
            // btnCargarMasivaGestSubPot
            // 
            this.btnCargarMasivaGestSubPot.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(157)))), ((int)(((byte)(6)))), ((int)(((byte)(32)))));
            this.btnCargarMasivaGestSubPot.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnCargarMasivaGestSubPot.Font = new System.Drawing.Font("Century Gothic", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnCargarMasivaGestSubPot.ForeColor = System.Drawing.Color.White;
            this.btnCargarMasivaGestSubPot.Location = new System.Drawing.Point(795, 574);
            this.btnCargarMasivaGestSubPot.Margin = new System.Windows.Forms.Padding(4);
            this.btnCargarMasivaGestSubPot.Name = "btnCargarMasivaGestSubPot";
            this.btnCargarMasivaGestSubPot.Size = new System.Drawing.Size(211, 32);
            this.btnCargarMasivaGestSubPot.TabIndex = 94;
            this.btnCargarMasivaGestSubPot.Text = "Cargar Archivo";
            this.btnCargarMasivaGestSubPot.UseVisualStyleBackColor = false;
            this.btnCargarMasivaGestSubPot.Click += new System.EventHandler(this.btnCargarMasivaGestSubPot_Click);
            // 
            // frmAdmGestSubPotCrgMav
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(1356, 649);
            this.Controls.Add(this.btnRegreCargMavSubPot);
            this.Controls.Add(this.btnCargarMasivaGestSubPot);
            this.Controls.Add(this.gbSubpotencialesPesos);
            this.Controls.Add(this.gbSubPotencial);
            this.Controls.Add(this.label3);
            this.Name = "frmAdmGestSubPotCrgMav";
            this.Text = "frmAdmGestSubPotCrgMav";
            this.gbSubPotencial.ResumeLayout(false);
            this.gbSubPotencial.PerformLayout();
            this.gbSubpotencialesPesos.ResumeLayout(false);
            this.gbSubpotencialesPesos.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.GroupBox gbSubPotencial;
        private System.Windows.Forms.Button btnGestSubPotSelecSubPot;
        private System.Windows.Forms.TextBox txtNomArchSubPotMav;
        private System.Windows.Forms.RadioButton rdbActMavSubPot;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.RadioButton rdbInsMavSubPot;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.GroupBox gbSubpotencialesPesos;
        private System.Windows.Forms.Button btnGestSubPotSelecPesos;
        private System.Windows.Forms.TextBox txtNomArchSubPotPesosMav;
        private System.Windows.Forms.RadioButton rdbActMavSubPotPesos;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.RadioButton rdbInsMavSubPotPesos;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Button btnRegreCargMavSubPot;
        private System.Windows.Forms.Button btnCargarMasivaGestSubPot;
    }
}