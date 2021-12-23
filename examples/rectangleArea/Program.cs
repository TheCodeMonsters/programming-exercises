// See https://aka.ms/new-console-template for more information
namespace ConsoleApp1
{
		class Program
		{
				static void Main(string[] args)
				{
					// rectangle area cal.
					AreaRectangle();


					// operadoresRelacionales();
				
					/**
					 * Calcular la edad de una persona
					 */

					// agePerson();

				}

				static void AreaRectangle()
				{
					int sideA = 10;
					Console.WriteLine("Ingresa el primer lado del reacangle");
					sideA = Convert.ToInt32(Console.ReadLine());

					int sideB = 20;
					Console.WriteLine("Ingresa el segundo lado del reacangle");
					sideB = Convert.ToInt32(Console.ReadLine());


					int area = sideA * sideB;

					Console.WriteLine("Area of rectangle is : " + area);
				}

				static void operadoresRelacionales()
				{
					// operadores relacionales
					int a = 10;
					int b = 20;
					int c = 30;

					// == igual
					// != diferente
					// > mayor que
					// < menor que
					// >= mayor o igual que
					// <= menor o igual que

					if (a > b) 
					{
						Console.WriteLine("a es mayor que b");
					} else
					{
						Console.WriteLine("a es menor que b");
					}
					
				}


				static void agePerson()
				{
					// Calcular la de una persona para ver si puede entrar a una bar
					int agePerson;

					Console.WriteLine("Ingrese su edad por favor: ");
					agePerson = Convert.ToInt32(Console.ReadLine());

					if (agePerson >= 18)
					{
						Console.WriteLine("Puede entrar a la bar");
					} else
					{
						Console.WriteLine("No puede entrar a la bar");
					}	

				}
		}
}
