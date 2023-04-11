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
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Farmacia
{
    public partial class RegistrarLote : Form
    {
        public RegistrarLote()
        {
            InitializeComponent();
        }
        static string conexion = ("SERVER = 127.0.0.1;PORT=3306;DATABASE=farmacia;UID=root;PASSWORD=;");
        MySqlConnection con = new MySqlConnection(conexion);

        private void btnCancelar_Click(object sender, EventArgs e)
        {
            panelAmlacen panelAmlacen = new panelAmlacen();
            panelAmlacen.Show();
            panelAmlacen.Close();
        }

        private void btnRegistroLote_Click(object sender, EventArgs e)
        {
            con.Open();

            string proveedorIDQuery = "SELECT ID_PRODUCTO FROM productos where NOMBRE = @nombre";
            MySqlCommand proveedorIDCmd = new MySqlCommand(proveedorIDQuery, con);
            proveedorIDCmd.Parameters.AddWithValue("@nombre", cbUser.Text);
            int proveedorID = Convert.ToInt32(proveedorIDCmd.ExecuteScalar());
            con.Close();
            con.Open();
            string insertar = "INSERT INTO lote(ID_PRODUCTO, PIEZAS, CADUCIDAD) VALUES (@ID_PRODUCTO, @PIEZAS, @CADUCIDAD)";
            MySqlCommand cmd = new MySqlCommand(insertar, con);
            if (string.IsNullOrEmpty(textBox1.Text) || string.IsNullOrEmpty(cbUser.Text) || string.IsNullOrEmpty(dateTimePicker1.Text))
            {
                MessageBox.Show("1 o mas campos no han sido llenados");
                con.Close();
            }
            else
            {
                string selectDateAsString = dateTimePicker1.Value.ToString("yyyyMMdd");
                cmd.Parameters.AddWithValue("@ID_PRODUCTO", proveedorID);
                cmd.Parameters.AddWithValue("@PIEZAS", textBox1.Text);
                cmd.Parameters.AddWithValue("@CADUCIDAD", selectDateAsString);
                cmd.ExecuteNonQuery();
            

                
                con.Close();
            }
            con.Close();
            con.Open();
            string insertarAlmacen = "INSERT INTO almacen(ID_PRODUCTO, STOCK) VALUES (@ID_PRODUCTO2, @STOCK)";
            MySqlCommand cmd2 = new MySqlCommand(insertarAlmacen, con);
            if (string.IsNullOrEmpty(textBox1.Text) || string.IsNullOrEmpty(cbUser.Text) || string.IsNullOrEmpty(dateTimePicker1.Text))
            {
                MessageBox.Show("1 o mas campos no han sido llenados");
                con.Close();
            }
            else
            {
                cmd.Parameters.AddWithValue("@ID_PRODUCTO2", proveedorID);
                cmd.Parameters.AddWithValue("@STOCK", textBox1.Text);
                cmd.ExecuteNonQuery();
                MessageBox.Show("Lote Agregado Exitosamente");

                panelAmlacen panel = new panelAmlacen();
                panel.Show();
                this.Close();
                con.Close();
            }
            con.Close();
        }

        private void RegistrarLote_Load(object sender, EventArgs e)
        {
            con.Open();
            string buscarID = "SELECT NOMBRE FROM productos";
            MySqlCommand cmd = new MySqlCommand(buscarID, con);
            MySqlDataReader registros = cmd.ExecuteReader();
            while (registros.Read())
            {
                string item = registros["NOMBRE"] + " ";
                cbUser.Items.Add(item);
            }
            con.Close();
        }
    }
}
