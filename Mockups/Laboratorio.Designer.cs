namespace Farmacia
{
    partial class Laboratorio
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
            btnCancelar = new Button();
            btnRegistrar = new Button();
            txtNombreLab = new TextBox();
            label2 = new Label();
            panel1 = new Panel();
            label1 = new Label();
            panel1.SuspendLayout();
            SuspendLayout();
            // 
            // btnCancelar
            // 
            btnCancelar.FlatStyle = FlatStyle.Popup;
            btnCancelar.Font = new Font("Arial", 12F, FontStyle.Regular, GraphicsUnit.Point);
            btnCancelar.Location = new Point(243, 200);
            btnCancelar.Margin = new Padding(4);
            btnCancelar.Name = "btnCancelar";
            btnCancelar.Size = new Size(125, 31);
            btnCancelar.TabIndex = 60;
            btnCancelar.Text = "Cancelar";
            btnCancelar.UseVisualStyleBackColor = true;
            // 
            // btnRegistrar
            // 
            btnRegistrar.FlatStyle = FlatStyle.Popup;
            btnRegistrar.Font = new Font("Arial", 12F, FontStyle.Regular, GraphicsUnit.Point);
            btnRegistrar.Location = new Point(94, 200);
            btnRegistrar.Margin = new Padding(4);
            btnRegistrar.Name = "btnRegistrar";
            btnRegistrar.Size = new Size(125, 31);
            btnRegistrar.TabIndex = 59;
            btnRegistrar.Text = "Registrar";
            btnRegistrar.UseVisualStyleBackColor = true;
            // 
            // txtNombreLab
            // 
            txtNombreLab.Location = new Point(94, 136);
            txtNombreLab.Name = "txtNombreLab";
            txtNombreLab.Size = new Size(274, 23);
            txtNombreLab.TabIndex = 58;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Verdana", 12F, FontStyle.Regular, GraphicsUnit.Point);
            label2.Location = new Point(135, 97);
            label2.Name = "label2";
            label2.Size = new Size(209, 18);
            label2.TabIndex = 57;
            label2.Text = "Nombre de Laboratorio :";
            // 
            // panel1
            // 
            panel1.BackColor = Color.DarkSlateGray;
            panel1.Controls.Add(label1);
            panel1.Dock = DockStyle.Top;
            panel1.Location = new Point(0, 0);
            panel1.Name = "panel1";
            panel1.Size = new Size(474, 57);
            panel1.TabIndex = 56;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Verdana", 15.75F, FontStyle.Regular, GraphicsUnit.Point);
            label1.ForeColor = Color.White;
            label1.Location = new Point(68, 20);
            label1.Name = "label1";
            label1.Size = new Size(320, 25);
            label1.TabIndex = 0;
            label1.Text = "REGISTRO DE LABORATORIO";
            // 
            // Laboratorio
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(474, 284);
            Controls.Add(btnCancelar);
            Controls.Add(btnRegistrar);
            Controls.Add(txtNombreLab);
            Controls.Add(label2);
            Controls.Add(panel1);
            MaximizeBox = false;
            Name = "Laboratorio";
            ShowIcon = false;
            StartPosition = FormStartPosition.CenterScreen;
            Text = "Laboratorio";
            panel1.ResumeLayout(false);
            panel1.PerformLayout();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Button btnCancelar;
        private Button btnRegistrar;
        private TextBox txtNombreLab;
        private Label label2;
        private Panel panel1;
        private Label label1;
    }
}