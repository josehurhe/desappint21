namespace segundo_examen_parcial.Modelo
{
    public class PeliculaProductor 
    {
        public int ProductorId { get; set; }
        public Productor Productor { get; set; }
        public int PeliculaId { get; set; }
        public Pelicula Pelicula { get; set; }
    }
}