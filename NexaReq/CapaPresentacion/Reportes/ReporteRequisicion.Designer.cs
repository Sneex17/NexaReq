namespace CapaPresentacion.Reportes
{
    partial class ReporteRequisicion
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
            panelHeader.SuspendLayout();
            panelContext.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).BeginInit();
            SuspendLayout();
            // 
            // label1
            // 
            label1.Size = new Size(288, 31);
            label1.Text = "Reportes de requisiciones";
            // 
            // BuCerrarVentana
            // 
            BuCerrarVentana.Click += BuCerrarVentana_Click;
            // 
            // ReporteRequisicion
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(890, 661);
            Name = "ReporteRequisicion";
            Text = "ReporteRequisicion";
            panelHeader.ResumeLayout(false);
            panelHeader.PerformLayout();
            panelContext.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)pictureBox1).EndInit();
            ResumeLayout(false);
        }

        #endregion
    }
}