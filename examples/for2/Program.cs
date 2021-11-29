using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EstructuraRepetitivaFor2
{
    class Program
    {
        static void Main(string[] args)
        {
            int suma, f, valor, promedio;
            string linea;
            suma = 0;

            for (f = 1; f <= 5; f++)
            {
                Console.Write("Ingrese la nota: ");
                linea = Console.ReadLine();
                valor = int.Parse(linea);
                suma = suma + valor;
            }

            Console.Write("La suma de las notas: ");
            Console.WriteLine(suma);
            promedio = suma / 5;

            Console.Write("El promedio es: ");
            Console.Write(promedio);

            Console.WriteLine("  ");

            if (promedio >= 60)
            {
                Console.WriteLine("Aprobado");
            }
            else
            {
                Console.WriteLine("Reprobado");
            }

            Console.ReadKey();
        }
    }
} 