using System.Collections.Generic;
using System.Linq;
using p24_universidadv4.Modelo;
using p24_universidadv4.Data;
using Microsoft.EntityFrameworkCore;
using System;

namespace p24_universidadv4.Servicio
{
    public class ServicioInscripciones
    {
        private readonly UniContexto _contexto;
        public ServicioInscripciones(UniContexto uniContexto) => _contexto = uniContexto;
        public List<Inscripcion> ObtenerTodo() => _contexto.Inscripciones
        .Include(c => c.Curso)
        .Include(e => e.Estudiante)
        .ToList();
        public Inscripcion Obtener(int Id){
            Inscripcion inscripcion = _contexto.Inscripciones.FirstOrDefault(e => e.InscripcionId.Equals(Id));
            return inscripcion;
        }
        public bool Insertar(Inscripcion inscripcion){
            try{
                _contexto.Inscripciones.Add(inscripcion);
                _contexto.SaveChanges();
            }catch(Exception){
            }
            return true;
        }
        public bool Actualizar(Inscripcion inscripcion){
            _contexto.Inscripciones.Update(inscripcion);
            _contexto.SaveChanges();
            return true;
        }
        public bool Eliminar(Inscripcion inscripcion){
            _contexto.Inscripciones.Remove(inscripcion);
            _contexto.SaveChanges();
            return true;
        }
    }
}