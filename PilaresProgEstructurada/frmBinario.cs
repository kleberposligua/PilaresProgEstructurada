using System;
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
    public partial class frmBinario : Form
    {
        public frmBinario()
        {
            InitializeComponent();
        }

        private void checkBox2_CheckedChanged(object sender, EventArgs e)
        {

        }

        private void btnConvertir_Click(object sender, EventArgs e)
        {
            if (this.txtNumero.Text.Length == 0)
            {
                MessageBox.Show("Debe ingresar un entero...");
                return; //abandonar ejecución
            }

            //Actividades:
            //1. validar que sea un número y no letras
            //2. validar que el número ingresado esté entre 0 y 255
            //3. Diseñar un formulario nuevo o en el mismo, pero ahora
            //debe marcar los checkboxs y al hacer clic en un botón
            //debe aparecer el equivalente en entero

            if (int.TryParse(this.txtNumero.Text, out int numero))
            {
                if (numero >= 0 && numero <= 255)
                    binario(numero);
                else
                    MessageBox.Show("Número fuera de rango");
            }
            else
            {
                MessageBox.Show("Debe ingresar solo valores numéricos...");
            }
           
        }

        void binario(int num)
        {   //declarar un vector de enteros
            int[] vector = new int[8];
            int residuo = 0, i=0;
            while (num > 0)
            {
                residuo = num % 2;
                vector[i++] = residuo;
                num /= 2;
            }
            i = 0;
            foreach (int k in vector)
            {
                if (i == 7) this.checkBox1.Checked = k == 1 ? true : false;
                if (i == 6) this.checkBox2.Checked = k == 1 ? true : false;
                if (i == 5) this.checkBox3.Checked = k == 1 ? true : false;
                if (i == 4) this.checkBox4.Checked = k == 1 ? true : false;
                if (i == 3) this.checkBox5.Checked = k == 1 ? true : false;
                if (i == 2) this.checkBox6.Checked = k == 1 ? true : false;
                if (i == 1) this.checkBox7.Checked = k == 1 ? true : false;
                if (i == 0) this.checkBox8.Checked = k == 1 ? true : false;
                i++;
            }
        }
    }
}
