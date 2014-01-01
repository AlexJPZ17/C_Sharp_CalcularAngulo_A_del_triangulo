using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace CalcularAngulo_A_del_triangulo
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }
        private void Angulos()
        {
            //Declaramos la variables de tipo Double
            double anguloA, anguloB1, anguloB2, adyacente, hipotenusa, coseno;
            //Condición que valúa el TextBox si está vacío
            if (TextBox_Hipotenusa.Text == "")
            {
                MessageBox.Show("Ingrese la hipotenusa", "Atención", MessageBoxButtons.OK, MessageBoxIcon.Information);
                //Colocamos el focus en el TextBox
                TextBox_Hipotenusa.Focus();
            }
            else
            {
                //Condición que valúa el TextBox si está vacío
                if (TextBox_Adyacente.Text == "")
                {
                    MessageBox.Show("Ingrese la adyacente", "Atención", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    //Colocamos el focus en el TextBox
                    TextBox_Adyacente.Focus();
                }
                else
                {
                    /*Métodos que convierte en un tipo double los valores
                     que se ingresen por los TextBox */
                    hipotenusa = Convert.ToDouble(TextBox_Hipotenusa.Text);
                    adyacente = Convert.ToDouble(TextBox_Adyacente.Text);
                    //División de las variables adyacente/hipotenusa
                    coseno = adyacente / hipotenusa;
                    //Formula para sacar el ángulo A sacando el coseno inverso de la variable coseno 
                    anguloA = Math.Acos(coseno) * 180 / Math.PI;
                    Label_AnguloA.Text = anguloA.ToString() + "°";
                    //Método para sacar el ángulo B
                    anguloB1 = 90 + anguloA;
                    anguloB2 = 180 - anguloB1;
                    Label_AnguloB.Text = anguloB2.ToString() + "°";
                }
            }
        }

        private void Button_Calular_Click(object sender, EventArgs e)
        {
            Angulos();
        }

        private void Button_Limpiar_Click(object sender, EventArgs e)
        {
            TextBox_Hipotenusa.Text = "";
            TextBox_Adyacente.Text = "";
            Label_AnguloA.Text = "0°";
            Label_AnguloB.Text = "0°";
            TextBox_Hipotenusa.Focus();

        }
    }
}
