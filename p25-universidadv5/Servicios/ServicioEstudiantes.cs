using System.Collections.Generic;
using System.Linq;
using p25_universidadv5.Modelo;
using p25_universidadv5.Data;
using Microsoft.EntityFrameworkCore;

namespace p25_universidadv5.Servicio
{
    public class ServicioEstudidantes
    {
        private readonly UniContexto _contexto;
        public ServicioEstudidantes(UniContexto uniContexto) => _contexto = uniContexto;
        public List<Estudiante> ObtenerTodo(string cadenaBuscar) {
            var _estudiantes = _contexto.Estudiantes.Include(i => i.Inscripciones)
            .ThenInclude(c => c.Curso);

            var estudiantes = from e in _estudiantes select e;
            if(!string.IsNullOrEmpty(cadenaBuscar)){
                estudiantes = estudiantes
                .Where(e => e.Apaterno.ToLower().Contains(cadenaBuscar) 
                || e.Amaterno.ToLower().Contains(cadenaBuscar.ToLower()));
            }
            return estudiantes.ToList();
        }
        public Estudiante Obtener(int Id){
            Estudiante estudiante = _contexto.Estudiantes.FirstOrDefault(e => e.Id.Equals(Id));
            return estudiante;
        }

        public bool Insertar(Estudiante estudiante){
            _contexto.Estudiantes.Add(estudiante);
            _contexto.SaveChanges();
            return true;
        }

        public bool Actualizar(Estudiante estudiante){
            _contexto.Estudiantes.Update(estudiante);
            _contexto.SaveChanges();
            return true;
        }

        public bool Eliminar(Estudiante estudiante){
            _contexto.Estudiantes.Remove(estudiante);
            _contexto.SaveChanges();
            return true;
        }
    }
}