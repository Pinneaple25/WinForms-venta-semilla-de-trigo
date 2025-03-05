namespace venta_semilla_de_trigo.Components
{
    partial class FilterCategoria
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
            LbTitle = new Label();
            RbBasica = new RadioButton();
            RbRegistrada = new RadioButton();
            RbTodos = new RadioButton();
            SuspendLayout();
            // 
            // LbItems
            // 
            LbTitle.AutoSize = true;
            LbTitle.Location = new Point(22, 13);
            LbTitle.Name = "LbItems";
            LbTitle.Size = new Size(0, 20);
            LbTitle.TabIndex = 1;
            // 
            // RbBasica
            // 
            RbBasica.AutoSize = true;
            RbBasica.Location = new Point(22, 46);
            RbBasica.Name = "RbBasica";
            RbBasica.Size = new Size(72, 24);
            RbBasica.TabIndex = 2;
            RbBasica.Text = "Básica";
            RbBasica.UseVisualStyleBackColor = true;
            // 
            // RbRegistrada
            // 
            RbRegistrada.AutoSize = true;
            RbRegistrada.Location = new Point(114, 46);
            RbRegistrada.Name = "RbRegistrada";
            RbRegistrada.Size = new Size(101, 24);
            RbRegistrada.TabIndex = 3;
            RbRegistrada.Text = "Registrada";
            RbRegistrada.UseVisualStyleBackColor = true;
            // 
            // RbTodos
            // 
            RbTodos.AutoSize = true;
            RbTodos.Checked = true;
            RbTodos.Location = new Point(231, 46);
            RbTodos.Name = "RbTodos";
            RbTodos.Size = new Size(70, 24);
            RbTodos.TabIndex = 4;
            RbTodos.TabStop = true;
            RbTodos.Text = "Todos";
            RbTodos.UseVisualStyleBackColor = true;
            // 
            // FilterCategoria
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            Controls.Add(RbTodos);
            Controls.Add(RbRegistrada);
            Controls.Add(RbBasica);
            Controls.Add(LbTitle);
            Name = "FilterCategoria";
            Size = new Size(394, 94);
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label LbTitle;
        private RadioButton RbBasica;
        private RadioButton RbRegistrada;
        private RadioButton RbTodos;
    }
}
