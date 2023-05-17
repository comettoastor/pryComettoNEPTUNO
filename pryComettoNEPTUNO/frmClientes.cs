using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data.OleDb;

namespace pryComettoNEPTUNO
{
    public partial class frmClientes : Form
    {
        public frmClientes()
        {
            InitializeComponent();
        }

        private void btnListar_Click(object sender, EventArgs e)
        {
            dgvClientes.Rows.Clear();
            try
            {
                OleDbConnection conexion = new OleDbConnection("Provider=Microsoft.ACE.OLEDB.12.0;Data Source=NEPTUNO.accdb;Persist Security Info=False;");
                OleDbCommand comando = new OleDbCommand();
                OleDbDataReader lector;

                comando.Connection = conexion;
                comando.CommandText = "Clientes";
                comando.CommandType = CommandType.TableDirect;
                comando.Connection.Open();

                lector = comando.ExecuteReader();

                while (lector.Read())
                {
                    dgvClientes.Rows.Add(lector[0], lector[1], lector[2], lector[3], lector[4], lector[5], lector[6], lector[7], lector[8], lector[9], lector[10]);
                }

                comando.Connection.Close();
            }
            catch (Exception error)
            {
                MessageBox.Show(error.Message);
            }
        }
    }
}
