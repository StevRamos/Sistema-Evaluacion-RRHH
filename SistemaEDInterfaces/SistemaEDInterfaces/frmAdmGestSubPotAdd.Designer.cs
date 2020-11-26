namespace SistemaEDInterfaces
{
    partial class frmAdmGestSubPotAdd
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
            this.txtPot = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.cmbCargo = new System.Windows.Forms.ComboBox();
            this.txtPeriodo = new System.Windows.Forms.TextBox();
            this.txtPeso = new System.Windows.Forms.TextBox();
            this.label7 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.btnRegresarAddSubPot = new System.Windows.Forms.Button();
            this.label4 = new System.Windows.Forms.Label();
            this.btnGuardarAddRegSubPot = new System.Windows.Forms.Button();
            this.txtDescripcion = new System.Windows.Forms.RichTextBox();
            this.txtSubpot = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.lblRegistrarObjetivo = new System.Windows.Forms.Label();
            this.btnBusRegSubPot = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // txtPot
            // 
            this.txtPot.Location = new System.Drawing.Point(325, 105);
            this.txtPot.Name = "txtPot";
            this.txtPot.Size = new System.Drawing.Size(193, 20);
            this.txtPot.TabIndex = 57;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Century Gothic", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(18, 105);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(117, 24);
            this.label3.TabIndex = 56;
            this.label3.Text = "Potencial :";
            // 
            // cmbCargo
            // 
            this.cmbCargo.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cmbCargo.FormattingEnabled = true;
            this.cmbCargo.Location = new System.Drawing.Point(753, 104);
            this.cmbCargo.Name = "cmbCargo";
            this.cmbCargo.Size = new System.Drawing.Size(193, 21);
            this.cmbCargo.TabIndex = 55;
            // 
            // txtPeriodo
            // 
            this.txtPeriodo.Enabled = false;
            this.txtPeriodo.Location = new System.Drawing.Point(325, 195);
            this.txtPeriodo.MaxLength = 50;
            this.txtPeriodo.Name = "txtPeriodo";
            this.txtPeriodo.Size = new System.Drawing.Size(193, 20);
            this.txtPeriodo.TabIndex = 54;
            // 
            // txtPeso
            // 
            this.txtPeso.Location = new System.Drawing.Point(753, 146);
            this.txtPeso.MaxLength = 50;
            this.txtPeso.Name = "txtPeso";
            this.txtPeso.Size = new System.Drawing.Size(193, 20);
            this.txtPeso.TabIndex = 53;
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Font = new System.Drawing.Font("Century Gothic", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label7.Location = new System.Drawing.Point(18, 195);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(92, 24);
            this.label7.TabIndex = 52;
            this.label7.Text = "Periodo:";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Century Gothic", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.Location = new System.Drawing.Point(638, 140);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(63, 24);
            this.label6.TabIndex = 51;
            this.label6.Text = "Peso:";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Century Gothic", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.Location = new System.Drawing.Point(638, 99);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(80, 24);
            this.label5.TabIndex = 50;
            this.label5.Text = "Cargo:";
            // 
            // btnRegresarAddSubPot
            // 
            this.btnRegresarAddSubPot.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(157)))), ((int)(((byte)(6)))), ((int)(((byte)(32)))));
            this.btnRegresarAddSubPot.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnRegresarAddSubPot.Font = new System.Drawing.Font("Century Gothic", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnRegresarAddSubPot.ForeColor = System.Drawing.Color.White;
            this.btnRegresarAddSubPot.Location = new System.Drawing.Point(388, 508);
            this.btnRegresarAddSubPot.Name = "btnRegresarAddSubPot";
            this.btnRegresarAddSubPot.Size = new System.Drawing.Size(158, 26);
            this.btnRegresarAddSubPot.TabIndex = 49;
            this.btnRegresarAddSubPot.Text = "Regresar";
            this.btnRegresarAddSubPot.UseVisualStyleBackColor = false;
            this.btnRegresarAddSubPot.Click += new System.EventHandler(this.btnRegresarAddSubPot_Click);
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Century Gothic", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(19, 470);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(135, 17);
            this.label4.TabIndex = 48;
            this.label4.Text = "Max. 200 caracteres";
            // 
            // btnGuardarAddRegSubPot
            // 
            this.btnGuardarAddRegSubPot.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(157)))), ((int)(((byte)(6)))), ((int)(((byte)(32)))));
            this.btnGuardarAddRegSubPot.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnGuardarAddRegSubPot.Font = new System.Drawing.Font("Century Gothic", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnGuardarAddRegSubPot.ForeColor = System.Drawing.Color.White;
            this.btnGuardarAddRegSubPot.Location = new System.Drawing.Point(613, 508);
            this.btnGuardarAddRegSubPot.Name = "btnGuardarAddRegSubPot";
            this.btnGuardarAddRegSubPot.Size = new System.Drawing.Size(158, 26);
            this.btnGuardarAddRegSubPot.TabIndex = 47;
            this.btnGuardarAddRegSubPot.Text = "Guardar";
            this.btnGuardarAddRegSubPot.UseVisualStyleBackColor = false;
            this.btnGuardarAddRegSubPot.Click += new System.EventHandler(this.btnGuardar_Click);
            // 
            // txtDescripcion
            // 
            this.txtDescripcion.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.txtDescripcion.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtDescripcion.Location = new System.Drawing.Point(22, 288);
            this.txtDescripcion.MaxLength = 200;
            this.txtDescripcion.Name = "txtDescripcion";
            this.txtDescripcion.Size = new System.Drawing.Size(460, 165);
            this.txtDescripcion.TabIndex = 46;
            this.txtDescripcion.Text = "";
            // 
            // txtSubpot
            // 
            this.txtSubpot.Location = new System.Drawing.Point(325, 146);
            this.txtSubpot.MaxLength = 50;
            this.txtSubpot.Name = "txtSubpot";
            this.txtSubpot.Size = new System.Drawing.Size(193, 20);
            this.txtSubpot.TabIndex = 45;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Century Gothic", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(18, 239);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(134, 24);
            this.label1.TabIndex = 44;
            this.label1.Text = "Descripción:";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Century Gothic", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(18, 146);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(247, 24);
            this.label2.TabIndex = 43;
            this.label2.Text = "Nombre Subpotencial :";
            // 
            // lblRegistrarObjetivo
            // 
            this.lblRegistrarObjetivo.AutoSize = true;
            this.lblRegistrarObjetivo.Font = new System.Drawing.Font("Century Gothic", 36F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblRegistrarObjetivo.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(66)))), ((int)(((byte)(122)))));
            this.lblRegistrarObjetivo.Location = new System.Drawing.Point(12, 9);
            this.lblRegistrarObjetivo.Name = "lblRegistrarObjetivo";
            this.lblRegistrarObjetivo.Size = new System.Drawing.Size(547, 56);
            this.lblRegistrarObjetivo.TabIndex = 42;
            this.lblRegistrarObjetivo.Text = "Registrar Subpotencial";
            // 
            // btnBusRegSubPot
            // 
            this.btnBusRegSubPot.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(157)))), ((int)(((byte)(6)))), ((int)(((byte)(32)))));
            this.btnBusRegSubPot.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.btnBusRegSubPot.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnBusRegSubPot.Font = new System.Drawing.Font("Microsoft Sans Serif", 6F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnBusRegSubPot.ForeColor = System.Drawing.Color.White;
            this.btnBusRegSubPot.ImageAlign = System.Drawing.ContentAlignment.TopCenter;
            this.btnBusRegSubPot.Location = new System.Drawing.Point(523, 105);
            this.btnBusRegSubPot.Name = "btnBusRegSubPot";
            this.btnBusRegSubPot.Size = new System.Drawing.Size(23, 18);
            this.btnBusRegSubPot.TabIndex = 58;
            this.btnBusRegSubPot.Text = "...";
            this.btnBusRegSubPot.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            this.btnBusRegSubPot.UseVisualStyleBackColor = false;
            this.btnBusRegSubPot.Click += new System.EventHandler(this.btnBusRegSubPot_Click);
            // 
            // frmAdmGestSubPotAdd
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(1056, 543);
            this.Controls.Add(this.btnBusRegSubPot);
            this.Controls.Add(this.txtPot);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.cmbCargo);
            this.Controls.Add(this.txtPeriodo);
            this.Controls.Add(this.txtPeso);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.btnRegresarAddSubPot);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.btnGuardarAddRegSubPot);
            this.Controls.Add(this.txtDescripcion);
            this.Controls.Add(this.txtSubpot);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.lblRegistrarObjetivo);
            this.Name = "frmAdmGestSubPotAdd";
            this.Text = "frmAdmGestSubPotAdd";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox txtPot;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.ComboBox cmbCargo;
        private System.Windows.Forms.TextBox txtPeriodo;
        private System.Windows.Forms.TextBox txtPeso;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Button btnRegresarAddSubPot;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Button btnGuardarAddRegSubPot;
        private System.Windows.Forms.RichTextBox txtDescripcion;
        private System.Windows.Forms.TextBox txtSubpot;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label lblRegistrarObjetivo;
        private System.Windows.Forms.Button btnBusRegSubPot;
    }
}