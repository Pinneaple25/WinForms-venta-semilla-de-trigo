namespace venta_semilla_de_trigo.Views
{
    partial class EconomicFilter
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
            BtnGraficar = new Button();
            SelectorPanel = new Panel();
            FilterPanel = new Panel();
            PFilter3 = new Panel();
            PFilter2 = new Panel();
            PFilter1 = new Panel();
            RbBy = new CheckBox();
            SuspendLayout();
            // 
            // BtnGraficar
            // 
            BtnGraficar.Location = new Point(715, 431);
            BtnGraficar.Name = "BtnGraficar";
            BtnGraficar.Size = new Size(94, 29);
            BtnGraficar.TabIndex = 7;
            BtnGraficar.Text = "Aceptar";
            BtnGraficar.UseVisualStyleBackColor = true;
            BtnGraficar.Click += BtnGraficar_Click;
            // 
            // SelectorPanel
            // 
            SelectorPanel.Location = new Point(24, 227);
            SelectorPanel.Name = "SelectorPanel";
            SelectorPanel.Size = new Size(365, 172);
            SelectorPanel.TabIndex = 8;
            // 
            // FilterPanel
            // 
            FilterPanel.Location = new Point(24, 12);
            FilterPanel.Name = "FilterPanel";
            FilterPanel.Size = new Size(365, 209);
            FilterPanel.TabIndex = 7;
            // 
            // PFilter3
            // 
            PFilter3.Location = new Point(413, 274);
            PFilter3.Name = "PFilter3";
            PFilter3.Size = new Size(396, 125);
            PFilter3.TabIndex = 11;
            // 
            // PFilter2
            // 
            PFilter2.Location = new Point(413, 143);
            PFilter2.Name = "PFilter2";
            PFilter2.Size = new Size(396, 125);
            PFilter2.TabIndex = 10;
            // 
            // PFilter1
            // 
            PFilter1.Location = new Point(413, 12);
            PFilter1.Name = "PFilter1";
            PFilter1.Size = new Size(396, 125);
            PFilter1.TabIndex = 9;
            // 
            // TbBy
            // 
            RbBy.AutoSize = true;
            RbBy.Location = new Point(24, 420);
            RbBy.Name = "TbBy";
            RbBy.Size = new Size(128, 24);
            RbBy.TabIndex = 12;
            RbBy.Text = "Mostrar costos";
            RbBy.UseVisualStyleBackColor = true;
            RbBy.CheckedChanged += TbBy_CheckedChanged;
            // 
            // EconomicFilter
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(831, 472);
            Controls.Add(RbBy);
            Controls.Add(PFilter3);
            Controls.Add(PFilter2);
            Controls.Add(PFilter1);
            Controls.Add(FilterPanel);
            Controls.Add(SelectorPanel);
            Controls.Add(BtnGraficar);
            FormBorderStyle = FormBorderStyle.FixedSingle;
            MaximizeBox = false;
            Name = "EconomicFilter";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Button BtnGraficar;
        private Panel SelectorPanel;
        private Panel FilterPanel;
        private Panel PFilter3;
        private Panel PFilter2;
        private Panel PFilter1;
        private CheckBox RbBy;
    }
}