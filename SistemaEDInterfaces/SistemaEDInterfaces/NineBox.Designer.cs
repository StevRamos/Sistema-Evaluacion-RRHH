namespace SistemaEDInterfaces
{
    partial class NineBox
    {
        /// <summary> 
        /// Variable del diseñador necesaria.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary> 
        /// Limpiar los recursos que se estén usando.
        /// </summary>
        /// <param name="disposing">true si los recursos administrados se deben desechar; false en caso contrario.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Código generado por el Diseñador de componentes

        /// <summary> 
        /// Método necesario para admitir el Diseñador. No se puede modificar
        /// el contenido de este método con el editor de código.
        /// </summary>
        private void InitializeComponent()
        {
            this.tlp9Box = new System.Windows.Forms.TableLayoutPanel();
            this.SuspendLayout();
            // 
            // tlp9Box
            // 
            this.tlp9Box.AllowDrop = true;
            this.tlp9Box.AutoSize = true;
            this.tlp9Box.BackColor = System.Drawing.SystemColors.InactiveCaption;
            this.tlp9Box.CellBorderStyle = System.Windows.Forms.TableLayoutPanelCellBorderStyle.Single;
            this.tlp9Box.ColumnCount = 2;
            this.tlp9Box.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tlp9Box.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tlp9Box.Location = new System.Drawing.Point(3, 3);
            this.tlp9Box.Name = "tlp9Box";
            this.tlp9Box.RowCount = 2;
            this.tlp9Box.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tlp9Box.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tlp9Box.Size = new System.Drawing.Size(775, 414);
            this.tlp9Box.TabIndex = 0;
            // 
            // _9Box
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoSize = true;
            this.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.Controls.Add(this.tlp9Box);
            this.Name = "_9Box";
            this.Size = new System.Drawing.Size(781, 420);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TableLayoutPanel tlp9Box;
    }
}
