// Calcular el area de un triangulo

using System;

namespace p03_areatriangulo
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Calculando el area de un triangulo");
            Console.Write("Dame la base?"); float lbase = float.Parse(Console.ReadLine());
            Console.Write("Dame la altura?"); float altura = float.Parse(Console.ReadLine());
            float area = (lbase * altura)/2;
            Console.WriteLine($"El area del triangulo es {area}");
        }
    }
}