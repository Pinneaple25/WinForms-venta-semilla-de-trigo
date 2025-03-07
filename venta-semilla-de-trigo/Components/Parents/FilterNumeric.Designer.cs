namespace venta_semilla_de_trigo.Components
{
    partial class FilterNumeric
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
            NudMin = new NumericUpDown();
            NudMax = new NumericUpDown();
            ((System.ComponentModel.ISupportInitialize)NudMin).BeginInit();
            ((System.ComponentModel.ISupportInitialize)NudMax).BeginInit();
            SuspendLayout();
            // 
            // LbItems
            // 
            LbTitle.AutoSize = true;
            LbTitle.Location = new Point(22, 13);
            LbTitle.Name = "LbItems";
            LbTitle.Size = new Size(0, 20);
            LbTitle.TabIndex = 2;
            // 
            // NudMin
            // 
            NudMin.Location = new Point(22, 43);
            NudMin.Maximum = new decimal(new int[] { 100000, 0, 0, 0 });
            NudMin.Name = "NudMin";
            NudMin.Size = new Size(168, 27);
            NudMin.TabIndex = 3;
            NudMin.ThousandsSeparator = true;
            // 
            // NudMax
            // 
            NudMax.Location = new Point(218, 43);
            NudMax.Maximum = new decimal(new int[] { 100000, 0, 0, 0 });
            NudMax.Name = "NudMax";
            NudMax.Size = new Size(168, 27);
            NudMax.TabIndex = 4;
            NudMax.ThousandsSeparator = true;
            // 
            // FilterNumeric
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            Controls.Add(NudMax);
            Controls.Add(NudMin);
            Controls.Add(LbTitle);
            Name = "FilterNumeric";
            Size = new Size(409, 92);
            ((System.ComponentModel.ISupportInitialize)NudMin).EndInit();
            ((System.ComponentModel.ISupportInitialize)NudMax).EndInit();
            Load += OnLoadComponent;
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label LbTitle;
        private NumericUpDown NudMin;
        private NumericUpDown NudMax;
    }
}
