﻿using CEOEye.Negocio;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace CEOEye.Presentacion
{
    public partial class AltaCliente : Form
    {
        Cliente cliente;

        public AltaCliente()
        {
            InitializeComponent();
        }

        private void button3_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void button2_Click(object sender, EventArgs e)
        {
            textDNI.Text = "";
            textNombre.Text = "";
            textApellidos.Text = "";
            textMail.Text = "";
            textDireccion.Text = "";
            textTelefono.Text = "";
            textNombre.Text = "";
        }

        private void buttonGuardar_Click(object sender, EventArgs e)
        {
            cliente = new Cliente(textDNI.Text,textNombre.Text,textApellidos.Text,textTelefono.Text,textDireccion.Text
                ,textMail.Text,"");
        }
    }
}
