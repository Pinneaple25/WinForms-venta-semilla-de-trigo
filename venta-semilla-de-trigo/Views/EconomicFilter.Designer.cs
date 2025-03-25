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
            SuspendLayout();
            // 
            // BtnGraficar
            // 
            BtnGraficar.Location = new Point(37, 193);
            BtnGraficar.Name = "BtnGraficar";
            BtnGraficar.Size = new Size(94, 29);
            BtnGraficar.TabIndex = 7;
            BtnGraficar.Text = "Aceptar";
            BtnGraficar.UseVisualStyleBackColor = true;
            BtnGraficar.Click += BtnGraficar_Click;
            // 
            // SelectorPanel
            // 
            SelectorPanel.Location = new Point(37, 22);
            SelectorPanel.Name = "SelectorPanel";
            SelectorPanel.Size = new Size(379, 158);
            SelectorPanel.TabIndex = 8;
            // 
            // EconomicFilter
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(457, 234);
            Controls.Add(SelectorPanel);
            Controls.Add(BtnGraficar);
            FormBorderStyle = FormBorderStyle.FixedSingle;
            MaximizeBox = false;
            Name = "EconomicFilter";
            ResumeLayout(false);
        }

        #endregion

        private Button BtnGraficar;
        private Panel SelectorPanel;
    }
}