using Microsoft.EntityFrameworkCore;
using System.Collections.Generic;
using p24_universidadv4.Modelo;

namespace p24_universidadv4.Data
{
    public class UniContexto : DbContext
    {
        public UniContexto(DbContextOptions<UniContexto> opciones) : base(opciones){}
        public DbSet<Curso> Cursos { get; set; }
        public DbSet<Departamento> Departamentos { get; set; }
        public DbSet<Estudiante> Estudiantes { get; set; }
        public DbSet<Inscripcion> Inscripciones { get; set; }
        public DbSet<Instructor> Instructores { get; set; }
        public DbSet<OficinaAsignada> OficinaAsignadas { get; set; }
        public DbSet<AsignacionCurso> AsignacionCursos { get; set; }
        protected override void OnModelCreating(ModelBuilder mod){
            mod.Entity<AsignacionCurso>().HasKey(k => new {k.CursoId, k.InstructorId});
        }
    }    
}