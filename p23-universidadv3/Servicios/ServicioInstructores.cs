using System.Collections.Generic;
using System.Linq;
using p23_universidadv3.Modelo;
using p23_universidadv3.Data;
using Microsoft.EntityFrameworkCore;

namespace p23_universidadv3.Servicio
{
    public class ServicioInstructores
    {
        private readonly UniContexto _contexto;
        public ServicioInstructores(UniContexto uniContexto) => _contexto = uniContexto;
        public List<Instructor> ObtienerTodo() => _contexto.Instructores
        .Include(o => o.OficinaAsignada)
        .Include(a => a.AsignacionCursos)
        .ThenInclude(c => c.Curso).ToList();
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