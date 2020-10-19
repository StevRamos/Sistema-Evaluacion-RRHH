namespace SistemaEDInterfaces
{
    partial class frmInicio
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
            this.panelMenu = new System.Windows.Forms.Panel();
            this.panelLeftPlanificacion = new System.Windows.Forms.Panel();
            this.panelPlanificacion = new System.Windows.Forms.Panel();
            this.btnValidarObjetivos = new System.Windows.Forms.Button();
            this.btnMisObjetivos = new System.Windows.Forms.Button();
            this.panelLeftEvaluacion = new System.Windows.Forms.Panel();
            this.panelEvaluacion = new System.Windows.Forms.Panel();
            this.btnMisTrabajadores = new System.Windows.Forms.Button();
            this.btnAutoevaluacion = new System.Windows.Forms.Button();
            this.btnFeedback = new System.Windows.Forms.Button();
            this.btnMisResultados = new System.Windows.Forms.Button();
            this.btnHistorialEv = new System.Windows.Forms.Button();
            this.btnEvaluacion = new System.Windows.Forms.Button();
            this.btnPlanificacion = new System.Windows.Forms.Button();
            this.panelLeftHistorial = new System.Windows.Forms.Panel();
            this.panelMenu.SuspendLayout();
            this.panelPlanificacion.SuspendLayout();
            this.panelEvaluacion.SuspendLayout();
            this.SuspendLayout();
            // 
            // panelMenu
            // 
            this.panelMenu.AutoScroll = true;
            this.panelMenu.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(37)))), ((int)(((byte)(36)))), ((int)(((byte)(64)))));
            this.panelMenu.Controls.Add(this.panelLeftHistorial);
            this.panelMenu.Controls.Add(this.btnHistorialEv);
            this.panelMenu.Controls.Add(this.panelPlanificacion);
            this.panelMenu.Controls.Add(this.panelEvaluacion);
            this.panelMenu.Controls.Add(this.panelLeftEvaluacion);
            this.panelMenu.Controls.Add(this.btnEvaluacion);
            this.panelMenu.Controls.Add(this.panelLeftPlanificacion);
            this.panelMenu.Controls.Add(this.btnPlanificacion);
            this.panelMenu.Dock = System.Windows.Forms.DockStyle.Left;
            this.panelMenu.Location = new System.Drawing.Point(0, 0);
            this.panelMenu.Name = "panelMenu";
            this.panelMenu.Size = new System.Drawing.Size(261, 861);
            this.panelMenu.TabIndex = 1;
            this.panelMenu.Paint += new System.Windows.Forms.PaintEventHandler(this.panelMenu_Paint);
            // 
            // panelLeftPlanificacion
            // 
            this.panelLeftPlanificacion.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(80)))), ((int)(((byte)(200)))));
            this.panelLeftPlanificacion.Location = new System.Drawing.Point(3, 154);
            this.panelLeftPlanificacion.Name = "panelLeftPlanificacion";
            this.panelLeftPlanificacion.Size = new System.Drawing.Size(10, 47);
            this.panelLeftPlanificacion.TabIndex = 3;
            // 
            // panelPlanificacion
            // 
            this.panelPlanificacion.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(37)))), ((int)(((byte)(36)))), ((int)(((byte)(64)))));
            this.panelPlanificacion.Controls.Add(this.btnValidarObjetivos);
            this.panelPlanificacion.Controls.Add(this.btnMisObjetivos);
            this.panelPlanificacion.Location = new System.Drawing.Point(15, 207);
            this.panelPlanificacion.Name = "panelPlanificacion";
            this.panelPlanificacion.Size = new System.Drawing.Size(239, 100);
            this.panelPlanificacion.TabIndex = 2;
            this.panelPlanificacion.Paint += new System.Windows.Forms.PaintEventHandler(this.panelPlanificacion_Paint);
            // 
            // btnValidarObjetivos
            // 
            this.btnValidarObjetivos.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(37)))), ((int)(((byte)(36)))), ((int)(((byte)(64)))));
            this.btnValidarObjetivos.FlatAppearance.BorderSize = 0;
            this.btnValidarObjetivos.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnValidarObjetivos.Font = new System.Drawing.Font("Century Gothic", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnValidarObjetivos.ForeColor = System.Drawing.SystemColors.Control;
            this.btnValidarObjetivos.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnValidarObjetivos.Location = new System.Drawing.Point(0, 47);
            this.btnValidarObjetivos.Name = "btnValidarObjetivos";
            this.btnValidarObjetivos.Size = new System.Drawing.Size(239, 47);
            this.btnValidarObjetivos.TabIndex = 4;
            this.btnValidarObjetivos.Text = "Validar Objetivos";
            this.btnValidarObjetivos.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnValidarObjetivos.UseVisualStyleBackColor = false;
            // 
            // btnMisObjetivos
            // 
            this.btnMisObjetivos.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(37)))), ((int)(((byte)(36)))), ((int)(((byte)(64)))));
            this.btnMisObjetivos.FlatAppearance.BorderSize = 0;
            this.btnMisObjetivos.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnMisObjetivos.Font = new System.Drawing.Font("Century Gothic", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnMisObjetivos.ForeColor = System.Drawing.SystemColors.Control;
            this.btnMisObjetivos.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnMisObjetivos.Location = new System.Drawing.Point(0, 0);
            this.btnMisObjetivos.Name = "btnMisObjetivos";
            this.btnMisObjetivos.Size = new System.Drawing.Size(239, 47);
            this.btnMisObjetivos.TabIndex = 3;
            this.btnMisObjetivos.Text = "Mis objetivos";
            this.btnMisObjetivos.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnMisObjetivos.UseVisualStyleBackColor = false;
            this.btnMisObjetivos.Click += new System.EventHandler(this.btnMisObjetivos_Click);
            // 
            // panelLeftEvaluacion
            // 
            this.panelLeftEvaluacion.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(80)))), ((int)(((byte)(200)))));
            this.panelLeftEvaluacion.Location = new System.Drawing.Point(3, 308);
            this.panelLeftEvaluacion.Name = "panelLeftEvaluacion";
            this.panelLeftEvaluacion.Size = new System.Drawing.Size(10, 47);
            this.panelLeftEvaluacion.TabIndex = 4;
            // 
            // panelEvaluacion
            // 
            this.panelEvaluacion.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(37)))), ((int)(((byte)(36)))), ((int)(((byte)(64)))));
            this.panelEvaluacion.Controls.Add(this.btnMisResultados);
            this.panelEvaluacion.Controls.Add(this.btnFeedback);
            this.panelEvaluacion.Controls.Add(this.btnMisTrabajadores);
            this.panelEvaluacion.Controls.Add(this.btnAutoevaluacion);
            this.panelEvaluacion.Location = new System.Drawing.Point(12, 361);
            this.panelEvaluacion.Name = "panelEvaluacion";
            this.panelEvaluacion.Size = new System.Drawing.Size(239, 191);
            this.panelEvaluacion.TabIndex = 3;
            this.panelEvaluacion.Paint += new System.Windows.Forms.PaintEventHandler(this.panel3_Paint);
            // 
            // btnMisTrabajadores
            // 
            this.btnMisTrabajadores.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(37)))), ((int)(((byte)(36)))), ((int)(((byte)(64)))));
            this.btnMisTrabajadores.FlatAppearance.BorderSize = 0;
            this.btnMisTrabajadores.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnMisTrabajadores.Font = new System.Drawing.Font("Century Gothic", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnMisTrabajadores.ForeColor = System.Drawing.SystemColors.Control;
            this.btnMisTrabajadores.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnMisTrabajadores.Location = new System.Drawing.Point(0, 47);
            this.btnMisTrabajadores.Name = "btnMisTrabajadores";
            this.btnMisTrabajadores.Size = new System.Drawing.Size(239, 47);
            this.btnMisTrabajadores.TabIndex = 4;
            this.btnMisTrabajadores.Text = "Mis trabajadores";
            this.btnMisTrabajadores.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnMisTrabajadores.UseVisualStyleBackColor = false;
            // 
            // btnAutoevaluacion
            // 
            this.btnAutoevaluacion.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(37)))), ((int)(((byte)(36)))), ((int)(((byte)(64)))));
            this.btnAutoevaluacion.FlatAppearance.BorderSize = 0;
            this.btnAutoevaluacion.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnAutoevaluacion.Font = new System.Drawing.Font("Century Gothic", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnAutoevaluacion.ForeColor = System.Drawing.SystemColors.Control;
            this.btnAutoevaluacion.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnAutoevaluacion.Location = new System.Drawing.Point(0, 0);
            this.btnAutoevaluacion.Name = "btnAutoevaluacion";
            this.btnAutoevaluacion.Size = new System.Drawing.Size(239, 47);
            this.btnAutoevaluacion.TabIndex = 3;
            this.btnAutoevaluacion.Text = "Autoevaluación";
            this.btnAutoevaluacion.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnAutoevaluacion.UseVisualStyleBackColor = false;
            // 
            // btnFeedback
            // 
            this.btnFeedback.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(37)))), ((int)(((byte)(36)))), ((int)(((byte)(64)))));
            this.btnFeedback.FlatAppearance.BorderSize = 0;
            this.btnFeedback.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnFeedback.Font = new System.Drawing.Font("Century Gothic", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnFeedback.ForeColor = System.Drawing.SystemColors.Control;
            this.btnFeedback.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnFeedback.Location = new System.Drawing.Point(0, 94);
            this.btnFeedback.Name = "btnFeedback";
            this.btnFeedback.Size = new System.Drawing.Size(239, 47);
            this.btnFeedback.TabIndex = 5;
            this.btnFeedback.Text = "Feedback";
            this.btnFeedback.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnFeedback.UseVisualStyleBackColor = false;
            // 
            // btnMisResultados
            // 
            this.btnMisResultados.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(37)))), ((int)(((byte)(36)))), ((int)(((byte)(64)))));
            this.btnMisResultados.FlatAppearance.BorderSize = 0;
            this.btnMisResultados.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnMisResultados.Font = new System.Drawing.Font("Century Gothic", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnMisResultados.ForeColor = System.Drawing.SystemColors.Control;
            this.btnMisResultados.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnMisResultados.Location = new System.Drawing.Point(0, 141);
            this.btnMisResultados.Name = "btnMisResultados";
            this.btnMisResultados.Size = new System.Drawing.Size(239, 47);
            this.btnMisResultados.TabIndex = 6;
            this.btnMisResultados.Text = "Mis resultados";
            this.btnMisResultados.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnMisResultados.UseVisualStyleBackColor = false;
            // 
            // btnHistorialEv
            // 
            this.btnHistorialEv.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(37)))), ((int)(((byte)(36)))), ((int)(((byte)(64)))));
            this.btnHistorialEv.FlatAppearance.BorderSize = 0;
            this.btnHistorialEv.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnHistorialEv.Font = new System.Drawing.Font("Century Gothic", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnHistorialEv.ForeColor = System.Drawing.SystemColors.Control;
            this.btnHistorialEv.Image = global::SistemaEDInterfaces.Properties.Resources.historial_medico;
            this.btnHistorialEv.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnHistorialEv.Location = new System.Drawing.Point(15, 555);
            this.btnHistorialEv.Name = "btnHistorialEv";
            this.btnHistorialEv.Size = new System.Drawing.Size(239, 47);
            this.btnHistorialEv.TabIndex = 3;
            this.btnHistorialEv.Text = "Historial Evaluaciones";
            this.btnHistorialEv.UseVisualStyleBackColor = false;
            // 
            // btnEvaluacion
            // 
            this.btnEvaluacion.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(37)))), ((int)(((byte)(36)))), ((int)(((byte)(64)))));
            this.btnEvaluacion.FlatAppearance.BorderSize = 0;
            this.btnEvaluacion.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnEvaluacion.Font = new System.Drawing.Font("Century Gothic", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnEvaluacion.ForeColor = System.Drawing.SystemColors.Control;
            this.btnEvaluacion.Image = global::SistemaEDInterfaces.Properties.Resources.evaluacion;
            this.btnEvaluacion.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnEvaluacion.Location = new System.Drawing.Point(12, 307);
            this.btnEvaluacion.Name = "btnEvaluacion";
            this.btnEvaluacion.Padding = new System.Windows.Forms.Padding(0, 0, 80, 0);
            this.btnEvaluacion.Size = new System.Drawing.Size(239, 47);
            this.btnEvaluacion.TabIndex = 2;
            this.btnEvaluacion.Text = "Evaluación";
            this.btnEvaluacion.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btnEvaluacion.UseVisualStyleBackColor = false;
            // 
            // btnPlanificacion
            // 
            this.btnPlanificacion.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(37)))), ((int)(((byte)(36)))), ((int)(((byte)(64)))));
            this.btnPlanificacion.FlatAppearance.BorderSize = 0;
            this.btnPlanificacion.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnPlanificacion.Font = new System.Drawing.Font("Century Gothic", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnPlanificacion.ForeColor = System.Drawing.SystemColors.Control;
            this.btnPlanificacion.Image = global::SistemaEDInterfaces.Properties.Resources.planificacion;
            this.btnPlanificacion.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnPlanificacion.Location = new System.Drawing.Point(12, 154);
            this.btnPlanificacion.Name = "btnPlanificacion";
            this.btnPlanificacion.Padding = new System.Windows.Forms.Padding(0, 0, 80, 0);
            this.btnPlanificacion.Size = new System.Drawing.Size(239, 47);
            this.btnPlanificacion.TabIndex = 0;
            this.btnPlanificacion.Text = "Planificación";
            this.btnPlanificacion.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btnPlanificacion.UseVisualStyleBackColor = false;
            this.btnPlanificacion.Click += new System.EventHandler(this.button1_Click);
            // 
            // panelLeftHistorial
            // 
            this.panelLeftHistorial.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(80)))), ((int)(((byte)(200)))));
            this.panelLeftHistorial.Location = new System.Drawing.Point(3, 555);
            this.panelLeftHistorial.Name = "panelLeftHistorial";
            this.panelLeftHistorial.Size = new System.Drawing.Size(10, 47);
            this.panelLeftHistorial.TabIndex = 5;
            // 
            // frmInicio
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1384, 861);
            this.Controls.Add(this.panelMenu);
            this.MinimumSize = new System.Drawing.Size(1400, 900);
            this.Name = "frmInicio";
            this.Text = "frmInicio";
            this.Load += new System.EventHandler(this.frmInicio_Load);
            this.panelMenu.ResumeLayout(false);
            this.panelPlanificacion.ResumeLayout(false);
            this.panelEvaluacion.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button btnPlanificacion;
        private System.Windows.Forms.Panel panelMenu;
        private System.Windows.Forms.Panel panelLeftPlanificacion;
        private System.Windows.Forms.Panel panelPlanificacion;
        private System.Windows.Forms.Button btnValidarObjetivos;
        private System.Windows.Forms.Button btnMisObjetivos;
        private System.Windows.Forms.Panel panelLeftEvaluacion;
        private System.Windows.Forms.Button btnEvaluacion;
        private System.Windows.Forms.Panel panelEvaluacion;
        private System.Windows.Forms.Button btnMisTrabajadores;
        private System.Windows.Forms.Button btnAutoevaluacion;
        private System.Windows.Forms.Button btnMisResultados;
        private System.Windows.Forms.Button btnFeedback;
        private System.Windows.Forms.Button btnHistorialEv;
        private System.Windows.Forms.Panel panelLeftHistorial;
    }
}