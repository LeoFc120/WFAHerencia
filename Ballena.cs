using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WFAHere
{
    internal class Ballena:Mamifero
    {
        public Ballena() : base("", 0)
        {

        }

        public Ballena(string n, double p) : base(n, p)
        {

        }

        /*
        //Metodos 
        public void MostrarBallena()
        {

            string nombre;
            Console.Write("Ingresa el nombre: ");
            nombre = Console.ReadLine();

            Console.Write("Ingresa el peso: ");
            peso = double.Parse(Console.ReadLine());

            Console.WriteLine("Clase Ballena");
            Console.WriteLine("Nombre: " + nombre);
            Console.WriteLine("Peso: " + peso + "Kg");
        }
        */
        public string mostrarballena() 
        {
            string dato1;
            dato1 = "El nombre de la ballena es: " + getNombre() + Environment.NewLine;
            dato1 += "El peso es: " + peso + " kilogramos" + Environment.NewLine;
            return dato1;

        }


    }
}
