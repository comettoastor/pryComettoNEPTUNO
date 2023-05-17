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
        OleDbConnection conexion = new OleDbConnection("Provider=Microsoft.ACE.OLEDB.12.0;Data Source=NEPTUNO.accdb;Persist Security Info=False;");
        OleDbCommand comando = new OleDbCommand();
        OleDbDataReader lector;

        public void ListarClientes()
        {
            dgvClientes.Rows.Clear();
            try
            {
                comando.Connection = conexion;
                comando.CommandText = "Clientes";
                comando.CommandType = CommandType.TableDirect;
                comando.Connection.Open();

                lector = comando.ExecuteReader();

                while (lector.Read())
                {
                    dgvClientes.Rows.Add(lector[0], lector[1], lector[2], lector[3], lector[4], lector[5], lector[6], lector[7], lector[8], lector[9], lector[10]);
                    cmbCiudad.Items.Add(lector[5]);
                }

                comando.Connection.Close();
            }
            catch (Exception error)
            {
                MessageBox.Show(error.Message);
            }
        }

        public void Volver()
        {
            frmMenu frmMenu = new frmMenu();
            this.Hide();
            frmMenu.ShowDialog();
            this.Close();

        }

        public void CargarPaisCiudad()
        {
            bool encontradoCiudad = false;
            bool encontradoPais = false;
            try
            {
                comando.Connection = conexion;
                comando.CommandText = "Clientes";
                comando.CommandType = CommandType.TableDirect;
                comando.Connection.Open();

                lector = comando.ExecuteReader();

                while (lector.Read())
                {
                    for (int i = 0; i < cmbCiudad.Items.Count; i++)
                    {
                        if (lector[5].ToString() == cmbCiudad.Items[i].ToString())
                        {
                            encontradoCiudad = true;
                        }
                    }
                    if (encontradoCiudad == false)
                    {
                        cmbCiudad.Items.Add(lector[5]);
                    }
                    encontradoCiudad = false;

                    for (int i = 0; i < cmbPais.Items.Count; i++)
                    {
                        if (lector[8].ToString() == cmbPais.Items[i].ToString())
                        {
                            encontradoPais = true;
                        }
                    }
                    if (encontradoPais == false)
                    {
                        cmbPais.Items.Add(lector[8]);
                    }
                    encontradoPais = false;
                }
                comando.Connection.Close();
            }
            catch (Exception error)
            {
                MessageBox.Show(error.Message);
            }
        }

        public void ListarPais()
        {
            dgvClientes.Rows.Clear();
            try
            {
                comando.Connection = conexion;
                comando.CommandText = "Clientes";
                comando.CommandType = CommandType.TableDirect;
                comando.Connection.Open();

                lector = comando.ExecuteReader();

                while (lector.Read())
                {
                    if (lector[8].ToString() == cmbPais.Text)
                    {
                        dgvClientes.Rows.Add(lector[0], lector[1], lector[2], lector[3], lector[4], lector[5], lector[6], lector[7], lector[8], lector[9], lector[10]);
                    }
                }
                comando.Connection.Close();
            }
            catch (Exception error)
            {
                MessageBox.Show(error.Message);
            }
        }

        public void ListarCiudad()
        {
            dgvClientes.Rows.Clear();
            try
            {
                comando.Connection = conexion;
                comando.CommandText = "Clientes";
                comando.CommandType = CommandType.TableDirect;
                comando.Connection.Open();

                lector = comando.ExecuteReader();

                while (lector.Read())
                {
                    if (lector[5].ToString() == cmbCiudad.Text)
                    {
                        dgvClientes.Rows.Add(lector[0], lector[1], lector[2], lector[3], lector[4], lector[5], lector[6], lector[7], lector[8], lector[9], lector[10]);
                    }
                }
                comando.Connection.Close();
            }
            catch (Exception error)
            {
                MessageBox.Show(error.Message);
            }
        }

        public frmClientes()
        {
            InitializeComponent();
        }

        private void btnListar_Click(object sender, EventArgs e)
        {
            ListarClientes();
        }

        private void frmClientes_Load(object sender, EventArgs e)
        {
            CargarPaisCiudad();
        }

        private void cmbPais_SelectedIndexChanged(object sender, EventArgs e)
        {
            ListarPais();
        }

        private void cmbCiudad_SelectedIndexChanged(object sender, EventArgs e)
        {
            ListarCiudad();
        }

        private void btnVolver_Click(object sender, EventArgs e)
        {
            Volver();
        }
    }
}
