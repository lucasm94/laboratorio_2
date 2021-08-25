using Biblioteca;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ValidadorRangos
{
    class Program
    {
        static void Main(string[] args)
        {
            int valor;
            int min = -100;
            int max = 100;
            bool esNumerico;
            int minimoAgregado = max;
            int maximoAgregado = min;
            int acumNumerosIngresados = 0;
            float acumuladoValor = 0;

            while (acumNumerosIngresados < 10)
            {
                Console.WriteLine("Ingrese un numero: ");
                esNumerico = int.TryParse(Console.ReadLine(), out valor);
                if (esNumerico)
                {
                    if (Validador.Validar(valor, min, max))
                    {
                        if (minimoAgregado > valor)
                        {
                            minimoAgregado = valor;
                        }
                        if (maximoAgregado < valor)
                        {
                            maximoAgregado = valor;
                        }
                        acumuladoValor += valor;
                        Console.WriteLine("Esta dentro del rango");
                    }
                    else
                    {
                        Console.WriteLine("Esta fuera del rango");
                    }
                    acumNumerosIngresados++;
                }
                else
                {
                    Console.WriteLine("Lo ingresado no es un numero");
                }
            }

            Console.WriteLine($"El numero minimo ingresado es {minimoAgregado}");
            Console.WriteLine($"El numero maximo ingresado es {maximoAgregado}");
            Console.WriteLine($"El promedio es {acumuladoValor / acumNumerosIngresados}");
            Console.ReadLine();
        }
    }
}
