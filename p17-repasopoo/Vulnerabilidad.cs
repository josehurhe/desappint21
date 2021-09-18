using System;

namespace p17_repasopoo
{
    public class Vulnerabilidad
    {
        public Vulnerabilidad(string clave, string vendedor, string descripcion, string tipo, DateTime fecha) =>
        (this.clave,this.vendedor,this.descripcion,this.tipo,this.fecha) = (clave,vendedor,descripcion,tipo,fecha);

        public string clave { get; private set; }
        public string vendedor { get; private set; }
        public string descripcion { get; private set; }
        public string tipo { get; private set; }
        public DateTime fecha { get; private set; }
        public int Antiguedad {
            get {
                return DateTime.Now.Year - fecha.Year;
            }
        }

        public override string ToString() =>
        $"Clave: {clave} Vendedor: {vendedor} Descripcion: {descripcion} Tipo: {tipo} "+
        $"Fecha: {fecha.ToString("dd/mm/yy")} Antiguedad: {Antiguedad.ToString()}";
    }
}