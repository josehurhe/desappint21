using System.ComponentModel.DataAnnotations;

namespace segundo_examen_parcial.Modelo
{
    public class Actor
    {
        [Key]
        public int Id { get; set; }
        [Required (ErrorMessage = "Se requiere nombre completo"), StringLength(100, ErrorMessage = "Longitud máxima de 50")]
        public string NombreCompleto { get; set;}
        public string Notas { get; set; }
    }
}