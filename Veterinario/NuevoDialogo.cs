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

        }

        private void btnGuardar_Click(object sender, EventArgs e)
        {
            conexion.Open();
            comando = new MySqlCommand("INSERT INTO mascotas (chip, nombre, especie, raza, fecha_nac, id_propietario) VALUES (" + tbChip.Text + ", '" + tbNombre.Text + "', '" + tbEspecie.Text + "', '" + tbRaza.Text + "', " + tbFecha.Text + ", '" + tbID.Text + "')", conexion);
            comando.ExecuteReader();
            conexion.Close();
            conexion.Open();
            comando = new MySqlCommand("SELECT num_mascotas FROM clientes WHERE DNI = " + Int32.Parse(tbID.Text), conexion);
            resultado = comando.ExecuteReader();
            if (resultado.Read()) { numMascotas = resultado.GetInt32(0) + 1; }
            conexion.Close();
            conexion.Open();
            comando = new MySqlCommand("UPDATE clientes SET num_mascotas=" + numMascotas + " WHERE id_cliente = " + tbID.Text , conexion);
            conexion.Close();
            this.Dispose();
        }

        private void btnCancelar_Click(object sender, EventArgs e)
        {
            this.Dispose();
        }
    }
}
