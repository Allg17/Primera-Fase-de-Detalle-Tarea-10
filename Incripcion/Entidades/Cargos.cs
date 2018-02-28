using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;


namespace Incripcion.Entidades
{
    class Cargos
    {
        [Key]
        public int CargoID { get; set; }
        public DateTime Fecha { get; set; }
        public int EstudianteID { get; set; }
        public string Concepto { get; set; }
        public decimal Monto { get; set; }
        public int Balance { get; set; }

        public Cargos(int cargoID, DateTime fecha, int estudianteID, string concepto, decimal monto, int balance)
        {
            this.CargoID = cargoID;
            this.Fecha = fecha;
            this.EstudianteID = estudianteID;
            this.Concepto = concepto;
            this.Monto = monto;
            this.Balance = balance;
        }

        public Cargos()
        {
            this.CargoID = 0;
            this.Fecha = DateTime.Now;
            this.EstudianteID = 0;
            this.Concepto = string.Empty;
            this.Monto = 0;
            this.Balance = 0;
        }
    }
}
