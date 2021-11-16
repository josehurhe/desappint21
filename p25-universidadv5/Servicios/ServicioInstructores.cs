using System.Collections.Generic;
using System.Linq;
using p25_universidadv5.Modelo;
using p25_universidadv5.Data;
using Microsoft.EntityFrameworkCore;

namespace p25_universidadv5.Servicio
{
    public class ServicioInstructores
    {
        private readonly UniContexto _contexto;
        public ServicioInstructores(UniContexto uniContexto) => _contexto = uniContexto;
        public List<Instructor> ObtenerTodo(string cadenaBuscar) {
            var _instructores = _contexto.Instructores
            .Include(o => o.OficinaAsignada).Include(a => a.AsignacionCursos)
            .ThenInclude(c => c.Curso);

            var instructores = from i in _instructores select i;
            if(!string.IsNullOrEmpty(cadenaBuscar)){
                instructores = instructores.Where(e => e.Apaterno.ToLower()
                .Contains(cadenaBuscar.ToLower()) || e.Amaterno.ToLower()
                .Contains(cadenaBuscar.ToLower()));
            }
            return instructores.ToList();
        }
        public Instructor Obtener(int Id){
            Instructor Instructor = _contexto.Instructores.FirstOrDefault(e => e.Id.Equals(Id));
            return Instructor;
        }

        public bool Insertar(Instructor instructor){
            _contexto.Instructores.Add(instructor);
            _contexto.SaveChanges();
            return true;
        }

        public bool Actualizar(Instructor instructor){
            _contexto.Instructores.Update(instructor);
            _contexto.SaveChanges();
            return true;
        }

        public bool Eliminar(Instructor instructor){
            _contexto.Instructores.Remove(instructor);
            _contexto.SaveChanges();
            return true;
        }
    }
}