namespace Farmacia
{
    partial class RegistrarLote
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
            label4 = new Label();
            panel1 = new Panel();
            label1 = new Label();
            label2 = new Label();
            label3 = new Label();
            comboBox1 = new ComboBox();
            textBox1 = new TextBox();
            dateTimePicker1 = new DateTimePicker();
            btnRegistroLote = new Button();
            btnCancelar = new Button();
            panel1.SuspendLayout();
            SuspendLayout();
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Font = new Font("Verdana", 15.75F, FontStyle.Regular, GraphicsUnit.Point);
            label4.ForeColor = Color.White;
            label4.Location = new Point(148, 25);
            label4.Margin = new Padding(4, 0, 4, 0);
            label4.Name = "label4";
            label4.Size = new Size(184, 25);
            label4.TabIndex = 1;
            label4.Text = "REGISTRO LOTE";
            // 
            // panel1
            // 
            panel1.BackColor = Color.DarkSlateGray;
            panel1.Controls.Add(label4);
            panel1.Dock = DockStyle.Top;
            panel1.Location = new Point(0, 0);
            panel1.Margin = new Padding(4, 4, 4, 4);
            panel1.Name = "panel1";
            panel1.Size = new Size(495, 70);
            panel1.TabIndex = 33;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(106, 121);
            label1.Margin = new Padding(4, 0, 4, 0);
            label1.Name = "label1";
            label1.Size = new Size(75, 18);
            label1.TabIndex = 34;
            label1.Text = "Producto:";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(121, 173);
            label2.Margin = new Padding(4, 0, 4, 0);
            label2.Name = "label2";
            label2.Size = new Size(60, 18);
            label2.TabIndex = 35;
            label2.Text = "Piezas:";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(92, 225);
            label3.Margin = new Padding(4, 0, 4, 0);
            label3.Name = "label3";
            label3.Size = new Size(89, 18);
            label3.TabIndex = 36;
            label3.Text = "Caducidad:";
            // 
            // comboBox1
            // 
            comboBox1.FormattingEnabled = true;
            comboBox1.Location = new Point(188, 118);
            comboBox1.Name = "comboBox1";
            comboBox1.Size = new Size(207, 26);
            comboBox1.TabIndex = 37;
            // 
            // textBox1
            // 
            textBox1.Location = new Point(188, 170);
            textBox1.Name = "textBox1";
            textBox1.Size = new Size(207, 26);
            textBox1.TabIndex = 38;
            // 
            // dateTimePicker1
            // 
            dateTimePicker1.Location = new Point(188, 219);
            dateTimePicker1.Name = "dateTimePicker1";
            dateTimePicker1.Size = new Size(207, 26);
            dateTimePicker1.TabIndex = 39;
            // 
            // btnRegistroLote
            // 
            btnRegistroLote.FlatStyle = FlatStyle.Popup;
            btnRegistroLote.ForeColor = Color.Black;
            btnRegistroLote.Location = new Point(84, 303);
            btnRegistroLote.Name = "btnRegistroLote";
            btnRegistroLote.Size = new Size(125, 31);
            btnRegistroLote.TabIndex = 40;
            btnRegistroLote.Text = "REGISTRAR";
            btnRegistroLote.UseVisualStyleBackColor = true;
            // 
            // btnCancelar
            // 
            btnCancelar.FlatStyle = FlatStyle.Popup;
            btnCancelar.ForeColor = Color.Black;
            btnCancelar.Location = new Point(291, 303);
            btnCancelar.Name = "btnCancelar";
            btnCancelar.Size = new Size(125, 31);
            btnCancelar.TabIndex = 41;
            btnCancelar.Text = "CANCELAR";
            btnCancelar.UseVisualStyleBackColor = true;
            // 
            // RegistrarLote
            // 
            AutoScaleDimensions = new SizeF(9F, 18F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.FromArgb(220, 237, 244);
            ClientSize = new Size(495, 383);
            Controls.Add(btnCancelar);
            Controls.Add(btnRegistroLote);
            Controls.Add(dateTimePicker1);
            Controls.Add(textBox1);
            Controls.Add(comboBox1);
            Controls.Add(label3);
            Controls.Add(label2);
            Controls.Add(label1);
            Controls.Add(panel1);
            Font = new Font("Arial", 12F, FontStyle.Regular, GraphicsUnit.Point);
            Margin = new Padding(4, 4, 4, 4);
            MaximizeBox = false;
            Name = "RegistrarLote";
            ShowIcon = false;
            StartPosition = FormStartPosition.CenterScreen;
            Text = "RegistrarLote";
            panel1.ResumeLayout(false);
            panel1.PerformLayout();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label label4;
        private Panel panel1;
        private Label label1;
        private Label label2;
        private Label label3;
        private ComboBox comboBox1;
        private TextBox textBox1;
        private DateTimePicker dateTimePicker1;
        private Button btnRegistroLote;
        private Button btnCancelar;
    }
}