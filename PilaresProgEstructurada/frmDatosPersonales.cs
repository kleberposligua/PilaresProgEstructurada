﻿using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace PilaresProgEstructurada
{
    public partial class frmDatosPersonales : Form
    {
        public frmDatosPersonales()
        {
            InitializeComponent();
        }

        private void btnAceptar_Click(object sender, EventArgs e)
        {
            //estructuras secuenciales
            string saludo = ""; //cadena caracteres
            saludo = this.txtNombres.Text + " " + this.txtApellidos.Text;
            MessageBox.Show("Hola: " + saludo);

            //estructuras repetitivas
            string aux = "";
            for (int i=1; i<=10; i++)
            {
                //aux = aux + saludo + System.Environment.NewLine;
                aux += saludo + System.Environment.NewLine;
            }
            

            //estructuras selectivas (condicionales)
            int a = 100;
            int b = 20;
            if (a > b)
                aux = aux + "a mayor b";
            else
                aux = aux + "b mayor que a";

            this.txtResultado.Text = aux;

        }
    }
}
