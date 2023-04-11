namespace Farmacia
{
    partial class AgregarMedicamento
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
            tbMedicamento = new TextBox();
            tbCompuesto = new TextBox();
            tbTipoMed = new TextBox();
            tbContenido = new TextBox();
            tbEfecto = new TextBox();
            tbStock = new TextBox();
            tbPrecio = new TextBox();
            cbxUser = new ComboBox();
            cbxLab = new ComboBox();
            label1 = new Label();
            label2 = new Label();
            label3 = new Label();
            label4 = new Label();
            label5 = new Label();
            label6 = new Label();
            label7 = new Label();
            label8 = new Label();
            label9 = new Label();
            btnRegresar = new Button();
            btnAgregar = new Button();
            label10 = new Label();
            tbAdministracion = new TextBox();
            label11 = new Label();
            tbCantidad = new TextBox();
            SuspendLayout();
            // 
            // tbMedicamento
            // 
            tbMedicamento.Location = new Point(212, 120);
            tbMedicamento.Margin = new Padding(4);
            tbMedicamento.Name = "tbMedicamento";
            tbMedicamento.Size = new Size(205, 26);
            tbMedicamento.TabIndex = 0;
            // 
            // tbCompuesto
            // 
            tbCompuesto.Location = new Point(212, 166);
            tbCompuesto.Margin = new Padding(4);
            tbCompuesto.Name = "tbCompuesto";
            tbCompuesto.Size = new Size(205, 26);
            tbCompuesto.TabIndex = 1;
            // 
            // tbTipoMed
            // 
            tbTipoMed.Location = new Point(212, 212);
            tbTipoMed.Margin = new Padding(4);
            tbTipoMed.Name = "tbTipoMed";
            tbTipoMed.Size = new Size(205, 26);
            tbTipoMed.TabIndex = 2;
            // 
            // tbContenido
            // 
            tbContenido.Location = new Point(212, 304);
            tbContenido.Margin = new Padding(4);
            tbContenido.Name = "tbContenido";
            tbContenido.Size = new Size(205, 26);
            tbContenido.TabIndex = 3;
            // 
            // tbEfecto
            // 
            tbEfecto.Location = new Point(644, 29);
            tbEfecto.Margin = new Padding(4);
            tbEfecto.Multiline = true;
            tbEfecto.Name = "tbEfecto";
            tbEfecto.Size = new Size(276, 118);
            tbEfecto.TabIndex = 4;
            // 
            // tbStock
            // 
            tbStock.Location = new Point(644, 165);
            tbStock.Margin = new Padding(4);
            tbStock.Name = "tbStock";
            tbStock.Size = new Size(159, 26);
            tbStock.TabIndex = 5;
            tbStock.KeyDown += tbStock_KeyDown;
            tbStock.KeyPress += tbStock_KeyPress;
            // 
            // tbPrecio
            // 
            tbPrecio.Location = new Point(644, 253);
            tbPrecio.Margin = new Padding(4);
            tbPrecio.Name = "tbPrecio";
            tbPrecio.Size = new Size(159, 26);
            tbPrecio.TabIndex = 6;
            tbPrecio.KeyPress += tbPrecio_KeyPress;
            // 
            // cbxUser
            // 
            cbxUser.FormattingEnabled = true;
            cbxUser.Location = new Point(212, 28);
            cbxUser.Margin = new Padding(4);
            cbxUser.Name = "cbxUser";
            cbxUser.Size = new Size(205, 26);
            cbxUser.TabIndex = 7;
            // 
            // cbxLab
            // 
            cbxLab.FormattingEnabled = true;
            cbxLab.Location = new Point(212, 74);
            cbxLab.Margin = new Padding(4);
            cbxLab.Name = "cbxLab";
            cbxLab.Size = new Size(205, 26);
            cbxLab.TabIndex = 8;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(138, 31);
            label1.Margin = new Padding(4, 0, 4, 0);
            label1.Name = "label1";
            label1.Size = new Size(66, 18);
            label1.TabIndex = 11;
            label1.Text = "Usuario:";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(111, 77);
            label2.Margin = new Padding(4, 0, 4, 0);
            label2.Name = "label2";
            label2.Size = new Size(93, 18);
            label2.TabIndex = 12;
            label2.Text = "Laboratorio:";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(12, 123);
            label3.Margin = new Padding(4, 0, 4, 0);
            label3.Name = "label3";
            label3.Size = new Size(192, 18);
            label3.TabIndex = 13;
            label3.Text = "Nombre del medicamento:";
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Location = new Point(30, 169);
            label4.Margin = new Padding(4, 0, 4, 0);
            label4.Name = "label4";
            label4.Size = new Size(174, 18);
            label4.TabIndex = 14;
            label4.Text = "Nombre del compuesto:";
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Location = new Point(41, 215);
            label5.Margin = new Padding(4, 0, 4, 0);
            label5.Name = "label5";
            label5.Size = new Size(163, 18);
            label5.TabIndex = 15;
            label5.Text = "Tipo de medicamento:";
            // 
            // label6
            // 
            label6.AutoSize = true;
            label6.Location = new Point(120, 307);
            label6.Margin = new Padding(4, 0, 4, 0);
            label6.Name = "label6";
            label6.Size = new Size(84, 18);
            label6.TabIndex = 16;
            label6.Text = "Contenido:";
            // 
            // label7
            // 
            label7.AutoSize = true;
            label7.Location = new Point(579, 75);
            label7.Margin = new Padding(4, 0, 4, 0);
            label7.Name = "label7";
            label7.Size = new Size(57, 18);
            label7.TabIndex = 17;
            label7.Text = "Efecto:";
            // 
            // label8
            // 
            label8.AutoSize = true;
            label8.Location = new Point(505, 169);
            label8.Margin = new Padding(4, 0, 4, 0);
            label8.Name = "label8";
            label8.Size = new Size(131, 18);
            label8.TabIndex = 18;
            label8.Text = "Stock Disponible:";
            // 
            // label9
            // 
            label9.AutoSize = true;
            label9.Location = new Point(578, 257);
            label9.Margin = new Padding(4, 0, 4, 0);
            label9.Name = "label9";
            label9.Size = new Size(58, 18);
            label9.TabIndex = 19;
            label9.Text = "Precio:";
            // 
            // btnRegresar
            // 
            btnRegresar.Location = new Point(640, 369);
            btnRegresar.Margin = new Padding(4);
            btnRegresar.Name = "btnRegresar";
            btnRegresar.Size = new Size(113, 37);
            btnRegresar.TabIndex = 20;
            btnRegresar.Text = "Regresar";
            btnRegresar.UseVisualStyleBackColor = true;
            btnRegresar.Click += btnRegresar_Click;
            // 
            // btnAgregar
            // 
            btnAgregar.Location = new Point(792, 369);
            btnAgregar.Margin = new Padding(4);
            btnAgregar.Name = "btnAgregar";
            btnAgregar.Size = new Size(113, 37);
            btnAgregar.TabIndex = 21;
            btnAgregar.Text = "Añadir";
            btnAgregar.UseVisualStyleBackColor = true;
            btnAgregar.Click += btnAgregar_Click;
            // 
            // label10
            // 
            label10.AutoSize = true;
            label10.Location = new Point(34, 261);
            label10.Margin = new Padding(4, 0, 4, 0);
            label10.Name = "label10";
            label10.Size = new Size(170, 18);
            label10.TabIndex = 23;
            label10.Text = "Tipo de administracion:";
            // 
            // tbAdministracion
            // 
            tbAdministracion.Location = new Point(212, 258);
            tbAdministracion.Margin = new Padding(4);
            tbAdministracion.Name = "tbAdministracion";
            tbAdministracion.Size = new Size(205, 26);
            tbAdministracion.TabIndex = 22;
            // 
            // label11
            // 
            label11.AutoSize = true;
            label11.Location = new Point(439, 213);
            label11.Margin = new Padding(4, 0, 4, 0);
            label11.Name = "label11";
            label11.Size = new Size(197, 18);
            label11.TabIndex = 25;
            label11.Text = "Cantidad de medicamento:";
            // 
            // tbCantidad
            // 
            tbCantidad.Location = new Point(644, 209);
            tbCantidad.Margin = new Padding(4);
            tbCantidad.Name = "tbCantidad";
            tbCantidad.Size = new Size(159, 26);
            tbCantidad.TabIndex = 24;
            // 
            // AgregarMedicamento
            // 
            AutoScaleDimensions = new SizeF(9F, 18F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(939, 421);
            Controls.Add(label11);
            Controls.Add(tbCantidad);
            Controls.Add(label10);
            Controls.Add(tbAdministracion);
            Controls.Add(btnAgregar);
            Controls.Add(btnRegresar);
            Controls.Add(label9);
            Controls.Add(label8);
            Controls.Add(label7);
            Controls.Add(label6);
            Controls.Add(label5);
            Controls.Add(label4);
            Controls.Add(label3);
            Controls.Add(label2);
            Controls.Add(label1);
            Controls.Add(cbxLab);
            Controls.Add(cbxUser);
            Controls.Add(tbPrecio);
            Controls.Add(tbStock);
            Controls.Add(tbEfecto);
            Controls.Add(tbContenido);
            Controls.Add(tbTipoMed);
            Controls.Add(tbCompuesto);
            Controls.Add(tbMedicamento);
            Font = new Font("Arial", 12F, FontStyle.Regular, GraphicsUnit.Point);
            FormBorderStyle = FormBorderStyle.FixedDialog;
            Margin = new Padding(4);
            Name = "AgregarMedicamento";
            Text = "Agregar Medicamento";
            Load += AgregarMedicamento_Load;
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private TextBox tbMedicamento;
        private TextBox tbCompuesto;
        private TextBox tbTipoMed;
        private TextBox tbContenido;
        private TextBox tbEfecto;
        private TextBox tbStock;
        private TextBox tbPrecio;
        private ComboBox cbxUser;
        private ComboBox cbxLab;
        private Label label1;
        private Label label2;
        private Label label3;
        private Label label4;
        private Label label5;
        private Label label6;
        private Label label7;
        private Label label8;
        private Label label9;
        private Button btnRegresar;
        private Button btnAgregar;
        private Label label10;
        private TextBox tbAdministracion;
        private Label label11;
        private TextBox tbCantidad;
    }
}