namespace CapaPresentacion.Plantillas
{
    partial class UIregistro
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
            panelHeader = new Panel();
            panelContext = new Panel();
            pictureBox1 = new PictureBox();
            label1 = new Label();
            panelHeader.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).BeginInit();
            SuspendLayout();
            // 
            // panelHeader
            // 
            panelHeader.BackColor = SystemColors.AppWorkspace;
            panelHeader.Controls.Add(label1);
            panelHeader.Controls.Add(pictureBox1);
            panelHeader.Dock = DockStyle.Top;
            panelHeader.Location = new Point(0, 0);
            panelHeader.Name = "panelHeader";
            panelHeader.Size = new Size(890, 65);
            panelHeader.TabIndex = 0;
            // 
            // panelContext
            // 
            panelContext.Dock = DockStyle.Fill;
            panelContext.Location = new Point(0, 65);
            panelContext.Name = "panelContext";
            panelContext.Size = new Size(890, 596);
            panelContext.TabIndex = 1;
            // 
            // pictureBox1
            // 
            pictureBox1.Location = new Point(41, 8);
            pictureBox1.Name = "pictureBox1";
            pictureBox1.Size = new Size(66, 50);
            pictureBox1.TabIndex = 0;
            pictureBox1.TabStop = false;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Segoe UI", 17F);
            label1.Location = new Point(113, 23);
            label1.Name = "label1";
            label1.Size = new Size(68, 31);
            label1.TabIndex = 1;
            label1.Text = "Texto";
            // 
            // UIregistro
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(890, 661);
            Controls.Add(panelContext);
            Controls.Add(panelHeader);
            FormBorderStyle = FormBorderStyle.None;
            MaximumSize = new Size(890, 661);
            MinimumSize = new Size(890, 661);
            Name = "UIregistro";
            Text = "UIregistro";
            panelHeader.ResumeLayout(false);
            panelHeader.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).EndInit();
            ResumeLayout(false);
        }

        #endregion

        public Panel panelHeader;
        public Panel panelContext;
        public Label label1;
        public PictureBox pictureBox1;
    }
}