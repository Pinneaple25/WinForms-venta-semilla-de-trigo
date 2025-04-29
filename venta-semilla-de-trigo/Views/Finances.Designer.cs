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
            BtnAgregar = new Button();
            CbGlobal = new CheckBox();
            BtnLimpiar = new Button();
            GbMuestreo.SuspendLayout();
            PFiltro.SuspendLayout();
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
            GbMuestreo.Location = new Point(12, 146);
            GbMuestreo.Name = "GbMuestreo";
            GbMuestreo.Size = new Size(688, 79);
            GbMuestreo.TabIndex = 0;
            GbMuestreo.TabStop = false;
            GbMuestreo.Text = "Intervalo de muestreo";
            // 
            // RbMensual
            // 
            RbMensual.AutoSize = true;
            RbMensual.Location = new Point(586, 42);
            RbMensual.Name = "RbMensual";
            RbMensual.Size = new Size(85, 24);
            RbMensual.TabIndex = 6;
            RbMensual.Text = "Mensual";
            RbMensual.UseVisualStyleBackColor = true;
            // 
            // RbBimestral
            // 
            RbBimestral.AutoSize = true;
            RbBimestral.Location = new Point(488, 42);
            RbBimestral.Name = "RbBimestral";
            RbBimestral.Size = new Size(92, 24);
            RbBimestral.TabIndex = 5;
            RbBimestral.Text = "Bimestral";
            RbBimestral.UseVisualStyleBackColor = true;
            // 
            // RbTrimestral
            // 
            RbTrimestral.AutoSize = true;
            RbTrimestral.Location = new Point(387, 42);
            RbTrimestral.Name = "RbTrimestral";
            RbTrimestral.Size = new Size(95, 24);
            RbTrimestral.TabIndex = 4;
            RbTrimestral.Text = "Trimestral";
            RbTrimestral.UseVisualStyleBackColor = true;
            // 
            // RbCuatrimestral
            // 
            RbCuatrimestral.AutoSize = true;
            RbCuatrimestral.Location = new Point(263, 42);
            RbCuatrimestral.Name = "RbCuatrimestral";
            RbCuatrimestral.Size = new Size(118, 24);
            RbCuatrimestral.TabIndex = 3;
            RbCuatrimestral.Text = "Cuatrimestral";
            RbCuatrimestral.UseVisualStyleBackColor = true;
            // 
            // RbSemestral
            // 
            RbSemestral.AutoSize = true;
            RbSemestral.Location = new Point(162, 42);
            RbSemestral.Name = "RbSemestral";
            RbSemestral.Size = new Size(95, 24);
            RbSemestral.TabIndex = 2;
            RbSemestral.Text = "Semestral";
            RbSemestral.UseVisualStyleBackColor = true;
            // 
            // RbAnual
            // 
            RbAnual.AutoSize = true;
            RbAnual.Location = new Point(88, 42);
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
            BtnGraficar.Location = new Point(772, 196);
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
            PFiltro.Controls.Add(BtnLimpiar);
            PFiltro.Controls.Add(BtnAgregar);
            PFiltro.Location = new Point(545, 12);
            PFiltro.Name = "PFiltro";
            PFiltro.Size = new Size(321, 129);
            PFiltro.TabIndex = 3;
            PFiltro.Visible = false;
            // 
            // BtnAgregar
            // 
            BtnAgregar.Location = new Point(124, 97);
            BtnAgregar.Name = "BtnAgregar";
            BtnAgregar.Size = new Size(94, 29);
            BtnAgregar.TabIndex = 0;
            BtnAgregar.Text = "Agregar";
            BtnAgregar.UseVisualStyleBackColor = true;
            BtnAgregar.Click += BtnAgregar_Click;
            // 
            // CbGlobal
            // 
            CbGlobal.AutoSize = true;
            CbGlobal.Location = new Point(318, 12);
            CbGlobal.Name = "CbGlobal";
            CbGlobal.Size = new Size(75, 24);
            CbGlobal.TabIndex = 4;
            CbGlobal.Text = "Global";
            CbGlobal.UseVisualStyleBackColor = true;
            CbGlobal.CheckedChanged += CbGlobal_CheckedChanged;
            // 
            // BtnLimpiar
            // 
            BtnLimpiar.Location = new Point(224, 97);
            BtnLimpiar.Name = "BtnLimpiar";
            BtnLimpiar.Size = new Size(94, 29);
            BtnLimpiar.TabIndex = 1;
            BtnLimpiar.Text = "Limpiar";
            BtnLimpiar.UseVisualStyleBackColor = true;
            BtnLimpiar.Click += BtnLimpiar_Click;
            // 
            // Finances
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(886, 237);
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
            PFiltro.ResumeLayout(false);
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
        private Button BtnAgregar;
        private Button BtnLimpiar;
    }
}