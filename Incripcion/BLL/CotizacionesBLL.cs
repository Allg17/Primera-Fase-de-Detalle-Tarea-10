using Incripcion.DAL;
using Incripcion.Entidades;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Linq.Expressions;
using System.Text;

namespace Incripcion.BLL
{
   public  class CotizacionesBLL
    {
        static int IDs=0;
        public static bool Guardar(Cotizaciones cotizacion)
        {
            bool paso = false;
            try
            {
                Contexto contex = new Contexto();
                if (contex.cotizaciones.Add(cotizacion) != null)
                {
                    contex.SaveChanges();
                    paso = true;
                }
                BuscarID(cotizacion);
                
            }
            catch (Exception)
            {

                throw;
            }
            return paso;
        }
        private static void BuscarID(Cotizaciones cotizaciones)
        {
            IDs = cotizaciones.ID;
            
        }
        public static int RetornarID()
        {
            return IDs;
        }
        public static  int calcularMonto(decimal cantidad , decimal precio)
        {
            int resultado;
            resultado = Convert.ToInt32(cantidad) * Convert.ToInt32(precio);

            return resultado;
        }

      
        public static bool Eliminar(int ID)
        {
            bool paso = false;
            try
            {
                Contexto contex = new Contexto();
                var cotizaciones = contex.cotizaciones.Find(ID);
                if (contex.cotizaciones.Remove(cotizaciones) != null)
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

        public static bool Modificar(Cotizaciones cotizaciones)
        {
            bool paso = false;

            try
            {
                Contexto contex = new Contexto();
                contex.Entry(cotizaciones).State = System.Data.Entity.EntityState.Modified;
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
        public static int CotisarMonto(List<CotizacionesDetalle> detalle)
        {
            int monto = 0;
            foreach (var cotisar in detalle)
            {
                monto += (Convert.ToInt32(cotisar.Precio) * cotisar.Cantidad);
            }

            return monto;
        }
        public static Cotizaciones Buscar(int ID)
        {
            Cotizaciones cotizaciones = new Cotizaciones();
            try
            {
                Contexto contex = new Contexto();
                cotizaciones = contex.cotizaciones.Find(ID);

            }
            catch (Exception)
            {

                throw;
            }
            return cotizaciones;
        }

        public static List<Cotizaciones> GetList(Expression<Func<Cotizaciones, bool>> cotizacione)
        {
            List<Cotizaciones> cotizaciones = new List<Cotizaciones>();
            try
            { 
            
                Contexto contex = new Contexto();
                cotizaciones = contex.cotizaciones.Where(cotizacione).ToList();

            }
            catch (Exception)
            {

                throw;
            }
            return cotizaciones;
        }
    }
}
