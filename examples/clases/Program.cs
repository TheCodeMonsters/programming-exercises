using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PruebaClase1
{
    class Persona
    {
        private string nombre;
        private string apellido;
        private int edad;

        public void Inicializar()
        {
            Console.Write("Ingrese el nombre:");
            nombre = Console.ReadLine();

            Console.Write("Ingrese el apellido:");
            apellido = Console.ReadLine();

            string linea;
            Console.Write("Ingrese la edad:");
            linea = Console.ReadLine();
            edad = int.Parse(linea);
        }

        public void Imprimir()
        {
            Console.Write("Nombre: ");
            Console.WriteLine(nombre);
            Console.Write("Apellido: ");
            Console.WriteLine(apellido);
            Console.Write("Edad: ");
            Console.WriteLine(edad);
        }

        public void EsMayorEdad()
        {
            if (edad >= 18)
            {
                Console.Write("Es mayor de edad");
            }
            else
            {
                Console.Write("No es mayor de edad");
            }
            Console.ReadKey();
        }


        static void Main(string[] args)
        {
            Persona per1 = new Persona();
            per1.Inicializar();
            per1.Imprimir();
            per1.EsMayorEdad();
        }
    }
}