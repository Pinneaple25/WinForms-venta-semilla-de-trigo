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
            GbxGraficar = new GroupBox();
            RbOficio = new RadioButton();
            RbLote = new RadioButton();
            RbCiclo = new RadioButton();
            RbCategoria = new RadioButton();
            RbVariedad = new RadioButton();
            RbSolicitante = new RadioButton();
            PFilter1 = new Panel();
            PFilter2 = new Panel();
            PFilter3 = new Panel();
            BtnGraficar = new Button();
            FilterPanel = new Panel();
            GbxGraficar.SuspendLayout();
            SuspendLayout();
            // 
            // GbxGraficar
            // 
            GbxGraficar.Controls.Add(RbOficio);
            GbxGraficar.Controls.Add(RbLote);
            GbxGraficar.Controls.Add(RbCiclo);
            GbxGraficar.Controls.Add(RbCategoria);
            GbxGraficar.Controls.Add(RbVariedad);
            GbxGraficar.Controls.Add(RbSolicitante);
            GbxGraficar.Location = new Point(48, 238);
            GbxGraficar.Name = "GbxGraficar";
            GbxGraficar.Size = new Size(365, 121);
            GbxGraficar.TabIndex = 1;
            GbxGraficar.TabStop = false;
            GbxGraficar.Text = "Graficar por:";
            // 
            // RbOficio
            // 
            RbOficio.AutoSize = true;
            RbOficio.Location = new Point(180, 86);
            RbOficio.Name = "RbOficio";
            RbOficio.Size = new Size(133, 24);
            RbOficio.TabIndex = 5;
            RbOficio.Text = "OFICIO Reporte";
            RbOficio.UseVisualStyleBackColor = true;
            // 
            // RbLote
            // 
            RbLote.AutoSize = true;
            RbLote.Location = new Point(13, 86);
            RbLote.Name = "RbLote";
            RbLote.Size = new Size(62, 24);
            RbLote.TabIndex = 4;
            RbLote.Text = "LOTE";
            RbLote.UseVisualStyleBackColor = true;
            // 
            // RbCiclo
            // 
            RbCiclo.AutoSize = true;
            RbCiclo.Location = new Point(180, 56);
            RbCiclo.Name = "RbCiclo";
            RbCiclo.Size = new Size(166, 24);
            RbCiclo.TabIndex = 3;
            RbCiclo.Text = "CICLO PRODUCCIÓN";
            RbCiclo.UseVisualStyleBackColor = true;
            // 
            // RbCategoria
            // 
            RbCategoria.AutoSize = true;
            RbCategoria.Location = new Point(13, 56);
            RbCategoria.Name = "RbCategoria";
            RbCategoria.Size = new Size(108, 24);
            RbCategoria.TabIndex = 2;
            RbCategoria.Text = "CATEGORIA";
            RbCategoria.UseVisualStyleBackColor = true;
            // 
            // RbVariedad
            // 
            RbVariedad.AutoSize = true;
            RbVariedad.Location = new Point(250, 26);
            RbVariedad.Name = "RbVariedad";
            RbVariedad.Size = new Size(101, 24);
            RbVariedad.TabIndex = 1;
            RbVariedad.Text = "VARIEDAD";
            RbVariedad.UseVisualStyleBackColor = true;
            // 
            // RbSolicitante
            // 
            RbSolicitante.AutoSize = true;
            RbSolicitante.Checked = true;
            RbSolicitante.Location = new Point(12, 26);
            RbSolicitante.Name = "RbSolicitante";
            RbSolicitante.Size = new Size(222, 24);
            RbSolicitante.TabIndex = 0;
            RbSolicitante.TabStop = true;
            RbSolicitante.Text = "SOLICITANTE - COMPRADOR";
            RbSolicitante.UseVisualStyleBackColor = true;
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
            BtnGraficar.Location = new Point(48, 381);
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
            // Stadistics
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(884, 423);
            Controls.Add(FilterPanel);
            Controls.Add(BtnGraficar);
            Controls.Add(PFilter3);
            Controls.Add(PFilter2);
            Controls.Add(PFilter1);
            Controls.Add(GbxGraficar);
            FormBorderStyle = FormBorderStyle.FixedSingle;
            MaximizeBox = false;
            MinimumSize = new Size(902, 451);
            Name = "Stadistics";
            StartPosition = FormStartPosition.CenterScreen;
            GbxGraficar.ResumeLayout(false);
            GbxGraficar.PerformLayout();
            ResumeLayout(false);
        }

        #endregion
        private GroupBox GbxGraficar;
        private RadioButton RbOficio;
        private RadioButton RbLote;
        private RadioButton RbCiclo;
        private RadioButton RbCategoria;
        private RadioButton RbVariedad;
        private RadioButton RbSolicitante;
        private Panel PFilter1;
        private Panel PFilter2;
        private Panel PFilter3;
        private Button BtnGraficar;
        private Panel FilterPanel;
    }
}