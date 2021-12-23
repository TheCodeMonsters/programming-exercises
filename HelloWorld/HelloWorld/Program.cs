using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HelloWorld
{
    internal class Program
    {
        static void Main(string[] args)
        {

             //suma();
            //stringName();
            manejoString();


        }

        static void stringName()
        {
            int height = 170;
            int age = 20;
            string name = "Manuel Duarte";
            Console.WriteLine($"Hola: {name}");

            Console.ReadKey();
        }

        static void manejoString ()
        {
            int height = 170;
            int age = 22;
            string name = "Carlos Duarte";
            string information = $"The requested info is:\nUser name: {name} \nUser age: {age} \nUser height: {height}";
            Console.WriteLine(information);
        }
  

        static void suma ()
        {
            int number1;
            int number2;

            Console.WriteLine("Input the first number");
            number1 = Convert.ToInt32(Console.ReadLine());

            Console.WriteLine("Input two number");
            number2 = Convert.ToInt32(Console.ReadLine());

            int sum = number1 + number2;
            Console.WriteLine("La suma es: " + sum);

            Console.ReadKey();

        }
    }
}
