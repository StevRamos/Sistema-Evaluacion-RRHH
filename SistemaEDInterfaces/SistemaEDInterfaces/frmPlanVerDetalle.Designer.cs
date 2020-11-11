namespace SistemaEDInterfaces
{
    partial class frmPlanVerDetalle
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
            this.btnRegresar = new System.Windows.Forms.Button();
            this.txtEstado = new System.Windows.Forms.TextBox();
            this.txtBoxDescripcion = new System.Windows.Forms.RichTextBox();
            this.txtUnidadMedida = new System.Windows.Forms.TextBox();
            this.txtPeso = new System.Windows.Forms.TextBox();
            this.lblFechaAprobacion = new System.Windows.Forms.Label();
            this.lblFechaFormulacion = new System.Windows.Forms.Label();
            this.lblEstado = new System.Windows.Forms.Label();
            this.lblDescripcion = new System.Windows.Forms.Label();
            this.lblMeta = new System.Windows.Forms.Label();
            this.lblObservacionJefe = new System.Windows.Forms.Label();
            this.lblPeso = new System.Windows.Forms.Label();
            this.txtMeta = new System.Windows.Forms.TextBox();
            this.txtIDObjetivo = new System.Windows.Forms.TextBox();
            this.lblIDObjetivo = new System.Windows.Forms.Label();
            this.lblUnidadMedida = new System.Windows.Forms.Label();
            this.lblEditarObjetivos = new System.Windows.Forms.Label();
            this.lblDNI = new System.Windows.Forms.Label();
            this.txtGerencia = new System.Windows.Forms.TextBox();
            this.txtCargo = new System.Windows.Forms.TextBox();
            this.txtDNI = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.txtNombre = new System.Windows.Forms.TextBox();
            this.lblNombre = new System.Windows.Forms.Label();
            this.txtIDColab = new System.Windows.Forms.TextBox();
            this.lblIDColab = new System.Windows.Forms.Label();
            this.lblDatosColaborador = new System.Windows.Forms.Label();
            this.panelDatosColaborador = new System.Windows.Forms.Panel();
            this.rbAprobar = new System.Windows.Forms.RadioButton();
            this.rbDenegar = new System.Windows.Forms.RadioButton();
            this.btnRealizar = new System.Windows.Forms.Button();
            this.txtBoxObservacionJefe = new System.Windows.Forms.RichTextBox();
            this.lblObservacionColocada = new System.Windows.Forms.Label();
            this.dtpFechaFormulacion = new System.Windows.Forms.DateTimePicker();
            this.dtpFechaAprobacion = new System.Windows.Forms.DateTimePicker();
            this.panelDatosColaborador.SuspendLayout();
            this.SuspendLayout();
            // 
            // btnRegresar
            // 
            this.btnRegresar.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(157)))), ((int)(((byte)(6)))), ((int)(((byte)(32)))));
            this.btnRegresar.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnRegresar.Font = new System.Drawing.Font("Century Gothic", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnRegresar.ForeColor = System.Drawing.Color.White;
            this.btnRegresar.Location = new System.Drawing.Point(46, 717);
            this.btnRegresar.Name = "btnRegresar";
            this.btnRegresar.Size = new System.Drawing.Size(158, 26);
            this.btnRegresar.TabIndex = 48;
            this.btnRegresar.Text = "Regresar";
            this.btnRegresar.UseVisualStyleBackColor = false;
            this.btnRegresar.Click += new System.EventHandler(this.btnRegresar_Click);
            // 
            // txtEstado
            // 
            this.txtEstado.Enabled = false;
            this.txtEstado.Location = new System.Drawing.Point(774, 207);
            this.txtEstado.Name = "txtEstado";
            this.txtEstado.Size = new System.Drawing.Size(193, 20);
            this.txtEstado.TabIndex = 47;
            // 
            // txtBoxDescripcion
            // 
            this.txtBoxDescripcion.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.txtBoxDescripcion.Enabled = false;
            this.txtBoxDescripcion.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtBoxDescripcion.Location = new System.Drawing.Point(46, 452);
            this.txtBoxDescripcion.MaxLength = 200;
            this.txtBoxDescripcion.Name = "txtBoxDescripcion";
            this.txtBoxDescripcion.Size = new System.Drawing.Size(450, 156);
            this.txtBoxDescripcion.TabIndex = 44;
            this.txtBoxDescripcion.Text = "";
            // 
            // txtUnidadMedida
            // 
            this.txtUnidadMedida.Enabled = false;
            this.txtUnidadMedida.Location = new System.Drawing.Point(774, 317);
            this.txtUnidadMedida.Name = "txtUnidadMedida";
            this.txtUnidadMedida.Size = new System.Drawing.Size(193, 20);
            this.txtUnidadMedida.TabIndex = 42;
            // 
            // txtPeso
            // 
            this.txtPeso.Enabled = false;
            this.txtPeso.Location = new System.Drawing.Point(303, 360);
            this.txtPeso.Name = "txtPeso";
            this.txtPeso.Size = new System.Drawing.Size(193, 20);
            this.txtPeso.TabIndex = 41;
            // 
            // lblFechaAprobacion
            // 
            this.lblFechaAprobacion.AutoSize = true;
            this.lblFechaAprobacion.Font = new System.Drawing.Font("Century Gothic", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblFechaAprobacion.Location = new System.Drawing.Point(513, 259);
            this.lblFechaAprobacion.Name = "lblFechaAprobacion";
            this.lblFechaAprobacion.Size = new System.Drawing.Size(241, 24);
            this.lblFechaAprobacion.TabIndex = 40;
            this.lblFechaAprobacion.Text = "Fecha de Aprobacion:";
            // 
            // lblFechaFormulacion
            // 
            this.lblFechaFormulacion.AutoSize = true;
            this.lblFechaFormulacion.Font = new System.Drawing.Font("Century Gothic", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblFechaFormulacion.Location = new System.Drawing.Point(42, 257);
            this.lblFechaFormulacion.Name = "lblFechaFormulacion";
            this.lblFechaFormulacion.Size = new System.Drawing.Size(247, 24);
            this.lblFechaFormulacion.TabIndex = 39;
            this.lblFechaFormulacion.Text = "Fecha de Formulacion:";
            // 
            // lblEstado
            // 
            this.lblEstado.AutoSize = true;
            this.lblEstado.Font = new System.Drawing.Font("Century Gothic", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblEstado.Location = new System.Drawing.Point(513, 203);
            this.lblEstado.Name = "lblEstado";
            this.lblEstado.Size = new System.Drawing.Size(83, 24);
            this.lblEstado.TabIndex = 38;
            this.lblEstado.Text = "Estado:";
            // 
            // lblDescripcion
            // 
            this.lblDescripcion.AutoSize = true;
            this.lblDescripcion.Font = new System.Drawing.Font("Century Gothic", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblDescripcion.Location = new System.Drawing.Point(42, 412);
            this.lblDescripcion.Name = "lblDescripcion";
            this.lblDescripcion.Size = new System.Drawing.Size(134, 24);
            this.lblDescripcion.TabIndex = 37;
            this.lblDescripcion.Text = "Descripcion:";
            // 
            // lblMeta
            // 
            this.lblMeta.AutoSize = true;
            this.lblMeta.Font = new System.Drawing.Font("Century Gothic", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblMeta.Location = new System.Drawing.Point(42, 311);
            this.lblMeta.Name = "lblMeta";
            this.lblMeta.Size = new System.Drawing.Size(69, 24);
            this.lblMeta.TabIndex = 36;
            this.lblMeta.Text = "Meta:";
            // 
            // lblObservacionJefe
            // 
            this.lblObservacionJefe.AutoSize = true;
            this.lblObservacionJefe.Font = new System.Drawing.Font("Century Gothic", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblObservacionJefe.Location = new System.Drawing.Point(45, 657);
            this.lblObservacionJefe.Name = "lblObservacionJefe";
            this.lblObservacionJefe.Size = new System.Drawing.Size(88, 24);
            this.lblObservacionJefe.TabIndex = 35;
            this.lblObservacionJefe.Text = "Accion:";
            // 
            // lblPeso
            // 
            this.lblPeso.AutoSize = true;
            this.lblPeso.Font = new System.Drawing.Font("Century Gothic", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblPeso.Location = new System.Drawing.Point(42, 360);
            this.lblPeso.Name = "lblPeso";
            this.lblPeso.Size = new System.Drawing.Size(63, 24);
            this.lblPeso.TabIndex = 34;
            this.lblPeso.Text = "Peso:";
            // 
            // txtMeta
            // 
            this.txtMeta.Enabled = false;
            this.txtMeta.Location = new System.Drawing.Point(303, 315);
            this.txtMeta.Name = "txtMeta";
            this.txtMeta.Size = new System.Drawing.Size(193, 20);
            this.txtMeta.TabIndex = 33;
            // 
            // txtIDObjetivo
            // 
            this.txtIDObjetivo.Enabled = false;
            this.txtIDObjetivo.Location = new System.Drawing.Point(303, 209);
            this.txtIDObjetivo.Name = "txtIDObjetivo";
            this.txtIDObjetivo.Size = new System.Drawing.Size(193, 20);
            this.txtIDObjetivo.TabIndex = 32;
            // 
            // lblIDObjetivo
            // 
            this.lblIDObjetivo.AutoSize = true;
            this.lblIDObjetivo.Font = new System.Drawing.Font("Century Gothic", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblIDObjetivo.Location = new System.Drawing.Point(42, 205);
            this.lblIDObjetivo.Name = "lblIDObjetivo";
            this.lblIDObjetivo.Size = new System.Drawing.Size(36, 24);
            this.lblIDObjetivo.TabIndex = 31;
            this.lblIDObjetivo.Text = "ID:";
            // 
            // lblUnidadMedida
            // 
            this.lblUnidadMedida.AutoSize = true;
            this.lblUnidadMedida.Font = new System.Drawing.Font("Century Gothic", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblUnidadMedida.Location = new System.Drawing.Point(513, 311);
            this.lblUnidadMedida.Name = "lblUnidadMedida";
            this.lblUnidadMedida.Size = new System.Drawing.Size(204, 24);
            this.lblUnidadMedida.TabIndex = 30;
            this.lblUnidadMedida.Text = "Unidad de Medida:";
            // 
            // lblEditarObjetivos
            // 
            this.lblEditarObjetivos.AutoSize = true;
            this.lblEditarObjetivos.Font = new System.Drawing.Font("Century Gothic", 36F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblEditarObjetivos.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(66)))), ((int)(((byte)(122)))));
            this.lblEditarObjetivos.Location = new System.Drawing.Point(12, 9);
            this.lblEditarObjetivos.Name = "lblEditarObjetivos";
            this.lblEditarObjetivos.Size = new System.Drawing.Size(426, 56);
            this.lblEditarObjetivos.TabIndex = 29;
            this.lblEditarObjetivos.Text = "Validar Objetivos";
            // 
            // lblDNI
            // 
            this.lblDNI.AutoSize = true;
            this.lblDNI.Font = new System.Drawing.Font("Century Gothic", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblDNI.ForeColor = System.Drawing.Color.White;
            this.lblDNI.Location = new System.Drawing.Point(858, 48);
            this.lblDNI.Name = "lblDNI";
            this.lblDNI.Size = new System.Drawing.Size(52, 24);
            this.lblDNI.TabIndex = 59;
            this.lblDNI.Text = "DNI:";
            // 
            // txtGerencia
            // 
            this.txtGerencia.Enabled = false;
            this.txtGerencia.Location = new System.Drawing.Point(637, 87);
            this.txtGerencia.Name = "txtGerencia";
            this.txtGerencia.Size = new System.Drawing.Size(209, 20);
            this.txtGerencia.TabIndex = 58;
            // 
            // txtCargo
            // 
            this.txtCargo.Enabled = false;
            this.txtCargo.Location = new System.Drawing.Point(637, 48);
            this.txtCargo.Name = "txtCargo";
            this.txtCargo.Size = new System.Drawing.Size(209, 20);
            this.txtCargo.TabIndex = 57;
            // 
            // txtDNI
            // 
            this.txtDNI.Enabled = false;
            this.txtDNI.Location = new System.Drawing.Point(916, 50);
            this.txtDNI.Name = "txtDNI";
            this.txtDNI.Size = new System.Drawing.Size(177, 20);
            this.txtDNI.TabIndex = 56;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Century Gothic", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.ForeColor = System.Drawing.Color.White;
            this.label3.Location = new System.Drawing.Point(508, 83);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(111, 24);
            this.label3.TabIndex = 55;
            this.label3.Text = "Gerencia:";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Century Gothic", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.ForeColor = System.Drawing.Color.White;
            this.label2.Location = new System.Drawing.Point(508, 44);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(80, 24);
            this.label2.TabIndex = 54;
            this.label2.Text = "Cargo:";
            // 
            // txtNombre
            // 
            this.txtNombre.Enabled = false;
            this.txtNombre.Location = new System.Drawing.Point(154, 87);
            this.txtNombre.Name = "txtNombre";
            this.txtNombre.Size = new System.Drawing.Size(339, 20);
            this.txtNombre.TabIndex = 53;
            // 
            // lblNombre
            // 
            this.lblNombre.AutoSize = true;
            this.lblNombre.Font = new System.Drawing.Font("Century Gothic", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblNombre.ForeColor = System.Drawing.Color.White;
            this.lblNombre.Location = new System.Drawing.Point(32, 83);
            this.lblNombre.Name = "lblNombre";
            this.lblNombre.Size = new System.Drawing.Size(100, 24);
            this.lblNombre.TabIndex = 52;
            this.lblNombre.Text = "Nombre:";
            // 
            // txtIDColab
            // 
            this.txtIDColab.Enabled = false;
            this.txtIDColab.Location = new System.Drawing.Point(154, 48);
            this.txtIDColab.Name = "txtIDColab";
            this.txtIDColab.Size = new System.Drawing.Size(339, 20);
            this.txtIDColab.TabIndex = 51;
            // 
            // lblIDColab
            // 
            this.lblIDColab.AutoSize = true;
            this.lblIDColab.Font = new System.Drawing.Font("Century Gothic", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblIDColab.ForeColor = System.Drawing.Color.White;
            this.lblIDColab.Location = new System.Drawing.Point(32, 44);
            this.lblIDColab.Name = "lblIDColab";
            this.lblIDColab.Size = new System.Drawing.Size(36, 24);
            this.lblIDColab.TabIndex = 50;
            this.lblIDColab.Text = "ID:";
            // 
            // lblDatosColaborador
            // 
            this.lblDatosColaborador.AutoSize = true;
            this.lblDatosColaborador.Font = new System.Drawing.Font("Century Gothic", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblDatosColaborador.ForeColor = System.Drawing.Color.White;
            this.lblDatosColaborador.Location = new System.Drawing.Point(32, 10);
            this.lblDatosColaborador.Name = "lblDatosColaborador";
            this.lblDatosColaborador.Size = new System.Drawing.Size(251, 24);
            this.lblDatosColaborador.TabIndex = 60;
            this.lblDatosColaborador.Text = "Datos del Colaborador:";
            // 
            // panelDatosColaborador
            // 
            this.panelDatosColaborador.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(66)))), ((int)(((byte)(122)))));
            this.panelDatosColaborador.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.panelDatosColaborador.Controls.Add(this.txtIDColab);
            this.panelDatosColaborador.Controls.Add(this.lblDatosColaborador);
            this.panelDatosColaborador.Controls.Add(this.lblIDColab);
            this.panelDatosColaborador.Controls.Add(this.lblDNI);
            this.panelDatosColaborador.Controls.Add(this.lblNombre);
            this.panelDatosColaborador.Controls.Add(this.txtGerencia);
            this.panelDatosColaborador.Controls.Add(this.txtNombre);
            this.panelDatosColaborador.Controls.Add(this.txtCargo);
            this.panelDatosColaborador.Controls.Add(this.label2);
            this.panelDatosColaborador.Controls.Add(this.txtDNI);
            this.panelDatosColaborador.Controls.Add(this.label3);
            this.panelDatosColaborador.Location = new System.Drawing.Point(0, 68);
            this.panelDatosColaborador.Name = "panelDatosColaborador";
            this.panelDatosColaborador.Size = new System.Drawing.Size(1123, 120);
            this.panelDatosColaborador.TabIndex = 61;
            // 
            // rbAprobar
            // 
            this.rbAprobar.AutoSize = true;
            this.rbAprobar.Font = new System.Drawing.Font("Century Gothic", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.rbAprobar.Location = new System.Drawing.Point(178, 657);
            this.rbAprobar.Name = "rbAprobar";
            this.rbAprobar.Size = new System.Drawing.Size(111, 28);
            this.rbAprobar.TabIndex = 62;
            this.rbAprobar.TabStop = true;
            this.rbAprobar.Text = "Aprobar";
            this.rbAprobar.UseVisualStyleBackColor = true;
            // 
            // rbDenegar
            // 
            this.rbDenegar.AutoSize = true;
            this.rbDenegar.Font = new System.Drawing.Font("Century Gothic", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.rbDenegar.Location = new System.Drawing.Point(319, 657);
            this.rbDenegar.Name = "rbDenegar";
            this.rbDenegar.Size = new System.Drawing.Size(119, 28);
            this.rbDenegar.TabIndex = 63;
            this.rbDenegar.TabStop = true;
            this.rbDenegar.Text = "Denegar";
            this.rbDenegar.UseVisualStyleBackColor = true;
            // 
            // btnRealizar
            // 
            this.btnRealizar.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(157)))), ((int)(((byte)(6)))), ((int)(((byte)(32)))));
            this.btnRealizar.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnRealizar.Font = new System.Drawing.Font("Century Gothic", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnRealizar.ForeColor = System.Drawing.Color.White;
            this.btnRealizar.Location = new System.Drawing.Point(517, 661);
            this.btnRealizar.Name = "btnRealizar";
            this.btnRealizar.Size = new System.Drawing.Size(158, 26);
            this.btnRealizar.TabIndex = 64;
            this.btnRealizar.Text = "Realizar";
            this.btnRealizar.UseVisualStyleBackColor = false;
            this.btnRealizar.Click += new System.EventHandler(this.btnRealizar_Click);
            // 
            // txtBoxObservacionJefe
            // 
            this.txtBoxObservacionJefe.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.txtBoxObservacionJefe.Enabled = false;
            this.txtBoxObservacionJefe.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtBoxObservacionJefe.Location = new System.Drawing.Point(517, 452);
            this.txtBoxObservacionJefe.MaxLength = 200;
            this.txtBoxObservacionJefe.Name = "txtBoxObservacionJefe";
            this.txtBoxObservacionJefe.Size = new System.Drawing.Size(450, 156);
            this.txtBoxObservacionJefe.TabIndex = 66;
            this.txtBoxObservacionJefe.Text = "";
            // 
            // lblObservacionColocada
            // 
            this.lblObservacionColocada.AutoSize = true;
            this.lblObservacionColocada.Font = new System.Drawing.Font("Century Gothic", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblObservacionColocada.Location = new System.Drawing.Point(513, 412);
            this.lblObservacionColocada.Name = "lblObservacionColocada";
            this.lblObservacionColocada.Size = new System.Drawing.Size(258, 24);
            this.lblObservacionColocada.TabIndex = 65;
            this.lblObservacionColocada.Text = "Observacion Colocada:";
            // 
            // dtpFechaFormulacion
            // 
            this.dtpFechaFormulacion.Location = new System.Drawing.Point(303, 263);
            this.dtpFechaFormulacion.Name = "dtpFechaFormulacion";
            this.dtpFechaFormulacion.Size = new System.Drawing.Size(193, 20);
            this.dtpFechaFormulacion.TabIndex = 67;
            // 
            // dtpFechaAprobacion
            // 
            this.dtpFechaAprobacion.Location = new System.Drawing.Point(774, 263);
            this.dtpFechaAprobacion.Name = "dtpFechaAprobacion";
            this.dtpFechaAprobacion.Size = new System.Drawing.Size(193, 20);
            this.dtpFechaAprobacion.TabIndex = 68;
            // 
            // frmPlanVerDetalle
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(1107, 755);
            this.Controls.Add(this.dtpFechaAprobacion);
            this.Controls.Add(this.dtpFechaFormulacion);
            this.Controls.Add(this.txtBoxObservacionJefe);
            this.Controls.Add(this.lblObservacionColocada);
            this.Controls.Add(this.btnRealizar);
            this.Controls.Add(this.rbDenegar);
            this.Controls.Add(this.rbAprobar);
            this.Controls.Add(this.panelDatosColaborador);
            this.Controls.Add(this.btnRegresar);
            this.Controls.Add(this.txtEstado);
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
            this.Controls.Add(this.txtIDObjetivo);
            this.Controls.Add(this.lblIDObjetivo);
            this.Controls.Add(this.lblUnidadMedida);
            this.Controls.Add(this.lblEditarObjetivos);
            this.Name = "frmPlanVerDetalle";
            this.Text = "frmPlanVerDetalle";
            this.Load += new System.EventHandler(this.frmPlanVerDetalle_Load);
            this.panelDatosColaborador.ResumeLayout(false);
            this.panelDatosColaborador.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Button btnRegresar;
        private System.Windows.Forms.TextBox txtEstado;
        private System.Windows.Forms.RichTextBox txtBoxDescripcion;
        private System.Windows.Forms.TextBox txtUnidadMedida;
        private System.Windows.Forms.TextBox txtPeso;
        private System.Windows.Forms.Label lblFechaAprobacion;
        private System.Windows.Forms.Label lblFechaFormulacion;
        private System.Windows.Forms.Label lblEstado;
        private System.Windows.Forms.Label lblDescripcion;
        private System.Windows.Forms.Label lblMeta;
        private System.Windows.Forms.Label lblObservacionJefe;
        private System.Windows.Forms.Label lblPeso;
        private System.Windows.Forms.TextBox txtMeta;
        private System.Windows.Forms.TextBox txtIDObjetivo;
        private System.Windows.Forms.Label lblIDObjetivo;
        private System.Windows.Forms.Label lblUnidadMedida;
        private System.Windows.Forms.Label lblEditarObjetivos;
        private System.Windows.Forms.Label lblDNI;
        private System.Windows.Forms.TextBox txtGerencia;
        private System.Windows.Forms.TextBox txtCargo;
        private System.Windows.Forms.TextBox txtDNI;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox txtNombre;
        private System.Windows.Forms.Label lblNombre;
        private System.Windows.Forms.TextBox txtIDColab;
        private System.Windows.Forms.Label lblIDColab;
        private System.Windows.Forms.Label lblDatosColaborador;
        private System.Windows.Forms.Panel panelDatosColaborador;
        private System.Windows.Forms.RadioButton rbAprobar;
        private System.Windows.Forms.RadioButton rbDenegar;
        private System.Windows.Forms.Button btnRealizar;
        private System.Windows.Forms.RichTextBox txtBoxObservacionJefe;
        private System.Windows.Forms.Label lblObservacionColocada;
        private System.Windows.Forms.DateTimePicker dtpFechaFormulacion;
        private System.Windows.Forms.DateTimePicker dtpFechaAprobacion;
    }
}