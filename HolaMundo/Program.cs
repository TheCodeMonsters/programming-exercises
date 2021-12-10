namespace HolaMundo
{
    class Program
    {
        static void Main(string[] args)
        {
            // Variables
            int n1, n2, suma, mutiplicacion, resta, division;
            string linea;

            #region  "Cambiar de color la consola"
            Console.ForegroundColor = ConsoleColor.Green;
            Console.BackgroundColor = ConsoleColor.Black;
            Console.Clear();
            #endregion

            // Pedir datos por consola
            Console.WriteLine("Numero 1");
            linea = Console.ReadLine();
            n1 = int.Parse(linea);

            Console.WriteLine("Numero 2");
            linea = Console.ReadLine();
            n2 = int.Parse(linea);

            // Operaciones de suma
            suma = n1 + n2;
            resta = n1 - n2;
            mutiplicacion = n1 * n2;
            division = n1 / n2;

            Console.WriteLine("Suma de los 2 números es: " + suma);
            Console.WriteLine("resta de los 2 números es: " + resta);
            Console.WriteLine("mutiplicacion de los 2 números es: " + mutiplicacion);
            Console.WriteLine("division de los 2 números es: " + division);

            Console.ReadKey();
        }
    }
}

