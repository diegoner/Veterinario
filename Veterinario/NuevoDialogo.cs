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
    public partial class NuevoDialogo : Form
    {

        private MySqlConnection conexion;
        private static MySqlCommand comando;
        private String consulta;
        private MySqlDataReader resultado;
        private DataTable datos = new DataTable();
        private int numMascotas;

        public NuevoDialogo()
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
                    cbPropietario.Items.Add(Convert.ToString(resultado[0]));
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

        private void btnGuardar_Click(object sender, EventArgs e)
        {
            conexion.Open();
            comando = new MySqlCommand("INSERT INTO mascotas (chip, nombre, especie, raza, fecha_nac, id_propietario) VALUES (" + tbChip.Text + ", '" + tbNombre.Text + "', '" + tbEspecie.Text + "', '" + tbRaza.Text + "', " + tbFecha.Text + ", '" + cbPropietario.Text + "')", conexion);
            comando.ExecuteReader();
            conexion.Close();
            conexion.Open();
            comando = new MySqlCommand("SELECT num_mascotas FROM clientes WHERE DNI = " + Int32.Parse(cbPropietario.Text), conexion);
            resultado = comando.ExecuteReader();
            if (resultado.Read()) { numMascotas = resultado.GetInt32(0) + 1; }
            conexion.Close();
            conexion.Open();
            comando = new MySqlCommand("UPDATE clientes SET num_mascotas=" + numMascotas + " WHERE id_cliente = " + cbPropietario.Text , conexion);
            conexion.Close();
            this.Dispose();
        }

        private void btnCancelar_Click(object sender, EventArgs e)
        {
            this.Dispose();
        }
    }
}
