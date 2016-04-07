using System;
using System.Windows.Forms;

namespace ProyectoPruebaCSharp
{
    public partial class Form1 : Form
    {
        // <summary>
        //Texto que aparece
        /// </summary>
        public string textoBanner = "Controlado con -git";

        // <summary>
        //Contador que indica el numero de letras que están apareciendo en cada intervalo de timer1
        /// </summary>
        public short index = 0;

        public Form1()
        {
            InitializeComponent();
        }

        /// <summary>
        /// Se aplica Substring al texto. Se podría utilizar un indice como en un array.
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void timer1_Tick(object sender, EventArgs e)
        {
            label1.Text = textoBanner.Substring(0, index);
            index++;
            if (index==textoBanner.Length+1)
            {
                index = 0;
            }

        }

        private void button1_Click(object sender, EventArgs e)
        {
            timer1.Enabled = true;
        }

        private void button2_Click(object sender, EventArgs e)
        {
            timer1.Enabled = false;
        }
    }
}
