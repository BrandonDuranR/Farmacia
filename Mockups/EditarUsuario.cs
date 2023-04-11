using Mockups;
using Mockups.Properties;
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
    public partial class EditarUsuario : Form
    {
        public EditarUsuario()
        {
            InitializeComponent();
        }
        static string conexion = ("SERVER = 127.0.0.1;PORT=3306;DATABASE=farmacia;UID=root;PASSWORD=;");
        MySqlConnection con = new MySqlConnection(conexion);
        private void EditarUsuario_Load(object sender, EventArgs e)
        {
            con.Open();
            string buscarID = "SELECT IDUSER,NOMBRE,APELLIDO_P,APELLIDO_M FROM usuario";
            MySqlCommand cmd = new MySqlCommand(buscarID, con);
            MySqlDataReader registros = cmd.ExecuteReader();
            while (registros.Read())
            {
                string item = registros["IDUSER"] + " - " + registros["NOMBRE"] + " " + registros["APELLIDO_P"] + " " + registros["APELLIDO_M"];
                cbUser.Items.Add(item);
            }
            con.Close();

            // Add the event handler for the SelectedIndexChanged event
            cbUser.SelectedIndexChanged += CbUser_SelectedIndexChanged;
        }

        private void CbUser_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (!string.IsNullOrEmpty(cbUser.Text))
            {
                // Conseguir el IDUSer
                string[] parts = cbUser.Text.Split('-');
                int idUser = int.Parse(parts[0].Trim());

                // Regresar la informacion de la BD
                con.Open();
                string buscarUser = "SELECT NOMBRE, APELLIDO_P, APELLIDO_M, TELEFONO, EMAIL,CP,DIRECCION,USUARIO, CONTRASENA,ROL FROM usuario WHERE IDUSER = @idUser";
                MySqlCommand cmd = new MySqlCommand(buscarUser, con);
                cmd.Parameters.AddWithValue("@idUser", idUser);
                MySqlDataReader reader = cmd.ExecuteReader();
                if (reader.Read())
                {
                    tbNombre.Text = reader["NOMBRE"].ToString();
                    tbAP.Text = reader["APELLIDO_P"].ToString();
                    tbAM.Text = reader["APELLIDO_M"].ToString();
                    tbTelefono.Text = reader["TELEFONO"].ToString();
                    tbCE.Text = reader["EMAIL"].ToString();
                    tbCP.Text = reader["CP"].ToString();
                    tbDireccion.Text = reader["DIRECCION"].ToString();
                    tbUsuario.Text = reader["USUARIO"].ToString();
                    tbPass.Text = reader["CONTRASENA"].ToString();
                    cbRol.Text = reader["ROL"].ToString();
                }
                reader.Close();
                con.Close();
            }
        }


        private void button2_Click(object sender, EventArgs e)
        {
            PanelAdmin panel = new PanelAdmin();
            panel.Show();
            this.Close();
        }

        private void textBox2_TextChanged(object sender, EventArgs e)
        {

        }

        private void textBox4_TextChanged(object sender, EventArgs e)
        {

        }

        private void tbTelefono_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!char.IsControl(e.KeyChar) && !char.IsDigit(e.KeyChar))
            {
                e.Handled = true;
            }
        }

        private void tbCP_TextChanged(object sender, EventArgs e)
        {

        }

        private void tbCP_KeyDown(object sender, KeyEventArgs e)
        {

        }

        private void tbCP_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!char.IsControl(e.KeyChar) && !char.IsDigit(e.KeyChar))
            {
                e.Handled = true;
            }
        }

        private void comboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            string[] parts = cbUser.Text.Split('-');
            int idUser = int.Parse(parts[0].Trim());
            con.Open();
            string actualizar = "UPDATE `usuario` SET NOMBRE = @NOMBRE, APELLIDO_P = @APELLIDO_P, APELLIDO_M = @APELLIDO_M, TELEFONO = @TELEFONO, EMAIL = @EMAIL, CP = @CP, DIRECCION = @DIRECCION, USUARIO = @USUARIO, CONTRASENA = @CONTRASENA, ROL = @ROL WHERE IDUSER = @idUser";
            MySqlCommand cmd = new MySqlCommand(actualizar, con);

            if (string.IsNullOrEmpty(tbNombre.Text) || string.IsNullOrEmpty(tbAP.Text) || string.IsNullOrEmpty(tbAM.Text) || string.IsNullOrEmpty(tbTelefono.Text) || string.IsNullOrEmpty(tbCE.Text) || string.IsNullOrEmpty(tbCP.Text) || string.IsNullOrEmpty(tbUsuario.Text) || string.IsNullOrEmpty(tbPass.Text))
            {
                MessageBox.Show("1 o mas campos no han sido llenados");
                con.Close();
            }
           
            else 
            {

                cmd.Parameters.AddWithValue("@idUser", idUser);
                cmd.Parameters.AddWithValue("@NOMBRE", tbNombre.Text);
                cmd.Parameters.AddWithValue("@APELLIDO_P", tbAP.Text);
                cmd.Parameters.AddWithValue("@APELLIDO_M", tbAM.Text);
                cmd.Parameters.AddWithValue("@TELEFONO", tbTelefono.Text);
                cmd.Parameters.AddWithValue("@EMAIL", tbCE.Text);
                cmd.Parameters.AddWithValue("@CP", tbCP.Text);
                cmd.Parameters.AddWithValue("@DIRECCION", tbDireccion.Text);
                cmd.Parameters.AddWithValue("@USUARIO", tbUsuario.Text);
                cmd.Parameters.AddWithValue("@CONTRASENA", tbPass.Text);
                cmd.Parameters.AddWithValue("@ROL", cbRol.Text);
                cmd.ExecuteNonQuery();
                MessageBox.Show("Usuario Actualizado Exitosamente");

                PanelAdmin panel = new PanelAdmin();
                panel.Show();
                this.Close();
                con.Close();
            }
            con.Close();
        }

        private void editarToolStripMenuItem_Click(object sender, EventArgs e)
        {
            RegistroUser registro = new RegistroUser();
            registro.Show();
            this.Close();
        }

        private void eliminarToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Eliminar eliminar = new Eliminar();
            eliminar.Show();
            this.Close();
        }

        private void button2_Click_1(object sender, EventArgs e)
        {
            PanelAdmin panel = new PanelAdmin();
            panel.Show();
            this.Hide();
            con.Close();
        }

        private void EditarUsuario_Load_1(object sender, EventArgs e)
        {

        }
    }
}

