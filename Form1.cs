using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Tarea_27
{
    public partial class fmrTarea27 : Form
    {

        private int a = 0;
        private int NumAl;
        public fmrTarea27()
        {
            InitializeComponent();
            Random aleatorio = new Random();
            NumAl = aleatorio.Next(0, 100);
        }
        private void cmdVer_Click(object sender, EventArgs e)
        {
            // Programa que permita a un jugador adivinar un número indeterminado de veces que
            // consiste en lo siguiente:
            // A. Genera un número aleatorio comprendido entre 0-100
            // B. Permite al jugador adivinar el número generado, permitiéndoles introducir por
            // teclado número mientras que no acierte. Con cada número introducido se le informará
            // por pantalla si el número generado es mayor o menor.
            // C. El programa cuenta el npumero de intentos y muestra al jugador en pantalla al
            // momento de la victoria, con el número de intentos. Si el número de intentos es 
            // menor o igual a 5 se indica al jugador que es bueno, si es mayor a 5 y menor a 15
            // se indica al jugador que es bueno, si es 15 o más se invita al jugador a que entrene
            // por ser malo.

            // Declaración de variables y tipo Random
            int Num;
     
            // Asignación de valores a las variables

            // Ciclo do-while para captura de Num
            do
            {
                Num = Convert.ToInt32(txtNum.Text);
                a = a + 1;
               // MessageBox.Show(NumAl.ToString());
                if (Num < NumAl)
                {
                    lblMensaje.Text = "0 o 0 El número a adivinar es MAYOR que "+Num;
                    txtNum.Clear();
                }
                else if (Num > NumAl)
                {
                    lblMensaje.Text = "0 - 0 El número a adivinar es Menor que "+Num;
                    txtNum.Clear();
                }
                else {
                    if (a <= 5)
                    {
                        lblMensaje.Text = "¡Ha adivinado el número! Usted es un buen jugador";
                        lblIntentos.Text = "Número de intentos: " + a.ToString();

                    }
                    else if (a > 5 && a <= 15)
                    {
                        lblMensaje.Text = "¡Ha adivinido el número! Usted es un jugaror regular";
                        lblIntentos.Text = "Número de intentos: " + a.ToString();

                    }
                    else
                    {
                        lblMensaje.Text = "¡Ha adivinado el número! Usted es un jugaor malo,\n lo invitamos a seguir prácticando";
                        lblIntentos.Text = "Número de intentos: " + a.ToString();
                    }
                    NumAl = 0;
                }
            } while(NumAl == Num);

            

        }

        private void cmdOtro_Click(object sender, EventArgs e)
        {
            lblMensaje.Text = "0u0";
            lblIntentos.Text = "";
            txtNum.Clear();
            Random aleatorio = new Random();
            NumAl = aleatorio.Next(0, 100);
        }

        private void cmdSalir_Click(object sender, EventArgs e)
        {
            Close();
        }
    }
}
