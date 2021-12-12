class Program
{
    static void Main(String[] args)
    {
        int positivos = 0; int contador = 0; int numero;

        Console.WriteLine("Introduce un número: ");
        numero = Int32.Parse(Console.ReadLine());

        while (numero != 999)
        {
            contador = contador + 1;

            if (numero > 0) positivos = positivos + 1;

            Console.WriteLine("Introduce un número: ");
            numero = Int32.Parse(Console.ReadLine());
        }

        Console.WriteLine("Has introducido un total de {0}", contador);
        Console.WriteLine("Y son positivos {0}", positivos);

    }

    
}