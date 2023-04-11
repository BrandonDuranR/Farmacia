using Microsoft.VisualBasic.ApplicationServices;
using Mockups;
using MySql.Data.MySqlClient;
using Org.BouncyCastle.Crypto;
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
    public partial class AgregarMedicamento : Form
    {
        public AgregarMedicamento()
        {
            InitializeComponent();
            con.Open();
            string buscarLaboratorio = "SELECT NOMBRE FROM laboratorio";
            string buscarUser = "SELECT NOMBRE, APELLIDO_P, APELLIDO_M FROM usuario WHERE ROL='ALMACEN'";
            MySqlCommand cmd = new MySqlCommand(buscarLaboratorio, con);

            MySqlDataReader nombrelab = cmd.ExecuteReader();

            while (nombrelab.Read())
            {
                string item = nombrelab["NOMBRE"] + "";
                cbxLab.Items.Add(item);
            }
            con.Close();
            con.Open();
            MySqlCommand cmd2 = new MySqlCommand(buscarUser, con);
            MySqlDataReader nombreUser = cmd2.ExecuteReader();
            while (nombreUser.Read())
            {
                string item2 = nombreUser["NOMBRE"] + "  " + nombreUser["APELLIDO_P"] + "  " + nombreUser["APELLIDO_M"];
                cbxUser.Items.Add(item2);
            }
            con.Close();
        }
        static string conexion = ("SERVER = 127.0.0.1;PORT=3306;DATABASE=farmacia;UID=root;PASSWORD=;");
        MySqlConnection con = new MySqlConnection(conexion);
        private void btnRegresar_Click(object sender, EventArgs e)
        {
            panelAmlacen almacen = new panelAmlacen();
            almacen.Show();
            this.Close();
        }

        private void tbStock_KeyDown(object sender, KeyEventArgs e)
        {

        }

        private void tbStock_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!char.IsControl(e.KeyChar) && !char.IsDigit(e.KeyChar))
            {
                e.Handled = true;
            }
        }

        private void tbPrecio_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!char.IsControl(e.KeyChar) && !char.IsDigit(e.KeyChar) && (e.KeyChar != '.'))
            {
                e.Handled = true;
            }

            if ((e.KeyChar == '.') && ((sender as TextBox).Text.IndexOf('.') > -1))
            {
                e.Handled = true;
            }
        }

        private void btnAgregar_Click(object sender, EventArgs e)
        {

            con.Open();
            string insertar = "INSERT INTO usuario(IDUSER, IDLAB, Nombre, NOMBRE_COMPUESTO, TIPO, CONTENIDO, TIPO_ADMINISTRACION, CANTIDAD, EFECTO, STOCK_DISPONIBLE,PRECIO) VALUES (@IDUSER, @IDLAB, @Nombre, @NOMBRE_COMPUESTO, @TIPO, @CONTENIDO, @TIPO_ADMINISTRACION, @CANTIDAD, @EFECTO, @STOCK_DISPONIBLE,@PRECIO)";
            MySqlCommand cmd = new MySqlCommand(insertar, con);
            if (string.IsNullOrEmpty(cbxLab.Text) || string.IsNullOrEmpty(cbxUser.Text) || string.IsNullOrEmpty(tbMedicamento.Text) || string.IsNullOrEmpty(tbCompuesto.Text) || string.IsNullOrEmpty(tbTipoMed.Text) || string.IsNullOrEmpty(tbContenido.Text) || string.IsNullOrEmpty(tbEfecto.Text) || string.IsNullOrEmpty(tbAdministracion.Text) || string.IsNullOrEmpty(tbCantidad.Text) || string.IsNullOrEmpty(tbEfecto.Text) || string.IsNullOrEmpty(tbStock.Text) || string.IsNullOrEmpty(tbPrecio.Text))
            {
                MessageBox.Show("1 o mas campos no han sido llenados");
                con.Close();
            }
            else
            {
                cmd.Parameters.AddWithValue("@IDUSER", cbxUser.Text); // replace with actual value
                cmd.Parameters.AddWithValue("@IDLAB", cbxLab.Text); // replace with actual value
                cmd.Parameters.AddWithValue("@Nombre", tbMedicamento.Text);
                cmd.Parameters.AddWithValue("@NOMBRE_COMPUESTO", tbCompuesto.Text);
                cmd.Parameters.AddWithValue("@TIPO", tbTipoMed.Text);
                cmd.Parameters.AddWithValue("@CONTENIDO", tbContenido.Text);
                cmd.Parameters.AddWithValue("@TIPO_ADMINISTRACION", tbAdministracion.Text);
                cmd.Parameters.AddWithValue("@CANTIDAD", tbCantidad.Text);
                cmd.Parameters.AddWithValue("@EFECTO", tbEfecto.Text);
                cmd.Parameters.AddWithValue("@STOCK_DISPONIBLE", tbStock.Text);
                cmd.Parameters.AddWithValue("@PRECIO", tbPrecio.Text);
                cmd.ExecuteNonQuery();
                MessageBox.Show("Usuario Agregado Exitosamente");

                PanelAdmin panel = new PanelAdmin();
                panel.Show();
                this.Close();
                con.Close();
            }
            con.Close();
        }

        private void AgregarMedicamento_Load(object sender, EventArgs e)
        {

        }
    }
}
