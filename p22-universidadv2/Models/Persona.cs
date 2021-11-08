using System.ComponentModel.DataAnnotations;

namespace p22_universidadv2.Modelo
{
    public class Persona
    {
        [Key]
        public int Id { get; set; }
        [Required(ErrorMessage="Se requiere apellido paterno"), StringLength(50, ErrorMessage="Longitud Maxima 50")]
        public string Apaterno { get; set; }
        [Required(ErrorMessage="Se requiere apellido materno"), StringLength(50, ErrorMessage="Longitud Maxima 50")]
        public string Amaterno { get; set; }
        [Required(ErrorMessage="Se requiere nombre"), StringLength(50, ErrorMessage="Longitud Maxima 50")]
        public string Nombre { get; set; }
        [EmailAddress(ErrorMessage="Email invalido")]
        public string Email { get; set; }
        public string NombreCompleto {
            get {
                return $"{Apaterno} {Amaterno} {Nombre}";
            }
        }
    }
}