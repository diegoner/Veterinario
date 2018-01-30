namespace Veterinario
{
    partial class NuevoDialogoCliente
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
            this.btnGuardar = new System.Windows.Forms.Button();
            this.btnCancelar = new System.Windows.Forms.Button();
            this.tbNombre = new System.Windows.Forms.TextBox();
            this.lblNombre = new System.Windows.Forms.Label();
            this.tbDni = new System.Windows.Forms.TextBox();
            this.lblDni = new System.Windows.Forms.Label();
            this.tbTlf = new System.Windows.Forms.TextBox();
            this.lblTlf = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // btnGuardar
            // 
            this.btnGuardar.Location = new System.Drawing.Point(159, 129);
            this.btnGuardar.Name = "btnGuardar";
            this.btnGuardar.Size = new System.Drawing.Size(75, 23);
            this.btnGuardar.TabIndex = 11;
            this.btnGuardar.Text = "Guardar";
            this.btnGuardar.UseVisualStyleBackColor = true;
            this.btnGuardar.Click += new System.EventHandler(this.btnGuardar_Click);
            // 
            // btnCancelar
            // 
            this.btnCancelar.Location = new System.Drawing.Point(20, 129);
            this.btnCancelar.Name = "btnCancelar";
            this.btnCancelar.Size = new System.Drawing.Size(75, 23);
            this.btnCancelar.TabIndex = 10;
            this.btnCancelar.Text = "Cancelar";
            this.btnCancelar.UseVisualStyleBackColor = true;
            this.btnCancelar.Click += new System.EventHandler(this.btnCancelar_Click);
            // 
            // tbNombre
            // 
            this.tbNombre.Location = new System.Drawing.Point(126, 16);
            this.tbNombre.Name = "tbNombre";
            this.tbNombre.Size = new System.Drawing.Size(100, 20);
            this.tbNombre.TabIndex = 8;
            // 
            // lblNombre
            // 
            this.lblNombre.AutoSize = true;
            this.lblNombre.Location = new System.Drawing.Point(17, 19);
            this.lblNombre.Name = "lblNombre";
            this.lblNombre.Size = new System.Drawing.Size(103, 13);
            this.lblNombre.TabIndex = 6;
            this.lblNombre.Text = "Nombre y Apellidos: ";
            // 
            // tbDni
            // 
            this.tbDni.Location = new System.Drawing.Point(126, 49);
            this.tbDni.Name = "tbDni";
            this.tbDni.Size = new System.Drawing.Size(100, 20);
            this.tbDni.TabIndex = 13;
            // 
            // lblDni
            // 
            this.lblDni.AutoSize = true;
            this.lblDni.Location = new System.Drawing.Point(17, 56);
            this.lblDni.Name = "lblDni";
            this.lblDni.Size = new System.Drawing.Size(32, 13);
            this.lblDni.TabIndex = 12;
            this.lblDni.Text = "DNI: ";
            // 
            // tbTlf
            // 
            this.tbTlf.Location = new System.Drawing.Point(126, 86);
            this.tbTlf.Name = "tbTlf";
            this.tbTlf.Size = new System.Drawing.Size(100, 20);
            this.tbTlf.TabIndex = 15;
            // 
            // lblTlf
            // 
            this.lblTlf.AutoSize = true;
            this.lblTlf.Location = new System.Drawing.Point(17, 93);
            this.lblTlf.Name = "lblTlf";
            this.lblTlf.Size = new System.Drawing.Size(55, 13);
            this.lblTlf.TabIndex = 14;
            this.lblTlf.Text = "Teléfono: ";
            // 
            // NuevoDialogoCliente
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(281, 175);
            this.Controls.Add(this.tbTlf);
            this.Controls.Add(this.lblTlf);
            this.Controls.Add(this.tbDni);
            this.Controls.Add(this.lblDni);
            this.Controls.Add(this.btnGuardar);
            this.Controls.Add(this.btnCancelar);
            this.Controls.Add(this.tbNombre);
            this.Controls.Add(this.lblNombre);
            this.Name = "NuevoDialogoCliente";
            this.Text = "NuevoDialogoCliente";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btnGuardar;
        private System.Windows.Forms.Button btnCancelar;
        private System.Windows.Forms.TextBox tbNombre;
        private System.Windows.Forms.Label lblNombre;
        private System.Windows.Forms.TextBox tbDni;
        private System.Windows.Forms.Label lblDni;
        private System.Windows.Forms.TextBox tbTlf;
        private System.Windows.Forms.Label lblTlf;
    }
}