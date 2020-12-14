namespace SistemaEDInterfaces
{
    partial class frmAdmGestGerenCargaMav
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmAdmGestGerenCargaMav));
            this.rdbActCargaMavGer = new System.Windows.Forms.RadioButton();
            this.rdbInsCargaMavGer = new System.Windows.Forms.RadioButton();
            this.label1 = new System.Windows.Forms.Label();
            this.txtNomArchGerenMav = new System.Windows.Forms.TextBox();
            this.btnGestGerSelecGer = new System.Windows.Forms.Button();
            this.label2 = new System.Windows.Forms.Label();
            this.btnRegreCargMavGer = new System.Windows.Forms.Button();
            this.btnCargarGerMasiva = new System.Windows.Forms.Button();
            this.lblRegistrarObjetivo = new System.Windows.Forms.Label();
            this.sfdReporte = new System.Windows.Forms.SaveFileDialog();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // rdbActCargaMavGer
            // 
            this.rdbActCargaMavGer.AutoSize = true;
            this.rdbActCargaMavGer.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.rdbActCargaMavGer.Location = new System.Drawing.Point(481, 161);
            this.rdbActCargaMavGer.Margin = new System.Windows.Forms.Padding(2);
            this.rdbActCargaMavGer.Name = "rdbActCargaMavGer";
            this.rdbActCargaMavGer.Size = new System.Drawing.Size(108, 25);
            this.rdbActCargaMavGer.TabIndex = 81;
            this.rdbActCargaMavGer.TabStop = true;
            this.rdbActCargaMavGer.Text = "Actualizar";
            this.rdbActCargaMavGer.UseVisualStyleBackColor = true;
            // 
            // rdbInsCargaMavGer
            // 
            this.rdbInsCargaMavGer.AutoSize = true;
            this.rdbInsCargaMavGer.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.rdbInsCargaMavGer.Location = new System.Drawing.Point(352, 161);
            this.rdbInsCargaMavGer.Margin = new System.Windows.Forms.Padding(2);
            this.rdbInsCargaMavGer.Name = "rdbInsCargaMavGer";
            this.rdbInsCargaMavGer.Size = new System.Drawing.Size(87, 25);
            this.rdbInsCargaMavGer.TabIndex = 80;
            this.rdbInsCargaMavGer.TabStop = true;
            this.rdbInsCargaMavGer.Text = "Insertar";
            this.rdbInsCargaMavGer.UseVisualStyleBackColor = true;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Century Gothic", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(14, 158);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(310, 24);
            this.label1.TabIndex = 79;
            this.label1.Text = "Seleccionar tipo de proceso :";
            // 
            // txtNomArchGerenMav
            // 
            this.txtNomArchGerenMav.Enabled = false;
            this.txtNomArchGerenMav.Location = new System.Drawing.Point(352, 114);
            this.txtNomArchGerenMav.Margin = new System.Windows.Forms.Padding(2);
            this.txtNomArchGerenMav.Name = "txtNomArchGerenMav";
            this.txtNomArchGerenMav.Size = new System.Drawing.Size(392, 20);
            this.txtNomArchGerenMav.TabIndex = 78;
            // 
            // btnGestGerSelecGer
            // 
            this.btnGestGerSelecGer.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(157)))), ((int)(((byte)(6)))), ((int)(((byte)(32)))));
            this.btnGestGerSelecGer.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnGestGerSelecGer.Font = new System.Drawing.Font("Century Gothic", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnGestGerSelecGer.ForeColor = System.Drawing.Color.White;
            this.btnGestGerSelecGer.Location = new System.Drawing.Point(760, 110);
            this.btnGestGerSelecGer.Name = "btnGestGerSelecGer";
            this.btnGestGerSelecGer.Size = new System.Drawing.Size(158, 26);
            this.btnGestGerSelecGer.TabIndex = 77;
            this.btnGestGerSelecGer.Text = "Seleccionar archivo";
            this.btnGestGerSelecGer.UseVisualStyleBackColor = false;
            this.btnGestGerSelecGer.Click += new System.EventHandler(this.btnGestGerSelecGer_Click);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Century Gothic", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(14, 109);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(234, 24);
            this.label2.TabIndex = 76;
            this.label2.Text = "Nombre del archivo : ";
            // 
            // btnRegreCargMavGer
            // 
            this.btnRegreCargMavGer.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(157)))), ((int)(((byte)(6)))), ((int)(((byte)(32)))));
            this.btnRegreCargMavGer.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnRegreCargMavGer.Font = new System.Drawing.Font("Century Gothic", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnRegreCargMavGer.ForeColor = System.Drawing.Color.White;
            this.btnRegreCargMavGer.Location = new System.Drawing.Point(95, 271);
            this.btnRegreCargMavGer.Name = "btnRegreCargMavGer";
            this.btnRegreCargMavGer.Size = new System.Drawing.Size(158, 26);
            this.btnRegreCargMavGer.TabIndex = 75;
            this.btnRegreCargMavGer.Text = "Regresar";
            this.btnRegreCargMavGer.UseVisualStyleBackColor = false;
            this.btnRegreCargMavGer.Click += new System.EventHandler(this.btnRegreCargMavGer_Click);
            // 
            // btnCargarGerMasiva
            // 
            this.btnCargarGerMasiva.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(157)))), ((int)(((byte)(6)))), ((int)(((byte)(32)))));
            this.btnCargarGerMasiva.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnCargarGerMasiva.Font = new System.Drawing.Font("Century Gothic", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnCargarGerMasiva.ForeColor = System.Drawing.Color.White;
            this.btnCargarGerMasiva.Location = new System.Drawing.Point(668, 271);
            this.btnCargarGerMasiva.Name = "btnCargarGerMasiva";
            this.btnCargarGerMasiva.Size = new System.Drawing.Size(158, 26);
            this.btnCargarGerMasiva.TabIndex = 74;
            this.btnCargarGerMasiva.Text = "Cargar Archivo";
            this.btnCargarGerMasiva.UseVisualStyleBackColor = false;
            this.btnCargarGerMasiva.Click += new System.EventHandler(this.btnCargarComMasiva_Click);
            // 
            // lblRegistrarObjetivo
            // 
            this.lblRegistrarObjetivo.AutoSize = true;
            this.lblRegistrarObjetivo.Font = new System.Drawing.Font("Century Gothic", 36F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblRegistrarObjetivo.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(66)))), ((int)(((byte)(122)))));
            this.lblRegistrarObjetivo.Location = new System.Drawing.Point(10, 7);
            this.lblRegistrarObjetivo.Name = "lblRegistrarObjetivo";
            this.lblRegistrarObjetivo.Size = new System.Drawing.Size(683, 56);
            this.lblRegistrarObjetivo.TabIndex = 73;
            this.lblRegistrarObjetivo.Text = "Carga Masiva de Gerencias";
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox1.Image")));
            this.pictureBox1.Location = new System.Drawing.Point(871, 16);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(47, 47);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBox1.TabIndex = 84;
            this.pictureBox1.TabStop = false;
            this.pictureBox1.Click += new System.EventHandler(this.pictureBox1_Click);
            // 
            // frmAdmGestGerenCargaMav
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(967, 339);
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.rdbActCargaMavGer);
            this.Controls.Add(this.rdbInsCargaMavGer);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.txtNomArchGerenMav);
            this.Controls.Add(this.btnGestGerSelecGer);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.btnRegreCargMavGer);
            this.Controls.Add(this.btnCargarGerMasiva);
            this.Controls.Add(this.lblRegistrarObjetivo);
            this.Margin = new System.Windows.Forms.Padding(2);
            this.Name = "frmAdmGestGerenCargaMav";
            this.Text = "frmAdmGestGerenCargaMav";
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.RadioButton rdbActCargaMavGer;
        private System.Windows.Forms.RadioButton rdbInsCargaMavGer;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox txtNomArchGerenMav;
        private System.Windows.Forms.Button btnGestGerSelecGer;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Button btnRegreCargMavGer;
        private System.Windows.Forms.Button btnCargarGerMasiva;
        private System.Windows.Forms.Label lblRegistrarObjetivo;
        private System.Windows.Forms.SaveFileDialog sfdReporte;
        private System.Windows.Forms.PictureBox pictureBox1;
    }
}