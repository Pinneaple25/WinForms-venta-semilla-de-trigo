namespace venta_semilla_de_trigo.Components.Ventas
{
    partial class SelectorData
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
            GbxGraficar = new GroupBox();
            RbGrupo = new RadioButton();
            RbOficio = new RadioButton();
            RbLote = new RadioButton();
            RbCiclo = new RadioButton();
            RbCategoria = new RadioButton();
            RbVariedad = new RadioButton();
            RbSolicitante = new RadioButton();
            GbxGraficar.SuspendLayout();
            SuspendLayout();
            // 
            // GbxGraficar
            // 
            GbxGraficar.Controls.Add(RbGrupo);
            GbxGraficar.Controls.Add(RbOficio);
            GbxGraficar.Controls.Add(RbLote);
            GbxGraficar.Controls.Add(RbCiclo);
            GbxGraficar.Controls.Add(RbCategoria);
            GbxGraficar.Controls.Add(RbVariedad);
            GbxGraficar.Controls.Add(RbSolicitante);
            GbxGraficar.Location = new Point(3, 3);
            GbxGraficar.Name = "GbxGraficar";
            GbxGraficar.Size = new Size(365, 155);
            GbxGraficar.TabIndex = 7;
            GbxGraficar.TabStop = false;
            GbxGraficar.Text = "Graficar por:";
            // 
            // RbGrupo
            // 
            RbGrupo.AutoSize = true;
            RbGrupo.Location = new Point(180, 56);
            RbGrupo.Name = "RbGrupo";
            RbGrupo.Size = new Size(78, 24);
            RbGrupo.TabIndex = 6;
            RbGrupo.TabStop = true;
            RbGrupo.Text = "GRUPO";
            RbGrupo.UseVisualStyleBackColor = true;
            // 
            // RbOficio
            // 
            RbOficio.AutoSize = true;
            RbOficio.Location = new Point(13, 116);
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
            RbCiclo.Location = new Point(180, 86);
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
            RbVariedad.Location = new Point(180, 26);
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
            RbSolicitante.Size = new Size(117, 24);
            RbSolicitante.TabIndex = 0;
            RbSolicitante.TabStop = true;
            RbSolicitante.Text = "SOLICITANTE";
            RbSolicitante.UseVisualStyleBackColor = true;
            // 
            // SelectorData
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            Controls.Add(GbxGraficar);
            Name = "SelectorData";
            Size = new Size(372, 164);
            GbxGraficar.ResumeLayout(false);
            GbxGraficar.PerformLayout();
            ResumeLayout(false);
        }

        #endregion

        private GroupBox GbxGraficar;
        private RadioButton RbGrupo;
        private RadioButton RbOficio;
        private RadioButton RbLote;
        private RadioButton RbCiclo;
        private RadioButton RbCategoria;
        private RadioButton RbVariedad;
        private RadioButton RbSolicitante;
    }
}
