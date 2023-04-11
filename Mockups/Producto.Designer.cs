namespace Farmacia
{
    partial class Producto
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
            label14 = new Label();
            label1 = new Label();
            label2 = new Label();
            label3 = new Label();
            label4 = new Label();
            label5 = new Label();
            label6 = new Label();
            label7 = new Label();
            this.txtNombre = new TextBox();
            this.txtCodBar = new TextBox();
            this.txtPrecio = new TextBox();
            this.txtUnidadMedida = new TextBox();
            this.txtCantidadMedida = new TextBox();
            txtObserbaciones = new TextBox();
            btnRegistrarProductos = new Button();
            btnCancelar = new Button();
            cbProveedor = new ComboBox();
            panel1.SuspendLayout();
            SuspendLayout();
            // 
            // panel1
            // 
            panel1.BackColor = Color.DarkSlateGray;
            panel1.Controls.Add(label14);
            panel1.Dock = DockStyle.Top;
            panel1.Location = new Point(0, 0);
            panel1.Name = "panel1";
            panel1.Size = new Size(436, 58);
            panel1.TabIndex = 58;
            // 
            // label14
            // 
            label14.AutoSize = true;
            label14.Font = new Font("Verdana", 15.75F, FontStyle.Regular, GraphicsUnit.Point);
            label14.ForeColor = Color.White;
            label14.Location = new Point(87, 18);
            label14.Name = "label14";
            label14.Size = new Size(276, 25);
            label14.TabIndex = 1;
            label14.Text = "REGISTRAR PRODUCTOS";
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(78, 103);
            label1.Name = "label1";
            label1.Size = new Size(85, 18);
            label1.TabIndex = 59;
            label1.Text = "Proveedor:";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(95, 143);
            label2.Name = "label2";
            label2.Size = new Size(68, 18);
            label2.TabIndex = 60;
            label2.Text = "Nombre:";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(48, 183);
            label3.Name = "label3";
            label3.Size = new Size(115, 18);
            label3.TabIndex = 61;
            label3.Text = "Codigo Barras:";
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Location = new Point(105, 223);
            label4.Name = "label4";
            label4.Size = new Size(58, 18);
            label4.TabIndex = 62;
            label4.Text = "Precio:";
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Location = new Point(44, 263);
            label5.Name = "label5";
            label5.Size = new Size(119, 18);
            label5.TabIndex = 63;
            label5.Text = "Unidad Medida:";
            // 
            // label6
            // 
            label6.AutoSize = true;
            label6.Location = new Point(30, 303);
            label6.Name = "label6";
            label6.Size = new Size(133, 18);
            label6.TabIndex = 64;
            label6.Text = "Cantidad Medida:";
            // 
            // label7
            // 
            label7.AutoSize = true;
            label7.Location = new Point(46, 343);
            label7.Name = "label7";
            label7.Size = new Size(117, 18);
            label7.TabIndex = 65;
            label7.Text = "Observaciones:";
            // 
            // txtNombre
            // 
            this.txtNombre.Location = new Point(169, 140);
            this.txtNombre.Name = "txtNombre";
            this.txtNombre.Size = new Size(206, 26);
            this.txtNombre.TabIndex = 67;
            // 
            // txtCodBar
            // 
            this.txtCodBar.Location = new Point(169, 180);
            this.txtCodBar.Name = "txtCodBar";
            this.txtCodBar.Size = new Size(206, 26);
            this.txtCodBar.TabIndex = 68;
            // 
            // txtPrecio
            // 
            this.txtPrecio.Location = new Point(169, 220);
            this.txtPrecio.Name = "txtPrecio";
            this.txtPrecio.Size = new Size(206, 26);
            this.txtPrecio.TabIndex = 69;
            // 
            // txtUnidadMedida
            // 
            this.txtUnidadMedida.Location = new Point(169, 260);
            this.txtUnidadMedida.Name = "txtUnidadMedida";
            this.txtUnidadMedida.Size = new Size(206, 26);
            this.txtUnidadMedida.TabIndex = 70;
            // 
            // txtCantidadMedida
            // 
            this.txtCantidadMedida.Location = new Point(169, 300);
            this.txtCantidadMedida.Name = "txtCantidadMedida";
            this.txtCantidadMedida.Size = new Size(206, 26);
            this.txtCantidadMedida.TabIndex = 71;
            // 
            // txtObserbaciones
            // 
            txtObserbaciones.Location = new Point(169, 340);
            txtObserbaciones.Name = "txtObserbaciones";
            txtObserbaciones.Size = new Size(206, 26);
            txtObserbaciones.TabIndex = 72;
            // 
            // btnRegistrarProductos
            // 
            btnRegistrarProductos.FlatStyle = FlatStyle.Popup;
            btnRegistrarProductos.Location = new Point(49, 424);
            btnRegistrarProductos.Name = "btnRegistrarProductos";
            btnRegistrarProductos.Size = new Size(125, 31);
            btnRegistrarProductos.TabIndex = 73;
            btnRegistrarProductos.Text = "REGISTRAR";
            btnRegistrarProductos.UseVisualStyleBackColor = true;
            // 
            // btnCancelar
            // 
            btnCancelar.FlatStyle = FlatStyle.Popup;
            btnCancelar.Location = new Point(238, 424);
            btnCancelar.Name = "btnCancelar";
            btnCancelar.Size = new Size(125, 31);
            btnCancelar.TabIndex = 74;
            btnCancelar.Text = "CANCELAR";
            btnCancelar.UseVisualStyleBackColor = true;
            // 
            // cbProveedor
            // 
            cbProveedor.FormattingEnabled = true;
            cbProveedor.Location = new Point(169, 100);
            cbProveedor.Name = "cbProveedor";
            cbProveedor.Size = new Size(206, 26);
            cbProveedor.TabIndex = 75;
            // 
            // Producto
            // 
            AutoScaleDimensions = new SizeF(9F, 18F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.FromArgb(220, 237, 244);
            ClientSize = new Size(436, 511);
            Controls.Add(cbProveedor);
            Controls.Add(btnCancelar);
            Controls.Add(btnRegistrarProductos);
            Controls.Add(txtObserbaciones);
            Controls.Add(this.txtCantidadMedida);
            Controls.Add(this.txtUnidadMedida);
            Controls.Add(this.txtPrecio);
            Controls.Add(this.txtCodBar);
            Controls.Add(this.txtNombre);
            Controls.Add(label7);
            Controls.Add(label6);
            Controls.Add(label5);
            Controls.Add(label4);
            Controls.Add(label3);
            Controls.Add(label2);
            Controls.Add(label1);
            Controls.Add(panel1);
            Font = new Font("Arial", 12F, FontStyle.Regular, GraphicsUnit.Point);
            Margin = new Padding(4, 4, 4, 4);
            MaximizeBox = false;
            Name = "Producto";
            ShowIcon = false;
            StartPosition = FormStartPosition.CenterScreen;
            Text = "Producto";
            panel1.ResumeLayout(false);
            panel1.PerformLayout();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Panel panel1;
        private Label label14;
        private Label label1;
        private Label label2;
        private Label label3;
        private Label label4;
        private Label label5;
        private Label label6;
        private Label label7;
        private TextBox textBox1;
        private TextBox textBox2;
        private TextBox textBox3;
        private TextBox textBox4;
        private TextBox textBox5;
        private TextBox textBox6;
        private TextBox txtObserbaciones;
        private Button btnRegistrarProductos;
        private Button btnCancelar;
        private ComboBox cbProveedor;
    }
}