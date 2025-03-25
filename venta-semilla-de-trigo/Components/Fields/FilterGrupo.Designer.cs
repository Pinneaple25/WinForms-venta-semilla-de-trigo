namespace venta_semilla_de_trigo.Components
{
    partial class FilterGrupo
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
            RbDuro = new RadioButton();
            RbHarinero = new RadioButton();
            RbTodos = new RadioButton();
            LbTitle = new Label();
            SuspendLayout();
            // 
            // RbDuro
            // 
            RbDuro.AutoSize = true;
            RbDuro.Location = new Point(17, 44);
            RbDuro.Name = "RbDuro";
            RbDuro.Size = new Size(63, 24);
            RbDuro.TabIndex = 0;
            RbDuro.TabStop = true;
            RbDuro.Text = "Duro";
            RbDuro.UseVisualStyleBackColor = true;
            // 
            // RbHarinero
            // 
            RbHarinero.AutoSize = true;
            RbHarinero.Location = new Point(101, 44);
            RbHarinero.Name = "RbHarinero";
            RbHarinero.Size = new Size(88, 24);
            RbHarinero.TabIndex = 1;
            RbHarinero.TabStop = true;
            RbHarinero.Text = "Harinero";
            RbHarinero.UseVisualStyleBackColor = true;
            // 
            // RbTodos
            // 
            RbTodos.AutoSize = true;
            RbTodos.Location = new Point(201, 44);
            RbTodos.Name = "RbTodos";
            RbTodos.Size = new Size(70, 24);
            RbTodos.TabIndex = 2;
            RbTodos.TabStop = true;
            RbTodos.Text = "S/N";
            RbTodos.UseVisualStyleBackColor = true;
            // 
            // LbTitle
            // 
            LbTitle.AutoSize = true;
            LbTitle.Location = new Point(17, 11);
            LbTitle.Name = "LbTitle";
            LbTitle.Size = new Size(57, 20);
            LbTitle.TabIndex = 3;
            LbTitle.Text = "GRUPO";
            // 
            // FilterGrupo
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            Controls.Add(LbTitle);
            Controls.Add(RbTodos);
            Controls.Add(RbHarinero);
            Controls.Add(RbDuro);
            Name = "FilterGrupo";
            Size = new Size(289, 86);
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private RadioButton RbDuro;
        private RadioButton RbHarinero;
        private RadioButton RbTodos;
        private Label LbTitle;
    }
}
