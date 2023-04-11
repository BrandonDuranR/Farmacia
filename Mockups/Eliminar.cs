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
    public partial class Eliminar : Form
    {
        public Eliminar()
        {
            InitializeComponent();
            
        }

        private void button1_Click(object sender, EventArgs e)//buscar
        {
            
            dataGridView1.DataSource = buscarTabla();
        }
        static string conexion = ("SERVER = 127.0.0.1;PORT=3306;DATABASE=farmacia;UID=root;PASSWORD=;");
        MySqlConnection con = new MySqlConnection(conexion);
        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }
        public DataTable llenarTabla()
        {
            con.Open();
            DataTable dt = new DataTable();
            string llenar = ("SELECT IDUSER, NOMBRE,APELLIDO_P,APELLIDO_M,USUARIO, ROL FROM `usuario`");
            MySqlCommand cmd = new MySqlCommand(llenar, con);
            MySqlDataAdapter dataAdapter = new MySqlDataAdapter(cmd);
            dataAdapter.Fill(dt);
            con.Close();
            return dt;

        }
        public DataTable buscarTabla()
        {
            dataGridView1.ClearSelection();
            DataTable busqueda = new DataTable();
            string bus = "SELECT IDUSER, NOMBRE,APELLIDO_P,APELLIDO_M,USUARIO, ROL FROM `usuario` where NOMBRE = \"" + tbBusqueda.Text+ "\"";
            MySqlCommand cmd = new MySqlCommand(bus, con);
            MySqlDataAdapter dataAdapter = new MySqlDataAdapter(cmd);
            dataAdapter.Fill(busqueda);
            con.Close();
            return busqueda;
        }
        public  void eliminarRegistro()
        {
            string query = "DELETE FROM usuario WHERE IDUSER = @iduser";
            MySqlCommand cmd = new MySqlCommand(query, con);
            cmd.Parameters.AddWithValue("@iduser", textBox1.Text);
            con.Open();
            cmd.ExecuteNonQuery();
            con.Close();
        }

        private void Eliminar_Load(object sender, EventArgs e) //Mostrar la tabla
        {
            dataGridView1.DataSource = llenarTabla();
        }

        private void button2_Click(object sender, EventArgs e)//Eliminar
        {
            eliminarRegistro();
            dataGridView1.DataSource=llenarTabla();
        }

        private void button3_Click(object sender, EventArgs e)//REGRESAR
        {
            PanelAdmin panel = new PanelAdmin();
            panel.Show();
            this.Close();
        }
    }
}
