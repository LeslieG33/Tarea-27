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
        public fmrTarea27()
        {
            InitializeComponent();
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
            int Num, NumAl, a=0;
            Random aleatorio = new Random();

            // Asignación de valores a las variables
            NumAl = aleatorio.Next(100);
            Num = Convert.ToInt32(txtNum.Text);

            // Ciclo do-while para captura de Num
            do
            {
                if (Num < NumAl)
                {
                    a = a + 1;
                    lblMensaje.Text = "El número a adivinar es MAYOR";
                    txtNum.Focus();
                }
                else if (Num > NumAl)
                {
                    a = a + 1;
                    lblMensaje.Text = "El número a adivinar es MENOR";
                    txtNum.Focus();
                }
                else
                {
                    a = a + 1;
                }
            } while (Num != NumAl);

            // Despliqegue del resultado
            if (a <= 5)
            {
                lblMensaje.Text = "¡Ha adivinado el número! Usted es un buen jugador";
                lblIntentos.Text = "Número de intentos: " + a;

            }
            else if (a >5 && a <=15)
            {
                lblMensaje.Text = "¡Ha adivinido el número! Usted es un jugaror regular";
                lblIntentos.Text = "Número de intentos: " + a;

            }
            else
            {
                lblMensaje.Text = "¡Ha adivinado el número! Usted es un jugaor malo, lo invitamos a seguir prácticando";
                lblIntentos.Text = "Número de intentos: " + a;
            }
                
        }

        private void cmdOtro_Click(object sender, EventArgs e)
        {
            lblMensaje.Text = "";
            lblIntentos.Text = "";
            txtNum.Clear();
        }

        private void cmdSalir_Click(object sender, EventArgs e)
        {
            Close();
        }
    }
}
