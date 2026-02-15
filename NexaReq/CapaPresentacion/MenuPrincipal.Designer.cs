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
            panelLogo = new Panel();
            label3 = new Label();
            BuSolicitudes = new Button();
            panelSmSolicitudes = new Panel();
            BuReporteSolicitud = new Button();
            BuSolicitud = new Button();
            BuRequisiciones = new Button();
            panelSmRequisiciones = new Panel();
            BuReportesPendientes = new Button();
            BuRevisiones = new Button();
            BuSalirMenu = new Button();
            panelMenu = new Panel();
            pictureBox1 = new PictureBox();
            panelContainer = new Panel();
            groupBox1 = new GroupBox();
            pictureBox2 = new PictureBox();
            LbUsuario = new Label();
            label1 = new Label();
            panelLogo.SuspendLayout();
            panelSmSolicitudes.SuspendLayout();
            panelSmRequisiciones.SuspendLayout();
            panelMenu.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).BeginInit();
            panelContainer.SuspendLayout();
            groupBox1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBox2).BeginInit();
            SuspendLayout();
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
            // BuSolicitudes
            // 
            BuSolicitudes.BackColor = Color.FromArgb(44, 206, 117);
            BuSolicitudes.Cursor = Cursors.Hand;
            BuSolicitudes.Dock = DockStyle.Top;
            BuSolicitudes.FlatStyle = FlatStyle.Flat;
            BuSolicitudes.Font = new Font("Segoe UI", 11F, FontStyle.Bold);
            BuSolicitudes.ForeColor = Color.FromArgb(15, 47, 99);
            BuSolicitudes.Image = Properties.Resources.Document;
            BuSolicitudes.ImageAlign = ContentAlignment.MiddleLeft;
            BuSolicitudes.Location = new Point(0, 81);
            BuSolicitudes.Name = "BuSolicitudes";
            BuSolicitudes.Size = new Size(194, 40);
            BuSolicitudes.TabIndex = 1;
            BuSolicitudes.Text = "Solicitudes";
            BuSolicitudes.UseVisualStyleBackColor = false;
            BuSolicitudes.Click += BuSolicitudes_Click;
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
            // BuRequisiciones
            // 
            BuRequisiciones.BackColor = Color.FromArgb(44, 206, 117);
            BuRequisiciones.Cursor = Cursors.Hand;
            BuRequisiciones.Dock = DockStyle.Top;
            BuRequisiciones.FlatStyle = FlatStyle.Flat;
            BuRequisiciones.Font = new Font("Segoe UI", 11F, FontStyle.Bold);
            BuRequisiciones.ForeColor = Color.FromArgb(15, 47, 99);
            BuRequisiciones.Image = Properties.Resources.To_Do_List;
            BuRequisiciones.ImageAlign = ContentAlignment.MiddleLeft;
            BuRequisiciones.Location = new Point(0, 221);
            BuRequisiciones.Name = "BuRequisiciones";
            BuRequisiciones.Size = new Size(194, 40);
            BuRequisiciones.TabIndex = 3;
            BuRequisiciones.Text = "Requisiciones";
            BuRequisiciones.UseVisualStyleBackColor = false;
            BuRequisiciones.Click += BuRequisiciones_Click;
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
            // BuSalirMenu
            // 
            BuSalirMenu.BackColor = Color.FromArgb(44, 206, 117);
            BuSalirMenu.Cursor = Cursors.Hand;
            BuSalirMenu.Dock = DockStyle.Bottom;
            BuSalirMenu.FlatStyle = FlatStyle.Flat;
            BuSalirMenu.Font = new Font("Segoe UI", 11F, FontStyle.Bold);
            BuSalirMenu.ForeColor = Color.FromArgb(15, 47, 99);
            BuSalirMenu.Image = Properties.Resources.Logout_Rounded_Left;
            BuSalirMenu.ImageAlign = ContentAlignment.MiddleLeft;
            BuSalirMenu.Location = new Point(0, 621);
            BuSalirMenu.Name = "BuSalirMenu";
            BuSalirMenu.Size = new Size(194, 40);
            BuSalirMenu.TabIndex = 5;
            BuSalirMenu.Text = "Cerrar Seción";
            BuSalirMenu.UseVisualStyleBackColor = false;
            BuSalirMenu.Click += BuSalirMenu_Click;
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
            // panelContainer
            // 
            panelContainer.AutoScroll = true;
            panelContainer.BackColor = Color.White;
            panelContainer.Controls.Add(groupBox1);
            panelContainer.Controls.Add(pictureBox1);
            panelContainer.Dock = DockStyle.Fill;
            panelContainer.Location = new Point(194, 0);
            panelContainer.Name = "panelContainer";
            panelContainer.Size = new Size(890, 661);
            panelContainer.TabIndex = 1;
            // 
            // groupBox1
            // 
            groupBox1.Anchor = AnchorStyles.Top | AnchorStyles.Right;
            groupBox1.BackColor = Color.Gainsboro;
            groupBox1.Controls.Add(pictureBox2);
            groupBox1.Controls.Add(LbUsuario);
            groupBox1.Controls.Add(label1);
            groupBox1.Font = new Font("Montserrat", 10.2F, FontStyle.Bold, GraphicsUnit.Point, 0);
            groupBox1.Location = new Point(599, 19);
            groupBox1.Margin = new Padding(3, 2, 3, 2);
            groupBox1.Name = "groupBox1";
            groupBox1.Padding = new Padding(3, 2, 3, 2);
            groupBox1.Size = new Size(272, 67);
            groupBox1.TabIndex = 9;
            groupBox1.TabStop = false;
            groupBox1.Text = "Información";
            // 
            // pictureBox2
            // 
            pictureBox2.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
            pictureBox2.Image = Properties.Resources.IconoUsuario;
            pictureBox2.Location = new Point(217, 10);
            pictureBox2.Name = "pictureBox2";
            pictureBox2.Size = new Size(50, 46);
            pictureBox2.SizeMode = PictureBoxSizeMode.Zoom;
            pictureBox2.TabIndex = 10;
            pictureBox2.TabStop = false;
            // 
            // LbUsuario
            // 
            LbUsuario.AutoSize = true;
            LbUsuario.Location = new Point(81, 28);
            LbUsuario.Name = "LbUsuario";
            LbUsuario.Size = new Size(40, 20);
            LbUsuario.TabIndex = 1;
            LbUsuario.Text = "Text";
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(5, 28);
            label1.Name = "label1";
            label1.Size = new Size(69, 20);
            label1.TabIndex = 0;
            label1.Text = "Usuario:";
            // 
            // MenuPrincipal
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(1084, 661);
            Controls.Add(panelContainer);
            Controls.Add(panelMenu);
            Icon = (Icon)resources.GetObject("$this.Icon");
            MaximumSize = new Size(1100, 700);
            Name = "MenuPrincipal";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "NexaReq - Menu";
            panelLogo.ResumeLayout(false);
            panelLogo.PerformLayout();
            panelSmSolicitudes.ResumeLayout(false);
            panelSmRequisiciones.ResumeLayout(false);
            panelMenu.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)pictureBox1).EndInit();
            panelContainer.ResumeLayout(false);
            groupBox1.ResumeLayout(false);
            groupBox1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBox2).EndInit();
            ResumeLayout(false);
        }

        #endregion

        private Panel panelLogo;
        private Label label3;
        private Button BuSolicitudes;
        private Panel panelSmSolicitudes;
        private Button BuReporteSolicitud;
        private Button BuSolicitud;
        private Button BuRequisiciones;
        private Panel panelSmRequisiciones;
        private Button BuReportesPendientes;
        private Button BuRevisiones;
        private Button BuSalirMenu;
        private Panel panelMenu;
        private PictureBox pictureBox1;
        private Panel panelContainer;
        private GroupBox groupBox1;
        private PictureBox pictureBox2;
        private Label LbUsuario;
        private Label label1;
    }
}