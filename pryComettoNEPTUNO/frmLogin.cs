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
    public partial class frmLogin : Form
    {
        public frmLogin()
        {
            InitializeComponent();
        }

        private void btnIngresar_Click(object sender, EventArgs e)
        {
            if (txtUsuario.Text == "admin" && txtContrasenia.Text == "admin")
            {
                frmMenu frmMenu = new frmMenu();
                this.Hide();
                frmMenu.ShowDialog();
                this.Close();
            }
            else
            {
                MessageBox.Show("El usuario/contraseña ingresados son incorrectos", "Usuario/Contraseña Incorrectos", MessageBoxButtons.OK,MessageBoxIcon.Warning);
            }
        }

        private void btnSalir_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }
    }
}
