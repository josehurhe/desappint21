namespace segundo_examen_parcial.Modelo
{
    public class PeliculaActorRol
    {
        public int PeliculaId { get; set; }
        public Pelicula Pelicula { get; set; }
        public int ActorId { get; set; }
        public Actor Actor { get; set; }
        public int RolId { get; set; }
        public Rol Rol { get; set; }
        public string Personaje { get; set; }
        public string DescripcionPersonaje { get; set; }
    }   
}