using System;

namespace p12_vectorinvertido
{
    class Program
    {
        static void Main(string[] args)
        {
            const int TAM = 15;
            int[] A = new int[TAM];
            int[] B = new int[TAM];
            Random random = new Random();
            for (int i = 0; i < A.Length; i++)
            {
                A[i] = random.Next(1,100);
                B[(A.Length-1)-i] = A[i];
            }
            Console.WriteLine("\nValores de A");imprime(A);
            Console.WriteLine("\nValores de B");imprime(B);
        }

        static void imprime(int[] v){
            for (int i = 0; i < v.Length; i++)
            {
                Console.Write($"{v[i]} ");
            }
            Console.WriteLine();
        }
    }
}