using System.Collections.Generic;

namespace p18_repasopoov2
{
    public class Nodo {
        public Nodo() => vulnerabilidades = new List<Vulnerabilidad>();
        public Nodo(string ip, string tipo, int puertos, int saltos, string so) : this() => 
        (this.ip,this.tipo,this.puertos,this.saltos,this.so) = (ip,tipo,puertos,saltos,so);

        public string  ip { get; set; }
        public string tipo { get; set; }
        public int puertos { get; set; }
        public int saltos { get; set; }
        public string so { get; set; }
        public List<Vulnerabilidad> vulnerabilidades { get; set; }

        public void AgregarVulnerabilidad(Vulnerabilidad v) => vulnerabilidades.Add(v);

        public override string ToString() => 
        $"Ip: {ip,-12} Tipo: {tipo,-12} Puertos: {puertos,-3} Saltos: {saltos,-3} So: {so,-8} TotalV: {vulnerabilidades.Count}";
    }
}