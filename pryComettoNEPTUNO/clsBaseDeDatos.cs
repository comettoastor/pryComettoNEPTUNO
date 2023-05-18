using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.OleDb;
using System.Data;
using System.Windows.Forms;

namespace pryComettoNEPTUNO
{
    internal class clsBaseDeDatos
    {
        public OleDbCommand Comando = new OleDbCommand();
        public OleDbDataReader Lector;

        public void ListarClientes(DataGridView dgvClientes, string BaseDeDatos, string Tabla)
        {
            OleDbConnection Conexion = new OleDbConnection("Provider=Microsoft.ACE.OLEDB.12.0;Data Source=" + BaseDeDatos + ".accdb;Persist Security Info=False;");
            dgvClientes.Rows.Clear();
            try
            {
                Comando.Connection = Conexion;
                Comando.CommandText = Tabla;
                Comando.CommandType = CommandType.TableDirect;
                Comando.Connection.Open();

                Lector = Comando.ExecuteReader();

                while (Lector.Read())
                {
                    dgvClientes.Rows.Add(Lector[0], Lector[1], Lector[2], Lector[3], Lector[4], Lector[5], Lector[6], Lector[7], Lector[8], Lector[9], Lector[10]);
                }

                Comando.Connection.Close();
            }
            catch (Exception error)
            {
                MessageBox.Show(error.Message);
            }
        }

        public void CargarPaisCiudad(ComboBox cmbCiudad, ComboBox cmbPais, string BaseDeDatos, string Tabla)
        {
            OleDbConnection Conexion = new OleDbConnection("Provider=Microsoft.ACE.OLEDB.12.0;Data Source=" + BaseDeDatos + ".accdb;Persist Security Info=False;");
            bool encontradoCiudad = false;
            bool encontradoPais = false;
            try
            {
                Comando.Connection = Conexion;
                Comando.CommandText = Tabla;
                Comando.CommandType = CommandType.TableDirect;
                Comando.Connection.Open();

                Lector = Comando.ExecuteReader();

                while (Lector.Read())
                {
                    for (int i = 0; i < cmbCiudad.Items.Count; i++)
                    {
                        if (Lector[5].ToString() == cmbCiudad.Items[i].ToString())
                        {
                            encontradoCiudad = true;
                        }
                    }
                    if (encontradoCiudad == false)
                    {
                        cmbCiudad.Items.Add(Lector[5]);
                    }
                    encontradoCiudad = false;

                    for (int i = 0; i < cmbPais.Items.Count; i++)
                    {
                        if (Lector[8].ToString() == cmbPais.Items[i].ToString())
                        {
                            encontradoPais = true;
                        }
                    }
                    if (encontradoPais == false)
                    {
                        cmbPais.Items.Add(Lector[8]);
                    }
                    encontradoPais = false;
                }
                Comando.Connection.Close();
            }
            catch (Exception error)
            {
                MessageBox.Show(error.Message);
            }
        }

        public void ListarPais(DataGridView dgvClientes, string BaseDeDatos, string Tabla, ComboBox cmbPais)
        {
            OleDbConnection Conexion = new OleDbConnection("Provider=Microsoft.ACE.OLEDB.12.0;Data Source=" + BaseDeDatos + ".accdb;Persist Security Info=False;");
            dgvClientes.Rows.Clear();
            if (cmbPais.SelectedIndex != -1)
            {
                try
                {
                    Comando.Connection = Conexion;
                    Comando.CommandText = Tabla;
                    Comando.CommandType = CommandType.TableDirect;
                    Comando.Connection.Open();

                    Lector = Comando.ExecuteReader();

                    while (Lector.Read())
                    {
                        if (Lector[8].ToString() == cmbPais.Text)
                        {
                            dgvClientes.Rows.Add(Lector[0], Lector[1], Lector[2], Lector[3], Lector[4], Lector[5], Lector[6], Lector[7], Lector[8], Lector[9], Lector[10]);
                        }
                    }
                    Comando.Connection.Close();
                }
                catch (Exception error)
                {
                    MessageBox.Show(error.Message);
                }
            }
        }

        public void ListarCiudad(DataGridView dgvClientes, string BaseDeDatos, string Tabla, ComboBox cmbCiudad)
        {
            OleDbConnection Conexion = new OleDbConnection("Provider=Microsoft.ACE.OLEDB.12.0;Data Source=" + BaseDeDatos + ".accdb;Persist Security Info=False;");
            dgvClientes.Rows.Clear();
            try
            {
                Comando.Connection = Conexion;
                Comando.CommandText = Tabla;
                Comando.CommandType = CommandType.TableDirect;
                Comando.Connection.Open();

                Lector = Comando.ExecuteReader();

                while (Lector.Read())
                {
                    if (Lector[5].ToString() == cmbCiudad.Text)
                    {
                        dgvClientes.Rows.Add(Lector[0], Lector[1], Lector[2], Lector[3], Lector[4], Lector[5], Lector[6], Lector[7], Lector[8], Lector[9], Lector[10]);
                    }
                }
                Comando.Connection.Close();
            }
            catch (Exception error)
            {
                MessageBox.Show(error.Message);
            }
        }

    }
}
