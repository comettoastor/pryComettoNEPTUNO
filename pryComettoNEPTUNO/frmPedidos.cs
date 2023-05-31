using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace pryComettoNEPTUNO
{
    public partial class frmPedidos : Form
    {
        public frmPedidos()
        {
            InitializeComponent();
        }

        clsBaseDeDatos objBaseDeDatos = new clsBaseDeDatos();

        private void cmbPedido_SelectedIndexChanged(object sender, EventArgs e)
        {
            objBaseDeDatos.ListarPedidos(dgvPedidos, "NEPTUNO", "Detalles de pedidos", cmbPedido);
        }

        private void frmPedidos_Load(object sender, EventArgs e)
        {
            objBaseDeDatos.CargarPedidos(cmbPedido, "NEPTUNO", "Pedidos");
        }
    }
}
