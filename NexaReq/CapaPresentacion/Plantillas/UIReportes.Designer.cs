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
            panelContext = new Panel();
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
            panelContext.Controls.Add(dataView);
            panelContext.Dock = DockStyle.Fill;
            panelContext.Location = new Point(0, 87);
            panelContext.Margin = new Padding(3, 4, 3, 4);
            panelContext.Name = "panelContext";
            panelContext.Size = new Size(999, 747);
            panelContext.TabIndex = 3;
            // 
            // dataView
            // 
            dataView.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
            dataView.AutoSizeRowsMode = DataGridViewAutoSizeRowsMode.AllCells;
            dataView.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataView.Location = new Point(47, 111);
            dataView.Name = "dataView";
            dataView.RowHeadersWidth = 51;
            dataView.Size = new Size(906, 559);
            dataView.TabIndex = 0;
            // 
            // panelHeader
            // 
            panelHeader.BackColor = SystemColors.AppWorkspace;
            panelHeader.Controls.Add(label1);
            panelHeader.Controls.Add(pictureBox1);
            panelHeader.Dock = DockStyle.Top;
            panelHeader.Location = new Point(0, 0);
            panelHeader.Margin = new Padding(3, 4, 3, 4);
            panelHeader.Name = "panelHeader";
            panelHeader.Size = new Size(999, 87);
            panelHeader.TabIndex = 2;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Segoe UI", 17F);
            label1.Location = new Point(129, 31);
            label1.Name = "label1";
            label1.Size = new Size(84, 40);
            label1.TabIndex = 1;
            label1.Text = "Texto";
            // 
            // pictureBox1
            // 
            pictureBox1.Location = new Point(47, 11);
            pictureBox1.Margin = new Padding(3, 4, 3, 4);
            pictureBox1.Name = "pictureBox1";
            pictureBox1.Size = new Size(75, 67);
            pictureBox1.TabIndex = 0;
            pictureBox1.TabStop = false;
            // 
            // UIReportes
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(999, 834);
            Controls.Add(panelContext);
            Controls.Add(panelHeader);
            FormBorderStyle = FormBorderStyle.None;
            Name = "UIReportes";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "UIReportes";
            panelContext.ResumeLayout(false);
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
    }
}