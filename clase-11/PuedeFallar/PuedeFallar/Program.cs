using System;

namespace PuedeFallar
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Prueba Metodo de Extension FizzBuzz");
            Console.WriteLine($"Ingreso el 3 a FizzBuzz - respuesta: {FizzBuzzExtension.FizzBuzz(3)}");
            Console.WriteLine($"Ingreso el 5 a FizzBuzz - respuesta: {FizzBuzzExtension.FizzBuzz(5)}");
            Console.WriteLine($"Ingreso el 15 a FizzBuzz - respuesta: {FizzBuzzExtension.FizzBuzz(15)}");
            Console.WriteLine($"Ingreso el 25 a FizzBuzz - respuesta: {FizzBuzzExtension.FizzBuzz(25)}");
            Console.WriteLine($"Ingreso el 18 a FizzBuzz - respuesta: {FizzBuzzExtension.FizzBuzz(18)}");
            Console.WriteLine($"Ingreso el 8 a FizzBuzz - respuesta: {FizzBuzzExtension.FizzBuzz(8)}");
        }
    }
}
