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
            this.labelTitleUser = new System.Windows.Forms.Label();
            this.comboBox1 = new System.Windows.Forms.ComboBox();
            this.comboBoxMedicamento = new System.Windows.Forms.ComboBox();
            this.textBox2 = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.buttonRegresar = new System.Windows.Forms.Button();
            this.buttonRegistrar = new System.Windows.Forms.Button();
            this.monthCalendar1 = new System.Windows.Forms.MonthCalendar();
            this.SuspendLayout();
            // 
            // labelTitleUser
            // 
            this.labelTitleUser.AutoSize = true;
            this.labelTitleUser.Location = new System.Drawing.Point(58, 33);
            this.labelTitleUser.Name = "labelTitleUser";
            this.labelTitleUser.Size = new System.Drawing.Size(47, 15);
            this.labelTitleUser.TabIndex = 1;
            this.labelTitleUser.Text = "Usuario";
            // 
            // comboBox1
            // 
            this.comboBox1.FormattingEnabled = true;
            this.comboBox1.Location = new System.Drawing.Point(23, 51);
            this.comboBox1.Name = "comboBox1";
            this.comboBox1.Size = new System.Drawing.Size(121, 23);
            this.comboBox1.TabIndex = 2;
            // 
            // comboBoxMedicamento
            // 
            this.comboBoxMedicamento.FormattingEnabled = true;
            this.comboBoxMedicamento.Location = new System.Drawing.Point(255, 51);
            this.comboBoxMedicamento.Name = "comboBoxMedicamento";
            this.comboBoxMedicamento.Size = new System.Drawing.Size(198, 23);
            this.comboBoxMedicamento.TabIndex = 3;
            // 
            // textBox2
            // 
            this.textBox2.Location = new System.Drawing.Point(339, 129);
            this.textBox2.Name = "textBox2";
            this.textBox2.Size = new System.Drawing.Size(121, 23);
            this.textBox2.TabIndex = 4;
            this.textBox2.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.textBox2_KeyPress);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(339, 33);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(81, 15);
            this.label2.TabIndex = 5;
            this.label2.Text = "Medicamento";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(75, 105);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(112, 15);
            this.label3.TabIndex = 6;
            this.label3.Text = "Fecha de caducidad";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(346, 105);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(114, 15);
            this.label4.TabIndex = 7;
            this.label4.Text = "Cantidad Comprada";
            // 
            // buttonRegresar
            // 
            this.buttonRegresar.Location = new System.Drawing.Point(283, 209);
            this.buttonRegresar.Name = "buttonRegresar";
            this.buttonRegresar.Size = new System.Drawing.Size(75, 23);
            this.buttonRegresar.TabIndex = 9;
            this.buttonRegresar.Text = "Rregresar";
            this.buttonRegresar.UseVisualStyleBackColor = true;
            // 
            // buttonRegistrar
            // 
            this.buttonRegistrar.Location = new System.Drawing.Point(385, 209);
            this.buttonRegistrar.Name = "buttonRegistrar";
            this.buttonRegistrar.Size = new System.Drawing.Size(75, 23);
            this.buttonRegistrar.TabIndex = 10;
            this.buttonRegistrar.Text = "Registrar";
            this.buttonRegistrar.UseVisualStyleBackColor = true;
            this.buttonRegistrar.Click += new System.EventHandler(this.buttonRegistrar_Click);
            // 
            // monthCalendar1
            // 
            this.monthCalendar1.Location = new System.Drawing.Point(18, 129);
            this.monthCalendar1.Name = "monthCalendar1";
            this.monthCalendar1.TabIndex = 12;
            // 
            // RegistrarLote
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(513, 338);
            this.Controls.Add(this.monthCalendar1);
            this.Controls.Add(this.buttonRegistrar);
            this.Controls.Add(this.buttonRegresar);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.textBox2);
            this.Controls.Add(this.comboBoxMedicamento);
            this.Controls.Add(this.comboBox1);
            this.Controls.Add(this.labelTitleUser);
            this.Name = "RegistrarLote";
            this.Text = "RegistrarLote";
            this.Load += new System.EventHandler(this.RegistrarLote_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private Label labelTitleUser;
        private ComboBox comboBox1;
        private ComboBox comboBoxMedicamento;
        private TextBox textBox2;
        private Label label2;
        private Label label3;
        private Label label4;
        private Button buttonRegresar;
        private Button buttonRegistrar;
        private MonthCalendar monthCalendar1;
    }
}