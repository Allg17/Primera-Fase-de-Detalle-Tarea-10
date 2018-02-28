using Incripcion.DAL;
using Incripcion.Entidades;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Linq.Expressions;
using System.Text;

namespace Incripcion.BLL
{
    public class CotizacionesDetalleBLL
    {
        public static bool Guardar(CotizacionesDetalle cotizacion)
        {
            bool paso = false;
            try
            {
                Contexto contex = new Contexto();
                if (contex.detalle.Add(cotizacion) != null)
                {
                    contex.SaveChanges();
                    paso = true;
                }
                

            }
            catch (Exception)
            {

                throw;
            }
            return paso;
        }

        public static bool Guardar(List<CotizacionesDetalle> cotizaciones)
        {

            bool paso = false;
            try
            {
                Contexto contex = new Contexto();

                foreach (var detalle in cotizaciones)
                {
                    detalle.CotizacionesID = BLL.CotizacionesBLL.RetornarID();
                   
                }

                if (contex.detalle.AddRange(cotizaciones) != null)
                {
                    contex.SaveChanges();
                    paso = true;
                }
    
            }
            catch (Exception)
            {

                throw;
            }
            return paso;
        }

        public static bool EliminarArticulos(int ID)
        {
            bool termino = false;
            List<CotizacionesDetalle> borrar = new List<CotizacionesDetalle>();

            borrar = GetList(tt => tt.CotizacionesID == ID);

            foreach (var eliminar in borrar)
            {
                if (Eliminar(eliminar.ID))
                {
                    termino = true;
                }

            }
            return termino;

        }

        public static List<CotizacionesDetalle> AgregarArticulo(List<CotizacionesDetalle> detalle,int articuloID,int cantidad, int importe, decimal precio, string descripcion)
        {
            CotizacionesDetalle cotisacion = new CotizacionesDetalle();
            
            
            foreach (var cotisar in detalle)
            {
         
               
                 if (cotisar.ArticuloID == articuloID)
                 {
                      cotisar.Cantidad += cantidad;
                      cotisar.Importe += importe;
                      break;
                 }

                if (detalle.Exists(x => x.ArticuloID == articuloID)==false)
                {
                    detalle.Add(new CotizacionesDetalle(cotisar.CotizacionesID, articuloID, cantidad, precio, descripcion, importe));
                    foreach (var detalles in detalle)
                    {
                        if(detalles.ArticuloID ==articuloID)
                        {
                            cotisacion = detalles;
                            break;
                        }
                    }

                    Guardar(cotisacion);
                    break;
                }

                
            }
            return detalle;   
        }

        public static List<CotizacionesDetalle> BuscarLista(int id)
        {
            List<CotizacionesDetalle> Cotizacion = new List<CotizacionesDetalle>();
            Articulos Articulo = new Articulos();
            int articulo;


            Cotizacion = GetList(tt => tt.CotizacionesID == id);

            foreach (var Detalle in Cotizacion)
            {
                articulo = Detalle.ArticuloID;
                Detalle.Importe = BLL.CotizacionesBLL.calcularMonto(Detalle.Cantidad, Detalle.Precio);
                Articulo = BLL.ArticulosBLL.Buscar(articulo);
                Detalle.Descripcion = Articulo.Descripcion;
                
            }

            return Cotizacion;
        }

        public static List<CotizacionesDetalle> ArreglarLista(int idDetalle, int id,int cantidad)
        {
            List<CotizacionesDetalle> Cotizacion = new List<CotizacionesDetalle>();
            Articulos Articulo = new Articulos();
            int articulo;
  

            Cotizacion = GetList(tt => tt.CotizacionesID == id);

            foreach (var Detalle in Cotizacion)
            {
                if(Detalle.ID==idDetalle)
                {
                     Detalle.Cantidad = cantidad;
                     Detalle.Importe = BLL.CotizacionesBLL.calcularMonto(cantidad, Detalle.Precio);
                     articulo = Detalle.ArticuloID;
                     Articulo = BLL.ArticulosBLL.Buscar(articulo);
                     Detalle.Descripcion = Articulo.Descripcion;
                }
                else
                {
                   
                    Detalle.Importe = BLL.CotizacionesBLL.calcularMonto(Detalle.Cantidad, Detalle.Precio);
                    articulo = Detalle.ArticuloID;
                    Articulo = BLL.ArticulosBLL.Buscar(articulo);
                    Detalle.Descripcion = Articulo.Descripcion;
                }
                
                
            }

            return Cotizacion;
        }



        public static bool Eliminar(int ID)
        {
            bool paso = false;
            try
            {
                Contexto contex = new Contexto();
                var elimina = contex.detalle.Find(ID);
                if (contex.detalle.Remove(elimina) != null)
                {
                    contex.SaveChanges();
                    paso = true;
                }
                
            }
            catch (Exception)
            {

                throw;
            }
            return paso;
        }
        public static bool Cambiar(List<CotizacionesDetalle> Cotisaciones, int id, int cantidad)
        {
            bool paso = false;
            foreach (var cotisar in Cotisaciones)
            {
                if (cotisar.ID == id)
                {
                    cotisar.Cantidad = cantidad;
                    cotisar.Importe = BLL.CotizacionesBLL.calcularMonto(cotisar.Cantidad, cotisar.Precio);
                    paso = true;
                    break;
                }
            }
            return paso;
        }

        public static CotizacionesDetalle ModificarArticulos(List<CotizacionesDetalle> Cotisaciones, int id)
        {

            CotizacionesDetalle cotisar = new CotizacionesDetalle();
            foreach (var Detalle in Cotisaciones)
            {
                if(Detalle.ID == id)
                {
                    cotisar = Detalle;
                    break;
                }
            }
            return cotisar;

        }
        
        

        public static bool Modificar(CotizacionesDetalle Cotisaciones)
        {
            bool paso = false;

            try
            {
                Contexto contex = new Contexto();
                
                contex.Entry(Cotisaciones).State = System.Data.Entity.EntityState.Modified;
                if (contex.SaveChanges() > 0)
                {
                    paso = true;
                }

            }
            catch (Exception)
            {

                throw;
            }
            return paso;
        }

        public static CotizacionesDetalle Buscar(int ID)
        {
            CotizacionesDetalle cotizaciones = new CotizacionesDetalle();
            try
            {
                Contexto contex = new Contexto();
                cotizaciones = contex.detalle.Find(ID);

            }
            catch (Exception)
            {

                throw;
            }
            return cotizaciones;
        }

        public static List<CotizacionesDetalle> GetList(Expression<Func<CotizacionesDetalle, bool>> cotizacione)
        {
            List<CotizacionesDetalle> cotizaciones = new List<CotizacionesDetalle>();
            try
            {

                Contexto contex = new Contexto();
                cotizaciones = contex.detalle.Where(cotizacione).ToList();

            }
            catch (Exception)
            {

                throw;
            }
            return cotizaciones;
        }
        public static CotizacionesDetalle BuscarDetalle(int id, int ID)
        {
            List<CotizacionesDetalle> detalle = new List<CotizacionesDetalle>();
            CotizacionesDetalle cotisar = new CotizacionesDetalle();
            detalle = GetList(tt => tt.CotizacionesID == id);

            foreach (var lista in detalle)
            {
                if (lista.ID == ID)
                {

                    var articulo = BLL.ArticulosBLL.Buscar(lista.ArticuloID);
                    lista.Descripcion = articulo.Descripcion;
                    cotisar = lista;
                    break;
                }
            }
            return cotisar;
            
        }
    }
}
