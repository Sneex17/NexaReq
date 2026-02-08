namespace CapaPresentacion.Reportes
{
    partial class ReporteEmpleados
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(ReporteEmpleados));
            panelHeader.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).BeginInit();
            SuspendLayout();
            // 
            // panelContext
            // 
            panelContext.Margin = new Padding(3, 2, 3, 2);
            panelContext.Size = new Size(890, 596);
            // 
            // panelHeader
            // 
            panelHeader.Margin = new Padding(3, 2, 3, 2);
            panelHeader.Size = new Size(890, 65);
            // 
            // label1
            // 
            label1.Size = new Size(127, 31);
            label1.Text = "Empleados";
            // 
            // ReporteEmpleados
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(890, 661);
            Icon = (Icon)resources.GetObject("$this.Icon");
            MaximumSize = new Size(890, 661);
            MinimumSize = new Size(890, 661);
            Name = "ReporteEmpleados";
            Text = "NexaReq - Empleados";
            panelHeader.ResumeLayout(false);
            panelHeader.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).EndInit();
            ResumeLayout(false);
        }

        #endregion
    }
}