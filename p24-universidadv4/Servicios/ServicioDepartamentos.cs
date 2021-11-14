using System.Collections.Generic;
using System.Linq;
using p24_universidadv4.Modelo;
using p24_universidadv4.Data;
using Microsoft.EntityFrameworkCore;

namespace p24_universidadv4.Servicio
{
    public class ServicioDepartamentos
    {
        private readonly UniContexto _contexto;
        public ServicioDepartamentos(UniContexto uniContexto) => _contexto = uniContexto;
        public List<Departamento> ObtenerTodo() => _contexto.Departamentos.Include(i => i.Instructor).ToList();
        public Departamento Obtener(int Id){
            Departamento departamento = _contexto.Departamentos.Include(i => i.Instructor).FirstOrDefault(e => e.DepartamentoId.Equals(Id));
            return departamento;
        }

        public bool Insertar(Departamento departamento){
            _contexto.Departamentos.Add(departamento);
            _contexto.SaveChanges();
            return true;
        }

        public bool Actualizar(Departamento departamento){
            _contexto.Departamentos.Update(departamento);
            _contexto.SaveChanges();
            return true;
        }

        public bool Eliminar(Departamento departamento){
            _contexto.Departamentos.Remove(departamento);
            _contexto.SaveChanges();
            return true;
        }
    }
}