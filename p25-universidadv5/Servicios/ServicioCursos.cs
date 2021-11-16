using System.Collections.Generic;
using System.Linq;
using p25_universidadv5.Modelo;
using p25_universidadv5.Data;
using Microsoft.EntityFrameworkCore;

namespace p25_universidadv5.Servicio
{
    public class ServicioCursos
    {
        private readonly UniContexto _contexto;
        public ServicioCursos(UniContexto uniContexto) => _contexto = uniContexto;
        public List<Curso> ObtenerTodo(string cadenaBuscar) {
            var _cursos = _contexto.Cursos.Include(d => d.Departamento);

            var cursos = from c in _cursos select c;
            if (!string.IsNullOrEmpty(cadenaBuscar)){
                cursos = _cursos.Where(c => c.Titulo.ToLower().Contains(cadenaBuscar.ToLower()));
            }
            return cursos.ToList();
        } 
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