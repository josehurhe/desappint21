using System;

namespace p07_tablas
{
    class Program
    {
        static void Main(string[] args)
        {
            int numero = 5;
            for (int i = 1; i <= 10; i++)
            {
                Console.WriteLine($"{numero} x {i} = {numero*i}");
            }
            imprimir(1,100);
            imprimir(10,10);
            imprimir(5,11);
        }

        static void imprimir(int tabla, int numero){
            for (int i = 1; i <= numero; i++)
            {
                Console.WriteLine($"{tabla} x {i} = {tabla*i}");
            }
            Console.WriteLine();
        }
    }
}
