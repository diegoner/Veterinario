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
using System.Drawing.Drawing2D;

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
        private static MySqlCommand comando3;
        private String consulta3;
        private MySqlDataReader resultado3;
        private DataTable datos3 = new DataTable();
        private String modo = "clientes";

        public Principal()
        {
            InitializeComponent();

            conexion = new MySqlConnection("Server = 127.0.0.1; Database = veterinario; Uid = root; Pwd =; Port = 3306; Convert Zero Datetime=True");

            refrescar(modo);
            refrescar("visitas");
        }

        private void btnClientes_Click(object sender, EventArgs e)
        {
            
        }

        private void btnClientes_MouseHover(object sender, EventArgs e)
        {
            
            btnClientes.BackColor = Color.DimGray;
        }

        private void btnClientes_MouseLeave(object sender, EventArgs e)
        {
            
            btnClientes.BackColor = Color.Black;
        }

        private void btnMascotas_Click(object sender, EventArgs e)
        {
            
        }

        private void btnMascotas_MouseHover(object sender, EventArgs e)
        {
            //btnMascotas.Size = new Size(278, 53);
            btnMascotas.BackColor = Color.DimGray;
        }

        private void btnMascotas_MouseLeave(object sender, EventArgs e)
        {
            //btnMascotas.Size = new Size(275, 50);
            btnMascotas.BackColor = Color.Black;
        }


        private void btnTienda_MouseHover(object sender, EventArgs e)
        {
            //btnTienda.Size = new Size(278, 53);
            btnTienda.BackColor = Color.DimGray;
        }

        private void btnTienda_MouseLeave(object sender, EventArgs e)
        {
            //btnTienda.Size = new Size(275, 50);
            btnTienda.BackColor = Color.Black;
        }

        private void btnNuevo_MouseHover(object sender, EventArgs e)
        {
            //btnNuevo.Size = new Size(278, 53);
            btnNuevo.BackColor = Color.DimGray;
        }

        private void btnNuevo_MouseLeave(object sender, EventArgs e)
        {
            //btnNuevo.Size = new Size(275, 50);
            btnNuevo.BackColor = Color.Black;
        }


        public void refrescar(String modo)
        {
            switch (modo) {
                case "clientes":
                    conexion.Open();
                    comando = new MySqlCommand("SELECT * FROM clientes", conexion);
                    resultado = comando.ExecuteReader();
                    datos.Load(resultado);
                    conexion.Close();
                    dataGridView1.DataSource = datos;
                    break;

                case "mascotas":
                    conexion.Open();
                    comando2 = new MySqlCommand("SELECT * FROM mascotas", conexion);
                    resultado2 = comando2.ExecuteReader();
                    datos2.Load(resultado2);
                    conexion.Close();
                    dataGridView1.DataSource = datos2;
                    break;
                case "visitas":
                    conexion.Open();
                    comando3 = new MySqlCommand("SELECT * FROM visitas", conexion);
                    resultado3 = comando3.ExecuteReader();
                    datos3.Load(resultado3);
                    conexion.Close();
                    dataGridView2.DataSource = datos3;
                    break;
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

        private void btnNuevo_Click(object sender, EventArgs e)
        {
            if (modo == "clientes")
            {
                NuevoDialogoCliente dialogoCliente = new NuevoDialogoCliente();
                dialogoCliente.Show();
            }
            else if ((modo == "mascotas"))
            {
                NuevoDialogo dialogoMascota = new NuevoDialogo();
                dialogoMascota.Show();
            }
        }

        private void btnClientes_Click_1(object sender, EventArgs e)
        {
            modo = "clientes";
            refrescar(modo);
        }

        private void btnMascotas_Click_1(object sender, EventArgs e)
        {
            modo = "mascotas";
            refrescar(modo);
        }

        private void btnTienda_Click(object sender, EventArgs e)
        {
            System.Diagnostics.Process.Start(fileName: @"http://localhost/Tienda/inicio.php");
        }

        private void btnCita_Click(object sender, EventArgs e)
        {
            DialogoCita dialogoCita = new DialogoCita();
            dialogoCita.Show();
        }

        private void pictureBox3_Click(object sender, EventArgs e)
        {
            //sonido al pulsar el perro
        }

        private void btnCita_MouseHover(object sender, EventArgs e)
        {
            btnCita.BackColor = Color.DimGray;
        }

        private void btnCita_MouseLeave(object sender, EventArgs e)
        {
            btnCita.BackColor = Color.Black;
        }

        private void dataGridView2_Click(object sender, EventArgs e)
        {
            refrescar("visitas");
        }

        private void dataGridView2_CellClick(object sender, DataGridViewCellEventArgs e)
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
                    if (cell.Value.ToString().Equals(dataGridView2.CurrentCell.Value.ToString()))
                    {
                        containingCells.Add(cell);
                    }
                }
            }
            if (containingCells.Count > 0)
                dataGridView1.CurrentCell =
                        containingCells[currentContainingCellListIndex++];
        }

        private void btnTienda_Paint(object sender, PaintEventArgs e)
        {
           
        }
    }
}
