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
    public partial class panelAmlacen : Form
    {
        public panelAmlacen()
        {
            InitializeComponent();
        }
        static string conexion = ("SERVER = 127.0.0.1;PORT=3306;DATABASE=farmacia;UID=root;PASSWORD=;");
        MySqlConnection con = new MySqlConnection(conexion);
        private void agregarToolStripMenuItem_Click(object sender, EventArgs e) //Agregar producto
        {

        }

        private void agregarUsuarioToolStripMenuItem_Click(object sender, EventArgs e)
        {

        }

        private void registrarMedicamentoToolStripMenuItem_Click(object sender, EventArgs e)
        {

        }

        private void panelAmlacen_Load(object sender, EventArgs e)
        {
           
        }
        public DataTable llenarTabla()
        {
            con.Open();
            DataTable dt = new DataTable();
            string llenar = ("SELECT * FROM `almacen`");
            MySqlCommand cmd = new MySqlCommand(llenar, con);
            MySqlDataAdapter dataAdapter = new MySqlDataAdapter(cmd);
            dataAdapter.Fill(dt);
            con.Close();
            return dt;
        }

        private void panelAmlacen_Load_1(object sender, EventArgs e)
        {
            dataGridView1.DataSource = llenarTabla();
        }

        private void eliminarToolStripMenuItem_Click(object sender, EventArgs e)
        {

        }

        private void modificarToolStripMenuItem_Click(object sender, EventArgs e)
        {

        }

        private void agregarUsuarioToolStripMenuItem_Click_1(object sender, EventArgs e)
        {

        }

        private void registrarLoteToolStripMenuItem_Click(object sender, EventArgs e)
        {
            RegistrarLote lote = new RegistrarLote();
            lote.Show();
            this.Close();
            con.Close();
        }

        private void registrarMedicamentoToolStripMenuItem_Click_1(object sender, EventArgs e)
        {
            AgregarMedicamento medicamento = new AgregarMedicamento();
            medicamento.Show();
            this.Close();
        }
    }
}
