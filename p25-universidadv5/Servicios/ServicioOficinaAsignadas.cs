using System.Collections.Generic;
using System.Linq;
using p25_universidadv5.Modelo;
using p25_universidadv5.Data;
using Microsoft.EntityFrameworkCore;
using System;

namespace p25_universidadv5.Servicio
{
    public class ServicioOficinaAsignadas
    {
        private readonly UniContexto _contexto;
        public ServicioOficinaAsignadas(UniContexto uniContexto) => _contexto = uniContexto;
        public List<OficinaAsignada> ObtenerTodo() => _contexto.OficinaAsignadas
        .Include(i => i.Instructor)
        .ToList();
        public OficinaAsignada Obtener(int Id){
            OficinaAsignada oficinaAsignada = _contexto.OficinaAsignadas.FirstOrDefault(e => e.InstructorId.Equals(Id));
            return oficinaAsignada;
        }
        public bool Insertar(OficinaAsignada oficinaAsignada){
            try{
                _contexto.OficinaAsignadas.Add(oficinaAsignada);
                _contexto.SaveChanges();
            } catch (Exception){
            }
            return true;
        }
        public bool Actualizar(OficinaAsignada oficinaAsignada){
            try{
                _contexto.OficinaAsignadas.Update(oficinaAsignada);
                _contexto.SaveChanges();
            }catch(Exception){
            }
            return true;
        }
        public bool Eliminar(OficinaAsignada oficinaAsignada){
            _contexto.OficinaAsignadas.Remove(oficinaAsignada);
            _contexto.SaveChanges();
            return true;
        }
    }
}