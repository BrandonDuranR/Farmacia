using Farmacia;
using Mockups.Properties;
using MySql.Data.MySqlClient;
using Mysqlx;
using System.Data;

namespace Mockups
{
    public partial class Login : Form
    {
        MySqlDataReader something;
        public Login()
        {
            InitializeComponent(); 
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }
        static string conexion = ("SERVER = 127.0.0.1;PORT=3306;DATABASE=farmacia;UID=root;PASSWORD=;");
        MySqlConnection con = new MySqlConnection(conexion);
        private void button1_Click(object sender, EventArgs e)
        {

            try
            {
                con.Open();
                string usuarioAdmin = ("SELECT ROL FROM `usuario` WHERE USUARIO='" + tbUser.Text + "' AND CONTRASENA='" + tbPass.Text + "';");
                MySqlCommand cmd = new MySqlCommand(usuarioAdmin, con);
                something = cmd.ExecuteReader();
                if (something.Read())
                {
                    string rol = something.GetString(0);
                    if (rol == "ADMIN")
                    {
                        PanelAdmin panel = new PanelAdmin();
                        panel.Show();
                        this.Hide();
                        con.Close();

                    }
                    else if (rol == "ALMACEN")
                    {
                        panelAmlacen almace = new panelAmlacen();
                        almace.Show();
                        this.Hide();
                        con.Close();
                    }
                    else if (rol == "VENTAS")
                    {
                        MessageBox.Show("Accediste como alguien de ventas");
                        con.Close();
                    }

                }
            }
            catch
            {
                MessageBox.Show("Usuario o contraseña invalida");
            }

        }
    }
}
