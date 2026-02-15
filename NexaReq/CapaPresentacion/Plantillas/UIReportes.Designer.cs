namespace CapaPresentacion.Plantillas
{
    partial class UIReportes
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
            DataGridViewCellStyle dataGridViewCellStyle1 = new DataGridViewCellStyle();
            panelContext = new Panel();
            cbxCamposDeBuscar = new ComboBox();
            label2 = new Label();
            textbFiltro = new TextBox();
            BuGeneralReportes = new Button();
            BuCerrarVentana = new Button();
            dataView = new DataGridView();
            panelHeader = new Panel();
            label1 = new Label();
            pictureBox1 = new PictureBox();
            panelContext.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)dataView).BeginInit();
            panelHeader.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).BeginInit();
            SuspendLayout();
            // 
            // panelContext
            // 
            panelContext.BackColor = Color.White;
            panelContext.Controls.Add(cbxCamposDeBuscar);
            panelContext.Controls.Add(label2);
            panelContext.Controls.Add(textbFiltro);
            panelContext.Controls.Add(BuGeneralReportes);
            panelContext.Controls.Add(BuCerrarVentana);
            panelContext.Controls.Add(dataView);
            panelContext.Dock = DockStyle.Fill;
            panelContext.Location = new Point(0, 65);
            panelContext.Name = "panelContext";
            panelContext.Size = new Size(874, 561);
            panelContext.TabIndex = 3;
            // 
            // cbxCamposDeBuscar
            // 
            cbxCamposDeBuscar.Font = new Font("Segoe UI", 10F);
            cbxCamposDeBuscar.FormattingEnabled = true;
            cbxCamposDeBuscar.Location = new Point(532, 40);
            cbxCamposDeBuscar.Name = "cbxCamposDeBuscar";
            cbxCamposDeBuscar.Size = new Size(165, 25);
            cbxCamposDeBuscar.TabIndex = 11;
            cbxCamposDeBuscar.Text = "Seleccione un campo";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Segoe UI", 17.25F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label2.ForeColor = Color.FromArgb(16, 40, 99);
            label2.Location = new Point(41, 33);
            label2.Name = "label2";
            label2.Size = new Size(91, 31);
            label2.TabIndex = 2;
            label2.Text = "Buscar ";
            // 
            // textbFiltro
            // 
            textbFiltro.BorderStyle = BorderStyle.FixedSingle;
            textbFiltro.Location = new Point(138, 41);
            textbFiltro.Name = "textbFiltro";
            textbFiltro.Size = new Size(388, 23);
            textbFiltro.TabIndex = 10;
            // 
            // BuGeneralReportes
            // 
            BuGeneralReportes.BackColor = Color.FromArgb(16, 40, 99);
            BuGeneralReportes.Cursor = Cursors.Hand;
            BuGeneralReportes.FlatStyle = FlatStyle.Popup;
            BuGeneralReportes.Font = new Font("Segoe UI Semibold", 11.25F, FontStyle.Bold);
            BuGeneralReportes.ForeColor = Color.White;
            BuGeneralReportes.Location = new Point(680, 512);
            BuGeneralReportes.Name = "BuGeneralReportes";
            BuGeneralReportes.Size = new Size(154, 47);
            BuGeneralReportes.TabIndex = 9;
            BuGeneralReportes.Text = "General reporte";
            BuGeneralReportes.UseVisualStyleBackColor = false;
            // 
            // BuCerrarVentana
            // 
            BuCerrarVentana.BackColor = Color.FromArgb(16, 40, 99);
            BuCerrarVentana.Cursor = Cursors.Hand;
            BuCerrarVentana.FlatStyle = FlatStyle.Popup;
            BuCerrarVentana.Font = new Font("Segoe UI Semibold", 11.25F, FontStyle.Bold);
            BuCerrarVentana.ForeColor = Color.White;
            BuCerrarVentana.Location = new Point(41, 512);
            BuCerrarVentana.Name = "BuCerrarVentana";
            BuCerrarVentana.Size = new Size(128, 47);
            BuCerrarVentana.TabIndex = 8;
            BuCerrarVentana.Text = "Cerrar ventana";
            BuCerrarVentana.UseVisualStyleBackColor = false;
            // 
            // dataView
            // 
            dataView.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
            dataView.AutoSizeRowsMode = DataGridViewAutoSizeRowsMode.AllCells;
            dataView.BackgroundColor = Color.Gainsboro;
            dataGridViewCellStyle1.Alignment = DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle1.BackColor = Color.LightSteelBlue;
            dataGridViewCellStyle1.Font = new Font("Montserrat SemiBold", 8F, FontStyle.Bold);
            dataGridViewCellStyle1.ForeColor = SystemColors.WindowText;
            dataGridViewCellStyle1.SelectionBackColor = SystemColors.Highlight;
            dataGridViewCellStyle1.SelectionForeColor = SystemColors.HighlightText;
            dataGridViewCellStyle1.WrapMode = DataGridViewTriState.True;
            dataView.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle1;
            dataView.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataView.Location = new Point(41, 83);
            dataView.Margin = new Padding(3, 2, 3, 2);
            dataView.Name = "dataView";
            dataView.RowHeadersWidth = 51;
            dataView.Size = new Size(793, 419);
            dataView.TabIndex = 0;
            // 
            // panelHeader
            // 
            panelHeader.BackColor = Color.FromArgb(44, 206, 117);
            panelHeader.Controls.Add(label1);
            panelHeader.Controls.Add(pictureBox1);
            panelHeader.Dock = DockStyle.Top;
            panelHeader.Location = new Point(0, 0);
            panelHeader.Name = "panelHeader";
            panelHeader.Size = new Size(874, 65);
            panelHeader.TabIndex = 2;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Segoe UI", 17.25F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label1.ForeColor = Color.FromArgb(16, 40, 99);
            label1.Location = new Point(113, 23);
            label1.Name = "label1";
            label1.Size = new Size(73, 31);
            label1.TabIndex = 1;
            label1.Text = "Texto";
            // 
            // pictureBox1
            // 
            pictureBox1.Location = new Point(72, 23);
            pictureBox1.Name = "pictureBox1";
            pictureBox1.Size = new Size(35, 35);
            pictureBox1.TabIndex = 0;
            pictureBox1.TabStop = false;
            // 
            // UIReportes
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(874, 626);
            Controls.Add(panelContext);
            Controls.Add(panelHeader);
            FormBorderStyle = FormBorderStyle.None;
            Margin = new Padding(3, 2, 3, 2);
            Name = "UIReportes";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "UIReportes";
            panelContext.ResumeLayout(false);
            panelContext.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)dataView).EndInit();
            panelHeader.ResumeLayout(false);
            panelHeader.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).EndInit();
            ResumeLayout(false);
        }

        #endregion

        public Panel panelContext;
        public Panel panelHeader;
        public Label label1;
        public PictureBox pictureBox1;
        public DataGridView dataView;
        public Button BuCerrarVentana;
        public Button BuGeneralReportes;
        public Label label2;
        public ComboBox cbxCamposDeBuscar;
        public TextBox textbFiltro;
    }
}