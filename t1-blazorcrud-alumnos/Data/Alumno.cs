using System.ComponentModel.DataAnnotations;
using System;

namespace t1_blazorcrud_alumnos.Data
{
    public class Alumno
    {
        public Alumno(){}

        public Alumno(string Matricula, string Nombre, string primerApellido, string SegundoApellido, DateTime FechaNacimiento, string Genero)
        {
            this.Matricula = Matricula;
            this.Nombre = Nombre;
            this.PrimerApellido = PrimerApellido;
            this.SegundoApellido = SegundoApellido;
            this.FechaNacimiento = FechaNacimiento;
            this.Genero = Genero;
        }

        [Key]
        public int Id { get; set; }
        public string Matricula { get; set; }
        public string Nombre { get; set; }
        public string PrimerApellido { get; set; }
        public string SegundoApellido { get; set; }
        public DateTime FechaNacimiento { get; set; }
        public string Genero { get; set; }
    }
}