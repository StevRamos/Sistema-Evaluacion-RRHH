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
            this.rdbActCargaMavCargo = new System.Windows.Forms.RadioButton();
            this.rdbInsCargaMavCargo = new System.Windows.Forms.RadioButton();
            this.label1 = new System.Windows.Forms.Label();
            this.txtNomArchCargoMav = new System.Windows.Forms.TextBox();
            this.btnGestCargoSelecCargo = new System.Windows.Forms.Button();
            this.label2 = new System.Windows.Forms.Label();
            this.btnRegreCargMavCargo = new System.Windows.Forms.Button();
            this.btnCargarCargoMasiva = new System.Windows.Forms.Button();
            this.lblRegistrarObjetivo = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // rdbActCargaMavCargo
            // 
            this.rdbActCargaMavCargo.AutoSize = true;
            this.rdbActCargaMavCargo.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.rdbActCargaMavCargo.Location = new System.Drawing.Point(641, 198);
            this.rdbActCargaMavCargo.Name = "rdbActCargaMavCargo";
            this.rdbActCargaMavCargo.Size = new System.Drawing.Size(129, 27);
            this.rdbActCargaMavCargo.TabIndex = 81;
            this.rdbActCargaMavCargo.TabStop = true;
            this.rdbActCargaMavCargo.Text = "Actualizar";
            this.rdbActCargaMavCargo.UseVisualStyleBackColor = true;
            // 
            // rdbInsCargaMavCargo
            // 
            this.rdbInsCargaMavCargo.AutoSize = true;
            this.rdbInsCargaMavCargo.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.rdbInsCargaMavCargo.Location = new System.Drawing.Point(470, 198);
            this.rdbInsCargaMavCargo.Name = "rdbInsCargaMavCargo";
            this.rdbInsCargaMavCargo.Size = new System.Drawing.Size(102, 27);
            this.rdbInsCargaMavCargo.TabIndex = 80;
            this.rdbInsCargaMavCargo.TabStop = true;
            this.rdbInsCargaMavCargo.Text = "Insertar";
            this.rdbInsCargaMavCargo.UseVisualStyleBackColor = true;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Century Gothic", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(19, 195);
            this.label1.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(401, 33);
            this.label1.TabIndex = 79;
            this.label1.Text = "Seleccionar tipo de proceso :";
            // 
            // txtNomArchCargoMav
            // 
            this.txtNomArchCargoMav.Enabled = false;
            this.txtNomArchCargoMav.Location = new System.Drawing.Point(470, 140);
            this.txtNomArchCargoMav.Name = "txtNomArchCargoMav";
            this.txtNomArchCargoMav.Size = new System.Drawing.Size(521, 22);
            this.txtNomArchCargoMav.TabIndex = 78;
            // 
            // btnGestCargoSelecCargo
            // 
            this.btnGestCargoSelecCargo.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(157)))), ((int)(((byte)(6)))), ((int)(((byte)(32)))));
            this.btnGestCargoSelecCargo.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnGestCargoSelecCargo.Font = new System.Drawing.Font("Century Gothic", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnGestCargoSelecCargo.ForeColor = System.Drawing.Color.White;
            this.btnGestCargoSelecCargo.Location = new System.Drawing.Point(1014, 135);
            this.btnGestCargoSelecCargo.Margin = new System.Windows.Forms.Padding(4);
            this.btnGestCargoSelecCargo.Name = "btnGestCargoSelecCargo";
            this.btnGestCargoSelecCargo.Size = new System.Drawing.Size(211, 32);
            this.btnGestCargoSelecCargo.TabIndex = 77;
            this.btnGestCargoSelecCargo.Text = "Seleccionar archivo";
            this.btnGestCargoSelecCargo.UseVisualStyleBackColor = false;
            this.btnGestCargoSelecCargo.Click += new System.EventHandler(this.btnGestCargoSelecCargo_Click);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Century Gothic", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(19, 134);
            this.label2.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(301, 33);
            this.label2.TabIndex = 76;
            this.label2.Text = "Nombre del archivo : ";
            // 
            // btnRegreCargMavCargo
            // 
            this.btnRegreCargMavCargo.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(157)))), ((int)(((byte)(6)))), ((int)(((byte)(32)))));
            this.btnRegreCargMavCargo.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnRegreCargMavCargo.Font = new System.Drawing.Font("Century Gothic", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnRegreCargMavCargo.ForeColor = System.Drawing.Color.White;
            this.btnRegreCargMavCargo.Location = new System.Drawing.Point(127, 333);
            this.btnRegreCargMavCargo.Margin = new System.Windows.Forms.Padding(4);
            this.btnRegreCargMavCargo.Name = "btnRegreCargMavCargo";
            this.btnRegreCargMavCargo.Size = new System.Drawing.Size(211, 32);
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
            this.btnCargarCargoMasiva.Location = new System.Drawing.Point(891, 333);
            this.btnCargarCargoMasiva.Margin = new System.Windows.Forms.Padding(4);
            this.btnCargarCargoMasiva.Name = "btnCargarCargoMasiva";
            this.btnCargarCargoMasiva.Size = new System.Drawing.Size(211, 32);
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
            this.lblRegistrarObjetivo.Location = new System.Drawing.Point(13, 9);
            this.lblRegistrarObjetivo.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblRegistrarObjetivo.Name = "lblRegistrarObjetivo";
            this.lblRegistrarObjetivo.Size = new System.Drawing.Size(763, 70);
            this.lblRegistrarObjetivo.TabIndex = 73;
            this.lblRegistrarObjetivo.Text = "Carga Masiva de Cargos";
            // 
            // frmAdmGestCargoCargaMav
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(1289, 417);
            this.Controls.Add(this.rdbActCargaMavCargo);
            this.Controls.Add(this.rdbInsCargaMavCargo);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.txtNomArchCargoMav);
            this.Controls.Add(this.btnGestCargoSelecCargo);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.btnRegreCargMavCargo);
            this.Controls.Add(this.btnCargarCargoMasiva);
            this.Controls.Add(this.lblRegistrarObjetivo);
            this.Name = "frmAdmGestCargoCargaMav";
            this.Text = "frmAdmGestCargoCargaMav";
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
    }
}