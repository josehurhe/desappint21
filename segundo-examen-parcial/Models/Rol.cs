using System.ComponentModel.DataAnnotations;

namespace segundo_examen_parcial.Modelo
{
    public class Rol
    {
        [Key]
        public int Id { get; set; }
        [Required(ErrorMessage = "Se requiere el rol")]
        public string Nombre { get; set; }
    }
}