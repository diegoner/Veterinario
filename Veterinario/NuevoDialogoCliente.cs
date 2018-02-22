using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data.Odbc;
using MySql.Data.Types;
using MySql.Data.MySqlClient;

namespace Veterinario
{
    public partial class NuevoDialogoCliente : Form
    {
        private MySqlConnection conexion;
        private static MySqlCommand comando;
        private String consulta;
        private MySqlDataReader resultado;
        private DataTable datos = new DataTable();

        public NuevoDialogoCliente()
        {
            InitializeComponent();
            conexion = new MySqlConnection("Server = 127.0.0.1; Database = veterinario; Uid = root; Pwd =; Port = 3306");

        }

        private void btnGuardar_Click(object sender, EventArgs e)
        {
            conexion.Open();
            comando = new MySqlCommand("INSERT INTO clientes (dni, name, telefono, num_mascotas) VALUES ('" + tbDni.Text + "', '" + tbNombre.Text + "', " + tbTlf.Text + ", " + 0 + ")", conexion);
            comando.ExecuteReader();
            conexion.Close();
            this.Dispose();
        }

        private void btnCancelar_Click(object sender, EventArgs e)
        {
            this.Dispose();
        }

        private void btnCancelar_MouseHover(object sender, EventArgs e)
        {
            btnCancelar.BackColor = Color.DarkGray;
        }

        private void btnCancelar_MouseLeave(object sender, EventArgs e)
        {
            btnCancelar.BackColor = Color.Gray;
        }

        private void btnGuardar_MouseHover(object sender, EventArgs e)
        {
            btnGuardar.BackColor = Color.DarkGray;
        }

        private void btnGuardar_MouseLeave(object sender, EventArgs e)
        {
            btnGuardar.BackColor = Color.Gray;
        }
    }
}
