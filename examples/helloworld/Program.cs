using System;

namespace HelloWorld
{
    class Program
    {
        static void Main(string[] args)
        {
            // Variables
            string firstName;
            string lastName;
            int age;

            // Inicializacion de las variables
            firstName = "Manuel";
            lastName = "Duarte";
            age = 20;

            // Imprimir en consola
            Console.Write("Hello, ");
            Console.Write(firstName);
            Console.Write(" ");
            Console.Write(lastName);
            Console.Write(" Tu tienes una edad de: ");
            System.Console.Write(age);

            Console.WriteLine("\nOtra forma de poder concatenar string");

            Console.WriteLine($"Hello, {firstName} {lastName} Tu tienes una edad de: {age}");

            // se asegura que el programa no se cerrará inmediatamente después 
            // de ejecutarse
            System.Console.ReadKey();

        }
    }
}