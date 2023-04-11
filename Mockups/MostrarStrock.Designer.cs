namespace Farmacia
{
    partial class MostrarStrock
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
            label4 = new Label();
            btnCancelar = new Button();
            dataGridView1 = new DataGridView();
            ID_Producto = new DataGridViewTextBoxColumn();
            Stock = new DataGridViewTextBoxColumn();
            panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)dataGridView1).BeginInit();
            SuspendLayout();
            // 
            // panel1
            // 
            panel1.BackColor = Color.DarkSlateGray;
            panel1.Controls.Add(label4);
            panel1.Dock = DockStyle.Top;
            panel1.Location = new Point(0, 0);
            panel1.Margin = new Padding(5, 5, 5, 5);
            panel1.Name = "panel1";
            panel1.Size = new Size(527, 84);
            panel1.TabIndex = 34;
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Font = new Font("Verdana", 15.75F, FontStyle.Regular, GraphicsUnit.Point);
            label4.ForeColor = Color.White;
            label4.Location = new Point(196, 30);
            label4.Margin = new Padding(5, 0, 5, 0);
            label4.Name = "label4";
            label4.Size = new Size(158, 25);
            label4.TabIndex = 1;
            label4.Text = "Mostrar Stock";
            // 
            // btnCancelar
            // 
            btnCancelar.FlatStyle = FlatStyle.Popup;
            btnCancelar.ForeColor = Color.Black;
            btnCancelar.Location = new Point(352, 444);
            btnCancelar.Margin = new Padding(4, 4, 4, 4);
            btnCancelar.Name = "btnCancelar";
            btnCancelar.Size = new Size(161, 37);
            btnCancelar.TabIndex = 42;
            btnCancelar.Text = "ATRAS";
            btnCancelar.UseVisualStyleBackColor = true;
            // 
            // dataGridView1
            // 
            dataGridView1.BackgroundColor = Color.FromArgb(220, 237, 244);
            dataGridView1.BorderStyle = BorderStyle.None;
            dataGridView1.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridView1.Columns.AddRange(new DataGridViewColumn[] { ID_Producto, Stock });
            dataGridView1.Location = new Point(12, 92);
            dataGridView1.Name = "dataGridView1";
            dataGridView1.RowTemplate.Height = 25;
            dataGridView1.Size = new Size(333, 389);
            dataGridView1.TabIndex = 43;
            // 
            // ID_Producto
            // 
            ID_Producto.AutoSizeMode = DataGridViewAutoSizeColumnMode.None;
            ID_Producto.HeaderText = "Nombre";
            ID_Producto.Name = "ID_Producto";
            ID_Producto.ReadOnly = true;
            // 
            // Stock
            // 
            Stock.HeaderText = "Stock";
            Stock.Name = "Stock";
            Stock.ReadOnly = true;
            // 
            // MostrarStrock
            // 
            AutoScaleDimensions = new SizeF(9F, 18F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.FromArgb(220, 237, 244);
            ClientSize = new Size(527, 494);
            Controls.Add(dataGridView1);
            Controls.Add(btnCancelar);
            Controls.Add(panel1);
            Font = new Font("Arial", 12F, FontStyle.Regular, GraphicsUnit.Point);
            Margin = new Padding(4, 4, 4, 4);
            MaximizeBox = false;
            Name = "MostrarStrock";
            ShowIcon = false;
            StartPosition = FormStartPosition.CenterScreen;
            Text = "Mostrar Stock";
            panel1.ResumeLayout(false);
            panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)dataGridView1).EndInit();
            ResumeLayout(false);
        }

        #endregion

        private Panel panel1;
        private Label label4;
        private Button btnCancelar;
        private DataGridView dataGridView1;
        private DataGridViewTextBoxColumn ID_Producto;
        private DataGridViewTextBoxColumn Stock;
    }
}