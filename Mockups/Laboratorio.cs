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
    public partial class Laboratorio : Form
    {
        public Laboratorio()
        {
            InitializeComponent();
        }
        static string conexion = ("SERVER = 127.0.0.1;PORT=3306;DATABASE=farmacia;UID=root;PASSWORD=;");
        MySqlConnection con = new MySqlConnection(conexion);
        private void btnRegistrar_Click(object sender, EventArgs e)
        {
            con.Open();
            string insertar = "INSERT INTO laboratorio(NOMBRE) VALUES (@NOMBRE)";
            MySqlCommand cmd = new MySqlCommand(insertar, con);
            if (string.IsNullOrEmpty(txtNombreLab.Text))
            {
                MessageBox.Show("El campo esta vacio");
                con.Close();
            }
            else
            {
                cmd.Parameters.AddWithValue("@NOMBRE", txtNombreLab.Text);
                cmd.ExecuteNonQuery();
                MessageBox.Show("Producto Agregado Exitosamente");

                PanelAdmin panel = new PanelAdmin();
                panel.Show();
                this.Close();
                con.Close();
            }
            con.Close();
        }

        private void btnCancelar_Click(object sender, EventArgs e)
        {
            PanelAdmin panelAdmin   = new PanelAdmin();
            panelAdmin.Show(); 
            this.Close();
        }
    }
}
