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
    public partial class Principal : Form
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
        private String modo = "clientes";

        public Principal()
        {
            InitializeComponent();

            conexion = new MySqlConnection("Server = 127.0.0.1; Database = veterinario; Uid = root; Pwd =; Port = 3306");

            refrescar(modo);

        }

        private void btnClientes_Click(object sender, EventArgs e)
        {
            modo = "clientes";
            refrescar(modo);
        }

        private void btnMascotas_Click(object sender, EventArgs e)
        {
            modo = "mascotas";
            refrescar(modo);
        }

        private void btnNuevo_Click(object sender, EventArgs e)
        {
            
            if (modo == "clientes")
            {
                NuevoDialogoCliente dialogoCliente = new NuevoDialogoCliente();
                dialogoCliente.Show();
            }else if( (modo == "mascotas"))
            {
                NuevoDialogo dialogoMascota = new NuevoDialogo();
                dialogoMascota.Show();
            }
        }

        public void refrescar(String modo)
        {
            if(modo == "clientes")
            {
                conexion.Open();
                comando = new MySqlCommand("SELECT * FROM clientes", conexion);
                resultado = comando.ExecuteReader();
                datos.Load(resultado);

                conexion.Close();
                dataGridView1.DataSource = datos;
            }
            else if(modo == "mascotas")
            {
                conexion.Open();
                comando2 = new MySqlCommand("SELECT * FROM mascotas", conexion);
                resultado2 = comando2.ExecuteReader();
                datos2.Load(resultado2);
                conexion.Close();
                dataGridView1.DataSource = datos2;
            }
        }

        private void textBox1_KeyPress(object sender, KeyPressEventArgs e)
        {
            
            List<DataGridViewCell> containingCells = new List<DataGridViewCell>();
            int currentContainingCellListIndex = 0;
            //In Event handler of Find button iterate all the rows and cells in 
            //each row to find the cells containing the required text
            //if found add that to the containingCells List   
                containingCells.Clear();
                currentContainingCellListIndex = 0;
                foreach (DataGridViewRow row in dataGridView1.Rows)
                {
                    foreach (DataGridViewCell cell in row.Cells)
                    {
                        if (cell.Value == DBNull.Value || cell.Value == null)
                            continue;
                        if (cell.Value.ToString().Contains(tbBuscar.Text))
                        {
                            containingCells.Add(cell);
                        }
                    }
                }
                if (containingCells.Count > 0)
                    dataGridView1.CurrentCell =
                            containingCells[currentContainingCellListIndex++];
            
        }
    }
}
