using System.ComponentModel.DataAnnotations;

namespace segundo_examen_parcial.Modelo
{
    public class Genero
    {
        [Key]
        public int Id { get; set; }
        [Required(ErrorMessage = "Se requiere el genero")]
        public string Nombre { get; set; }
    }
}