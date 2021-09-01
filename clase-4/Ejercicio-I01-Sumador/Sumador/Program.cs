using Ejercicio_I01_Sumador;
using System;

namespace SumadorConsola
{
    public class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Prueba Sumador");

            Sumador s1 = new Sumador(4);
            Sumador s2 = new Sumador(12);

            Console.WriteLine($"la cantidad de sumas S1: {(int)s1}");
            Console.WriteLine($"la cantidad de sumas S2: {(int)s2}");
            Console.WriteLine($"la cantidad de sumas entre S1 y S2 es: {s1+s2}");
            Console.WriteLine($"S1 y S2 son iguales?: {s1 == s2}");
        }
    }
}
