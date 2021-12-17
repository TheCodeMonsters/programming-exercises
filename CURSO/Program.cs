using CURSO.Clases;

namespace Program
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Hello World");

            Prototipo transporte = new Prototipo();
            transporte.color = "Black";
            transporte.marca = "Toyota";
            transporte.price = 2500;
            transporte.tipo = "Bicicleta BMX";

            Console.WriteLine("Tipo: " + transporte.tipo);
            Console.WriteLine("Color: " + transporte.color);
            Console.WriteLine("Marca: " + transporte.marca);
            Console.WriteLine("Precio: " + transporte.price);

            #region Avion
            Console.WriteLine("\n\nAvion");
            Avion avion = new Avion();
            avion.aerolinea = "Avianca";
            avion.name = "Juan";
            avion.ruta = "Europa";
            avion.scala = "SI";


            Console.WriteLine("Aerolinea: " + avion.aerolinea);
            Console.WriteLine("Nombre Piloto: " + avion.name);
            Console.WriteLine("Cual es la Ruta: " + avion.ruta);
            Console.WriteLine("Tiene escala: " + avion.scala);
            #endregion

            #region Piloto
            Console.WriteLine("\n\nPiloto");
            Piloto piloto = new Piloto();
            piloto.name = "Juan";
            piloto.lastName = "Perez";
            piloto.campeonatos = 5;
            piloto.nacionalidad = "Mexicano";

            Console.WriteLine("Nombre: " + piloto.name);
            Console.WriteLine("Apellido: " + piloto.lastName);
            Console.WriteLine("Campeonatos: " + piloto.campeonatos);
            Console.WriteLine("Nacionalidad: " + piloto.nacionalidad);
            #endregion

        }
    }
}
