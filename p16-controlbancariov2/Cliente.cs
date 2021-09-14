using System.Collections.Generic;

namespace p16_controlbancariov2
{
    public class Cliente{
        public Cliente(string nombre, string apellido)
        {
            this.nombre = nombre;
            this.apellido = apellido;
            cuentas = new List<CuentaBancaria>();
        }
        public string nombre { get; private set; }
        public string apellido { get; private set; }
        public List<CuentaBancaria> cuentas { get; set; }
        public void AgregarCuenta(CuentaBancaria cta){
            cuentas.Add(cta);
        }
    }
}