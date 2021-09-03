using System;

namespace p13_vectormultiplica
{
    class Program
    {
        static void Main(string[] args)
        {
            const int TAM = 10;
            int[] A = new int[TAM];
            int[] B = new int[TAM];
            int[] C = new int[TAM];
            Random random = new Random();
            for (int i = 0; i < A.Length; i++)
            {
                A[i] = random.Next(1,100);
                B[i] = random.Next(1,100);
            }
            C = multiplica(A,B);

            Console.WriteLine("\nValores de A");imprime(A);
            Console.WriteLine("\nValores de B");imprime(B);
            Console.WriteLine("\nValores de C");imprime(C);
        }

        static int[] multiplica(int[] A, int[] B){
            int[] C = new int[A.Length];
            for (int i = 0; i < A.Length; i++)
            {
                C[i] = A[i] * B[(B.Length-1)-i];
            }
            return C;
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
