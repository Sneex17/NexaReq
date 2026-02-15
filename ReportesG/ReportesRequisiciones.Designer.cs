namespace ReportesG
{
    partial class ReportesRequisiciones
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

        #region Código generado por el Diseñador de Windows Forms

        /// <summary>
        /// Método necesario para admitir el Diseñador. No se puede modificar
        /// el contenido de este método con el editor de código.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(ReportesRequisiciones));
            this.directoryEntry1 = new System.DirectoryServices.DirectoryEntry();
            this.panelText = new System.Windows.Forms.Panel();
            this.panelReport = new System.Windows.Forms.Panel();
            this.reportViewer = new Microsoft.Reporting.WinForms.ReportViewer();
            this.panelReport.SuspendLayout();
            this.SuspendLayout();
            // 
            // panelText
            // 
            this.panelText.Dock = System.Windows.Forms.DockStyle.Top;
            this.panelText.Location = new System.Drawing.Point(0, 0);
            this.panelText.Name = "panelText";
            this.panelText.Size = new System.Drawing.Size(882, 94);
            this.panelText.TabIndex = 0;
            // 
            // panelReport
            // 
            this.panelReport.Controls.Add(this.reportViewer);
            this.panelReport.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panelReport.Location = new System.Drawing.Point(0, 94);
            this.panelReport.Name = "panelReport";
            this.panelReport.Size = new System.Drawing.Size(882, 559);
            this.panelReport.TabIndex = 1;
            // 
            // reportViewer
            // 
            this.reportViewer.Dock = System.Windows.Forms.DockStyle.Fill;
            this.reportViewer.Location = new System.Drawing.Point(0, 0);
            this.reportViewer.Name = "reportViewer";
            this.reportViewer.ServerReport.BearerToken = null;
            this.reportViewer.Size = new System.Drawing.Size(882, 559);
            this.reportViewer.TabIndex = 0;
            // 
            // ReportesRequisiciones
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(882, 653);
            this.Controls.Add(this.panelReport);
            this.Controls.Add(this.panelText);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "ReportesRequisiciones";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "NexaReq - Reportes";
            this.Load += new System.EventHandler(this.ReportesRequisiciones_Load);
            this.panelReport.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.DirectoryServices.DirectoryEntry directoryEntry1;
        private System.Windows.Forms.Panel panelText;
        private System.Windows.Forms.Panel panelReport;
        private Microsoft.Reporting.WinForms.ReportViewer reportViewer;
    }
}

