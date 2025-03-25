namespace venta_semilla_de_trigo.Components
{
    partial class FilterData
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
            GbxFiltro = new GroupBox();
            CbGrupo = new CheckBox();
            CbOficio = new CheckBox();
            CbFecha = new CheckBox();
            CbLote = new CheckBox();
            CbCiclo = new CheckBox();
            CbCosto = new CheckBox();
            CbKgSalida = new CheckBox();
            CbCategoria = new CheckBox();
            CbVariedad = new CheckBox();
            CbSolicitud = new CheckBox();
            GbxFiltro.SuspendLayout();
            SuspendLayout();
            // 
            // GbxFiltro
            // 
            GbxFiltro.Controls.Add(CbGrupo);
            GbxFiltro.Controls.Add(CbOficio);
            GbxFiltro.Controls.Add(CbFecha);
            GbxFiltro.Controls.Add(CbLote);
            GbxFiltro.Controls.Add(CbCiclo);
            GbxFiltro.Controls.Add(CbCosto);
            GbxFiltro.Controls.Add(CbKgSalida);
            GbxFiltro.Controls.Add(CbCategoria);
            GbxFiltro.Controls.Add(CbVariedad);
            GbxFiltro.Controls.Add(CbSolicitud);
            GbxFiltro.Location = new Point(3, 3);
            GbxFiltro.Name = "GbxFiltro";
            GbxFiltro.Size = new Size(365, 180);
            GbxFiltro.TabIndex = 2;
            GbxFiltro.TabStop = false;
            GbxFiltro.Text = "Filtrar por:";
            // 
            // CbGrupo
            // 
            CbGrupo.AutoSize = true;
            CbGrupo.Location = new Point(211, 56);
            CbGrupo.Name = "CbGrupo";
            CbGrupo.Size = new Size(79, 24);
            CbGrupo.TabIndex = 10;
            CbGrupo.Text = "GRUPO";
            CbGrupo.UseVisualStyleBackColor = true;
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
            // 
            // CbCategoria
            // 
            CbCategoria.AutoSize = true;
            CbCategoria.Location = new Point(211, 26);
            CbCategoria.Name = "CbCategoria";
            CbCategoria.Size = new Size(109, 24);
            CbCategoria.TabIndex = 3;
            CbCategoria.Text = "CATEGORIA";
            CbCategoria.UseVisualStyleBackColor = true;
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
            // 
            // CbSolicitud
            // 
            CbSolicitud.AutoSize = true;
            CbSolicitud.Location = new Point(12, 26);
            CbSolicitud.Name = "CbSolicitud";
            CbSolicitud.Size = new Size(118, 24);
            CbSolicitud.TabIndex = 1;
            CbSolicitud.Text = "SOLICITANTE";
            CbSolicitud.UseVisualStyleBackColor = true;
            // 
            // FilterData
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            Controls.Add(GbxFiltro);
            Name = "FilterData";
            Size = new Size(371, 186);
            GbxFiltro.ResumeLayout(false);
            GbxFiltro.PerformLayout();
            ResumeLayout(false);
        }

        #endregion

        private GroupBox GbxFiltro;
        private CheckBox CbOficio;
        private CheckBox CbFecha;
        private CheckBox CbLote;
        private CheckBox CbCiclo;
        private CheckBox CbCosto;
        private CheckBox CbKgSalida;
        private CheckBox CbCategoria;
        private CheckBox CbVariedad;
        private CheckBox CbSolicitud;
        private CheckBox CbGrupo;
    }
}
