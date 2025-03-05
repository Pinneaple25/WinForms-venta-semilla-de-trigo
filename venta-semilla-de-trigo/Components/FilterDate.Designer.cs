namespace venta_semilla_de_trigo.Components
{
    partial class FilterDate
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
            CbxMinMonth = new ComboBox();
            label1 = new Label();
            NudMinYear = new NumericUpDown();
            NudMaxYear = new NumericUpDown();
            CbxMaxMonth = new ComboBox();
            ((System.ComponentModel.ISupportInitialize)NudMinYear).BeginInit();
            ((System.ComponentModel.ISupportInitialize)NudMaxYear).BeginInit();
            SuspendLayout();
            // 
            // LbItems
            // 
            LbItems.AutoSize = true;
            LbItems.Location = new Point(22, 13);
            LbItems.Name = "LbItems";
            LbItems.Size = new Size(47, 20);
            LbItems.TabIndex = 3;
            LbItems.Text = "Fecha";
            // 
            // CbxMinMonth
            // 
            CbxMinMonth.FormattingEnabled = true;
            CbxMinMonth.Items.AddRange(new object[] { "ENERO", "FEBRERO", "MARZO", "ABRIL", "MAYO", "JUNIO", "JULIO", "AGOSTO", "SEPTIEMBRE", "OCTUBRE", "NOVIEMBRE", "DICIEMBRE" });
            CbxMinMonth.Location = new Point(14, 40);
            CbxMinMonth.Name = "CbxMinMonth";
            CbxMinMonth.Size = new Size(151, 28);
            CbxMinMonth.TabIndex = 4;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(149, 71);
            label1.Name = "label1";
            label1.Size = new Size(17, 20);
            label1.TabIndex = 5;
            label1.Text = "a";
            // 
            // NudMinYear
            // 
            NudMinYear.Location = new Point(171, 40);
            NudMinYear.Maximum = new decimal(new int[] { 2030, 0, 0, 0 });
            NudMinYear.Minimum = new decimal(new int[] { 2010, 0, 0, 0 });
            NudMinYear.Name = "NudMinYear";
            NudMinYear.Size = new Size(95, 27);
            NudMinYear.TabIndex = 6;
            NudMinYear.Value = new decimal(new int[] { 2010, 0, 0, 0 });
            // 
            // NudMaxYear
            // 
            NudMaxYear.Location = new Point(172, 94);
            NudMaxYear.Maximum = new decimal(new int[] { 2030, 0, 0, 0 });
            NudMaxYear.Minimum = new decimal(new int[] { 2010, 0, 0, 0 });
            NudMaxYear.Name = "NudMaxYear";
            NudMaxYear.Size = new Size(95, 27);
            NudMaxYear.TabIndex = 8;
            NudMaxYear.Value = new decimal(new int[] { 2010, 0, 0, 0 });
            // 
            // CbxMaxMonth
            // 
            CbxMaxMonth.FormattingEnabled = true;
            CbxMaxMonth.Items.AddRange(new object[] { "ENERO", "FEBRERO", "MARZO", "ABRIL", "MAYO", "JUNIO", "JULIO", "AGOSTO", "SEPTIEMBRE", "OCTUBRE", "NOVIEMBRE", "DICIEMBRE" });
            CbxMaxMonth.Location = new Point(15, 94);
            CbxMaxMonth.Name = "CbxMaxMonth";
            CbxMaxMonth.Size = new Size(151, 28);
            CbxMaxMonth.TabIndex = 7;
            // 
            // FilterDate
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            Controls.Add(NudMaxYear);
            Controls.Add(CbxMaxMonth);
            Controls.Add(NudMinYear);
            Controls.Add(label1);
            Controls.Add(CbxMinMonth);
            Controls.Add(LbItems);
            Name = "FilterDate";
            Size = new Size(388, 150);
            ((System.ComponentModel.ISupportInitialize)NudMinYear).EndInit();
            ((System.ComponentModel.ISupportInitialize)NudMaxYear).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label LbItems;
        private ComboBox CbxMinMonth;
        private Label label1;
        private NumericUpDown NudMinYear;
        private NumericUpDown NudMaxYear;
        private ComboBox CbxMaxMonth;
    }
}
