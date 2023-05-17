namespace pryComettoNEPTUNO
{
    partial class frmMenu
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
            this.btnListadoClientes = new System.Windows.Forms.Button();
            this.mrcConsultas = new System.Windows.Forms.GroupBox();
            this.btnSalir = new System.Windows.Forms.Button();
            this.mrcConsultas.SuspendLayout();
            this.SuspendLayout();
            // 
            // btnListadoClientes
            // 
            this.btnListadoClientes.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            this.btnListadoClientes.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.btnListadoClientes.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnListadoClientes.Location = new System.Drawing.Point(18, 29);
            this.btnListadoClientes.Name = "btnListadoClientes";
            this.btnListadoClientes.Size = new System.Drawing.Size(131, 49);
            this.btnListadoClientes.TabIndex = 0;
            this.btnListadoClientes.Text = "Listado de Clientes";
            this.btnListadoClientes.UseVisualStyleBackColor = false;
            this.btnListadoClientes.Click += new System.EventHandler(this.btnListadoClientes_Click);
            // 
            // mrcConsultas
            // 
            this.mrcConsultas.Controls.Add(this.btnListadoClientes);
            this.mrcConsultas.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.mrcConsultas.Location = new System.Drawing.Point(12, 12);
            this.mrcConsultas.Name = "mrcConsultas";
            this.mrcConsultas.Size = new System.Drawing.Size(311, 267);
            this.mrcConsultas.TabIndex = 1;
            this.mrcConsultas.TabStop = false;
            this.mrcConsultas.Text = "Consultas";
            // 
            // btnSalir
            // 
            this.btnSalir.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(192)))), ((int)(((byte)(192)))));
            this.btnSalir.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.btnSalir.Location = new System.Drawing.Point(12, 288);
            this.btnSalir.Name = "btnSalir";
            this.btnSalir.Size = new System.Drawing.Size(75, 23);
            this.btnSalir.TabIndex = 6;
            this.btnSalir.Text = "Salir";
            this.btnSalir.UseVisualStyleBackColor = false;
            this.btnSalir.Click += new System.EventHandler(this.btnSalir_Click);
            // 
            // frmMenu
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(335, 323);
            this.Controls.Add(this.btnSalir);
            this.Controls.Add(this.mrcConsultas);
            this.Name = "frmMenu";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Menú - NEPTUNO";
            this.mrcConsultas.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button btnListadoClientes;
        private System.Windows.Forms.GroupBox mrcConsultas;
        private System.Windows.Forms.Button btnSalir;
    }
}