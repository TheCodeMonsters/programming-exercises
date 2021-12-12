## Programa : El usuario introduce números y el ordenador cuenta cuantos son positivos.

```c#
class Program
 {
    static void Main(string[] args)
    {
        int positivos = 0; int conta = 0; int numero;
        Console.WriteLine("Introduce número ");
        numero = Int32.Parse(Console.ReadLine());
    
    while (numero != 999)
    {
        conta = conta + 1;

        if (numero > 0) positivos = positivos + 1;

        Console.WriteLine("Introduce número ");
        numero = Int32.Parse(Console.ReadLine());
    }
        Console.WriteLine("Has introducido un total de {0}", conta);
        Console.WriteLine("y son positivos {0}", positivos);

    } //fin Main
 }
```
