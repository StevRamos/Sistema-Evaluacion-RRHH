namespace SistemaEDInterfaces
{
    partial class frmRepPDI
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
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle1 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle2 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle3 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle4 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle5 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle6 = new System.Windows.Forms.DataGridViewCellStyle();
            this.lblPDI = new System.Windows.Forms.Label();
            this.lblJPuesto = new System.Windows.Forms.Label();
            this.lblNombre = new System.Windows.Forms.Label();
            this.lblJefe = new System.Windows.Forms.Label();
            this.txtNombre = new System.Windows.Forms.TextBox();
            this.txtJefe = new System.Windows.Forms.TextBox();
            this.txtPuesto = new System.Windows.Forms.TextBox();
            this.txtGerencia = new System.Windows.Forms.TextBox();
            this.lblGerencia = new System.Windows.Forms.Label();
            this.panel1 = new System.Windows.Forms.Panel();
            this.btnRegistrar = new System.Windows.Forms.Button();
            this.lblComentarios = new System.Windows.Forms.Label();
            this.txtbComentario = new System.Windows.Forms.TextBox();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.dataGridViewTextBoxColumn1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn2 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Acciones = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.FechaCumplimiento = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dgvCupos = new System.Windows.Forms.DataGridView();
            this.Competencia = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Subcompetencia = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.panel2 = new System.Windows.Forms.Panel();
            this.lblOportunidades = new System.Windows.Forms.Label();
            this.panelFortalezas = new System.Windows.Forms.Panel();
            this.lblFortalezas = new System.Windows.Forms.Label();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgvCupos)).BeginInit();
            this.panel2.SuspendLayout();
            this.panelFortalezas.SuspendLayout();
            this.SuspendLayout();
            // 
            // lblPDI
            // 
            this.lblPDI.AutoSize = true;
            this.lblPDI.Font = new System.Drawing.Font("Century Gothic", 36F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblPDI.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(66)))), ((int)(((byte)(122)))));
            this.lblPDI.Location = new System.Drawing.Point(19, 22);
            this.lblPDI.Name = "lblPDI";
            this.lblPDI.Size = new System.Drawing.Size(638, 56);
            this.lblPDI.TabIndex = 13;
            this.lblPDI.Text = "Plan de Desarrollo Integral";
            // 
            // lblJPuesto
            // 
            this.lblJPuesto.AutoSize = true;
            this.lblJPuesto.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.8F);
            this.lblJPuesto.Location = new System.Drawing.Point(131, 161);
            this.lblJPuesto.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lblJPuesto.Name = "lblJPuesto";
            this.lblJPuesto.Size = new System.Drawing.Size(78, 24);
            this.lblJPuesto.TabIndex = 15;
            this.lblJPuesto.Text = "Puesto :";
            // 
            // lblNombre
            // 
            this.lblNombre.AutoSize = true;
            this.lblNombre.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.8F);
            this.lblNombre.Location = new System.Drawing.Point(122, 110);
            this.lblNombre.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lblNombre.Name = "lblNombre";
            this.lblNombre.Size = new System.Drawing.Size(89, 24);
            this.lblNombre.TabIndex = 14;
            this.lblNombre.Text = "Nombre :";
            // 
            // lblJefe
            // 
            this.lblJefe.AutoSize = true;
            this.lblJefe.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.8F);
            this.lblJefe.Location = new System.Drawing.Point(93, 213);
            this.lblJefe.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lblJefe.Name = "lblJefe";
            this.lblJefe.Size = new System.Drawing.Size(117, 24);
            this.lblJefe.TabIndex = 16;
            this.lblJefe.Text = "Jefe directo :";
            // 
            // txtNombre
            // 
            this.txtNombre.Location = new System.Drawing.Point(268, 116);
            this.txtNombre.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.txtNombre.Name = "txtNombre";
            this.txtNombre.ReadOnly = true;
            this.txtNombre.Size = new System.Drawing.Size(745, 20);
            this.txtNombre.TabIndex = 17;
            this.txtNombre.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // txtJefe
            // 
            this.txtJefe.Location = new System.Drawing.Point(268, 219);
            this.txtJefe.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.txtJefe.Name = "txtJefe";
            this.txtJefe.ReadOnly = true;
            this.txtJefe.Size = new System.Drawing.Size(745, 20);
            this.txtJefe.TabIndex = 18;
            this.txtJefe.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // txtPuesto
            // 
            this.txtPuesto.Location = new System.Drawing.Point(268, 167);
            this.txtPuesto.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.txtPuesto.Name = "txtPuesto";
            this.txtPuesto.ReadOnly = true;
            this.txtPuesto.Size = new System.Drawing.Size(745, 20);
            this.txtPuesto.TabIndex = 19;
            this.txtPuesto.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // txtGerencia
            // 
            this.txtGerencia.Location = new System.Drawing.Point(268, 272);
            this.txtGerencia.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.txtGerencia.Name = "txtGerencia";
            this.txtGerencia.ReadOnly = true;
            this.txtGerencia.Size = new System.Drawing.Size(745, 20);
            this.txtGerencia.TabIndex = 21;
            this.txtGerencia.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // lblGerencia
            // 
            this.lblGerencia.AutoSize = true;
            this.lblGerencia.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.8F);
            this.lblGerencia.Location = new System.Drawing.Point(114, 266);
            this.lblGerencia.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lblGerencia.Name = "lblGerencia";
            this.lblGerencia.Size = new System.Drawing.Size(97, 24);
            this.lblGerencia.TabIndex = 20;
            this.lblGerencia.Text = "Gerencia :";
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.btnRegistrar);
            this.panel1.Controls.Add(this.lblComentarios);
            this.panel1.Controls.Add(this.txtbComentario);
            this.panel1.Controls.Add(this.dataGridView1);
            this.panel1.Controls.Add(this.dgvCupos);
            this.panel1.Controls.Add(this.panel2);
            this.panel1.Controls.Add(this.panelFortalezas);
            this.panel1.Location = new System.Drawing.Point(1, 337);
            this.panel1.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(1089, 1289);
            this.panel1.TabIndex = 22;
            // 
            // btnRegistrar
            // 
            this.btnRegistrar.Anchor = System.Windows.Forms.AnchorStyles.Right;
            this.btnRegistrar.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(157)))), ((int)(((byte)(6)))), ((int)(((byte)(32)))));
            this.btnRegistrar.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnRegistrar.Font = new System.Drawing.Font("Century Gothic", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnRegistrar.ForeColor = System.Drawing.Color.White;
            this.btnRegistrar.Location = new System.Drawing.Point(928, 1184);
            this.btnRegistrar.Name = "btnRegistrar";
            this.btnRegistrar.Size = new System.Drawing.Size(158, 26);
            this.btnRegistrar.TabIndex = 27;
            this.btnRegistrar.Text = "Registrar";
            this.btnRegistrar.UseVisualStyleBackColor = false;
            // 
            // lblComentarios
            // 
            this.lblComentarios.AutoSize = true;
            this.lblComentarios.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.8F);
            this.lblComentarios.Location = new System.Drawing.Point(21, 873);
            this.lblComentarios.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lblComentarios.Name = "lblComentarios";
            this.lblComentarios.Size = new System.Drawing.Size(189, 24);
            this.lblComentarios.TabIndex = 23;
            this.lblComentarios.Text = "Comentario General :";
            // 
            // txtbComentario
            // 
            this.txtbComentario.Location = new System.Drawing.Point(19, 899);
            this.txtbComentario.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.txtbComentario.Multiline = true;
            this.txtbComentario.Name = "txtbComentario";
            this.txtbComentario.Size = new System.Drawing.Size(1067, 213);
            this.txtbComentario.TabIndex = 26;
            // 
            // dataGridView1
            // 
            this.dataGridView1.AllowUserToAddRows = false;
            this.dataGridView1.AllowUserToDeleteRows = false;
            this.dataGridView1.AllowUserToResizeColumns = false;
            this.dataGridView1.AllowUserToResizeRows = false;
            this.dataGridView1.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.dataGridView1.AutoSizeRowsMode = System.Windows.Forms.DataGridViewAutoSizeRowsMode.AllCells;
            this.dataGridView1.BackgroundColor = System.Drawing.Color.White;
            this.dataGridView1.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.dataGridView1.ColumnHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.None;
            dataGridViewCellStyle1.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(66)))), ((int)(((byte)(122)))));
            dataGridViewCellStyle1.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle1.ForeColor = System.Drawing.Color.White;
            dataGridViewCellStyle1.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle1.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle1.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dataGridView1.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle1;
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.dataGridViewTextBoxColumn1,
            this.dataGridViewTextBoxColumn2,
            this.Acciones,
            this.FechaCumplimiento});
            this.dataGridView1.EnableHeadersVisualStyles = false;
            this.dataGridView1.GridColor = System.Drawing.SystemColors.ControlText;
            this.dataGridView1.Location = new System.Drawing.Point(9, 501);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.ReadOnly = true;
            dataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle2.BackColor = System.Drawing.Color.White;
            dataGridViewCellStyle2.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle2.ForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle2.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle2.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle2.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dataGridView1.RowHeadersDefaultCellStyle = dataGridViewCellStyle2;
            this.dataGridView1.RowHeadersVisible = false;
            this.dataGridView1.RowHeadersWidth = 51;
            dataGridViewCellStyle3.BackColor = System.Drawing.Color.White;
            dataGridViewCellStyle3.SelectionBackColor = System.Drawing.Color.White;
            dataGridViewCellStyle3.SelectionForeColor = System.Drawing.Color.White;
            this.dataGridView1.RowsDefaultCellStyle = dataGridViewCellStyle3;
            this.dataGridView1.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dataGridView1.Size = new System.Drawing.Size(1081, 106);
            this.dataGridView1.TabIndex = 25;
            // 
            // dataGridViewTextBoxColumn1
            // 
            this.dataGridViewTextBoxColumn1.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.dataGridViewTextBoxColumn1.FillWeight = 25F;
            this.dataGridViewTextBoxColumn1.HeaderText = "Competencia";
            this.dataGridViewTextBoxColumn1.MinimumWidth = 6;
            this.dataGridViewTextBoxColumn1.Name = "dataGridViewTextBoxColumn1";
            this.dataGridViewTextBoxColumn1.ReadOnly = true;
            this.dataGridViewTextBoxColumn1.Resizable = System.Windows.Forms.DataGridViewTriState.False;
            this.dataGridViewTextBoxColumn1.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.Programmatic;
            // 
            // dataGridViewTextBoxColumn2
            // 
            this.dataGridViewTextBoxColumn2.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.dataGridViewTextBoxColumn2.FillWeight = 43F;
            this.dataGridViewTextBoxColumn2.HeaderText = "Comportamiento";
            this.dataGridViewTextBoxColumn2.MinimumWidth = 6;
            this.dataGridViewTextBoxColumn2.Name = "dataGridViewTextBoxColumn2";
            this.dataGridViewTextBoxColumn2.ReadOnly = true;
            this.dataGridViewTextBoxColumn2.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.Programmatic;
            // 
            // Acciones
            // 
            this.Acciones.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.Acciones.FillWeight = 43F;
            this.Acciones.HeaderText = "Acciones a realizar";
            this.Acciones.MinimumWidth = 6;
            this.Acciones.Name = "Acciones";
            this.Acciones.ReadOnly = true;
            // 
            // FechaCumplimiento
            // 
            this.FechaCumplimiento.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.FechaCumplimiento.FillWeight = 25F;
            this.FechaCumplimiento.HeaderText = "Fecha de cumplimiento";
            this.FechaCumplimiento.MinimumWidth = 6;
            this.FechaCumplimiento.Name = "FechaCumplimiento";
            this.FechaCumplimiento.ReadOnly = true;
            // 
            // dgvCupos
            // 
            this.dgvCupos.AllowUserToAddRows = false;
            this.dgvCupos.AllowUserToDeleteRows = false;
            this.dgvCupos.AllowUserToResizeColumns = false;
            this.dgvCupos.AllowUserToResizeRows = false;
            this.dgvCupos.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.dgvCupos.AutoSizeRowsMode = System.Windows.Forms.DataGridViewAutoSizeRowsMode.AllCells;
            this.dgvCupos.BackgroundColor = System.Drawing.Color.White;
            this.dgvCupos.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.dgvCupos.ColumnHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.None;
            dataGridViewCellStyle4.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle4.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(66)))), ((int)(((byte)(122)))));
            dataGridViewCellStyle4.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle4.ForeColor = System.Drawing.Color.White;
            dataGridViewCellStyle4.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle4.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle4.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dgvCupos.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle4;
            this.dgvCupos.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvCupos.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.Competencia,
            this.Subcompetencia});
            this.dgvCupos.EnableHeadersVisualStyles = false;
            this.dgvCupos.GridColor = System.Drawing.SystemColors.ControlText;
            this.dgvCupos.Location = new System.Drawing.Point(3, 77);
            this.dgvCupos.Name = "dgvCupos";
            this.dgvCupos.ReadOnly = true;
            dataGridViewCellStyle5.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle5.BackColor = System.Drawing.Color.White;
            dataGridViewCellStyle5.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle5.ForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle5.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle5.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle5.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dgvCupos.RowHeadersDefaultCellStyle = dataGridViewCellStyle5;
            this.dgvCupos.RowHeadersVisible = false;
            this.dgvCupos.RowHeadersWidth = 51;
            dataGridViewCellStyle6.BackColor = System.Drawing.Color.White;
            dataGridViewCellStyle6.SelectionBackColor = System.Drawing.Color.White;
            dataGridViewCellStyle6.SelectionForeColor = System.Drawing.Color.White;
            this.dgvCupos.RowsDefaultCellStyle = dataGridViewCellStyle6;
            this.dgvCupos.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dgvCupos.Size = new System.Drawing.Size(1086, 106);
            this.dgvCupos.TabIndex = 3;
            // 
            // Competencia
            // 
            this.Competencia.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.Competencia.FillWeight = 43F;
            this.Competencia.HeaderText = "Competencia";
            this.Competencia.MinimumWidth = 6;
            this.Competencia.Name = "Competencia";
            this.Competencia.ReadOnly = true;
            this.Competencia.Resizable = System.Windows.Forms.DataGridViewTriState.False;
            this.Competencia.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.Programmatic;
            // 
            // Subcompetencia
            // 
            this.Subcompetencia.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.Subcompetencia.FillWeight = 86F;
            this.Subcompetencia.HeaderText = "Subcompetencia";
            this.Subcompetencia.MinimumWidth = 6;
            this.Subcompetencia.Name = "Subcompetencia";
            this.Subcompetencia.ReadOnly = true;
            this.Subcompetencia.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.Programmatic;
            // 
            // panel2
            // 
            this.panel2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(66)))), ((int)(((byte)(122)))));
            this.panel2.Controls.Add(this.lblOportunidades);
            this.panel2.Location = new System.Drawing.Point(8, 427);
            this.panel2.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(1082, 46);
            this.panel2.TabIndex = 24;
            // 
            // lblOportunidades
            // 
            this.lblOportunidades.AutoSize = true;
            this.lblOportunidades.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F, System.Drawing.FontStyle.Bold);
            this.lblOportunidades.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.lblOportunidades.Location = new System.Drawing.Point(444, 11);
            this.lblOportunidades.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lblOportunidades.Name = "lblOportunidades";
            this.lblOportunidades.Size = new System.Drawing.Size(255, 25);
            this.lblOportunidades.TabIndex = 23;
            this.lblOportunidades.Text = "Oportunidades de mejora";
            // 
            // panelFortalezas
            // 
            this.panelFortalezas.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(66)))), ((int)(((byte)(122)))));
            this.panelFortalezas.Controls.Add(this.lblFortalezas);
            this.panelFortalezas.Location = new System.Drawing.Point(2, 2);
            this.panelFortalezas.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.panelFortalezas.Name = "panelFortalezas";
            this.panelFortalezas.Size = new System.Drawing.Size(1088, 46);
            this.panelFortalezas.TabIndex = 0;
            // 
            // lblFortalezas
            // 
            this.lblFortalezas.AutoSize = true;
            this.lblFortalezas.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F, System.Drawing.FontStyle.Bold);
            this.lblFortalezas.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.lblFortalezas.Location = new System.Drawing.Point(506, 9);
            this.lblFortalezas.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lblFortalezas.Name = "lblFortalezas";
            this.lblFortalezas.Size = new System.Drawing.Size(113, 25);
            this.lblFortalezas.TabIndex = 23;
            this.lblFortalezas.Text = "Fortalezas";
            // 
            // frmRepPDI
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoScroll = true;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(1107, 755);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.txtGerencia);
            this.Controls.Add(this.lblGerencia);
            this.Controls.Add(this.txtPuesto);
            this.Controls.Add(this.txtJefe);
            this.Controls.Add(this.txtNombre);
            this.Controls.Add(this.lblJefe);
            this.Controls.Add(this.lblJPuesto);
            this.Controls.Add(this.lblNombre);
            this.Controls.Add(this.lblPDI);
            this.Name = "frmRepPDI";
            this.Text = "frmRepPDI";
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgvCupos)).EndInit();
            this.panel2.ResumeLayout(false);
            this.panel2.PerformLayout();
            this.panelFortalezas.ResumeLayout(false);
            this.panelFortalezas.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lblPDI;
        private System.Windows.Forms.Label lblJPuesto;
        private System.Windows.Forms.Label lblNombre;
        private System.Windows.Forms.Label lblJefe;
        private System.Windows.Forms.TextBox txtNombre;
        private System.Windows.Forms.TextBox txtJefe;
        private System.Windows.Forms.TextBox txtPuesto;
        private System.Windows.Forms.TextBox txtGerencia;
        private System.Windows.Forms.Label lblGerencia;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Panel panelFortalezas;
        private System.Windows.Forms.Label lblFortalezas;
        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.DataGridView dgvCupos;
        private System.Windows.Forms.DataGridViewTextBoxColumn Competencia;
        private System.Windows.Forms.DataGridViewTextBoxColumn Subcompetencia;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.Label lblOportunidades;
        private System.Windows.Forms.Label lblComentarios;
        private System.Windows.Forms.TextBox txtbComentario;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn1;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn2;
        private System.Windows.Forms.DataGridViewTextBoxColumn Acciones;
        private System.Windows.Forms.DataGridViewTextBoxColumn FechaCumplimiento;
        private System.Windows.Forms.Button btnRegistrar;
    }
}