using System.ComponentModel.DataAnnotations;

namespace segundo_examen_parcial.Modelo
{
    public class Certificado
    {
        [Key]
        public int Id { get; set; }
        [Required(ErrorMessage = "Se requiere el certificado")]
        public string Nombre { get; set; }
    }
}