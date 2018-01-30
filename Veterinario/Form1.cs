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
    public partial class Form1 : Form
    {
        private MySqlConnection conexion;
        private static MySqlCommand comando;
        private String consulta;
        private MySqlDataReader resultado;
        Principal nuevaVentana = new Principal();
        private Control picturebox1;

        public Form1()
        {
            InitializeComponent();
            Application.EnableVisualStyles();

            conexion = new MySqlConnection("Server = 127.0.0.1; Database = veterinario; Uid = root; Pwd =; Port = 3306");

        }

        private void btnLog_Click(object sender, EventArgs e)
        {
            conexion.Open();
            comando = new MySqlCommand("SELECT * FROM usuarios", conexion);
            resultado = comando.ExecuteReader();
            while (resultado.Read())
            {
                if (tbUser.Text == Convert.ToString(resultado[1]) && tbPass.Text == Convert.ToString(resultado[2]))
                {

                    nuevaVentana.Show();
                    this.Hide();
                }
                else
                {
                    lblError.Visible = true;
                    tbPass.Text = "";
                }
            }
            conexion.Close();
        }

        private void tbPass_KeyPress(object sender, KeyPressEventArgs e)
        {
            if(e.KeyChar == Convert.ToChar(Keys.Enter))
            {
                conexion.Open();
                comando = new MySqlCommand("SELECT * FROM usuarios", conexion);
                resultado = comando.ExecuteReader();
                while (resultado.Read())
                {
                    if (tbUser.Text == Convert.ToString(resultado[1]) && tbPass.Text == Convert.ToString(resultado[2]))
                    {
                        
                        nuevaVentana.Show();
                        this.Hide();
                    }
                    else
                    {
                        lblError.Visible = true;
                        tbPass.Text = "";
                    }
                }
                conexion.Close();
            }
        }

        private void button1_Click(object sender, EventArgs e)
        {
            //Width = 600;
            //button2.Visible = true;
            //button1.Visible = true;

        }
    }
}
