namespace SistemaEDInterfaces
{
    partial class frmEvAutoevaluacion
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
            this.label1 = new System.Windows.Forms.Label();
            this.lblTituloCompetencias = new System.Windows.Forms.Label();
            this.lblMisObjetivos = new System.Windows.Forms.Label();
            this.btnGuardar = new System.Windows.Forms.Button();
            this.btnFinalizar = new System.Windows.Forms.Button();
            this.txtNotaObjetivos = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.txtNotaCompetencias = new System.Windows.Forms.TextBox();
            this.lblNotaCompetencias = new System.Windows.Forms.Label();
            this.lblDescripcionCompetencias = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.lblObjetivo = new System.Windows.Forms.Label();
            this.lblCantidad = new System.Windows.Forms.Label();
            this.lblPeso = new System.Windows.Forms.Label();
            this.lblLogro = new System.Windows.Forms.Label();
            this.btnRegresar = new System.Windows.Forms.Button();
            this.lbl1 = new System.Windows.Forms.Label();
            this.lbl2 = new System.Windows.Forms.Label();
            this.lbl3 = new System.Windows.Forms.Label();
            this.lbl5 = new System.Windows.Forms.Label();
            this.lbl4 = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 21.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(66)))), ((int)(((byte)(122)))));
            this.label1.Location = new System.Drawing.Point(20, 166);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(147, 33);
            this.label1.TabIndex = 0;
            this.label1.Text = "Objetivos";
            // 
            // lblTituloCompetencias
            // 
            this.lblTituloCompetencias.AutoSize = true;
            this.lblTituloCompetencias.Font = new System.Drawing.Font("Microsoft Sans Serif", 21.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblTituloCompetencias.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(66)))), ((int)(((byte)(122)))));
            this.lblTituloCompetencias.Location = new System.Drawing.Point(20, 421);
            this.lblTituloCompetencias.Name = "lblTituloCompetencias";
            this.lblTituloCompetencias.Size = new System.Drawing.Size(214, 33);
            this.lblTituloCompetencias.TabIndex = 2;
            this.lblTituloCompetencias.Text = "Competencias";
            // 
            // lblMisObjetivos
            // 
            this.lblMisObjetivos.AutoSize = true;
            this.lblMisObjetivos.Font = new System.Drawing.Font("Century Gothic", 36F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblMisObjetivos.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(66)))), ((int)(((byte)(122)))));
            this.lblMisObjetivos.Location = new System.Drawing.Point(12, 9);
            this.lblMisObjetivos.Name = "lblMisObjetivos";
            this.lblMisObjetivos.Size = new System.Drawing.Size(394, 56);
            this.lblMisObjetivos.TabIndex = 4;
            this.lblMisObjetivos.Text = "AutoEvaluación";
            // 
            // btnGuardar
            // 
            this.btnGuardar.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(157)))), ((int)(((byte)(6)))), ((int)(((byte)(32)))));
            this.btnGuardar.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnGuardar.Font = new System.Drawing.Font("Century Gothic", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnGuardar.ForeColor = System.Drawing.Color.White;
            this.btnGuardar.Location = new System.Drawing.Point(740, 630);
            this.btnGuardar.Name = "btnGuardar";
            this.btnGuardar.Size = new System.Drawing.Size(158, 26);
            this.btnGuardar.TabIndex = 7;
            this.btnGuardar.Text = "Guardar Cambios";
            this.btnGuardar.UseVisualStyleBackColor = false;
            this.btnGuardar.Click += new System.EventHandler(this.btnGuardar_Click);
            // 
            // btnFinalizar
            // 
            this.btnFinalizar.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(157)))), ((int)(((byte)(6)))), ((int)(((byte)(32)))));
            this.btnFinalizar.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnFinalizar.Font = new System.Drawing.Font("Century Gothic", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnFinalizar.ForeColor = System.Drawing.Color.White;
            this.btnFinalizar.Location = new System.Drawing.Point(921, 630);
            this.btnFinalizar.Name = "btnFinalizar";
            this.btnFinalizar.Size = new System.Drawing.Size(158, 26);
            this.btnFinalizar.TabIndex = 9;
            this.btnFinalizar.Text = "Finalizar Evaluacion";
            this.btnFinalizar.UseVisualStyleBackColor = false;
            this.btnFinalizar.Click += new System.EventHandler(this.btnFinalizar_Click);
            // 
            // txtNotaObjetivos
            // 
            this.txtNotaObjetivos.Enabled = false;
            this.txtNotaObjetivos.Font = new System.Drawing.Font("Microsoft Sans Serif", 27.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtNotaObjetivos.Location = new System.Drawing.Point(926, 166);
            this.txtNotaObjetivos.Name = "txtNotaObjetivos";
            this.txtNotaObjetivos.Size = new System.Drawing.Size(153, 49);
            this.txtNotaObjetivos.TabIndex = 45;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(66)))), ((int)(((byte)(122)))));
            this.label5.Location = new System.Drawing.Point(921, 129);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(68, 25);
            this.label5.TabIndex = 44;
            this.label5.Text = "Nota ";
            // 
            // txtNotaCompetencias
            // 
            this.txtNotaCompetencias.Enabled = false;
            this.txtNotaCompetencias.Font = new System.Drawing.Font("Microsoft Sans Serif", 27.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtNotaCompetencias.Location = new System.Drawing.Point(926, 421);
            this.txtNotaCompetencias.Name = "txtNotaCompetencias";
            this.txtNotaCompetencias.Size = new System.Drawing.Size(153, 49);
            this.txtNotaCompetencias.TabIndex = 47;
            // 
            // lblNotaCompetencias
            // 
            this.lblNotaCompetencias.AutoSize = true;
            this.lblNotaCompetencias.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblNotaCompetencias.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(66)))), ((int)(((byte)(122)))));
            this.lblNotaCompetencias.Location = new System.Drawing.Point(922, 380);
            this.lblNotaCompetencias.Name = "lblNotaCompetencias";
            this.lblNotaCompetencias.Size = new System.Drawing.Size(61, 25);
            this.lblNotaCompetencias.TabIndex = 46;
            this.lblNotaCompetencias.Text = "Nota";
            // 
            // lblDescripcionCompetencias
            // 
            this.lblDescripcionCompetencias.AutoSize = true;
            this.lblDescripcionCompetencias.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblDescripcionCompetencias.Location = new System.Drawing.Point(22, 458);
            this.lblDescripcionCompetencias.Name = "lblDescripcionCompetencias";
            this.lblDescripcionCompetencias.Size = new System.Drawing.Size(438, 20);
            this.lblDescripcionCompetencias.TabIndex = 48;
            this.lblDescripcionCompetencias.Text = "Nivel deficiente (1-2). Nivel regular(3-4). Nivel sobresaliente(5)";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(22, 213);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(312, 20);
            this.label4.TabIndex = 49;
            this.label4.Text = "Ingrese el logro alcanzado de sus objetivos";
            // 
            // lblObjetivo
            // 
            this.lblObjetivo.AutoSize = true;
            this.lblObjetivo.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblObjetivo.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(66)))), ((int)(((byte)(122)))));
            this.lblObjetivo.Location = new System.Drawing.Point(58, 243);
            this.lblObjetivo.Name = "lblObjetivo";
            this.lblObjetivo.Size = new System.Drawing.Size(99, 25);
            this.lblObjetivo.TabIndex = 50;
            this.lblObjetivo.Text = "Objetivo";
            // 
            // lblCantidad
            // 
            this.lblCantidad.AutoSize = true;
            this.lblCantidad.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblCantidad.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(66)))), ((int)(((byte)(122)))));
            this.lblCantidad.Location = new System.Drawing.Point(503, 243);
            this.lblCantidad.Name = "lblCantidad";
            this.lblCantidad.Size = new System.Drawing.Size(106, 25);
            this.lblCantidad.TabIndex = 51;
            this.lblCantidad.Text = "Cantidad";
            // 
            // lblPeso
            // 
            this.lblPeso.AutoSize = true;
            this.lblPeso.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblPeso.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(66)))), ((int)(((byte)(122)))));
            this.lblPeso.Location = new System.Drawing.Point(683, 243);
            this.lblPeso.Name = "lblPeso";
            this.lblPeso.Size = new System.Drawing.Size(65, 25);
            this.lblPeso.TabIndex = 52;
            this.lblPeso.Text = "Peso";
            // 
            // lblLogro
            // 
            this.lblLogro.AutoSize = true;
            this.lblLogro.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblLogro.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(66)))), ((int)(((byte)(122)))));
            this.lblLogro.Location = new System.Drawing.Point(921, 243);
            this.lblLogro.Name = "lblLogro";
            this.lblLogro.Size = new System.Drawing.Size(72, 25);
            this.lblLogro.TabIndex = 53;
            this.lblLogro.Text = "Logro";
            // 
            // btnRegresar
            // 
            this.btnRegresar.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(157)))), ((int)(((byte)(6)))), ((int)(((byte)(32)))));
            this.btnRegresar.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnRegresar.Font = new System.Drawing.Font("Century Gothic", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnRegresar.ForeColor = System.Drawing.Color.White;
            this.btnRegresar.Location = new System.Drawing.Point(22, 95);
            this.btnRegresar.Name = "btnRegresar";
            this.btnRegresar.Size = new System.Drawing.Size(158, 26);
            this.btnRegresar.TabIndex = 54;
            this.btnRegresar.Text = "Regresar";
            this.btnRegresar.UseVisualStyleBackColor = false;
            this.btnRegresar.Click += new System.EventHandler(this.btnRegresar_Click);
            // 
            // lbl1
            // 
            this.lbl1.AutoSize = true;
            this.lbl1.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl1.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(66)))), ((int)(((byte)(122)))));
            this.lbl1.Location = new System.Drawing.Point(503, 454);
            this.lbl1.Name = "lbl1";
            this.lbl1.Size = new System.Drawing.Size(25, 25);
            this.lbl1.TabIndex = 55;
            this.lbl1.Text = "1";
            // 
            // lbl2
            // 
            this.lbl2.AutoSize = true;
            this.lbl2.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl2.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(66)))), ((int)(((byte)(122)))));
            this.lbl2.Location = new System.Drawing.Point(563, 454);
            this.lbl2.Name = "lbl2";
            this.lbl2.Size = new System.Drawing.Size(25, 25);
            this.lbl2.TabIndex = 56;
            this.lbl2.Text = "2";
            // 
            // lbl3
            // 
            this.lbl3.AutoSize = true;
            this.lbl3.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl3.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(66)))), ((int)(((byte)(122)))));
            this.lbl3.Location = new System.Drawing.Point(623, 454);
            this.lbl3.Name = "lbl3";
            this.lbl3.Size = new System.Drawing.Size(25, 25);
            this.lbl3.TabIndex = 57;
            this.lbl3.Text = "3";
            // 
            // lbl5
            // 
            this.lbl5.AutoSize = true;
            this.lbl5.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl5.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(66)))), ((int)(((byte)(122)))));
            this.lbl5.Location = new System.Drawing.Point(743, 454);
            this.lbl5.Name = "lbl5";
            this.lbl5.Size = new System.Drawing.Size(25, 25);
            this.lbl5.TabIndex = 58;
            this.lbl5.Text = "5";
            // 
            // lbl4
            // 
            this.lbl4.AutoSize = true;
            this.lbl4.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl4.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(66)))), ((int)(((byte)(122)))));
            this.lbl4.Location = new System.Drawing.Point(683, 454);
            this.lbl4.Name = "lbl4";
            this.lbl4.Size = new System.Drawing.Size(25, 25);
            this.lbl4.TabIndex = 59;
            this.lbl4.Text = "4";
            // 
            // frmEvAutoevaluacion
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoScroll = true;
            this.AutoScrollMargin = new System.Drawing.Size(0, 100);
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(1158, 749);
            this.Controls.Add(this.lbl4);
            this.Controls.Add(this.lbl5);
            this.Controls.Add(this.lbl3);
            this.Controls.Add(this.lbl2);
            this.Controls.Add(this.lbl1);
            this.Controls.Add(this.btnRegresar);
            this.Controls.Add(this.lblLogro);
            this.Controls.Add(this.lblPeso);
            this.Controls.Add(this.lblCantidad);
            this.Controls.Add(this.lblObjetivo);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.lblDescripcionCompetencias);
            this.Controls.Add(this.txtNotaCompetencias);
            this.Controls.Add(this.lblNotaCompetencias);
            this.Controls.Add(this.txtNotaObjetivos);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.btnFinalizar);
            this.Controls.Add(this.btnGuardar);
            this.Controls.Add(this.lblMisObjetivos);
            this.Controls.Add(this.lblTituloCompetencias);
            this.Controls.Add(this.label1);
            this.Name = "frmEvAutoevaluacion";
            this.Text = "frmEvAutoevaluacion";
            this.Load += new System.EventHandler(this.frmEvAutoevaluacion_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label lblTituloCompetencias;
        private System.Windows.Forms.Label lblMisObjetivos;
        private System.Windows.Forms.Button btnGuardar;
        private System.Windows.Forms.Button btnFinalizar;
        private System.Windows.Forms.TextBox txtNotaObjetivos;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.TextBox txtNotaCompetencias;
        private System.Windows.Forms.Label lblNotaCompetencias;
        private System.Windows.Forms.Label lblDescripcionCompetencias;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label lblObjetivo;
        private System.Windows.Forms.Label lblCantidad;
        private System.Windows.Forms.Label lblPeso;
        private System.Windows.Forms.Label lblLogro;
        private System.Windows.Forms.Button btnRegresar;
        private System.Windows.Forms.Label lbl1;
        private System.Windows.Forms.Label lbl2;
        private System.Windows.Forms.Label lbl3;
        private System.Windows.Forms.Label lbl5;
        private System.Windows.Forms.Label lbl4;
    }
}