using System;
using System.ComponentModel.DataAnnotations;
using System.Collections.Generic;

namespace p25_universidadv5.Modelo
{
    public class Estudiante : Persona
    {
        [DataType(DataType.Date)]
        public DateTime FechaIngreso { get; set; }
        public ICollection<Inscripcion> Inscripciones { get; set; }
    }
}