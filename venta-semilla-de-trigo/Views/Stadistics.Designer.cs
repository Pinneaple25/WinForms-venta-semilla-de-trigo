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
            GbxFiltro = new GroupBox();
            CbOficio = new CheckBox();
            CbFecha = new CheckBox();
            CbLote = new CheckBox();
            CbCiclo = new CheckBox();
            CbCosto = new CheckBox();
            CbKgSalida = new CheckBox();
            CbCategoria = new CheckBox();
            CbVariedad = new CheckBox();
            CbSolicitud = new CheckBox();
            GbxGraficar = new GroupBox();
            RbFecha = new RadioButton();
            RbLote = new RadioButton();
            RbCiclo = new RadioButton();
            RbCategoria = new RadioButton();
            RbVariedad = new RadioButton();
            RbSolicitante = new RadioButton();
            PFilter1 = new Panel();
            PFilter2 = new Panel();
            PFilter3 = new Panel();
            GbxFiltro.SuspendLayout();
            GbxGraficar.SuspendLayout();
            SuspendLayout();
            // 
            // GbxFiltro
            // 
            GbxFiltro.Controls.Add(CbOficio);
            GbxFiltro.Controls.Add(CbFecha);
            GbxFiltro.Controls.Add(CbLote);
            GbxFiltro.Controls.Add(CbCiclo);
            GbxFiltro.Controls.Add(CbCosto);
            GbxFiltro.Controls.Add(CbKgSalida);
            GbxFiltro.Controls.Add(CbCategoria);
            GbxFiltro.Controls.Add(CbVariedad);
            GbxFiltro.Controls.Add(CbSolicitud);
            GbxFiltro.Location = new Point(48, 23);
            GbxFiltro.Name = "GbxFiltro";
            GbxFiltro.Size = new Size(365, 180);
            GbxFiltro.TabIndex = 0;
            GbxFiltro.TabStop = false;
            GbxFiltro.Text = "Filtrar por:";
            // 
            // CbOficio
            // 
            CbOficio.AutoSize = true;
            CbOficio.Location = new Point(213, 146);
            CbOficio.Name = "CbOficio";
            CbOficio.Size = new Size(138, 24);
            CbOficio.TabIndex = 9;
            CbOficio.Text = "OFICIO Reporte ";
            CbOficio.UseVisualStyleBackColor = true;
            CbOficio.CheckedChanged += CbOficio_CheckedChanged;
            // 
            // CbFecha
            // 
            CbFecha.AutoSize = true;
            CbFecha.Location = new Point(12, 146);
            CbFecha.Name = "CbFecha";
            CbFecha.Size = new Size(76, 24);
            CbFecha.TabIndex = 8;
            CbFecha.Text = "FECHA";
            CbFecha.UseVisualStyleBackColor = true;
            CbFecha.CheckedChanged += CbFecha_CheckedChanged;
            // 
            // CbLote
            // 
            CbLote.AutoSize = true;
            CbLote.Location = new Point(213, 116);
            CbLote.Name = "CbLote";
            CbLote.Size = new Size(63, 24);
            CbLote.TabIndex = 7;
            CbLote.Text = "LOTE";
            CbLote.UseVisualStyleBackColor = true;
            CbLote.CheckedChanged += CbLote_CheckedChanged;
            // 
            // CbCiclo
            // 
            CbCiclo.AutoSize = true;
            CbCiclo.Location = new Point(12, 116);
            CbCiclo.Name = "CbCiclo";
            CbCiclo.Size = new Size(167, 24);
            CbCiclo.TabIndex = 6;
            CbCiclo.Text = "CICLO PRODUCCIÓN";
            CbCiclo.UseVisualStyleBackColor = true;
            CbCiclo.CheckedChanged += CbCiclo_CheckedChanged;
            // 
            // CbCosto
            // 
            CbCosto.AutoSize = true;
            CbCosto.Location = new Point(213, 86);
            CbCosto.Name = "CbCosto";
            CbCosto.Size = new Size(77, 24);
            CbCosto.TabIndex = 5;
            CbCosto.Text = "COSTO";
            CbCosto.UseVisualStyleBackColor = true;
            CbCosto.CheckedChanged += CbCosto_CheckedChanged;
            // 
            // CbKgSalida
            // 
            CbKgSalida.AutoSize = true;
            CbKgSalida.Location = new Point(12, 86);
            CbKgSalida.Name = "CbKgSalida";
            CbKgSalida.Size = new Size(97, 24);
            CbKgSalida.TabIndex = 4;
            CbKgSalida.Text = "KG. Salida";
            CbKgSalida.UseVisualStyleBackColor = true;
            CbKgSalida.CheckedChanged += CbKgSalida_CheckedChanged;
            // 
            // CbCategoria
            // 
            CbCategoria.AutoSize = true;
            CbCategoria.Location = new Point(213, 56);
            CbCategoria.Name = "CbCategoria";
            CbCategoria.Size = new Size(109, 24);
            CbCategoria.TabIndex = 3;
            CbCategoria.Text = "CATEGORIA";
            CbCategoria.UseVisualStyleBackColor = true;
            CbCategoria.CheckedChanged += CbCategoria_CheckedChanged;
            // 
            // CbVariedad
            // 
            CbVariedad.AutoSize = true;
            CbVariedad.Location = new Point(12, 56);
            CbVariedad.Name = "CbVariedad";
            CbVariedad.Size = new Size(102, 24);
            CbVariedad.TabIndex = 2;
            CbVariedad.Text = "VARIEDAD";
            CbVariedad.UseVisualStyleBackColor = true;
            CbVariedad.CheckedChanged += CbVariedad_CheckedChanged;
            // 
            // CbSolicitud
            // 
            CbSolicitud.AutoSize = true;
            CbSolicitud.Location = new Point(12, 26);
            CbSolicitud.Name = "CbSolicitud";
            CbSolicitud.Size = new Size(223, 24);
            CbSolicitud.TabIndex = 1;
            CbSolicitud.Text = "SOLICITANTE - COMPRADOR";
            CbSolicitud.UseVisualStyleBackColor = true;
            CbSolicitud.CheckedChanged += CbSolicitud_CheckedChanged;
            // 
            // GbxGraficar
            // 
            GbxGraficar.Controls.Add(RbFecha);
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
            // RbFecha
            // 
            RbFecha.AutoSize = true;
            RbFecha.Location = new Point(180, 86);
            RbFecha.Name = "RbFecha";
            RbFecha.Size = new Size(133, 24);
            RbFecha.TabIndex = 5;
            RbFecha.TabStop = true;
            RbFecha.Text = "OFICIO Reporte";
            RbFecha.UseVisualStyleBackColor = true;
            // 
            // RbLote
            // 
            RbLote.AutoSize = true;
            RbLote.Location = new Point(13, 86);
            RbLote.Name = "RbLote";
            RbLote.Size = new Size(62, 24);
            RbLote.TabIndex = 4;
            RbLote.TabStop = true;
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
            RbCiclo.TabStop = true;
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
            RbCategoria.TabStop = true;
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
            RbVariedad.TabStop = true;
            RbVariedad.Text = "VARIEDAD";
            RbVariedad.UseVisualStyleBackColor = true;
            // 
            // RbSolicitante
            // 
            RbSolicitante.AutoSize = true;
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
            // Stadistics
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(884, 423);
            Controls.Add(PFilter3);
            Controls.Add(PFilter2);
            Controls.Add(PFilter1);
            Controls.Add(GbxGraficar);
            Controls.Add(GbxFiltro);
            FormBorderStyle = FormBorderStyle.FixedSingle;
            MaximizeBox = false;
            MinimumSize = new Size(902, 451);
            Name = "Stadistics";
            StartPosition = FormStartPosition.CenterScreen;
            GbxFiltro.ResumeLayout(false);
            GbxFiltro.PerformLayout();
            GbxGraficar.ResumeLayout(false);
            GbxGraficar.PerformLayout();
            ResumeLayout(false);
        }

        #endregion

        private GroupBox GbxFiltro;
        private CheckBox CbKgSalida;
        private CheckBox CbCategoria;
        private CheckBox CbVariedad;
        private CheckBox CbSolicitud;
        private CheckBox CbCosto;
        private CheckBox CbOficio;
        private CheckBox CbFecha;
        private CheckBox CbLote;
        private CheckBox CbCiclo;
        private GroupBox GbxGraficar;
        private RadioButton RbFecha;
        private RadioButton RbLote;
        private RadioButton RbCiclo;
        private RadioButton RbCategoria;
        private RadioButton RbVariedad;
        private RadioButton RbSolicitante;
        private Panel PFilter1;
        private Panel PFilter2;
        private Panel PFilter3;
    }
}