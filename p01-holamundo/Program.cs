using System;

namespace p01_holamundo
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Hola Mundo!");
            Console.WriteLine("Dame tu nombre?");
            string nombre = Console.ReadLine();
            Console.WriteLine($"{nombre} bienvenido a C#\n");
            DateTime fecha = DateTime.Now;
            Console.WriteLine($"Hoy es {fecha:d} y son las {fecha:t}");
            Console.WriteLine("\nHasta Pronto");
        }
    }
}
