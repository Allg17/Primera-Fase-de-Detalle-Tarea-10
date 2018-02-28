using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;

namespace Incripcion.Entidades
{
    class Estudiantes
    {

        [Key]
        public int EstudianteId { get; set; }
        public string Nombre { get; set; }
        public string Observaciones { get; set; }
        public DateTime FechaActual { get; set; }
        public Estudiantes()
        {

            this.Nombre = string.Empty;
            this.Observaciones = string.Empty;
            this.FechaActual = DateTime.Now;

        }

        public Estudiantes(int EstudianteId, string nombres, string observaciones)
        {
            this.EstudianteId = EstudianteId;
            this.Nombre = nombres;
            this.Observaciones = observaciones;
            FechaActual = DateTime.Now;
        }
    }
}
