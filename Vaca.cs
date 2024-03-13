using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Policy;
using System.Text;
using System.Threading.Tasks;

namespace WFAHere
{
    internal class Vaca:Mamifero
    {
        private double LitLeche { get; set; }

        /*
        public Vaca() : base("", 0)
        {
            Console.WriteLine("Ingrese los litros de leche");
            LitLeche = double.Parse(Console.ReadLine());

            Console.WriteLine("Ingrese el peso");
            peso = double.Parse(Console.ReadLine());
        }
        */

        public Vaca(string n, int p, int l) : base(n, p)
        {
            this.LitLeche = l;
        }

        /*

        public void CalcularCanComida()
        {
            double kiloscomida = 0;
            kiloscomida = peso / (2 * LitLeche);
            Console.WriteLine("La cantidad de comida es:" + kiloscomida);

        }
        */
        /*
        public void mostrarvaca()
        {
            string nomb = "";
            nomb = getNombre();
            Console.Write("Ingresa el nombre de la vaca: ");
            nomb = Console.ReadLine();

            Console.WriteLine("Clase Vaca");
            Console.WriteLine("El nombre de la Vaca es: " + nomb);
            Console.WriteLine("Peso: " + peso);
            Console.WriteLine("Litros de leche: " + LitLeche);
        }
        */
 

        public string mostrvaca() 
        {
            string dat;
            dat = "El nombre de la vaca es: " + getNombre() + Environment.NewLine;
            dat += "El peso es: " + peso + " kilogramos" + Environment.NewLine;
            dat += "Litros de leche: " + LitLeche + Environment.NewLine;
            dat += "La Vaca come:" + peso / (2 * LitLeche) + Environment.NewLine;
            return dat;
        }
    }
}
