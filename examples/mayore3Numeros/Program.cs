namespace Program
{

    class Program
    {
        static void Main(string[] args)
        {
            byte MAY, MEN, NUM1, NUM2, NUM3;
            string linea;

            Console.Write("NÚMERO 1 :"); linea = Console.ReadLine();
            NUM1 = byte.Parse(linea);

            Console.Write("NÚMERO 2 :"); linea = Console.ReadLine();
            NUM2 = byte.Parse(linea);

            Console.Write("NÚMERO 3 :"); linea = Console.ReadLine();
            NUM3 = byte.Parse(linea);

            MAY = NUM1; MEN = NUM1;

            if ((NUM2 > MAY)) MAY = NUM2;
            if ((NUM3 > MAY)) MAY = NUM3;
            if ((NUM2 > MEN)) MEN = NUM2;
            if ((NUM3 < MEN)) MEN = NUM3;

            Console.WriteLine("MAYOR ES:" + MAY);
            Console.WriteLine("MENOR ES:" + MEN);
            Console.WriteLine("Pulse una Tecla:"); 
            
            Console.ReadLine();

        }
    }

}