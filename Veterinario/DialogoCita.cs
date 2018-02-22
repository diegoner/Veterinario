using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

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
    public partial class DialogoCita : Form
    {

        private MySqlConnection conexion;
        private static MySqlCommand comando;
        private String consulta;
        private MySqlDataReader resultado;
        private DataTable datos = new DataTable();
        private static MySqlCommand comando2;
        private String consulta2;
        private MySqlDataReader resultado2;
        private DataTable datos2 = new DataTable();

        public DialogoCita()

        {
            InitializeComponent();
            conexion = new MySqlConnection("Server = 127.0.0.1; Database = veterinario; Uid = root; Pwd =; Port = 3306");
            conexion.Open();
            comando = new MySqlCommand("SELECT dni FROM clientes", conexion);
            resultado = comando.ExecuteReader();
            if (resultado.HasRows)
            {
                while (resultado.Read())
                {
                    cbNombre.Items.Add(Convert.ToString(resultado[0]));
                    resultado.NextResult();
                }
            }
            else
            {
                Console.WriteLine("No rows found.");
            }
            resultado.Close();
            conexion.Close();
        }

        private void btnCancel_Click(object sender, EventArgs e)
        {
            this.Dispose();
        }

        private void dateTimePicker1_ValueChanged(object sender, EventArgs e)
        {

        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void btnCancel_MouseHover(object sender, EventArgs e)
        {
            btnCancel.BackColor = Color.DarkGray;
        }

        private void btnCancel_MouseLeave(object sender, EventArgs e)
        {
            btnCancel.BackColor = Color.Gray;
        }

        private void btnSave_MouseHover(object sender, EventArgs e)
        {
            btnSave.BackColor = Color.DarkGray;
        }

        private void btnSave_MouseLeave(object sender, EventArgs e)
        {
            btnSave.BackColor = Color.Gray;
        }

        private void btnSave_Click(object sender, EventArgs e)
        {
            /*
            conexion.Open();
            comando2 = new MySqlCommand("SELECT name FROM clientes WHERE dni = '" + cbNombre.Text +"'", conexion);
            resultado2 = comando2.ExecuteReader();
            conexion.Close();*/

            conexion.Open();
            comando = new MySqlCommand("INSERT INTO visitas (fecha_visita, nombre_cliente) VALUES ('" + dateTimePicker1.Text + "', '" + cbNombre.Text + "')", conexion);
            resultado = comando.ExecuteReader();
            datos.Load(resultado);

            conexion.Close();
            this.Dispose();
        }
    }
}
