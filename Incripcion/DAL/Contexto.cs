using Incripcion.Entidades;
using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Text;

namespace Incripcion.DAL
{
    class Contexto : DbContext
    {
        public DbSet<Estudiantes> Estudiante { get; set; }
        public DbSet<Cargos> Cargo { get; set; }
        public DbSet<Pagos> Pagos { get; set; }
        public DbSet<PagosCargos> PagoCargo { get; set; }
        public DbSet<Articulos> Articulo { get; set; }
        public DbSet<Cotizaciones> cotizaciones { get; set; }
        public DbSet<CotizacionesDetalle> detalle { get; set; }

        public Contexto() : base("ConStr")
        {
        }
    }
}
