using Microsoft.VisualBasic.ApplicationServices;
using Mockups;
using MySql.Data.MySqlClient;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Farmacia
{
    public partial class Producto : Form
    {
        public Producto()
        {
            InitializeComponent();
        }
        static string conexion = ("SERVER = 127.0.0.1;PORT=3306;DATABASE=farmacia;UID=root;PASSWORD=;");
        MySqlConnection con = new MySqlConnection(conexion);

        
        private void btnRegistrarProductos_Click(object sender, EventArgs e)
        {
            con.Open();
            
            string proveedorIDQuery = "SELECT IDLABORATORIO FROM laboratorio where NOMBRE = @nombre";
            MySqlCommand proveedorIDCmd = new MySqlCommand(proveedorIDQuery, con);
            proveedorIDCmd.Parameters.AddWithValue("@nombre",cbUser.Text);
            int proveedorID = Convert.ToInt32(proveedorIDCmd.ExecuteScalar());
            con.Close();
            con.Open();
            string insertar = "INSERT INTO productos(ID_PROVEEDOR, NOMBRE, CODIGOBARRAS, PRECIO, UNIDADMEDIDA, CANTIDADMEDIDA, OBSERVACIONES) VALUES (@ID_PROVEEDOR, @NOMBRE, @CODIGOBARRAS, @PRECIO, @UNIDADMEDIDA, @CANTIDADMEDIDA, @OBSERVACIONES)";
            MySqlCommand cmd = new MySqlCommand(insertar, con);
            if (string.IsNullOrEmpty(tbNombre.Text) || string.IsNullOrEmpty(cbUser.Text) || string.IsNullOrEmpty(tbCantidad.Text) || string.IsNullOrEmpty(tbCB.Text) || string.IsNullOrEmpty(tbPrecio.Text) || string.IsNullOrEmpty(tbUnidad.Text) || string.IsNullOrEmpty(txtObserbaciones.Text))
            {
                MessageBox.Show("1 o mas campos no han sido llenados");
                con.Close();
            }
            else
            {
                cmd.Parameters.AddWithValue("@ID_PROVEEDOR", proveedorID);
                cmd.Parameters.AddWithValue("@NOMBRE", tbNombre.Text);
                cmd.Parameters.AddWithValue("@CODIGOBARRAS", tbCB.Text);
                cmd.Parameters.AddWithValue("@PRECIO", tbPrecio.Text);
                cmd.Parameters.AddWithValue("@UNIDADMEDIDA", tbUnidad.Text);
                cmd.Parameters.AddWithValue("@CANTIDADMEDIDA", tbCantidad.Text);
                cmd.Parameters.AddWithValue("@OBSERVACIONES", txtObserbaciones.Text);
                cmd.ExecuteNonQuery();
                MessageBox.Show("Producto Agregado Exitosamente");

                PanelAdmin panel = new PanelAdmin();
                panel.Show();
                this.Close();
                con.Close();
            }
            con.Close();
        }

        private void Producto_Load(object sender, EventArgs e)
        {
            con.Open();
            string buscarID = "SELECT NOMBRE FROM laboratorio";
            MySqlCommand cmd = new MySqlCommand(buscarID, con);
            MySqlDataReader registros = cmd.ExecuteReader();
            while (registros.Read())
            {
                string item = registros["NOMBRE"] + " ";
                cbUser.Items.Add(item);
            }
            con.Close();
        }

        private void tbPrecio_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!char.IsControl(e.KeyChar) && !char.IsDigit(e.KeyChar) && e.KeyChar != '.')
            {
                e.Handled = true; // Mark the event as handled to prevent the character from being entered
            }
            else if (e.KeyChar == '.')
            {
                // Check if the textbox already contains a decimal point or if it's the first character
                if (tbPrecio.Text.Contains('.') || tbPrecio.SelectionStart == 0)
                {
                    e.Handled = true; // Mark the event as handled to prevent the character from being entered
                }
            }
            else if (char.IsDigit(e.KeyChar) && tbPrecio.Text.Contains('.'))
            {
                // Check if the number of digits after the decimal point is already two
                int selectionStart = tbPrecio.SelectionStart;
                int selectionLength = tbPrecio.SelectionLength;
                string newText = tbPrecio.Text.Remove(selectionStart, selectionLength).Insert(selectionStart, e.KeyChar.ToString());
                int dotIndex = newText.IndexOf('.');
                int decimalPlaces = newText.Length - dotIndex - 1;
                if (decimalPlaces > 2)
                {
                    e.Handled = true; // Mark the event as handled to prevent the character from being entered
                }
            }
        }

        private void tbCB_KeyPress(object sender, KeyPressEventArgs e)
        {
            e.Handled = !char.IsDigit(e.KeyChar);
            
        }

        private void btnCancelar_Click(object sender, EventArgs e)
        {
            panelAmlacen panel = new panelAmlacen();
            panel.Show();
            this.Hide();
            con.Close();
        }
    }
}
