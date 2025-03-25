namespace venta_semilla_de_trigo.Views
{
    partial class Stadistics
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
            PFilter1 = new Panel();
            PFilter2 = new Panel();
            PFilter3 = new Panel();
            BtnGraficar = new Button();
            FilterPanel = new Panel();
            SelectorPanel = new Panel();
            SuspendLayout();
            // 
            // PFilter1
            // 
            PFilter1.Location = new Point(464, 23);
            PFilter1.Name = "PFilter1";
            PFilter1.Size = new Size(396, 125);
            PFilter1.TabIndex = 2;
            // 
            // PFilter2
            // 
            PFilter2.Location = new Point(464, 154);
            PFilter2.Name = "PFilter2";
            PFilter2.Size = new Size(396, 125);
            PFilter2.TabIndex = 3;
            // 
            // PFilter3
            // 
            PFilter3.Location = new Point(464, 285);
            PFilter3.Name = "PFilter3";
            PFilter3.Size = new Size(396, 125);
            PFilter3.TabIndex = 4;
            // 
            // BtnGraficar
            // 
            BtnGraficar.Location = new Point(766, 421);
            BtnGraficar.Name = "BtnGraficar";
            BtnGraficar.Size = new Size(94, 29);
            BtnGraficar.TabIndex = 5;
            BtnGraficar.Text = "Aceptar";
            BtnGraficar.UseVisualStyleBackColor = true;
            BtnGraficar.Click += BtnGraficar_Click;
            // 
            // FilterPanel
            // 
            FilterPanel.Location = new Point(48, 23);
            FilterPanel.Name = "FilterPanel";
            FilterPanel.Size = new Size(365, 209);
            FilterPanel.TabIndex = 6;
            // 
            // SelectorPanel
            // 
            SelectorPanel.Location = new Point(48, 238);
            SelectorPanel.Name = "SelectorPanel";
            SelectorPanel.Size = new Size(365, 172);
            SelectorPanel.TabIndex = 7;
            // 
            // Stadistics
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(884, 462);
            Controls.Add(SelectorPanel);
            Controls.Add(FilterPanel);
            Controls.Add(BtnGraficar);
            Controls.Add(PFilter3);
            Controls.Add(PFilter2);
            Controls.Add(PFilter1);
            FormBorderStyle = FormBorderStyle.FixedSingle;
            MaximizeBox = false;
            MinimumSize = new Size(902, 451);
            Name = "Stadistics";
            StartPosition = FormStartPosition.CenterScreen;
            ResumeLayout(false);
        }

        #endregion
        private Panel PFilter1;
        private Panel PFilter2;
        private Panel PFilter3;
        private Button BtnGraficar;
        private Panel FilterPanel;
        private Panel SelectorPanel;
    }
}