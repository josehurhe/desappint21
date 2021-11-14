using System.Collections.Generic;
using System.Linq;
using p24_universidadv4.Modelo;
using p24_universidadv4.Data;
using Microsoft.EntityFrameworkCore;

namespace p24_universidadv4.Servicio
{
    public class ServicioEstudidantes
    {
        private readonly UniContexto _contexto;
        public ServicioEstudidantes(UniContexto uniContexto) => _contexto = uniContexto;
        public List<Estudiante> ObtenerTodo() => _contexto.Estudiantes
        .Include(i => i.Inscripciones)
        .ThenInclude(c => c.Curso).ToList();
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