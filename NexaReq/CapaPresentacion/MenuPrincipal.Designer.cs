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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(MenuPrincipal));
            panelMenu = new Panel();
            BuSalirMenu = new Button();
            panelSmRequisiciones = new Panel();
            BuReportesPendientes = new Button();
            BuRevisiones = new Button();
            BuRequisiciones = new Button();
            panelSmSolicitudes = new Panel();
            BuReporteSolicitud = new Button();
            BuSolicitud = new Button();
            BuSolicitudes = new Button();
            panelLogo = new Panel();
            label3 = new Label();
            panelContainer = new Panel();
            pictureBox1 = new PictureBox();
            panelMenu.SuspendLayout();
            panelSmRequisiciones.SuspendLayout();
            panelSmSolicitudes.SuspendLayout();
            panelLogo.SuspendLayout();
            panelContainer.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).BeginInit();
            SuspendLayout();
            // 
            // panelMenu
            // 
            panelMenu.AutoScroll = true;
            panelMenu.BackColor = Color.FromArgb(16, 40, 99);
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
            BuSalirMenu.BackColor = Color.FromArgb(44, 206, 117);
            BuSalirMenu.Cursor = Cursors.Hand;
            BuSalirMenu.Dock = DockStyle.Bottom;
            BuSalirMenu.FlatStyle = FlatStyle.Flat;
            BuSalirMenu.Font = new Font("Segoe UI", 11F, FontStyle.Bold);
            BuSalirMenu.ForeColor = Color.FromArgb(15, 47, 99);
            BuSalirMenu.Location = new Point(0, 621);
            BuSalirMenu.Name = "BuSalirMenu";
            BuSalirMenu.Size = new Size(194, 40);
            BuSalirMenu.TabIndex = 5;
            BuSalirMenu.Text = "Cerrar Seción";
            BuSalirMenu.UseVisualStyleBackColor = false;
            BuSalirMenu.Click += BuSalirMenu_Click;
            // 
            // panelSmRequisiciones
            // 
            panelSmRequisiciones.Controls.Add(BuReportesPendientes);
            panelSmRequisiciones.Controls.Add(BuRevisiones);
            panelSmRequisiciones.Dock = DockStyle.Top;
            panelSmRequisiciones.Location = new Point(0, 261);
            panelSmRequisiciones.Name = "panelSmRequisiciones";
            panelSmRequisiciones.Size = new Size(194, 100);
            panelSmRequisiciones.TabIndex = 4;
            // 
            // BuReportesPendientes
            // 
            BuReportesPendientes.BackColor = Color.FromArgb(65, 237, 142);
            BuReportesPendientes.Cursor = Cursors.Hand;
            BuReportesPendientes.Dock = DockStyle.Top;
            BuReportesPendientes.FlatStyle = FlatStyle.Flat;
            BuReportesPendientes.Font = new Font("Segoe UI", 11F, FontStyle.Bold);
            BuReportesPendientes.ForeColor = Color.FromArgb(15, 47, 99);
            BuReportesPendientes.Location = new Point(0, 40);
            BuReportesPendientes.Name = "BuReportesPendientes";
            BuReportesPendientes.Padding = new Padding(27, 0, 0, 0);
            BuReportesPendientes.Size = new Size(194, 40);
            BuReportesPendientes.TabIndex = 1;
            BuReportesPendientes.Text = "Reportes";
            BuReportesPendientes.TextAlign = ContentAlignment.MiddleLeft;
            BuReportesPendientes.UseVisualStyleBackColor = false;
            BuReportesPendientes.Click += BuReportesPendientes_Click;
            // 
            // BuRevisiones
            // 
            BuRevisiones.BackColor = Color.FromArgb(65, 237, 142);
            BuRevisiones.Cursor = Cursors.Hand;
            BuRevisiones.Dock = DockStyle.Top;
            BuRevisiones.FlatStyle = FlatStyle.Flat;
            BuRevisiones.Font = new Font("Segoe UI", 11F, FontStyle.Bold);
            BuRevisiones.ForeColor = Color.FromArgb(15, 47, 99);
            BuRevisiones.Location = new Point(0, 0);
            BuRevisiones.Name = "BuRevisiones";
            BuRevisiones.Padding = new Padding(27, 0, 0, 0);
            BuRevisiones.Size = new Size(194, 40);
            BuRevisiones.TabIndex = 0;
            BuRevisiones.Text = "Revisiones";
            BuRevisiones.TextAlign = ContentAlignment.MiddleLeft;
            BuRevisiones.UseVisualStyleBackColor = false;
            BuRevisiones.Click += BuRevisiones_Click;
            // 
            // BuRequisiciones
            // 
            BuRequisiciones.BackColor = Color.FromArgb(44, 206, 117);
            BuRequisiciones.Cursor = Cursors.Hand;
            BuRequisiciones.Dock = DockStyle.Top;
            BuRequisiciones.FlatStyle = FlatStyle.Flat;
            BuRequisiciones.Font = new Font("Segoe UI", 11F, FontStyle.Bold);
            BuRequisiciones.ForeColor = Color.FromArgb(15, 47, 99);
            BuRequisiciones.Location = new Point(0, 221);
            BuRequisiciones.Name = "BuRequisiciones";
            BuRequisiciones.Size = new Size(194, 40);
            BuRequisiciones.TabIndex = 3;
            BuRequisiciones.Text = "Requisiciones";
            BuRequisiciones.UseVisualStyleBackColor = false;
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
            BuReporteSolicitud.BackColor = Color.FromArgb(65, 237, 142);
            BuReporteSolicitud.Cursor = Cursors.Hand;
            BuReporteSolicitud.Dock = DockStyle.Top;
            BuReporteSolicitud.FlatStyle = FlatStyle.Flat;
            BuReporteSolicitud.Font = new Font("Segoe UI", 11F, FontStyle.Bold);
            BuReporteSolicitud.ForeColor = Color.FromArgb(15, 47, 99);
            BuReporteSolicitud.Location = new Point(0, 40);
            BuReporteSolicitud.Name = "BuReporteSolicitud";
            BuReporteSolicitud.Padding = new Padding(27, 0, 0, 0);
            BuReporteSolicitud.Size = new Size(194, 40);
            BuReporteSolicitud.TabIndex = 1;
            BuReporteSolicitud.Text = "Reportes";
            BuReporteSolicitud.TextAlign = ContentAlignment.MiddleLeft;
            BuReporteSolicitud.UseVisualStyleBackColor = false;
            BuReporteSolicitud.Click += BuReporteSolicitud_Click;
            // 
            // BuSolicitud
            // 
            BuSolicitud.BackColor = Color.FromArgb(65, 237, 142);
            BuSolicitud.Cursor = Cursors.Hand;
            BuSolicitud.Dock = DockStyle.Top;
            BuSolicitud.FlatStyle = FlatStyle.Flat;
            BuSolicitud.Font = new Font("Segoe UI", 11F, FontStyle.Bold);
            BuSolicitud.ForeColor = Color.FromArgb(15, 47, 99);
            BuSolicitud.Location = new Point(0, 0);
            BuSolicitud.Name = "BuSolicitud";
            BuSolicitud.Padding = new Padding(27, 0, 0, 0);
            BuSolicitud.Size = new Size(194, 40);
            BuSolicitud.TabIndex = 0;
            BuSolicitud.Text = "Solicitar";
            BuSolicitud.TextAlign = ContentAlignment.MiddleLeft;
            BuSolicitud.UseVisualStyleBackColor = false;
            BuSolicitud.Click += BuSolicitud_Click;
            // 
            // BuSolicitudes
            // 
            BuSolicitudes.BackColor = Color.FromArgb(44, 206, 117);
            BuSolicitudes.Cursor = Cursors.Hand;
            BuSolicitudes.Dock = DockStyle.Top;
            BuSolicitudes.FlatStyle = FlatStyle.Flat;
            BuSolicitudes.Font = new Font("Segoe UI", 11F, FontStyle.Bold);
            BuSolicitudes.ForeColor = Color.FromArgb(15, 47, 99);
            BuSolicitudes.Location = new Point(0, 81);
            BuSolicitudes.Name = "BuSolicitudes";
            BuSolicitudes.Size = new Size(194, 40);
            BuSolicitudes.TabIndex = 1;
            BuSolicitudes.Text = "Solicitudes";
            BuSolicitudes.UseVisualStyleBackColor = false;
            BuSolicitudes.Click += BuSolicitudes_Click;
            // 
            // panelLogo
            // 
            panelLogo.Controls.Add(label3);
            panelLogo.Dock = DockStyle.Top;
            panelLogo.Location = new Point(0, 0);
            panelLogo.Name = "panelLogo";
            panelLogo.Size = new Size(194, 81);
            panelLogo.TabIndex = 0;
            // 
            // label3
            // 
            label3.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
            label3.AutoSize = true;
            label3.Font = new Font("Impact", 25.25F, FontStyle.Italic);
            label3.ForeColor = Color.White;
            label3.Location = new Point(28, 19);
            label3.Name = "label3";
            label3.Size = new Size(137, 42);
            label3.TabIndex = 7;
            label3.Text = "NexaReq";
            // 
            // panelContainer
            // 
            panelContainer.AutoScroll = true;
            panelContainer.BackColor = Color.White;
            panelContainer.Controls.Add(pictureBox1);
            panelContainer.Dock = DockStyle.Fill;
            panelContainer.Location = new Point(194, 0);
            panelContainer.Name = "panelContainer";
            panelContainer.Size = new Size(890, 661);
            panelContainer.TabIndex = 1;
            // 
            // pictureBox1
            // 
            pictureBox1.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
            pictureBox1.Image = Properties.Resources.LogoTipo;
            pictureBox1.Location = new Point(262, 165);
            pictureBox1.Name = "pictureBox1";
            pictureBox1.Size = new Size(366, 331);
            pictureBox1.SizeMode = PictureBoxSizeMode.Zoom;
            pictureBox1.TabIndex = 8;
            pictureBox1.TabStop = false;
            // 
            // MenuPrincipal
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(1084, 661);
            Controls.Add(panelContainer);
            Controls.Add(panelMenu);
            Icon = (Icon)resources.GetObject("$this.Icon");
            Name = "MenuPrincipal";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "NexaReq - Menu";
            panelMenu.ResumeLayout(false);
            panelSmRequisiciones.ResumeLayout(false);
            panelSmSolicitudes.ResumeLayout(false);
            panelLogo.ResumeLayout(false);
            panelLogo.PerformLayout();
            panelContainer.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)pictureBox1).EndInit();
            ResumeLayout(false);
        }

        #endregion

        private Panel panelMenu;
        private Button BuSolicitudes;
        private Panel panelLogo;
        private Panel panelContainer;
        private Panel panelSmRequisiciones;
        private Button BuReportesPendientes;
        private Button BuRevisiones;
        private Button BuRequisiciones;
        private Panel panelSmSolicitudes;
        private Button BuReporteSolicitud;
        private Button BuSolicitud;
        private Button BuSalirMenu;
        private Label label3;
        private PictureBox pictureBox1;
    }
}