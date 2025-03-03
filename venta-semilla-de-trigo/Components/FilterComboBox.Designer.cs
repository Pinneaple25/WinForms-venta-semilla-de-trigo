namespace venta_semilla_de_trigo.Components
{
    partial class FilterComboBox
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
            LbItems = new Label();
            CbxItems = new ComboBox();
            SuspendLayout();
            // 
            // LbItems
            // 
            LbItems.AutoSize = true;
            LbItems.Location = new Point(22, 13);
            LbItems.Name = "LbItems";
            LbItems.Size = new Size(46, 20);
            LbItems.TabIndex = 0;
            LbItems.Text = "{Text}";
            // 
            // CbxItems
            // 
            CbxItems.FormattingEnabled = true;
            CbxItems.Location = new Point(22, 43);
            CbxItems.Name = "CbxItems";
            CbxItems.Size = new Size(296, 28);
            CbxItems.TabIndex = 1;
            // 
            // FilterComboBox
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            Controls.Add(CbxItems);
            Controls.Add(LbItems);
            Name = "FilterComboBox";
            Size = new Size(345, 88);
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label LbItems;
        private ComboBox CbxItems;
    }
}
