namespace venta_semilla_de_trigo.Views
{
    partial class Home
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
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
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            BtnOpenFolder = new Button();
            BtnEstadisticas = new Button();
            OpenFile = new OpenFileDialog();
            BtnContabilidad = new Button();
            BtnFinanzas = new Button();
            SuspendLayout();
            // 
            // BtnOpenFolder
            // 
            BtnOpenFolder.Location = new Point(85, 25);
            BtnOpenFolder.Name = "BtnOpenFolder";
            BtnOpenFolder.Size = new Size(120, 63);
            BtnOpenFolder.TabIndex = 0;
            BtnOpenFolder.Text = "Seleccionar\r\narchivo";
            BtnOpenFolder.UseVisualStyleBackColor = true;
            BtnOpenFolder.Click += BtnOpenFolder_Click;
            // 
            // BtnEstadisticas
            // 
            BtnEstadisticas.Enabled = false;
            BtnEstadisticas.Location = new Point(85, 117);
            BtnEstadisticas.Name = "BtnEstadisticas";
            BtnEstadisticas.Size = new Size(120, 63);
            BtnEstadisticas.TabIndex = 1;
            BtnEstadisticas.Text = "Estadísticas";
            BtnEstadisticas.UseVisualStyleBackColor = true;
            BtnEstadisticas.Click += BtnEstadisticas_Click;
            // 
            // OpenFile
            // 
            OpenFile.Filter = "Archivos de Excel|*.xlsx; *.xls";
            // 
            // BtnContabilidad
            // 
            BtnContabilidad.Enabled = false;
            BtnContabilidad.Location = new Point(237, 25);
            BtnContabilidad.Name = "BtnContabilidad";
            BtnContabilidad.Size = new Size(120, 63);
            BtnContabilidad.TabIndex = 2;
            BtnContabilidad.Text = "Contabilidad";
            BtnContabilidad.UseVisualStyleBackColor = true;
            BtnContabilidad.Click += BtnEconomia_Click;
            // 
            // BtnFinanzas
            // 
            BtnFinanzas.Enabled = false;
            BtnFinanzas.Location = new Point(237, 117);
            BtnFinanzas.Name = "BtnFinanzas";
            BtnFinanzas.Size = new Size(120, 63);
            BtnFinanzas.TabIndex = 3;
            BtnFinanzas.Text = "Gráficas financieras";
            BtnFinanzas.UseVisualStyleBackColor = true;
            BtnFinanzas.Click += BtnFinanzas_Click;
            // 
            // Home
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(431, 215);
            Controls.Add(BtnFinanzas);
            Controls.Add(BtnContabilidad);
            Controls.Add(BtnEstadisticas);
            Controls.Add(BtnOpenFolder);
            FormBorderStyle = FormBorderStyle.FixedSingle;
            MaximizeBox = false;
            Name = "Home";
            StartPosition = FormStartPosition.CenterScreen;
            ResumeLayout(false);
        }

        #endregion

        private Button BtnOpenFolder;
        private Button BtnEstadisticas;
        private OpenFileDialog OpenFile;
        private Button BtnContabilidad;
        private Button BtnFinanzas;
    }
}
