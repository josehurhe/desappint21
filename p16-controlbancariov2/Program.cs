﻿using System;

namespace p16_controlbancariov2
{
    class Program
    {
        static void Main(string[] args)
        {
            Banco mibanco = new Banco("Banco del norte SA de CV","privada las cumbres 123");
            mibanco.AgregarCliente(new Cliente("Pedro","Perez"));
            mibanco.AgregarCliente(new Cliente("Juan","Villa"));
            mibanco.AgregarCliente(new Cliente("Rene","Ulises"));
            mibanco.AgregarCliente(new Cliente("Jose","Rodriguez"));

            mibanco.clientes[0].AgregarCuenta(new CuentaDeAhorro(1500,0.10f));
            mibanco.clientes[0].AgregarCuenta(new CuentaDeAhorro(2500,0.20f));
            mibanco.clientes[0].AgregarCuenta(new CuentaDeCheques(6500,500));
            mibanco.clientes[2].AgregarCuenta(new CuentaDeCheques(16500,1500));
            mibanco.clientes[1].AgregarCuenta(new CuentaDeCheques(2500,500));
            mibanco.clientes[2].AgregarCuenta(new CuentaDeAhorro(116500,0.40f));
            mibanco.clientes[3].AgregarCuenta(new CuentaDeAhorro(12500,0.30f));

            mibanco.clientes[1].cuentas[0].retira(3000);
            mibanco.clientes[2].cuentas[0].retira(17000);
            mibanco.clientes[2].cuentas[0].retira(1000);

            // Reporte de clientes del banco y el saldo de sus cuentas
            Console.WriteLine($"Reporte de clientes del banco {mibanco.nombre}, {mibanco.direccion}");
            Console.WriteLine($"Clientes {mibanco.clientes.Count}");

            foreach (Cliente cte in mibanco.clientes)
            {
                Console.WriteLine($"\nCliente: {cte.nombre}, {cte.apellido}, cuentas: {cte.cuentas.Count}");
                foreach (CuentaBancaria cta in cte.cuentas)
                {
                    Console.Write((cta is CuentaDeCheques) ? "Cuenta de Cheques" : "Cuenta de Ahorro");
                    if (cta is CuentaDeAhorro) (cta as CuentaDeAhorro).CalcularInteres();
                    Console.WriteLine($" con un saldo de {cta.saldo}");
                }
            }
        }
    }
}