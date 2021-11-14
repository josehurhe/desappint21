using System.ComponentModel.DataAnnotations;

namespace p23_universidadv3.Modelo
{
    public class Inscripcion
    {
        [Key]
        public int InscripcionId { get; set; }
        [DisplayFormat(NullDisplayText="Sin calificar")]
        public float? Promedio { get; set; }
        public int CursoId { get; set; }
        public Curso Curso { get; set; }
        public int EstudianteId { get; set; }
        public Estudiante Estudiante { get; set; }
    }
}