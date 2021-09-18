﻿using System;

namespace p17_repasopoo
{
    class Program
    {
        static void Main(string[] args)
        {
            // Inicializar datos
            Red mired = new Red("Universidad Autonoma de Zacatecas","Juan Perez","Jardín Juarez 147");
            mired.AgregarNodo(new Nodo("192.168.0.10","servidor",5,10,"linux"));
            mired.AgregarNodo(new Nodo("192.168.0.12","equipoactivo",2,12,"ios"));
            mired.AgregarNodo(new Nodo("192.168.0.20","computadora",8,5,"windows"));
            mired.AgregarNodo(new Nodo("192.168.0.20","servidor",10,22,"linux"));
            mired.nodos[0].AgregarVulnerabilidad(new Vulnerabilidad("CVE-2015-1635","microsoft",
            "HTTP.sys permite a atacantes remotos ejecutar código arbitrario", "remota", DateTime.Parse("14/04/2015")));
            
            mired.nodos[0].AgregarVulnerabilidad(new Vulnerabilidad("CVE-2017-0004","microsoft",
            "El servicio LSASS permite causar una denegación de servicio", "local", DateTime.Parse("01/10/2011")));
            
            mired.nodos[1].AgregarVulnerabilidad(new Vulnerabilidad("CVE-2017-3847","cisco",
            "Cisco Firepower Management Center XSS", "remota", DateTime.Parse("21/02/2017")));

            mired.nodos[2].AgregarVulnerabilidad(new Vulnerabilidad("CVE-2009-2504","microsoft",
            "Múltiples desbordamientos de enteros en APIs Microsoft .NET 1.1", "local", DateTime.Parse("13/11/2009")));

            mired.nodos[2].AgregarVulnerabilidad(new Vulnerabilidad("CVE-2016-7271","microsoft",
            "Elevación de privilegios Kernel Segura en Windows 10 Gold", "local", DateTime.Parse("20/12/2016")));
            
            mired.nodos[2].AgregarVulnerabilidad(new Vulnerabilidad("CVE-2017-2996","adobe",
            "Adobe Flash Player 24.0.0.194 corrupción de memoria explotable", "remota", DateTime.Parse("15/02/2017")));
            
            // Reporte
            Console.WriteLine("\n>> Datos generales de la red\n");
            Console.WriteLine($"Empresa: {mired.empresa}");
            Console.WriteLine($"Propietario: {mired.propietario}");
            Console.WriteLine($"Domicilio: {mired.domicilio}");
            Console.WriteLine($"Total nodos red: {mired.nodos.Count}");
            Console.WriteLine($"Total vulnerabilidades: {mired.TotVuln}");

            Console.WriteLine("\n>>Datos generales de los nodos");
            mired.nodos.ForEach(n => Console.WriteLine(n.ToString()));
            Console.WriteLine($"Mayor numero de saltos: {mired.Mayor}");
            Console.WriteLine($"Menor numero de saltos: {mired.Menor}");
            Console.WriteLine("\n>> Vulnerabilidades por nodo:");
            foreach (Nodo n in mired.nodos)
            {
                Console.WriteLine($"\n> Ip: {n.ip}, Tipo: {n.tipo}\n");
                n.vulnerabilidades.ForEach(v => Console.WriteLine(v.ToString()));
            }
        }
    }
}