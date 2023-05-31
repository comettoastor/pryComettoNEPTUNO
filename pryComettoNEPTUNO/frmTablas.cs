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
    public partial class frmTablas : Form
    {
        public string cadenaConexion;

        public frmTablas()
        {
            InitializeComponent();
        }

        clsBaseDeDatos clsBaseDeDatos = new clsBaseDeDatos();

        private void cmbTablas_SelectedIndexChanged(object sender, EventArgs e)
        {
            clsBaseDeDatos.MostrarTablas(cmbTablas, cadenaConexion, dgvTablas);
        }

        private void btnBaseDatos_Click(object sender, EventArgs e)
        {
            clsBaseDeDatos.ListarTablas(cmbTablas, dgvTablas, txtBaseDatos);
            cadenaConexion = clsBaseDeDatos.cadenaConexion;
            if (cadenaConexion != "")
            {
                lblBaseDatos.Enabled = true;
                lblTabla.Enabled = true;
                cmbTablas.Enabled = true;
            }
        }

        private void btnVolver_Click(object sender, EventArgs e)
        {
            frmMenu frmMenu = new frmMenu();
            this.Hide();
            frmMenu.ShowDialog();
            this.Close();
        }
    }
}
