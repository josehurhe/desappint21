using Microsoft.EntityFrameworkCore;
using segundo_examen_parcial.Modelo;
using System.Collections.Generic;

namespace segundo_examen_parcial.Data
{
    public class UniContexto : DbContext
    {
        public UniContexto(DbContextOptions<UniContexto> opciones) : base(opciones){}
        public DbSet<Actor> Actores { get; set; }
        public DbSet<Certificado> Certificados { get; set; }
        public DbSet<Genero> Generos { get; set; }
        public DbSet<Pelicula> Peliculas { get; set; }
        public DbSet<PeliculaActorRol> PeliculaActorRoles { get; set; }
        public DbSet<PeliculaProductor> PeliculaProductores { get; set; }
        public DbSet<Productor> Productores { get; set; }
        public DbSet<Rol> Roles { get; set; }
        protected override void OnModelCreating(ModelBuilder mod){
            mod.Entity<PeliculaActorRol>().HasKey(k => new {k.PeliculaId, k.ActorId, k.RolId, k.Personaje});
            mod.Entity<PeliculaProductor>().HasKey(k => new {k.ProductorId, k.PeliculaId});
        }
    }
}