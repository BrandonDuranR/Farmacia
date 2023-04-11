namespace Farmacia
{
    partial class panelAmlacen
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
            button1 = new Button();
            label1 = new Label();
            label2 = new Label();
            button2 = new Button();
            panel1 = new Panel();
            btnLogOut = new Button();
            label14 = new Label();
            label3 = new Label();
            button3 = new Button();
            panel1.SuspendLayout();
            SuspendLayout();
            // 
            // button1
            // 
            button1.BackgroundImage = Properties.Resources.registrarLote;
            button1.BackgroundImageLayout = ImageLayout.Stretch;
            button1.FlatStyle = FlatStyle.Flat;
            button1.Location = new Point(80, 150);
            button1.Margin = new Padding(4);
            button1.Name = "button1";
            button1.Size = new Size(107, 100);
            button1.TabIndex = 4;
            button1.UseVisualStyleBackColor = true;
            button1.Click += button1_Click;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(80, 254);
            label1.Margin = new Padding(4, 0, 4, 0);
            label1.Name = "label1";
            label1.Size = new Size(107, 18);
            label1.TabIndex = 5;
            label1.Text = "Registrar Lote";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(262, 254);
            label2.Margin = new Padding(4, 0, 4, 0);
            label2.Name = "label2";
            label2.Size = new Size(139, 18);
            label2.TabIndex = 7;
            label2.Text = "Registrar Producto";
            // 
            // button2
            // 
            button2.BackgroundImage = Properties.Resources.registrarMed;
            button2.BackgroundImageLayout = ImageLayout.Stretch;
            button2.FlatStyle = FlatStyle.Flat;
            button2.Location = new Point(279, 150);
            button2.Margin = new Padding(4);
            button2.Name = "button2";
            button2.Size = new Size(107, 100);
            button2.TabIndex = 6;
            button2.UseVisualStyleBackColor = true;
            button2.Click += button2_Click;
            // 
            // panel1
            // 
            panel1.BackColor = Color.DarkSlateGray;
            panel1.Controls.Add(btnLogOut);
            panel1.Controls.Add(label14);
            panel1.Dock = DockStyle.Top;
            panel1.Location = new Point(0, 0);
            panel1.Name = "panel1";
            panel1.Size = new Size(674, 89);
            panel1.TabIndex = 59;
            // 
            // btnLogOut
            // 
            btnLogOut.BackColor = Color.Transparent;
            btnLogOut.BackgroundImage = Properties.Resources.log_out;
            btnLogOut.BackgroundImageLayout = ImageLayout.Stretch;
            btnLogOut.FlatStyle = FlatStyle.Popup;
            btnLogOut.Location = new Point(605, 10);
            btnLogOut.Margin = new Padding(4);
            btnLogOut.Name = "btnLogOut";
            btnLogOut.Size = new Size(65, 72);
            btnLogOut.TabIndex = 62;
            btnLogOut.UseVisualStyleBackColor = false;
            btnLogOut.Click += btnLogOut_Click;
            // 
            // label14
            // 
            label14.AutoSize = true;
            label14.Font = new Font("Verdana", 15.75F, FontStyle.Regular, GraphicsUnit.Point);
            label14.ForeColor = Color.White;
            label14.Location = new Point(262, 31);
            label14.Name = "label14";
            label14.Size = new Size(166, 25);
            label14.TabIndex = 1;
            label14.Text = "Panel Almacen";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(478, 254);
            label3.Margin = new Padding(4, 0, 4, 0);
            label3.Name = "label3";
            label3.Size = new Size(105, 18);
            label3.TabIndex = 61;
            label3.Text = "Mostrar Stock";
            // 
            // button3
            // 
            button3.BackgroundImage = Properties.Resources.vista;
            button3.BackgroundImageLayout = ImageLayout.Stretch;
            button3.FlatStyle = FlatStyle.Flat;
            button3.Location = new Point(478, 150);
            button3.Margin = new Padding(4);
            button3.Name = "button3";
            button3.Size = new Size(107, 100);
            button3.TabIndex = 60;
            button3.UseVisualStyleBackColor = true;
            // 
            // panelAmlacen
            // 
            AutoScaleDimensions = new SizeF(9F, 18F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.FromArgb(220, 237, 244);
            ClientSize = new Size(674, 323);
            Controls.Add(label3);
            Controls.Add(button3);
            Controls.Add(panel1);
            Controls.Add(label2);
            Controls.Add(button2);
            Controls.Add(label1);
            Controls.Add(button1);
            Font = new Font("Arial", 12F, FontStyle.Regular, GraphicsUnit.Point);
            Margin = new Padding(4);
            MaximizeBox = false;
            Name = "panelAmlacen";
            ShowIcon = false;
            StartPosition = FormStartPosition.CenterScreen;
            Text = "Panel Almacen";
            panel1.ResumeLayout(false);
            panel1.PerformLayout();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion
        private Button button1;
        private Label label1;
        private Label label2;
        private Button button2;
        private Panel panel1;
        private Label label14;
        private Label label3;
        private Button button3;
        private Button btnLogOut;
    }
}