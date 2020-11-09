namespace SistemaEDInterfaces
{
    partial class frmEvMisTrabajadoresOpciones
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
            this.lblMisObjetivos = new System.Windows.Forms.Label();
            this.btnPrevia = new System.Windows.Forms.Button();
            this.btnFinal = new System.Windows.Forms.Button();
            this.btnPotencial = new System.Windows.Forms.Button();
            this.btnRegresar = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // lblMisObjetivos
            // 
            this.lblMisObjetivos.AutoSize = true;
            this.lblMisObjetivos.Font = new System.Drawing.Font("Century Gothic", 36F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblMisObjetivos.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(66)))), ((int)(((byte)(122)))));
            this.lblMisObjetivos.Location = new System.Drawing.Point(12, 9);
            this.lblMisObjetivos.Name = "lblMisObjetivos";
            this.lblMisObjetivos.Size = new System.Drawing.Size(251, 56);
            this.lblMisObjetivos.TabIndex = 2;
            this.lblMisObjetivos.Text = "Opciones";
            // 
            // btnPrevia
            // 
            this.btnPrevia.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(157)))), ((int)(((byte)(6)))), ((int)(((byte)(32)))));
            this.btnPrevia.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnPrevia.Font = new System.Drawing.Font("Century Gothic", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnPrevia.ForeColor = System.Drawing.Color.White;
            this.btnPrevia.Location = new System.Drawing.Point(369, 174);
            this.btnPrevia.Name = "btnPrevia";
            this.btnPrevia.Size = new System.Drawing.Size(272, 26);
            this.btnPrevia.TabIndex = 6;
            this.btnPrevia.Text = "Evaluación Previa de Desempeño";
            this.btnPrevia.UseVisualStyleBackColor = false;
            this.btnPrevia.Click += new System.EventHandler(this.btnPrevia_Click);
            // 
            // btnFinal
            // 
            this.btnFinal.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(157)))), ((int)(((byte)(6)))), ((int)(((byte)(32)))));
            this.btnFinal.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnFinal.Font = new System.Drawing.Font("Century Gothic", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnFinal.ForeColor = System.Drawing.Color.White;
            this.btnFinal.Location = new System.Drawing.Point(369, 246);
            this.btnFinal.Name = "btnFinal";
            this.btnFinal.Size = new System.Drawing.Size(272, 26);
            this.btnFinal.TabIndex = 7;
            this.btnFinal.Text = "Evaluación Final de Desempeño";
            this.btnFinal.UseVisualStyleBackColor = false;
            this.btnFinal.Click += new System.EventHandler(this.btnFinal_Click);
            // 
            // btnPotencial
            // 
            this.btnPotencial.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(157)))), ((int)(((byte)(6)))), ((int)(((byte)(32)))));
            this.btnPotencial.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnPotencial.Font = new System.Drawing.Font("Century Gothic", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnPotencial.ForeColor = System.Drawing.Color.White;
            this.btnPotencial.Location = new System.Drawing.Point(369, 317);
            this.btnPotencial.Name = "btnPotencial";
            this.btnPotencial.Size = new System.Drawing.Size(272, 26);
            this.btnPotencial.TabIndex = 8;
            this.btnPotencial.Text = "Evaluación de Potencial";
            this.btnPotencial.UseVisualStyleBackColor = false;
            this.btnPotencial.Click += new System.EventHandler(this.btnPotencial_Click);
            // 
            // btnRegresar
            // 
            this.btnRegresar.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(157)))), ((int)(((byte)(6)))), ((int)(((byte)(32)))));
            this.btnRegresar.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnRegresar.Font = new System.Drawing.Font("Century Gothic", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnRegresar.ForeColor = System.Drawing.Color.White;
            this.btnRegresar.Location = new System.Drawing.Point(877, 39);
            this.btnRegresar.Name = "btnRegresar";
            this.btnRegresar.Size = new System.Drawing.Size(158, 26);
            this.btnRegresar.TabIndex = 17;
            this.btnRegresar.Text = "Regresar";
            this.btnRegresar.UseVisualStyleBackColor = false;
            this.btnRegresar.Click += new System.EventHandler(this.btnRegresar_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(18, 99);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(295, 24);
            this.label1.TabIndex = 27;
            this.label1.Text = "Seleccione un tipo de evaluación:";
            // 
            // frmEvMisTrabajadoresOpciones
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(1108, 749);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.btnRegresar);
            this.Controls.Add(this.btnPotencial);
            this.Controls.Add(this.btnFinal);
            this.Controls.Add(this.btnPrevia);
            this.Controls.Add(this.lblMisObjetivos);
            this.Name = "frmEvMisTrabajadoresOpciones";
            this.Text = "frmEvMisTrabajadoresOpciones";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lblMisObjetivos;
        private System.Windows.Forms.Button btnPrevia;
        private System.Windows.Forms.Button btnFinal;
        private System.Windows.Forms.Button btnPotencial;
        private System.Windows.Forms.Button btnRegresar;
        private System.Windows.Forms.Label label1;
    }
}