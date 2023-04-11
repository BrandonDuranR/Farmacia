namespace Farmacia
{
    partial class EditarUsuario
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
            button2 = new Button();
            button1 = new Button();
            cbRol = new ComboBox();
            tbPass2 = new TextBox();
            tbPass = new TextBox();
            tbUsuario = new TextBox();
            tbDireccion = new TextBox();
            tbCP = new TextBox();
            tbCE = new TextBox();
            tbAM = new TextBox();
            tbAP = new TextBox();
            tbTelefono = new TextBox();
            tbNombre = new TextBox();
            label12 = new Label();
            label11 = new Label();
            label10 = new Label();
            label9 = new Label();
            label8 = new Label();
            label7 = new Label();
            label6 = new Label();
            label5 = new Label();
            label4 = new Label();
            label3 = new Label();
            label2 = new Label();
            label1 = new Label();
            cbUser = new ComboBox();
            label13 = new Label();
            SuspendLayout();
            // 
            // button2
            // 
            button2.Location = new Point(766, 399);
            button2.Margin = new Padding(4, 4, 4, 4);
            button2.Name = "button2";
            button2.Size = new Size(96, 28);
            button2.TabIndex = 54;
            button2.Text = "Cancelar";
            button2.UseVisualStyleBackColor = true;
            button2.Click += button2_Click;
            // 
            // button1
            // 
            button1.Location = new Point(643, 399);
            button1.Margin = new Padding(4, 4, 4, 4);
            button1.Name = "button1";
            button1.Size = new Size(96, 28);
            button1.TabIndex = 53;
            button1.Text = "Guardar";
            button1.UseVisualStyleBackColor = true;
            button1.Click += button1_Click;
            // 
            // cbRol
            // 
            cbRol.FormattingEnabled = true;
            cbRol.Items.AddRange(new object[] { "VENDEDOR", "ALMACEN", "ADMIN" });
            cbRol.Location = new Point(649, 316);
            cbRol.Margin = new Padding(4, 4, 4, 4);
            cbRol.Name = "cbRol";
            cbRol.Size = new Size(223, 26);
            cbRol.TabIndex = 52;
            cbRol.SelectedIndexChanged += comboBox1_SelectedIndexChanged;
            // 
            // tbPass2
            // 
            tbPass2.Location = new Point(649, 269);
            tbPass2.Margin = new Padding(4, 4, 4, 4);
            tbPass2.Name = "tbPass2";
            tbPass2.Size = new Size(223, 26);
            tbPass2.TabIndex = 51;
            // 
            // tbPass
            // 
            tbPass.Location = new Point(649, 222);
            tbPass.Margin = new Padding(4, 4, 4, 4);
            tbPass.Name = "tbPass";
            tbPass.Size = new Size(223, 26);
            tbPass.TabIndex = 50;
            // 
            // tbUsuario
            // 
            tbUsuario.Location = new Point(649, 175);
            tbUsuario.Margin = new Padding(4, 4, 4, 4);
            tbUsuario.Name = "tbUsuario";
            tbUsuario.Size = new Size(223, 26);
            tbUsuario.TabIndex = 49;
            // 
            // tbDireccion
            // 
            tbDireccion.Location = new Point(649, 128);
            tbDireccion.Margin = new Padding(4, 4, 4, 4);
            tbDireccion.Name = "tbDireccion";
            tbDireccion.Size = new Size(223, 26);
            tbDireccion.TabIndex = 48;
            // 
            // tbCP
            // 
            tbCP.Location = new Point(649, 81);
            tbCP.Margin = new Padding(4, 4, 4, 4);
            tbCP.MaxLength = 5;
            tbCP.Name = "tbCP";
            tbCP.Size = new Size(223, 26);
            tbCP.TabIndex = 47;
            tbCP.TextChanged += tbCP_TextChanged;
            tbCP.KeyDown += tbCP_KeyDown;
            tbCP.KeyPress += tbCP_KeyPress;
            // 
            // tbCE
            // 
            tbCE.Location = new Point(192, 321);
            tbCE.Margin = new Padding(4, 4, 4, 4);
            tbCE.Name = "tbCE";
            tbCE.Size = new Size(223, 26);
            tbCE.TabIndex = 46;
            // 
            // tbAM
            // 
            tbAM.Location = new Point(192, 225);
            tbAM.Margin = new Padding(4, 4, 4, 4);
            tbAM.Name = "tbAM";
            tbAM.Size = new Size(223, 26);
            tbAM.TabIndex = 45;
            // 
            // tbAP
            // 
            tbAP.Location = new Point(192, 177);
            tbAP.Margin = new Padding(4, 4, 4, 4);
            tbAP.Name = "tbAP";
            tbAP.Size = new Size(223, 26);
            tbAP.TabIndex = 44;
            tbAP.TextChanged += textBox2_TextChanged;
            // 
            // tbTelefono
            // 
            tbTelefono.Location = new Point(192, 273);
            tbTelefono.Margin = new Padding(4, 4, 4, 4);
            tbTelefono.MaxLength = 10;
            tbTelefono.Name = "tbTelefono";
            tbTelefono.Size = new Size(223, 26);
            tbTelefono.TabIndex = 43;
            tbTelefono.TextChanged += textBox4_TextChanged;
            tbTelefono.KeyPress += tbTelefono_KeyPress;
            // 
            // tbNombre
            // 
            tbNombre.Location = new Point(192, 129);
            tbNombre.Margin = new Padding(4, 4, 4, 4);
            tbNombre.Name = "tbNombre";
            tbNombre.Size = new Size(223, 26);
            tbNombre.TabIndex = 42;
            // 
            // label12
            // 
            label12.AutoSize = true;
            label12.BackColor = Color.Transparent;
            label12.Font = new Font("Verdana", 12F, FontStyle.Regular, GraphicsUnit.Point);
            label12.Location = new Point(100, 279);
            label12.Margin = new Padding(4, 0, 4, 0);
            label12.Name = "label12";
            label12.Size = new Size(84, 18);
            label12.TabIndex = 41;
            label12.Text = "Telefono:";
            // 
            // label11
            // 
            label11.AutoSize = true;
            label11.BackColor = Color.Transparent;
            label11.Font = new Font("Verdana", 12F, FontStyle.Regular, GraphicsUnit.Point);
            label11.Location = new Point(122, 324);
            label11.Margin = new Padding(4, 0, 4, 0);
            label11.Name = "label11";
            label11.Size = new Size(65, 18);
            label11.TabIndex = 40;
            label11.Text = "E-Mail:";
            // 
            // label10
            // 
            label10.AutoSize = true;
            label10.BackColor = Color.Transparent;
            label10.Font = new Font("Verdana", 12F, FontStyle.Regular, GraphicsUnit.Point);
            label10.Location = new Point(549, 132);
            label10.Margin = new Padding(4, 0, 4, 0);
            label10.Name = "label10";
            label10.Size = new Size(89, 18);
            label10.TabIndex = 39;
            label10.Text = "Dirección:";
            // 
            // label9
            // 
            label9.AutoSize = true;
            label9.BackColor = Color.Transparent;
            label9.Font = new Font("Verdana", 12F, FontStyle.Regular, GraphicsUnit.Point);
            label9.Location = new Point(530, 226);
            label9.Margin = new Padding(4, 0, 4, 0);
            label9.Name = "label9";
            label9.Size = new Size(108, 18);
            label9.TabIndex = 38;
            label9.Text = "Contraseña:";
            // 
            // label8
            // 
            label8.AutoSize = true;
            label8.BackColor = Color.Transparent;
            label8.Font = new Font("Verdana", 12F, FontStyle.Regular, GraphicsUnit.Point);
            label8.Location = new Point(451, 273);
            label8.Margin = new Padding(4, 0, 4, 0);
            label8.Name = "label8";
            label8.Size = new Size(187, 18);
            label8.TabIndex = 37;
            label8.Text = "Confirme Contraseña:";
            // 
            // label7
            // 
            label7.AutoSize = true;
            label7.BackColor = Color.Transparent;
            label7.Font = new Font("Verdana", 12F, FontStyle.Regular, GraphicsUnit.Point);
            label7.Location = new Point(586, 320);
            label7.Margin = new Padding(4, 0, 4, 0);
            label7.Name = "label7";
            label7.Size = new Size(41, 18);
            label7.TabIndex = 36;
            label7.Text = "Rol:";
            // 
            // label6
            // 
            label6.AutoSize = true;
            label6.BackColor = Color.Transparent;
            label6.Font = new Font("Verdana", 12F, FontStyle.Regular, GraphicsUnit.Point);
            label6.Location = new Point(513, 85);
            label6.Margin = new Padding(4, 0, 4, 0);
            label6.Name = "label6";
            label6.Size = new Size(128, 18);
            label6.TabIndex = 35;
            label6.Text = "Codigo Postal:";
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.BackColor = Color.Transparent;
            label5.Font = new Font("Verdana", 12F, FontStyle.Regular, GraphicsUnit.Point);
            label5.Location = new Point(561, 179);
            label5.Margin = new Padding(4, 0, 4, 0);
            label5.Name = "label5";
            label5.Size = new Size(77, 18);
            label5.TabIndex = 34;
            label5.Text = "Usuario:";
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.BackColor = Color.Transparent;
            label4.Font = new Font("Verdana", 12F, FontStyle.Regular, GraphicsUnit.Point);
            label4.Location = new Point(35, 181);
            label4.Margin = new Padding(4, 0, 4, 0);
            label4.Name = "label4";
            label4.Size = new Size(150, 18);
            label4.TabIndex = 33;
            label4.Text = "Apellido Paterno:";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.BackColor = Color.Transparent;
            label3.Font = new Font("Verdana", 12F, FontStyle.Regular, GraphicsUnit.Point);
            label3.Location = new Point(32, 230);
            label3.Margin = new Padding(4, 0, 4, 0);
            label3.Name = "label3";
            label3.Size = new Size(153, 18);
            label3.TabIndex = 32;
            label3.Text = "Apellido Materno:";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.BackColor = Color.Transparent;
            label2.Font = new Font("Verdana", 12F, FontStyle.Regular, GraphicsUnit.Point);
            label2.Location = new Point(83, 132);
            label2.Margin = new Padding(4, 0, 4, 0);
            label2.Name = "label2";
            label2.Size = new Size(101, 18);
            label2.TabIndex = 31;
            label2.Text = "Nombre(s):";
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Verdana", 15.75F, FontStyle.Regular, GraphicsUnit.Point);
            label1.Location = new Point(13, 20);
            label1.Margin = new Padding(4, 0, 4, 0);
            label1.Name = "label1";
            label1.Size = new Size(161, 25);
            label1.TabIndex = 30;
            label1.Text = "Editar Usuario";
            // 
            // cbUser
            // 
            cbUser.FormattingEnabled = true;
            cbUser.Location = new Point(192, 81);
            cbUser.Margin = new Padding(4, 4, 4, 4);
            cbUser.Name = "cbUser";
            cbUser.Size = new Size(223, 26);
            cbUser.TabIndex = 55;
            // 
            // label13
            // 
            label13.AutoSize = true;
            label13.BackColor = Color.Transparent;
            label13.Font = new Font("Verdana", 12F, FontStyle.Regular, GraphicsUnit.Point);
            label13.Location = new Point(23, 83);
            label13.Margin = new Padding(4, 0, 4, 0);
            label13.Name = "label13";
            label13.Size = new Size(162, 18);
            label13.TabIndex = 56;
            label13.Text = "Seleccione Usuario";
            // 
            // EditarUsuario
            // 
            AutoScaleDimensions = new SizeF(9F, 18F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = SystemColors.Control;
            ClientSize = new Size(940, 460);
            Controls.Add(label13);
            Controls.Add(cbUser);
            Controls.Add(button2);
            Controls.Add(button1);
            Controls.Add(cbRol);
            Controls.Add(tbPass2);
            Controls.Add(tbPass);
            Controls.Add(tbUsuario);
            Controls.Add(tbDireccion);
            Controls.Add(tbCP);
            Controls.Add(tbCE);
            Controls.Add(tbAM);
            Controls.Add(tbAP);
            Controls.Add(tbTelefono);
            Controls.Add(tbNombre);
            Controls.Add(label12);
            Controls.Add(label11);
            Controls.Add(label10);
            Controls.Add(label9);
            Controls.Add(label8);
            Controls.Add(label7);
            Controls.Add(label6);
            Controls.Add(label5);
            Controls.Add(label4);
            Controls.Add(label3);
            Controls.Add(label2);
            Controls.Add(label1);
            Font = new Font("Arial", 12F, FontStyle.Regular, GraphicsUnit.Point);
            Margin = new Padding(4, 4, 4, 4);
            Name = "EditarUsuario";
            ShowIcon = false;
            StartPosition = FormStartPosition.CenterScreen;
            Text = "Editar Usuario";
            Load += EditarUsuario_Load;
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Button button2;
        private Button button1;
        private ComboBox cbRol;
        private TextBox tbPass2;
        private TextBox tbPass;
        private TextBox tbUsuario;
        private TextBox tbDireccion;
        private TextBox tbCP;
        private TextBox tbCE;
        private TextBox tbAM;
        private TextBox tbAP;
        private TextBox tbTelefono;
        private TextBox tbNombre;
        private Label label12;
        private Label label11;
        private Label label10;
        private Label label9;
        private Label label8;
        private Label label7;
        private Label label6;
        private Label label5;
        private Label label4;
        private Label label3;
        private Label label2;
        private Label label1;
        private ComboBox cbUser;
        private Label label13;
    }
}