namespace CapaPresentacion
{
    partial class MenuPrincipal
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
            panelMenu = new Panel();
            BuSalirMenu = new Button();
            panelSmRequisiciones = new Panel();
            button5 = new Button();
            button6 = new Button();
            BuRequisiciones = new Button();
            panelSmSolicitudes = new Panel();
            BuReporteSolicitud = new Button();
            BuSolicitud = new Button();
            BuSolicitudes = new Button();
            panelLogo = new Panel();
            panelContainer = new Panel();
            panelMenu.SuspendLayout();
            panelSmRequisiciones.SuspendLayout();
            panelSmSolicitudes.SuspendLayout();
            SuspendLayout();
            // 
            // panelMenu
            // 
            panelMenu.AutoScroll = true;
            panelMenu.Controls.Add(BuSalirMenu);
            panelMenu.Controls.Add(panelSmRequisiciones);
            panelMenu.Controls.Add(BuRequisiciones);
            panelMenu.Controls.Add(panelSmSolicitudes);
            panelMenu.Controls.Add(BuSolicitudes);
            panelMenu.Controls.Add(panelLogo);
            panelMenu.Dock = DockStyle.Left;
            panelMenu.Location = new Point(0, 0);
            panelMenu.Name = "panelMenu";
            panelMenu.Size = new Size(194, 661);
            panelMenu.TabIndex = 0;
            // 
            // BuSalirMenu
            // 
            BuSalirMenu.Dock = DockStyle.Bottom;
            BuSalirMenu.Location = new Point(0, 621);
            BuSalirMenu.Name = "BuSalirMenu";
            BuSalirMenu.Size = new Size(194, 40);
            BuSalirMenu.TabIndex = 5;
            BuSalirMenu.Text = "Cerrar Seción";
            BuSalirMenu.UseVisualStyleBackColor = true;
            BuSalirMenu.Click += BuSalirMenu_Click;
            // 
            // panelSmRequisiciones
            // 
            panelSmRequisiciones.Controls.Add(button5);
            panelSmRequisiciones.Controls.Add(button6);
            panelSmRequisiciones.Dock = DockStyle.Top;
            panelSmRequisiciones.Location = new Point(0, 261);
            panelSmRequisiciones.Name = "panelSmRequisiciones";
            panelSmRequisiciones.Size = new Size(194, 100);
            panelSmRequisiciones.TabIndex = 4;
            // 
            // button5
            // 
            button5.Dock = DockStyle.Top;
            button5.Location = new Point(0, 40);
            button5.Name = "button5";
            button5.Padding = new Padding(27, 0, 0, 0);
            button5.Size = new Size(194, 40);
            button5.TabIndex = 1;
            button5.Text = "Reportes";
            button5.TextAlign = ContentAlignment.MiddleLeft;
            button5.UseVisualStyleBackColor = true;
            // 
            // button6
            // 
            button6.Dock = DockStyle.Top;
            button6.Location = new Point(0, 0);
            button6.Name = "button6";
            button6.Padding = new Padding(27, 0, 0, 0);
            button6.Size = new Size(194, 40);
            button6.TabIndex = 0;
            button6.Text = "Revisiones";
            button6.TextAlign = ContentAlignment.MiddleLeft;
            button6.UseVisualStyleBackColor = true;
            // 
            // BuRequisiciones
            // 
            BuRequisiciones.Dock = DockStyle.Top;
            BuRequisiciones.Location = new Point(0, 221);
            BuRequisiciones.Name = "BuRequisiciones";
            BuRequisiciones.Size = new Size(194, 40);
            BuRequisiciones.TabIndex = 3;
            BuRequisiciones.Text = "Requisiciones";
            BuRequisiciones.UseVisualStyleBackColor = true;
            BuRequisiciones.Click += BuRequisiciones_Click;
            // 
            // panelSmSolicitudes
            // 
            panelSmSolicitudes.Controls.Add(BuReporteSolicitud);
            panelSmSolicitudes.Controls.Add(BuSolicitud);
            panelSmSolicitudes.Dock = DockStyle.Top;
            panelSmSolicitudes.Location = new Point(0, 121);
            panelSmSolicitudes.Name = "panelSmSolicitudes";
            panelSmSolicitudes.Size = new Size(194, 100);
            panelSmSolicitudes.TabIndex = 2;
            // 
            // BuReporteSolicitud
            // 
            BuReporteSolicitud.Dock = DockStyle.Top;
            BuReporteSolicitud.Location = new Point(0, 40);
            BuReporteSolicitud.Name = "BuReporteSolicitud";
            BuReporteSolicitud.Padding = new Padding(27, 0, 0, 0);
            BuReporteSolicitud.Size = new Size(194, 40);
            BuReporteSolicitud.TabIndex = 1;
            BuReporteSolicitud.Text = "Reportes";
            BuReporteSolicitud.TextAlign = ContentAlignment.MiddleLeft;
            BuReporteSolicitud.UseVisualStyleBackColor = true;
            // 
            // BuSolicitud
            // 
            BuSolicitud.Dock = DockStyle.Top;
            BuSolicitud.Location = new Point(0, 0);
            BuSolicitud.Name = "BuSolicitud";
            BuSolicitud.Padding = new Padding(27, 0, 0, 0);
            BuSolicitud.Size = new Size(194, 40);
            BuSolicitud.TabIndex = 0;
            BuSolicitud.Text = "Solicitar";
            BuSolicitud.TextAlign = ContentAlignment.MiddleLeft;
            BuSolicitud.UseVisualStyleBackColor = true;
            BuSolicitud.Click += BuSolicitud_Click;
            // 
            // BuSolicitudes
            // 
            BuSolicitudes.Dock = DockStyle.Top;
            BuSolicitudes.Location = new Point(0, 81);
            BuSolicitudes.Name = "BuSolicitudes";
            BuSolicitudes.Size = new Size(194, 40);
            BuSolicitudes.TabIndex = 1;
            BuSolicitudes.Text = "Solicitudes";
            BuSolicitudes.UseVisualStyleBackColor = true;
            BuSolicitudes.Click += BuSolicitudes_Click;
            // 
            // panelLogo
            // 
            panelLogo.Dock = DockStyle.Top;
            panelLogo.Location = new Point(0, 0);
            panelLogo.Name = "panelLogo";
            panelLogo.Size = new Size(194, 81);
            panelLogo.TabIndex = 0;
            // 
            // panelContainer
            // 
            panelContainer.AutoScroll = true;
            panelContainer.Dock = DockStyle.Fill;
            panelContainer.Location = new Point(194, 0);
            panelContainer.Name = "panelContainer";
            panelContainer.Size = new Size(890, 661);
            panelContainer.TabIndex = 1;
            // 
            // MenuPrincipal
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(1084, 661);
            Controls.Add(panelContainer);
            Controls.Add(panelMenu);
            Name = "MenuPrincipal";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "NexaReq - Menu";
            panelMenu.ResumeLayout(false);
            panelSmRequisiciones.ResumeLayout(false);
            panelSmSolicitudes.ResumeLayout(false);
            ResumeLayout(false);
        }

        #endregion

        private Panel panelMenu;
        private Button BuSolicitudes;
        private Panel panelLogo;
        private Panel panelContainer;
        private Panel panelSmRequisiciones;
        private Button button5;
        private Button button6;
        private Button BuRequisiciones;
        private Panel panelSmSolicitudes;
        private Button BuReporteSolicitud;
        private Button BuSolicitud;
        private Button BuSalirMenu;
    }
}