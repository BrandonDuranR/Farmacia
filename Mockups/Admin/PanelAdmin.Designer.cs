namespace Mockups
{
    partial class PanelAdmin
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
            panel1 = new Panel();
            btnLogOut = new Button();
            label2 = new Label();
            btnUsuario = new Button();
            label1 = new Label();
            label3 = new Label();
            button1 = new Button();
            label4 = new Label();
            button2 = new Button();
            label5 = new Label();
            button3 = new Button();
            panel1.SuspendLayout();
            SuspendLayout();
            // 
            // panel1
            // 
            panel1.BackColor = Color.DarkSlateGray;
            panel1.Controls.Add(btnLogOut);
            panel1.Controls.Add(label2);
            panel1.Dock = DockStyle.Top;
            panel1.ForeColor = Color.White;
            panel1.Location = new Point(0, 0);
            panel1.Name = "panel1";
            panel1.Size = new Size(642, 100);
            panel1.TabIndex = 1;
            // 
            // btnLogOut
            // 
            btnLogOut.BackColor = Color.Transparent;
            btnLogOut.BackgroundImage = Farmacia.Properties.Resources.log_out;
            btnLogOut.BackgroundImageLayout = ImageLayout.Stretch;
            btnLogOut.FlatStyle = FlatStyle.Popup;
            btnLogOut.Location = new Point(564, 16);
            btnLogOut.Margin = new Padding(4);
            btnLogOut.Name = "btnLogOut";
            btnLogOut.Size = new Size(65, 72);
            btnLogOut.TabIndex = 3;
            btnLogOut.UseVisualStyleBackColor = false;
            btnLogOut.Click += btnLogOut_Click;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Verdana", 15.75F, FontStyle.Regular, GraphicsUnit.Point);
            label2.Location = new Point(162, 37);
            label2.Name = "label2";
            label2.Size = new Size(277, 25);
            label2.TabIndex = 3;
            label2.Text = "PANEL  ADMINISTRADOR\r\n";
            label2.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // btnUsuario
            // 
            btnUsuario.BackgroundImage = Farmacia.Properties.Resources.nuevo;
            btnUsuario.BackgroundImageLayout = ImageLayout.Stretch;
            btnUsuario.FlatStyle = FlatStyle.Flat;
            btnUsuario.Location = new Point(175, 134);
            btnUsuario.Margin = new Padding(4);
            btnUsuario.Name = "btnUsuario";
            btnUsuario.Size = new Size(97, 99);
            btnUsuario.TabIndex = 0;
            btnUsuario.UseVisualStyleBackColor = false;
            btnUsuario.Click += btnUsuario_Click;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(161, 237);
            label1.Name = "label1";
            label1.Size = new Size(125, 18);
            label1.TabIndex = 2;
            label1.Text = "Registro Usuario";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(351, 237);
            label3.Name = "label3";
            label3.Size = new Size(131, 18);
            label3.TabIndex = 4;
            label3.Text = "Modificar Usuario";
            // 
            // button1
            // 
            button1.BackgroundImage = Farmacia.Properties.Resources.perfil_1_;
            button1.BackgroundImageLayout = ImageLayout.Stretch;
            button1.FlatStyle = FlatStyle.Flat;
            button1.Location = new Point(370, 134);
            button1.Margin = new Padding(4);
            button1.Name = "button1";
            button1.Size = new Size(97, 99);
            button1.TabIndex = 3;
            button1.UseVisualStyleBackColor = false;
            button1.Click += button1_Click;
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Location = new Point(344, 383);
            label4.Name = "label4";
            label4.Size = new Size(149, 18);
            label4.TabIndex = 6;
            label4.Text = "Registrar Proveedor";
            // 
            // button2
            // 
            button2.BackgroundImage = Farmacia.Properties.Resources.proveedor;
            button2.BackgroundImageLayout = ImageLayout.Stretch;
            button2.FlatStyle = FlatStyle.Flat;
            button2.Location = new Point(370, 280);
            button2.Margin = new Padding(4);
            button2.Name = "button2";
            button2.Size = new Size(97, 99);
            button2.TabIndex = 5;
            button2.UseVisualStyleBackColor = false;
            button2.Click += button2_Click;
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Location = new Point(161, 383);
            label5.Name = "label5";
            label5.Size = new Size(123, 18);
            label5.TabIndex = 8;
            label5.Text = "Eliminar Usuario";
            // 
            // button3
            // 
            button3.BackgroundImage = Farmacia.Properties.Resources.eliminar_usuario;
            button3.BackgroundImageLayout = ImageLayout.Stretch;
            button3.FlatStyle = FlatStyle.Flat;
            button3.Location = new Point(175, 280);
            button3.Margin = new Padding(4);
            button3.Name = "button3";
            button3.Size = new Size(97, 99);
            button3.TabIndex = 7;
            button3.UseVisualStyleBackColor = false;
            // 
            // PanelAdmin
            // 
            AutoScaleDimensions = new SizeF(9F, 18F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.FromArgb(220, 237, 244);
            ClientSize = new Size(642, 434);
            Controls.Add(label5);
            Controls.Add(button3);
            Controls.Add(label4);
            Controls.Add(button2);
            Controls.Add(label3);
            Controls.Add(button1);
            Controls.Add(label1);
            Controls.Add(panel1);
            Controls.Add(btnUsuario);
            Font = new Font("Arial", 12F, FontStyle.Regular, GraphicsUnit.Point);
            Margin = new Padding(4);
            MaximizeBox = false;
            Name = "PanelAdmin";
            ShowIcon = false;
            StartPosition = FormStartPosition.CenterScreen;
            Text = "Panel Administrador";
            Load += PanelAdmin_Load_1;
            panel1.ResumeLayout(false);
            panel1.PerformLayout();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion
        private Panel panel1;
        private Label label2;
        private Button btnLogOut;
        private Button btnUsuario;
        private Label label1;
        private Label label3;
        private Button button1;
        private Label label4;
        private Button button2;
        private Label label5;
        private Button button3;
    }
}