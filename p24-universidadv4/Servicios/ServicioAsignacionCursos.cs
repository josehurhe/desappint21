using System.Collections.Generic;
using System.Linq;
using p24_universidadv4.Modelo;
using p24_universidadv4.Data;
using Microsoft.EntityFrameworkCore;
using System;

namespace p24_universidadv4.Servicio
{
    public class ServicioAsignacionCursos
    {
        private readonly UniContexto _contexto;
        public ServicioAsignacionCursos(UniContexto uniContexto) => _contexto = uniContexto;
        public List<AsignacionCurso> ObtenerTodo() => _contexto.AsignacionCursos
        .Include(c => c.Curso)
        .Include(i => i.Instructor)
        .ToList();
        public AsignacionCurso Obtener(int Id1, int Id2){
            AsignacionCurso asignacionCurso = _contexto.AsignacionCursos
            .FirstOrDefault(a => a.CursoId.Equals(Id1) && a.InstructorId.Equals(Id2));
            return asignacionCurso;
        }
        public bool Insertar(AsignacionCurso asignacionCurso){
            try{
                _contexto.AsignacionCursos.Add(asignacionCurso);
                _contexto.SaveChanges();
            } catch(Exception){
            }
            return true;
        }
        public bool Actualizar(AsignacionCurso asignacionCurso){
            _contexto.AsignacionCursos.Update(asignacionCurso);
            _contexto.SaveChanges();
            return true;
        }
        public bool Eliminar(AsignacionCurso asignacionCurso){
            _contexto.AsignacionCursos.Remove(asignacionCurso);
            _contexto.SaveChanges();
            return true;
        }
    }
}