
class Program
{
    static void Main(string[] args)
    {
        Console.WriteLine("\n Herencia en C# \n");

        Persona trabajador = new Persona();
        trabajador.name = "Juan";
        trabajador.lastName = "Duarte";
        trabajador.age = 20;
        trabajador.email = "duarte@herencia.com";
        trabajador.phone = "57574486";
        trabajador.address = "Calle falsa 123";

        Console.WriteLine("Nombre: " + trabajador.name);
        Console.WriteLine("Apellido: " + trabajador.lastName);
        Console.WriteLine("Edad: " + trabajador.age);
        Console.WriteLine("Email: " + trabajador.email);
        Console.WriteLine("Telefono: " + trabajador.phone);
        Console.WriteLine("Direccion: " + trabajador.address);

        // La parte de estudiante
        Console.WriteLine("\nLa parte de estudiante");
        Estudiante estudiante = new Estudiante();

        estudiante.name = "Carlos";
        estudiante.lastName = "Gonzalez";
        estudiante.age = 20;
        estudiante.address = "Managua, Nicaragua";

        estudiante.carrera = "Ingenieria en Sistemas";
        estudiante.curso = "Segundo";
        estudiante.exColegio = "UNAN";

        Console.WriteLine("Nombre: " + estudiante.name);
        Console.WriteLine("Apellido: " + estudiante.lastName);
        Console.WriteLine("Edad: " + estudiante.age);
        Console.WriteLine("Direccion: " + estudiante.address);

        Console.WriteLine("Carrera: " + estudiante.carrera);
        Console.WriteLine("Curso: " + estudiante.curso);
        Console.WriteLine("Ex-Colegio: " + estudiante.exColegio);


        // La parte de profesor
        Console.WriteLine("\nLa parte de Docente");
        Docente profesor = new Docente();

        profesor.name = "Pedro";
        profesor.lastName = "Perez";
        profesor.phone = "57574486";
        profesor.email  = "pedro@uraccan.com";
        profesor.address = "Calle verdadera 123";

        profesor.materias = "Matematica";
        profesor.colegio = "URACCAN";
        profesor.experiencia = "5 años";

        Console.WriteLine("Nombre: " + profesor.name);
        Console.WriteLine("Apellido: " + profesor.lastName);
        Console.WriteLine("Telefono: " + profesor.phone);
        Console.WriteLine("Email: " + profesor.email);
        Console.WriteLine("Direccion: " + profesor.address);

        Console.WriteLine("Materias: " + profesor.materias);
        Console.WriteLine("Colegio: " + profesor.colegio);
        Console.WriteLine("Experiencia: " + profesor.experiencia);

    }
}