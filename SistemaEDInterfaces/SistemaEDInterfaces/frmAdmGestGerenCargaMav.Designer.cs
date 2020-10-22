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
            this.rdbActCargaMavGer = new System.Windows.Forms.RadioButton();
            this.rdbInsCargaMavGer = new System.Windows.Forms.RadioButton();
            this.label1 = new System.Windows.Forms.Label();
            this.txtNomArchGerenMav = new System.Windows.Forms.TextBox();
            this.btnGestGerSelecGer = new System.Windows.Forms.Button();
            this.label2 = new System.Windows.Forms.Label();
            this.btnRegreCargMavGer = new System.Windows.Forms.Button();
            this.btnCargarGerMasiva = new System.Windows.Forms.Button();
            this.lblRegistrarObjetivo = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // rdbActCargaMavGer
            // 
            this.rdbActCargaMavGer.AutoSize = true;
            this.rdbActCargaMavGer.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.rdbActCargaMavGer.Location = new System.Drawing.Point(641, 198);
            this.rdbActCargaMavGer.Name = "rdbActCargaMavGer";
            this.rdbActCargaMavGer.Size = new System.Drawing.Size(129, 27);
            this.rdbActCargaMavGer.TabIndex = 81;
            this.rdbActCargaMavGer.TabStop = true;
            this.rdbActCargaMavGer.Text = "Actualizar";
            this.rdbActCargaMavGer.UseVisualStyleBackColor = true;
            // 
            // rdbInsCargaMavGer
            // 
            this.rdbInsCargaMavGer.AutoSize = true;
            this.rdbInsCargaMavGer.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.rdbInsCargaMavGer.Location = new System.Drawing.Point(470, 198);
            this.rdbInsCargaMavGer.Name = "rdbInsCargaMavGer";
            this.rdbInsCargaMavGer.Size = new System.Drawing.Size(102, 27);
            this.rdbInsCargaMavGer.TabIndex = 80;
            this.rdbInsCargaMavGer.TabStop = true;
            this.rdbInsCargaMavGer.Text = "Insertar";
            this.rdbInsCargaMavGer.UseVisualStyleBackColor = true;
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
            // txtNomArchGerenMav
            // 
            this.txtNomArchGerenMav.Enabled = false;
            this.txtNomArchGerenMav.Location = new System.Drawing.Point(470, 140);
            this.txtNomArchGerenMav.Name = "txtNomArchGerenMav";
            this.txtNomArchGerenMav.Size = new System.Drawing.Size(521, 22);
            this.txtNomArchGerenMav.TabIndex = 78;
            // 
            // btnGestGerSelecGer
            // 
            this.btnGestGerSelecGer.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(157)))), ((int)(((byte)(6)))), ((int)(((byte)(32)))));
            this.btnGestGerSelecGer.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnGestGerSelecGer.Font = new System.Drawing.Font("Century Gothic", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnGestGerSelecGer.ForeColor = System.Drawing.Color.White;
            this.btnGestGerSelecGer.Location = new System.Drawing.Point(1014, 135);
            this.btnGestGerSelecGer.Margin = new System.Windows.Forms.Padding(4);
            this.btnGestGerSelecGer.Name = "btnGestGerSelecGer";
            this.btnGestGerSelecGer.Size = new System.Drawing.Size(211, 32);
            this.btnGestGerSelecGer.TabIndex = 77;
            this.btnGestGerSelecGer.Text = "Seleccionar archivo";
            this.btnGestGerSelecGer.UseVisualStyleBackColor = false;
            this.btnGestGerSelecGer.Click += new System.EventHandler(this.btnGestGerSelecGer_Click);
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
            // btnRegreCargMavGer
            // 
            this.btnRegreCargMavGer.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(157)))), ((int)(((byte)(6)))), ((int)(((byte)(32)))));
            this.btnRegreCargMavGer.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnRegreCargMavGer.Font = new System.Drawing.Font("Century Gothic", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnRegreCargMavGer.ForeColor = System.Drawing.Color.White;
            this.btnRegreCargMavGer.Location = new System.Drawing.Point(127, 333);
            this.btnRegreCargMavGer.Margin = new System.Windows.Forms.Padding(4);
            this.btnRegreCargMavGer.Name = "btnRegreCargMavGer";
            this.btnRegreCargMavGer.Size = new System.Drawing.Size(211, 32);
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
            this.btnCargarGerMasiva.Location = new System.Drawing.Point(891, 333);
            this.btnCargarGerMasiva.Margin = new System.Windows.Forms.Padding(4);
            this.btnCargarGerMasiva.Name = "btnCargarGerMasiva";
            this.btnCargarGerMasiva.Size = new System.Drawing.Size(211, 32);
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
            this.lblRegistrarObjetivo.Location = new System.Drawing.Point(13, 9);
            this.lblRegistrarObjetivo.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblRegistrarObjetivo.Name = "lblRegistrarObjetivo";
            this.lblRegistrarObjetivo.Size = new System.Drawing.Size(852, 70);
            this.lblRegistrarObjetivo.TabIndex = 73;
            this.lblRegistrarObjetivo.Text = "Carga Masiva de Gerencias";
            // 
            // frmAdmGestGerenCargaMav
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(1289, 417);
            this.Controls.Add(this.rdbActCargaMavGer);
            this.Controls.Add(this.rdbInsCargaMavGer);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.txtNomArchGerenMav);
            this.Controls.Add(this.btnGestGerSelecGer);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.btnRegreCargMavGer);
            this.Controls.Add(this.btnCargarGerMasiva);
            this.Controls.Add(this.lblRegistrarObjetivo);
            this.Name = "frmAdmGestGerenCargaMav";
            this.Text = "frmAdmGestGerenCargaMav";
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
    }
}