namespace pryComettoNEPTUNO
{
    partial class frmPedidos
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmPedidos));
            this.mrcFiltros = new System.Windows.Forms.GroupBox();
            this.cmbPedido = new System.Windows.Forms.ComboBox();
            this.lblPedido = new System.Windows.Forms.Label();
            this.dgvPedidos = new System.Windows.Forms.DataGridView();
            this.idPedido = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Producto = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.PrecioPorUnidad = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Cantidad = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Descuento = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.mrcFiltros.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvPedidos)).BeginInit();
            this.SuspendLayout();
            // 
            // mrcFiltros
            // 
            this.mrcFiltros.Controls.Add(this.cmbPedido);
            this.mrcFiltros.Controls.Add(this.lblPedido);
            this.mrcFiltros.Location = new System.Drawing.Point(12, 12);
            this.mrcFiltros.Name = "mrcFiltros";
            this.mrcFiltros.Size = new System.Drawing.Size(183, 46);
            this.mrcFiltros.TabIndex = 9;
            this.mrcFiltros.TabStop = false;
            this.mrcFiltros.Text = "Filtros";
            // 
            // cmbPedido
            // 
            this.cmbPedido.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cmbPedido.FormattingEnabled = true;
            this.cmbPedido.Location = new System.Drawing.Point(55, 18);
            this.cmbPedido.Name = "cmbPedido";
            this.cmbPedido.Size = new System.Drawing.Size(121, 21);
            this.cmbPedido.Sorted = true;
            this.cmbPedido.TabIndex = 11;
            this.cmbPedido.SelectedIndexChanged += new System.EventHandler(this.cmbPedido_SelectedIndexChanged);
            // 
            // lblPedido
            // 
            this.lblPedido.AutoSize = true;
            this.lblPedido.Location = new System.Drawing.Point(6, 21);
            this.lblPedido.Name = "lblPedido";
            this.lblPedido.Size = new System.Drawing.Size(43, 13);
            this.lblPedido.TabIndex = 9;
            this.lblPedido.Text = "Pedido:";
            // 
            // dgvPedidos
            // 
            this.dgvPedidos.AllowUserToAddRows = false;
            this.dgvPedidos.AllowUserToDeleteRows = false;
            this.dgvPedidos.AllowUserToResizeColumns = false;
            this.dgvPedidos.AllowUserToResizeRows = false;
            this.dgvPedidos.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dgvPedidos.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvPedidos.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.idPedido,
            this.Producto,
            this.PrecioPorUnidad,
            this.Cantidad,
            this.Descuento});
            this.dgvPedidos.Location = new System.Drawing.Point(12, 64);
            this.dgvPedidos.Name = "dgvPedidos";
            this.dgvPedidos.ReadOnly = true;
            this.dgvPedidos.RowHeadersVisible = false;
            this.dgvPedidos.Size = new System.Drawing.Size(349, 220);
            this.dgvPedidos.TabIndex = 10;
            // 
            // idPedido
            // 
            this.idPedido.HeaderText = "Id. de pedido";
            this.idPedido.Name = "idPedido";
            this.idPedido.ReadOnly = true;
            // 
            // Producto
            // 
            this.Producto.HeaderText = "Producto";
            this.Producto.Name = "Producto";
            this.Producto.ReadOnly = true;
            // 
            // PrecioPorUnidad
            // 
            this.PrecioPorUnidad.HeaderText = "Precio por unidad";
            this.PrecioPorUnidad.Name = "PrecioPorUnidad";
            this.PrecioPorUnidad.ReadOnly = true;
            // 
            // Cantidad
            // 
            this.Cantidad.HeaderText = "Cantidad";
            this.Cantidad.Name = "Cantidad";
            this.Cantidad.ReadOnly = true;
            // 
            // Descuento
            // 
            this.Descuento.HeaderText = "Descuento";
            this.Descuento.Name = "Descuento";
            this.Descuento.ReadOnly = true;
            // 
            // frmPedidos
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(369, 294);
            this.Controls.Add(this.dgvPedidos);
            this.Controls.Add(this.mrcFiltros);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "frmPedidos";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Pedidos - NEPTUNO";
            this.Load += new System.EventHandler(this.frmPedidos_Load);
            this.mrcFiltros.ResumeLayout(false);
            this.mrcFiltros.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvPedidos)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.GroupBox mrcFiltros;
        private System.Windows.Forms.ComboBox cmbPedido;
        private System.Windows.Forms.Label lblPedido;
        private System.Windows.Forms.DataGridView dgvPedidos;
        private System.Windows.Forms.DataGridViewTextBoxColumn idPedido;
        private System.Windows.Forms.DataGridViewTextBoxColumn Producto;
        private System.Windows.Forms.DataGridViewTextBoxColumn PrecioPorUnidad;
        private System.Windows.Forms.DataGridViewTextBoxColumn Cantidad;
        private System.Windows.Forms.DataGridViewTextBoxColumn Descuento;
    }
}