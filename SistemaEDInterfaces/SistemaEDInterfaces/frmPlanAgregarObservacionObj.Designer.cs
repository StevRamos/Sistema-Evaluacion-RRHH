namespace SistemaEDInterfaces
{
    partial class frmPlanAgregarObservacionObj
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
            this.lblMaxCaracteres = new System.Windows.Forms.Label();
            this.btnRegistrar = new System.Windows.Forms.Button();
            this.txtObservaciones = new System.Windows.Forms.RichTextBox();
            this.lblObservaciones = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // lblMaxCaracteres
            // 
            this.lblMaxCaracteres.AutoSize = true;
            this.lblMaxCaracteres.Font = new System.Drawing.Font("Century Gothic", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblMaxCaracteres.Location = new System.Drawing.Point(9, 204);
            this.lblMaxCaracteres.Name = "lblMaxCaracteres";
            this.lblMaxCaracteres.Size = new System.Drawing.Size(135, 17);
            this.lblMaxCaracteres.TabIndex = 14;
            this.lblMaxCaracteres.Text = "Max. 200 caracteres";
            // 
            // btnRegistrar
            // 
            this.btnRegistrar.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(157)))), ((int)(((byte)(6)))), ((int)(((byte)(32)))));
            this.btnRegistrar.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnRegistrar.Font = new System.Drawing.Font("Century Gothic", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnRegistrar.ForeColor = System.Drawing.Color.White;
            this.btnRegistrar.Location = new System.Drawing.Point(266, 226);
            this.btnRegistrar.Name = "btnRegistrar";
            this.btnRegistrar.Size = new System.Drawing.Size(158, 26);
            this.btnRegistrar.TabIndex = 13;
            this.btnRegistrar.Text = "Registrar";
            this.btnRegistrar.UseVisualStyleBackColor = false;
            this.btnRegistrar.Click += new System.EventHandler(this.btnRegistrar_Click);
            // 
            // txtObservaciones
            // 
            this.txtObservaciones.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.txtObservaciones.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtObservaciones.Location = new System.Drawing.Point(12, 36);
            this.txtObservaciones.MaxLength = 200;
            this.txtObservaciones.Name = "txtObservaciones";
            this.txtObservaciones.Size = new System.Drawing.Size(414, 165);
            this.txtObservaciones.TabIndex = 12;
            this.txtObservaciones.Text = "";
            // 
            // lblObservaciones
            // 
            this.lblObservaciones.AutoSize = true;
            this.lblObservaciones.Font = new System.Drawing.Font("Century Gothic", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblObservaciones.Location = new System.Drawing.Point(8, 9);
            this.lblObservaciones.Name = "lblObservaciones";
            this.lblObservaciones.Size = new System.Drawing.Size(168, 24);
            this.lblObservaciones.TabIndex = 11;
            this.lblObservaciones.Text = "Observaciones:";
            // 
            // frmPlanAgregarObservacionObj
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(442, 273);
            this.Controls.Add(this.lblMaxCaracteres);
            this.Controls.Add(this.btnRegistrar);
            this.Controls.Add(this.txtObservaciones);
            this.Controls.Add(this.lblObservaciones);
            this.MaximumSize = new System.Drawing.Size(458, 312);
            this.MinimumSize = new System.Drawing.Size(458, 312);
            this.Name = "frmPlanAgregarObservacionObj";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Agregar Observaciones";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.frmPlanAgregarObservacionObj_FormClosing);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lblMaxCaracteres;
        private System.Windows.Forms.Button btnRegistrar;
        private System.Windows.Forms.RichTextBox txtObservaciones;
        private System.Windows.Forms.Label lblObservaciones;
    }
}