﻿using System;

namespace p14_estadisticas
{
    class Program
    {
        static void Main(string[] args)
        {
            //double[] v = {100,30.4,20.5,66,84};
            double mayor, menor, promedio, varianza, desviacion;
            int n;
            Console.WriteLine("Cuantos valores deseas procesar");
            n = int.Parse(Console.ReadLine());
            double[] v = new double[n];
            for (int i = 0; i < v.Length; i++)
            {
                Console.Write($"n[{i+1}] = ");
                v[i] = double.Parse(Console.ReadLine());
            }

            mayor = may(v);
            menor = men(v);
            promedio = prom(v);
            varianza = vari(v,promedio);
            desviacion = Math.Sqrt(varianza);

            Console.WriteLine($"\nEl mayor es {mayor}");
            Console.WriteLine($"\nEl menor es {menor}");
            Console.WriteLine($"\nEl promedio es {promedio}");
            Console.WriteLine($"\nLa varianza es {varianza}");
            Console.WriteLine($"\nLa desviación estandar es {desviacion}");
        }

        static double vari(double[] v, double p){
            double s = 0;
            for (int i = 0; i < v.Length; i++)
            {
                s+= Math.Pow(v[i]-p,2);
            }
            return s/v.Length;
        }

        static double prom(double[] v){
            double s = 0;
            for (int i = 0; i < v.Length; i++)
            {
                s+=v[i];
            }
            return s/v.Length;
        }

        static double may(double[] v){
            double m = v[0];
            for (int i = 0; i < v.Length; i++)
            {
                if(v[i]>m)
                    m = v[i];
            }
            return m;
        }

        static double men(double[] v){
            double m = v[0];
            for (int i = 0; i < v.Length; i++)
            {
                if(v[i]<m)
                    m = v[i];
            }
            return m;
        }
    }
}