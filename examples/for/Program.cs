using System;

namespace EstructuraRepetitivaFor
{
    class Program
    {
        static void Main(string[] args)
        {
            int n;
            int i = 1;
            string liner;

            Console.Write("Ingrese multiplicador: ");
            liner = Console.ReadLine();

            n = int.Parse(liner);

            while ( i <= 10)
            {
                Console.Write(i + " x " + n + " = " + i * n + "\n");
                i++;
            }
            System.Console.ReadKey();
        }
    }
}