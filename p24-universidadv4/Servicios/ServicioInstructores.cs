using System.Collections.Generic;
using System.Linq;
using p24_universidadv4.Modelo;
using p24_universidadv4.Data;
using Microsoft.EntityFrameworkCore;

namespace p24_universidadv4.Servicio
{
    public class ServicioInstructores
    {
        private readonly UniContexto _contexto;
        public ServicioInstructores(UniContexto uniContexto) => _contexto = uniContexto;
        public List<Instructor> ObtenerTodo() => _contexto.Instructores
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