using System;
using System.Linq;
using segundo_examen_parcial.Modelo;

namespace segundo_examen_parcial.Data
{
    public class InicializaBD
    {
        public static void Inicializar(UniContexto contexto){
            contexto.Database.EnsureCreated();
            if (contexto.Actores.Any()){
                return;
            }
            
            // Agregar actores
            var actores = new Actor[]{
                new Actor{NombreCompleto="Jack Nicholson", Notas="Notas de Jack Nicholson"},
                new Actor{NombreCompleto="Marlon Brando", Notas="Notas de Marlon Brando"},
                new Actor{NombreCompleto="Charlton Heston", Notas="Notas de Charlton Heston"},
                new Actor{NombreCompleto="Johnny Depp", Notas="Notas de Johnny Depp"},
                new Actor{NombreCompleto="Nicholas Cage", Notas="Notas de Nicholas Cage"},
                new Actor{NombreCompleto="Halle Berry", Notas="Notas de Halle Berry"},
            };
            foreach(Actor a in actores) contexto.Actores.Add(a);
            contexto.SaveChanges();

            // Agregar generos
            var generos = new Genero[]{
                new Genero{Nombre="Comedia"},
                new Genero{Nombre="Terror"},
                new Genero{Nombre="Suspenso"},
                new Genero{Nombre="Ciencia Ficcion"},
                new Genero{Nombre="Romantico"},
                new Genero{Nombre="Drama"},
            };
            foreach(Genero g in generos) contexto.Generos.Add(g);
            contexto.SaveChanges();

            // Agregar certificados
            var certificados = new Certificado[]{
                new Certificado{Nombre="G"},
                new Certificado{Nombre="PG"},
                new Certificado{Nombre="PG-13"},
                new Certificado{Nombre="R"},
            };
            foreach(Certificado c in certificados) contexto.Certificados.Add(c);
            contexto.SaveChanges();

            // Agregar productores
            var productores = new Productor[]{
                new Productor{Nombre="Warner Media",Email="warnermedia@gmail.com",SitioWeb="warnermedia.com"},
                new Productor{Nombre="Sony Pictures",Email="sonypictures@gmail.com",SitioWeb="sonypictures.com"},
                new Productor{Nombre="Universal Studios",Email="universalstudios@gmail.com",SitioWeb="universalstudios.com"},
                new Productor{Nombre="Columbia Pictures",Email="columbiapictures@gmail.com",SitioWeb="columbiapictures.com"},
                new Productor{Nombre="New Line Cinema",Email="newlinecinema@gmail.com",SitioWeb="newlinecinema.com"},
            };
            foreach (Productor p in productores) contexto.Productores.Add(p);
            contexto.SaveChanges();

            // Agregar roles
            var roles = new Rol[]{
                new Rol{Nombre="Superheroe"},
                new Rol{Nombre="Villano"},
                new Rol{Nombre="Jugador"},
                new Rol{Nombre="Policia"},
                new Rol{Nombre="Estudiante"},
                new Rol{Nombre="Soldado"},
            };
            foreach(Rol r in roles) contexto.Roles.Add(r);
            contexto.SaveChanges();

            // Agregar peliculas
            var peliculas = new Pelicula[]{
                new Pelicula{Titulo="El Padrino",Historia="Historia del padrino",FechaLanzamiento=DateTime.Parse("1972-09-01"),Duracion=120,GeneroId=generos.Single(g => g.Nombre == "Drama").Id, CertificadoId=certificados.Single(c => c.Nombre == "PG").Id, InformacionAdicional="Informacion adicional del padrino"},
                new Pelicula{Titulo="Ciudadano Kane",Historia="Historia de Ciudadano Kane",FechaLanzamiento=DateTime.Parse("1941-09-01"),Duracion=150,GeneroId=generos.Single(g => g.Nombre == "Suspenso").Id, CertificadoId=certificados.Single(c => c.Nombre == "PG-13").Id, InformacionAdicional="Informacion adicional de Ciudadano Kane"},
                new Pelicula{Titulo="El mago de Oz",Historia="Historia de El mago de Oz",FechaLanzamiento=DateTime.Parse("1939-09-01"),Duracion=130,GeneroId=generos.Single(g => g.Nombre == "Ciencia Ficcion").Id, CertificadoId=certificados.Single(c => c.Nombre == "G").Id, InformacionAdicional="Informacion adicional de El mago de Oz"},
                new Pelicula{Titulo="Pulp Fiction",Historia="Historia de Pulp Fiction",FechaLanzamiento=DateTime.Parse("1994-09-01"),Duracion=140,GeneroId=generos.Single(g => g.Nombre == "Drama").Id, CertificadoId=certificados.Single(c => c.Nombre == "PG-13").Id, InformacionAdicional="Informacion adicional de Pulp Fiction"},
                new Pelicula{Titulo="Volver al futuro",Historia="Historia de Volver al futuro",FechaLanzamiento=DateTime.Parse("1984-09-01"),Duracion=145,GeneroId=generos.Single(g => g.Nombre == "Ciencia Ficcion").Id, CertificadoId=certificados.Single(c => c.Nombre == "PG").Id, InformacionAdicional="Informacion adicional de Volver al futuro"},
                new Pelicula{Titulo="Forrest Gump",Historia="Historia de Forrest Gump",FechaLanzamiento=DateTime.Parse("1994-09-01"),Duracion=120,GeneroId=generos.Single(g => g.Nombre == "Romantico").Id, CertificadoId=certificados.Single(c => c.Nombre == "PG-13").Id, InformacionAdicional="Informacion adicional de Forrest Gump"},
            };
            foreach(Pelicula p in peliculas) contexto.Peliculas.Add(p);
            contexto.SaveChanges();

            // Agregar peliculas de los productores
            var peliculasProductores = new PeliculaProductor[]{
                new PeliculaProductor{PeliculaId=peliculas.Single(p => p.Titulo == "El Padrino").Id,ProductorId=productores.Single(p => p.Nombre == "Warner Media").Id},
                new PeliculaProductor{PeliculaId=peliculas.Single(p => p.Titulo == "Ciudadano Kane").Id,ProductorId=productores.Single(p => p.Nombre == "Sony Pictures").Id},
                new PeliculaProductor{PeliculaId=peliculas.Single(p => p.Titulo == "El mago de Oz").Id,ProductorId=productores.Single(p => p.Nombre == "Universal Studios").Id},
                new PeliculaProductor{PeliculaId=peliculas.Single(p => p.Titulo == "Pulp Fiction").Id,ProductorId=productores.Single(p => p.Nombre == "Columbia Pictures").Id},
                new PeliculaProductor{PeliculaId=peliculas.Single(p => p.Titulo == "Volver al futuro").Id,ProductorId=productores.Single(p => p.Nombre == "New Line Cinema").Id},
                new PeliculaProductor{PeliculaId=peliculas.Single(p => p.Titulo == "Forrest Gump").Id,ProductorId=productores.Single(p => p.Nombre == "Warner Media").Id},
            };
            foreach(PeliculaProductor pp in peliculasProductores) contexto.PeliculaProductores.Add(pp);
            contexto.SaveChanges();

            // Agregar los personaje de los actores en las peliculas
            var peliculaActorRoles = new PeliculaActorRol[]{
                new PeliculaActorRol{PeliculaId=peliculas.Single(p => p.Titulo == "El Padrino").Id, ActorId=actores.Single(a => a.NombreCompleto == "Jack Nicholson").Id, RolId=roles.Single(r => r.Nombre == "Jugador").Id, Personaje="Personaje 1", DescripcionPersonaje="Descripcion personaje 1"},
                new PeliculaActorRol{PeliculaId=peliculas.Single(p => p.Titulo == "Ciudadano Kane").Id, ActorId=actores.Single(a => a.NombreCompleto == "Marlon Brando").Id, RolId=roles.Single(r => r.Nombre == "Policia").Id, Personaje="Personaje 2", DescripcionPersonaje="Descripcion personaje 2"},
                new PeliculaActorRol{PeliculaId=peliculas.Single(p => p.Titulo == "El mago de Oz").Id, ActorId=actores.Single(a => a.NombreCompleto == "Charlton Heston").Id, RolId=roles.Single(r => r.Nombre == "Estudiante").Id, Personaje="Personaje 2", DescripcionPersonaje="Descripcion personaje 3"},
                new PeliculaActorRol{PeliculaId=peliculas.Single(p => p.Titulo == "Pulp Fiction").Id, ActorId=actores.Single(a => a.NombreCompleto == "Johnny Depp").Id, RolId=roles.Single(r => r.Nombre == "Soldado").Id, Personaje="Personaje 3", DescripcionPersonaje="Descripcion personaje 4"},
                new PeliculaActorRol{PeliculaId=peliculas.Single(p => p.Titulo == "Volver al futuro").Id, ActorId=actores.Single(a => a.NombreCompleto == "Nicholas Cage").Id, RolId=roles.Single(r => r.Nombre == "Villano").Id, Personaje="Personaje 4", DescripcionPersonaje="Descripcion personaje 5"},
                new PeliculaActorRol{PeliculaId=peliculas.Single(p => p.Titulo == "Forrest Gump").Id, ActorId=actores.Single(a => a.NombreCompleto == "Halle Berry").Id, RolId=roles.Single(r => r.Nombre == "Estudiante").Id, Personaje="Personaje 5", DescripcionPersonaje="Descripcion personaje 6"},
            };
            foreach(PeliculaActorRol par in peliculaActorRoles) contexto.PeliculaActorRoles.Add(par);
            contexto.SaveChanges();
        }
    }
}