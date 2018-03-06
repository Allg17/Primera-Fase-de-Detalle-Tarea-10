using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;

namespace Incripcion.Entidades
{
   public  class Articulos
    {
        [Key]
        public int ArticuloID { get; set; }
        public string Descripcion { get; set; }
        public decimal Precio { get; set; }
        public int ArticulosCotizados { get; set; }

        public Articulos(int articuloID, string descripcion, decimal precio, int articulosCotizados)
        {
            ArticuloID = articuloID;
            Descripcion = descripcion;
            Precio = precio;
            ArticulosCotizados = articulosCotizados;
        }

        public Articulos()
        {
            this.ArticuloID = 0;
            this.Descripcion = string.Empty;
            this.Precio = 0;
            this.ArticulosCotizados = 0;
        }
        public Articulos( string descripcion)
        {
            
            this.Descripcion = descripcion;
         
        }
    }
}
