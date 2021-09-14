using System.Collections.Generic;

namespace p16_controlbancariov2
{
    public class Banco{
        public Banco(string nombre, string direccion)
        {
            this.nombre = nombre;
            this.direccion = direccion;
            clientes = new List<Cliente>();
        }
        public string nombre { get; private set; }
        public string direccion { get; set; }
        public List<Cliente> clientes { get; private set; }
        public void AgregarCliente(Cliente cliente){
            clientes.Add(cliente);
        }
    }
}