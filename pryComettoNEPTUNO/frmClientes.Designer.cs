namespace pryComettoNEPTUNO
{
    partial class frmClientes
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
            this.dgvClientes = new System.Windows.Forms.DataGridView();
            this.idCliente = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Nombre_Compania = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Nombre_Contacto = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Cargo_Contacto = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Direccion = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Ciudad = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Region = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Codigo_Postal = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Pais = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Telefono = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Fax = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.btnListar = new System.Windows.Forms.Button();
            this.lblListado = new System.Windows.Forms.Label();
            this.btnSalir = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.dgvClientes)).BeginInit();
            this.SuspendLayout();
            // 
            // dgvClientes
            // 
            this.dgvClientes.AllowUserToAddRows = false;
            this.dgvClientes.AllowUserToDeleteRows = false;
            this.dgvClientes.AllowUserToOrderColumns = true;
            this.dgvClientes.AllowUserToResizeColumns = false;
            this.dgvClientes.AllowUserToResizeRows = false;
            this.dgvClientes.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.DisplayedCells;
            this.dgvClientes.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvClientes.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.idCliente,
            this.Nombre_Compania,
            this.Nombre_Contacto,
            this.Cargo_Contacto,
            this.Direccion,
            this.Ciudad,
            this.Region,
            this.Codigo_Postal,
            this.Pais,
            this.Telefono,
            this.Fax});
            this.dgvClientes.Location = new System.Drawing.Point(12, 61);
            this.dgvClientes.Name = "dgvClientes";
            this.dgvClientes.RowHeadersVisible = false;
            this.dgvClientes.Size = new System.Drawing.Size(699, 252);
            this.dgvClientes.TabIndex = 1;
            // 
            // idCliente
            // 
            this.idCliente.HeaderText = "Id. de Cliente";
            this.idCliente.Name = "idCliente";
            this.idCliente.Width = 87;
            // 
            // Nombre_Compania
            // 
            this.Nombre_Compania.HeaderText = "Nombre de compañia";
            this.Nombre_Compania.Name = "Nombre_Compania";
            this.Nombre_Compania.Width = 122;
            // 
            // Nombre_Contacto
            // 
            this.Nombre_Contacto.HeaderText = "Nombre del contacto";
            this.Nombre_Contacto.Name = "Nombre_Contacto";
            this.Nombre_Contacto.Width = 120;
            // 
            // Cargo_Contacto
            // 
            this.Cargo_Contacto.HeaderText = "Cargo del contacto";
            this.Cargo_Contacto.Name = "Cargo_Contacto";
            this.Cargo_Contacto.Width = 112;
            // 
            // Direccion
            // 
            this.Direccion.HeaderText = "Dirección";
            this.Direccion.Name = "Direccion";
            this.Direccion.Width = 77;
            // 
            // Ciudad
            // 
            this.Ciudad.HeaderText = "Ciudad";
            this.Ciudad.Name = "Ciudad";
            this.Ciudad.Width = 65;
            // 
            // Region
            // 
            this.Region.HeaderText = "Región";
            this.Region.Name = "Region";
            this.Region.Width = 66;
            // 
            // Codigo_Postal
            // 
            this.Codigo_Postal.HeaderText = "Código Postal";
            this.Codigo_Postal.Name = "Codigo_Postal";
            this.Codigo_Postal.Width = 89;
            // 
            // Pais
            // 
            this.Pais.HeaderText = "País";
            this.Pais.Name = "Pais";
            this.Pais.Width = 54;
            // 
            // Telefono
            // 
            this.Telefono.HeaderText = "Teléfono";
            this.Telefono.Name = "Telefono";
            this.Telefono.Width = 74;
            // 
            // Fax
            // 
            this.Fax.HeaderText = "Fax";
            this.Fax.Name = "Fax";
            this.Fax.Width = 49;
            // 
            // btnListar
            // 
            this.btnListar.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(255)))), ((int)(((byte)(192)))));
            this.btnListar.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(255)))), ((int)(((byte)(192)))));
            this.btnListar.FlatAppearance.BorderSize = 0;
            this.btnListar.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.btnListar.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnListar.Location = new System.Drawing.Point(608, 329);
            this.btnListar.Name = "btnListar";
            this.btnListar.Size = new System.Drawing.Size(103, 36);
            this.btnListar.TabIndex = 0;
            this.btnListar.Text = "Listar";
            this.btnListar.UseVisualStyleBackColor = false;
            this.btnListar.Click += new System.EventHandler(this.btnListar_Click);
            // 
            // lblListado
            // 
            this.lblListado.AutoSize = true;
            this.lblListado.Font = new System.Drawing.Font("Microsoft Sans Serif", 20F, System.Drawing.FontStyle.Underline, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblListado.Location = new System.Drawing.Point(261, 10);
            this.lblListado.Name = "lblListado";
            this.lblListado.Size = new System.Drawing.Size(245, 31);
            this.lblListado.TabIndex = 2;
            this.lblListado.Text = "Listado de Clientes";
            // 
            // btnSalir
            // 
            this.btnSalir.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            this.btnSalir.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.btnSalir.Location = new System.Drawing.Point(12, 329);
            this.btnSalir.Name = "btnSalir";
            this.btnSalir.Size = new System.Drawing.Size(101, 36);
            this.btnSalir.TabIndex = 6;
            this.btnSalir.Text = "Volver";
            this.btnSalir.UseVisualStyleBackColor = false;
            this.btnSalir.Click += new System.EventHandler(this.btnSalir_Click);
            // 
            // frmClientes
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(721, 375);
            this.Controls.Add(this.btnSalir);
            this.Controls.Add(this.lblListado);
            this.Controls.Add(this.btnListar);
            this.Controls.Add(this.dgvClientes);
            this.Name = "frmClientes";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Listado de Clientes - NEPTUNO";
            ((System.ComponentModel.ISupportInitialize)(this.dgvClientes)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DataGridView dgvClientes;
        private System.Windows.Forms.DataGridViewTextBoxColumn idCliente;
        private System.Windows.Forms.DataGridViewTextBoxColumn Nombre_Compania;
        private System.Windows.Forms.DataGridViewTextBoxColumn Nombre_Contacto;
        private System.Windows.Forms.DataGridViewTextBoxColumn Cargo_Contacto;
        private System.Windows.Forms.DataGridViewTextBoxColumn Direccion;
        private System.Windows.Forms.DataGridViewTextBoxColumn Ciudad;
        private System.Windows.Forms.DataGridViewTextBoxColumn Region;
        private System.Windows.Forms.DataGridViewTextBoxColumn Codigo_Postal;
        private System.Windows.Forms.DataGridViewTextBoxColumn Pais;
        private System.Windows.Forms.DataGridViewTextBoxColumn Telefono;
        private System.Windows.Forms.DataGridViewTextBoxColumn Fax;
        private System.Windows.Forms.Button btnListar;
        private System.Windows.Forms.Label lblListado;
        private System.Windows.Forms.Button btnSalir;
    }
}