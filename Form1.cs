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
        public string textoBanner = "Controlado con -git";
        public short index = 0;
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            timer1.Enabled = true;
        }

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
