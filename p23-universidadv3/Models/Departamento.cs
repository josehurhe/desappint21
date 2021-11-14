using System;
using System.ComponentModel.DataAnnotations;
using System.Collections.Generic;

namespace p23_universidadv3.Modelo
{
    public class Departamento
    {
        [Key]
        public int DepartamentoId { get; set; }
        public string Nombre { get; set; }
        [DataType(DataType.Currency)]
        public float Presupuesto { get; set; }
        [DataType(DataType.Date), DisplayFormat(DataFormatString="{0:yyyy-MM-dd}",ApplyFormatInEditMode=true)]
        public DateTime FechaDeInicio { get; set; }
        [Display(Name="Administrador")]
        public int? InstructorId { get; set; }
        public Instructor Instructor { get; set; }
        public ICollection<Curso> Cursos { get; set; }
    }
}