using System.ComponentModel.DataAnnotations;

namespace p21_universidadv1.Modelo
{
    public class Persona
    {
        [Key]
        public int Id { get; set; }
        [Required, StringLength(50), Display(Name="Apellido Paterno")]
        public string Apaterno { get; set; }
        [Required, StringLength(50), Display(Name="Apellido Materno")]
        public string Amaterno { get; set; }
        [Required, StringLength(50)]
        public string Nombre { get; set; }
        [RegularExpression(@"^[A-Za-z0-9._%+-]+@[A-Za-z0-9.-]+\.[A-Za-z]{2,4}$")]
        public string Email { get; set; }
        [Display(Name="Nombre Completo")]
        public string NombreCompleto {
            get {
                return $"{Apaterno} {Amaterno} {Nombre}";
            }
        }
    }
}