using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ProyectoPruebaCSharp
{
    public partial class Form1 : Form
    {
        //Texto que aparece
        public string textoBanner = "Controlado con -git";
        //Contador que indica el numero de letras que están apareciendo en cada intervalo de timer1
        public short index = 0;
        public Form1()
        {
            InitializeComponent();
        }
        //Nada más cargarse el formulario, empieza el contador
        private void Form1_Load(object sender, EventArgs e)
        {
            timer1.Enabled = true;
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
    }
}
