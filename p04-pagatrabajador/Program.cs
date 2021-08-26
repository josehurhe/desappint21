// Calcular la paga total de un trabajador

using System;

namespace p04_pagatrabajador
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Calculando la paga de un trabajador");
            const float TASA = 0.3f;
            Console.WriteLine("Dame tu nombre?"); string nombre = Console.ReadLine();
            Console.WriteLine("Horas trabajadas?"); int horas = int.Parse(Console.ReadLine());
            Console.WriteLine("Pago por hora?"); float pago = float.Parse(Console.ReadLine());
            float pagoBruto = horas * pago;
            float impuesto = pagoBruto * TASA;
            float pagoNeto = pagoBruto - impuesto;
            string salida = $"\nEl trabajador {nombre}, trabajo {horas}, con un pago de {pago}\n" +
            $"Pago bruto: {pagoBruto}\nImpuesto: {impuesto}\nPago neto: {pagoNeto}";
            Console.WriteLine(salida);
        }
    }
}
