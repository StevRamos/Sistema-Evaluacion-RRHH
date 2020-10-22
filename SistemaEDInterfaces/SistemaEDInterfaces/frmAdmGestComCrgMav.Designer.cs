namespace SistemaEDInterfaces
{
    partial class frmAdmGestComCrgMav
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
            this.label2 = new System.Windows.Forms.Label();
            this.btnRegreCargMavComp = new System.Windows.Forms.Button();
            this.btnCargarComMasiva = new System.Windows.Forms.Button();
            this.lblRegistrarObjetivo = new System.Windows.Forms.Label();
            this.btnGestComSelecCom = new System.Windows.Forms.Button();
            this.txtNomArchComMav = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.rdbInsCargaMavCom = new System.Windows.Forms.RadioButton();
            this.rdbActCargaMavCom = new System.Windows.Forms.RadioButton();
            this.SuspendLayout();
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Century Gothic", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(19, 134);
            this.label2.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(301, 33);
            this.label2.TabIndex = 67;
            this.label2.Text = "Nombre del archivo : ";
            // 
            // btnRegreCargMavComp
            // 
            this.btnRegreCargMavComp.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(157)))), ((int)(((byte)(6)))), ((int)(((byte)(32)))));
            this.btnRegreCargMavComp.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnRegreCargMavComp.Font = new System.Drawing.Font("Century Gothic", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnRegreCargMavComp.ForeColor = System.Drawing.Color.White;
            this.btnRegreCargMavComp.Location = new System.Drawing.Point(127, 333);
            this.btnRegreCargMavComp.Margin = new System.Windows.Forms.Padding(4);
            this.btnRegreCargMavComp.Name = "btnRegreCargMavComp";
            this.btnRegreCargMavComp.Size = new System.Drawing.Size(211, 32);
            this.btnRegreCargMavComp.TabIndex = 66;
            this.btnRegreCargMavComp.Text = "Regresar";
            this.btnRegreCargMavComp.UseVisualStyleBackColor = false;
            this.btnRegreCargMavComp.Click += new System.EventHandler(this.btnRegreCargMavComp_Click);
            // 
            // btnCargarComMasiva
            // 
            this.btnCargarComMasiva.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(157)))), ((int)(((byte)(6)))), ((int)(((byte)(32)))));
            this.btnCargarComMasiva.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnCargarComMasiva.Font = new System.Drawing.Font("Century Gothic", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnCargarComMasiva.ForeColor = System.Drawing.Color.White;
            this.btnCargarComMasiva.Location = new System.Drawing.Point(891, 333);
            this.btnCargarComMasiva.Margin = new System.Windows.Forms.Padding(4);
            this.btnCargarComMasiva.Name = "btnCargarComMasiva";
            this.btnCargarComMasiva.Size = new System.Drawing.Size(211, 32);
            this.btnCargarComMasiva.TabIndex = 65;
            this.btnCargarComMasiva.Text = "Cargar Archivo";
            this.btnCargarComMasiva.UseVisualStyleBackColor = false;
            this.btnCargarComMasiva.Click += new System.EventHandler(this.btnCargarComMasiva_Click);
            // 
            // lblRegistrarObjetivo
            // 
            this.lblRegistrarObjetivo.AutoSize = true;
            this.lblRegistrarObjetivo.Font = new System.Drawing.Font("Century Gothic", 36F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblRegistrarObjetivo.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(66)))), ((int)(((byte)(122)))));
            this.lblRegistrarObjetivo.Location = new System.Drawing.Point(13, 9);
            this.lblRegistrarObjetivo.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblRegistrarObjetivo.Name = "lblRegistrarObjetivo";
            this.lblRegistrarObjetivo.Size = new System.Drawing.Size(982, 70);
            this.lblRegistrarObjetivo.TabIndex = 64;
            this.lblRegistrarObjetivo.Text = "Carga Masiva de Competencias";
            // 
            // btnGestComSelecCom
            // 
            this.btnGestComSelecCom.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(157)))), ((int)(((byte)(6)))), ((int)(((byte)(32)))));
            this.btnGestComSelecCom.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnGestComSelecCom.Font = new System.Drawing.Font("Century Gothic", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnGestComSelecCom.ForeColor = System.Drawing.Color.White;
            this.btnGestComSelecCom.Location = new System.Drawing.Point(1014, 135);
            this.btnGestComSelecCom.Margin = new System.Windows.Forms.Padding(4);
            this.btnGestComSelecCom.Name = "btnGestComSelecCom";
            this.btnGestComSelecCom.Size = new System.Drawing.Size(211, 32);
            this.btnGestComSelecCom.TabIndex = 68;
            this.btnGestComSelecCom.Text = "Seleccionar archivo";
            this.btnGestComSelecCom.UseVisualStyleBackColor = false;
            this.btnGestComSelecCom.Click += new System.EventHandler(this.btnGestComSelecCom_Click);
            // 
            // txtNomArchComMav
            // 
            this.txtNomArchComMav.Enabled = false;
            this.txtNomArchComMav.Location = new System.Drawing.Point(470, 140);
            this.txtNomArchComMav.Name = "txtNomArchComMav";
            this.txtNomArchComMav.Size = new System.Drawing.Size(521, 22);
            this.txtNomArchComMav.TabIndex = 69;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Century Gothic", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(19, 195);
            this.label1.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(401, 33);
            this.label1.TabIndex = 70;
            this.label1.Text = "Seleccionar tipo de proceso :";
            // 
            // rdbInsCargaMavCom
            // 
            this.rdbInsCargaMavCom.AutoSize = true;
            this.rdbInsCargaMavCom.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.rdbInsCargaMavCom.Location = new System.Drawing.Point(470, 198);
            this.rdbInsCargaMavCom.Name = "rdbInsCargaMavCom";
            this.rdbInsCargaMavCom.Size = new System.Drawing.Size(102, 27);
            this.rdbInsCargaMavCom.TabIndex = 71;
            this.rdbInsCargaMavCom.TabStop = true;
            this.rdbInsCargaMavCom.Text = "Insertar";
            this.rdbInsCargaMavCom.UseVisualStyleBackColor = true;
            // 
            // rdbActCargaMavCom
            // 
            this.rdbActCargaMavCom.AutoSize = true;
            this.rdbActCargaMavCom.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.rdbActCargaMavCom.Location = new System.Drawing.Point(641, 198);
            this.rdbActCargaMavCom.Name = "rdbActCargaMavCom";
            this.rdbActCargaMavCom.Size = new System.Drawing.Size(129, 27);
            this.rdbActCargaMavCom.TabIndex = 72;
            this.rdbActCargaMavCom.TabStop = true;
            this.rdbActCargaMavCom.Text = "Actualizar";
            this.rdbActCargaMavCom.UseVisualStyleBackColor = true;
            // 
            // frmAdmGestComCrgMav
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(1289, 417);
            this.Controls.Add(this.rdbActCargaMavCom);
            this.Controls.Add(this.rdbInsCargaMavCom);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.txtNomArchComMav);
            this.Controls.Add(this.btnGestComSelecCom);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.btnRegreCargMavComp);
            this.Controls.Add(this.btnCargarComMasiva);
            this.Controls.Add(this.lblRegistrarObjetivo);
            this.Name = "frmAdmGestComCrgMav";
            this.Text = "frmAdmGestComCrgMav";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Button btnRegreCargMavComp;
        private System.Windows.Forms.Button btnCargarComMasiva;
        private System.Windows.Forms.Label lblRegistrarObjetivo;
        private System.Windows.Forms.Button btnGestComSelecCom;
        private System.Windows.Forms.TextBox txtNomArchComMav;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.RadioButton rdbInsCargaMavCom;
        private System.Windows.Forms.RadioButton rdbActCargaMavCom;
    }
}