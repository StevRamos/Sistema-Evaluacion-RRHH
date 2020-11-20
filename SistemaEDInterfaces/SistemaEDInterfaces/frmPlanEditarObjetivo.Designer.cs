namespace SistemaEDInterfaces
{
    partial class frmPlanEditarObjetivo
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
            this.lblObjetivo = new System.Windows.Forms.Label();
            this.txtMeta = new System.Windows.Forms.TextBox();
            this.txtID = new System.Windows.Forms.TextBox();
            this.lblID = new System.Windows.Forms.Label();
            this.lblUnidadMedida = new System.Windows.Forms.Label();
            this.lblPeso = new System.Windows.Forms.Label();
            this.lblObservacionJefe = new System.Windows.Forms.Label();
            this.lblMeta = new System.Windows.Forms.Label();
            this.lblDescripcion = new System.Windows.Forms.Label();
            this.lblEstado = new System.Windows.Forms.Label();
            this.lblFechaFormulacion = new System.Windows.Forms.Label();
            this.lblFechaAprobacion = new System.Windows.Forms.Label();
            this.txtPeso = new System.Windows.Forms.TextBox();
            this.txtUnidadMedida = new System.Windows.Forms.TextBox();
            this.txtBoxDescripcion = new System.Windows.Forms.RichTextBox();
            this.txtBoxObservacionJefe = new System.Windows.Forms.RichTextBox();
            this.txtEstado = new System.Windows.Forms.TextBox();
            this.btnRegresar = new System.Windows.Forms.Button();
            this.btnGuardar = new System.Windows.Forms.Button();
            this.btnEditar = new System.Windows.Forms.Button();
            this.dtpFechaFormulacion = new System.Windows.Forms.DateTimePicker();
            this.dtpFechaAprobacion = new System.Windows.Forms.DateTimePicker();
            this.SuspendLayout();
            // 
            // lblObjetivo
            // 
            this.lblObjetivo.AutoSize = true;
            this.lblObjetivo.Font = new System.Drawing.Font("Century Gothic", 36F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblObjetivo.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(66)))), ((int)(((byte)(122)))));
            this.lblObjetivo.Location = new System.Drawing.Point(12, 9);
            this.lblObjetivo.Name = "lblObjetivo";
            this.lblObjetivo.Size = new System.Drawing.Size(223, 56);
            this.lblObjetivo.TabIndex = 1;
            this.lblObjetivo.Text = "Objetivo";
            // 
            // txtMeta
            // 
            this.txtMeta.Enabled = false;
            this.txtMeta.Location = new System.Drawing.Point(289, 224);
            this.txtMeta.MaxLength = 50;
            this.txtMeta.Name = "txtMeta";
            this.txtMeta.Size = new System.Drawing.Size(193, 20);
            this.txtMeta.TabIndex = 12;
            this.txtMeta.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtMeta_KeyPress);
            // 
            // txtID
            // 
            this.txtID.Enabled = false;
            this.txtID.Location = new System.Drawing.Point(289, 118);
            this.txtID.Name = "txtID";
            this.txtID.Size = new System.Drawing.Size(193, 20);
            this.txtID.TabIndex = 11;
            // 
            // lblID
            // 
            this.lblID.AutoSize = true;
            this.lblID.Font = new System.Drawing.Font("Century Gothic", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblID.Location = new System.Drawing.Point(28, 114);
            this.lblID.Name = "lblID";
            this.lblID.Size = new System.Drawing.Size(36, 24);
            this.lblID.TabIndex = 10;
            this.lblID.Text = "ID:";
            // 
            // lblUnidadMedida
            // 
            this.lblUnidadMedida.AutoSize = true;
            this.lblUnidadMedida.Font = new System.Drawing.Font("Century Gothic", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblUnidadMedida.Location = new System.Drawing.Point(499, 220);
            this.lblUnidadMedida.Name = "lblUnidadMedida";
            this.lblUnidadMedida.Size = new System.Drawing.Size(204, 24);
            this.lblUnidadMedida.TabIndex = 9;
            this.lblUnidadMedida.Text = "Unidad de Medida:";
            // 
            // lblPeso
            // 
            this.lblPeso.AutoSize = true;
            this.lblPeso.Font = new System.Drawing.Font("Century Gothic", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblPeso.Location = new System.Drawing.Point(28, 269);
            this.lblPeso.Name = "lblPeso";
            this.lblPeso.Size = new System.Drawing.Size(63, 24);
            this.lblPeso.TabIndex = 13;
            this.lblPeso.Text = "Peso:";
            // 
            // lblObservacionJefe
            // 
            this.lblObservacionJefe.AutoSize = true;
            this.lblObservacionJefe.Font = new System.Drawing.Font("Century Gothic", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblObservacionJefe.Location = new System.Drawing.Point(499, 321);
            this.lblObservacionJefe.Name = "lblObservacionJefe";
            this.lblObservacionJefe.Size = new System.Drawing.Size(231, 24);
            this.lblObservacionJefe.TabIndex = 14;
            this.lblObservacionJefe.Text = "Observacion de Jefe:";
            // 
            // lblMeta
            // 
            this.lblMeta.AutoSize = true;
            this.lblMeta.Font = new System.Drawing.Font("Century Gothic", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblMeta.Location = new System.Drawing.Point(28, 220);
            this.lblMeta.Name = "lblMeta";
            this.lblMeta.Size = new System.Drawing.Size(69, 24);
            this.lblMeta.TabIndex = 15;
            this.lblMeta.Text = "Meta:";
            // 
            // lblDescripcion
            // 
            this.lblDescripcion.AutoSize = true;
            this.lblDescripcion.Font = new System.Drawing.Font("Century Gothic", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblDescripcion.Location = new System.Drawing.Point(28, 321);
            this.lblDescripcion.Name = "lblDescripcion";
            this.lblDescripcion.Size = new System.Drawing.Size(134, 24);
            this.lblDescripcion.TabIndex = 16;
            this.lblDescripcion.Text = "Descripcion:";
            // 
            // lblEstado
            // 
            this.lblEstado.AutoSize = true;
            this.lblEstado.Font = new System.Drawing.Font("Century Gothic", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblEstado.Location = new System.Drawing.Point(499, 112);
            this.lblEstado.Name = "lblEstado";
            this.lblEstado.Size = new System.Drawing.Size(83, 24);
            this.lblEstado.TabIndex = 17;
            this.lblEstado.Text = "Estado:";
            // 
            // lblFechaFormulacion
            // 
            this.lblFechaFormulacion.AutoSize = true;
            this.lblFechaFormulacion.Font = new System.Drawing.Font("Century Gothic", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblFechaFormulacion.Location = new System.Drawing.Point(28, 166);
            this.lblFechaFormulacion.Name = "lblFechaFormulacion";
            this.lblFechaFormulacion.Size = new System.Drawing.Size(247, 24);
            this.lblFechaFormulacion.TabIndex = 18;
            this.lblFechaFormulacion.Text = "Fecha de Formulacion:";
            // 
            // lblFechaAprobacion
            // 
            this.lblFechaAprobacion.AutoSize = true;
            this.lblFechaAprobacion.Font = new System.Drawing.Font("Century Gothic", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblFechaAprobacion.Location = new System.Drawing.Point(499, 168);
            this.lblFechaAprobacion.Name = "lblFechaAprobacion";
            this.lblFechaAprobacion.Size = new System.Drawing.Size(241, 24);
            this.lblFechaAprobacion.TabIndex = 19;
            this.lblFechaAprobacion.Text = "Fecha de Aprobacion:";
            // 
            // txtPeso
            // 
            this.txtPeso.Enabled = false;
            this.txtPeso.Location = new System.Drawing.Point(289, 269);
            this.txtPeso.MaxLength = 50;
            this.txtPeso.Name = "txtPeso";
            this.txtPeso.Size = new System.Drawing.Size(193, 20);
            this.txtPeso.TabIndex = 20;
            this.txtPeso.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtPeso_KeyPress);
            // 
            // txtUnidadMedida
            // 
            this.txtUnidadMedida.Enabled = false;
            this.txtUnidadMedida.Location = new System.Drawing.Point(760, 226);
            this.txtUnidadMedida.MaxLength = 50;
            this.txtUnidadMedida.Name = "txtUnidadMedida";
            this.txtUnidadMedida.Size = new System.Drawing.Size(193, 20);
            this.txtUnidadMedida.TabIndex = 21;
            this.txtUnidadMedida.TextChanged += new System.EventHandler(this.txtUnidadMedida_TextChanged);
            this.txtUnidadMedida.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtUnidadMedida_KeyPress);
            // 
            // txtBoxDescripcion
            // 
            this.txtBoxDescripcion.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.txtBoxDescripcion.Enabled = false;
            this.txtBoxDescripcion.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtBoxDescripcion.Location = new System.Drawing.Point(32, 361);
            this.txtBoxDescripcion.MaxLength = 200;
            this.txtBoxDescripcion.Name = "txtBoxDescripcion";
            this.txtBoxDescripcion.Size = new System.Drawing.Size(450, 156);
            this.txtBoxDescripcion.TabIndex = 23;
            this.txtBoxDescripcion.Text = "";
            // 
            // txtBoxObservacionJefe
            // 
            this.txtBoxObservacionJefe.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.txtBoxObservacionJefe.Enabled = false;
            this.txtBoxObservacionJefe.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtBoxObservacionJefe.Location = new System.Drawing.Point(503, 361);
            this.txtBoxObservacionJefe.MaxLength = 200;
            this.txtBoxObservacionJefe.Name = "txtBoxObservacionJefe";
            this.txtBoxObservacionJefe.Size = new System.Drawing.Size(450, 156);
            this.txtBoxObservacionJefe.TabIndex = 25;
            this.txtBoxObservacionJefe.Text = "";
            // 
            // txtEstado
            // 
            this.txtEstado.Enabled = false;
            this.txtEstado.Location = new System.Drawing.Point(760, 116);
            this.txtEstado.Name = "txtEstado";
            this.txtEstado.Size = new System.Drawing.Size(193, 20);
            this.txtEstado.TabIndex = 26;
            // 
            // btnRegresar
            // 
            this.btnRegresar.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(157)))), ((int)(((byte)(6)))), ((int)(((byte)(32)))));
            this.btnRegresar.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnRegresar.Font = new System.Drawing.Font("Century Gothic", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnRegresar.ForeColor = System.Drawing.Color.White;
            this.btnRegresar.Location = new System.Drawing.Point(32, 587);
            this.btnRegresar.Name = "btnRegresar";
            this.btnRegresar.Size = new System.Drawing.Size(158, 26);
            this.btnRegresar.TabIndex = 27;
            this.btnRegresar.Text = "Regresar";
            this.btnRegresar.UseVisualStyleBackColor = false;
            this.btnRegresar.Click += new System.EventHandler(this.btnAtras_Click);
            // 
            // btnGuardar
            // 
            this.btnGuardar.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(157)))), ((int)(((byte)(6)))), ((int)(((byte)(32)))));
            this.btnGuardar.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnGuardar.Font = new System.Drawing.Font("Century Gothic", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnGuardar.ForeColor = System.Drawing.Color.White;
            this.btnGuardar.Location = new System.Drawing.Point(795, 587);
            this.btnGuardar.Name = "btnGuardar";
            this.btnGuardar.Size = new System.Drawing.Size(158, 26);
            this.btnGuardar.TabIndex = 28;
            this.btnGuardar.Text = "Guardar";
            this.btnGuardar.UseVisualStyleBackColor = false;
            this.btnGuardar.Click += new System.EventHandler(this.btnGuardar_Click);
            // 
            // btnEditar
            // 
            this.btnEditar.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(157)))), ((int)(((byte)(6)))), ((int)(((byte)(32)))));
            this.btnEditar.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnEditar.Font = new System.Drawing.Font("Century Gothic", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnEditar.ForeColor = System.Drawing.Color.White;
            this.btnEditar.Location = new System.Drawing.Point(503, 587);
            this.btnEditar.Name = "btnEditar";
            this.btnEditar.Size = new System.Drawing.Size(158, 26);
            this.btnEditar.TabIndex = 29;
            this.btnEditar.Text = "Editar";
            this.btnEditar.UseVisualStyleBackColor = false;
            this.btnEditar.Click += new System.EventHandler(this.btnEditar_Click);
            // 
            // dtpFechaFormulacion
            // 
            this.dtpFechaFormulacion.Enabled = false;
            this.dtpFechaFormulacion.Location = new System.Drawing.Point(289, 172);
            this.dtpFechaFormulacion.Name = "dtpFechaFormulacion";
            this.dtpFechaFormulacion.Size = new System.Drawing.Size(193, 20);
            this.dtpFechaFormulacion.TabIndex = 30;
            // 
            // dtpFechaAprobacion
            // 
            this.dtpFechaAprobacion.Enabled = false;
            this.dtpFechaAprobacion.Location = new System.Drawing.Point(760, 172);
            this.dtpFechaAprobacion.Name = "dtpFechaAprobacion";
            this.dtpFechaAprobacion.Size = new System.Drawing.Size(193, 20);
            this.dtpFechaAprobacion.TabIndex = 31;
            // 
            // frmPlanEditarObjetivo
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(1107, 755);
            this.Controls.Add(this.dtpFechaAprobacion);
            this.Controls.Add(this.dtpFechaFormulacion);
            this.Controls.Add(this.btnEditar);
            this.Controls.Add(this.btnGuardar);
            this.Controls.Add(this.btnRegresar);
            this.Controls.Add(this.txtEstado);
            this.Controls.Add(this.txtBoxObservacionJefe);
            this.Controls.Add(this.txtBoxDescripcion);
            this.Controls.Add(this.txtUnidadMedida);
            this.Controls.Add(this.txtPeso);
            this.Controls.Add(this.lblFechaAprobacion);
            this.Controls.Add(this.lblFechaFormulacion);
            this.Controls.Add(this.lblEstado);
            this.Controls.Add(this.lblDescripcion);
            this.Controls.Add(this.lblMeta);
            this.Controls.Add(this.lblObservacionJefe);
            this.Controls.Add(this.lblPeso);
            this.Controls.Add(this.txtMeta);
            this.Controls.Add(this.txtID);
            this.Controls.Add(this.lblID);
            this.Controls.Add(this.lblUnidadMedida);
            this.Controls.Add(this.lblObjetivo);
            this.Name = "frmPlanEditarObjetivo";
            this.Text = "frmPlanEditarObjetivo";
            this.Load += new System.EventHandler(this.frmPlanEditarObjetivo_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lblObjetivo;
        private System.Windows.Forms.TextBox txtMeta;
        private System.Windows.Forms.TextBox txtID;
        private System.Windows.Forms.Label lblID;
        private System.Windows.Forms.Label lblUnidadMedida;
        private System.Windows.Forms.Label lblPeso;
        private System.Windows.Forms.Label lblObservacionJefe;
        private System.Windows.Forms.Label lblMeta;
        private System.Windows.Forms.Label lblDescripcion;
        private System.Windows.Forms.Label lblEstado;
        private System.Windows.Forms.Label lblFechaFormulacion;
        private System.Windows.Forms.Label lblFechaAprobacion;
        private System.Windows.Forms.TextBox txtPeso;
        private System.Windows.Forms.TextBox txtUnidadMedida;
        private System.Windows.Forms.RichTextBox txtBoxDescripcion;
        private System.Windows.Forms.RichTextBox txtBoxObservacionJefe;
        private System.Windows.Forms.TextBox txtEstado;
        private System.Windows.Forms.Button btnRegresar;
        private System.Windows.Forms.Button btnGuardar;
        private System.Windows.Forms.Button btnEditar;
        private System.Windows.Forms.DateTimePicker dtpFechaFormulacion;
        private System.Windows.Forms.DateTimePicker dtpFechaAprobacion;
    }
}