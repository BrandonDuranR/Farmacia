using Microsoft.VisualBasic.ApplicationServices;
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
            llenarComboBox();
        }
        static string conexion = ("SERVER = 127.0.0.1;PORT=3306;DATABASE=farmacia;UID=root;PASSWORD=;");
        MySqlConnection con = new MySqlConnection(conexion);
        private void RegistrarLote_Load(object sender, EventArgs e)
        {

        }

        private void llenarComboBox()
        {
            con.Open();
            string buscarMedicamento = "SELECT NOMBRE, TIPO, CONTENIDO FROM medicamento";
            MySqlCommand cmd = new MySqlCommand(buscarMedicamento, con);
            MySqlDataReader registros = cmd.ExecuteReader();
            while (registros.Read())
            {
                string item = registros["NOMBRE"] + " - " + registros["TIPO"] + " " + registros["CONTENIDO"];
                comboBoxMedicamento.Items.Add(item);
            }
            con.Close();
        }

        private void textBox2_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!char.IsControl(e.KeyChar) && !char.IsDigit(e.KeyChar))
            {
                e.Handled = true;
            }
        }

        private void buttonRegistrar_Click(object sender, EventArgs e)
        {
            string fecha = monthCalendar1.SelectionRange.Start.ToString("yyyy-MM-dd");
            
        }
    }
}
