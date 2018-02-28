using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;

namespace Incripcion.Entidades
{
    class Pagos
    {   [Key]
        public int PagosID { get; set; }
        public DateTime Fecha { get; set; }
        public int EstudianteID { get; set; }
        public string Concepto { get; set; }
        public decimal Monto { get; set; }
        public List<PagosCargos> Detalle { get; set; }

        public Pagos(int pagosID, DateTime fecha, int estudianteID, string concepto, decimal monto)
        {
            this.PagosID = pagosID;
            this.Fecha = fecha;
            this.EstudianteID = estudianteID;
            this.Concepto = concepto;
            this.Monto = monto;
        }

        public Pagos()
        {
            this.PagosID = 0;
            this.Fecha = DateTime.Now;
            this.EstudianteID = 0;
            this.Concepto = string.Empty;
            this.Monto = 0;
        }
    }
}
