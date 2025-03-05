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
            LbTitle = new Label();
            CbxItems = new ComboBox();
            SuspendLayout();
            // 
            // LbItems
            // 
            LbTitle.AutoSize = true;
            LbTitle.Location = new Point(22, 13);
            LbTitle.Name = "LbItems";
            LbTitle.Size = new Size(0, 20);
            LbTitle.TabIndex = 0;
            // 
            // CbxItems
            // 
            CbxItems.FormattingEnabled = true;
            CbxItems.Location = new Point(22, 43);
            CbxItems.Name = "CbxItems";
            CbxItems.Size = new Size(296, 28);
            CbxItems.Sorted = true;
            CbxItems.TabIndex = 1;
            // 
            // FilterComboBox
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            Controls.Add(CbxItems);
            Controls.Add(LbTitle);
            Name = "FilterComboBox";
            Size = new Size(345, 88);
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label LbTitle;
        private ComboBox CbxItems;
    }
}
