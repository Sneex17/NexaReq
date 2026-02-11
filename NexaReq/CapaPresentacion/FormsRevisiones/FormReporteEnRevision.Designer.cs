namespace CapaPresentacion.FormsRevisiones
{
    partial class FormReporteEnRevision
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
            panelContext.SuspendLayout();
            panelHeader.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).BeginInit();
            SuspendLayout();
            // 
            // panelContext
            // 
            panelContext.Size = new Size(890, 596);
            // 
            // panelHeader
            // 
            panelHeader.Size = new Size(890, 65);
            // 
            // label1
            // 
            label1.Size = new Size(284, 31);
            label1.Text = "Requisiciones pendientes";
            // 
            // BuCerrarVentana
            // 
            BuCerrarVentana.Click += BuCerrarVentana_Click;
            // 
            // BuGeneralReportes
            // 
            BuGeneralReportes.Click += BuGeneralReportes_Click;
            // 
            // cbxCamposDeBuscar
            // 
            cbxCamposDeBuscar.Size = new Size(165, 25);
            // 
            // FormReporteEnRevision
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(890, 661);
            MaximumSize = new Size(890, 661);
            MinimumSize = new Size(890, 661);
            Name = "FormReporteEnRevision";
            Text = "FormReporteEnRevision";
            panelContext.ResumeLayout(false);
            panelContext.PerformLayout();
            panelHeader.ResumeLayout(false);
            panelHeader.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).EndInit();
            ResumeLayout(false);
        }

        #endregion
    }
}