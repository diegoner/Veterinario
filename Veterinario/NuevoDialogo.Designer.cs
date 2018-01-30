namespace Veterinario
{
    partial class NuevoDialogo
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
            this.lblNombre = new System.Windows.Forms.Label();
            this.lblID = new System.Windows.Forms.Label();
            this.tbNombre = new System.Windows.Forms.TextBox();
            this.tbID = new System.Windows.Forms.TextBox();
            this.btnCancelar = new System.Windows.Forms.Button();
            this.btnGuardar = new System.Windows.Forms.Button();
            this.tbEspecie = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.tbRaza = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.tbChip = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.tbFecha = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // lblNombre
            // 
            this.lblNombre.AutoSize = true;
            this.lblNombre.Location = new System.Drawing.Point(12, 27);
            this.lblNombre.Name = "lblNombre";
            this.lblNombre.Size = new System.Drawing.Size(50, 13);
            this.lblNombre.TabIndex = 0;
            this.lblNombre.Text = "Nombre: ";
            // 
            // lblID
            // 
            this.lblID.AutoSize = true;
            this.lblID.Location = new System.Drawing.Point(12, 157);
            this.lblID.Name = "lblID";
            this.lblID.Size = new System.Drawing.Size(59, 13);
            this.lblID.TabIndex = 1;
            this.lblID.Text = "ID Dueño: ";
            // 
            // tbNombre
            // 
            this.tbNombre.Location = new System.Drawing.Point(95, 20);
            this.tbNombre.Name = "tbNombre";
            this.tbNombre.Size = new System.Drawing.Size(100, 20);
            this.tbNombre.TabIndex = 2;
            // 
            // tbID
            // 
            this.tbID.Location = new System.Drawing.Point(95, 150);
            this.tbID.Name = "tbID";
            this.tbID.Size = new System.Drawing.Size(100, 20);
            this.tbID.TabIndex = 3;
            // 
            // btnCancelar
            // 
            this.btnCancelar.Location = new System.Drawing.Point(12, 192);
            this.btnCancelar.Name = "btnCancelar";
            this.btnCancelar.Size = new System.Drawing.Size(75, 23);
            this.btnCancelar.TabIndex = 4;
            this.btnCancelar.Text = "Cancelar";
            this.btnCancelar.UseVisualStyleBackColor = true;
            this.btnCancelar.Click += new System.EventHandler(this.btnCancelar_Click);
            // 
            // btnGuardar
            // 
            this.btnGuardar.Location = new System.Drawing.Point(152, 192);
            this.btnGuardar.Name = "btnGuardar";
            this.btnGuardar.Size = new System.Drawing.Size(75, 23);
            this.btnGuardar.TabIndex = 5;
            this.btnGuardar.Text = "Guardar";
            this.btnGuardar.UseVisualStyleBackColor = true;
            this.btnGuardar.Click += new System.EventHandler(this.btnGuardar_Click);
            // 
            // tbEspecie
            // 
            this.tbEspecie.Location = new System.Drawing.Point(95, 46);
            this.tbEspecie.Name = "tbEspecie";
            this.tbEspecie.Size = new System.Drawing.Size(100, 20);
            this.tbEspecie.TabIndex = 7;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(12, 53);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(51, 13);
            this.label1.TabIndex = 6;
            this.label1.Text = "Especie: ";
            // 
            // tbRaza
            // 
            this.tbRaza.Location = new System.Drawing.Point(95, 72);
            this.tbRaza.Name = "tbRaza";
            this.tbRaza.Size = new System.Drawing.Size(100, 20);
            this.tbRaza.TabIndex = 9;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(12, 79);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(38, 13);
            this.label2.TabIndex = 8;
            this.label2.Text = "Raza: ";
            // 
            // tbChip
            // 
            this.tbChip.Location = new System.Drawing.Point(95, 98);
            this.tbChip.Name = "tbChip";
            this.tbChip.Size = new System.Drawing.Size(100, 20);
            this.tbChip.TabIndex = 11;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(12, 105);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(34, 13);
            this.label3.TabIndex = 10;
            this.label3.Text = "Chip: ";
            // 
            // tbFecha
            // 
            this.tbFecha.Location = new System.Drawing.Point(95, 124);
            this.tbFecha.Name = "tbFecha";
            this.tbFecha.Size = new System.Drawing.Size(100, 20);
            this.tbFecha.TabIndex = 13;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(12, 131);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(82, 13);
            this.label4.TabIndex = 12;
            this.label4.Text = "Fecha de nac.: ";
            // 
            // NuevoDialogo
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(239, 234);
            this.Controls.Add(this.tbFecha);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.tbChip);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.tbRaza);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.tbEspecie);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.btnGuardar);
            this.Controls.Add(this.btnCancelar);
            this.Controls.Add(this.tbID);
            this.Controls.Add(this.tbNombre);
            this.Controls.Add(this.lblID);
            this.Controls.Add(this.lblNombre);
            this.Name = "NuevoDialogo";
            this.Text = "NuevoDialogo";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lblNombre;
        private System.Windows.Forms.Label lblID;
        private System.Windows.Forms.TextBox tbNombre;
        private System.Windows.Forms.TextBox tbID;
        private System.Windows.Forms.Button btnCancelar;
        private System.Windows.Forms.Button btnGuardar;
        private System.Windows.Forms.TextBox tbEspecie;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox tbRaza;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox tbChip;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox tbFecha;
        private System.Windows.Forms.Label label4;
    }
}