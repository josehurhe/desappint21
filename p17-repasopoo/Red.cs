using System.Collections.Generic;
// using System.Linq;

namespace p17_repasopoo
{
    public class Red {
        public Red() => nodos = new List<Nodo>();
        public Red(string empresa, string propietario, string domicilio) : this() => 
        (this.empresa,this.propietario,this.domicilio) = (empresa,propietario,domicilio);

        public string empresa { get; private set; }
        public string propietario { get; private set; }
        public string domicilio { get; private set; }
        public List<Nodo> nodos { get; private set; }

        public int Mayor{
            get {
                int m = nodos[0].saltos;
                foreach (Nodo n in nodos)
                    if(n.saltos > m) m = n.saltos;
                return m;
            }
        }
        // public int Mayor {get => nodos.Min(n => n.saltos);}
        public int Menor{
            get {
                int m = nodos[0].saltos;
                foreach (Nodo n in nodos)
                    if(n.saltos < m) m = n.saltos;
                return m;
            }
        }

        public int TotVuln {
            get {
                int s = 0;
                foreach (Nodo n in nodos)
                    s = s + n.vulnerabilidades.Count;
                return s;
            }
        }
        public void AgregarNodo(Nodo n) => nodos.Add(n);
    }
}