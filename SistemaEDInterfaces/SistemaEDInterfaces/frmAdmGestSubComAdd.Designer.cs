namespace SistemaEDInterfaces
{
    partial class frmAdmGestSubComAdd
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
            this.cmbCargo = new System.Windows.Forms.ComboBox();
            this.txtPeriodo = new System.Windows.Forms.TextBox();
            this.txtPeso = new System.Windows.Forms.TextBox();
            this.label7 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.btnRegresarAddCom = new System.Windows.Forms.Button();
            this.label4 = new System.Windows.Forms.Label();
            this.btnGuardar = new System.Windows.Forms.Button();
            this.txtDescripcion = new System.Windows.Forms.RichTextBox();
            this.txtNombreSubcomp = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.lblRegistrarObjetivo = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.txtComp = new System.Windows.Forms.TextBox();
            this.btnBusRegSubCom = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // cmbCargo
            // 
            this.cmbCargo.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cmbCargo.FormattingEnabled = true;
            this.cmbCargo.Location = new System.Drawing.Point(753, 111);
            this.cmbCargo.Name = "cmbCargo";
            this.cmbCargo.Size = new System.Drawing.Size(193, 21);
            this.cmbCargo.TabIndex = 39;
            // 
            // txtPeriodo
            // 
            this.txtPeriodo.Enabled = false;
            this.txtPeriodo.Location = new System.Drawing.Point(325, 204);
            this.txtPeriodo.Name = "txtPeriodo";
            this.txtPeriodo.Size = new System.Drawing.Size(193, 20);
            this.txtPeriodo.TabIndex = 38;
            // 
            // txtPeso
            // 
            this.txtPeso.Location = new System.Drawing.Point(753, 163);
            this.txtPeso.MaxLength = 50;
            this.txtPeso.Name = "txtPeso";
            this.txtPeso.Size = new System.Drawing.Size(193, 20);
            this.txtPeso.TabIndex = 37;
            this.txtPeso.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtPeso_KeyPress);
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Font = new System.Drawing.Font("Century Gothic", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label7.Location = new System.Drawing.Point(18, 195);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(92, 24);
            this.label7.TabIndex = 36;
            this.label7.Text = "Periodo:";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Century Gothic", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.Location = new System.Drawing.Point(638, 157);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(63, 24);
            this.label6.TabIndex = 35;
            this.label6.Text = "Peso:";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Century Gothic", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.Location = new System.Drawing.Point(638, 105);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(80, 24);
            this.label5.TabIndex = 34;
            this.label5.Text = "Cargo:";
            // 
            // btnRegresarAddCom
            // 
            this.btnRegresarAddCom.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(157)))), ((int)(((byte)(6)))), ((int)(((byte)(32)))));
            this.btnRegresarAddCom.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnRegresarAddCom.Font = new System.Drawing.Font("Century Gothic", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnRegresarAddCom.ForeColor = System.Drawing.Color.White;
            this.btnRegresarAddCom.Location = new System.Drawing.Point(388, 508);
            this.btnRegresarAddCom.Name = "btnRegresarAddCom";
            this.btnRegresarAddCom.Size = new System.Drawing.Size(158, 26);
            this.btnRegresarAddCom.TabIndex = 33;
            this.btnRegresarAddCom.Text = "Regresar";
            this.btnRegresarAddCom.UseVisualStyleBackColor = false;
            this.btnRegresarAddCom.Click += new System.EventHandler(this.btnRegresarAddCom_Click);
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Century Gothic", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(19, 470);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(135, 17);
            this.label4.TabIndex = 32;
            this.label4.Text = "Max. 200 caracteres";
            // 
            // btnGuardar
            // 
            this.btnGuardar.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(157)))), ((int)(((byte)(6)))), ((int)(((byte)(32)))));
            this.btnGuardar.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnGuardar.Font = new System.Drawing.Font("Century Gothic", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnGuardar.ForeColor = System.Drawing.Color.White;
            this.btnGuardar.Location = new System.Drawing.Point(613, 508);
            this.btnGuardar.Name = "btnGuardar";
            this.btnGuardar.Size = new System.Drawing.Size(158, 26);
            this.btnGuardar.TabIndex = 31;
            this.btnGuardar.Text = "Guardar";
            this.btnGuardar.UseVisualStyleBackColor = false;
            this.btnGuardar.Click += new System.EventHandler(this.btnGuardar_Click);
            // 
            // txtDescripcion
            // 
            this.txtDescripcion.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.txtDescripcion.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtDescripcion.Location = new System.Drawing.Point(22, 288);
            this.txtDescripcion.MaxLength = 200;
            this.txtDescripcion.Name = "txtDescripcion";
            this.txtDescripcion.Size = new System.Drawing.Size(460, 165);
            this.txtDescripcion.TabIndex = 30;
            this.txtDescripcion.Text = "";
            // 
            // txtNombreSubcomp
            // 
            this.txtNombreSubcomp.Location = new System.Drawing.Point(325, 161);
            this.txtNombreSubcomp.MaxLength = 50;
            this.txtNombreSubcomp.Name = "txtNombreSubcomp";
            this.txtNombreSubcomp.Size = new System.Drawing.Size(193, 20);
            this.txtNombreSubcomp.TabIndex = 29;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Century Gothic", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(18, 239);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(134, 24);
            this.label1.TabIndex = 28;
            this.label1.Text = "Descripción:";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Century Gothic", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(16, 152);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(285, 24);
            this.label2.TabIndex = 27;
            this.label2.Text = "Nombre Subcompetencia:";
            // 
            // lblRegistrarObjetivo
            // 
            this.lblRegistrarObjetivo.AutoSize = true;
            this.lblRegistrarObjetivo.Font = new System.Drawing.Font("Century Gothic", 36F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblRegistrarObjetivo.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(66)))), ((int)(((byte)(122)))));
            this.lblRegistrarObjetivo.Location = new System.Drawing.Point(12, 9);
            this.lblRegistrarObjetivo.Name = "lblRegistrarObjetivo";
            this.lblRegistrarObjetivo.Size = new System.Drawing.Size(642, 56);
            this.lblRegistrarObjetivo.TabIndex = 26;
            this.lblRegistrarObjetivo.Text = "Registrar Subcompetencia";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Century Gothic", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(18, 105);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(166, 24);
            this.label3.TabIndex = 40;
            this.label3.Text = "Competencia :";
            this.label3.Click += new System.EventHandler(this.label3_Click);
            // 
            // txtComp
            // 
            this.txtComp.Enabled = false;
            this.txtComp.Location = new System.Drawing.Point(325, 111);
            this.txtComp.Name = "txtComp";
            this.txtComp.Size = new System.Drawing.Size(193, 20);
            this.txtComp.TabIndex = 41;
            // 
            // btnBusRegSubCom
            // 
            this.btnBusRegSubCom.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(157)))), ((int)(((byte)(6)))), ((int)(((byte)(32)))));
            this.btnBusRegSubCom.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.btnBusRegSubCom.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnBusRegSubCom.Font = new System.Drawing.Font("Microsoft Sans Serif", 6F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnBusRegSubCom.ForeColor = System.Drawing.Color.White;
            this.btnBusRegSubCom.ImageAlign = System.Drawing.ContentAlignment.TopCenter;
            this.btnBusRegSubCom.Location = new System.Drawing.Point(523, 111);
            this.btnBusRegSubCom.Name = "btnBusRegSubCom";
            this.btnBusRegSubCom.Size = new System.Drawing.Size(23, 18);
            this.btnBusRegSubCom.TabIndex = 42;
            this.btnBusRegSubCom.Text = "...";
            this.btnBusRegSubCom.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            this.btnBusRegSubCom.UseVisualStyleBackColor = false;
            this.btnBusRegSubCom.Click += new System.EventHandler(this.btnBusRegSubCom_Click);
            // 
            // frmAdmGestSubComAdd
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(1056, 543);
            this.Controls.Add(this.btnBusRegSubCom);
            this.Controls.Add(this.txtComp);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.cmbCargo);
            this.Controls.Add(this.txtPeriodo);
            this.Controls.Add(this.txtPeso);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.btnRegresarAddCom);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.btnGuardar);
            this.Controls.Add(this.txtDescripcion);
            this.Controls.Add(this.txtNombreSubcomp);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.lblRegistrarObjetivo);
            this.Name = "frmAdmGestSubComAdd";
            this.Text = "frmAdmGestSubComAdd";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.ComboBox cmbCargo;
        private System.Windows.Forms.TextBox txtPeriodo;
        private System.Windows.Forms.TextBox txtPeso;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Button btnRegresarAddCom;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Button btnGuardar;
        private System.Windows.Forms.RichTextBox txtDescripcion;
        private System.Windows.Forms.TextBox txtNombreSubcomp;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label lblRegistrarObjetivo;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox txtComp;
        private System.Windows.Forms.Button btnBusRegSubCom;
    }
}