using System.Collections.Generic;
using System.Linq;
using p25_universidadv5.Modelo;
using p25_universidadv5.Data;
using Microsoft.EntityFrameworkCore;

namespace p25_universidadv5.Servicio
{
    public class ServicioDepartamentos
    {
        private readonly UniContexto _contexto;
        public ServicioDepartamentos(UniContexto uniContexto) => _contexto = uniContexto;
        public List<Departamento> ObtenerTodo(string cadenaBuscar) {
            var _departamentos = _contexto.Departamentos.Include(i => i.Instructor);
            var departamentos = from d in _departamentos select d;
            if (!string.IsNullOrEmpty(cadenaBuscar)){
                departamentos = departamentos.Where(d => d.Nombre.ToLower().Contains(cadenaBuscar.ToLower()));
            }
            return departamentos.ToList();
        }
        public Departamento Obtener(int Id){
            Departamento departamento = _contexto.Departamentos.Include(i => i.Instructor).FirstOrDefault(e => e.DepartamentoId.Equals(Id));
            return departamento;
        }

        public bool Insertar(Departamento departamento){
            _contexto.Departamentos.Add(departamento);
            _contexto.SaveChanges();
            return true;
        }

        public bool Actualizar(Departamento departamento){
            _contexto.Departamentos.Update(departamento);
            _contexto.SaveChanges();
            return true;
        }

        public bool Eliminar(Departamento departamento){
            _contexto.Departamentos.Remove(departamento);
            _contexto.SaveChanges();
            return true;
        }
    }
}