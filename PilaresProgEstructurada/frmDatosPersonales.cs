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
            this.getSaludos(saludo); //llamada a la función
            this.lblNombres.Text = this.lblNombres.Text + "-->" + this.getCalculos(a, b).ToString();
        }

    //procedimientos - funciones
    //las funciones devuelven valores.
    //el procedimiento es una función que no devuelve valor
    void getSaludos(string nombres)
        {
            this.lblNombres.Text = "Uso de función que no devuelve valor (" + nombres + ")";
        }

    // función que devuelve valor

    double  getCalculos(int a, int b)
        {
            double resul = 0;
            resul = (a * 10) / (b * 2.5);
            
            return resul;
        }
        // tipos de datos en C#
        // operadores lógicos
        // Operadores relacionales
        // Operadores aritméticos
        // Estructuras repetitivas


    }
}
