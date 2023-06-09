﻿namespace Mockups
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Login));
            tbUser = new TextBox();
            tbPass = new TextBox();
            label2 = new Label();
            label3 = new Label();
            btnLogin = new Button();
            panel1 = new Panel();
            label1 = new Label();
            panel1.SuspendLayout();
            SuspendLayout();
            // 
            // tbUser
            // 
            tbUser.Location = new Point(334, 110);
            tbUser.Margin = new Padding(4);
            tbUser.Name = "tbUser";
            tbUser.Size = new Size(199, 26);
            tbUser.TabIndex = 0;
            tbUser.TextAlign = HorizontalAlignment.Center;
            // 
            // tbPass
            // 
            tbPass.Location = new Point(334, 180);
            tbPass.Margin = new Padding(4);
            tbPass.Name = "tbPass";
            tbPass.PasswordChar = '*';
            tbPass.Size = new Size(199, 26);
            tbPass.TabIndex = 1;
            tbPass.TextAlign = HorizontalAlignment.Center;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.BackColor = Color.Transparent;
            label2.Font = new Font("Verdana", 12F, FontStyle.Regular, GraphicsUnit.Point);
            label2.Location = new Point(395, 88);
            label2.Margin = new Padding(4, 0, 4, 0);
            label2.Name = "label2";
            label2.Size = new Size(77, 18);
            label2.TabIndex = 3;
            label2.Text = "Usuario:";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.BackColor = Color.Transparent;
            label3.Font = new Font("Verdana", 12F, FontStyle.Regular, GraphicsUnit.Point);
            label3.Location = new Point(379, 158);
            label3.Margin = new Padding(4, 0, 4, 0);
            label3.Name = "label3";
            label3.Size = new Size(108, 18);
            label3.TabIndex = 4;
            label3.Text = "Contraseña:";
            // 
            // btnLogin
            // 
            btnLogin.BackColor = Color.FromArgb(220, 237, 244);
            btnLogin.FlatStyle = FlatStyle.Popup;
            btnLogin.Font = new Font("Verdana", 12F, FontStyle.Regular, GraphicsUnit.Point);
            btnLogin.Location = new Point(369, 242);
            btnLogin.Margin = new Padding(4);
            btnLogin.Name = "btnLogin";
            btnLogin.Size = new Size(129, 40);
            btnLogin.TabIndex = 5;
            btnLogin.Text = "Ingresar";
            btnLogin.UseVisualStyleBackColor = false;
            btnLogin.Click += btnLogin_Click;
            // 
            // panel1
            // 
            panel1.BackColor = Color.DarkSlateGray;
            panel1.Controls.Add(label1);
            panel1.Dock = DockStyle.Top;
            panel1.Location = new Point(0, 0);
            panel1.Name = "panel1";
            panel1.Size = new Size(565, 60);
            panel1.TabIndex = 6;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.BackColor = Color.Transparent;
            label1.Font = new Font("Verdana", 12F, FontStyle.Bold, GraphicsUnit.Point);
            label1.ForeColor = Color.White;
            label1.Location = new Point(210, 21);
            label1.Margin = new Padding(4, 0, 4, 0);
            label1.Name = "label1";
            label1.Size = new Size(152, 18);
            label1.TabIndex = 7;
            label1.Text = "Iniciar de Sesión";
            // 
            // Login
            // 
            AutoScaleDimensions = new SizeF(9F, 18F);
            AutoScaleMode = AutoScaleMode.Font;
            BackgroundImage = (Image)resources.GetObject("$this.BackgroundImage");
            BackgroundImageLayout = ImageLayout.Stretch;
            ClientSize = new Size(565, 295);
            Controls.Add(panel1);
            Controls.Add(btnLogin);
            Controls.Add(label3);
            Controls.Add(label2);
            Controls.Add(tbPass);
            Controls.Add(tbUser);
            Font = new Font("Arial", 12F, FontStyle.Regular, GraphicsUnit.Point);
            Margin = new Padding(4);
            MaximizeBox = false;
            Name = "Login";
            ShowIcon = false;
            StartPosition = FormStartPosition.CenterScreen;
            Text = "Inicio Sesión";
            Load += Login_Load;
            panel1.ResumeLayout(false);
            panel1.PerformLayout();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private TextBox tbUser;
        private TextBox tbPass;
        private Label label2;
        private Label label3;
        private Button btnLogin;
        private Panel panel1;
        private Label label1;
    }
}