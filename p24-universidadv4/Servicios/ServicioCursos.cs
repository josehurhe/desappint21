using System.Collections.Generic;
using System.Linq;
using p24_universidadv4.Modelo;
using p24_universidadv4.Data;
using Microsoft.EntityFrameworkCore;

namespace p24_universidadv4.Servicio
{
    public class ServicioCursos
    {
        private readonly UniContexto _contexto;
        public ServicioCursos(UniContexto uniContexto) => _contexto = uniContexto;
        public List<Curso> ObtenerTodo() => _contexto.Cursos.Include(d => d.Departamento).ToList();
        public Curso Obtener(int Id){
            Curso curso = _contexto.Cursos.Include(d => d.Departamento).FirstOrDefault(e => e.CursoId.Equals(Id));
            return curso;
        }

        public bool Insertar(Curso curso){
            _contexto.Cursos.Add(curso);
            _contexto.SaveChanges();
            return true;
        }

        public bool Actualizar(Curso curso){
            _contexto.Cursos.Update(curso);
            _contexto.SaveChanges();
            return true;
        }

        public bool Eliminar(Curso curso){
            _contexto.Cursos.Remove(curso);
            _contexto.SaveChanges();
            return true;
        }
    }
}