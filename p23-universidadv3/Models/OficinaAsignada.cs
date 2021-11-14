using System.ComponentModel.DataAnnotations;

namespace p23_universidadv3.Modelo
{
    public class OficinaAsignada
    {
        [Key]
        public int InstructorId { get; set; }
        [StringLength(50), Display(Name="Ubicacion Oficina")]
        public string Ubicacion { get; set; }
        public Instructor Instructor { get; set; }
    }
} 