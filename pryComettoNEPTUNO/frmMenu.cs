﻿using System;
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
    public partial class frmMenu : Form
    {
        public frmMenu()
        {
            InitializeComponent();
        }

        private void btnListadoClientes_Click(object sender, EventArgs e)
        {
            frmClientes frmClientes = new frmClientes();
            this.Hide();
            frmClientes.ShowDialog();
            this.Close();
        }

        private void btnSalir_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void btnTablas_Click(object sender, EventArgs e)
        {
            frmTablas frmTablas = new frmTablas();
            this.Hide();
            frmTablas.ShowDialog();
            this.Close();
        }

        private void btnPedidos_Click(object sender, EventArgs e)
        {
            frmPedidos frmPedidos = new frmPedidos();
            this.Hide();
            frmPedidos.ShowDialog();
            this.Close();
        }
    }
}
