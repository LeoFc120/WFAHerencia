using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WFAHere
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            if (textBox2.Text == string.Empty)
            {
                MessageBox.Show("Ingresa el numero de bigotes");
            }
            else
            {
                //pasar tipo sting a int
                int nBi = int.Parse(textBox2.Text);

                Gato cat = new Gato("SCAR", 5, nBi);
                //Mostrar datos
                textBox1.Text = cat.mostrargati();

            }
        }

        private void button2_Click(object sender, EventArgs e)
        {
            //Vaca

                //pasar tipo sting a int
                int Lit = int.Parse(textBox5.Text);
                int Ps = int.Parse(textBox4.Text);
                string nom = (textBox3.Text);
                Vaca vac =new Vaca(nom, Lit, Ps);
                //Mostrar datos
                textBox1.Text = vac.mostrvaca();
            //textBox1.Text = vac.CalcularCanComida();
        }
    }
}
