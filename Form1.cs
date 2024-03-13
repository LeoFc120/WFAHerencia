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
            if (textBox3.Text == string.Empty) 
            {

                MessageBox.Show("Ingresa los datos");

            }
            else
            {
                //pasar tipo sting a int
                int LitLeche = int.Parse(textBox4.Text);
                int peso = int.Parse(textBox5.Text);
                string nom = (textBox3.Text);
                Vaca vac = new Vaca(nom, LitLeche, peso);
                //Mostrar datos
                textBox1.Text = vac.mostrvaca();
            }

            
        }

        private void button3_Click(object sender, EventArgs e)
        {
            if (textBox6.Text == string.Empty)
            {
                MessageBox.Show("Ingresa los datos");
            }
            else
            {
                //pasar tipo sting a int
                double Pes = double.Parse(textBox7.Text);
                string nomb = (textBox6.Text);
                Ballena ballena = new Ballena(nomb, Pes);
                //Mostrar datos
                textBox1.Text = ballena.mostrarballena();

            }

        }

        private void button4_Click(object sender, EventArgs e)
        {
            textBox1.Text=string.Empty;
            textBox2.Text = string.Empty;
            textBox3.Text = string.Empty;
            textBox4.Text = string.Empty;
            textBox5.Text = string.Empty;
            textBox6.Text = string.Empty;
            textBox7.Text = string.Empty;
        }
    }
}
