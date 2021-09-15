using Biblioteca;
using System;

namespace Consola_I01
{
    public class Program
    {
        static void Main(string[] args)
        {
            Automovil auto = new Automovil(4, 2, Colores.Negro, 5, 4);
            Console.WriteLine("Auto:");
            Console.WriteLine($"Ruedas: {auto.cantidadRuedas}");
            Console.WriteLine($"Puertas: {auto.cantidadPuertas}");
            Console.WriteLine($"Color: {auto.color}");
            Console.WriteLine($"Marchas: {auto.cantidadMarchas}");
            Console.WriteLine($"Pasajeros: {auto.cantidadPasajeros}");
        }
    }
}
