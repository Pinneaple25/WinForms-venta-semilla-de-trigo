namespace venta_semilla_de_trigo
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
            // 
            // OpenFile
            // 
            OpenFile.Filter = "Archivos de Excel|*.xlsx";
            // 
            // Home
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(282, 215);
            Controls.Add(BtnEstadisticas);
            Controls.Add(BtnOpenFolder);
            Name = "Home";
            ResumeLayout(false);
        }

        #endregion

        private Button BtnOpenFolder;
        private Button BtnEstadisticas;
        private OpenFileDialog OpenFile;
    }
}
