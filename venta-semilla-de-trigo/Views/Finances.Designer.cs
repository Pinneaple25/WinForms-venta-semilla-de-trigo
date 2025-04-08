namespace venta_semilla_de_trigo.Views
{
    partial class Finances
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
            GbMuestreo = new GroupBox();
            RbMensual = new RadioButton();
            RbBimestral = new RadioButton();
            RbTrimestral = new RadioButton();
            RbCuatrimestral = new RadioButton();
            RbSemestral = new RadioButton();
            RbAnual = new RadioButton();
            RbLustros = new RadioButton();
            BtnGraficar = new Button();
            filterDate = new venta_semilla_de_trigo.Components.FilterDate();
            PFiltro = new Panel();
            CbGlobal = new CheckBox();
            GbMuestreo.SuspendLayout();
            SuspendLayout();
            // 
            // GbMuestreo
            // 
            GbMuestreo.Anchor = AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
            GbMuestreo.Controls.Add(RbMensual);
            GbMuestreo.Controls.Add(RbBimestral);
            GbMuestreo.Controls.Add(RbTrimestral);
            GbMuestreo.Controls.Add(RbCuatrimestral);
            GbMuestreo.Controls.Add(RbSemestral);
            GbMuestreo.Controls.Add(RbAnual);
            GbMuestreo.Controls.Add(RbLustros);
            GbMuestreo.Location = new Point(12, 159);
            GbMuestreo.Name = "GbMuestreo";
            GbMuestreo.Size = new Size(500, 125);
            GbMuestreo.TabIndex = 0;
            GbMuestreo.TabStop = false;
            GbMuestreo.Text = "Intervalo de muestreo";
            // 
            // RbMensual
            // 
            RbMensual.AutoSize = true;
            RbMensual.Location = new Point(242, 72);
            RbMensual.Name = "RbMensual";
            RbMensual.Size = new Size(85, 24);
            RbMensual.TabIndex = 6;
            RbMensual.Text = "Mensual";
            RbMensual.UseVisualStyleBackColor = true;
            // 
            // RbBimestral
            // 
            RbBimestral.AutoSize = true;
            RbBimestral.Location = new Point(127, 72);
            RbBimestral.Name = "RbBimestral";
            RbBimestral.Size = new Size(92, 24);
            RbBimestral.TabIndex = 5;
            RbBimestral.Text = "Bimestral";
            RbBimestral.UseVisualStyleBackColor = true;
            // 
            // RbTrimestral
            // 
            RbTrimestral.AutoSize = true;
            RbTrimestral.Location = new Point(6, 72);
            RbTrimestral.Name = "RbTrimestral";
            RbTrimestral.Size = new Size(95, 24);
            RbTrimestral.TabIndex = 4;
            RbTrimestral.Text = "Trimestral";
            RbTrimestral.UseVisualStyleBackColor = true;
            // 
            // RbCuatrimestral
            // 
            RbCuatrimestral.AutoSize = true;
            RbCuatrimestral.Location = new Point(362, 42);
            RbCuatrimestral.Name = "RbCuatrimestral";
            RbCuatrimestral.Size = new Size(118, 24);
            RbCuatrimestral.TabIndex = 3;
            RbCuatrimestral.Text = "Cuatrimestral";
            RbCuatrimestral.UseVisualStyleBackColor = true;
            // 
            // RbSemestral
            // 
            RbSemestral.AutoSize = true;
            RbSemestral.Location = new Point(242, 42);
            RbSemestral.Name = "RbSemestral";
            RbSemestral.Size = new Size(95, 24);
            RbSemestral.TabIndex = 2;
            RbSemestral.Text = "Semestral";
            RbSemestral.UseVisualStyleBackColor = true;
            // 
            // RbAnual
            // 
            RbAnual.AutoSize = true;
            RbAnual.Location = new Point(127, 42);
            RbAnual.Name = "RbAnual";
            RbAnual.Size = new Size(68, 24);
            RbAnual.TabIndex = 1;
            RbAnual.Text = "Anual";
            RbAnual.UseVisualStyleBackColor = true;
            // 
            // RbLustros
            // 
            RbLustros.AutoSize = true;
            RbLustros.Checked = true;
            RbLustros.Location = new Point(6, 42);
            RbLustros.Name = "RbLustros";
            RbLustros.Size = new Size(76, 24);
            RbLustros.TabIndex = 0;
            RbLustros.TabStop = true;
            RbLustros.Text = "Lustros";
            RbLustros.UseVisualStyleBackColor = true;
            // 
            // BtnGraficar
            // 
            BtnGraficar.Anchor = AnchorStyles.Bottom | AnchorStyles.Right;
            BtnGraficar.Location = new Point(584, 255);
            BtnGraficar.Name = "BtnGraficar";
            BtnGraficar.Size = new Size(94, 29);
            BtnGraficar.TabIndex = 1;
            BtnGraficar.Text = "Aceptar";
            BtnGraficar.UseVisualStyleBackColor = true;
            BtnGraficar.Click += BtnGraficar_Click;
            // 
            // filterDate
            // 
            filterDate.Location = new Point(18, 12);
            filterDate.Name = "filterDate";
            filterDate.Size = new Size(279, 129);
            filterDate.TabIndex = 2;
            // 
            // PFiltro
            // 
            PFiltro.Location = new Point(319, 12);
            PFiltro.Name = "PFiltro";
            PFiltro.Size = new Size(321, 95);
            PFiltro.TabIndex = 3;
            PFiltro.Visible = false;
            // 
            // CbGlobal
            // 
            CbGlobal.AutoSize = true;
            CbGlobal.Location = new Point(357, 117);
            CbGlobal.Name = "CbGlobal";
            CbGlobal.Size = new Size(75, 24);
            CbGlobal.TabIndex = 4;
            CbGlobal.Text = "Global";
            CbGlobal.UseVisualStyleBackColor = true;
            CbGlobal.CheckedChanged += CbGlobal_CheckedChanged;
            // 
            // Finances
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(698, 296);
            Controls.Add(CbGlobal);
            Controls.Add(PFiltro);
            Controls.Add(filterDate);
            Controls.Add(BtnGraficar);
            Controls.Add(GbMuestreo);
            FormBorderStyle = FormBorderStyle.FixedSingle;
            MaximizeBox = false;
            Name = "Finances";
            StartPosition = FormStartPosition.CenterScreen;
            GbMuestreo.ResumeLayout(false);
            GbMuestreo.PerformLayout();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private GroupBox GbMuestreo;
        private RadioButton RbAnual;
        private RadioButton RbLustros;
        private RadioButton RbMensual;
        private RadioButton RbBimestral;
        private RadioButton RbTrimestral;
        private RadioButton RbCuatrimestral;
        private RadioButton RbSemestral;
        private Button BtnGraficar;
        private Components.FilterDate filterDate;
        private Panel PFiltro;
        private CheckBox CbGlobal;
    }
}