using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;

namespace Incripcion.Entidades
{
    class PagosCargos
    {
        [Key]
        public int ID { get; set; }
        public int PagosID { get; set; }
        public int CargoID { get; set; }
        public decimal Monto { get; set; }
        public float Saldo { get; set; }

        public PagosCargos(int iD, int pagosID, int cargoID, decimal monto, float saldo)
        {
            this.ID = iD;
            this.PagosID = pagosID;
            this.CargoID = cargoID;
            this.Monto = monto;
            this.Saldo = saldo;
        }

        public PagosCargos()
        {
            this.ID = 0;
            this.PagosID = 0;
            this.CargoID = 0;
            this.Monto = 0;
            this.Saldo = 0;
        }
    }
}
