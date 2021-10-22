using System.ComponentModel.DataAnnotations;
using System.Collections.Generic;

namespace p21_universidadv1.Modelo
{
    public class Curso
    {
        [Key]
        public int CursoId { get; set; }
        [StringLength(40, MinimumLength=3)]
        public string Titulo { get; set; }
        [Range(1,7)]
        public int Creditos { get; set; }
        public Departamento Departamento { get; set; }
        public ICollection<Inscripcion> Inscripciones { get; set; }
        public ICollection<Instructor> Instructores { get; set; }
    }
}