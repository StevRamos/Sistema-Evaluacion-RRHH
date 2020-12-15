namespace SistemaEDInterfaces
{
    partial class frmAdmGestCargoCargaMav
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmAdmGestCargoCargaMav));
            this.rdbActCargaMavCargo = new System.Windows.Forms.RadioButton();
            this.rdbInsCargaMavCargo = new System.Windows.Forms.RadioButton();
            this.label1 = new System.Windows.Forms.Label();
            this.txtNomArchCargoMav = new System.Windows.Forms.TextBox();
            this.btnGestCargoSelecCargo = new System.Windows.Forms.Button();
            this.label2 = new System.Windows.Forms.Label();
            this.btnRegreCargMavCargo = new System.Windows.Forms.Button();
            this.btnCargarCargoMasiva = new System.Windows.Forms.Button();
            this.lblRegistrarObjetivo = new System.Windows.Forms.Label();
            this.sfdReporte = new System.Windows.Forms.SaveFileDialog();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // rdbActCargaMavCargo
            // 
            this.rdbActCargaMavCargo.AutoSize = true;
            this.rdbActCargaMavCargo.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.rdbActCargaMavCargo.Location = new System.Drawing.Point(481, 161);
            this.rdbActCargaMavCargo.Margin = new System.Windows.Forms.Padding(2);
            this.rdbActCargaMavCargo.Name = "rdbActCargaMavCargo";
            this.rdbActCargaMavCargo.Size = new System.Drawing.Size(108, 25);
            this.rdbActCargaMavCargo.TabIndex = 81;
            this.rdbActCargaMavCargo.TabStop = true;
            this.rdbActCargaMavCargo.Text = "Actualizar";
            this.rdbActCargaMavCargo.UseVisualStyleBackColor = true;
            // 
            // rdbInsCargaMavCargo
            // 
            this.rdbInsCargaMavCargo.AutoSize = true;
            this.rdbInsCargaMavCargo.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.rdbInsCargaMavCargo.Location = new System.Drawing.Point(352, 161);
            this.rdbInsCargaMavCargo.Margin = new System.Windows.Forms.Padding(2);
            this.rdbInsCargaMavCargo.Name = "rdbInsCargaMavCargo";
            this.rdbInsCargaMavCargo.Size = new System.Drawing.Size(87, 25);
            this.rdbInsCargaMavCargo.TabIndex = 80;
            this.rdbInsCargaMavCargo.TabStop = true;
            this.rdbInsCargaMavCargo.Text = "Insertar";
            this.rdbInsCargaMavCargo.UseVisualStyleBackColor = true;
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
            // txtNomArchCargoMav
            // 
            this.txtNomArchCargoMav.Enabled = false;
            this.txtNomArchCargoMav.Location = new System.Drawing.Point(352, 114);
            this.txtNomArchCargoMav.Margin = new System.Windows.Forms.Padding(2);
            this.txtNomArchCargoMav.Name = "txtNomArchCargoMav";
            this.txtNomArchCargoMav.Size = new System.Drawing.Size(392, 20);
            this.txtNomArchCargoMav.TabIndex = 78;
            // 
            // btnGestCargoSelecCargo
            // 
            this.btnGestCargoSelecCargo.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(157)))), ((int)(((byte)(6)))), ((int)(((byte)(32)))));
            this.btnGestCargoSelecCargo.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnGestCargoSelecCargo.Font = new System.Drawing.Font("Century Gothic", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnGestCargoSelecCargo.ForeColor = System.Drawing.Color.White;
            this.btnGestCargoSelecCargo.Location = new System.Drawing.Point(760, 110);
            this.btnGestCargoSelecCargo.Name = "btnGestCargoSelecCargo";
            this.btnGestCargoSelecCargo.Size = new System.Drawing.Size(158, 26);
            this.btnGestCargoSelecCargo.TabIndex = 77;
            this.btnGestCargoSelecCargo.Text = "Seleccionar archivo";
            this.btnGestCargoSelecCargo.UseVisualStyleBackColor = false;
            this.btnGestCargoSelecCargo.Click += new System.EventHandler(this.btnGestCargoSelecCargo_Click);
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
            // btnRegreCargMavCargo
            // 
            this.btnRegreCargMavCargo.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(157)))), ((int)(((byte)(6)))), ((int)(((byte)(32)))));
            this.btnRegreCargMavCargo.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnRegreCargMavCargo.Font = new System.Drawing.Font("Century Gothic", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnRegreCargMavCargo.ForeColor = System.Drawing.Color.White;
            this.btnRegreCargMavCargo.Location = new System.Drawing.Point(95, 271);
            this.btnRegreCargMavCargo.Name = "btnRegreCargMavCargo";
            this.btnRegreCargMavCargo.Size = new System.Drawing.Size(158, 26);
            this.btnRegreCargMavCargo.TabIndex = 75;
            this.btnRegreCargMavCargo.Text = "Regresar";
            this.btnRegreCargMavCargo.UseVisualStyleBackColor = false;
            this.btnRegreCargMavCargo.Click += new System.EventHandler(this.btnRegreCargMavCargo_Click);
            // 
            // btnCargarCargoMasiva
            // 
            this.btnCargarCargoMasiva.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(157)))), ((int)(((byte)(6)))), ((int)(((byte)(32)))));
            this.btnCargarCargoMasiva.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnCargarCargoMasiva.Font = new System.Drawing.Font("Century Gothic", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnCargarCargoMasiva.ForeColor = System.Drawing.Color.White;
            this.btnCargarCargoMasiva.Location = new System.Drawing.Point(668, 271);
            this.btnCargarCargoMasiva.Name = "btnCargarCargoMasiva";
            this.btnCargarCargoMasiva.Size = new System.Drawing.Size(158, 26);
            this.btnCargarCargoMasiva.TabIndex = 74;
            this.btnCargarCargoMasiva.Text = "Cargar Archivo";
            this.btnCargarCargoMasiva.UseVisualStyleBackColor = false;
            this.btnCargarCargoMasiva.Click += new System.EventHandler(this.btnCargarCargoMasiva_Click);
            // 
            // lblRegistrarObjetivo
            // 
            this.lblRegistrarObjetivo.AutoSize = true;
            this.lblRegistrarObjetivo.Font = new System.Drawing.Font("Century Gothic", 36F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblRegistrarObjetivo.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(66)))), ((int)(((byte)(122)))));
            this.lblRegistrarObjetivo.Location = new System.Drawing.Point(10, 7);
            this.lblRegistrarObjetivo.Name = "lblRegistrarObjetivo";
            this.lblRegistrarObjetivo.Size = new System.Drawing.Size(609, 56);
            this.lblRegistrarObjetivo.TabIndex = 73;
            this.lblRegistrarObjetivo.Text = "Carga Masiva de Cargos";
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox1.Image")));
            this.pictureBox1.Location = new System.Drawing.Point(871, 16);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(47, 47);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBox1.TabIndex = 83;
            this.pictureBox1.TabStop = false;
            this.pictureBox1.Click += new System.EventHandler(this.pictureBox1_Click);
            // 
            // frmAdmGestCargoCargaMav
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(967, 339);
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.rdbActCargaMavCargo);
            this.Controls.Add(this.rdbInsCargaMavCargo);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.txtNomArchCargoMav);
            this.Controls.Add(this.btnGestCargoSelecCargo);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.btnRegreCargMavCargo);
            this.Controls.Add(this.btnCargarCargoMasiva);
            this.Controls.Add(this.lblRegistrarObjetivo);
            this.Margin = new System.Windows.Forms.Padding(2);
            this.Name = "frmAdmGestCargoCargaMav";
            this.Text = "frmAdmGestCargoCargaMav";
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.RadioButton rdbActCargaMavCargo;
        private System.Windows.Forms.RadioButton rdbInsCargaMavCargo;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox txtNomArchCargoMav;
        private System.Windows.Forms.Button btnGestCargoSelecCargo;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Button btnRegreCargMavCargo;
        private System.Windows.Forms.Button btnCargarCargoMasiva;
        private System.Windows.Forms.Label lblRegistrarObjetivo;
        private System.Windows.Forms.SaveFileDialog sfdReporte;
        private System.Windows.Forms.PictureBox pictureBox1;
    }
}