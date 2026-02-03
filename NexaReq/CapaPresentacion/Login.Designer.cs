namespace CapaPresentacion
{
    partial class Login
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
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
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            components = new System.ComponentModel.Container();
            panelFondo = new Panel();
            label3 = new Label();
            textbPassword = new TextBox();
            label2 = new Label();
            checkViewPass = new CheckBox();
            BuIngresar = new Button();
            textbUsername = new TextBox();
            label1 = new Label();
            errorProviderLogin = new ErrorProvider(components);
            panelFondo.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)errorProviderLogin).BeginInit();
            SuspendLayout();
            // 
            // panelFondo
            // 
            panelFondo.Controls.Add(label3);
            panelFondo.Controls.Add(textbPassword);
            panelFondo.Controls.Add(label2);
            panelFondo.Controls.Add(checkViewPass);
            panelFondo.Controls.Add(BuIngresar);
            panelFondo.Controls.Add(textbUsername);
            panelFondo.Controls.Add(label1);
            panelFondo.Dock = DockStyle.Fill;
            panelFondo.Location = new Point(0, 0);
            panelFondo.Name = "panelFondo";
            panelFondo.Size = new Size(800, 450);
            panelFondo.TabIndex = 0;
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Font = new Font("Impact", 25.25F, FontStyle.Italic);
            label3.Location = new Point(332, 30);
            label3.Name = "label3";
            label3.Size = new Size(137, 42);
            label3.TabIndex = 6;
            label3.Text = "NexaReq";
            // 
            // textbPassword
            // 
            textbPassword.BorderStyle = BorderStyle.FixedSingle;
            textbPassword.Font = new Font("Segoe UI", 11F);
            textbPassword.Location = new Point(301, 198);
            textbPassword.Name = "textbPassword";
            textbPassword.Size = new Size(202, 27);
            textbPassword.TabIndex = 5;
            textbPassword.Validating += textbPassword_Validating;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Segoe UI Semibold", 11F, FontStyle.Bold);
            label2.Location = new Point(301, 175);
            label2.Name = "label2";
            label2.Size = new Size(73, 20);
            label2.TabIndex = 4;
            label2.Text = "Password";
            // 
            // checkViewPass
            // 
            checkViewPass.AutoSize = true;
            checkViewPass.Font = new Font("Segoe UI", 11F);
            checkViewPass.Location = new Point(301, 231);
            checkViewPass.Name = "checkViewPass";
            checkViewPass.Size = new Size(125, 24);
            checkViewPass.TabIndex = 3;
            checkViewPass.Text = "Ver contraseña";
            checkViewPass.UseVisualStyleBackColor = true;
            checkViewPass.CheckedChanged += checkViewPass_CheckedChanged;
            // 
            // BuIngresar
            // 
            BuIngresar.Cursor = Cursors.Hand;
            BuIngresar.FlatStyle = FlatStyle.Flat;
            BuIngresar.Font = new Font("Segoe UI Semibold", 12.75F, FontStyle.Bold, GraphicsUnit.Point, 0);
            BuIngresar.Location = new Point(301, 261);
            BuIngresar.Name = "BuIngresar";
            BuIngresar.Size = new Size(202, 39);
            BuIngresar.TabIndex = 2;
            BuIngresar.Text = "Ingresar";
            BuIngresar.UseVisualStyleBackColor = true;
            BuIngresar.Click += BuIngresar_Click;
            // 
            // textbUsername
            // 
            textbUsername.BorderStyle = BorderStyle.FixedSingle;
            textbUsername.Font = new Font("Segoe UI", 11F);
            textbUsername.Location = new Point(301, 139);
            textbUsername.Name = "textbUsername";
            textbUsername.Size = new Size(202, 27);
            textbUsername.TabIndex = 1;
            textbUsername.Validating += textbUsername_Validating;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Segoe UI Semibold", 11F, FontStyle.Bold);
            label1.Location = new Point(298, 116);
            label1.Name = "label1";
            label1.Size = new Size(78, 20);
            label1.TabIndex = 0;
            label1.Text = "Username";
            // 
            // errorProviderLogin
            // 
            errorProviderLogin.ContainerControl = this;
            // 
            // Login
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 450);
            Controls.Add(panelFondo);
            Name = "Login";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "NexaReq";
            panelFondo.ResumeLayout(false);
            panelFondo.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)errorProviderLogin).EndInit();
            ResumeLayout(false);
        }

        #endregion

        private Panel panelFondo;
        private CheckBox checkViewPass;
        private Button BuIngresar;
        private TextBox textbUsername;
        private Label label1;
        private TextBox textbPassword;
        private Label label2;
        private Label label3;
        private ErrorProvider errorProviderLogin;
    }
}
