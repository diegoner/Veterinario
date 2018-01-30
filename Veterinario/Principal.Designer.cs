namespace Veterinario
{
    partial class Principal
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.btnNuevo = new System.Windows.Forms.Button();
            this.lblBuscar = new System.Windows.Forms.Label();
            this.tbBuscar = new System.Windows.Forms.TextBox();
            this.btnClientes = new System.Windows.Forms.Button();
            this.btnMascotas = new System.Windows.Forms.Button();
            this.btnTienda = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.SuspendLayout();
            // 
            // dataGridView1
            // 
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Location = new System.Drawing.Point(12, 91);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.Size = new System.Drawing.Size(334, 295);
            this.dataGridView1.TabIndex = 0;
            // 
            // btnNuevo
            // 
            this.btnNuevo.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnNuevo.Location = new System.Drawing.Point(238, 46);
            this.btnNuevo.Name = "btnNuevo";
            this.btnNuevo.Size = new System.Drawing.Size(108, 39);
            this.btnNuevo.TabIndex = 1;
            this.btnNuevo.Text = "Nuevo";
            this.btnNuevo.UseVisualStyleBackColor = true;
            this.btnNuevo.Click += new System.EventHandler(this.btnNuevo_Click);
            // 
            // lblBuscar
            // 
            this.lblBuscar.AutoSize = true;
            this.lblBuscar.Location = new System.Drawing.Point(34, 59);
            this.lblBuscar.Name = "lblBuscar";
            this.lblBuscar.Size = new System.Drawing.Size(46, 13);
            this.lblBuscar.TabIndex = 2;
            this.lblBuscar.Text = "Buscar: ";
            // 
            // tbBuscar
            // 
            this.tbBuscar.Location = new System.Drawing.Point(87, 56);
            this.tbBuscar.Name = "tbBuscar";
            this.tbBuscar.Size = new System.Drawing.Size(100, 20);
            this.tbBuscar.TabIndex = 3;
            this.tbBuscar.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.textBox1_KeyPress);
            // 
            // btnClientes
            // 
            this.btnClientes.Location = new System.Drawing.Point(16, 12);
            this.btnClientes.Name = "btnClientes";
            this.btnClientes.Size = new System.Drawing.Size(105, 23);
            this.btnClientes.TabIndex = 4;
            this.btnClientes.Text = "Clientes";
            this.btnClientes.UseVisualStyleBackColor = true;
            this.btnClientes.Click += new System.EventHandler(this.btnClientes_Click);
            // 
            // btnMascotas
            // 
            this.btnMascotas.Location = new System.Drawing.Point(127, 12);
            this.btnMascotas.Name = "btnMascotas";
            this.btnMascotas.Size = new System.Drawing.Size(105, 23);
            this.btnMascotas.TabIndex = 5;
            this.btnMascotas.Text = "Mascotas";
            this.btnMascotas.UseVisualStyleBackColor = true;
            this.btnMascotas.Click += new System.EventHandler(this.btnMascotas_Click);
            // 
            // btnTienda
            // 
            this.btnTienda.Location = new System.Drawing.Point(238, 12);
            this.btnTienda.Name = "btnTienda";
            this.btnTienda.Size = new System.Drawing.Size(105, 23);
            this.btnTienda.TabIndex = 6;
            this.btnTienda.Text = "Tienda";
            this.btnTienda.UseVisualStyleBackColor = true;
            // 
            // Principal
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(356, 398);
            this.Controls.Add(this.btnTienda);
            this.Controls.Add(this.btnMascotas);
            this.Controls.Add(this.btnClientes);
            this.Controls.Add(this.tbBuscar);
            this.Controls.Add(this.lblBuscar);
            this.Controls.Add(this.btnNuevo);
            this.Controls.Add(this.dataGridView1);
            this.Name = "Principal";
            this.Text = "Principal";
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.Button btnNuevo;
        private System.Windows.Forms.Label lblBuscar;
        private System.Windows.Forms.TextBox tbBuscar;
        private System.Windows.Forms.Button btnClientes;
        private System.Windows.Forms.Button btnMascotas;
        private System.Windows.Forms.Button btnTienda;
    }
}