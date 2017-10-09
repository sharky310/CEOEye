﻿using CEOEye.Presentacion;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace CEOEye
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
            InicializarControlesPropios();

        }

        private void salirToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void InicializarControlesPropios()
        {
            barraInfo.Text = "Todo funcionando correctamente";
        }

        public void setBarraInfo(String info)
        {
            barraInfo.Text = info;
        }

        private void altaToolStripMenuItem_Click(object sender, EventArgs e)
        {
            AltaCliente formCliente = new AltaCliente();
            AddOwnedForm(formCliente);
            formCliente.Show();
        }
    }
}
