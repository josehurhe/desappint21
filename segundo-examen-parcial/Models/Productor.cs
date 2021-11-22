using System.ComponentModel.DataAnnotations;

namespace segundo_examen_parcial.Modelo
{
    public class Productor
    {
        [Key]
        public int Id { get; set; }
        [Required(ErrorMessage = "Se requiere el nombre")]
        public string Nombre { get; set; }
        [EmailAddress(ErrorMessage = "Email invalido")]
        public string Email { get; set; }
        public string SitioWeb { get; set; }
    }
}