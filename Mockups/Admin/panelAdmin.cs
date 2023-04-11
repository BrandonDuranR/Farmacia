﻿using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Farmacia;
using Mockups.Properties;
using MySql.Data.MySqlClient;

namespace Mockups
{
    public partial class PanelAdmin : Form
    {
        public PanelAdmin()
        {
            InitializeComponent();
        }
        static string conexion = ("SERVER = 127.0.0.1;PORT=3306;DATABASE=farmacia;UID=root;PASSWORD=;");
        MySqlConnection con = new MySqlConnection(conexion);
        private void PanelAdmin_Load(object sender, EventArgs e)
        {
            dataGridView1.DataSource = llenarTabla();

        }
        public DataTable llenarTabla()
        {
            con.Open();
            DataTable dt = new DataTable();
            string llenar = ("SELECT * FROM `usuario`");
            MySqlCommand cmd = new MySqlCommand(llenar, con);
            MySqlDataAdapter dataAdapter = new MySqlDataAdapter(cmd);
            dataAdapter.Fill(dt);
            con.Close();
            return dt;

        }
        private void agregarUsuarioToolStripMenuItem_Click(object sender, EventArgs e)
        {

        }

        private void agregarToolStripMenuItem_Click(object sender, EventArgs e) //Agregar
        {
            RegistroUser registro = new RegistroUser();
            registro.Show();
            this.Close();
        }

        private void modificarToolStripMenuItem_Click(object sender, EventArgs e) //Modificar
        {
            EditarUsuario editar = new EditarUsuario();
            editar.Show();
            this.Close();
        }

        private void eliminarToolStripMenuItem_Click(object sender, EventArgs e) //eliminar
        {
            Eliminar eliminar = new Eliminar();
            eliminar.Show();
            this.Close();
        }
    }
}
