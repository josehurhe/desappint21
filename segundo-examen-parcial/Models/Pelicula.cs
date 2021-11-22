using System;
using System.ComponentModel.DataAnnotations;

namespace segundo_examen_parcial.Modelo
{
    public class Pelicula
    {
        [Key]
        public int Id { get; set; }
        [Required(ErrorMessage = "Se requiere el titulo")]
        public string Titulo { get; set; }
        public string Historia { get; set; }
        [DataType(DataType.Date), DisplayFormat(DataFormatString="{0:yyyy-MM-dd}",ApplyFormatInEditMode=true)]
        public DateTime FechaLanzamiento { get; set; }
        public int Duracion { get; set; }
        public int GeneroId { get; set; }
        public Genero Genero { get; set; }
        public int CertificadoId { get; set; }
        public Certificado Certificado { get; set; }
        public string InformacionAdicional { get; set; }
    }
}