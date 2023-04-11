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
    public partial class MostrarStrock : Form
    {
        public MostrarStrock()
        {
            InitializeComponent();
        }
        static string conexion = ("SERVER = 127.0.0.1;PORT=3306;DATABASE=farmacia;UID=root;PASSWORD=;");
        MySqlConnection con = new MySqlConnection(conexion);
        public DataTable llenarTabla()
        {
            con.Open();
            DataTable dt = new DataTable();
            string llenar = ("SELECT productos.NOMBRE, almacen.STOCK FROM productos INNER JOIN almacen ON productos.ID_PRODUCTO = almacen.ID_PRODUCTO");
            MySqlCommand cmd = new MySqlCommand(llenar, con);
            MySqlDataAdapter dataAdapter = new MySqlDataAdapter(cmd);
            dataAdapter.Fill(dt);
            con.Close();
            return dt;
        }
        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            
            
        }

        private void MostrarStrock_Load(object sender, EventArgs e)
        {
            dataGridView1.DataSource = llenarTabla();
        }

        private void btnCancelar_Click(object sender, EventArgs e)
        {
            panelAmlacen panelAmlacen = new panelAmlacen();
            panelAmlacen.Show();
            this.Close();
        }
    }
}
