namespace SistemaEDInterfaces
{
    partial class frmAdmGestColabCargaMav
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmAdmGestColabCargaMav));
            this.rdbActCargaMavColab = new System.Windows.Forms.RadioButton();
            this.rdbInsCargaMavColab = new System.Windows.Forms.RadioButton();
            this.label1 = new System.Windows.Forms.Label();
            this.txtNomArchColabMav = new System.Windows.Forms.TextBox();
            this.btnGestColabSelecColab = new System.Windows.Forms.Button();
            this.label2 = new System.Windows.Forms.Label();
            this.btnRegreCargMavColab = new System.Windows.Forms.Button();
            this.btnCargarColabMasiva = new System.Windows.Forms.Button();
            this.lblRegistrarObjetivo = new System.Windows.Forms.Label();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.sfdReporte = new System.Windows.Forms.SaveFileDialog();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // rdbActCargaMavColab
            // 
            this.rdbActCargaMavColab.AutoSize = true;
            this.rdbActCargaMavColab.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.rdbActCargaMavColab.Location = new System.Drawing.Point(481, 161);
            this.rdbActCargaMavColab.Margin = new System.Windows.Forms.Padding(2);
            this.rdbActCargaMavColab.Name = "rdbActCargaMavColab";
            this.rdbActCargaMavColab.Size = new System.Drawing.Size(108, 25);
            this.rdbActCargaMavColab.TabIndex = 81;
            this.rdbActCargaMavColab.TabStop = true;
            this.rdbActCargaMavColab.Text = "Actualizar";
            this.rdbActCargaMavColab.UseVisualStyleBackColor = true;
            // 
            // rdbInsCargaMavColab
            // 
            this.rdbInsCargaMavColab.AutoSize = true;
            this.rdbInsCargaMavColab.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.rdbInsCargaMavColab.Location = new System.Drawing.Point(352, 161);
            this.rdbInsCargaMavColab.Margin = new System.Windows.Forms.Padding(2);
            this.rdbInsCargaMavColab.Name = "rdbInsCargaMavColab";
            this.rdbInsCargaMavColab.Size = new System.Drawing.Size(87, 25);
            this.rdbInsCargaMavColab.TabIndex = 80;
            this.rdbInsCargaMavColab.TabStop = true;
            this.rdbInsCargaMavColab.Text = "Insertar";
            this.rdbInsCargaMavColab.UseVisualStyleBackColor = true;
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
            // txtNomArchColabMav
            // 
            this.txtNomArchColabMav.Enabled = false;
            this.txtNomArchColabMav.Location = new System.Drawing.Point(352, 114);
            this.txtNomArchColabMav.Margin = new System.Windows.Forms.Padding(2);
            this.txtNomArchColabMav.Name = "txtNomArchColabMav";
            this.txtNomArchColabMav.Size = new System.Drawing.Size(392, 20);
            this.txtNomArchColabMav.TabIndex = 78;
            // 
            // btnGestColabSelecColab
            // 
            this.btnGestColabSelecColab.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(157)))), ((int)(((byte)(6)))), ((int)(((byte)(32)))));
            this.btnGestColabSelecColab.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnGestColabSelecColab.Font = new System.Drawing.Font("Century Gothic", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnGestColabSelecColab.ForeColor = System.Drawing.Color.White;
            this.btnGestColabSelecColab.Location = new System.Drawing.Point(760, 110);
            this.btnGestColabSelecColab.Name = "btnGestColabSelecColab";
            this.btnGestColabSelecColab.Size = new System.Drawing.Size(158, 26);
            this.btnGestColabSelecColab.TabIndex = 77;
            this.btnGestColabSelecColab.Text = "Seleccionar archivo";
            this.btnGestColabSelecColab.UseVisualStyleBackColor = false;
            this.btnGestColabSelecColab.Click += new System.EventHandler(this.btnGestColabSelecColab_Click);
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
            // btnRegreCargMavColab
            // 
            this.btnRegreCargMavColab.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(157)))), ((int)(((byte)(6)))), ((int)(((byte)(32)))));
            this.btnRegreCargMavColab.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnRegreCargMavColab.Font = new System.Drawing.Font("Century Gothic", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnRegreCargMavColab.ForeColor = System.Drawing.Color.White;
            this.btnRegreCargMavColab.Location = new System.Drawing.Point(95, 271);
            this.btnRegreCargMavColab.Name = "btnRegreCargMavColab";
            this.btnRegreCargMavColab.Size = new System.Drawing.Size(158, 26);
            this.btnRegreCargMavColab.TabIndex = 75;
            this.btnRegreCargMavColab.Text = "Regresar";
            this.btnRegreCargMavColab.UseVisualStyleBackColor = false;
            this.btnRegreCargMavColab.Click += new System.EventHandler(this.btnRegreCargMavColab_Click);
            // 
            // btnCargarColabMasiva
            // 
            this.btnCargarColabMasiva.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(157)))), ((int)(((byte)(6)))), ((int)(((byte)(32)))));
            this.btnCargarColabMasiva.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnCargarColabMasiva.Font = new System.Drawing.Font("Century Gothic", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnCargarColabMasiva.ForeColor = System.Drawing.Color.White;
            this.btnCargarColabMasiva.Location = new System.Drawing.Point(668, 271);
            this.btnCargarColabMasiva.Name = "btnCargarColabMasiva";
            this.btnCargarColabMasiva.Size = new System.Drawing.Size(158, 26);
            this.btnCargarColabMasiva.TabIndex = 74;
            this.btnCargarColabMasiva.Text = "Cargar Archivo";
            this.btnCargarColabMasiva.UseVisualStyleBackColor = false;
            this.btnCargarColabMasiva.Click += new System.EventHandler(this.btnCargarColabMasiva_Click);
            // 
            // lblRegistrarObjetivo
            // 
            this.lblRegistrarObjetivo.AutoSize = true;
            this.lblRegistrarObjetivo.Font = new System.Drawing.Font("Century Gothic", 36F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblRegistrarObjetivo.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(66)))), ((int)(((byte)(122)))));
            this.lblRegistrarObjetivo.Location = new System.Drawing.Point(10, 7);
            this.lblRegistrarObjetivo.Name = "lblRegistrarObjetivo";
            this.lblRegistrarObjetivo.Size = new System.Drawing.Size(793, 56);
            this.lblRegistrarObjetivo.TabIndex = 73;
            this.lblRegistrarObjetivo.Text = "Carga Masiva de Colaboradores";
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox1.Image")));
            this.pictureBox1.Location = new System.Drawing.Point(929, 16);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(47, 47);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBox1.TabIndex = 82;
            this.pictureBox1.TabStop = false;
            this.pictureBox1.Click += new System.EventHandler(this.pictureBox1_Click_1);
            // 
            // frmAdmGestColabCargaMav
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(1017, 361);
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.rdbActCargaMavColab);
            this.Controls.Add(this.rdbInsCargaMavColab);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.txtNomArchColabMav);
            this.Controls.Add(this.btnGestColabSelecColab);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.btnRegreCargMavColab);
            this.Controls.Add(this.btnCargarColabMasiva);
            this.Controls.Add(this.lblRegistrarObjetivo);
            this.Margin = new System.Windows.Forms.Padding(2);
            this.Name = "frmAdmGestColabCargaMav";
            this.Text = "frmAdmGestColabCargaMav";
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.RadioButton rdbActCargaMavColab;
        private System.Windows.Forms.RadioButton rdbInsCargaMavColab;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox txtNomArchColabMav;
        private System.Windows.Forms.Button btnGestColabSelecColab;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Button btnRegreCargMavColab;
        private System.Windows.Forms.Button btnCargarColabMasiva;
        private System.Windows.Forms.Label lblRegistrarObjetivo;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.SaveFileDialog sfdReporte;
    }
}