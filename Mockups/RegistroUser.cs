using Farmacia;
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

namespace Mockups.Properties
{
    public partial class RegistroUser : Form
    {
        public RegistroUser()
        {
            InitializeComponent();
        }
        static string conexion = ("SERVER = 127.0.0.1;PORT=3306;DATABASE=farmacia;UID=root;PASSWORD=;");
        MySqlConnection con = new MySqlConnection(conexion);
        private void button2_Click(object sender, EventArgs e) //Cancelar
        {
            PanelAdmin panel = new PanelAdmin();
            panel.Show();
            this.Close();
        }

        private void button1_Click(object sender, EventArgs e) //Registrar
        {
            con.Open();
            string insertar = "INSERT INTO usuario(NOMBRE, APELLIDO_P, APELLIDO_M, TELEFONO, EMAIL, CP, DIRECCION, USUARIO, CONTRASENA, ROL) VALUES (@NOMBRE,@APELLIDO_P,@APELLIDO_M,@TELEFONO,@EMAIL,@CP,@DIRECCION,@USUARIO,@CONTRASENA,@ROL)";
            MySqlCommand cmd = new MySqlCommand(insertar, con);
            if (string.IsNullOrEmpty(tbNombre.Text) || string.IsNullOrEmpty(tbAP.Text) || string.IsNullOrEmpty(tbAM.Text) || string.IsNullOrEmpty(tbNumero.Text) || string.IsNullOrEmpty(tbCorreo.Text) || string.IsNullOrEmpty(tbCP.Text) || string.IsNullOrEmpty(tbUsuario.Text) || string.IsNullOrEmpty(tbPass.Text) || string.IsNullOrEmpty(tbPass2.Text))
            {
                MessageBox.Show("1 o mas campos no han sido llenados");
                con.Close();
            }
            else if (tbPass.Text != tbPass2.Text)
            {
                MessageBox.Show("Las contraseñas no coinciden");
                con.Close();
            }
            else if (tbPass.Text == tbPass2.Text)
            {
                cmd.Parameters.AddWithValue("@NOMBRE", tbNombre.Text);
                cmd.Parameters.AddWithValue("@APELLIDO_P", tbAP.Text);
                cmd.Parameters.AddWithValue("@APELLIDO_M", tbAM.Text);
                cmd.Parameters.AddWithValue("@TELEFONO", tbNumero.Text);
                cmd.Parameters.AddWithValue("@EMAIL", tbCorreo.Text);
                cmd.Parameters.AddWithValue("@CP", tbCP.Text);
                cmd.Parameters.AddWithValue("@DIRECCION", tbDireccion.Text);
                cmd.Parameters.AddWithValue("@USUARIO", tbUsuario.Text);
                cmd.Parameters.AddWithValue("@CONTRASENA", tbPass.Text);
                cmd.Parameters.AddWithValue("@ROL", cbRol.Text);
                cmd.ExecuteNonQuery();
                MessageBox.Show("Usuario Agregado Exitosamente");

                PanelAdmin panel = new PanelAdmin();
                panel.Show();
                this.Close();
                con.Close();
            }
            con.Close();
        }

        private void tbCP_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!char.IsControl(e.KeyChar) && !char.IsDigit(e.KeyChar))
            {
                e.Handled = true;
            }
        }

        private void tbNumero_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!char.IsControl(e.KeyChar) && !char.IsDigit(e.KeyChar))
            {
                e.Handled = true;
            }
        }

        private void RegistroUser_Load(object sender, EventArgs e)
        {

        }

        private void button2_Click_1(object sender, EventArgs e)
        {
            PanelAdmin panel = new PanelAdmin();
            panel.Show();
            this.Hide();
            con.Close();    
        }

        private void editarToolStripMenuItem_Click(object sender, EventArgs e)
        {
            EditarUsuario editar = new EditarUsuario();
            editar.Show();
            this.Close();
        }

        private void eliminarToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Eliminar eliminar = new Eliminar();
            eliminar.Show();
            this.Close();
        }

        private void RegistroUser_Load_1(object sender, EventArgs e)
        {

        }
    }
}
