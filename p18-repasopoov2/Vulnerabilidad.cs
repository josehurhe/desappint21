using System;

namespace p18_repasopoov2
{
    public class Vulnerabilidad
    {
        public Vulnerabilidad(){}
        public Vulnerabilidad(string clave, string vendedor, string descripcion, string tipo, DateTime fecha) =>
        (this.clave,this.vendedor,this.descripcion,this.tipo,this.fecha) = (clave,vendedor,descripcion,tipo,fecha);

        public string clave { get; set; }
        public string vendedor { get; set; }
        public string descripcion { get; set; }
        public string tipo { get; set; }
        public DateTime fecha { get; set; }
        public int Antiguedad {
            get {
                return DateTime.Now.Year - fecha.Year;
            }
        }

        public override string ToString() =>
        $"Clave: {clave,-12} Vendedor: {vendedor,-10} Descripcion: {descripcion,-63} Tipo: {tipo,-8} "+
        $"Fecha: {fecha.ToString("dd/mm/yy"),-8} Antiguedad: {Antiguedad.ToString()}";
    }
}