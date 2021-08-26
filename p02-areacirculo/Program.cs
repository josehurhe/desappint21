// Calcular el area de un circulo

using System;

namespace p02_areacirculo
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Calculando el area de un circulo");
            Console.WriteLine("Dame el radio?");
            float radio = float.Parse(Console.ReadLine());
            double area = Math.PI * Math.Pow(radio,2);
            Console.WriteLine($"El area del circulo es {area}");
        }
    }
}
